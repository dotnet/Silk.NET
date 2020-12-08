// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtBufferDeviceAddressOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe ulong GetBufferDeviceAddress(this ExtBufferDeviceAddress thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<BufferDeviceAddressInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.GetBufferDeviceAddress(device, in pInfo.GetPinnableReference());
        }

    }
}

