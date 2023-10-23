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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrVideoEncodeQueueOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdEncodeVideo(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeInfoKHR> pEncodeInfo)
        {
            // SpanOverloader
            thisApi.CmdEncodeVideo(commandBuffer, in pEncodeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, pFeedbackInfo, ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, pFeedbackInfo, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, ref pFeedbackInfo.GetPinnableReference(), pDataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, ref pFeedbackInfo.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, ref pFeedbackInfo.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, pVideoSessionParametersInfo, ref pFeedbackInfo.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), pFeedbackInfo, pDataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), pFeedbackInfo, pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), pFeedbackInfo, ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] VideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), pFeedbackInfo, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), ref pFeedbackInfo.GetPinnableReference(), pDataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), ref pFeedbackInfo.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), ref pFeedbackInfo.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEncodedVideoSessionParameters<T0>(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncodeSessionParametersGetInfoKHR> pVideoSessionParametersInfo, [Count(Count = 0)] Span<VideoEncodeSessionParametersFeedbackInfoKHR> pFeedbackInfo, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetEncodedVideoSessionParameters(device, in pVideoSessionParametersInfo.GetPinnableReference(), ref pFeedbackInfo.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQualityLevelProperties = new(StructureType.VideoEncodeQualityLevelPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoEncodeQualityLevelProperties(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoEncodeQualityLevelPropertiesKHR> pQualityLevelProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoEncodeQualityLevelProperties(physicalDevice, pQualityLevelInfo, out pQualityLevelProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceVideoEncodeQualityLevelProperties(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceVideoEncodeQualityLevelInfoKHR> pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoEncodeQualityLevelProperties(physicalDevice, in pQualityLevelInfo.GetPinnableReference(), pQualityLevelProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQualityLevelProperties = new(StructureType.VideoEncodeQualityLevelPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoEncodeQualityLevelProperties(this KhrVideoEncodeQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceVideoEncodeQualityLevelInfoKHR> pQualityLevelInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoEncodeQualityLevelPropertiesKHR> pQualityLevelProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoEncodeQualityLevelProperties(physicalDevice, in pQualityLevelInfo.GetPinnableReference(), out pQualityLevelProperties.GetPinnableReference());
        }

    }
}

