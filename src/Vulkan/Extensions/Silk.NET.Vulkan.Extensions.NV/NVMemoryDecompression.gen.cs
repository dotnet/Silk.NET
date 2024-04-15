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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_memory_decompression")]
    public unsafe partial class NVMemoryDecompression : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_memory_decompression";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDecompressMemoryNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDecompressMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint decompressRegionCount, [Count(Parameter = "decompressRegionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DecompressMemoryRegionNV* pDecompressMemoryRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDecompressMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void CmdDecompressMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint decompressRegionCount, [Count(Parameter = "decompressRegionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DecompressMemoryRegionNV pDecompressMemoryRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDecompressMemoryIndirectCountNV", Convention = CallingConvention.Winapi)]
        public partial void CmdDecompressMemoryIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong indirectCommandsAddress, [Count(Count = 0)] ulong indirectCommandsCountAddress, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        public unsafe void CmdDecompressMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "decompressRegionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DecompressMemoryRegionNV> pDecompressMemoryRegions)
        {
            // ImplicitCountSpanOverloader
            CmdDecompressMemory(commandBuffer, (uint) pDecompressMemoryRegions.Length, in pDecompressMemoryRegions.GetPinnableReference());
        }

        public NVMemoryDecompression(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

