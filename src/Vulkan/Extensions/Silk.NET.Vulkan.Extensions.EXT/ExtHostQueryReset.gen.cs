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
    [Extension("VK_EXT_host_query_reset")]
    public abstract unsafe partial class ExtHostQueryReset : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_host_query_reset";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPoolEXT")]
        public abstract void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        public ExtHostQueryReset(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

