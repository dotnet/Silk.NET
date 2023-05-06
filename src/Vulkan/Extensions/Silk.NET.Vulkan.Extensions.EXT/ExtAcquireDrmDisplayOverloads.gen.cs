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
    public static class ExtAcquireDrmDisplayOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetDrmDisplay(this ExtAcquireDrmDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] int drmFd, [Count(Count = 0)] uint connectorId, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayKHR> display)
        {
            // SpanOverloader
            return thisApi.GetDrmDisplay(physicalDevice, drmFd, connectorId, out display.GetPinnableReference());
        }

    }
}

