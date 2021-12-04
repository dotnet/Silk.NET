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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtTextureStorageCompressionOverloads
    {
        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs2D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs2D(target, levels, internalformat, width, height, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

        public static unsafe void TexStorageAttribs3D(this ExtTextureStorageCompression thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ReadOnlySpan<TexStorageAttribs> attrib_list)
        {
            // SpanOverloader
            thisApi.TexStorageAttribs3D(target, levels, internalformat, width, height, depth, in attrib_list.GetPinnableReference());
        }

    }
}

