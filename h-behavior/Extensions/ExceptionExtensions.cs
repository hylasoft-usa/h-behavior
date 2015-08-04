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
    /// <typeparam name="T">The type of exception that is thrown or any of its supertype</typeparam>
    /// <param name="test">the test object that is expected to throw the exception</param>
    /// <param name="evaluate">callback predicate to evaluate the exception</param>
    public static void ToThrowException<T>(this TestObject<Action> test, Predicate<T> evaluate = null) where T : Exception
    {
      if (test.Obj == null)
        throw new ArgumentNullException("test", "the function to evaluate cannot be null.");
      try
      {
        test.Obj();
        Assert.Fail("No exception has been thrown");
      }
      catch (Exception e)
      {
        if (!(e is T))
          Assert.Fail("Exception " + e.GetType() + " is not of type " + typeof(T));
        // assert about the exception
        if (evaluate != null)
          Assert.IsTrue(evaluate((T)e));
      }
    }
  }

}