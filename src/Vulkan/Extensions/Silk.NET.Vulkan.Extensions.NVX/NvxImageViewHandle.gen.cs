// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NVX
{
    [Extension("VK_NVX_image_view_handle")]
    public abstract unsafe partial class NvxImageViewHandle : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NVX_image_view_handle";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewAddressNVX")]
        public abstract unsafe Result GetImageViewAddress([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.Out)] ImageViewAddressPropertiesNVX* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewAddressNVX")]
        public abstract Result GetImageViewAddress([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageViewAddressPropertiesNVX pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewHandleNVX")]
        public abstract unsafe uint GetImageViewHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewHandleInfoNVX* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewHandleNVX")]
        public abstract uint GetImageViewHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageViewHandleInfoNVX pInfo);

        public NvxImageViewHandle(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

