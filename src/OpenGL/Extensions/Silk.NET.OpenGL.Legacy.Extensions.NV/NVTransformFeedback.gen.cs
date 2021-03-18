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
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public unsafe partial void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public partial void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public partial void ActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] NV primitiveMode);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        public partial void BindBufferBase([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        public partial void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        public partial void BindBufferOffset([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        public partial void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        public partial void BindBufferRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        public partial void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glEndTransformFeedbackNV")]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public unsafe partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public partial void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out int location);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public unsafe partial int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public partial int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public partial int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        public unsafe partial void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        public partial void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in int attribs, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] int* bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] in int bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] int* bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public partial void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] in int bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* locations, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        public partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int locations, [Flow(FlowDirection.In)] NV bufferMode);

        public NVTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

