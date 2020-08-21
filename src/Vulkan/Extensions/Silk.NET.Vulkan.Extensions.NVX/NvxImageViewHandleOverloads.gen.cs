// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NVX
{
    public static class NvxImageViewHandleOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetImageViewAddress(this NvxImageViewHandle thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ImageViewAddressPropertiesNVX> pProperties)
        {
            // SpanOverloader
            return thisApi.GetImageViewAddress(device, imageView, out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe uint GetImageViewHandle(this NvxImageViewHandle thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImageViewHandleInfoNVX> pInfo)
        {
            // SpanOverloader
            return thisApi.GetImageViewHandle(device, in pInfo.GetPinnableReference());
        }

    }
}

