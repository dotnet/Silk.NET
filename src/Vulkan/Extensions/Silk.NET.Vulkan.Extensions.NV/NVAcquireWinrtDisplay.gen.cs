// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        [NativeApi(EntryPoint = "vkAcquireWinrtDisplayNV")]
        public partial Result AcquireWinrtDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetWinrtDisplayNV")]
        public unsafe partial Result GetWinrtDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint deviceRelativeId, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayKHR* pDisplay);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetWinrtDisplayNV")]
        public partial Result GetWinrtDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint deviceRelativeId, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayKHR pDisplay);

        public NVAcquireWinrtDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

