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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance3")]
    public abstract unsafe partial class KhrMaintenance3 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance3";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public abstract unsafe void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public abstract void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        public KhrMaintenance3(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

