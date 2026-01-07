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

namespace Silk.NET.Vulkan.Extensions.OHOS
{
    public static class OhosExternalMemoryOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryNativeBufferOhos(this OhosExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetNativeBufferInfoOHOS> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint** pBuffer)
        {
            // SpanOverloader
            return thisApi.GetMemoryNativeBufferOhos(device, in pInfo.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryNativeBufferOhos(this OhosExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetNativeBufferInfoOHOS> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint* pBuffer)
        {
            // SpanOverloader
            return thisApi.GetMemoryNativeBufferOhos(device, in pInfo.GetPinnableReference(), out pBuffer);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.NativeBufferPropertiesOhos);")]
        public static unsafe Result GetNativeBufferPropertiesOhos(this OhosExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<NativeBufferPropertiesOHOS> pProperties)
        {
            // SpanOverloader
            return thisApi.GetNativeBufferPropertiesOhos(device, buffer, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetNativeBufferPropertiesOhos(this OhosExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NativeBufferPropertiesOHOS* pProperties)
        {
            // SpanOverloader
            return thisApi.GetNativeBufferPropertiesOhos(device, in buffer.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.NativeBufferPropertiesOhos);")]
        public static unsafe Result GetNativeBufferPropertiesOhos(this OhosExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<NativeBufferPropertiesOHOS> pProperties)
        {
            // SpanOverloader
            return thisApi.GetNativeBufferPropertiesOhos(device, in buffer.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

