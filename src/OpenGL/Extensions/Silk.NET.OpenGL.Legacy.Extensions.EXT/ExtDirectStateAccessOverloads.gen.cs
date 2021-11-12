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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtDirectStateAccessOverloads
    {
        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferData(buffer, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedMultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage1D(texture, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage1D(texture, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage1D(texture, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage1D(texture, target, level, internalformat, width, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in bits.GetPinnableReference());
        }

        public static unsafe void FramebufferDrawBuffers(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<EXT> bufs)
        {
            // SpanOverloader
            thisApi.FramebufferDrawBuffers(framebuffer, n, in bufs.GetPinnableReference());
        }

        public static unsafe void FramebufferDrawBuffers(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
        {
            // SpanOverloader
            thisApi.FramebufferDrawBuffers(framebuffer, n, in bufs.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<Boolean> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<Boolean> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetCompressedMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetCompressedMultiTexImage(texunit, target, lod, out img.GetPinnableReference());
        }

        public static unsafe void GetCompressedMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetCompressedMultiTexImage(texunit, target, lod, out img.GetPinnableReference());
        }

        public static unsafe void GetCompressedMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetCompressedMultiTexImage(texunit, target, lod, out img.GetPinnableReference());
        }

        public static unsafe void GetCompressedMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetCompressedMultiTexImage(texunit, target, lod, out img.GetPinnableReference());
        }

        public static unsafe void GetCompressedTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetCompressedTextureImage(texture, target, lod, out img.GetPinnableReference());
        }

        public static unsafe void GetCompressedTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetCompressedTextureImage(texture, target, lod, out img.GetPinnableReference());
        }

        public static unsafe void GetDouble(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetDouble(pname, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetDouble(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetDouble(pname, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetDoubleIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<double> data)
        {
            // SpanOverloader
            thisApi.GetDoubleIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetDoubleIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<double> data)
        {
            // SpanOverloader
            thisApi.GetDoubleIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFloat(pname, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetFloat(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFloat(pname, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetFloatIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloatIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloatIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloatIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(framebuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(framebuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetIntegerIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetIntegerIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetIntegerIndexed(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetIntegerIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexEnv(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexGen(texunit, coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMultiTexImage(texunit, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexLevelParameter(texunit, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameter(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMultiTexParameterI(texunit, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetNamedBufferSubData(buffer, offset, size, out data.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferParameter(framebuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferParameter(framebuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgram(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgram(program, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgram(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgram(program, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgram(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgram(program, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgram(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgram(program, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameter(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameter(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameter(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameter(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameterI(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameterI(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameterI(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramLocalParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetNamedProgramLocalParameterI(program, target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetNamedProgramString(program, target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetNamedProgramString(program, target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetNamedProgramString(program, target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetNamedProgramString(program, target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedRenderbufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedRenderbufferParameter(renderbuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedRenderbufferParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedRenderbufferParameter(renderbuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetTextureImage(texture, target, level, format, type, out pixels.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayInteger(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayInteger(vaobj, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayInteger(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayInteger(vaobj, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayInteger(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayInteger(vaobj, index, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayInteger(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayInteger(vaobj, index, pname, out param.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexEnv(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexEnv(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexGen(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexGen(texunit, coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage1D(texunit, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage2D(texunit, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameter(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.MultiTexParameterI(texunit, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage1D(texunit, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void MultiTexSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void NamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] EXT usage) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedBufferData(buffer, size, in data.GetPinnableReference(), usage);
        }

        public static unsafe void NamedBufferData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedBufferData(buffer, size, in data.GetPinnableReference(), usage);
        }

        public static unsafe void NamedBufferStorage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedBufferStorage(buffer, size, in data.GetPinnableReference(), flags);
        }

        public static unsafe void NamedBufferStorage<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedBufferStorage(buffer, size, in data.GetPinnableReference(), flags);
        }

        public static unsafe void NamedBufferSubData<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedBufferSubData(buffer, offset, size, in data.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameter4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameter4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameter4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameter4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameter4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameter4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameter4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameter4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameterI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameterI4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameterI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameterI4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameterI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameterI4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameterI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameterI4(program, target, index, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameters4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameters4(program, target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParameters4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParameters4(program, target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParametersI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParametersI4(program, target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParametersI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParametersI4(program, target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParametersI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParametersI4(program, target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramLocalParametersI4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.NamedProgramLocalParametersI4(program, target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void NamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedProgramString(program, target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void NamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedProgramString(program, target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void NamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedProgramString(program, target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void NamedProgramString<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.NamedProgramString(program, target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage1D(texture, target, level, internalformat, width, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage2D(texture, target, level, internalformat, width, height, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureImage3D(texture, target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage1D(texture, target, level, xoffset, width, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage2D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TextureSubImage3D<T0>(this ExtDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

    }
}

