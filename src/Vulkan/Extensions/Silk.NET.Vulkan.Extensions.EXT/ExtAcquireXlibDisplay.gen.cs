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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_acquire_xlib_display")]
    public unsafe partial class ExtAcquireXlibDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_acquire_xlib_display";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireXlibDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireXlibDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] nint* dpy, [Count(Count = 0)] DisplayKHR display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireXlibDisplayEXT", Convention = CallingConvention.Winapi)]
        public partial Result AcquireXlibDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref nint dpy, [Count(Count = 0)] DisplayKHR display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] nint* dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplay);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] nint* dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayKHR pDisplay);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref nint dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplay);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref nint dpy, [Count(Count = 0)] nint rrOutput, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayKHR pDisplay);

        public ExtAcquireXlibDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

