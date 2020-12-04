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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance1")]
    public unsafe partial class KhrMaintenance1 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance1";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPoolKHR")]
        public partial void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags);

        public KhrMaintenance1(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

