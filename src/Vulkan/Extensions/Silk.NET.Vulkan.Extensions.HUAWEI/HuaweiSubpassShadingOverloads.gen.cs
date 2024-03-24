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

namespace Silk.NET.Vulkan.Extensions.HUAWEI
{
    public static class HuaweiSubpassShadingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceSubpassShadingMaxWorkgroupSizeHuawei(this HuaweiSubpassShading thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderpass, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Extent2D> pMaxWorkgroupSize)
        {
            // SpanOverloader
            return thisApi.GetDeviceSubpassShadingMaxWorkgroupSizeHuawei(device, renderpass, out pMaxWorkgroupSize.GetPinnableReference());
        }

    }
}

