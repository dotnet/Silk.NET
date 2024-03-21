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
        public unsafe partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageSubresourceInfoKHR* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageSubresourceInfoKHR* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2KHR pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceImageSubresourceInfoKHR pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        [NativeApi(EntryPoint = "vkGetDeviceImageSubresourceLayoutKHR", Convention = CallingConvention.Winapi)]
        public partial void GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceImageSubresourceInfoKHR pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2KHR pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2KHR pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresource2KHR pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2KHR", Convention = CallingConvention.Winapi)]
        public partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresource2KHR pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2KHR pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAreaInfoKHR* pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAreaInfoKHR* pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingAreaInfoKHR pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderingAreaGranularityKHR", Convention = CallingConvention.Winapi)]
        public partial void GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingAreaInfoKHR pRenderingAreaInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public unsafe SubresourceLayout2KHR GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageSubresourceInfoKHR* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceImageSubresourceLayout(device, pInfo, out SubresourceLayout2KHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public unsafe SubresourceLayout2KHR GetDeviceImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceImageSubresourceInfoKHR pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceImageSubresourceLayout(device, in pInfo, out SubresourceLayout2KHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public unsafe SubresourceLayout2KHR GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, pSubresource, out SubresourceLayout2KHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public unsafe SubresourceLayout2KHR GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresource2KHR pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, in pSubresource, out SubresourceLayout2KHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe Extent2D GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAreaInfoKHR* pRenderingAreaInfo)
        {
            // NonKhrReturnTypeOverloader
            GetRenderingAreaGranularity(device, pRenderingAreaInfo, out Extent2D silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe Extent2D GetRenderingAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingAreaInfoKHR pRenderingAreaInfo)
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

