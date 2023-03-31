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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    public static class ArmImportMemoryOverloads
    {
        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, memory, size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, out memory.GetPinnableReference(), size, errcode_ret);
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, out memory.GetPinnableReference(), size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), memory, size, errcode_ret);
        }

        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), memory, size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), out memory.GetPinnableReference(), size, errcode_ret);
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), out memory.GetPinnableReference(), size, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, memory, size, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, out memory.GetPinnableReference(), size, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, out memory.GetPinnableReference(), size, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), memory, size, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), memory, size, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), out memory.GetPinnableReference(), size, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, ARM) are deprecated in favour of the \"grouped\" enums (MemFlags, ImportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), out memory.GetPinnableReference(), size, out errcode_ret.GetPinnableReference());
        }

    }
}

