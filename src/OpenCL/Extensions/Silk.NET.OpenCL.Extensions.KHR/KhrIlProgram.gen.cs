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
    [Extension("KHR_il_program")]
    public unsafe partial class KhrIlProgram : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_il_program";
        [NativeApi(EntryPoint = "clCreateProgramWithILKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* il, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithILKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* il, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithILKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 il, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithILKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateProgramWithIL<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 il, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        public KhrIlProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

