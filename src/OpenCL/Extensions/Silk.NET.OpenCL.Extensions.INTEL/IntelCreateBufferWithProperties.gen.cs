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
    [Extension("INTEL_create_buffer_with_properties")]
    public unsafe partial class IntelCreateBufferWithProperties : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_create_buffer_with_properties";
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        public IntelCreateBufferWithProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

