// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_multi_bind")]
    public unsafe partial class ArbMultiBind : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_bind";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers)
            => ImplBindBuffersBase(target, first, count, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers)
            => ImplBindBuffersBase(target, first, count, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes)
            => ImplBindBuffersRange(target, first, count, buffers, offsets, sizes);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes)
            => ImplBindBuffersRange(target, first, count, buffers, offsets, sizes);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindImageTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures)
            => ImplBindImageTextures(first, count, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindImageTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures)
            => ImplBindImageTextures(first, count, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers)
            => ImplBindSamplers(first, count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers)
            => ImplBindSamplers(first, count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures)
            => ImplBindTextures(first, count, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures)
            => ImplBindTextures(first, count, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="strides">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
            => ImplBindVertexBuffers(first, count, buffers, offsets, strides);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="strides">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> strides)
            => ImplBindVertexBuffers(first, count, buffers, offsets, strides);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers)
            => ImplBindBuffersBase(target, first, count, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers)
            => ImplBindBuffersBase(target, first, count, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes)
            => ImplBindBuffersRange(target, first, count, buffers, offsets, sizes);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes)
            => ImplBindBuffersRange(target, first, count, buffers, offsets, sizes);

        public ArbMultiBind(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

