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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance5")]
    public unsafe partial class KhrMaintenance5 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance5";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindIndexBuffer2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdBindIndexBuffer2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] IndexType indexType);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageSubresourceInfo* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageSubresourceInfo* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2 pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceImageSubresourceInfo pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceImageSubresourceInfo pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2 pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2 pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageSubresource2 pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageSubresource2 pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2 pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAreaInfo* pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAreaInfo* pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderingAreaInfo pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderingAreaInfo pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        public unsafe SubresourceLayout2 GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageSubresourceInfo* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceImageSubresourceLayout(device, pInfo, out SubresourceLayout2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        public unsafe SubresourceLayout2 GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceImageSubresourceInfo pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceImageSubresourceLayout(device, in pInfo, out SubresourceLayout2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        public unsafe SubresourceLayout2 GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2* pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, pSubresource, out SubresourceLayout2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2);")]
        public unsafe SubresourceLayout2 GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageSubresource2 pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, in pSubresource, out SubresourceLayout2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe Extent2D GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAreaInfo* pRenderingAreaInfo)
        {
            // NonKhrReturnTypeOverloader
            GetRenderingAreaGranularity(device, pRenderingAreaInfo, out Extent2D silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe Extent2D GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderingAreaInfo pRenderingAreaInfo)
        {
            // NonKhrReturnTypeOverloader
            GetRenderingAreaGranularity(device, in pRenderingAreaInfo, out Extent2D silkRet);
            return silkRet;
        }

        public KhrMaintenance5(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

