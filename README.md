h-behavior
==========

Behavior Driven Development (BDD) wrapper for .NET MsTests

## Requirements
h-dependency works with .NET Framework 4.5 and higher

## Usage

To use it, make your unit test class inherit from `Hylasoft.Behavior.Spec`:

````C#
[TestClass]
public class TestBehavior : Spec{

  //Your tests here

}
````

In your tests, instead of using `Assert` use the `Expect().To...` Syntax:

````C#
Expect(myBooleanValue).ToBeTrue();
Expect(myString).ToBe("qwertyuiop");
Expect(myInteger).ToNotBeInstanceOf(typeof(string));
Expect<Action>(MyFaultyMethod).ToThrowException<TypeLoadException>();
````

The following extensions are available if you include the namespace `Hylasoft.Behavior.Extensions`:

- Exceptions
- Enumerables and Collections
- Comparable
- Booleans

## Build

You can build the project using Visual Studio or by running the grunt tasks for `msbuild`

## Contribute

You can contribute by opening a pull request. Make sure your code complies with the quality standards by running the following task:

    grunt test

## Nuget

A [nuget package](https://www.nuget.org/packages/Hylasoft.Behavior/) is available. To install Hylasoft.Behavior, run the following command in the Package Manager Console:

    PM> Install-Package Hylasoft.Behavior
