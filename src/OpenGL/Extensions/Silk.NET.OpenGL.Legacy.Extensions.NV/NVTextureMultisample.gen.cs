// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_texture_multisample")]
    public unsafe partial class NVTextureMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_texture_multisample";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage2DMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTexImage2DMultisampleCoverage(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage3DMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTexImage3DMultisampleCoverage(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);

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
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage2DMultisample(texture, target, samples, internalFormat, width, height, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage2DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage2DMultisampleCoverage(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);

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
        /// <param name="internalFormat">
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
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage3DMultisample(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage3DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage3DMultisampleCoverage(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage2DMultisampleCoverage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTexImage2DMultisampleCoverage(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage3DMultisampleCoverage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTexImage3DMultisampleCoverage(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);

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
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage2DMultisample(texture, target, samples, internalFormat, width, height, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage2DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage2DMultisampleCoverage(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);

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
        /// <param name="internalFormat">
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
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage3DMultisample(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureImage3DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations)
            => ImplTextureImage3DMultisampleCoverage(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);

        public NVTextureMultisample(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

