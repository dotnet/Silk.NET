using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Silk.NET.SilkTouch.TestFramework
{
    public class SilkTouchTestFramework : XunitTestFramework
    {
        public static readonly Dictionary<string, Func<string, bool>> TraitVerifiers = new()
        {
            ["Category"] = s => s is "Integration" or "Scraper" or "Symbols" or "Emitter",
            ["Feature"] = s => s is "Enums" or "Fields" or "Fixed-Size Arrays" or "Inheritance" or "Namespaces" or "Nested Types" or "Structs" or "Unions",
            ["Source Language"] = s => s is "C++",
            ["Target Language"] = s => s is "C#",
        };
        
        public SilkTouchTestFramework(IMessageSink messageSink)
            : base(messageSink)
        {
        }

        protected override ITestFrameworkDiscoverer CreateDiscoverer(
            IAssemblyInfo assemblyInfo)
            => new SilkTouchFrameworkDiscoverer(
                assemblyInfo,
                SourceInformationProvider,
                DiagnosticMessageSink);
    }

    public class SilkTouchFrameworkDiscoverer : XunitTestFrameworkDiscoverer
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
            return base.FindTestsForMethod
                (testMethod, includeSourceInformation, messageBus, discoveryOptions) && testMethod.Method
                .GetCustomAttributes(typeof(TraitAttribute))
                .Select
                (
                    x =>
                    {
                        var args = x.GetConstructorArguments().ToArray();
                        var name = (string) args[0];
                        var value = (string) args[1];
                        return (name, value);
                    }
                )
                .ToLookup(x => x.name, x => x.value)
                .All
                (
                    x =>
                    {
                        if (!SilkTouchTestFramework.TraitVerifiers.TryGetValue(x.Key, out var func)) return true;

                        return x.All(func);
                    }
                );
        }
    }
}
