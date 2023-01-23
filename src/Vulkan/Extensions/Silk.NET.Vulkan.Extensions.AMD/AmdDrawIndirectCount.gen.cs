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
    [Extension("VK_AMD_draw_indirect_count")]
    public unsafe partial class AmdDrawIndirectCount : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_draw_indirect_count";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCountAMD", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCountAMD", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        public AmdDrawIndirectCount(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

