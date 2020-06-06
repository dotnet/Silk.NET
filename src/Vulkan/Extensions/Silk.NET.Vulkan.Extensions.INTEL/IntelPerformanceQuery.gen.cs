// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.INTEL
{
    [Extension("VK_INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_INTEL_performance_query";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration)
            => ImplAcquirePerformanceConfiguration(device, pAcquireInfo, pConfiguration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceConfigurationAcquireInfoINTEL pAcquireInfo, [Count(Count = 0)] ref PerformanceConfigurationINTEL pConfiguration)
            => ImplAcquirePerformanceConfiguration(device, pAcquireInfo, pConfiguration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceMarkerInfoINTEL* pMarkerInfo)
            => ImplCmdSetPerformanceMarker(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceMarkerInfoINTEL pMarkerInfo)
            => ImplCmdSetPerformanceMarker(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceOverrideInfoINTEL* pOverrideInfo)
            => ImplCmdSetPerformanceOverride(commandBuffer, pOverrideInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceOverrideInfoINTEL pOverrideInfo)
            => ImplCmdSetPerformanceOverride(commandBuffer, pOverrideInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceStreamMarkerInfoINTEL* pMarkerInfo)
            => ImplCmdSetPerformanceStreamMarker(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref PerformanceStreamMarkerInfoINTEL pMarkerInfo)
            => ImplCmdSetPerformanceStreamMarker(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] PerformanceValueINTEL* pValue)
            => ImplGetPerformanceParameter(device, parameter, pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] out PerformanceValueINTEL pValue)
            => ImplGetPerformanceParameter(device, parameter, pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] InitializePerformanceApiInfoINTEL* pInitializeInfo)
            => ImplInitializePerformanceAp(device, pInitializeInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref InitializePerformanceApiInfoINTEL pInitializeInfo)
            => ImplInitializePerformanceAp(device, pInitializeInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSetPerformanceConfigurationINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result QueueSetPerformanceConfiguration([Count(Count = 0)] Queue queue, [Count(Count = 0)] PerformanceConfigurationINTEL configuration)
            => ImplQueueSetPerformanceConfiguration(queue, configuration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleasePerformanceConfigurationINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ReleasePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceConfigurationINTEL configuration)
            => ImplReleasePerformanceConfiguration(device, configuration);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUninitializePerformanceApiINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UninitializePerformanceAp([Count(Count = 0)] Device device)
            => ImplUninitializePerformanceAp(device);

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

