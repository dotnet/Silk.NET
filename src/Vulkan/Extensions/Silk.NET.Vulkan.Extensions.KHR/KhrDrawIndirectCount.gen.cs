// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_draw_indirect_count")]
    public unsafe partial class KhrDrawIndirectCount : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_draw_indirect_count";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCountKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawIndexedIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCountKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

        public KhrDrawIndirectCount(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

