using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Extensions
{
  /// <summary>
  /// Extensions to check Enumerables
  /// </summary>
  public static class EnumerableExtensions
  {
    /// <summary>
    /// Verifies that the specified sequence contains a specified element by using the default equality comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerbale</param>
    /// <param name="item">The object to check if it's contained in the test enumerable.</param>
    public static void ToContain<T, TEnum>(this TestObject<TEnum> test, T item)
      where TEnum : IEnumerable<T>
    {
      Assert.IsTrue(test.Obj.Contains(item));
    }

    /// <summary>
    /// Verifies that the specified sequence doesn't contain a specified element by using the default equality comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerbale</param>
    /// <param name="item">The object to check if it's not contained in the test enumerable.</param>
    public static void ToNotContain<T, TEnum>(this TestObject<TEnum> test, T item)
      where TEnum : IEnumerable<T>
    {
      Assert.IsFalse(test.Obj.Contains(item));
    }

    /// <summary>
    /// Verifies that the specified sequence contains a specified element by using a specified comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerbale</param>
    /// <param name="item">The object to check if it's contained in the test enumerable.</param>
    /// <param name="comparer">An equality comparer to compare values.</param>
    public static void ToContain<T, TEnum>(this TestObject<TEnum> test, T item, IEqualityComparer<T> comparer)
      where TEnum : IEnumerable<T>
    {
      Assert.IsTrue(test.Obj.Contains(item, comparer));
    }

    /// <summary>
    /// Verifies that the specified sequence doesn't contain a specified element by using a specified comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerable</param>
    /// <param name="item">The object to check if it's not contained in the test enumerable.</param>
    /// <param name="comparer">An equality comparer to compare values.</param>
    public static void ToNotContain<T, TEnum>(this TestObject<TEnum> test, T item, IEqualityComparer<T> comparer)
      where TEnum : IEnumerable<T>
    {
      Assert.IsFalse(test.Obj.Contains(item, comparer));
    }

    /// <summary>
    /// Verifies that all objects of a specified sequence are of a specific type.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerable</param>
    /// <param name="t">The type to verify for all objects.</param>
    public static void ToOnlyContainType<T, TEnum>(this TestObject<TEnum> test, Type t)
      where TEnum : IEnumerable<T>
    {
      Assert.IsTrue(test.Obj.All(i => i.GetType().IsInstanceOfType(t)));
    }

    /// <summary>
    /// Verifies that all objects of a specified sequence are not null.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerable</param>
    public static void IsAllNotNull<T, TEnum>(this TestObject<TEnum> test)
      where TEnum : IEnumerable<T>
    {
      Assert.IsFalse(test.Obj.Any(null));
    }

    /// <summary>
    /// Verifies that all objects of a specified sequence are unique.
    /// </summary>
    /// <typeparam name="T">The type of objects in the enumerable</typeparam>
    /// <typeparam name="TEnum">The enumerable for type T</typeparam>
    /// <param name="test">A Test object for the enumerable</param>
    public static void IsAllUnique<T, TEnum>(this TestObject<TEnum> test)
      where TEnum : IEnumerable<T>
    {
      Assert.AreEqual(test.Obj.Count(), test.Obj.Distinct<T>().Count());
    }
  }
}