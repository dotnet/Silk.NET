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
    [Extension("VK_EXT_direct_mode_display")]
    public unsafe partial class ExtDirectModeDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_direct_mode_display";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseDisplayEXT", Convention = CallingConvention.Winapi)]
        public partial Result ReleaseDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display);

        public ExtDirectModeDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

