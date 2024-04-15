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

namespace Silk.NET.Vulkan.Extensions.FUCHSIA
{
    [Extension("VK_FUCHSIA_external_semaphore")]
    public unsafe partial class FuchsiaExternalSemaphore : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_FUCHSIA_external_semaphore";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public partial Result GetSemaphoreZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ImportSemaphoreZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public partial Result ImportSemaphoreZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImportSemaphoreZirconHandleInfoFUCHSIA pImportSemaphoreZirconHandleInfo);

        public FuchsiaExternalSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

