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
    public static class NVAcquireWinrtDisplayOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetWinrtDisplay(this NVAcquireWinrtDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint deviceRelativeId, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayKHR> pDisplay)
        {
            // SpanOverloader
            return thisApi.GetWinrtDisplay(physicalDevice, deviceRelativeId, out pDisplay.GetPinnableReference());
        }

    }
}

