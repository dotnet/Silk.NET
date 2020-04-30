// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_acquire_xlib_display")]
    public abstract unsafe partial class ExtAcquireXlibDisplay : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquireXlibDisplayEXT")]
        public abstract unsafe Result AcquireXlibDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] DisplayKHR display);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquireXlibDisplayEXT")]
        public abstract Result AcquireXlibDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] DisplayKHR display);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT")]
        public abstract unsafe Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] IntPtr rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayKHR* pDisplay);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetRandROutputDisplayEXT")]
        public abstract Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] IntPtr rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayKHR pDisplay);

        /// <summary>To be added.</summary>
        public unsafe Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] IntPtr* dpy, [Count(Count = 0)] int rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayKHR* pDisplay)
        {
            // IntPtrOverloader
            return GetRandROutputDisplay(physicalDevice, dpy, new IntPtr(rrOutput), pDisplay);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetRandROutputDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref IntPtr dpy, [Count(Count = 0)] int rrOutput, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayKHR pDisplay)
        {
            // IntPtrOverloader
            return GetRandROutputDisplay(physicalDevice, ref dpy, new IntPtr(rrOutput), out pDisplay);
        }

        public ExtAcquireXlibDisplay(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

