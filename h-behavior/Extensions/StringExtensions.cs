using System;
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
    /// <param name="subString">The substring being searched for</param>
    public static void ToContain(this TestObject<String> test, String subString)
    {
      StringAssert.Contains(test.Obj, subString);
    }

    /// <summary>
    /// Verifies that the specified string does NOT match a specific regex
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="pattern">regex being searched for</param>
    public static void ToNotMatch(this TestObject<String> test, Regex pattern)
    {
      StringAssert.DoesNotMatch(test.Obj, pattern);
    }

    /// <summary>
    /// Verifies that the specified string ends with a specific substring
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="endString">The substring being searched for</param>
    public static void ToEndWith(this TestObject<String> test, String endString)
    {
      StringAssert.EndsWith(test.Obj, endString);
    }

    /// <summary>
    /// Verifies that the specified string matches a specific regex
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="pattern">regex being searched for</param>
    public static void ToMatch(this TestObject<String> test, Regex pattern)
    {
      StringAssert.Matches(test.Obj, pattern);
    }

    /// <summary>
    /// Verifies that the specified string starts with a specific substring
    /// </summary>
    /// <param name="test">The test string being verified</param>
    /// <param name="startString">The substring being searched for</param>
    public static void ToStartWith(this TestObject<String> test, String startString)
    {
      StringAssert.StartsWith(test.Obj, startString);
    }
  }
}