using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Extensions
{
  /// <summary>
  /// Extensions to check Strings
  /// </summary>
  public static class StringExtensions
  {
    /// <summary>
    /// Verifies that the specified string contains the specified substring
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="substring">The substring being searched for</param>
    public static void ToContain(this TestObject<string> test, string substring)
    {
      StringAssert.Contains(test.Obj, substring);
    }

    /// <summary>
    /// Verifies that the specified string does NOT match a specific regex
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="pattern">regex being searched for</param>
    public static void ToNotMatch(this TestObject<string> test, Regex pattern)
    {
      StringAssert.DoesNotMatch(test.Obj, pattern);
    }

    /// <summary>
    /// Verifies that the specified string ends with a specific substring
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="endstring">The substring being searched for</param>
    public static void ToEndWith(this TestObject<string> test, string endstring)
    {
      StringAssert.EndsWith(test.Obj, endstring);
    }

    /// <summary>
    /// Verifies that the specified string matches a specific regex
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="pattern">regex being searched for</param>
    public static void ToMatch(this TestObject<string> test, Regex pattern)
    {
      StringAssert.Matches(test.Obj, pattern);
    }

    /// <summary>
    /// Verifies that the specified string starts with a specific substring
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="startstring">The substring being searched for</param>
    public static void ToStartWith(this TestObject<string> test, string startstring)
    {
      StringAssert.StartsWith(test.Obj, startstring);
    }
  }
}