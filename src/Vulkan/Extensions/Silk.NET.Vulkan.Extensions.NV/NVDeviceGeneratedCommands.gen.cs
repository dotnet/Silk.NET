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
    [Extension("VK_NV_device_generated_commands")]
    public abstract unsafe partial class NVDeviceGeneratedCommands : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBindPipelineShaderGroupNV")]
        public abstract void CmdBindPipelineShaderGroup([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint groupIndex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        public abstract unsafe void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        public abstract void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsInfoNV pGeneratedCommandsInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        public abstract unsafe void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        public abstract void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsInfoNV pGeneratedCommandsInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        public abstract unsafe Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        public abstract Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref IndirectCommandsLayoutCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out IndirectCommandsLayoutNV pIndirectCommandsLayout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        public abstract unsafe void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        public abstract void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        public abstract unsafe void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        public abstract void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsMemoryRequirementsInfoNV pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        public NVDeviceGeneratedCommands(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

