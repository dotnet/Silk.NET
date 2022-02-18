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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_texture_object")]
    public unsafe partial class ExtTextureObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_object";
        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public partial bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glBindTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindTexture([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBindTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Texture* textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Texture textures);

        [NativeApi(EntryPoint = "glIsTextureEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsTexture([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float priorities);

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, textures, out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) textures.Length, in textures.GetPinnableReference(), residences);
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, textures, out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) textures.Length, in textures.GetPinnableReference(), residences);
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, textures, out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) textures.Length, in textures.GetPinnableReference(), residences);
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, textures, out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) textures.Length, in textures.GetPinnableReference(), residences);
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        public unsafe void DeleteTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // ImplicitCountSpanOverloader
            DeleteTextures((uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void DeleteTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            DeleteTextures((uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        public unsafe void GenTextures([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
        {
            // ImplicitCountSpanOverloader
            GenTextures((uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe void GenTextures([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            GenTextures((uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public ExtTextureObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

