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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.AMD
{
    [Extension("AMD_performance_monitor")]
    public unsafe partial class AmdPerformanceMonitor : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_performance_monitor";
        [NativeApi(EntryPoint = "glBeginPerfMonitorAMD", Convention = CallingConvention.Winapi)]
        public partial void BeginPerfMonitor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeletePerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glEndPerfMonitorAMD", Convention = CallingConvention.Winapi)]
        public partial void EndPerfMonitor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenPerfMonitors([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* maxActiveCounters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorCounterString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfMonitorGroupString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void SelectPerfMonitorCounters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint monitor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterList);

        public AmdPerformanceMonitor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

