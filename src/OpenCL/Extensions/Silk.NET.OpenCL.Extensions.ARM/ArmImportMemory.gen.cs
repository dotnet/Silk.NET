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
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public unsafe partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clImportMemoryARM", Convention = CallingConvention.Winapi)]
        public partial nint ImportMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        public ArmImportMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

