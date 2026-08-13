using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 并行计算框架
{
    public partial class FrmTPL_Corrected : Form
    {
        public FrmTPL_Corrected()
        {
            InitializeComponent();
        }

        //不要在这里new CancellationTokenSource！
        private CancellationTokenSource _cts;
        private bool _isRunning = false;

        #region 计算任务
        /// <summary>
        /// CPU累加计算，支持取消
        /// </summary>
        private decimal CalcWork(int maxNum, CancellationToken token)
        {
            decimal res = 0;
            for (int i = 1; i < maxNum; i++)
            {
                //检测取消，取消直接抛异常退出任务
                token.ThrowIfCancellationRequested();
                res += i;

            }
            return res;
        }
        #endregion

        #region 按钮事件
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                tbInfo.AppendText(Environment.NewLine + "任务正在执行中，请勿重复执行..");
                return;
            }

            _isRunning = true;
            tbInfo.Text = "";
            tbInfo.AppendText("开始日志记录..." + Environment.NewLine);

            // ✅每次启动任务，新建 CancellationTokenSource
            using (_cts = new CancellationTokenSource())
            {
                var token = _cts.Token;

                tbInfo.AppendText("开始执行任务.." + Environment.NewLine);

                Task<decimal> t1 = Task.Run(() => CalcWork(80000000, token), token);
                Task<decimal> t2 = Task.Run(() => CalcWork(100000000, token), token);

                try
                {
                    //等待两个任务全部完成
                    decimal[] results = await Task.WhenAll(t1, t2);
                    decimal cal_res = results[0] + results[1];

                    tbInfo.AppendText("结束执行任务.." + Environment.NewLine);
                    tbInfo.AppendText($"任务结果总和：{cal_res}" + Environment.NewLine);
                }
                catch (OperationCanceledException)
                {
                    tbInfo.AppendText(Environment.NewLine + ">>> 用户手动取消计算");
                }
                catch (Exception ex)
                {
                    tbInfo.AppendText(Environment.NewLine + $"并行计算失败：{ex.Message}");
                }
            }
            //using结束，自动调用_cts.Dispose()释放资源

            _isRunning = false; //✅任务真正结束，才恢复状态
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
                tbInfo.AppendText(Environment.NewLine + "已发送取消信号...");
            }
        }

        #endregion
    }
}