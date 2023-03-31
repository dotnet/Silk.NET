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

namespace Silk.NET.Vulkan.Extensions.NVX
{
    public static class NvxBinaryImportOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdCuLaunchKernel(this NvxBinaryImport thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuLaunchInfoNVX> pLaunchInfo)
        {
            // SpanOverloader
            thisApi.CmdCuLaunchKernel(commandBuffer, in pLaunchInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuFunctionNVX> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, pCreateInfo, pAllocator, out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CuFunctionNVX* pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, pCreateInfo, in pAllocator.GetPinnableReference(), pFunction);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuFunctionNVX> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuFunctionCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CuFunctionNVX* pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, in pCreateInfo.GetPinnableReference(), pAllocator, pFunction);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuFunctionCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuFunctionNVX> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuFunctionCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CuFunctionNVX* pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pFunction);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuFunctionCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuFunctionNVX> pFunction)
        {
            // SpanOverloader
            return thisApi.CreateCuFunction(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pFunction.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuModuleNVX> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, pCreateInfo, pAllocator, out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CuModuleNVX* pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, pCreateInfo, in pAllocator.GetPinnableReference(), pModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuModuleNVX> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuModuleCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CuModuleNVX* pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, in pCreateInfo.GetPinnableReference(), pAllocator, pModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuModuleCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuModuleNVX> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuModuleCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CuModuleNVX* pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pModule);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CuModuleCreateInfoNVX> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<CuModuleNVX> pModule)
        {
            // SpanOverloader
            return thisApi.CreateCuModule(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyCuFunction(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CuFunctionNVX function, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyCuFunction(device, function, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyCuModule(this NvxBinaryImport thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] CuModuleNVX module, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyCuModule(device, module, in pAllocator.GetPinnableReference());
        }

    }
}

