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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.ARM
{
    public static class ArmTensorsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BindTensorMemory(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindTensorMemoryInfoARM> pBindInfos)
        {
            // SpanOverloader
            return thisApi.BindTensorMemory(device, bindInfoCount, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyTensor(this ArmTensors thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTensorInfoARM> pCopyTensorInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyTensor(commandBuffer, in pCopyTensorInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorARM> pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, pCreateInfo, pAllocator, out pTensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, pCreateInfo, in pAllocator.GetPinnableReference(), pTensor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorARM> pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pTensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, in pCreateInfo.GetPinnableReference(), pAllocator, pTensor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorARM> pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pTensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorARM* pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pTensor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorARM> pTensor)
        {
            // SpanOverloader
            return thisApi.CreateTensor(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pTensor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorViewARM> pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, pCreateInfo, pAllocator, out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, pCreateInfo, in pAllocator.GetPinnableReference(), pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCreateInfoARM* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorViewARM> pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorViewCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, in pCreateInfo.GetPinnableReference(), pAllocator, pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorViewCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorViewARM> pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorViewCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TensorViewARM* pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pView);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorViewCreateInfoARM> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TensorViewARM> pView)
        {
            // SpanOverloader
            return thisApi.CreateTensorView(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyTensor(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] TensorARM tensor, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyTensor(device, tensor, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyTensorView(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] TensorViewARM tensorView, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyTensorView(device, tensorView, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDeviceTensorMemoryRequirements(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceTensorMemoryRequirementsARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceTensorMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceTensorMemoryRequirements(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceTensorMemoryRequirementsARM> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceTensorMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetDeviceTensorMemoryRequirements(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceTensorMemoryRequirementsARM> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetDeviceTensorMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalTensorProperties = new(StructureType.ExternalTensorPropertiesArm);")]
        public static unsafe void GetPhysicalDeviceExternalTensorProperties(this ArmTensors thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalTensorPropertiesARM> pExternalTensorProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalTensorProperties(physicalDevice, pExternalTensorInfo, out pExternalTensorProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceExternalTensorProperties(this ArmTensors thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalTensorInfoARM> pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalTensorPropertiesARM* pExternalTensorProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalTensorProperties(physicalDevice, in pExternalTensorInfo.GetPinnableReference(), pExternalTensorProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalTensorProperties = new(StructureType.ExternalTensorPropertiesArm);")]
        public static unsafe void GetPhysicalDeviceExternalTensorProperties(this ArmTensors thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceExternalTensorInfoARM> pExternalTensorInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalTensorPropertiesARM> pExternalTensorProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceExternalTensorProperties(physicalDevice, in pExternalTensorInfo.GetPinnableReference(), out pExternalTensorProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetTensorMemoryRequirements(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorMemoryRequirementsInfoARM* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetTensorMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetTensorMemoryRequirements(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorMemoryRequirementsInfoARM> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetTensorMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetTensorMemoryRequirements(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorMemoryRequirementsInfoARM> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetTensorMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTensorOpaqueCaptureDescriptorData<T0>(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorCaptureDescriptorDataInfoARM* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTensorOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTensorOpaqueCaptureDescriptorData(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorCaptureDescriptorDataInfoARM> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetTensorOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTensorOpaqueCaptureDescriptorData<T0>(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorCaptureDescriptorDataInfoARM> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTensorOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTensorViewOpaqueCaptureDescriptorData<T0>(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TensorViewCaptureDescriptorDataInfoARM* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTensorViewOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTensorViewOpaqueCaptureDescriptorData(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorViewCaptureDescriptorDataInfoARM> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetTensorViewOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTensorViewOpaqueCaptureDescriptorData<T0>(this ArmTensors thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TensorViewCaptureDescriptorDataInfoARM> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTensorViewOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

    }
}

