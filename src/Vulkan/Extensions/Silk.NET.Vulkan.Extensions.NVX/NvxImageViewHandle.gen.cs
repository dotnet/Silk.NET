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

namespace Silk.NET.Vulkan.Extensions.NVX
{
    [Extension("VK_NVX_image_view_handle")]
    public unsafe partial class NvxImageViewHandle : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NVX_image_view_handle";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewAddressNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageViewAddress([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageViewAddressPropertiesNVX* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ImageViewAddressPropertiesNvx);")]
        [NativeApi(EntryPoint = "vkGetImageViewAddressNVX", Convention = CallingConvention.Winapi)]
        public partial Result GetImageViewAddress([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ImageViewAddressPropertiesNVX pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewHandleNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetImageViewHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewHandleInfoNVX* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewHandleNVX", Convention = CallingConvention.Winapi)]
        public partial uint GetImageViewHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageViewHandleInfoNVX pInfo);

        public NvxImageViewHandle(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

