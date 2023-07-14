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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdPerformanceMonitorOverloads
    {
        public static unsafe void DeletePerfMonitors(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> monitors)
        {
            // SpanOverloader
            thisApi.DeletePerfMonitors(n, out monitors.GetPinnableReference());
        }

        public static unsafe void GenPerfMonitors(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> monitors)
        {
            // SpanOverloader
            thisApi.GenPerfMonitors(n, out monitors.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterData(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> bytesWritten)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterData(monitor, pname, dataSize, data, out bytesWritten.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterData(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* bytesWritten)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterData(monitor, pname, dataSize, out data.GetPinnableReference(), bytesWritten);
        }

        public static unsafe void GetPerfMonitorCounterData(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> bytesWritten)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterData(monitor, pname, dataSize, out data.GetPinnableReference(), out bytesWritten.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterInfo<T0>(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterInfo(group, counter, pname, out data.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, numCounters, maxActiveCounters, counterSize, out counters.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, numCounters, out maxActiveCounters.GetPinnableReference(), counterSize, counters);
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, numCounters, out maxActiveCounters.GetPinnableReference(), counterSize, out counters.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, out numCounters.GetPinnableReference(), maxActiveCounters, counterSize, counters);
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, out numCounters.GetPinnableReference(), maxActiveCounters, counterSize, out counters.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, out numCounters.GetPinnableReference(), out maxActiveCounters.GetPinnableReference(), counterSize, counters);
        }

        public static unsafe void GetPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counters)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounters(group, out numCounters.GetPinnableReference(), out maxActiveCounters.GetPinnableReference(), counterSize, out counters.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterString(group, counter, bufSize, length, out counterString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterString(group, counter, bufSize, length, out counterString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterString(group, counter, bufSize, out length.GetPinnableReference(), counterString);
        }

        public static unsafe void GetPerfMonitorCounterString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> counterString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterString(group, counter, bufSize, out length.GetPinnableReference(), out counterString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorCounterString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> counterString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorCounterString(group, counter, bufSize, out length.GetPinnableReference(), out counterString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorGroups(this AmdPerformanceMonitor thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> groups)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroups(numGroups, groupsSize, out groups.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorGroups(this AmdPerformanceMonitor thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* groups)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroups(out numGroups.GetPinnableReference(), groupsSize, groups);
        }

        public static unsafe void GetPerfMonitorGroups(this AmdPerformanceMonitor thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> groups)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroups(out numGroups.GetPinnableReference(), groupsSize, out groups.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorGroupString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> groupString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroupString(group, bufSize, length, out groupString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorGroupString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> groupString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroupString(group, bufSize, length, out groupString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorGroupString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* groupString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroupString(group, bufSize, out length.GetPinnableReference(), groupString);
        }

        public static unsafe void GetPerfMonitorGroupString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> groupString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroupString(group, bufSize, out length.GetPinnableReference(), out groupString.GetPinnableReference());
        }

        public static unsafe void GetPerfMonitorGroupString(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> groupString)
        {
            // SpanOverloader
            thisApi.GetPerfMonitorGroupString(group, bufSize, out length.GetPinnableReference(), out groupString.GetPinnableReference());
        }

        public static unsafe void SelectPerfMonitorCounters(this AmdPerformanceMonitor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> counterList)
        {
            // SpanOverloader
            thisApi.SelectPerfMonitorCounters(monitor, enable, group, numCounters, out counterList.GetPinnableReference());
        }

    }
}

