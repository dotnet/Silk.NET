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

namespace Silk.NET.Vulkan.Extensions.QCOM
{
    public static class QComTilePropertiesOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        public static unsafe Result GetDynamicRenderingTileProperties(this QComTileProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingInfo* pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TilePropertiesQCOM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDynamicRenderingTileProperties(device, pRenderingInfo, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDynamicRenderingTileProperties(this QComTileProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderingInfo> pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TilePropertiesQCOM* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDynamicRenderingTileProperties(device, in pRenderingInfo.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        public static unsafe Result GetDynamicRenderingTileProperties(this QComTileProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderingInfo> pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TilePropertiesQCOM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDynamicRenderingTileProperties(device, in pRenderingInfo.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        public static unsafe Result GetFramebufferTileProperties(this QComTileProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TilePropertiesQCOM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetFramebufferTileProperties(device, framebuffer, pPropertiesCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFramebufferTileProperties(this QComTileProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] Span<uint> pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TilePropertiesQCOM* pProperties)
        {
            // SpanOverloader
            return thisApi.GetFramebufferTileProperties(device, framebuffer, ref pPropertiesCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        public static unsafe Result GetFramebufferTileProperties(this QComTileProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] Span<uint> pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TilePropertiesQCOM> pProperties)
        {
            // SpanOverloader
            return thisApi.GetFramebufferTileProperties(device, framebuffer, ref pPropertiesCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

