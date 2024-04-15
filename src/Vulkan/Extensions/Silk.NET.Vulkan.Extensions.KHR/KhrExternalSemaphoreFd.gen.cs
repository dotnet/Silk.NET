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
    [Extension("VK_KHR_external_semaphore_fd")]
    public unsafe partial class KhrExternalSemaphoreFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_fd";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int pFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreFdKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ImportSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreFdKHR", Convention = CallingConvention.Winapi)]
        public partial Result ImportSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo);

        public KhrExternalSemaphoreFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

