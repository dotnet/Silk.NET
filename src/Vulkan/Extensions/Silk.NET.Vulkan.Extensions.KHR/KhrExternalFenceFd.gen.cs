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
    [Extension("VK_KHR_external_fence_fd")]
    public unsafe partial class KhrExternalFenceFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_fence_fd";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FenceGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FenceGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportFenceFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ImportFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImportFenceFdInfoKHR* pImportFenceFdInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportFenceFdKHR", Convention = CallingConvention.Winapi)]
        public partial Result ImportFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImportFenceFdInfoKHR pImportFenceFdInfo);

        public KhrExternalFenceFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

