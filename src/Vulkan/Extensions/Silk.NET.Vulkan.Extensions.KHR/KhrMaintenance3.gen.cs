// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance3")]
    public unsafe partial class KhrMaintenance3 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance3";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        public KhrMaintenance3(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

