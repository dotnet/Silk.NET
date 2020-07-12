// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback")]
    public abstract unsafe partial class NVTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback";
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public abstract unsafe void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public abstract void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] NV primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        public abstract void BindBufferOffset([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glEndTransformFeedbackNV")]
        public abstract void EndTransformFeedback();

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract unsafe void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        public abstract unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        public abstract void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out int location);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public abstract unsafe int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public abstract int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        public abstract unsafe void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        public abstract void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int attribs, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public abstract unsafe void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] int* bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public abstract void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] Span<int> bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        public abstract unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* locations, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        public abstract void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> locations, [Flow(FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public abstract void ActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        public abstract void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract unsafe void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public abstract int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        public unsafe void BindBufferOffset([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            BindBufferOffset(target, index, buffer, new IntPtr(offset));
        }

        public unsafe void BindBufferRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            BindBufferOffset(target, index, buffer, new IntPtr(offset));
        }

        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public NVTransformFeedback(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

