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
    [Extension("VK_EXT_multi_draw")]
    public unsafe partial class ExtMultiDraw : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_multi_draw";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMultiEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDrawMult([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MultiDrawInfoEXT* pVertexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMultiEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawMult([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MultiDrawInfoEXT pVertexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMultiIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDrawMultiIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MultiDrawIndexedInfoEXT* pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pVertexOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMultiIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDrawMultiIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MultiDrawIndexedInfoEXT* pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pVertexOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMultiIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDrawMultiIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MultiDrawIndexedInfoEXT pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pVertexOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMultiIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawMultiIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MultiDrawIndexedInfoEXT pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pVertexOffset);

        /// <summary>To be documented.</summary>
        public unsafe void CmdDrawMult([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MultiDrawInfoEXT> pVertexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride)
        {
            // ImplicitCountSpanOverloader
            CmdDrawMult(commandBuffer, (uint) pVertexInfo.Length, in pVertexInfo.GetPinnableReference(), instanceCount, firstInstance, stride);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdDrawMultiIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MultiDrawIndexedInfoEXT> pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pVertexOffset)
        {
            // ImplicitCountSpanOverloader
            CmdDrawMultiIndexed(commandBuffer, (uint) pIndexInfo.Length, in pIndexInfo.GetPinnableReference(), instanceCount, firstInstance, stride, pVertexOffset);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdDrawMultiIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MultiDrawIndexedInfoEXT> pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pVertexOffset)
        {
            // ImplicitCountSpanOverloader
            CmdDrawMultiIndexed(commandBuffer, (uint) pIndexInfo.Length, in pIndexInfo.GetPinnableReference(), instanceCount, firstInstance, stride, in pVertexOffset);
        }

        public ExtMultiDraw(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

