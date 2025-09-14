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
    [Extension("VK_QCOM_tile_shading")]
    public unsafe partial class QComTileShading : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_QCOM_tile_shading";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginPerTileExecutionQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginPerTileExecution([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerTileBeginInfoQCOM* pPerTileBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginPerTileExecutionQCOM", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginPerTileExecution([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PerTileBeginInfoQCOM pPerTileBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchTileQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDispatchTile([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DispatchTileInfoQCOM* pDispatchTileInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchTileQCOM", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchTile([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DispatchTileInfoQCOM pDispatchTileInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndPerTileExecutionQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndPerTileExecution([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PerTileEndInfoQCOM* pPerTileEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndPerTileExecutionQCOM", Convention = CallingConvention.Winapi)]
        public partial void CmdEndPerTileExecution([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PerTileEndInfoQCOM pPerTileEndInfo);

        public QComTileShading(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

