// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback")]
    public unsafe partial class NVTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplActiveVarying(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveVarying([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplActiveVarying(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginTransformFeedback([Flow(FlowDirection.In)] NV primitiveMode)
            => ImplBeginTransformFeedback(primitiveMode);

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
        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBufferBase(target, index, buffer);

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
        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferOffset([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplBindBufferOffset(target, index, buffer, offset);

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
        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndTransformFeedbackNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndTransformFeedback()
            => ImplEndTransformFeedback();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from program, index, and bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetActiveVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from program, index, and bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Count(Computed = "program, index, bufSize"), Flow(FlowDirection.Out)] out char name)
            => ImplGetActiveVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] int* location)
            => ImplGetTransformFeedbackVarying(program, index, location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out int location)
            => ImplGetTransformFeedbackVarying(program, index, location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetVaryingLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetVaryingLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="attribs">
        /// To be added.
        /// This parameter's element count is computed from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] NV bufferMode)
            => ImplTransformFeedbackAttrib(count, attribs, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="attribs">
        /// To be added.
        /// This parameter's element count is computed from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformFeedbackAttrib([Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int attribs, [Flow(FlowDirection.In)] NV bufferMode)
            => ImplTransformFeedbackAttrib(count, attribs, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="attribs">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="nbuffers">
        /// To be added.
        /// </param>
        /// <param name="bufstreams">
        /// To be added.
        /// This parameter's element count is taken from nbuffers.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] int* bufstreams, [Flow(FlowDirection.In)] NV bufferMode)
            => ImplTransformFeedbackStreamAttrib(count, attribs, nbuffers, bufstreams, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="attribs">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="nbuffers">
        /// To be added.
        /// </param>
        /// <param name="bufstreams">
        /// To be added.
        /// This parameter's element count is taken from nbuffers.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformFeedbackStreamAttrib([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] Span<int> bufstreams, [Flow(FlowDirection.In)] NV bufferMode)
            => ImplTransformFeedbackStreamAttrib(count, attribs, nbuffers, bufstreams, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="locations">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* locations, [Flow(FlowDirection.In)] NV bufferMode)
            => ImplTransformFeedbackVaryings(program, count, locations, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="locations">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> locations, [Flow(FlowDirection.In)] NV bufferMode)
            => ImplTransformFeedbackVaryings(program, count, locations, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name)
            => ImplActiveVarying(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode)
            => ImplBeginTransformFeedback(primitiveMode);

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
        [NativeApi(EntryPoint = "glBindBufferBaseNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBufferBase(target, index, buffer);

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
        [NativeApi(EntryPoint = "glBindBufferOffsetNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplBindBufferOffset(target, index, buffer, offset);

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
        [NativeApi(EntryPoint = "glBindBufferRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Flow(FlowDirection.Out)] string name)
            => ImplGetActiveVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveVaryingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out NV type, [Flow(FlowDirection.Out)] string name)
            => ImplGetActiveVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetVaryingLocationNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetVaryingLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name)
            => ImplGetVaryingLocation(program, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public NVTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

