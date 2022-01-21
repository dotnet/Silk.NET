// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_performance_monitor")]
    public unsafe partial class AmdPerformanceMonitor : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_performance_monitor";
        [NativeApi(EntryPoint = "glBeginPerfMonitorAMD", Convention = CallingConvention.Winapi)]
        public partial void BeginPerfMonitor([Flow(FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeletePerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public partial void DeletePerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint monitors);

        [NativeApi(EntryPoint = "glEndPerfMonitorAMD", Convention = CallingConvention.Winapi)]
        public partial void EndPerfMonitor([Flow(FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenPerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public partial void GenPerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint monitors);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(FlowDirection.Out)] out int bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] out uint data, [Count(Count = 1), Flow(FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] out uint data, [Count(Count = 1), Flow(FlowDirection.Out)] out int bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterInfo([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterInfo<T0>([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] int* numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] int* numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] out uint groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] out int numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] out int numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] out uint groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string groupString);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] uint* counterList);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public partial void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] out uint counterList);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] Boolean enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] uint* counterList);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public partial void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] Boolean enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] out uint counterList);

        public unsafe void DeletePerfMonitors([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> monitors)
        {
            // ImplicitCountSpanOverloader
            DeletePerfMonitors((uint) monitors.Length, out monitors.GetPinnableReference());
        }

        public unsafe uint GenPerfMonitor()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenPerfMonitors(n, &ret);
            return ret;
        }

        public unsafe void GenPerfMonitors([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> monitors)
        {
            // ImplicitCountSpanOverloader
            GenPerfMonitors((uint) monitors.Length, out monitors.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(FlowDirection.Out)] int* bytesWritten)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterData(monitor, pname, (uint) data.Length, out data.GetPinnableReference(), bytesWritten);
        }

        public unsafe void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(FlowDirection.Out)] out int bytesWritten)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterData(monitor, pname, (uint) data.Length, out data.GetPinnableReference(), out bytesWritten);
        }

        public unsafe void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, numCounters, maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, numCounters, out maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, out numCounters, maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, out numCounters, out maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, out length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, out length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] int* numGroups, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] Span<uint> groups)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroups(numGroups, (uint) groups.Length, out groups.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] out int numGroups, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] Span<uint> groups)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroups(out numGroups, (uint) groups.Length, out groups.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, length, out groupString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, length, out groupString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, out length, out groupString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, out length, out groupString.GetPinnableReference());
        }

        public unsafe void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] Span<uint> counterList)
        {
            // ImplicitCountSpanOverloader
            SelectPerfMonitorCounters(monitor, enable, group, (int) counterList.Length, out counterList.GetPinnableReference());
        }

        public unsafe void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] Boolean enable, [Flow(FlowDirection.In)] uint group, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] Span<uint> counterList)
        {
            // ImplicitCountSpanOverloader
            SelectPerfMonitorCounters(monitor, enable, group, (int) counterList.Length, out counterList.GetPinnableReference());
        }

        public AmdPerformanceMonitor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

