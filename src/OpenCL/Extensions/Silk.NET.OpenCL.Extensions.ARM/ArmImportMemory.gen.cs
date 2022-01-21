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

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Extension("ARM_import_memory")]
    public unsafe partial class ArmImportMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "ARM_import_memory";
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public partial nint ImportMemory<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        public ArmImportMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

