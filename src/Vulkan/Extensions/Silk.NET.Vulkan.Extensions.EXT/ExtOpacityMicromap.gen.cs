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
        [NativeApi(EntryPoint = "vkCmdBuildMicromapsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBuildMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint infoCount, [Count(Parameter = "infoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMemoryToMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMemoryToMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMicromap([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyMicromapToMemoryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCopyMicromapToMemory([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapToMemoryInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWriteMicromapsProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMemoryToMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMicromapToMemoryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMicromapToMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR deferredOperation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMicromapToMemoryInfoEXT* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMicromap([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapEXT* pMicromap);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyMicromapEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyMicromap([Count(Count = 0)] Device device, [Count(Count = 0)] MicromapEXT micromap, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMicromapCompatibilityEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceMicromapCompatibility([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapVersionInfoEXT* pVersionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AccelerationStructureCompatibilityKHR* pCompatibility);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMicromapBuildSizesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMicromapBuildSizes([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureBuildTypeKHR buildType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapBuildInfoEXT* pBuildInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MicromapBuildSizesInfoEXT* pSizeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWriteMicromapsPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WriteMicromapsProperties([Count(Count = 0)] Device device, [Count(Count = 0)] uint micromapCount, [Count(Parameter = "micromapCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MicromapEXT* pMicromaps, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] nuint stride);

        public ExtOpacityMicromap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

