// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NVX
{
    [Extension("VK_NVX_image_view_handle")]
    public unsafe partial class NvxImageViewHandle : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NVX_image_view_handle";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewAddressNVX")]
        public unsafe partial Result GetImageViewAddress([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.Out)] ImageViewAddressPropertiesNVX* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewAddressNVX")]
        public partial Result GetImageViewAddress([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageViewAddressPropertiesNVX pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewHandleNVX")]
        public unsafe partial uint GetImageViewHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewHandleInfoNVX* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewHandleNVX")]
        public partial uint GetImageViewHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageViewHandleInfoNVX pInfo);

        public NvxImageViewHandle(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

