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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtImageCompressionControlOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Ext);")]
        public static unsafe void GetImageSubresourceLayout2(this ExtImageCompressionControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource2EXT* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SubresourceLayout2EXT> pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout2(device, image, pSubresource, out pLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSubresourceLayout2(this ExtImageCompressionControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImageSubresource2EXT> pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout2EXT* pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout2(device, image, in pSubresource.GetPinnableReference(), pLayout);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Ext);")]
        public static unsafe void GetImageSubresourceLayout2(this ExtImageCompressionControl thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImageSubresource2EXT> pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SubresourceLayout2EXT> pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout2(device, image, in pSubresource.GetPinnableReference(), out pLayout.GetPinnableReference());
        }

    }
}

