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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_direct_mode_display")]
    public abstract unsafe partial class ExtDirectModeDisplay : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_direct_mode_display";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleaseDisplayEXT")]
        public abstract Result ReleaseDisplay([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display);

        public ExtDirectModeDisplay(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

