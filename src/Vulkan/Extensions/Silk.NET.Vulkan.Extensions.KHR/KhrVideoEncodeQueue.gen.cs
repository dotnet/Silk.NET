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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_video_encode_queue")]
    public unsafe partial class KhrVideoEncodeQueue : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_video_encode_queue";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEncodeVideoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEncodeVideo([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeInfoKHR* pEncodeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEncodeVideoKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdEncodeVideo([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeInfoKHR pEncodeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEncodedVideoSessionParameters([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEncodedVideoSessionParametersKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetEncodedVideoSessionParameters<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, [Count(Count = 0)] ref VideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoEncodeQualityLevelProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQualityLevelProperties = new(StructureType.VideoEncodeQualityLevelPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoEncodeQualityLevelProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoEncodeQualityLevelPropertiesKHR pQualityLevelProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceVideoEncodeQualityLevelProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceVideoEncodeQualityLevelInfoKHR pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQualityLevelProperties = new(StructureType.VideoEncodeQualityLevelPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceVideoEncodeQualityLevelProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceVideoEncodeQualityLevelInfoKHR pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VideoEncodeQualityLevelPropertiesKHR pQualityLevelProperties);

        public KhrVideoEncodeQueue(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

