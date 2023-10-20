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
    public static class ExtHostImageCopyOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CopyImageToImage(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyImageToImageInfoEXT> pCopyImageToImageInfo)
        {
            // SpanOverloader
            return thisApi.CopyImageToImage(device, in pCopyImageToImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyImageToMemory(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyImageToMemoryInfoEXT> pCopyImageToMemoryInfo)
        {
            // SpanOverloader
            return thisApi.CopyImageToMemory(device, in pCopyImageToMemoryInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CopyMemoryToImage(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyMemoryToImageInfoEXT> pCopyMemoryToImageInfo)
        {
            // SpanOverloader
            return thisApi.CopyMemoryToImage(device, in pCopyMemoryToImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public static unsafe void GetImageSubresourceLayout2(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SubresourceLayout2KHR> pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout2(device, image, pSubresource, out pLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSubresourceLayout2(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresource2KHR> pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout2(device, image, in pSubresource.GetPinnableReference(), pLayout);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public static unsafe void GetImageSubresourceLayout2(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresource2KHR> pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SubresourceLayout2KHR> pLayout)
        {
            // SpanOverloader
            thisApi.GetImageSubresourceLayout2(device, image, in pSubresource.GetPinnableReference(), out pLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result TransitionImageLayout(this ExtHostImageCopy thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint transitionCount, [Count(Parameter = "transitionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HostImageLayoutTransitionInfoEXT> pTransitions)
        {
            // SpanOverloader
            return thisApi.TransitionImageLayout(device, transitionCount, in pTransitions.GetPinnableReference());
        }

    }
}

