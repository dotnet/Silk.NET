// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_device_generated_commands")]
    public unsafe partial class ExtDeviceGeneratedCommands : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_device_generated_commands";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsInfoEXT* pGeneratedCommandsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GeneratedCommandsInfoEXT pGeneratedCommandsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsInfoEXT* pGeneratedCommandsInfo, [Count(Count = 0)] CommandBuffer stateCommandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GeneratedCommandsInfoEXT pGeneratedCommandsInfo, [Count(Count = 0)] CommandBuffer stateCommandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectCommandsLayoutEXT pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectCommandsLayoutEXT pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectCommandsLayoutCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectCommandsLayoutCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectCommandsLayoutEXT pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectCommandsLayoutCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectCommandsLayoutCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectCommandsLayoutEXT pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectExecutionSetEXT pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectExecutionSetEXT pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectExecutionSetCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectExecutionSetCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectExecutionSetEXT pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectExecutionSetCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IndirectExecutionSetCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out IndirectExecutionSetEXT pIndirectExecutionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutEXT indirectCommandsLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutEXT indirectCommandsLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectExecutionSetEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyIndirectExecutionSet([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoEXT* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoEXT* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GeneratedCommandsMemoryRequirementsInfoEXT pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsEXT", Convention = CallingConvention.Winapi)]
        public partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GeneratedCommandsMemoryRequirementsInfoEXT pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateIndirectExecutionSetPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0)] uint executionSetWriteCount, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] WriteIndirectExecutionSetPipelineEXT* pExecutionSetWrites);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateIndirectExecutionSetPipelineEXT", Convention = CallingConvention.Winapi)]
        public partial void UpdateIndirectExecutionSetPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0)] uint executionSetWriteCount, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WriteIndirectExecutionSetPipelineEXT pExecutionSetWrites);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateIndirectExecutionSetShader([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0)] uint executionSetWriteCount, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] WriteIndirectExecutionSetShaderEXT* pExecutionSetWrites);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateIndirectExecutionSetShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void UpdateIndirectExecutionSetShader([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0)] uint executionSetWriteCount, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WriteIndirectExecutionSetShaderEXT pExecutionSetWrites);

        /// <summary>To be documented.</summary>
        public unsafe void UpdateIndirectExecutionSetPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WriteIndirectExecutionSetPipelineEXT> pExecutionSetWrites)
        {
            // ImplicitCountSpanOverloader
            UpdateIndirectExecutionSetPipeline(device, indirectExecutionSet, (uint) pExecutionSetWrites.Length, in pExecutionSetWrites.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void UpdateIndirectExecutionSetShader([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WriteIndirectExecutionSetShaderEXT> pExecutionSetWrites)
        {
            // ImplicitCountSpanOverloader
            UpdateIndirectExecutionSetShader(device, indirectExecutionSet, (uint) pExecutionSetWrites.Length, in pExecutionSetWrites.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoEXT* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetGeneratedCommandsMemoryRequirements(device, pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GeneratedCommandsMemoryRequirementsInfoEXT pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetGeneratedCommandsMemoryRequirements(device, in pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        public ExtDeviceGeneratedCommands(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

