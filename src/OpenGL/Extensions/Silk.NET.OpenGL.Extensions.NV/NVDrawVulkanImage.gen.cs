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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_draw_vulkan_image")]
    public unsafe partial class NVDrawVulkanImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_vulkan_image";
        [NativeApi(EntryPoint = "glDrawVkImageNV", Convention = CallingConvention.Winapi)]
        public partial void DrawVkImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong vkImage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t1);

        [NativeApi(EntryPoint = "glGetVkProcAddrNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetVkProcAddr([Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetVkProcAddrNV", Convention = CallingConvention.Winapi)]
        public partial nint GetVkProcAddr([Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetVkProcAddrNV", Convention = CallingConvention.Winapi)]
        public partial nint GetVkProcAddr([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glSignalVkFenceNV", Convention = CallingConvention.Winapi)]
        public partial void SignalVkFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong vkFence);

        [NativeApi(EntryPoint = "glSignalVkSemaphoreNV", Convention = CallingConvention.Winapi)]
        public partial void SignalVkSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong vkSemaphore);

        [NativeApi(EntryPoint = "glWaitVkSemaphoreNV", Convention = CallingConvention.Winapi)]
        public partial void WaitVkSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong vkSemaphore);

        public NVDrawVulkanImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

