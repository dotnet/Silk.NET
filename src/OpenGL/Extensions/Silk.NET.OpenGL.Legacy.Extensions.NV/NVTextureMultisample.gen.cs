// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_texture_multisample")]
    public abstract unsafe partial class NVTextureMultisample : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV")]
        public abstract void TexImage2DMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV")]
        public abstract void TexImage3DMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV")]
        public abstract void TextureImage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
        public abstract void TextureImage2DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV")]
        public abstract void TextureImage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
        public abstract void TextureImage3DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV")]
        public abstract void TexImage2DMultisampleCoverage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV")]
        public abstract void TexImage3DMultisampleCoverage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV")]
        public abstract void TextureImage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
        public abstract void TextureImage2DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV")]
        public abstract void TextureImage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
        public abstract void TextureImage3DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        public NVTextureMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

