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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_push_descriptor")]
    public abstract unsafe partial class KhrPushDescriptor : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetKHR")]
        public abstract unsafe void CmdPushDescriptorSet([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetKHR")]
        public abstract void CmdPushDescriptorSet([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] ref WriteDescriptorSet pDescriptorWrites);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public abstract unsafe void CmdPushDescriptorSetWithTemplate([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] void* pData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public abstract void CmdPushDescriptorSetWithTemplate<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        public KhrPushDescriptor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

