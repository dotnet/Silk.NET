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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_extended_get2")]
    public unsafe partial class QComExtendedGet2 : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_extended_get2";
        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Program* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Program* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Program programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Program programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Shader* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Shader* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Shader shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Shader shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtIsProgramBinaryQCOM", Convention = CallingConvention.Winapi)]
        public partial bool ExtIsProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> programs, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, numPrograms);
        }

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> programs, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, out numPrograms);
        }

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Program> programs, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, numPrograms);
        }

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Program> programs, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, out numPrograms);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> shaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, numShaders);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> shaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, out numShaders);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Shader> shaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, numShaders);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Shader> shaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, out numShaders);
        }

        public unsafe int ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgram(programs, maxPrograms, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgram(out programs, maxPrograms, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Program* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgram(programs, maxPrograms, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Program programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgram(out programs, maxPrograms, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgramBinarySource(program, shadertype, source, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgramBinarySource(program, shadertype, out source, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgramBinarySource(program, shadertype, out source, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgramBinarySource(program, shadertype, source, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgramBinarySource(program, shadertype, out source, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgramBinarySource(program, shadertype, out source, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders)
        {
            // NonKhrReturnTypeOverloader
            ExtGetShaders(shaders, maxShaders, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders)
        {
            // NonKhrReturnTypeOverloader
            ExtGetShaders(out shaders, maxShaders, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Shader* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders)
        {
            // NonKhrReturnTypeOverloader
            ExtGetShaders(shaders, maxShaders, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Shader shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders)
        {
            // NonKhrReturnTypeOverloader
            ExtGetShaders(out shaders, maxShaders, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> programs)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgram(programs, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Program> programs)
        {
            // NonKhrReturnTypeOverloader
            ExtGetProgram(programs, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> shaders)
        {
            // NonKhrReturnTypeOverloader
            ExtGetShaders(shaders, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Shader> shaders)
        {
            // NonKhrReturnTypeOverloader
            ExtGetShaders(shaders, out int silkRet);
            return silkRet;
        }

        public QComExtendedGet2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

