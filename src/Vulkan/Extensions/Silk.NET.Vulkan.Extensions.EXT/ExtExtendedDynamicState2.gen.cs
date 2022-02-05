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
    [Extension("VK_EXT_extended_dynamic_state2")]
    public unsafe partial class ExtExtendedDynamicState2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_extended_dynamic_state2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBiasEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBiasEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBiasEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLogicOpEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLogicOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] LogicOp logicOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPatchControlPointsEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPatchControlPoints([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint patchControlPoints);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveRestartEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPrimitiveRestartEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 primitiveRestartEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRasterizerDiscardEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRasterizerDiscardEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 rasterizerDiscardEnable);

        public ExtExtendedDynamicState2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

