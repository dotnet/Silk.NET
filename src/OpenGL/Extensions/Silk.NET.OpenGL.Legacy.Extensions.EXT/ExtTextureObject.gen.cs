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
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreTexturesResidentEXT", Convention = CallingConvention.Winapi)]
        public partial bool AreTexturesResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glBindTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBindTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glDeleteTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures);

        [NativeApi(EntryPoint = "glGenTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Texture textures);

        [NativeApi(EntryPoint = "glIsTextureEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float priorities);

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, textures, out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) textures.Length, in textures.GetPinnableReference(), residences);
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, textures, out residences.GetPinnableReference());
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) textures.Length, in textures.GetPinnableReference(), residences);
        }

        public unsafe bool AreTexturesResident([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreTexturesResident((uint) residences.Length, in textures.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        public unsafe void DeleteTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // ImplicitCountSpanOverloader
            DeleteTextures((uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void DeleteTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures)
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

        public unsafe void GenTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> textures)
        {
            // ImplicitCountSpanOverloader
            GenTextures((uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe void GenTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            GenTextures((uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTextures([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTextures((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public unsafe uint GenTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenTextures(n, out uint silkRet);
            return silkRet;
        }

        public ExtTextureObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

