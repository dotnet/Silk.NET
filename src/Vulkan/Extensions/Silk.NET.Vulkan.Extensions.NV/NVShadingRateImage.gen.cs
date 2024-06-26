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
    [Extension("VK_NV_shading_rate_image")]
    public unsafe partial class NVShadingRateImage : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_shading_rate_image";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindShadingRateImageNV", Convention = CallingConvention.Winapi)]
        public partial void CmdBindShadingRateImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ImageView imageView, [Count(Count = 0)] ImageLayout imageLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoarseSampleOrderNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Parameter = "customSampleOrderCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] CoarseSampleOrderCustomNV* pCustomSampleOrders);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoarseSampleOrderNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Parameter = "customSampleOrderCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CoarseSampleOrderCustomNV pCustomSampleOrders);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportShadingRatePaletteNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShadingRatePaletteNV* pShadingRatePalettes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportShadingRatePaletteNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShadingRatePaletteNV pShadingRatePalettes);

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Parameter = "customSampleOrderCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CoarseSampleOrderCustomNV> pCustomSampleOrders)
        {
            // ImplicitCountSpanOverloader
            CmdSetCoarseSampleOrder(commandBuffer, sampleOrderType, (uint) pCustomSampleOrders.Length, in pCustomSampleOrders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShadingRatePaletteNV> pShadingRatePalettes)
        {
            // ImplicitCountSpanOverloader
            CmdSetViewportShadingRatePalette(commandBuffer, firstViewport, (uint) pShadingRatePalettes.Length, in pShadingRatePalettes.GetPinnableReference());
        }

        public NVShadingRateImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

