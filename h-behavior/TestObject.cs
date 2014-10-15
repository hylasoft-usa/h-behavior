using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior
{
  /// <summary>
  /// This class represent an object that can be tested against several methods
  /// </summary>
  /// <typeparam name="T">The type that the Test Object is tesing. based on the type, additional extension methods are available in the Hylasoft.Behavior.Extensions namespace</typeparam>
  public sealed class TestObject<T>
  {
    internal readonly T Obj;

    internal TestObject(T obj)
    {
      Obj = obj;
    }

    /// <summary>
    /// Verifies that two specified object variables refer to the same object. The assertion fails if they refer to different objects.
    /// </summary>
    /// <param name="expected">The object to compare to. This is the object the unit test expects.</param>
    public void ToBe(object expected)
    {
      Assert.AreSame(expected, Obj);
    }

    /// <summary>
    /// Verifies that two specified object variables refer to different objects. The assertion fails if they refer to the same object.
    /// </summary>
    /// <param name="expected">The object to compare to. This is the object the unit test expects.</param>
    public void ToNotBe(object expected)
    {
      Assert.AreNotSame(expected, Obj);
    }

    /// <summary>
    /// Verifies that two specified generic type data are equal by using the equality operator. The assertion fails if they are not equal.
    /// </summary>
    /// <param name="expected">The object to compare to. This is the object the unit test expects.</param>
    public void ToEqual(object expected)
    {
      Assert.AreEqual(expected, Obj);
    }

    /// <summary>
    /// Verifies that two specified generic type data are equal by using the equality operator. The assertion fails if they are not equal.
    /// </summary>
    /// <param name="expected">The object to compare to. This is the object the unit test expects.</param>
    public void ToEqual(T expected)
    {
      Assert.AreEqual(expected, Obj);
    }

    /// <summary>
    /// Verifies that two specified generic type data are not equal. The assertion fails if they are equal.
    /// </summary>
    /// <param name="expected">The object to compare to. This is the object the unit test expects.</param>
    public void ToNotEqual(object expected)
    {
      Assert.AreNotEqual(expected, Obj);
    }

    /// <summary>
    /// Verifies that the specified object is null. The assertion fails if it is not null.
    /// </summary>
    public void ToBeNull()
    {
      Assert.IsNull(Obj);
    }

    /// <summary>
    /// Verifies that the specified object is not null. The assertion fails if it is null.
    /// </summary>
    public void ToNotBeNull()
    {
      Assert.IsNotNull(Obj);
    }

    /// <summary>
    /// Verifies that the specified object is an instance of the specified type. The assertion fails if the type is not found in the inheritance hierarchy of the object.
    /// </summary>
    /// <param name="type">The type expected to be found in the inheritance hierarchy of the object</param>
    public void ToBeInstanceOf(Type type)
    {
      Assert.IsInstanceOfType(Obj, type);
    }

    /// <summary>
    /// Verifies that the specified object is not an instance of the specified type. The assertion fails if the type is found in the inheritance hierarchy of the object.
    /// </summary>
    /// <param name="type">The type expected to be found in the inheritance hierarchy of the object</param>
    public void ToNotBeInstanceOf(Type type)
    {
      Assert.IsNotInstanceOfType(Obj, type);
    }
  }
}