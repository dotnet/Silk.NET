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
    [Extension("KHR_suggested_local_work_size")]
    public unsafe partial class KhrSuggestedLocalWorkSize : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_suggested_local_work_size";
        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* suggested_local_work_size);

        [NativeApi(EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR", Convention = CallingConvention.Winapi)]
        public partial int GetKernelSuggestedLocalWorkSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint suggested_local_work_size);

        public KhrSuggestedLocalWorkSize(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

