# Introduction

Unit testing is an integral part of any successful software project.  But tests can often be time consuming to write and difficult to maintain.  The Emarkm Test Framework is a library designed to make the mundane aspects of object creation and mocking of classes (the "Arrange" part) easy, uniform and maintainable.

The framework uses the following technologies to enable rapid development and easy to maintain tests.  XUnit Theories are combined with AutoFixture and the Moq mocking framework to create an easy to use declarative style of unit testing code.

- [XUnit](https://xunit.github.io/) - unit test framework 
- [Moq](https://github.com/moq/moq4) - mocking framework
- [AutoFixture](https://github.com/AutoFixture/AutoFixture) - make "Arrange" phase of unit tests maintainable

# Getting Started
These packages are available:
- [TestFramework](https://www.nuget.org/packages/Emarkm.TestFramework/) - the main framework package
- [TestFramework.Data](https://www.nuget.org/packages/Emarkm.TestFramework.Data/) - auto filling objects with realistic data
- [TestFramework.Moq](https://www.nuget.org/packages/Emarkm.TestFramework.Moq/) - for easy to write mock using the Moq library
- [TestFramework.Resolve](https://www.nuget.org/packages/Emarkm.TestFramework.Resolve/) - Resolve components in your tests using a dependency injection tool
