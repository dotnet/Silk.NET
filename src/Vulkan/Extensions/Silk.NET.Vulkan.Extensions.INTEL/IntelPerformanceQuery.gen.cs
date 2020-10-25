// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.INTEL
{
    [Extension("VK_INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_INTEL_performance_query";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public unsafe partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public unsafe partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] ref PerformanceConfigurationINTEL pConfiguration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public unsafe partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PerformanceConfigurationAcquireInfoINTEL pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PerformanceConfigurationAcquireInfoINTEL pAcquireInfo, [Count(Count = 0)] ref PerformanceConfigurationINTEL pConfiguration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        public unsafe partial Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceMarkerInfoINTEL* pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        public partial Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in PerformanceMarkerInfoINTEL pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        public unsafe partial Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceOverrideInfoINTEL* pOverrideInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        public partial Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in PerformanceOverrideInfoINTEL pOverrideInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        public unsafe partial Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        public partial Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in PerformanceStreamMarkerInfoINTEL pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL")]
        public unsafe partial Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] PerformanceValueINTEL* pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL")]
        public partial Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] out PerformanceValueINTEL pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL")]
        public unsafe partial Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] InitializePerformanceApiInfoINTEL* pInitializeInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL")]
        public partial Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in InitializePerformanceApiInfoINTEL pInitializeInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSetPerformanceConfigurationINTEL")]
        public partial Result QueueSetPerformanceConfiguration([Count(Count = 0)] Queue queue, [Count(Count = 0)] PerformanceConfigurationINTEL configuration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleasePerformanceConfigurationINTEL")]
        public partial Result ReleasePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceConfigurationINTEL configuration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUninitializePerformanceApiINTEL")]
        public partial void UninitializePerformanceAp([Count(Count = 0)] Device device);

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

