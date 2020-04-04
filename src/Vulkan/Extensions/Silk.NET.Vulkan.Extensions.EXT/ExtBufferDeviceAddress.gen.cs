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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_buffer_device_address")]
    public abstract unsafe partial class ExtBufferDeviceAddress : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddressEXT")]
        public abstract unsafe ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddressEXT")]
        public abstract ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        public ExtBufferDeviceAddress(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

