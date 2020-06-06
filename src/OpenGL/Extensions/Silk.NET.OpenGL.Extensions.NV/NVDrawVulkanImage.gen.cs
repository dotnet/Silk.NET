// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_draw_vulkan_image")]
    public unsafe partial class NVDrawVulkanImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_vulkan_image";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vkImage">
        /// To be added.
        /// </param>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="x0">
        /// To be added.
        /// </param>
        /// <param name="y0">
        /// To be added.
        /// </param>
        /// <param name="x1">
        /// To be added.
        /// </param>
        /// <param name="y1">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="s0">
        /// To be added.
        /// </param>
        /// <param name="t0">
        /// To be added.
        /// </param>
        /// <param name="s1">
        /// To be added.
        /// </param>
        /// <param name="t1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawVkImageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawVkImage([Flow(FlowDirection.In)] ulong vkImage, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] float x0, [Flow(FlowDirection.In)] float y0, [Flow(FlowDirection.In)] float x1, [Flow(FlowDirection.In)] float y1, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float s0, [Flow(FlowDirection.In)] float t0, [Flow(FlowDirection.In)] float s1, [Flow(FlowDirection.In)] float t1)
            => ImplDrawVkImage(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetVkProcAddrNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr GetVkProcAddr([Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetVkProcAddr(name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetVkProcAddrNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr GetVkProcAddr([Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetVkProcAddr(name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vkFence">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSignalVkFenceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SignalVkFence([Flow(FlowDirection.In)] ulong vkFence)
            => ImplSignalVkFence(vkFence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vkSemaphore">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSignalVkSemaphoreNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SignalVkSemaphore([Flow(FlowDirection.In)] ulong vkSemaphore)
            => ImplSignalVkSemaphore(vkSemaphore);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vkSemaphore">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWaitVkSemaphoreNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WaitVkSemaphore([Flow(FlowDirection.In)] ulong vkSemaphore)
            => ImplWaitVkSemaphore(vkSemaphore);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetVkProcAddrNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr GetVkProcAddr([Flow(FlowDirection.In)] string name)
            => ImplGetVkProcAddr(name);

        public NVDrawVulkanImage(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

