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

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_direct_state_access")]
    public unsafe partial class ExtDirectStateAccess : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_direct_state_access";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindMultiTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindMultiTexture([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint texture)
            => ImplBindMultiTexture(texunit, target, texture);

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
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public EXT CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT target)
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
            => ImplClearNamedBufferSubData<T0>(buffer, internalformat, offset, size, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClientAttribDefaultEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClientAttribDefault([Flow(FlowDirection.In)] uint mask)
            => ImplClientAttribDefault(mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexImage1D<T0>(texunit, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexImage2D<T0>(texunit, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexImage3D<T0>(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexSubImage1D<T0>(texunit, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexSubImage2D<T0>(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexSubImage3D<T0>(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureImage1D(texture, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureImage1D<T0>(texture, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureImage2D(texture, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureImage2D<T0>(texture, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureImage3D<T0>(texture, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureSubImage1D(texture, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureSubImage1D<T0>(texture, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureSubImage2D<T0>(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureSubImage3D<T0>(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border)
            => ImplCopyMultiTexImage1D(texunit, target, level, internalformat, x, y, width, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border)
            => ImplCopyMultiTexImage2D(texunit, target, level, internalformat, x, y, width, height, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyMultiTexSubImage1D(texunit, target, level, xoffset, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border)
            => ImplCopyTextureImage1D(texture, target, level, internalformat, x, y, width, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border)
            => ImplCopyTextureImage2D(texture, target, level, internalformat, x, y, width, height, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyTextureSubImage1D(texture, target, level, xoffset, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTextureSubImage2D(texture, target, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableClientStateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableClientState([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index)
            => ImplDisableClientState(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableClientStateIndexed([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index)
            => ImplDisableClientStateIndexed(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplDisableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="array">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVertexArrayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT array)
            => ImplDisableVertexArray(vaobj, array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVertexArrayAttribEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index)
            => ImplDisableVertexArrayAttrib(vaobj, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableClientStateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableClientState([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index)
            => ImplEnableClientState(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableClientStateIndexed([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index)
            => ImplEnableClientStateIndexed(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplEnableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="array">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVertexArrayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT array)
            => ImplEnableVertexArray(vaobj, array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVertexArrayAttribEXT")]
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
        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRangeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplFlushMappedNamedBufferRange(buffer, offset, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT mode)
            => ImplFramebufferDrawBuffer(framebuffer, mode);

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
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* bufs)
            => ImplFramebufferDrawBuffers(framebuffer, n, bufs);

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
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<EXT> bufs)
            => ImplFramebufferDrawBuffers(framebuffer, n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT mode)
            => ImplFramebufferReadBuffer(framebuffer, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateMultiTexMipmap([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target)
            => ImplGenerateMultiTexMipmap(texunit, target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target)
            => ImplGenerateTextureMipmap(texture, target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCompressedMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img)
            => ImplGetCompressedMultiTexImage(texunit, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged
            => ImplGetCompressedMultiTexImage<T0>(texunit, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img)
            => ImplGetCompressedTextureImage(texture, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged
            => ImplGetCompressedTextureImage<T0>(texture, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetDoublei_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDouble([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params)
            => ImplGetDouble(pname, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetDoublei_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDouble([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params)
            => ImplGetDouble(pname, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDoubleIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data)
            => ImplGetDoubleIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDoubleIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data)
            => ImplGetDoubleIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloati_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFloat([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFloat(pname, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloati_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFloat([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFloat(pname, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFloatIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data)
            => ImplGetFloatIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFloatIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data)
            => ImplGetFloatIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data)
            => ImplGetIntegerIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data)
            => ImplGetIntegerIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels)
            => ImplGetMultiTexImage(texunit, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged
            => ImplGetMultiTexImage<T0>(texunit, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetNamedBufferPointer(buffer, pname, @params);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferPointer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetNamedBufferPointer<T0>(buffer, pname, @params);

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
        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.Out)] void* data)
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
        /// This parameter's element count is computed from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
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
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedProgram(program, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedProgram(program, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is computed from program and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string)
            => ImplGetNamedProgramString(program, target, pname, @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is computed from program and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged
            => ImplGetNamedProgramString<T0>(program, target, pname, @string);

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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedRenderbufferParameter(renderbuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetPointer(pname, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer<T0>([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetPointer<T0>(pname, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] void** data)
            => ImplGetPointerIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointerIndexed<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged
            => ImplGetPointerIndexed<T0>(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels)
            => ImplGetTextureImage(texture, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged
            => ImplGetTextureImage<T0>(texture, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArrayInteger(vaobj, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArrayInteger(vaobj, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArrayInteger(vaobj, index, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArrayInteger(vaobj, index, pname, param);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param)
            => ImplGetVertexArrayPointer(vaobj, pname, param);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayPointer<T0>([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* param) where T0 : unmanaged
            => ImplGetVertexArrayPointer<T0>(vaobj, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] void** param)
            => ImplGetVertexArrayPointer(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabledIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabledIndexed(target, index);

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
        [NativeApi(EntryPoint = "glMapNamedBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT access)
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
        [NativeApi(EntryPoint = "glMapNamedBufferRangeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access)
            => ImplMapNamedBufferRange(buffer, offset, length, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixFrustum([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixFrustum(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadIdentity([Flow(FlowDirection.In)] EXT mode)
            => ImplMatrixLoadIdentity(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixOrtho([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixOrtho(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPop([Flow(FlowDirection.In)] EXT mode)
            => ImplMatrixPop(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPush([Flow(FlowDirection.In)] EXT mode)
            => ImplMatrixPush(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="angle">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="angle">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexBuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplMultiTexBuffer(texunit, target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordPointer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplMultiTexCoordPointer(texunit, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordPointer<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplMultiTexCoordPointer<T0>(texunit, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param)
            => ImplMultiTexEnv(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnviEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param)
            => ImplMultiTexEnv(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param)
            => ImplMultiTexGen(texunit, coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGeniEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param)
            => ImplMultiTexGen(texunit, coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGendEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGend([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] double param)
            => ImplMultiTexGend(texunit, coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexImage1D<T0>(texunit, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexImage2D<T0>(texunit, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexImage3D<T0>(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param)
            => ImplMultiTexParameter(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param)
            => ImplMultiTexParameter(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexRenderbuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplMultiTexRenderbuffer(texunit, target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexSubImage1D<T0>(texunit, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexSubImage2D<T0>(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexSubImage3D<T0>(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] EXT usage)
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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] EXT usage) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glNamedBufferStorageEXT")]
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
        [NativeApi(EntryPoint = "glNamedBufferStorageEXT")]
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
        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT")]
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
        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
            => ImplNamedBufferSubData<T0>(buffer, offset, size, data);

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
        [NativeApi(EntryPoint = "glNamedCopyBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedCopyBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplNamedCopyBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);

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
        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param)
            => ImplNamedFramebufferParameter(framebuffer, pname, param);

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
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer)
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
        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
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
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplNamedFramebufferTexture1D(framebuffer, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplNamedFramebufferTexture2D(framebuffer, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset)
            => ImplNamedFramebufferTexture3D(framebuffer, attachment, textarget, texture, level, zoffset);

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
        /// <param name="face">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT face)
            => ImplNamedFramebufferTextureFace(framebuffer, attachment, texture, level, face);

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
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplNamedProgramLocalParameter4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplNamedProgramLocalParameter4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplNamedProgramLocalParameterI4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w)
            => ImplNamedProgramLocalParameterI4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params)
            => ImplNamedProgramLocalParameters4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> @params)
            => ImplNamedProgramLocalParameters4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string)
            => ImplNamedProgramString(program, target, format, len, @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged
            => ImplNamedProgramString<T0>(program, target, format, len, @string);

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
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
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
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
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
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisampleCoverage(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0)
            => ImplProgramUniform1(program, location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0)
            => ImplProgramUniform1(program, location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0)
            => ImplProgramUniform1(program, location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x)
            => ImplProgramUniform1(program, location, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1)
            => ImplProgramUniform2(program, location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1)
            => ImplProgramUniform2(program, location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1)
            => ImplProgramUniform2(program, location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y)
            => ImplProgramUniform2(program, location, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2)
            => ImplProgramUniform3(program, location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2)
            => ImplProgramUniform3(program, location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2)
            => ImplProgramUniform3(program, location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplProgramUniform3(program, location, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3)
            => ImplProgramUniform4(program, location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3)
            => ImplProgramUniform4(program, location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3)
            => ImplProgramUniform4(program, location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplProgramUniform4(program, location, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix2x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix2x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix2x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix2x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix2x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix2x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix2x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix2x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix3x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix3x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix3x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix3x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix3x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix3x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix3x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix3x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix4x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix4x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix4x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix4x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix4x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix4x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value)
            => ImplProgramUniformMatrix4x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value)
            => ImplProgramUniformMatrix4x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPushClientAttribDefaultEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PushClientAttribDefault([Flow(FlowDirection.In)] uint mask)
            => ImplPushClientAttribDefault(mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTextureBuffer(texture, target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureBufferRangeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTextureBufferRange(texture, target, internalformat, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureImage1D(texture, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureImage1D<T0>(texture, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureImage2D(texture, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureImage2D<T0>(texture, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureImage3D<T0>(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);

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
        /// <param name="commit">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexturePageCommitmentEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexturePageCommitment([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool commit)
            => ImplTexturePageCommitment(texture, level, xoffset, yoffset, zoffset, width, height, depth, commit);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param)
            => ImplTextureParameter(texture, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param)
            => ImplTextureParameter(texture, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureRenderbufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureRenderbuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplTextureRenderbuffer(texture, target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width)
            => ImplTextureStorage1D(texture, target, levels, internalformat, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplTextureStorage2D(texture, target, levels, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage2DMultisample(texture, target, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplTextureStorage3D(texture, target, levels, internalformat, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage3DMultisample(texture, target, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage1D(texture, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureSubImage1D<T0>(texture, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureSubImage2D<T0>(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureSubImage3D<T0>(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapNamedBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplUnmapNamedBuffer(buffer);

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
        [NativeApi(EntryPoint = "glVertexArrayBindVertexBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayBindVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexArrayBindVertexBuffer(vaobj, bindingindex, buffer, offset, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayColorOffset(vaobj, buffer, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayEdgeFlagOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayEdgeFlagOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayEdgeFlagOffset(vaobj, buffer, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayFogCoordOffset(vaobj, buffer, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayIndexOffset(vaobj, buffer, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayMultiTexCoordOffset(vaobj, buffer, texunit, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayNormalOffset(vaobj, buffer, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArraySecondaryColorOffset(vaobj, buffer, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayTexCoordOffset(vaobj, buffer, size, type, stride, offset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribBindingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex)
            => ImplVertexArrayVertexAttribBinding(vaobj, attribindex, bindingindex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="divisor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribDivisorEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexArrayVertexAttribDivisor(vaobj, index, divisor);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayVertexAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayVertexAttribIFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexAttribIOffset(vaobj, buffer, index, size, type, stride, offset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayVertexAttribLFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexAttribLOffset(vaobj, buffer, index, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
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
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexAttribOffset(vaobj, buffer, index, size, type, normalized, stride, offset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexBindingDivisorEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexArrayVertexBindingDivisor(vaobj, bindingindex, divisor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexOffset(vaobj, buffer, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindMultiTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindMultiTexture([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture)
            => ImplBindMultiTexture(texunit, target, texture);

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
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public EXT CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target)
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
            => ImplClearNamedBufferSubData<T0>(buffer, internalformat, offset, size, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexImage1D<T0>(texunit, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexImage2D<T0>(texunit, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexImage3D<T0>(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexSubImage1D<T0>(texunit, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexSubImage2D<T0>(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedMultiTexSubImage3D<T0>(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureImage1D(texture, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureImage1D<T0>(texture, target, level, internalformat, width, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureImage2D(texture, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureImage2D<T0>(texture, target, level, internalformat, width, height, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureImage3D<T0>(texture, target, level, internalformat, width, height, depth, border, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureSubImage1D(texture, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureSubImage1D<T0>(texture, target, level, xoffset, width, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureSubImage2D<T0>(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits)
            => ImplCompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="bits">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged
            => ImplCompressedTextureSubImage3D<T0>(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border)
            => ImplCopyMultiTexImage1D(texunit, target, level, internalformat, x, y, width, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border)
            => ImplCopyMultiTexImage2D(texunit, target, level, internalformat, x, y, width, height, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyMultiTexSubImage1D(texunit, target, level, xoffset, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border)
            => ImplCopyTextureImage1D(texture, target, level, internalformat, x, y, width, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border)
            => ImplCopyTextureImage2D(texture, target, level, internalformat, x, y, width, height, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyTextureSubImage1D(texture, target, level, xoffset, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTextureSubImage2D(texture, target, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableClientStateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableClientState([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index)
            => ImplDisableClientState(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableClientStateIndexed([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index)
            => ImplDisableClientStateIndexed(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplDisableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="array">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVertexArrayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EnableCap array)
            => ImplDisableVertexArray(vaobj, array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableClientStateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableClientState([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index)
            => ImplEnableClientState(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableClientStateIndexed([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index)
            => ImplEnableClientStateIndexed(array, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplEnableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="array">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVertexArrayEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EnableCap array)
            => ImplEnableVertexArray(vaobj, array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] DrawBufferMode mode)
            => ImplFramebufferDrawBuffer(framebuffer, mode);

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
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs)
            => ImplFramebufferDrawBuffers(framebuffer, n, bufs);

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
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs)
            => ImplFramebufferDrawBuffers(framebuffer, n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ReadBufferMode mode)
            => ImplFramebufferReadBuffer(framebuffer, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateMultiTexMipmap([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target)
            => ImplGenerateMultiTexMipmap(texunit, target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target)
            => ImplGenerateTextureMipmap(texture, target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCompressedMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img)
            => ImplGetCompressedMultiTexImage(texunit, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged
            => ImplGetCompressedMultiTexImage<T0>(texunit, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img)
            => ImplGetCompressedTextureImage(texture, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is computed from target and lod.
        /// </param>
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged
            => ImplGetCompressedTextureImage<T0>(texture, target, lod, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels)
            => ImplGetMultiTexImage(texunit, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged
            => ImplGetMultiTexImage<T0>(texunit, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexLevelParameter(texunit, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetMultiTexParameterI(texunit, target, pname, @params);

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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetNamedBufferPointer(buffer, pname, @params);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferPointer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetNamedBufferPointer<T0>(buffer, pname, @params);

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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
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
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedFramebufferParameter(framebuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedProgram(program, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedProgram(program, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetNamedProgramLocalParameter(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetNamedProgramLocalParameterI(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is computed from program and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string)
            => ImplGetNamedProgramString(program, target, pname, @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is computed from program and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged
            => ImplGetNamedProgramString<T0>(program, target, pname, @string);

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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedRenderbufferParameter(renderbuffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels)
            => ImplGetTextureImage(texture, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from target, level, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged
            => ImplGetTextureImage<T0>(texture, target, level, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTextureLevelParameter(texture, target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetTextureParameterI(texture, target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArrayInteger(vaobj, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArrayInteger(vaobj, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param)
            => ImplGetVertexArrayInteger(vaobj, index, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
            => ImplGetVertexArrayInteger(vaobj, index, pname, param);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param)
            => ImplGetVertexArrayPointer(vaobj, pname, param);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayPointer<T0>([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* param) where T0 : unmanaged
            => ImplGetVertexArrayPointer<T0>(vaobj, pname, param);

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
        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] void** param)
            => ImplGetVertexArrayPointer(vaobj, index, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabledIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabledIndexed(target, index);

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
        [NativeApi(EntryPoint = "glMapNamedBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access)
            => ImplMapNamedBuffer(buffer, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixFrustum([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixFrustum(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadIdentity([Flow(FlowDirection.In)] MatrixMode mode)
            => ImplMatrixLoadIdentity(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixOrtho([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixOrtho(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPop([Flow(FlowDirection.In)] MatrixMode mode)
            => ImplMatrixPop(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPush([Flow(FlowDirection.In)] MatrixMode mode)
            => ImplMatrixPush(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="angle">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="angle">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexBuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplMultiTexBuffer(texunit, target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordPointer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplMultiTexCoordPointer(texunit, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordPointer<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplMultiTexCoordPointer<T0>(texunit, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param)
            => ImplMultiTexEnv(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnviEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplMultiTexEnv(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexEnv(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param)
            => ImplMultiTexGen(texunit, coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGeniEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplMultiTexGen(texunit, coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexGen(texunit, coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexGendEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexGend([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param)
            => ImplMultiTexGend(texunit, coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexImage1D<T0>(texunit, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexImage2D<T0>(texunit, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexImage3D<T0>(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplMultiTexParameter(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param)
            => ImplMultiTexParameter(texunit, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMultiTexParameter(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params)
            => ImplMultiTexParameterI(texunit, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexRenderbuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplMultiTexRenderbuffer(texunit, target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexSubImage1D<T0>(texunit, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexSubImage2D<T0>(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplMultiTexSubImage3D<T0>(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
            => ImplNamedBufferData<T0>(buffer, size, data, usage);

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
        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplNamedFramebufferParameter(framebuffer, pname, param);

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
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT")]
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
        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT")]
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
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplNamedFramebufferTexture1D(framebuffer, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplNamedFramebufferTexture2D(framebuffer, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset)
            => ImplNamedFramebufferTexture3D(framebuffer, attachment, textarget, texture, level, zoffset);

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
        /// <param name="face">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face)
            => ImplNamedFramebufferTextureFace(framebuffer, attachment, texture, level, face);

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
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplNamedProgramLocalParameter4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplNamedProgramLocalParameter4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params)
            => ImplNamedProgramLocalParameter4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplNamedProgramLocalParameterI4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w)
            => ImplNamedProgramLocalParameterI4(program, target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params)
            => ImplNamedProgramLocalParameterI4(program, target, index, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params)
            => ImplNamedProgramLocalParameters4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> @params)
            => ImplNamedProgramLocalParameters4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params)
            => ImplNamedProgramLocalParametersI4(program, target, index, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string)
            => ImplNamedProgramString(program, target, format, len, @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged
            => ImplNamedProgramString<T0>(program, target, format, len, @string);

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
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT")]
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
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
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
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisampleCoverage(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureBufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTextureBuffer(texture, target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureBufferRangeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTextureBufferRange(texture, target, internalformat, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureImage1D(texture, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureImage1D<T0>(texture, target, level, internalformat, width, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureImage2D(texture, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureImage2D<T0>(texture, target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureImage3D<T0>(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param)
            => ImplTextureParameter(texture, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplTextureParameter(texture, target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTextureParameter(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params)
            => ImplTextureParameterI(texture, target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureRenderbufferEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureRenderbuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplTextureRenderbuffer(texture, target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width)
            => ImplTextureStorage1D(texture, target, levels, internalformat, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplTextureStorage2D(texture, target, levels, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage2DMultisample(texture, target, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplTextureStorage3D(texture, target, levels, internalformat, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTextureStorage3DMultisample(texture, target, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage1D(texture, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureSubImage1D<T0>(texture, target, level, xoffset, width, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureSubImage2D<T0>(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTextureSubImage3D<T0>(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayColorOffset(vaobj, buffer, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] FogCoordinatePointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayFogCoordOffset(vaobj, buffer, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayIndexOffset(vaobj, buffer, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayMultiTexCoordOffset(vaobj, buffer, texunit, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayNormalOffset(vaobj, buffer, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArraySecondaryColorOffset(vaobj, buffer, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayTexCoordOffset(vaobj, buffer, size, type, stride, offset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayVertexAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayVertexAttribIFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexAttribIOffset(vaobj, buffer, index, size, type, stride, offset);

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
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexArrayVertexAttribLFormat(vaobj, attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexAttribLOffset(vaobj, buffer, index, size, type, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
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
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexAttribOffset(vaobj, buffer, index, size, type, normalized, stride, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplVertexArrayVertexOffset(vaobj, buffer, size, type, stride, offset);

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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, data);
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, ref data);
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
        /// This parameter's element count is computed from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] void* data)
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
        /// This parameter's element count is computed from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), out data);
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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] EXT usage)
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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] EXT usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), ref data, usage);
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
        public unsafe void NamedCopyBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            NamedCopyBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
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
        public unsafe void VertexArrayBindVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayBindVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayEdgeFlagOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayEdgeFlagOffset(vaobj, buffer, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayFogCoordOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayIndexOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayMultiTexCoordOffset(vaobj, buffer, texunit, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayNormalOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArraySecondaryColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayTexCoordOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribIOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribLOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
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
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribOffset(vaobj, buffer, index, size, type, normalized, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, data);
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
        /// This parameter's element count is computed from format and type.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, ref data);
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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
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
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), ref data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
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
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] FogCoordinatePointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayFogCoordOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayIndexOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayMultiTexCoordOffset(vaobj, buffer, texunit, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayNormalOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArraySecondaryColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayTexCoordOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribIOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribLOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
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
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribOffset(vaobj, buffer, index, size, type, normalized, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        public ExtDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

