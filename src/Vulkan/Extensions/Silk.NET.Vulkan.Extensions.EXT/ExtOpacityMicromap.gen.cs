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
    [Extension("VK_EXT_opacity_micromap")]
    public unsafe partial class ExtOpacityMicromap : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_opacity_micromap";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildMicromapsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BuildMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBuildMicromapsEXT", Convention = CallingConvention.Winapi)]
        public partial Result BuildMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapBuildInfoEXT pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildMicromapsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildMicromapsEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBuildMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapBuildInfoEXT pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryToMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToMicromapEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMemoryToMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMemoryToMicromapInfoEXT pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMicromapEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMicromapInfoEXT pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMicromapToMemoryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMicromapToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapToMemoryInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMicromapToMemoryEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdCopyMicromapToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMicromapToMemoryInfoEXT pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWriteMicromapsProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteMicromapsProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapEXT pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMemoryToMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToMicromapEXT", Convention = CallingConvention.Winapi)]
        public partial Result CopyMemoryToMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMemoryToMicromapInfoEXT pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMicromapEXT", Convention = CallingConvention.Winapi)]
        public partial Result CopyMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMicromapInfoEXT pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMicromapToMemoryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMicromapToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapToMemoryInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMicromapToMemoryEXT", Convention = CallingConvention.Winapi)]
        public partial Result CopyMicromapToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMicromapToMemoryInfoEXT pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MicromapEXT pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MicromapEXT pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MicromapEXT pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MicromapEXT pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] MicromapEXT micromap, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyMicromapEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] MicromapEXT micromap, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMicromapCompatibilityEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapVersionInfoEXT* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMicromapCompatibilityEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapVersionInfoEXT* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureCompatibilityKHR pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMicromapCompatibilityEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapVersionInfoEXT pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMicromapCompatibilityEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapVersionInfoEXT pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AccelerationStructureCompatibilityKHR pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMicromapBuildSizesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapBuildSizesInfoEXT* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.MicromapBuildSizesInfoExt);")]
        [NativeApi(EntryPoint = "vkGetMicromapBuildSizesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MicromapBuildSizesInfoEXT pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMicromapBuildSizesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapBuildInfoEXT pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapBuildSizesInfoEXT* pSizeInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.MicromapBuildSizesInfoExt);")]
        [NativeApi(EntryPoint = "vkGetMicromapBuildSizesEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapBuildInfoEXT pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MicromapBuildSizesInfoEXT pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteMicromapsProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteMicromapsProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteMicromapsProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapEXT pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result WriteMicromapsProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapEXT pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        public unsafe Result BuildMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapBuildInfoEXT> pInfos)
        {
            // ImplicitCountSpanOverloader
            return BuildMicromap(device, deferredOperation, (uint) pInfos.Length, in pInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBuildMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapBuildInfoEXT> pInfos)
        {
            // ImplicitCountSpanOverloader
            CmdBuildMicromap(commandBuffer, (uint) pInfos.Length, in pInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWriteMicromapsProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapEXT> pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // ImplicitCountSpanOverloader
            CmdWriteMicromapsProperties(commandBuffer, (uint) pMicromaps.Length, in pMicromaps.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WriteMicromapsProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return WriteMicromapsProperties(device, micromapCount, pMicromaps, queryType, (nuint) ((pData.Length) * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WriteMicromapsProperties([Count(Count = 0)] Device device, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapEXT> pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride)
        {
            // ImplicitCountSpanOverloader
            return WriteMicromapsProperties(device, (uint) pMicromaps.Length, in pMicromaps.GetPinnableReference(), queryType, dataSize, pData, stride);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WriteMicromapsProperties<T0>([Count(Count = 0)] Device device, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MicromapEXT> pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] nuint stride) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return WriteMicromapsProperties(device, (uint) pMicromaps.Length, in pMicromaps.GetPinnableReference(), queryType, (nuint) ((pData.Length) * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference(), stride);
        }

        /// <summary>To be documented.</summary>
        public unsafe AccelerationStructureCompatibilityKHR GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapVersionInfoEXT* pVersionInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceMicromapCompatibility(device, pVersionInfo, out AccelerationStructureCompatibilityKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe AccelerationStructureCompatibilityKHR GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapVersionInfoEXT pVersionInfo)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceMicromapCompatibility(device, in pVersionInfo, out AccelerationStructureCompatibilityKHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.MicromapBuildSizesInfoExt);")]
        public unsafe MicromapBuildSizesInfoEXT GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pBuildInfo)
        {
            // NonKhrReturnTypeOverloader
            GetMicromapBuildSizes(device, buildType, pBuildInfo, out MicromapBuildSizesInfoEXT silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSizeInfo = new(StructureType.MicromapBuildSizesInfoExt);")]
        public unsafe MicromapBuildSizesInfoEXT GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MicromapBuildInfoEXT pBuildInfo)
        {
            // NonKhrReturnTypeOverloader
            GetMicromapBuildSizes(device, buildType, in pBuildInfo, out MicromapBuildSizesInfoEXT silkRet);
            return silkRet;
        }

        public ExtOpacityMicromap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

