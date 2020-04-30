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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback")]
    public abstract unsafe partial class NVTransformFeedback : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public abstract unsafe void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public abstract void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] NV primitiveMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        public abstract void BindBufferOffset([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndTransformFeedbackNV")]
        public abstract void EndTransformFeedback();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract unsafe void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        public abstract unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] int* location);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        public abstract void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out int location);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public abstract unsafe int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public abstract int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        public abstract unsafe void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] NV bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        public abstract void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int attribs, [Flow(FlowDirection.In)] NV bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public abstract unsafe void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] int* bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        public abstract void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] Span<int> bufstreams, [Flow(FlowDirection.In)] NV bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        public abstract unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* locations, [Flow(FlowDirection.In)] NV bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        public abstract void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> locations, [Flow(FlowDirection.In)] NV bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        public abstract void ActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        public abstract void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract unsafe void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        public abstract void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        public abstract int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void BindBufferOffset([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            BindBufferOffset(target, index, buffer, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            BindBufferOffset(target, index, buffer, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
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

