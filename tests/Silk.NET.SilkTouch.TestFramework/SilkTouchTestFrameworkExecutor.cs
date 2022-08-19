// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ATTRIBUTION:
// THIS FILE IS A MODIFIED VERSION OF CODE FOUND AT
// https://www.meziantou.net/parallelize-test-cases-execution-in-xunit.htm
// AND https://github.com/meziantou/Meziantou.Xunit.ParallelTestFramework
// WITH A NUGET PACKAGE AT https://www.nuget.org/packages/Meziantou.Xunit.ParallelTestFramework/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Silk.NET.SilkTouch.TestFramework;

public sealed class SilkTouchTestFrameworkExecutor : XunitTestFrameworkExecutor
{

    public SilkTouchTestFrameworkExecutor(AssemblyName assemblyName, ISourceInformationProvider sourceInformationProvider, IMessageSink diagnosticMessageSink) : base(assemblyName, sourceInformationProvider, diagnosticMessageSink)
    {
    }

    protected override void RunTestCases
        (IEnumerable<IXunitTestCase> testCases, IMessageSink executionMessageSink, ITestFrameworkExecutionOptions executionOptions)
    {
        var newTestCases = AllInParallel(testCases);
        
        base.RunTestCases(newTestCases, executionMessageSink, executionOptions);
    }

    private IEnumerable<IXunitTestCase> AllInParallel(IEnumerable<IXunitTestCase> testCases)
    {
        return testCases.Select
        (
            x =>
            {
                var oldTestMethod = x.TestMethod;
                var oldTestClass = oldTestMethod.TestClass;
                var oldTestCollection = oldTestMethod.TestClass.TestCollection;

                if (oldTestCollection.CollectionDefinition != null || oldTestClass.Class.GetCustomAttributes
                            (typeof(CollectionAttribute))
                        .Any())
                    return x;

                return AssignToNewCollection(x);
            }
        );
    }

    private IXunitTestCase AssignToNewCollection(IXunitTestCase testCase)
    {
        static TestMethodDisplay GetTestMethodDisplay(TestMethodTestCase testCase)
        {
            return (TestMethodDisplay)typeof(TestMethodTestCase)
                .GetProperty("DefaultMethodDisplay", BindingFlags.Instance | BindingFlags.NonPublic)!
                .GetValue(testCase)!;
        }

        static TestMethodDisplayOptions GetTestMethodDisplayOptions(TestMethodTestCase testCase)
        {
            return (TestMethodDisplayOptions)typeof(TestMethodTestCase)
                .GetProperty("DefaultMethodDisplayOptions", BindingFlags.Instance | BindingFlags.NonPublic)!
                .GetValue(testCase)!;
        }
        
        var oldTestMethod = testCase.TestMethod;
        var oldTestClass = oldTestMethod.TestClass;
        var oldTestCollection = oldTestMethod.TestClass.TestCollection;

        // Create a new collection with a unique id for the test case.
        var newTestCollection = new TestCollection
        (
            oldTestCollection.TestAssembly,
            oldTestCollection.CollectionDefinition,
            displayName: $"{oldTestCollection.DisplayName} {oldTestCollection.UniqueID}"
        );
        newTestCollection.UniqueID = Guid.NewGuid();

        // Duplicate the test and assign it to the new collection
        var newTestClass = new TestClass(newTestCollection, oldTestClass.Class);
        var newTestMethod = new TestMethod(newTestClass, oldTestMethod.Method);
        switch (testCase)
        {
            // Used by Theory having DisableDiscoveryEnumeration or non-serializable data
            case XunitTheoryTestCase xunitTheoryTestCase:
                return new XunitTheoryTestCase
                (
                    DiagnosticMessageSink,
                    GetTestMethodDisplay(xunitTheoryTestCase),
                    GetTestMethodDisplayOptions(xunitTheoryTestCase),
                    newTestMethod
                );

            // Used by all other tests
            case XunitTestCase xunitTestCase:
                return new XunitTestCase
                (
                    DiagnosticMessageSink,
                    GetTestMethodDisplay(xunitTestCase),
                    GetTestMethodDisplayOptions(xunitTestCase),
                    newTestMethod,
                    xunitTestCase.TestMethodArguments
                );

            // TODO If you use custom attribute, you may need to add cases here

            default:
                throw new ArgumentOutOfRangeException("Test case " + testCase.GetType() + " not supported");
        }
    }
}
