using System;
using System.Collections.Generic;
using System.Text;

using System.Text.RegularExpressions;
namespace AdvanceGrammar
{
    /// <summary>
    /// 学习正则表达式
    /// 通过Regex.调用下面静态方法
    /// 1. 静态方法: bool IsMatch()  判断指定字符串是否与正则表达式模式匹配
    /// 1.1 bool IsMatch(string input,string pattern)
    /// 1.2 bool IsMatch(string input, string pattern,RegexOptions options)
    /// 1,3 bool IsMatch(string input, string pattern, RegexOptions options,TimeSpan matchTiemout)
    /// 
    /// 2. 静态方法：Match Match()   返回指定字符串中第一个匹配模式的匹配项
    /// 2.1 Match Match(string input,string pattern)
    /// 2.2 Match Match(string input, string pattern,RegexOptions options)
    /// 2,3 Match Match(string input, string pattern, RegexOptions options,TimeSpan matchTiemout)
    /// 
    /// 3. 静态方法：Match Matches()   返回指定字符串中所有匹配模式的匹配项
    /// 3.1 MatchCollection Matches(string input,string pattern)
    /// 3.2 MatchCollection Matches(string input, string pattern,RegexOptions options)
    /// 3,3 MatchCollection Matches(string input, string pattern, RegexOptions options,TimeSpan matchTiemout)
    /// 
    /// 4. 静态方法：Replace函数    匹配模式的字符串进行替换
    /// 4,1 Replace(string input,string pattern, string replacement)
    /// 4.2 Replace(string input,string pattern, string replacement,RegexOptions options)
    /// 
    /// 5. 静态方法：Split          拆分文本
    /// 5.1 string[] Split(string input, string pattern)
    /// 5.2 string[] Split(string input, string pattern,RegexOptions options)
    /// 5.3 string[] Split(string input, string pattern,RegexOptions options,TimeSpan matchTiemout)
    /// </summary>
    internal class RegularExpression
    {
    }
}
