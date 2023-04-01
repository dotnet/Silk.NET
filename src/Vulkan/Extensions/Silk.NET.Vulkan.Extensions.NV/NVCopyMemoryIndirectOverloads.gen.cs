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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVCopyMemoryIndirectOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyMemoryToImageIndirect(this NVCopyMemoryIndirect thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong copyBufferAddress, [Count(Count = 0)] uint copyCount, [Count(Count = 0)] uint stride, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "copyCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSubresourceLayers> pImageSubresources)
        {
            // SpanOverloader
            thisApi.CmdCopyMemoryToImageIndirect(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, in pImageSubresources.GetPinnableReference());
        }

    }
}

