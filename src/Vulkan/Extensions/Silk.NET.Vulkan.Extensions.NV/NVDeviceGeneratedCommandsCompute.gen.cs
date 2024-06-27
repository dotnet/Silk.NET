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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_device_generated_commands_compute")]
    public unsafe partial class NVDeviceGeneratedCommandsCompute : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_generated_commands_compute";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdatePipelineIndirectBufferNV", Convention = CallingConvention.Winapi)]
        public partial void CmdUpdatePipelineIndirectBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineIndirectDeviceAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetPipelineIndirectDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineIndirectDeviceAddressInfoNV* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineIndirectDeviceAddressNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetPipelineIndirectDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineIndirectDeviceAddressInfoNV pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPipelineIndirectMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPipelineIndirectMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPipelineIndirectMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetPipelineIndirectMemoryRequirementsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPipelineIndirectMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetPipelineIndirectMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPipelineIndirectMemoryRequirements(device, pCreateInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetPipelineIndirectMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineCreateInfo pCreateInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPipelineIndirectMemoryRequirements(device, in pCreateInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        public NVDeviceGeneratedCommandsCompute(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

