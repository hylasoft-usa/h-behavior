using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Extensions
{
  /// <summary>
  /// Extensions to check if exceptions are thrown
  /// </summary>
  public static class ExceptionExtensions
  {
    /// <summary>
    /// Expects an exception to be thrown when executing the action
    /// </summary>
    /// <typeparam name="T">The type of exception that is </typeparam>
    /// <param name="test">the test object that is expected to throw the exception</param>
    public static void ToThrowException<T>(this TestObject<Action> test) where T : Exception
    {
      if (test.Obj == null)
        throw new ArgumentNullException("test", "the function to evaluate cannot be null.");
      try
      {
        test.Obj();
        Assert.Fail();
      }
      catch (Exception e)
      {
        if (!(e is T))
          Assert.Fail();
      }
    }
  }

}