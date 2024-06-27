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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_get_program_binary")]
    public unsafe partial class ArbGetProgramBinary : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_get_program_binary";
        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public partial void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* binary, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glProgramBinary", Convention = CallingConvention.Winapi)]
        public partial void ProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 binary, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramParameterPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        public unsafe void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) ((binary.Length) * Unsafe.SizeOf<T0>()), length, binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) ((binary.Length) * Unsafe.SizeOf<T0>()), length, out binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) ((binary.Length) * Unsafe.SizeOf<T0>()), out length, binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetProgramBinary(program, (uint) ((binary.Length) * Unsafe.SizeOf<T0>()), out length, out binaryFormat, out binary.GetPinnableReference());
        }

        public unsafe void ProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ProgramBinary(program, binaryFormat, in binary.GetPinnableReference(), (uint) ((binary.Length) * Unsafe.SizeOf<T0>()));
        }

        public unsafe T0 GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetProgramBinary(program, bufSize, length, binaryFormat, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetProgramBinary(program, bufSize, length, out binaryFormat, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetProgramBinary(program, bufSize, out length, binaryFormat, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetProgramBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB binaryFormat) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetProgramBinary(program, bufSize, out length, out binaryFormat, out T0 silkRet);
            return silkRet;
        }

        public ArbGetProgramBinary(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

