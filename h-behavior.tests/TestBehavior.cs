using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Tests
{
  [TestClass]
  public class TestBehavior : Spec
  {
    private struct TestStruct
    {
      public string S;
    }

    [TestMethod]
    public void ToBeMethodsShouldWork()
    {
      var testObj = new object();
      var testStruct1 = new TestStruct { S = "a" };
      var testStruct2 = new TestStruct { S = "b" };
      var testStruct3 = new TestStruct { S = "b" };

      Expect(1).ToBe(1);
      Expect(testObj).ToBe(testObj);
      Expect("asdwe").ToBe("asdwe");
      Expect(testStruct2).ToBe(testStruct3);
      Expect(testStruct2).ToBe(testStruct2);
      Expect(1).ToNotBe(2);
      Expect(testObj).ToNotBe(new object());
      Expect("asdwe").ToNotBe("asdasa");
      Expect(testStruct2).ToNotBe(testStruct1);
    }

    [TestMethod]
    public void ToBeSameMethodsShouldWork()
    {
      var testObj = new object();
      var testStruct1 = new TestStruct { S = "a" };

      Expect(testObj).ToBeSame(testObj);
      Expect(testObj).ToNotBeSame(new object());
      Expect(1).ToNotBeSame(1);
      Expect(1).ToNotBeSame(2);
      Expect(testStruct1).ToNotBeSame(testStruct1);
    }

    [TestMethod]
    public void ToBeNullMethodsShouldWork()
    {
      var testObj = new object();
      object nullObj = null;

      Expect(testObj).ToNotBeNull();
      Expect(nullObj).ToBeNull();
    }

    [TestMethod]
    public void ToBeInstanceOfMethodsShouldWork()
    {
      Expect("asdasd").ToBeInstanceOf(typeof(object));
      Expect("ads").ToBeInstanceOf(typeof(string));
      Expect(new object()).ToNotBeInstanceOf(typeof(int));
      Expect(2).ToNotBeInstanceOf(typeof(Exception));
    }
  }
}
