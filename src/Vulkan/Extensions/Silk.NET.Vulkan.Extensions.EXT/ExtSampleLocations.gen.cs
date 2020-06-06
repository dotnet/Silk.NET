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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_sample_locations")]
    public unsafe partial class ExtSampleLocations : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_sample_locations";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdSetSampleLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SampleLocationsInfoEXT* pSampleLocationsInfo)
            => ImplCmdSetSampleLocation(commandBuffer, pSampleLocationsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetSampleLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SampleLocationsInfoEXT pSampleLocationsInfo)
            => ImplCmdSetSampleLocation(commandBuffer, pSampleLocationsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceMultisampleProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] MultisamplePropertiesEXT* pMultisampleProperties)
            => ImplGetPhysicalDeviceMultisampleProperties(physicalDevice, samples, pMultisampleProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceMultisampleProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] out MultisamplePropertiesEXT pMultisampleProperties)
            => ImplGetPhysicalDeviceMultisampleProperties(physicalDevice, samples, pMultisampleProperties);

        public ExtSampleLocations(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

