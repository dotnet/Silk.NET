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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback")]
    public unsafe partial class NVTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback";
        [NativeApi(EntryPoint = "glActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public partial void ActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public partial void ActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void BeginTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void BeginTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferBaseNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferRangeNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glBindBufferRangeNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glEndTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbackVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int location);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetVaryingLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV", Convention = CallingConvention.Winapi)]
        public partial int GetVaryingLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV", Convention = CallingConvention.Winapi)]
        public partial int GetVaryingLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackTokenNV* locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TransformFeedbackTokenNV locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackTokenNV* locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TransformFeedbackTokenNV locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveVarying(program, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void TransformFeedbackStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribs, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackStreamAttrib(count, attribs, (uint) bufstreams.Length, in bufstreams.GetPinnableReference(), bufferMode);
        }

        public unsafe void TransformFeedbackStreamAttrib([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackStreamAttrib((uint) attribs.Length, in attribs.GetPinnableReference(), nbuffers, bufstreams, bufferMode);
        }

        public unsafe void TransformFeedbackStreamAttrib([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attribs, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackStreamAttrib((uint) attribs.Length, in attribs.GetPinnableReference(), (uint) bufstreams.Length, in bufstreams.GetPinnableReference(), bufferMode);
        }

        public unsafe void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackVaryings(program, (uint) locations.Length, in locations.GetPinnableReference(), bufferMode);
        }

        public unsafe void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackVaryings(program, (uint) locations.Length, in locations.GetPinnableReference(), bufferMode);
        }

        public unsafe void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TransformFeedbackTokenNV> locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackVaryings(program, (uint) locations.Length, in locations.GetPinnableReference(), bufferMode);
        }

        public unsafe void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TransformFeedbackTokenNV> locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // ImplicitCountSpanOverloader
            TransformFeedbackVaryings(program, (uint) locations.Length, in locations.GetPinnableReference(), bufferMode);
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, length, size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, length, size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, length, out size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, length, out size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, out length, size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, out length, size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, out length, out size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveVarying(program, index, bufSize, out length, out size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe int GetTransformFeedbackVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedbackVarying(program, index, out int silkRet);
            return silkRet;
        }

        public NVTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

