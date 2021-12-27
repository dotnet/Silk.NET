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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_accelerator")]
    public unsafe partial class IntelAccelerator : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_accelerator";
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] in T0 descriptor, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial nint CreateAccelerator<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] in T0 descriptor, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo<T0>([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetAcceleratorInfo<T0>([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial int ReleaseAccelerator([Flow(FlowDirection.In)] nint accelerator);

        [NativeApi(EntryPoint = "clRetainAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial int RetainAccelerator([Flow(FlowDirection.In)] nint accelerator);

        public IntelAccelerator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

