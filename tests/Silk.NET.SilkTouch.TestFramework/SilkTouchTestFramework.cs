using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Silk.NET.SilkTouch.TestFramework
{
    public class SilkTouchTestFramework : XunitTestFramework
    {
        public static readonly Dictionary<string, bool> Features = new()
        {
            ["Enums"] = false,
            ["Fields"] = true,
            ["Fixed-Size Arrays"] = true,
            ["Inheritance"] = true,
            ["Namespaces"] = true,
            ["Nested Types"] = true,
            ["Structs"] = true,
            ["Unions"] = false,
            ["Functions"] = true
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

        protected override ITestFrameworkExecutor CreateExecutor(AssemblyName assemblyName)
            => new SilkTouchTestFrameworkExecutor(assemblyName, SourceInformationProvider, DiagnosticMessageSink);
    }
}
