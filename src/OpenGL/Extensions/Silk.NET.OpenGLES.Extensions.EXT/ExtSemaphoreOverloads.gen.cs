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
    public static class ExtSemaphoreOverloads
    {
        public static unsafe void DeleteSemaphores(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> semaphores)
        {
            // SpanOverloader
            thisApi.DeleteSemaphores(n, in semaphores.GetPinnableReference());
        }

        public static unsafe void GenSemaphores(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> semaphores)
        {
            // SpanOverloader
            thisApi.GenSemaphores(n, out semaphores.GetPinnableReference());
        }

        public static unsafe void GetSemaphoreParameter(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetSemaphoreParameter(semaphore, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSemaphoreParameter(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetSemaphoreParameter(semaphore, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetUnsignedByte(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> data)
        {
            // SpanOverloader
            thisApi.GetUnsignedByte(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetUnsignedByte(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> data)
        {
            // SpanOverloader
            thisApi.GetUnsignedByte(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetUnsignedByte(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> data)
        {
            // SpanOverloader
            thisApi.GetUnsignedByte(target, index, out data.GetPinnableReference());
        }

        public static unsafe void SemaphoreParameter(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> @params)
        {
            // SpanOverloader
            thisApi.SemaphoreParameter(semaphore, pname, in @params.GetPinnableReference());
        }

        public static unsafe void SemaphoreParameter(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> @params)
        {
            // SpanOverloader
            thisApi.SemaphoreParameter(semaphore, pname, in @params.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in dstLayouts.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), dstLayouts);
        }

        public static unsafe void SignalSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> dstLayouts)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in dstLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, textures, in srcLayouts.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), srcLayouts);
        }

        public static unsafe void WaitSemaphore(this ExtSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureLayout> srcLayouts)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(semaphore, numBufferBarriers, in buffers.GetPinnableReference(), numTextureBarriers, in textures.GetPinnableReference(), in srcLayouts.GetPinnableReference());
        }

    }
}

