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

namespace Silk.NET.Vulkan.Extensions.QCOM
{
    [Extension("VK_QCOM_tile_memory_heap")]
    public unsafe partial class QComTileMemoryHeap : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_QCOM_tile_memory_heap";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTileMemoryQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTileMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TileMemoryBindInfoQCOM* pTileMemoryBindInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTileMemoryQCOM", Convention = CallingConvention.Winapi)]
        public partial void CmdBindTileMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileMemoryBindInfoQCOM pTileMemoryBindInfo);

        public QComTileMemoryHeap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

