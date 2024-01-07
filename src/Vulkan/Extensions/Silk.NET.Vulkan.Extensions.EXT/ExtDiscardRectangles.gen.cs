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
    [Extension("VK_EXT_discard_rectangles")]
    public unsafe partial class ExtDiscardRectangles : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_discard_rectangles";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDiscardRectangleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDiscardRectangle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstDiscardRectangle, [Count(Count = 0)] uint discardRectangleCount, [Count(Parameter = "discardRectangleCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect2D* pDiscardRectangles);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDiscardRectangleEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDiscardRectangle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstDiscardRectangle, [Count(Count = 0)] uint discardRectangleCount, [Count(Parameter = "discardRectangleCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Rect2D pDiscardRectangles);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDiscardRectangleEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDiscardRectangleEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 discardRectangleEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDiscardRectangleModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDiscardRectangleMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DiscardRectangleModeEXT discardRectangleMode);

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetDiscardRectangle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstDiscardRectangle, [Count(Parameter = "discardRectangleCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect2D> pDiscardRectangles)
        {
            // ImplicitCountSpanOverloader
            CmdSetDiscardRectangle(commandBuffer, firstDiscardRectangle, (uint) pDiscardRectangles.Length, in pDiscardRectangles.GetPinnableReference());
        }

        public ExtDiscardRectangles(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

