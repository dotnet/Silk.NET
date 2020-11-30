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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_direct_mode_display")]
    public unsafe partial class ExtDirectModeDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_direct_mode_display";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleaseDisplayEXT")]
        public partial Result ReleaseDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display);

        public ExtDirectModeDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

