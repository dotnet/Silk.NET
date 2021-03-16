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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVAcquireWinrtDisplayOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetWinrtDisplay(this NVAcquireWinrtDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint deviceRelativeId, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DisplayKHR> pDisplay)
        {
            // SpanOverloader
            return thisApi.GetWinrtDisplay(physicalDevice, deviceRelativeId, out pDisplay.GetPinnableReference());
        }

    }
}

