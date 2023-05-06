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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbMultiBindOverloads
    {
        public static unsafe void BindBuffersBase(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // SpanOverloader
            thisApi.BindBuffersBase(target, first, count, in buffers.GetPinnableReference());
        }

        public static unsafe void BindBuffersBase(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.BindBuffersBase(target, first, count, in buffers.GetPinnableReference());
        }

        public static unsafe void BindBuffersBase(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // SpanOverloader
            thisApi.BindBuffersBase(target, first, count, in buffers.GetPinnableReference());
        }

        public static unsafe void BindBuffersBase(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.BindBuffersBase(target, first, count, in buffers.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public static unsafe void BindBuffersRange(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // SpanOverloader
            thisApi.BindBuffersRange(target, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public static unsafe void BindImageTextures(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // SpanOverloader
            thisApi.BindImageTextures(first, count, in textures.GetPinnableReference());
        }

        public static unsafe void BindImageTextures(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // SpanOverloader
            thisApi.BindImageTextures(first, count, in textures.GetPinnableReference());
        }

        public static unsafe void BindSamplers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // SpanOverloader
            thisApi.BindSamplers(first, count, in samplers.GetPinnableReference());
        }

        public static unsafe void BindSamplers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
        {
            // SpanOverloader
            thisApi.BindSamplers(first, count, in samplers.GetPinnableReference());
        }

        public static unsafe void BindTextures(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // SpanOverloader
            thisApi.BindTextures(first, count, in textures.GetPinnableReference());
        }

        public static unsafe void BindTextures(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // SpanOverloader
            thisApi.BindTextures(first, count, in textures.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, buffers, offsets, in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, buffers, in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), offsets, strides);
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, buffers, offsets, in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, buffers, in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), offsets, strides);
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void BindVertexBuffers(this ArbMultiBind thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.BindVertexBuffers(first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

    }
}

