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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVCudaKernelLaunchOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdCudaLaunchKernel(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaLaunchInfoNV> pLaunchInfo)
        {
            // SpanOverloader
            thisApi.CmdCudaLaunchKernel(commandBuffer, in pLaunchInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaFunctionNV> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, pCreateInfo, pAllocator, out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, pCreateInfo, in pAllocator.GetPinnableReference(), pFunction);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaFunctionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaFunctionNV> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaFunctionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, in pCreateInfo.GetPinnableReference(), pAllocator, pFunction);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaFunctionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaFunctionNV> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaFunctionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaFunctionNV* pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pFunction);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaFunctionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaFunctionNV> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCudaFunction(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaModuleNV> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, pCreateInfo, pAllocator, out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, pCreateInfo, in pAllocator.GetPinnableReference(), pModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CudaModuleCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaModuleNV> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaModuleCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, in pCreateInfo.GetPinnableReference(), pAllocator, pModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaModuleCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaModuleNV> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaModuleCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CudaModuleNV* pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CudaModuleCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CudaModuleNV> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCudaModule(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyCudaFunction(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CudaFunctionNV function, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyCudaFunction(device, function, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyCudaModule(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyCudaModule(device, module, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCudaModuleCache<T0>(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] nuint* pCacheSize, [Count(Parameter = "pCacheSize")] Span<T0> pCacheData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetCudaModuleCache(device, module, pCacheSize, ref pCacheData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCudaModuleCache(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] Span<nuint> pCacheSize, [Count(Parameter = "pCacheSize")] void* pCacheData)
        {
            // SpanOverloader
            return thisApi.GetCudaModuleCache(device, module, ref pCacheSize.GetPinnableReference(), pCacheData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCudaModuleCache<T0>(this NVCudaKernelLaunch thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CudaModuleNV module, [Count(Count = 0)] Span<nuint> pCacheSize, [Count(Parameter = "pCacheSize")] Span<T0> pCacheData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetCudaModuleCache(device, module, ref pCacheSize.GetPinnableReference(), ref pCacheData.GetPinnableReference());
        }

    }
}

