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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_separate_shader_objects")]
    public unsafe partial class ArbSeparateShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_separate_shader_objects";
        [NativeApi(EntryPoint = "glActiveShaderProgram", Convention = CallingConvention.Winapi)]
        public partial void ActiveShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glBindProgramPipeline", Convention = CallingConvention.Winapi)]
        public partial void BindProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glCreateShaderProgramv", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramv", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramv", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramv", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* strings);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines", Convention = CallingConvention.Winapi)]
        public partial void DeleteProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines", Convention = CallingConvention.Winapi)]
        public partial void DeleteProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines", Convention = CallingConvention.Winapi)]
        public partial void GenProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines", Convention = CallingConvention.Winapi)]
        public partial void GenProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv", Convention = CallingConvention.Winapi)]
        public partial void GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string infoLog);

        [NativeApi(EntryPoint = "glIsProgramPipeline", Convention = CallingConvention.Winapi)]
        public partial bool IsProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramParameterPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramUniform1i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1iv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glProgramUniform1f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniform1d", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v0);

        [NativeApi(EntryPoint = "glProgramUniform1dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform1dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniform1ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1uiv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform2i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2iv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glProgramUniform2f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniform2d", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1);

        [NativeApi(EntryPoint = "glProgramUniform2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform2dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniform2ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2uiv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform3i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3iv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glProgramUniform3f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniform3d", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2);

        [NativeApi(EntryPoint = "glProgramUniform3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform3dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniform3ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3uiv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform4i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4iv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glProgramUniform4f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniform4d", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v3);

        [NativeApi(EntryPoint = "glProgramUniform4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform4dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniform4ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4uiv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double value);

        [NativeApi(EntryPoint = "glUseProgramStages", Convention = CallingConvention.Winapi)]
        public partial void UseProgramStages([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stages, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glUseProgramStages", Convention = CallingConvention.Winapi)]
        public partial void UseProgramStages([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UseProgramStageMask stages, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgramPipeline", Convention = CallingConvention.Winapi)]
        public partial void ValidateProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline);

        public unsafe uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((nint) strings, stringsSa);
            SilkMarshal.Free((nint) strings);
            return ret;
        }

        public unsafe uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((nint) strings, stringsSa);
            SilkMarshal.Free((nint) strings);
            return ret;
        }

        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        public unsafe void DeleteProgramPipelines([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pipelines)
        {
            // ImplicitCountSpanOverloader
            DeleteProgramPipelines((uint) pipelines.Length, in pipelines.GetPinnableReference());
        }

        public unsafe void DeleteProgramPipelines([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramPipeline> pipelines)
        {
            // ImplicitCountSpanOverloader
            DeleteProgramPipelines((uint) pipelines.Length, in pipelines.GetPinnableReference());
        }

        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe void GenProgramPipelines([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pipelines)
        {
            // ImplicitCountSpanOverloader
            GenProgramPipelines((uint) pipelines.Length, out pipelines.GetPinnableReference());
        }

        public unsafe void GenProgramPipelines([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ProgramPipeline> pipelines)
        {
            // ImplicitCountSpanOverloader
            GenProgramPipelines((uint) pipelines.Length, out pipelines.GetPinnableReference());
        }

        public unsafe void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetProgramPipelineInfoLog(pipeline, (uint) infoLog.Length, length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetProgramPipelineInfoLog(pipeline, (uint) infoLog.Length, length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetProgramPipelineInfoLog(pipeline, (uint) infoLog.Length, out length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetProgramPipelineInfoLog(pipeline, (uint) infoLog.Length, out length, out infoLog.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2(program, location, (uint) value.Length/4, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2(program, location, (uint) value.Length/4, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x3(program, location, (uint) value.Length/6, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x3(program, location, (uint) value.Length/6, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x4(program, location, (uint) value.Length/8, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x4(program, location, (uint) value.Length/8, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3(program, location, (uint) value.Length/9, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3(program, location, (uint) value.Length/9, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x2(program, location, (uint) value.Length/6, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x2(program, location, (uint) value.Length/6, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x4(program, location, (uint) value.Length/12, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x4(program, location, (uint) value.Length/12, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4(program, location, (uint) value.Length/16, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4(program, location, (uint) value.Length/16, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x2(program, location, (uint) value.Length/8, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x2(program, location, (uint) value.Length/8, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x3(program, location, (uint) value.Length/12, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x3(program, location, (uint) value.Length/12, transpose, in value.GetPinnableReference());
        }

        public unsafe uint GenProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenProgramPipelines(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetProgramPipeline(pipeline, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetProgramPipeline(pipeline, pname, out int silkRet);
            return silkRet;
        }

        public unsafe byte GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramPipelineInfoLog(pipeline, bufSize, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramPipelineInfoLog(pipeline, bufSize, out length, out byte silkRet);
            return silkRet;
        }

        public ArbSeparateShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

