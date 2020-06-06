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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_transform_feedback")]
    public unsafe partial class ExtTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_transform_feedback";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginTransformFeedbackEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginTransformFeedback([Flow(FlowDirection.In)] EXT primitiveMode)
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
        [NativeApi(EntryPoint = "glBindBufferBaseEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
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
        [NativeApi(EntryPoint = "glBindBufferOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferOffset([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset)
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
        [NativeApi(EntryPoint = "glBindBufferRangeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndTransformFeedbackEXT")]
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
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

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
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** varyings, [Flow(FlowDirection.In)] EXT bufferMode)
            => ImplTransformFeedbackVaryings(program, count, varyings, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginTransformFeedbackEXT")]
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
        [NativeApi(EntryPoint = "glBindBufferBaseEXT")]
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
        [NativeApi(EntryPoint = "glBindBufferOffsetEXT")]
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
        [NativeApi(EntryPoint = "glBindBufferRangeEXT")]
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
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GlslTypeToken* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

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
        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GlslTypeToken type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

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
        public unsafe void BindBufferOffset([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset)
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
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] EXT bufferMode)
        {
            // StringArrayOverloader
            var varyings = (char**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
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

        public ExtTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

