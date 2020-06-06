// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_shading_rate_image")]
    public unsafe partial class NVShadingRateImage : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_shading_rate_image";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindShadingRateImageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindShadingRateImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ImageView imageView, [Count(Count = 0)] ImageLayout imageLayout)
            => ImplCmdBindShadingRateImage(commandBuffer, imageView, imageLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Computed = "customSampleOrderCount"), Flow(FlowDirection.In)] CoarseSampleOrderCustomNV* pCustomSampleOrders)
            => ImplCmdSetCoarseSampleOrder(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Computed = "customSampleOrderCount"), Flow(FlowDirection.In)] ref CoarseSampleOrderCustomNV pCustomSampleOrders)
            => ImplCmdSetCoarseSampleOrder(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ShadingRatePaletteNV* pShadingRatePalettes)
            => ImplCmdSetViewportShadingRatePalette(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref ShadingRatePaletteNV pShadingRatePalettes)
            => ImplCmdSetViewportShadingRatePalette(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);

        public NVShadingRateImage(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

