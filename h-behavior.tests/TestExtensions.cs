using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Hylasoft.Behavior.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hylasoft.Behavior.Tests
{
  [TestClass]
  public class TestExtensions : Spec
  {
    [TestMethod]
    public void BoolMethodsShoudWork()
    {
      Expect(true).ToBeTrue();
      Expect(false).ToBeFalse();
      Expect("a".Length == 1).ToBeTrue();
      Expect("a".Length == 2).ToBeFalse();
    }


    [TestMethod]
    public void ComparableMethodsShouldWork()
    {
      Expect(1).ToBeGreaterThan(0);
      Expect(2).ToBeLessThan(3);
      Expect("a").ToBeLessThan("b");
    }

    private class MinusComparer : IEqualityComparer<int>
    {
      public bool Equals(int x, int y)
      {
        return x == y - 1;
      }

      public int GetHashCode(int obj)
      {
        return 0;
      }
    }

    [TestMethod]
    public void EnumerableMethodsShouldWork()
    {
      var testList = new List<int> { 1, 2, 3 };
      var secondTestList = new List<int> { 1, 2, 3 };
      Expect(testList).ToContain(1);
      Expect(testList).ToNotContain(0);
      Expect(testList).ToNotContain(1, new MinusComparer());
      Expect(testList).ToContain(4, new MinusComparer());
      Expect(testList).ToOnlyContainType(typeof(int));
      Expect(testList).IsAllNotNull();
      Expect(testList).IsAllUnique();
      Expect(testList).IsEqual(secondTestList);
      secondTestList = new List<int> { 2, 3, 1 };
      Expect(testList).IsEquivalent(secondTestList);
    }

    [TestMethod]
    public void ExceptionMethodsShouldWork()
    {
      Expect<Action>(() => { throw new TypeLoadException(); }).ToThrowException<TypeLoadException>();
      //checking exception inheritance
      Expect<Action>(() => { throw new TypeLoadException(); }).ToThrowException<Exception>();

      // Dog fooding like a pro. checking null actions
      Expect<Action>(() => Expect<Action>(null).ToThrowException<Exception>())
        .ToThrowException<ArgumentNullException>();

      // More dog fooding! checking false positives
      Expect<Action>(() => Expect<Action>(() => { }).ToThrowException<TypeLoadException>())
        .ToThrowException<AssertFailedException>();
      Expect<Action>(() => Expect<Action>(() => { throw new AggregateException(); }).ToThrowException<TypeLoadException>())
        .ToThrowException<AssertFailedException>();
    }
  }
}
