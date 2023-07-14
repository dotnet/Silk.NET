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
    public static class ArbVertexType2101010RevOverloads
    {
        public static unsafe void ColorP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> color)
        {
            // SpanOverloader
            thisApi.ColorP3(type, in color.GetPinnableReference());
        }

        public static unsafe void ColorP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> color)
        {
            // SpanOverloader
            thisApi.ColorP3(type, in color.GetPinnableReference());
        }

        public static unsafe void ColorP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> color)
        {
            // SpanOverloader
            thisApi.ColorP4(type, in color.GetPinnableReference());
        }

        public static unsafe void ColorP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> color)
        {
            // SpanOverloader
            thisApi.ColorP4(type, in color.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP1(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP1(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP1(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP1(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP2(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP2(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP2(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP2(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP3(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP3(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP3(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP3(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP4(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP4(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP4(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoordP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoordP4(texture, type, in coords.GetPinnableReference());
        }

        public static unsafe void NormalP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.NormalP3(type, in coords.GetPinnableReference());
        }

        public static unsafe void NormalP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.NormalP3(type, in coords.GetPinnableReference());
        }

        public static unsafe void SecondaryColorP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> color)
        {
            // SpanOverloader
            thisApi.SecondaryColorP3(type, in color.GetPinnableReference());
        }

        public static unsafe void SecondaryColorP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> color)
        {
            // SpanOverloader
            thisApi.SecondaryColorP3(type, in color.GetPinnableReference());
        }

        public static unsafe void TexCoordP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP1(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP1(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP2(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP2(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP3(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP3(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP4(type, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoordP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> coords)
        {
            // SpanOverloader
            thisApi.TexCoordP4(type, in coords.GetPinnableReference());
        }

        public static unsafe void VertexAttribP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP1(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP1(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP1(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP2(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP2(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP3(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP3(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP4(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP4(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexP2(type, in value.GetPinnableReference());
        }

        public static unsafe void VertexP2(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexP2(type, in value.GetPinnableReference());
        }

        public static unsafe void VertexP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexP3(type, in value.GetPinnableReference());
        }

        public static unsafe void VertexP3(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexP3(type, in value.GetPinnableReference());
        }

        public static unsafe void VertexP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexP4(type, in value.GetPinnableReference());
        }

        public static unsafe void VertexP4(this ArbVertexType2101010Rev thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexP4(type, in value.GetPinnableReference());
        }

    }
}

