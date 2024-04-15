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
    [Extension("VK_NV_cuda_kernel_launch")]
    public unsafe partial class NVCudaKernelLaunch : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_cuda_kernel_launch";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCudaLaunchKernelNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdCudaLaunchKernel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaLaunchInfoNV* pLaunchInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCudaLaunchKernelNV", Convention = CallingConvention.Winapi)]
        public partial void CmdCudaLaunchKernel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaLaunchInfoNV pLaunchInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaFunctionNV pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaFunctionNV pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaFunctionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaFunctionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaFunctionNV pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaFunctionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public partial Result CreateCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaFunctionCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaFunctionNV pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaModuleNV pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaModuleNV pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaModuleCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaModuleCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaModuleNV pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaModuleCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCudaModuleNV", Convention = CallingConvention.Winapi)]
        public partial Result CreateCudaModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CudaModuleCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CudaModuleNV pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0)] CudaFunctionNV function, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCudaFunctionNV", Convention = CallingConvention.Winapi)]
        public partial void DestroyCudaFunction([Count(Count = 0)] Device device, [Count(Count = 0)] CudaFunctionNV function, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCudaModuleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyCudaModule([Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCudaModuleNV", Convention = CallingConvention.Winapi)]
        public partial void DestroyCudaModule([Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCudaModuleCacheNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCudaModuleCache([Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] nuint* pCacheSize, [Count(Parameter = "pCacheSize")] void* pCacheData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCudaModuleCacheNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCudaModuleCache<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] nuint* pCacheSize, [Count(Parameter = "pCacheSize")] ref T0 pCacheData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCudaModuleCacheNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCudaModuleCache([Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] ref nuint pCacheSize, [Count(Parameter = "pCacheSize")] void* pCacheData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetCudaModuleCacheNV", Convention = CallingConvention.Winapi)]
        public partial Result GetCudaModuleCache<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] ref nuint pCacheSize, [Count(Parameter = "pCacheSize")] ref T0 pCacheData) where T0 : unmanaged;

        public NVCudaKernelLaunch(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

