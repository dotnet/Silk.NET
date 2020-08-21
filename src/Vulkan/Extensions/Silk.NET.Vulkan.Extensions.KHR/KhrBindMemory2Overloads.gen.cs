// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrBindMemory2Overloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result BindBufferMemory2(this KhrBindMemory2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindBufferMemoryInfo> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindBufferMemory2(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result BindImageMemory2(this KhrBindMemory2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindImageMemoryInfo> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindImageMemory2(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

    }
}

