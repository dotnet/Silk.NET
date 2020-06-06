// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_external_memory_capabilities")]
    public unsafe partial class NVExternalMemoryCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_external_memory_capabilities";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceExternalImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
            => ImplGetPhysicalDeviceExternalImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceExternalImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalImageFormatPropertiesNV pExternalImageFormatProperties)
            => ImplGetPhysicalDeviceExternalImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);

        public NVExternalMemoryCapabilities(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

