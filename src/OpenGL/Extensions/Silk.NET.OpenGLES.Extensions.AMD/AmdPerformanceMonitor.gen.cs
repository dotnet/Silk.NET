// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.AMD
{
    [Extension("AMD_performance_monitor")]
    public abstract unsafe partial class AmdPerformanceMonitor : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_performance_monitor";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="monitor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginPerfMonitorAMD")]
        public abstract void BeginPerfMonitor([Flow(FlowDirection.In)] uint monitor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="monitors">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD")]
        public abstract unsafe void DeletePerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* monitors);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="monitors">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeletePerfMonitorsAMD")]
        public abstract void DeletePerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> monitors);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="monitor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndPerfMonitorAMD")]
        public abstract void EndPerfMonitor([Flow(FlowDirection.In)] uint monitor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="monitors">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD")]
        public abstract unsafe void GenPerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* monitors);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="monitors">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenPerfMonitorsAMD")]
        public abstract void GenPerfMonitors([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> monitors);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="monitor">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from dataSize.
        /// </param>
        /// <param name="bytesWritten">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD")]
        public abstract unsafe void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] uint* data, [Count(Count = 1), Flow(FlowDirection.Out)] int* bytesWritten);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="monitor">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from dataSize.
        /// </param>
        /// <param name="bytesWritten">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterDataAMD")]
        public abstract void GetPerfMonitorCounterData([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint dataSize, [Count(Parameter = "dataSize"), Flow(FlowDirection.Out)] Span<uint> data, [Count(Count = 1), Flow(FlowDirection.Out)] out int bytesWritten);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="counter">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
        public abstract unsafe void GetPerfMonitorCounterInfo([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] void* data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="counter">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
        public abstract void GetPerfMonitorCounterInfo<T0>([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] AMD pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="numCounters">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="maxActiveCounters">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="counterSize">
        /// To be added.
        /// </param>
        /// <param name="counters">
        /// To be added.
        /// This parameter's element count is taken from counterSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public abstract unsafe void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] int* numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] int* maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] uint* counters);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="numCounters">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="maxActiveCounters">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="counterSize">
        /// To be added.
        /// </param>
        /// <param name="counters">
        /// To be added.
        /// This parameter's element count is taken from counterSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCountersAMD")]
        public abstract void GetPerfMonitorCounters([Flow(FlowDirection.In)] uint group, [Count(Count = 1), Flow(FlowDirection.Out)] out int numCounters, [Count(Count = 1), Flow(FlowDirection.Out)] out int maxActiveCounters, [Flow(FlowDirection.In)] uint counterSize, [Count(Parameter = "counterSize"), Flow(FlowDirection.Out)] Span<uint> counters);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="counter">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="counterString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public abstract unsafe void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* counterString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="counter">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="counterString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public abstract void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> counterString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numGroups">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="groupsSize">
        /// To be added.
        /// </param>
        /// <param name="groups">
        /// To be added.
        /// This parameter's element count is taken from groupsSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD")]
        public abstract unsafe void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] int* numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] uint* groups);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numGroups">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="groupsSize">
        /// To be added.
        /// </param>
        /// <param name="groups">
        /// To be added.
        /// This parameter's element count is taken from groupsSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorGroupsAMD")]
        public abstract void GetPerfMonitorGroups([Count(Count = 1), Flow(FlowDirection.Out)] out int numGroups, [Flow(FlowDirection.In)] uint groupsSize, [Count(Parameter = "groupsSize"), Flow(FlowDirection.Out)] Span<uint> groups);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="groupString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public abstract unsafe void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* groupString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="groupString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public abstract void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> groupString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="monitor">
        /// To be added.
        /// </param>
        /// <param name="enable">
        /// To be added.
        /// </param>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="numCounters">
        /// To be added.
        /// </param>
        /// <param name="counterList">
        /// To be added.
        /// This parameter's element count is taken from numCounters.
        /// </param>
        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD")]
        public abstract unsafe void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] uint* counterList);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="monitor">
        /// To be added.
        /// </param>
        /// <param name="enable">
        /// To be added.
        /// </param>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="numCounters">
        /// To be added.
        /// </param>
        /// <param name="counterList">
        /// To be added.
        /// This parameter's element count is taken from numCounters.
        /// </param>
        [NativeApi(EntryPoint = "glSelectPerfMonitorCountersAMD")]
        public abstract void SelectPerfMonitorCounters([Flow(FlowDirection.In)] uint monitor, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] int numCounters, [Count(Parameter = "numCounters"), Flow(FlowDirection.Out)] Span<uint> counterList);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="counter">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="counterString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public abstract unsafe void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string counterString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="counter">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="counterString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorCounterStringAMD")]
        public abstract void GetPerfMonitorCounterString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint counter, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string counterString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="groupString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public abstract unsafe void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string groupString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="group">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="groupString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfMonitorGroupStringAMD")]
        public abstract void GetPerfMonitorGroupString([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string groupString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="monitors">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenPerfMonitor()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenPerfMonitors(n, &ret);
            return ret;
        }

        public AmdPerformanceMonitor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

