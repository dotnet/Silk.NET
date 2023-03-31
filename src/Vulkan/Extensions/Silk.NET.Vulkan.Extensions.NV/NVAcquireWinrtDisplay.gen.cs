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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_acquire_winrt_display")]
    public unsafe partial class NVAcquireWinrtDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_acquire_winrt_display";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireWinrtDisplayNV", Convention = CallingConvention.Winapi)]
        public partial Result AcquireWinrtDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetWinrtDisplayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetWinrtDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint deviceRelativeId, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayKHR* pDisplay);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetWinrtDisplayNV", Convention = CallingConvention.Winapi)]
        public partial Result GetWinrtDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint deviceRelativeId, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DisplayKHR pDisplay);

        public NVAcquireWinrtDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

