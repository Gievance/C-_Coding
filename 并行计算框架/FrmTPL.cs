using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 并行计算框架
{
    public partial class FrmTPL : Form
    {
        public FrmTPL()
        {
            InitializeComponent();
        }

        // bug1 : cts执行Cancel方法后，就失效了；
        CancellationTokenSource cts = new CancellationTokenSource();
        private bool status = false;
        
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if(!status)
            {
                status = true;
                CancellationToken token = cts.Token;
                decimal cal_res = 0.0M;
                tbInfo.Text = "";
                tbInfo.Text = "开始日志记录...";

                Task<decimal> t1 = Task.Run(async () =>
                {
                    // tbInfo.Text.Append();
                    decimal res = 0;
                    for (int i = 1; i < 8000000; i++)
                    {
                        res += i;
                        await Task.Delay(10);

                        // bug2 没有使用token.ThrowIfCancellationRequested()，不会抛出异常，无法区分用户取消还是异常
                        if (token.IsCancellationRequested)
                            break;
                    }

                    return res;
                }, token
                );

                Task<decimal> t2 = Task.Run(async () =>
                {
                    decimal res = 0;
                    for (int i = 1; i < 10000000; i++)
                    {
                        res += i;
                        await Task.Delay(10);
                        if (token.IsCancellationRequested)
                            break;
                    }
                    return res;
                }
                , token);

                tbInfo.AppendText(Environment.NewLine + "开始执行任务..");
                try
                {   
                    await Task.WhenAll(t1, t2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"并行计算失败：{ex.Message}");
                }

                tbInfo.AppendText(Environment.NewLine + "结束执行任务..");

                // bug3: 不需要使用.Result。WhenALl可以返回结果
                cal_res = t1.Result + t2.Result;
                tbInfo.AppendText(Environment.NewLine + $"任务结果总和：{cal_res.ToString()}");

                status = false;
            }
            else
            {
                tbInfo.AppendText(Environment.NewLine + "任务正在执行中，请勿重复执行..");
            }
            

            
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            // bug4: Cancel并没有真正结束任务执行，不能直接设置status为false
            status = false;
            tbInfo.AppendText(Environment.NewLine + "用户手动取消计算");
            // bug5: 没有释放cts资源
        }
    }
}
