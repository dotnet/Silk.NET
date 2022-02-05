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
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] uint* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] uint* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] out uint programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] out uint programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Program* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Program* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] out Program programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] out Program programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out byte source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out byte source, [Flow(FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out byte source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out byte source, [Flow(FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "length"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source, [Flow(FlowDirection.Out)] out int length);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] uint* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] uint* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] out uint shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] out uint shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Shader* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Shader* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] out Shader shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] out Shader shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtIsProgramBinaryQCOM", Convention = CallingConvention.Winapi)]
        public partial bool ExtIsProgramBinary([Flow(FlowDirection.In)] uint program);

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<uint> programs, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, numPrograms);
        }

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<uint> programs, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, out numPrograms);
        }

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<Program> programs, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, numPrograms);
        }

        public unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<Program> programs, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms)
        {
            // ImplicitCountSpanOverloader
            ExtGetProgram(out programs.GetPinnableReference(), (int) programs.Length, out numPrograms);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<uint> shaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, numShaders);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<uint> shaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, out numShaders);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<Shader> shaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, numShaders);
        }

        public unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<Shader> shaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders)
        {
            // ImplicitCountSpanOverloader
            ExtGetShaders(out shaders.GetPinnableReference(), (int) shaders.Length, out numShaders);
        }

        public QComExtendedGet2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

