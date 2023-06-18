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

namespace Silk.NET.OpenGLES
{
    public unsafe partial class GL : NativeAPI
    {

        [NativeApi(EntryPoint = "glBlendBarrier", Convention = CallingConvention.Winapi)]
        public partial void BlendBarrier();

        [NativeApi(EntryPoint = "glBlendEquationi", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunci", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glColorMaski", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glCopyImageSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyImageSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum srcTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dstTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glDebugMessageCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageCallback([Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageControl", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDisablei", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glEnablei", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFramebufferTexture", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glGetDebugMessageLog", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetGraphicsResetStatus", Convention = CallingConvention.Winapi)]
        public partial GLEnum GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnUniformfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetObjectLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectPtrLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glIsEnabledi", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glMinSampleShading", Convention = CallingConvention.Winapi)]
        public partial void MinSampleShading([Flow(Silk.NET.Core.Native.FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glObjectLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void ObjectLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectPtrLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void ObjectPtrLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glPatchParameteri", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPopDebugGroup", Convention = CallingConvention.Winapi)]
        public partial void PopDebugGroup();

        [NativeApi(EntryPoint = "glPrimitiveBoundingBox", Convention = CallingConvention.Winapi)]
        public partial void PrimitiveBoundingBox([Flow(Silk.NET.Core.Native.FlowDirection.In)] float minX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float minY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float minZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float minW, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float maxW);

        [NativeApi(EntryPoint = "glPushDebugGroup", Convention = CallingConvention.Winapi)]
        public unsafe partial void PushDebugGroup([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glReadnPixels", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glTexBuffer", Convention = CallingConvention.Winapi)]
        public partial void TexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glActiveShaderProgram", Convention = CallingConvention.Winapi)]
        public partial void ActiveShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool layered, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format);

        [NativeApi(EntryPoint = "glBindProgramPipeline", Convention = CallingConvention.Winapi)]
        public partial void BindProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glBindVertexBuffer", Convention = CallingConvention.Winapi)]
        public partial void BindVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glCreateShaderProgramv", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pipelines);

        [NativeApi(EntryPoint = "glDispatchCompute", Convention = CallingConvention.Winapi)]
        public partial void DispatchCompute([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect", Convention = CallingConvention.Winapi)]
        public partial void DispatchComputeIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawArraysIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glFramebufferParameteri", Convention = CallingConvention.Winapi)]
        public partial void FramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGenProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glGetBooleani_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBoolean([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultisamplefv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramResourceiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetProgramResourceIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramResourceLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResourceName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glIsProgramPipeline", Convention = CallingConvention.Winapi)]
        public partial bool IsProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glMemoryBarrier", Convention = CallingConvention.Winapi)]
        public partial void MemoryBarrier([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glMemoryBarrierByRegion", Convention = CallingConvention.Winapi)]
        public partial void MemoryBarrierByRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glProgramUniform1i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4i", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4ui", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4f", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glSampleMaski", Convention = CallingConvention.Winapi)]
        public partial void SampleMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maskNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glUseProgramStages", Convention = CallingConvention.Winapi)]
        public partial void UseProgramStages([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stages, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgramPipeline", Convention = CallingConvention.Winapi)]
        public partial void ValidateProgramPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glVertexAttribBinding", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexAttribFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexBindingDivisor", Convention = CallingConvention.Winapi)]
        public partial void VertexBindingDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glBeginQuery", Convention = CallingConvention.Winapi)]
        public partial void BeginQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBeginTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void BeginTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBase", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glBindSampler", Convention = CallingConvention.Winapi)]
        public partial void BindSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glBindTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void BindTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindVertexArray", Convention = CallingConvention.Winapi)]
        public partial void BindVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glBlitFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum filter);

        [NativeApi(EntryPoint = "glClearBufferiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfi", Convention = CallingConvention.Winapi)]
        public partial void ClearBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClientWaitSync", Convention = CallingConvention.Winapi)]
        public partial GLEnum ClientWaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glCompressedTexImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCopyBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum readTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum writeTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glCopyTexSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void CopyTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDeleteQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSync", Convention = CallingConvention.Winapi)]
        public partial void DeleteSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDrawArraysInstanced", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum* bufs);

        [NativeApi(EntryPoint = "glDrawElementsInstanced", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawRangeElements", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElements([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glEndQuery", Convention = CallingConvention.Winapi)]
        public partial void EndQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glEndTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glFenceSync", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum condition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFlushMappedBufferRange", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetFragDataLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetFragDataLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetIntegeri_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetInteger64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64i_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetQueryiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetStringi", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* GetString([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetUniformuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetUniformBlockIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformIndices", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glIsQuery", Convention = CallingConvention.Winapi)]
        public partial bool IsQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glIsSampler", Convention = CallingConvention.Winapi)]
        public partial bool IsSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glIsSync", Convention = CallingConvention.Winapi)]
        public partial bool IsSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glIsTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial bool IsTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glIsVertexArray", Convention = CallingConvention.Winapi)]
        public partial bool IsVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glMapBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glPauseTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* binary, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glReadBuffer", Convention = CallingConvention.Winapi)]
        public partial void ReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum src);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glResumeTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void ResumeTransformFeedback();

        [NativeApi(EntryPoint = "glSamplerParameteri", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterf", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTexImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexStorage2D", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage3D", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTexSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** varyings, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum bufferMode);

        [NativeApi(EntryPoint = "glUniform1ui", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glUniform1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform2ui", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glUniform2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform3ui", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glUniform3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform4ui", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glUniform4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniformBlockBinding", Convention = CallingConvention.Winapi)]
        public partial void UniformBlockBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockBinding);

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUnmapBuffer", Convention = CallingConvention.Winapi)]
        public partial bool UnmapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glVertexAttribDivisor", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexAttribI4i", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexAttribI4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glVertexAttribI4iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribIPointer", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribIPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glWaitSync", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glActiveTexture", Convention = CallingConvention.Winapi)]
        public partial void ActiveTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum texture);

        [NativeApi(EntryPoint = "glAttachShader", Convention = CallingConvention.Winapi)]
        public partial void AttachShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glBindAttribLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindAttribLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindBuffer", Convention = CallingConvention.Winapi)]
        public partial void BindBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BindFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindTexture", Convention = CallingConvention.Winapi)]
        public partial void BindTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlendColor", Convention = CallingConvention.Winapi)]
        public partial void BlendColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] float red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparate", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunc", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum sfactor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dfactor);

        [NativeApi(EntryPoint = "glBlendFuncSeparate", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial GLEnum CheckFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glClear", Convention = CallingConvention.Winapi)]
        public partial void Clear([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glClearColor", Convention = CallingConvention.Winapi)]
        public partial void ClearColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] float red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glClearDepthf", Convention = CallingConvention.Winapi)]
        public partial void ClearDepth([Flow(Silk.NET.Core.Native.FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glClearStencil", Convention = CallingConvention.Winapi)]
        public partial void ClearStencil([Flow(Silk.NET.Core.Native.FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glColorMask", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] bool red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glCompileShader", Convention = CallingConvention.Winapi)]
        public partial void CompileShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glCompressedTexImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCopyTexImage2D", Convention = CallingConvention.Winapi)]
        public partial void CopyTexImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void CopyTexSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateProgram", Convention = CallingConvention.Winapi)]
        public partial uint CreateProgram();

        [NativeApi(EntryPoint = "glCreateShader", Convention = CallingConvention.Winapi)]
        public partial uint CreateShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type);

        [NativeApi(EntryPoint = "glCullFace", Convention = CallingConvention.Winapi)]
        public partial void CullFace([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glDeleteBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteProgram", Convention = CallingConvention.Winapi)]
        public partial void DeleteProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteShader", Convention = CallingConvention.Winapi)]
        public partial void DeleteShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDeleteTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glDepthFunc", Convention = CallingConvention.Winapi)]
        public partial void DepthFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum func);

        [NativeApi(EntryPoint = "glDepthMask", Convention = CallingConvention.Winapi)]
        public partial void DepthMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] bool flag);

        [NativeApi(EntryPoint = "glDepthRangef", Convention = CallingConvention.Winapi)]
        public partial void DepthRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] float n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDetachShader", Convention = CallingConvention.Winapi)]
        public partial void DetachShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDisable", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glDisableVertexAttribArray", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexAttribArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDrawArrays", Convention = CallingConvention.Winapi)]
        public partial void DrawArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElements", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElements([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glEnable", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glEnableVertexAttribArray", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexAttribArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFinish", Convention = CallingConvention.Winapi)]
        public partial void Finish();

        [NativeApi(EntryPoint = "glFlush", Convention = CallingConvention.Winapi)]
        public partial void Flush();

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFrontFace", Convention = CallingConvention.Winapi)]
        public partial void FrontFace([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glGenBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenerateMipmap", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glGenFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glGetActiveAttrib", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetAttachedShaders", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAttachedShaders([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* shaders);

        [NativeApi(EntryPoint = "glGetAttribLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAttribLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetBooleanv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBoolean([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetError", Convention = CallingConvention.Winapi)]
        public partial GLEnum GetError();

        [NativeApi(EntryPoint = "glGetFloatv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetIntegerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetProgramiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderInfoLog", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* range, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderSource", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetString", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* GetString([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum name);

        [NativeApi(EntryPoint = "glGetTexParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetUniformLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetVertexAttribfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glHint", Convention = CallingConvention.Winapi)]
        public partial void Hint([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glIsBuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glIsEnabled", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glIsFramebuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsProgram", Convention = CallingConvention.Winapi)]
        public partial bool IsProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glIsRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glIsShader", Convention = CallingConvention.Winapi)]
        public partial bool IsShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glIsTexture", Convention = CallingConvention.Winapi)]
        public partial bool IsTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glLineWidth", Convention = CallingConvention.Winapi)]
        public partial void LineWidth([Flow(Silk.NET.Core.Native.FlowDirection.In)] float width);

        [NativeApi(EntryPoint = "glLinkProgram", Convention = CallingConvention.Winapi)]
        public partial void LinkProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glPixelStorei", Convention = CallingConvention.Winapi)]
        public partial void PixelStore([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPolygonOffset", Convention = CallingConvention.Winapi)]
        public partial void PolygonOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] float factor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float units);

        [NativeApi(EntryPoint = "glReadPixels", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReleaseShaderCompiler", Convention = CallingConvention.Winapi)]
        public partial void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glSampleCoverage", Convention = CallingConvention.Winapi)]
        public partial void SampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] float value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glScissor", Convention = CallingConvention.Winapi)]
        public partial void Scissor([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* binary, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderSource", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glStencilFunc", Convention = CallingConvention.Winapi)]
        public partial void StencilFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum func, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparate", Convention = CallingConvention.Winapi)]
        public partial void StencilFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum func, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMask", Convention = CallingConvention.Winapi)]
        public partial void StencilMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate", Convention = CallingConvention.Winapi)]
        public partial void StencilMaskSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOp", Convention = CallingConvention.Winapi)]
        public partial void StencilOp([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum fail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum zfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum zpass);

        [NativeApi(EntryPoint = "glStencilOpSeparate", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glTexImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexParameterf", Convention = CallingConvention.Winapi)]
        public partial void TexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameteri", Convention = CallingConvention.Winapi)]
        public partial void TexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glUniform1f", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1i", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2f", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2i", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3f", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3i", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4f", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4i", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUseProgram", Convention = CallingConvention.Winapi)]
        public partial void UseProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgram", Convention = CallingConvention.Winapi)]
        public partial void ValidateProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glVertexAttrib1f", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2f", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3f", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4f", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribPointer", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glViewport", Convention = CallingConvention.Winapi)]
        public partial void Viewport([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);


        public GL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

