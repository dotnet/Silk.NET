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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_sample_locations")]
    public abstract unsafe partial class ExtSampleLocations : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_sample_locations";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEXT")]
        public abstract unsafe void CmdSetSampleLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SampleLocationsInfoEXT* pSampleLocationsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEXT")]
        public abstract void CmdSetSampleLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SampleLocationsInfoEXT pSampleLocationsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        public abstract unsafe void GetPhysicalDeviceMultisampleProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] MultisamplePropertiesEXT* pMultisampleProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        public abstract void GetPhysicalDeviceMultisampleProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] out MultisamplePropertiesEXT pMultisampleProperties);

        public ExtSampleLocations(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

