using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace Hylasoft.Behavior.Extensions
{
  /// <summary>
  /// Extensions to check Collections
  /// </summary>
  public static class EnumerableExtensions
  {
    /// <summary>
    /// Verifies that the specified sequence contains a specified element by using the default equality comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the enumerbale</param>
    /// <param name="item">The object to check if it's contained in the test collection.</param>
    public static void ToContain<T, TEnum>(this TestObject<TEnum> test, T item)
      where TEnum : ICollection<T>
    {
      Assert.IsTrue(test.Obj.Contains(item));
    }

    /// <summary>
    /// Verifies that the specified sequence doesn't contain a specified element by using the default equality comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the enumerbale</param>
    /// <param name="item">The object to check if it's not contained in the test collection.</param>
    public static void ToNotContain<T, TEnum>(this TestObject<TEnum> test, T item)
      where TEnum : ICollection<T>
    {
      Assert.IsFalse(test.Obj.Contains(item));
    }

    /// <summary>
    /// Verifies that the specified sequence contains a specified element by using a specified comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the enumerbale</param>
    /// <param name="item">The object to check if it's contained in the test collection.</param>
    /// <param name="comparer">An equality comparer to compare values.</param>
    public static void ToContain<T, TEnum>(this TestObject<TEnum> test, T item, IEqualityComparer<T> comparer)
      where TEnum : ICollection<T>
    {
      Assert.IsTrue(test.Obj.Contains(item, comparer));
    }

    /// <summary>
    /// Verifies that the specified sequence doesn't contain a specified element by using a specified comparer.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the collection</param>
    /// <param name="item">The object to check if it's not contained in the test collection.</param>
    /// <param name="comparer">An equality comparer to compare values.</param>
    public static void ToNotContain<T, TEnum>(this TestObject<TEnum> test, T item, IEqualityComparer<T> comparer)
      where TEnum : ICollection<T>
    {
      Assert.IsFalse(test.Obj.Contains(item, comparer));
    }

    /// <summary>
    /// Verifies that all objects of a specified sequence are of a specific type.
    /// </summary>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the collection</param>
    /// <param name="t">The type to verify for all objects.</param>
    public static void ToOnlyContainType<TEnum>(this TestObject<TEnum> test, Type t)
      where TEnum : ICollection
    {
        CollectionAssert.AllItemsAreInstancesOfType(test.Obj,t);
    }

    /// <summary>
    /// Verifies that all objects of a specified sequence are not null.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the collection</param>
    public static void IsAllNotNull<TEnum>(this TestObject<TEnum> test)
      where TEnum : ICollection
    {
      CollectionAssert.AllItemsAreNotNull(test.Obj);
    }

    /// <summary>
    /// Verifies that all objects of a specified sequence are unique.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">A Test object for the collection</param>
    public static void IsAllUnique<TEnum>(this TestObject<TEnum> test)
      where TEnum : ICollection
    {
      CollectionAssert.AllItemsAreUnique(test.Obj);
    }

    /// <summary>
    /// Verifies that two sequences have the same objects in the same order.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">The first sequence being compared</param>
    /// <param name="expected">The second sequence being compared</param>
    public static void IsEqual<TEnum>(this TestObject<TEnum> test, TEnum expected)
      where TEnum : ICollection
    {
      CollectionAssert.AreEqual(test.Obj, expected);
    }


    /// <summary>
    /// Verifies that two sequences have the same objects, but not necessarily in the same order.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">The first sequence being compared</param>
    /// <param name="expected">The second sequence being compared</param>
    public static void IsEquivalent<TEnum>(this TestObject<TEnum> test, TEnum expected)
      where TEnum : ICollection
    {
      CollectionAssert.AreEquivalent(test.Obj, expected);
    }

    /// <summary>
    /// Verifies that two sequences do NOT have the same objects in the same order.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">The first sequence being compared</param>
    /// <param name="expected">The second sequence being compared</param>
    public static void IsNotEqual<TEnum>(this TestObject<TEnum> test, TEnum expected)
      where TEnum : ICollection
    {
      CollectionAssert.AreNotEqual(test.Obj, expected);
    }

    /// <summary>
    /// Verifies that two sequences DO NOT have the same objects, even if in a different order.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">The first sequence being compared</param>
    /// <param name="expected">The second sequence being compared</param>
    public static void IsNotEquivalent<TEnum>(this TestObject<TEnum> test, TEnum expected)
      where TEnum : ICollection
    {
      CollectionAssert.AreNotEquivalent(test.Obj, expected);
    }

    /// <summary>
    /// Verifies that the test sequence is a subset of another sequence.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">The first sequence being compared</param>
    /// <param name="expected">The second sequence being compared</param>
    public static void IsSubsetOf<TEnum>(this TestObject<TEnum> test, TEnum expected)
      where TEnum : ICollection
    {
      CollectionAssert.IsSubsetOf(test.Obj, expected);
    }

    /// <summary>
    /// Verifies that the test sequence is NOT a subset of another sequence.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection</typeparam>
    /// <typeparam name="TEnum">The collection for type T</typeparam>
    /// <param name="test">The first sequence being compared</param>
    /// <param name="expected">The second sequence being compared</param>
    public static void IsNotSubsetOf<TEnum>(this TestObject<TEnum> test, TEnum expected)
      where TEnum : ICollection
    {
      CollectionAssert.IsNotSubsetOf(test.Obj, expected);
    }
  }
}