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
        public partial void BeginPerfMonitor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeletePerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public partial void DeletePerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint monitors);

        [NativeApi(EntryPoint = "glEndPerfMonitorAMD", Convention = CallingConvention.Winapi)]
        public partial void EndPerfMonitor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenPerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public partial void GenPerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint monitors);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string groupString);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void SelectPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterList);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public partial void SelectPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint counterList);

        public unsafe void DeletePerfMonitors([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> monitors)
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

        public unsafe void GenPerfMonitors([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> monitors)
        {
            // ImplicitCountSpanOverloader
            GenPerfMonitors((uint) monitors.Length, out monitors.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* bytesWritten)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterData(monitor, pname, (uint) data.Length*4, out data.GetPinnableReference(), bytesWritten);
        }

        public unsafe void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int bytesWritten)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterData(monitor, pname, (uint) data.Length*4, out data.GetPinnableReference(), out bytesWritten);
        }

        public unsafe uint GetPerfMonitorCounter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters)
        {
            const uint counterSize = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfMonitorCounters(group, numCounters, maxActiveCounters, counterSize, &ret);
            return ret;
        }

        public unsafe void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, numCounters, maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, numCounters, out maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, out numCounters, maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounters(group, out numCounters, out maxActiveCounters, (uint) counters.Length, out counters.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, out length, out counterString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorCounterString(group, counter, (uint) counterString.Length, out length, out counterString.GetPinnableReference());
        }

        public unsafe uint GetPerfMonitorGroup([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups)
        {
            const uint groupsSize = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfMonitorGroups(numGroups, groupsSize, &ret);
            return ret;
        }

        public unsafe void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> groups)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroups(numGroups, (uint) groups.Length, out groups.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numGroups, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> groups)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroups(out numGroups, (uint) groups.Length, out groups.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, length, out groupString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, length, out groupString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, out length, out groupString.GetPinnableReference());
        }

        public unsafe void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> groupString)
        {
            // ImplicitCountSpanOverloader
            GetPerfMonitorGroupString(group, (uint) groupString.Length, out length, out groupString.GetPinnableReference());
        }

        public unsafe void SelectPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Parameter = "numCounters"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterList)
        {
            // ImplicitCountSpanOverloader
            SelectPerfMonitorCounters(monitor, enable, group, (int) counterList.Length, out counterList.GetPinnableReference());
        }

        public unsafe uint DeletePerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            DeletePerfMonitors(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GenPerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenPerfMonitors(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* data)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounterData(monitor, pname, dataSize, data, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint data)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounterData(monitor, pname, dataSize, out data, out int silkRet);
            return silkRet;
        }

        public unsafe T0 GetPerfMonitorCounterInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounterInfo(group, counter, pname, out T0 silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounters(group, numCounters, maxActiveCounters, counterSize, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounters(group, numCounters, out maxActiveCounters, counterSize, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounters(group, out numCounters, maxActiveCounters, counterSize, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounters(group, out numCounters, out maxActiveCounters, counterSize, out uint silkRet);
            return silkRet;
        }

        public unsafe byte GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounterString(group, counter, bufSize, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounterString(group, counter, bufSize, out length, out byte silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorGroups(numGroups, groupsSize, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorGroups(out numGroups, groupsSize, out uint silkRet);
            return silkRet;
        }

        public unsafe byte GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorGroupString(group, bufSize, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorGroupString(group, bufSize, out length, out byte silkRet);
            return silkRet;
        }

        public unsafe uint SelectPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numCounters)
        {
            // NonKhrReturnTypeOverloader
            SelectPerfMonitorCounters(monitor, enable, group, numCounters, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> data)
        {
            // NonKhrReturnTypeOverloader
            GetPerfMonitorCounterData(monitor, pname, data, out int silkRet);
            return silkRet;
        }

        public AmdPerformanceMonitor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

