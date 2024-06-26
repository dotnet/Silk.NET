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

namespace Silk.NET.Vulkan.Extensions.VALVE
{
    [Extension("VK_VALVE_descriptor_set_host_mapping")]
    public unsafe partial class ValveDescriptorSetHostMapping : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_VALVE_descriptor_set_host_mapping";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetHostMappingVALVE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetHostMappingValve([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] void** ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetHostMappingVALVE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetHostMappingValve([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] ref void* ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutHostMappingInfoValve([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetBindingReferenceVALVE* pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutHostMappingInfoVALVE* pHostMapping);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pHostMapping = new(StructureType.DescriptorSetLayoutHostMappingInfoValve);")]
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutHostMappingInfoValve([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetBindingReferenceVALVE* pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DescriptorSetLayoutHostMappingInfoVALVE pHostMapping);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutHostMappingInfoValve([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorSetBindingReferenceVALVE pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutHostMappingInfoVALVE* pHostMapping);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pHostMapping = new(StructureType.DescriptorSetLayoutHostMappingInfoValve);")]
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutHostMappingInfoVALVE", Convention = CallingConvention.Winapi)]
        public partial void GetDescriptorSetLayoutHostMappingInfoValve([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorSetBindingReferenceVALVE pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DescriptorSetLayoutHostMappingInfoVALVE pHostMapping);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pHostMapping = new(StructureType.DescriptorSetLayoutHostMappingInfoValve);")]
        public unsafe DescriptorSetLayoutHostMappingInfoVALVE GetDescriptorSetLayoutHostMappingInfoValve([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetBindingReferenceVALVE* pBindingReference)
        {
            // NonKhrReturnTypeOverloader
            GetDescriptorSetLayoutHostMappingInfoValve(device, pBindingReference, out DescriptorSetLayoutHostMappingInfoVALVE silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pHostMapping = new(StructureType.DescriptorSetLayoutHostMappingInfoValve);")]
        public unsafe DescriptorSetLayoutHostMappingInfoVALVE GetDescriptorSetLayoutHostMappingInfoValve([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorSetBindingReferenceVALVE pBindingReference)
        {
            // NonKhrReturnTypeOverloader
            GetDescriptorSetLayoutHostMappingInfoValve(device, in pBindingReference, out DescriptorSetLayoutHostMappingInfoVALVE silkRet);
            return silkRet;
        }

        public ValveDescriptorSetHostMapping(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

