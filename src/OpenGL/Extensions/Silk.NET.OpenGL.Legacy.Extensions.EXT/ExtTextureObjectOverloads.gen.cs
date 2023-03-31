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
    public static class ExtTextureObjectOverloads
    {
        public static unsafe bool AreTexturesResident(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreTexturesResident(n, textures, out residences.GetPinnableReference());
        }

        public static unsafe bool AreTexturesResident(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences)
        {
            // SpanOverloader
            return thisApi.AreTexturesResident(n, in textures.GetPinnableReference(), residences);
        }

        public static unsafe bool AreTexturesResident(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreTexturesResident(n, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public static unsafe bool AreTexturesResident(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreTexturesResident(n, textures, out residences.GetPinnableReference());
        }

        public static unsafe bool AreTexturesResident(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences)
        {
            // SpanOverloader
            return thisApi.AreTexturesResident(n, in textures.GetPinnableReference(), residences);
        }

        public static unsafe bool AreTexturesResident(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreTexturesResident(n, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public static unsafe void DeleteTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // SpanOverloader
            thisApi.DeleteTextures(n, in textures.GetPinnableReference());
        }

        public static unsafe void DeleteTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // SpanOverloader
            thisApi.DeleteTextures(n, in textures.GetPinnableReference());
        }

        public static unsafe void GenTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> textures)
        {
            // SpanOverloader
            thisApi.GenTextures(n, out textures.GetPinnableReference());
        }

        public static unsafe void GenTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Texture> textures)
        {
            // SpanOverloader
            thisApi.GenTextures(n, out textures.GetPinnableReference());
        }

        public static unsafe void PrioritizeTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTextures(n, textures, in priorities.GetPinnableReference());
        }

        public static unsafe void PrioritizeTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTextures(n, in textures.GetPinnableReference(), priorities);
        }

        public static unsafe void PrioritizeTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTextures(n, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public static unsafe void PrioritizeTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTextures(n, textures, in priorities.GetPinnableReference());
        }

        public static unsafe void PrioritizeTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTextures(n, in textures.GetPinnableReference(), priorities);
        }

        public static unsafe void PrioritizeTextures(this ExtTextureObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTextures(n, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

    }
}

