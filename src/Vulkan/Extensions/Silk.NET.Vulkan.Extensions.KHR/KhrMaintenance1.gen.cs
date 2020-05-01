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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance1")]
    public abstract unsafe partial class KhrMaintenance1 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance1";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPoolKHR")]
        public abstract void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags);

        public KhrMaintenance1(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

