// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_bind_memory2")]
    public unsafe partial class KhrBindMemory2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_bind_memory2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2KHR")]
        public unsafe partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2KHR")]
        public partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindBufferMemoryInfo pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2KHR")]
        public unsafe partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2KHR")]
        public partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindImageMemoryInfo pBindInfos);

        public KhrBindMemory2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

