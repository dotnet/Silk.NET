// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_performance_monitor")]
    public unsafe partial class AmdPerformanceMonitor : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_performance_monitor";
        [NativeApi(EntryPoint = "glBeginPerfMonitorAMD")]
        public partial void BeginPerfMonitor([Flow(FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD")]
        public unsafe partial void DeletePerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD")]
        public partial void DeletePerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint monitors);

        [NativeApi(EntryPoint = "glEndPerfMonitorAMD")]
        public partial void EndPerfMonitor([Flow(FlowDirection.In)] uint monitor);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD")]
        public unsafe partial void GenPerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* monitors);

        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD")]
        public partial void GenPerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint monitors);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD")]
        public unsafe partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD")]
        public unsafe partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(FlowDirection.Out)] out int bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD")]
        public unsafe partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] out uint data, [Count(Count = 1), Flow(FlowDirection.Out)] int* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD")]
        public partial void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] out uint data, [Count(Count = 1), Flow(FlowDirection.Out)] out int bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
        public unsafe partial void GetPerfMonitorCounterInfo([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
        public partial void GetPerfMonitorCounterInfo<T0>([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public unsafe partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public partial void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] out uint counters);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public unsafe partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public partial void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string counterString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD")]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] int* numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD")]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] int* numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] out uint groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD")]
        public unsafe partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] out int numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] uint* groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD")]
        public partial void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] out int numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] out uint groups);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public unsafe partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte groupString);

        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public partial void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string groupString);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD")]
        public unsafe partial void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] uint* counterList);

        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD")]
        public partial void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] out uint counterList);

        public unsafe uint GenPerfMonitor()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenPerfMonitors(n, &ret);
            return ret;
        }

        public AmdPerformanceMonitor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

