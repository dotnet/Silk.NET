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
    [Extension("KHR_icd")]
    public unsafe partial class KhrIcd : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_icd";
        [NativeApi(EntryPoint = "clIcdGetFunctionAddressForPlatformKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void* IcdGetFunctionAddressForPlatform([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* func_name);

        [NativeApi(EntryPoint = "clIcdGetFunctionAddressForPlatformKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void* IcdGetFunctionAddressForPlatform([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte func_name);

        [NativeApi(EntryPoint = "clIcdGetFunctionAddressForPlatformKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void* IcdGetFunctionAddressForPlatform([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string func_name);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int IcdGetPlatformIDs([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int IcdGetPlatformIDs([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int IcdGetPlatformIDs([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR", Convention = CallingConvention.Winapi)]
        public partial int IcdGetPlatformIDs([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_platforms);

        [NativeApi(EntryPoint = "clIcdSetPlatformDispatchDataKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int IcdSetPlatformDispatchData([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dispatch_data);

        [NativeApi(EntryPoint = "clIcdSetPlatformDispatchDataKHR", Convention = CallingConvention.Winapi)]
        public partial int IcdSetPlatformDispatchData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dispatch_data) where T0 : unmanaged;

        public KhrIcd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

