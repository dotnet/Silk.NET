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

namespace Silk.NET.Vulkan.Extensions.ARM
{
    [Extension("VK_ARM_tensors")]
    public unsafe partial class ArmTensors : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_ARM_tensors";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindTensorMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindTensorMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindTensorMemoryInfoARM* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindTensorMemoryARM", Convention = CallingConvention.Winapi)]
        public partial Result BindTensorMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BindTensorMemoryInfoARM pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyTensor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTensorInfoARM* pCopyTensorInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyTensorARM", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyTensor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTensorInfoARM pCopyTensorInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorARM pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorARM pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorARM pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorARM", Convention = CallingConvention.Winapi)]
        public partial Result CreateTensor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorARM pTensor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorViewARM pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorViewARM pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorViewCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorViewCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorViewARM pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorViewCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateTensorViewARM", Convention = CallingConvention.Winapi)]
        public partial Result CreateTensorView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorViewCreateInfoARM pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TensorViewARM pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyTensorARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyTensor([Count(Count = 0)] Device device, [Count(Count = 0)] TensorARM tensor, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyTensorARM", Convention = CallingConvention.Winapi)]
        public partial void DestroyTensor([Count(Count = 0)] Device device, [Count(Count = 0)] TensorARM tensor, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyTensorViewARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyTensorView([Count(Count = 0)] Device device, [Count(Count = 0)] TensorViewARM tensorView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyTensorViewARM", Convention = CallingConvention.Winapi)]
        public partial void DestroyTensorView([Count(Count = 0)] Device device, [Count(Count = 0)] TensorViewARM tensorView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceTensorMemoryRequirementsARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceTensorMemoryRequirementsARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceTensorMemoryRequirementsARM pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetDeviceTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public partial void GetDeviceTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceTensorMemoryRequirementsARM pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalTensorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalTensorPropertiesARM* pExternalTensorProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalTensorProperties = new(StructureType.ExternalTensorPropertiesArm);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalTensorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalTensorPropertiesARM pExternalTensorProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalTensorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PhysicalDeviceExternalTensorInfoARM pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalTensorPropertiesARM* pExternalTensorProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalTensorProperties = new(StructureType.ExternalTensorPropertiesArm);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalTensorPropertiesARM", Convention = CallingConvention.Winapi)]
        public partial void GetPhysicalDeviceExternalTensorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PhysicalDeviceExternalTensorInfoARM pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalTensorPropertiesARM pExternalTensorProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorMemoryRequirementsInfoARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorMemoryRequirementsInfoARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorMemoryRequirementsInfoARM pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetTensorMemoryRequirementsARM", Convention = CallingConvention.Winapi)]
        public partial void GetTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorMemoryRequirementsInfoARM pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTensorOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCaptureDescriptorDataInfoARM* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTensorOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCaptureDescriptorDataInfoARM* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTensorOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorCaptureDescriptorDataInfoARM pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public partial Result GetTensorOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorCaptureDescriptorDataInfoARM pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTensorViewOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCaptureDescriptorDataInfoARM* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTensorViewOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCaptureDescriptorDataInfoARM* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTensorViewOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorViewCaptureDescriptorDataInfoARM pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetTensorViewOpaqueCaptureDescriptorDataARM", Convention = CallingConvention.Winapi)]
        public partial Result GetTensorViewOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorViewCaptureDescriptorDataInfoARM pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        public unsafe Result BindTensorMemory([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindTensorMemoryInfoARM> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindTensorMemory(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetDeviceTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceTensorMemoryRequirementsARM* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceTensorMemoryRequirements(device, pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetDeviceTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceTensorMemoryRequirementsARM pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceTensorMemoryRequirements(device, in pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalTensorProperties = new(StructureType.ExternalTensorPropertiesArm);")]
        public unsafe ExternalTensorPropertiesARM GetPhysicalDeviceExternalTensorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceExternalTensorProperties(physicalDevice, pExternalTensorInfo, out ExternalTensorPropertiesARM silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalTensorProperties = new(StructureType.ExternalTensorPropertiesArm);")]
        public unsafe ExternalTensorPropertiesARM GetPhysicalDeviceExternalTensorProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PhysicalDeviceExternalTensorInfoARM pExternalTensorInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceExternalTensorProperties(physicalDevice, in pExternalTensorInfo, out ExternalTensorPropertiesARM silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorMemoryRequirementsInfoARM* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetTensorMemoryRequirements(device, pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetTensorMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TensorMemoryRequirementsInfoARM pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetTensorMemoryRequirements(device, in pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        public ArmTensors(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

