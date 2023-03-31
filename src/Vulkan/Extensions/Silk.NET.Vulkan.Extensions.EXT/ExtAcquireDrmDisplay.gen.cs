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
    [Extension("VK_EXT_acquire_drm_display")]
    public unsafe partial class ExtAcquireDrmDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_acquire_drm_display";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireDrmDisplayEXT", Convention = CallingConvention.Winapi)]
        public partial Result AcquireDrmDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] int drmFd, [Count(Count = 0)] DisplayKHR display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDrmDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDrmDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] int drmFd, [Count(Count = 0)] uint connectorId, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDrmDisplayEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetDrmDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] int drmFd, [Count(Count = 0)] uint connectorId, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayKHR display);

        public ExtAcquireDrmDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

