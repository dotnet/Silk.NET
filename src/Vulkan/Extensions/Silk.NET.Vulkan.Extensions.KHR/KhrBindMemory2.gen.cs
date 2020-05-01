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
    [Extension("VK_KHR_bind_memory2")]
    public abstract unsafe partial class KhrBindMemory2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_bind_memory2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2KHR")]
        public abstract unsafe Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2KHR")]
        public abstract Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindBufferMemoryInfo pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2KHR")]
        public abstract unsafe Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2KHR")]
        public abstract Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindImageMemoryInfo pBindInfos);

        public KhrBindMemory2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

