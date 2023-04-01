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

namespace Silk.NET.Vulkan.Extensions.ANDROID
{
    public static class AndroidExternalMemoryAndroidHardwareBufferOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.AndroidHardwareBufferPropertiesAndroid);")]
        public static unsafe Result GetAndroidHardwareBufferProperties(this AndroidExternalMemoryAndroidHardwareBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AndroidHardwareBufferPropertiesANDROID> pProperties)
        {
            // SpanOverloader
            return thisApi.GetAndroidHardwareBufferProperties(device, buffer, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAndroidHardwareBufferProperties(this AndroidExternalMemoryAndroidHardwareBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            // SpanOverloader
            return thisApi.GetAndroidHardwareBufferProperties(device, in buffer.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.AndroidHardwareBufferPropertiesAndroid);")]
        public static unsafe Result GetAndroidHardwareBufferProperties(this AndroidExternalMemoryAndroidHardwareBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AndroidHardwareBufferPropertiesANDROID> pProperties)
        {
            // SpanOverloader
            return thisApi.GetAndroidHardwareBufferProperties(device, in buffer.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryAndroidHardwareBuffer(this AndroidExternalMemoryAndroidHardwareBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetAndroidHardwareBufferInfoANDROID> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint** pBuffer)
        {
            // SpanOverloader
            return thisApi.GetMemoryAndroidHardwareBuffer(device, in pInfo.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryAndroidHardwareBuffer(this AndroidExternalMemoryAndroidHardwareBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetAndroidHardwareBufferInfoANDROID> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint* pBuffer)
        {
            // SpanOverloader
            return thisApi.GetMemoryAndroidHardwareBuffer(device, in pInfo.GetPinnableReference(), out pBuffer);
        }

    }
}

