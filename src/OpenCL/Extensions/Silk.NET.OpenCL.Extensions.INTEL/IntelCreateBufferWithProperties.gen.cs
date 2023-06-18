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
        public unsafe partial nint CreateBufferWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        public IntelCreateBufferWithProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

