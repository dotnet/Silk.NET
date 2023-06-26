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

namespace Silk.NET.Vulkan.Extensions.QNX
{
    public static class QnxExternalMemoryScreenBufferOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ScreenBufferPropertiesQnx);")]
        public static unsafe Result GetScreenBufferPropertiesQnx(this QnxExternalMemoryScreenBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ScreenBufferPropertiesQNX> pProperties)
        {
            // SpanOverloader
            return thisApi.GetScreenBufferPropertiesQnx(device, buffer, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetScreenBufferPropertiesQnx<T0>(this QnxExternalMemoryScreenBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ScreenBufferPropertiesQNX* pProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetScreenBufferPropertiesQnx(device, in buffer.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ScreenBufferPropertiesQnx);")]
        public static unsafe Result GetScreenBufferPropertiesQnx<T0>(this QnxExternalMemoryScreenBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ScreenBufferPropertiesQNX> pProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetScreenBufferPropertiesQnx(device, in buffer.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

