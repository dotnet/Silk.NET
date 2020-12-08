// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    public static class ExtDisplaySurfaceCounterOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceCapabilities2(this ExtDisplaySurfaceCounter thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SurfaceCapabilities2EXT> pSurfaceCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceCapabilities2(physicalDevice, surface, out pSurfaceCapabilities.GetPinnableReference());
        }

    }
}

