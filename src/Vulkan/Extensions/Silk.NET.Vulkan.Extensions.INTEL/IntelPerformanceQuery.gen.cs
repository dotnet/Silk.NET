// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.INTEL
{
    [Extension("VK_INTEL_performance_query")]
    public abstract unsafe partial class IntelPerformanceQuery : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public abstract unsafe Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public abstract Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceConfigurationAcquireInfoINTEL pAcquireInfo, [Count(Count = 0)] ref PerformanceConfigurationINTEL pConfiguration);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        public abstract unsafe Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceMarkerInfoINTEL* pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        public abstract Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceMarkerInfoINTEL pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        public abstract unsafe Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceOverrideInfoINTEL* pOverrideInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        public abstract Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceOverrideInfoINTEL pOverrideInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        public abstract unsafe Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        public abstract Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceStreamMarkerInfoINTEL pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL")]
        public abstract unsafe Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] PerformanceValueINTEL* pValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL")]
        public abstract Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] out PerformanceValueINTEL pValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL")]
        public abstract unsafe Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] InitializePerformanceApiInfoINTEL* pInitializeInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL")]
        public abstract Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref InitializePerformanceApiInfoINTEL pInitializeInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkQueueSetPerformanceConfigurationINTEL")]
        public abstract Result QueueSetPerformanceConfiguration([Count(Count = 0)] Queue queue, [Count(Count = 0)] PerformanceConfigurationINTEL configuration);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkReleasePerformanceConfigurationINTEL")]
        public abstract Result ReleasePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceConfigurationINTEL configuration);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkUninitializePerformanceApiINTEL")]
        public abstract void UninitializePerformanceAp([Count(Count = 0)] Device device);

        public IntelPerformanceQuery(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

