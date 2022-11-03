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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_display_native_hdr")]
    public unsafe partial class AmdDisplayNativeHdr : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_display_native_hdr";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetLocalDimmingAMD", Convention = CallingConvention.Winapi)]
        public partial void SetLocalDimming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapChain, [Count(Count = 0)] Bool32 localDimmingEnable);

        public AmdDisplayNativeHdr(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

