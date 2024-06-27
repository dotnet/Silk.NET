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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.INTEL
{
    [Extension("VK_INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_INTEL_performance_query";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] ref PerformanceConfigurationINTEL pConfiguration);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PerformanceConfigurationAcquireInfoINTEL pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquirePerformanceConfigurationINTEL", Convention = CallingConvention.Winapi)]
        public partial Result AcquirePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PerformanceConfigurationAcquireInfoINTEL pAcquireInfo, [Count(Count = 0)] ref PerformanceConfigurationINTEL pConfiguration);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerformanceMarkerInfoINTEL* pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceMarkerINTEL", Convention = CallingConvention.Winapi)]
        public partial Result CmdSetPerformanceMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PerformanceMarkerInfoINTEL pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerformanceOverrideInfoINTEL* pOverrideInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceOverrideINTEL", Convention = CallingConvention.Winapi)]
        public partial Result CmdSetPerformanceOverride([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PerformanceOverrideInfoINTEL pOverrideInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL", Convention = CallingConvention.Winapi)]
        public partial Result CmdSetPerformanceStreamMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PerformanceStreamMarkerInfoINTEL pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PerformanceValueINTEL* pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPerformanceParameterINTEL", Convention = CallingConvention.Winapi)]
        public partial Result GetPerformanceParameter([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PerformanceValueINTEL pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InitializePerformanceApiInfoINTEL* pInitializeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkInitializePerformanceApiINTEL", Convention = CallingConvention.Winapi)]
        public partial Result InitializePerformanceAp([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InitializePerformanceApiInfoINTEL pInitializeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSetPerformanceConfigurationINTEL", Convention = CallingConvention.Winapi)]
        public partial Result QueueSetPerformanceConfiguration([Count(Count = 0)] Queue queue, [Count(Count = 0)] PerformanceConfigurationINTEL configuration);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleasePerformanceConfigurationINTEL", Convention = CallingConvention.Winapi)]
        public partial Result ReleasePerformanceConfiguration([Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceConfigurationINTEL configuration);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUninitializePerformanceApiINTEL", Convention = CallingConvention.Winapi)]
        public partial void UninitializePerformanceAp([Count(Count = 0)] Device device);

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

