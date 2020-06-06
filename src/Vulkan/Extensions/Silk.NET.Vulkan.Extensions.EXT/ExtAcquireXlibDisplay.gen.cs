// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_acquire_xlib_display")]
    public unsafe partial class ExtAcquireXlibDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_acquire_xlib_display";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireXlibDisplayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AcquireXlibDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] DisplayKHR display)
            => ImplAcquireXlibDisplay(physicalDevice, dpy, display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireXlibDisplayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquireXlibDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] DisplayKHR display)
            => ImplAcquireXlibDisplay(physicalDevice, dpy, display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] IntPtr rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayKHR* pDisplay)
            => ImplGetRandROutputDisplay(physicalDevice, dpy, rrOutput, pDisplay);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] IntPtr rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayKHR pDisplay)
            => ImplGetRandROutputDisplay(physicalDevice, dpy, rrOutput, pDisplay);

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] int rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayKHR* pDisplay)
        {
            // IntPtrOverloader
            return GetRandROutputDisplay(physicalDevice, dpy, new IntPtr(rrOutput), pDisplay);
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] int rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayKHR pDisplay)
        {
            // IntPtrOverloader
            return GetRandROutputDisplay(physicalDevice, ref dpy, new IntPtr(rrOutput), out pDisplay);
        }

        public ExtAcquireXlibDisplay(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

