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
    [Extension("VK_QCOM_tile_properties")]
    public unsafe partial class QComTileProperties : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_QCOM_tile_properties";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDynamicRenderingTileProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingInfo* pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TilePropertiesQCOM* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        [NativeApi(EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDynamicRenderingTileProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingInfo* pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TilePropertiesQCOM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDynamicRenderingTileProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingInfo pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TilePropertiesQCOM* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        [NativeApi(EntryPoint = "vkGetDynamicRenderingTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public partial Result GetDynamicRenderingTileProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingInfo pRenderingInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TilePropertiesQCOM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFramebufferTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFramebufferTileProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TilePropertiesQCOM* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        [NativeApi(EntryPoint = "vkGetFramebufferTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFramebufferTileProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] uint* pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TilePropertiesQCOM pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFramebufferTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFramebufferTileProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] ref uint pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TilePropertiesQCOM* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.TilePropertiesQCom);")]
        [NativeApi(EntryPoint = "vkGetFramebufferTilePropertiesQCOM", Convention = CallingConvention.Winapi)]
        public partial Result GetFramebufferTileProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0)] ref uint pPropertiesCount, [Count(Parameter = "pPropertiesCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TilePropertiesQCOM pProperties);

        public QComTileProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

