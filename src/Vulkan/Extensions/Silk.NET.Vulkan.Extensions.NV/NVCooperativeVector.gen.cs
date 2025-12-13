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
    [Extension("VK_NV_cooperative_vector")]
    public unsafe partial class NVCooperativeVector : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_cooperative_vector";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdConvertCooperativeVectorMatrix([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvertCooperativeVectorMatrixInfoNV* pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdConvertCooperativeVectorMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void CmdConvertCooperativeVectorMatrix([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ConvertCooperativeVectorMatrixInfoNV pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkConvertCooperativeVectorMatrixNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ConvertCooperativeVectorMatrix([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvertCooperativeVectorMatrixInfoNV* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkConvertCooperativeVectorMatrixNV", Convention = CallingConvention.Winapi)]
        public partial Result ConvertCooperativeVectorMatrix([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ConvertCooperativeVectorMatrixInfoNV pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCooperativeVectorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CooperativeVectorPropertiesNV* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeVectorPropertiesNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCooperativeVectorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CooperativeVectorPropertiesNV pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCooperativeVectorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CooperativeVectorPropertiesNV* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeVectorPropertiesNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeVectorPropertiesNV", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceCooperativeVectorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CooperativeVectorPropertiesNV pProperties);

        /// <summary>To be documented.</summary>
        public unsafe void CmdConvertCooperativeVectorMatrix([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ConvertCooperativeVectorMatrixInfoNV> pInfos)
        {
            // ImplicitCountSpanOverloader
            CmdConvertCooperativeVectorMatrix(commandBuffer, (uint) pInfos.Length, in pInfos.GetPinnableReference());
        }

        public NVCooperativeVector(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

