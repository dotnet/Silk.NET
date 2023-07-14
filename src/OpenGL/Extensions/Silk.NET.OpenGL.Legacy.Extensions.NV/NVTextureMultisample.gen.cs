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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_texture_multisample")]
    public unsafe partial class NVTextureMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_texture_multisample";
        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3DMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations);

        public NVTextureMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

