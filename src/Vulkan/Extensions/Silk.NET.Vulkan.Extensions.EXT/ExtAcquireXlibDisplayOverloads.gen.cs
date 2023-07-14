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
    public static class ExtAcquireXlibDisplayOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireXlibDisplay(this ExtAcquireXlibDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<nint> dpy, [Count(Count = 0)] DisplayKHR display)
        {
            // SpanOverloader
            return thisApi.AcquireXlibDisplay(physicalDevice, ref dpy.GetPinnableReference(), display);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRandROutputDisplay(this ExtAcquireXlibDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] nint* dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayKHR> pDisplay)
        {
            // SpanOverloader
            return thisApi.GetRandROutputDisplay(physicalDevice, dpy, rrOutput, out pDisplay.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRandROutputDisplay(this ExtAcquireXlibDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<nint> dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplay)
        {
            // SpanOverloader
            return thisApi.GetRandROutputDisplay(physicalDevice, ref dpy.GetPinnableReference(), rrOutput, pDisplay);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRandROutputDisplay(this ExtAcquireXlibDisplay thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<nint> dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayKHR> pDisplay)
        {
            // SpanOverloader
            return thisApi.GetRandROutputDisplay(physicalDevice, ref dpy.GetPinnableReference(), rrOutput, out pDisplay.GetPinnableReference());
        }

    }
}

