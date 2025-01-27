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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_pipeline_binary")]
    public unsafe partial class KhrPipelineBinary : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_pipeline_binary";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PipelineBinaryHandlesInfoKHR pBinaries);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PipelineBinaryHandlesInfoKHR pBinaries);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PipelineBinaryHandlesInfoKHR pBinaries);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        [NativeApi(EntryPoint = "vkCreatePipelineBinariesKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreatePipelineBinaries([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PipelineBinaryHandlesInfoKHR pBinaries);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineBinaryKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyPipelineBinary([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineBinaryKHR pipelineBinary, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineBinaryKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroyPipelineBinary([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineBinaryKHR pipelineBinary, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineBinaryData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineBinaryDataKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPipelineBinaryData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineBinaryDataInfoKHR pInfo, [Count(Count = 0)] ref PipelineBinaryKeyKHR pPipelineBinaryKey, [Count(Count = 0)] ref nuint pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] ref T0 pPipelineBinaryData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineKeyKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineKey([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCreateInfoKHR* pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryKeyKHR* pPipelineKey);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPipelineKey = new(StructureType.PipelineBinaryKeyKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineKeyKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineKey([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCreateInfoKHR* pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PipelineBinaryKeyKHR pPipelineKey);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineKeyKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineKey([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineCreateInfoKHR pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryKeyKHR* pPipelineKey);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPipelineKey = new(StructureType.PipelineBinaryKeyKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineKeyKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPipelineKey([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineCreateInfoKHR pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PipelineBinaryKeyKHR pPipelineKey);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseCapturedPipelineDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ReleaseCapturedPipelineData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReleaseCapturedPipelineDataInfoKHR* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseCapturedPipelineDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ReleaseCapturedPipelineData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReleaseCapturedPipelineDataInfoKHR* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseCapturedPipelineDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ReleaseCapturedPipelineData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReleaseCapturedPipelineDataInfoKHR pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseCapturedPipelineDataKHR", Convention = CallingConvention.Winapi)]
        public partial Result ReleaseCapturedPipelineData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReleaseCapturedPipelineDataInfoKHR pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        public KhrPipelineBinary(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

