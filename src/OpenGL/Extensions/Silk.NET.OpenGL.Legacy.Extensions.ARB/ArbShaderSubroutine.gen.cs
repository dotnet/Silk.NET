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
    [Extension("ARB_shader_subroutine")]
    public unsafe partial class ArbShaderSubroutine : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_subroutine";
        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv", Convention = CallingConvention.Winapi)]
        public partial void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv", Convention = CallingConvention.Winapi)]
        public partial void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv", Convention = CallingConvention.Winapi)]
        public partial void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv", Convention = CallingConvention.Winapi)]
        public partial void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint indices);

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveSubroutineUniformName(program, shadertype, index, (uint) name.Length, out length, out name.GetPinnableReference());
        }

        public unsafe void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // ImplicitCountSpanOverloader
            UniformSubroutines(shadertype, (uint) indices.Length, in indices.GetPinnableReference());
        }

        public unsafe void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // ImplicitCountSpanOverloader
            UniformSubroutines(shadertype, (uint) indices.Length, in indices.GetPinnableReference());
        }

        public ArbShaderSubroutine(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

