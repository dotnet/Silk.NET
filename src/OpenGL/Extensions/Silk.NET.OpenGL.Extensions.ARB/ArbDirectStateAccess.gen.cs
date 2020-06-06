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
    [Extension("ARB_direct_state_access")]
    public unsafe partial class ArbDirectStateAccess : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_direct_state_access";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindTextureUnit")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindTextureUnit([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture)
            => ImplBindTextureUnit(unit, texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readFramebuffer">
        /// To be added.
        /// </param>
        /// <param name="drawFramebuffer">
        /// To be added.
        /// </param>
        /// <param name="srcX0">
        /// To be added.
        /// </param>
        /// <param name="srcY0">
        /// To be added.
        /// </param>
        /// <param name="srcX1">
        /// To be added.
        /// </param>
        /// <param name="srcY1">
        /// To be added.
        /// </param>
        /// <param name="dstX0">
        /// To be added.
        /// </param>
        /// <param name="dstY0">
        /// To be added.
        /// </param>
        /// <param name="dstX1">
        /// To be added.
        /// </param>
        /// <param name="dstY1">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] ARB filter)
            => ImplBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ARB CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB target)
            => ImplCheckNamedFramebufferStatus(framebuffer, target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data)
            => ImplClearNamedBufferData(buffer, internalformat, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplClearNamedBufferData<T0>(buffer, internalformat, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data)
            => ImplClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplClearNamedBufferSubData<T0>(buffer, internalformat, offset, size, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="stencil">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, depth, stencil);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data)
            => ImplCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTextureSubImage1D<T0>(texture, level, xoffset, width, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data)
            => ImplCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTextureSubImage2D<T0>(texture, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data)
            => ImplCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTextureSubImage3D<T0>(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readBuffer">
        /// To be added.
        /// </param>
        /// <param name="writeBuffer">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyTextureSubImage1D(texture, level, xoffset, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers)
            => ImplCreateBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers)
            => ImplCreateBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers)
            => ImplCreateFramebuffers(n, framebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers)
            => ImplCreateFramebuffers(n, framebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines)
            => ImplCreateProgramPipelines(n, pipelines);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines)
            => ImplCreateProgramPipelines(n, pipelines);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateQueries([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids)
            => ImplCreateQueries(target, n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateQueries([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
            => ImplCreateQueries(target, n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers)
            => ImplCreateRenderbuffers(n, renderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers)
            => ImplCreateRenderbuffers(n, renderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* samplers)
            => ImplCreateSamplers(n, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers)
            => ImplCreateSamplers(n, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateTextures([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures)
            => ImplCreateTextures(target, n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateTextures([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
            => ImplCreateTextures(target, n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids)
            => ImplCreateTransformFeedbacks(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
            => ImplCreateTransformFeedbacks(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays)
            => ImplCreateVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
            => ImplCreateVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index)
            => ImplDisableVertexArrayAttrib(vaobj, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index)
            => ImplEnableVertexArrayAttrib(vaobj, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplFlushMappedNamedBufferRange(buffer, offset, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateTextureMipmap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture)
            => ImplGenerateTextureMipmap(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels)
            => ImplGetCompressedTextureImage(texture, level, bufSize, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
            => ImplGetCompressedTextureImage<T0>(texture, level, bufSize, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] long* @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] void** @params)
            => ImplGetNamedBufferPointer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* data)
            => ImplGetNamedBufferSubData(buffer, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplGetNamedBufferSubData<T0>(buffer, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedRenderbufferParameter(renderbuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedRenderbufferParameter(renderbuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplGetQueryBufferObject(id, buffer, pname, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels)
            => ImplGetTextureImage(texture, level, format, type, bufSize, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
            => ImplGetTextureImage<T0>(texture, level, format, type, bufSize, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] uint* @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetTransformFeedback(xfb, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetTransformFeedback(xfb, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param)
            => ImplGetTransformFeedback(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetTransformFeedback(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param)
            => ImplGetTransformFeedbacki64_(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param)
            => ImplGetTransformFeedbacki64_(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArray(vaobj, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArray(vaobj, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArrayIndexed(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArrayIndexed(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] long* param)
            => ImplGetVertexArrayIndexed64(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> param)
            => ImplGetVertexArrayIndexed64(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] ARB* attachments)
            => ImplInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<ARB> attachments)
            => ImplInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] ARB* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB access)
            => ImplMapNamedBuffer(buffer, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapNamedBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access)
            => ImplMapNamedBufferRange(buffer, offset, length, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
            => ImplNamedBufferData(buffer, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
            => ImplNamedBufferData<T0>(buffer, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
            => ImplNamedBufferStorage(buffer, size, data, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
            => ImplNamedBufferStorage<T0>(buffer, size, data, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
            => ImplNamedBufferSubData(buffer, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
            => ImplNamedBufferSubData<T0>(buffer, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buf)
            => ImplNamedFramebufferDrawBuffer(framebuffer, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ARB* bufs)
            => ImplNamedFramebufferDrawBuffers(framebuffer, n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ARB> bufs)
            => ImplNamedFramebufferDrawBuffers(framebuffer, n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param)
            => ImplNamedFramebufferParameter(framebuffer, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB src)
            => ImplNamedFramebufferReadBuffer(framebuffer, src);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="renderbuffertarget">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplNamedFramebufferTexture(framebuffer, attachment, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorage(renderbuffer, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTextureBuffer(texture, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        [NativeApi(EntryPoint = "glTextureBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTextureBufferRange(texture, internalformat, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float* param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<float> param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int* param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<int> param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int* @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<int> @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint* @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<uint> @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width)
            => ImplTextureStorage1D(texture, levels, internalformat, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplTextureStorage2D(texture, levels, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplTextureStorage3D(texture, levels, internalformat, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged
            => ImplTextureSubImage1D<T0>(texture, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged
            => ImplTextureSubImage2D<T0>(texture, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged
            => ImplTextureSubImage3D<T0>(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformFeedbackBufferBase([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplTransformFeedbackBufferBase(xfb, index, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
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
        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTransformFeedbackBufferRange(xfb, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapNamedBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplUnmapNamedBuffer(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribBinding")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex)
            => ImplVertexArrayAttribBinding(vaobj, attribindex, bindingindex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="divisor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexArrayBindingDivisor(vaobj, bindingindex, divisor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayElementBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayElementBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer)
            => ImplVertexArrayElementBuffer(vaobj, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
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
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// </param>
        /// <param name="strides">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] IntPtr* offsets, [Flow(FlowDirection.In)] uint* strides)
            => ImplVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
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
        /// </param>
        /// <param name="offsets">
        /// To be added.
        /// </param>
        /// <param name="strides">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<uint> buffers, [Flow(FlowDirection.In)] Span<IntPtr> offsets, [Flow(FlowDirection.In)] Span<uint> strides)
            => ImplVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readFramebuffer">
        /// To be added.
        /// </param>
        /// <param name="drawFramebuffer">
        /// To be added.
        /// </param>
        /// <param name="srcX0">
        /// To be added.
        /// </param>
        /// <param name="srcY0">
        /// To be added.
        /// </param>
        /// <param name="srcX1">
        /// To be added.
        /// </param>
        /// <param name="srcY1">
        /// To be added.
        /// </param>
        /// <param name="dstX0">
        /// To be added.
        /// </param>
        /// <param name="dstY0">
        /// To be added.
        /// </param>
        /// <param name="dstX1">
        /// To be added.
        /// </param>
        /// <param name="dstY1">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter)
            => ImplBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ARB CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target)
            => ImplCheckNamedFramebufferStatus(framebuffer, target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
            => ImplClearNamedBufferData(buffer, internalformat, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplClearNamedBufferData<T0>(buffer, internalformat, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
            => ImplClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplClearNamedBufferSubData<T0>(buffer, internalformat, offset, size, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="stencil">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil)
            => ImplClearNamedFramebuffer(framebuffer, buffer, drawbuffer, depth, stencil);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data)
            => ImplCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTextureSubImage1D<T0>(texture, level, xoffset, width, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data)
            => ImplCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTextureSubImage2D<T0>(texture, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data)
            => ImplCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTextureSubImage3D<T0>(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids)
            => ImplCreateQueries(target, n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
            => ImplCreateQueries(target, n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures)
            => ImplCreateTextures(target, n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
            => ImplCreateTextures(target, n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] long* @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] Span<long> @params)
            => ImplGetNamedBufferParameter(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] void** @params)
            => ImplGetNamedBufferPointer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedRenderbufferParameter(renderbuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedRenderbufferParameter(renderbuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplGetQueryBufferObject(id, buffer, pname, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels)
            => ImplGetTextureImage(texture, level, format, type, bufSize, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
            => ImplGetTextureImage<T0>(texture, level, format, type, bufSize, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetTextureLevelParameter(texture, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetTextureParameter(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] uint* @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetTransformFeedback(xfb, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetTransformFeedback(xfb, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param)
            => ImplGetTransformFeedback(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetTransformFeedback(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param)
            => ImplGetTransformFeedbacki64_(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param)
            => ImplGetTransformFeedbacki64_(xfb, pname, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArray(vaobj, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArray(vaobj, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArrayIndexed(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArrayIndexed(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] long* param)
            => ImplGetVertexArrayIndexed64(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param)
            => ImplGetVertexArrayIndexed64(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments)
            => ImplInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments)
            => ImplInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access)
            => ImplMapNamedBuffer(buffer, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
            => ImplNamedBufferData(buffer, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
            => ImplNamedBufferData<T0>(buffer, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer buf)
            => ImplNamedFramebufferDrawBuffer(framebuffer, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ColorBuffer* bufs)
            => ImplNamedFramebufferDrawBuffers(framebuffer, n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ColorBuffer> bufs)
            => ImplNamedFramebufferDrawBuffers(framebuffer, n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplNamedFramebufferParameter(framebuffer, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src)
            => ImplNamedFramebufferReadBuffer(framebuffer, src);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="renderbuffertarget">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplNamedFramebufferTexture(framebuffer, attachment, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorage(renderbuffer, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTextureBuffer(texture, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        [NativeApi(EntryPoint = "glTextureBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTextureBufferRange(texture, internalformat, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float* param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<float> param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> param)
            => ImplTextureParameter(texture, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] uint* @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<uint> @params)
            => ImplTextureParameterI(texture, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width)
            => ImplTextureStorage1D(texture, levels, internalformat, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplTextureStorage2D(texture, levels, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplTextureStorage3D(texture, levels, internalformat, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged
            => ImplTextureSubImage1D<T0>(texture, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged
            => ImplTextureSubImage2D<T0>(texture, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged
            => ImplTextureSubImage3D<T0>(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readBuffer">
        /// To be added.
        /// </param>
        /// <param name="writeBuffer">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyNamedBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
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
        public unsafe void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TransformFeedbackBufferRange(xfb, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public ArbDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

