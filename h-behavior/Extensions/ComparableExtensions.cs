using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Extensions
{
  /// <summary>
  /// Extensions to check for Comparisons
  /// </summary>
  public static class ComparableExtensions
  {
    /// <summary>
    /// Verifies that the object is less than the specified one
    /// </summary>
    /// <typeparam name="T">The type of objects to compare</typeparam>
    /// <typeparam name="TComp">The Comparer for type T</typeparam>
    /// <param name="test">A Test object for the comparer</param>
    /// <param name="item">An object to compare with the test object.</param>
    public static void ToBeLessThan<T, TComp>(this TestObject<TComp> test, T item)
      where TComp : IComparable<T>
    {
      Assert.IsTrue(test.Obj.CompareTo(item) < 0);
    }

    /// <summary>
    /// Verifies that the object is greater than the specified one
    /// </summary>
    /// <typeparam name="T">The type of objects to compare</typeparam>
    /// <typeparam name="TComp">The Comparer for type T</typeparam>
    /// <param name="test">A Test object for the comparer</param>
    /// <param name="item">An object to compare with the test object.</param>
    public static void ToBeGreaterThan<T, TComp>(this TestObject<TComp> test, T item)
      where TComp : IComparable<T>
    {
      Assert.IsTrue(test.Obj.CompareTo(item) > 0);
    }

  }
}