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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_memory_decompression")]
    public unsafe partial class ExtMemoryDecompression : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_memory_decompression";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDecompressMemoryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDecompressMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DecompressMemoryInfoEXT* pDecompressMemoryInfoEXT);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDecompressMemoryEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDecompressMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DecompressMemoryInfoEXT pDecompressMemoryInfoEXT);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDecompressMemoryIndirectCountEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDecompressMemoryIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] MemoryDecompressionMethodFlagsEXT decompressionMethod, [Count(Count = 0)] ulong indirectCommandsAddress, [Count(Count = 0)] ulong indirectCommandsCountAddress, [Count(Count = 0)] uint maxDecompressionCount, [Count(Count = 0)] uint stride);

        public ExtMemoryDecompression(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

