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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_external_memory_win32")]
    public abstract unsafe partial class NVExternalMemoryWin32 : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleNV")]
        public abstract unsafe Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV handleType, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleNV")]
        public abstract Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV handleType, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle);

        public NVExternalMemoryWin32(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

