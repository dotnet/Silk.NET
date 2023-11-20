// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Silk.NET.SilkTouch.TestFramework;

public sealed class SilkTouchFrameworkDiscoverer : XunitTestFrameworkDiscoverer
{
    public SilkTouchFrameworkDiscoverer(
        IAssemblyInfo assemblyInfo,
        ISourceInformationProvider sourceProvider,
        IMessageSink diagnosticMessageSink,
        IXunitTestCollectionFactory? collectionFactory = null)
        : base(
            assemblyInfo,
            sourceProvider,
            diagnosticMessageSink,
            collectionFactory)
    {
    }

    protected override bool FindTestsForMethod
    (
        ITestMethod testMethod,
        bool includeSourceInformation,
        IMessageBus messageBus,
        ITestFrameworkDiscoveryOptions discoveryOptions
    )
    {
        var traits = testMethod.Method.GetCustomAttributes(typeof(TraitAttribute))
            .Select
            (
                x =>
                {
                    var args = x.GetConstructorArguments().ToArray();
                    var name = (string) args[0];
                    var value = (string) args[1];
                    return (name, value);
                }
            );
        foreach (var (name, value) in traits)
        {
            if (name is "Category" &&
                value is not "Integration" and not "Scraper" and not "Symbols" and not "Emitter" and not "TypeStore" and not "Type Resolution")
            {
                return this.ReportDiscoveredTestCase
                (
                    (ITestCase) new ExecutionErrorTestCase
                    (
                        this.DiagnosticMessageSink, TestMethodDisplay.ClassAndMethod, TestMethodDisplayOptions.None,
                        testMethod,
                        "Category " + value +
                        " is not a valid category. Allowed values are \"Integration\", \"Scraper\", \"Symbols\", \"Emitter\"."
                    ), includeSourceInformation, messageBus
                );
            }
                
            if (name is "Source Language" &&
                value is not "C++")
            {
                return this.ReportDiscoveredTestCase
                (
                    (ITestCase) new ExecutionErrorTestCase
                    (
                        this.DiagnosticMessageSink, TestMethodDisplay.ClassAndMethod, TestMethodDisplayOptions.None,
                        testMethod,
                        "Source Language " + value +
                        " is not a valid language. Allowed values are \"C++\"."
                    ), includeSourceInformation, messageBus
                );
            }
                
            if (name is "Target Language" &&
                value is not "C#")
            {
                return this.ReportDiscoveredTestCase
                (
                    (ITestCase) new ExecutionErrorTestCase
                    (
                        this.DiagnosticMessageSink, TestMethodDisplay.ClassAndMethod, TestMethodDisplayOptions.None,
                        testMethod,
                        "Target Language " + value +
                        " is not a valid language. Allowed values are \"C#\"."
                    ), includeSourceInformation, messageBus
                );
            }

            if (name is "Feature")
            {
                if (!SilkTouchTestFramework.Features.TryGetValue(value, out var flag))
                {
                    return this.ReportDiscoveredTestCase
                    (
                        (ITestCase) new ExecutionErrorTestCase
                        (
                            this.DiagnosticMessageSink, TestMethodDisplay.ClassAndMethod,
                            TestMethodDisplayOptions.None, testMethod,
                            "Feature Flag " + value + " is not a valid flag. Allowed values are " + String.Join
                                (", ", SilkTouchTestFramework.Features.Keys.Select(x => "\"" + x + "\"")) + "."
                        ), includeSourceInformation, messageBus
                    );
                }

                if (!flag)
                {
                    return this.ReportDiscoveredTestCase
                    (
                        (ITestCase) new DisabledTestCase
                        (
                            "Flag " + value + " is not enabled", this.DiagnosticMessageSink, TestMethodDisplay.ClassAndMethod,
                            TestMethodDisplayOptions.None, testMethod
                        ), includeSourceInformation, messageBus
                    );
                }
            }
        }
        return base.FindTestsForMethod(testMethod, includeSourceInformation, messageBus, discoveryOptions);
    }

    private sealed class DisabledTestCase : XunitTestCase
    {
        private readonly string _skipReason;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete
        (
            "Called by the de-serializer; should only be called by deriving classes for de-serialization purposes"
        )]
        public DisabledTestCase() : base()
        {
            _skipReason = "Generic Skip";
        }

        public DisabledTestCase
        (
            string skipReason,
            IMessageSink diagnosticMessageSink,
            TestMethodDisplay defaultMethodDisplay,
            TestMethodDisplayOptions defaultMethodDisplayOptions,
            ITestMethod testMethod,
            object[]? testMethodArguments = null
        ) : base
        (
            diagnosticMessageSink, defaultMethodDisplay, defaultMethodDisplayOptions, testMethod,
            testMethodArguments
        )
        {
            _skipReason = skipReason;
        }

        protected override string GetSkipReason(IAttributeInfo factAttribute)
        {
            return _skipReason;
        }
    }
}
