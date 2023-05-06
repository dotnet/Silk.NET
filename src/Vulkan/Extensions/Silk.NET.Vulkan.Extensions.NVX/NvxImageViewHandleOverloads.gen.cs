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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NVX
{
    public static class NvxImageViewHandleOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ImageViewAddressPropertiesNvx);")]
        public static unsafe Result GetImageViewAddress(this NvxImageViewHandle thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageViewAddressPropertiesNVX> pProperties)
        {
            // SpanOverloader
            return thisApi.GetImageViewAddress(device, imageView, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe uint GetImageViewHandle(this NvxImageViewHandle thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewHandleInfoNVX> pInfo)
        {
            // SpanOverloader
            return thisApi.GetImageViewHandle(device, in pInfo.GetPinnableReference());
        }

    }
}

