using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Extensions
{
  /// <summary>
  /// Extensions to check for boolean values
  /// </summary>
  public static class BooleanExtensions
  {
    /// <summary>
    /// Verifies that the specified condition is false. The assertion fails if the condition is true.
    /// </summary>
    /// <param name="test">A boolean test object</param>
    public static void ToBeFalse(this TestObject<bool> test)
    {
      Debug.Assert(test != null, "test != null");
      Assert.IsFalse(test.Obj);
    }

    /// <summary>
    /// Verifies that the specified condition is true. The assertion fails if the condition is false.
    /// </summary>
    /// <param name="test">A boolean test object</param>
    public static void ToBeTrue(this TestObject<bool> test)
    {
      Assert.IsTrue(test.Obj);
    }
  }
}