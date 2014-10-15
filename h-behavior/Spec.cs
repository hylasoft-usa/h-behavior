using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior
{
  /// <summary>
  /// This class represents utility methods to perform BDD-like testing over MsTests
  /// </summary>
  public abstract class Spec
  {
    /// <summary>
    /// Creates the test object that wraps the specified object. It can be later tested using specific test methods
    /// </summary>
    /// <typeparam name="T">The type of the specified object</typeparam>
    /// <param name="obj">The specified object to wrap inside a test object</param>
    /// <returns>A Test Object that wraps the specified object</returns>
    protected static TestObject<T> Expect<T>(T obj)
    {
      return new TestObject<T>(obj);
    }
  }
}
