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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_get_program_binary")]
    public unsafe partial class OesGetProgramBinary : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_get_program_binary";
        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] int length);

        [NativeApi(EntryPoint = "glProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public partial void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] int length) where T0 : unmanaged;

        public unsafe void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) (binary.Length * Unsafe.SizeOf<T0>()), length, binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) (binary.Length * Unsafe.SizeOf<T0>()), length, out binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) (binary.Length * Unsafe.SizeOf<T0>()), out length, binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) (binary.Length * Unsafe.SizeOf<T0>()), out length, out binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ProgramBinary(program, binaryFormat, in binary.GetPinnableReference(), (int) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public OesGetProgramBinary(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

