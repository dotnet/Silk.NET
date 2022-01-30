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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_external_semaphore")]
    public unsafe partial class KhrExternalSemaphore : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_external_semaphore";
        [NativeApi(EntryPoint = "clGetSemaphoreHandleForTypeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreHandleForType([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] void* handle_ptr, [Flow(FlowDirection.Out)] nuint* handle_size_ret);

        [NativeApi(EntryPoint = "clGetSemaphoreHandleForTypeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreHandleForType([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] void* handle_ptr, [Flow(FlowDirection.Out)] out nuint handle_size_ret);

        [NativeApi(EntryPoint = "clGetSemaphoreHandleForTypeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreHandleForType<T0>([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] out T0 handle_ptr, [Flow(FlowDirection.Out)] nuint* handle_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSemaphoreHandleForTypeKHR", Convention = CallingConvention.Winapi)]
        public partial int GetSemaphoreHandleForType<T0>([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] out T0 handle_ptr, [Flow(FlowDirection.Out)] out nuint handle_size_ret) where T0 : unmanaged;

        public KhrExternalSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

