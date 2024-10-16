This is a NUnit-based test framework that uses c-sharp, .NET Core(3.1), RestSharp(112.1.0), NUnit(3.13.1) and NUnit3TestAdapter(3.17.0)

What is NUnit?
	- NUnit is a unit-testing framework for all .Net languages. Initially ported from JUnit, the current production release, version 3 
	- For more info see https://nunit.org/
	

Components of BDD
	-NUnit File - .cs
		- SetUp
		- Test
		

What libraries are used?
	- Following add-ons need to be installed.
	1. NUnit 
		- Get library + adapter both via Nuget
	2. RestSharp
                - Get library via Nuget


How to run command line
	- locate the output path post compilation
	- use command: 
		dotnet test BossTestFramework.dll
	- for more info see https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test
