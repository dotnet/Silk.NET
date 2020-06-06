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
    [Extension("VK_NV_device_generated_commands")]
    public unsafe partial class NVDeviceGeneratedCommands : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_generated_commands";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipelineShaderGroupNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindPipelineShaderGroup([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint groupIndex)
            => ImplCmdBindPipelineShaderGroup(commandBuffer, pipelineBindPoint, pipeline, groupIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo)
            => ImplCmdExecuteGeneratedCommands(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsInfoNV pGeneratedCommandsInfo)
            => ImplCmdExecuteGeneratedCommands(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo)
            => ImplCmdPreprocessGeneratedCommands(commandBuffer, pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsInfoNV pGeneratedCommandsInfo)
            => ImplCmdPreprocessGeneratedCommands(commandBuffer, pGeneratedCommandsInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout)
            => ImplCreateIndirectCommandsLayout(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref IndirectCommandsLayoutCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out IndirectCommandsLayoutNV pIndirectCommandsLayout)
            => ImplCreateIndirectCommandsLayout(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyIndirectCommandsLayout(device, indirectCommandsLayout, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyIndirectCommandsLayout(device, indirectCommandsLayout, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
            => ImplGetGeneratedCommandsMemoryRequirements(device, pInfo, pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref GeneratedCommandsMemoryRequirementsInfoNV pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements)
            => ImplGetGeneratedCommandsMemoryRequirements(device, pInfo, pMemoryRequirements);

        public NVDeviceGeneratedCommands(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

