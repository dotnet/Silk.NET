// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_texture_multisample")]
    public unsafe partial class NVTextureMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_texture_multisample";
        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV")]
        public partial void TexImage2DMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisampleCoverageNV")]
        public partial void TexImage2DMultisampleCoverage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV")]
        public partial void TexImage3DMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisampleCoverageNV")]
        public partial void TexImage3DMultisampleCoverage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV")]
        public partial void TextureImage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleNV")]
        public partial void TextureImage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
        public partial void TextureImage2DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
        public partial void TextureImage2DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV")]
        public partial void TextureImage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleNV")]
        public partial void TextureImage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
        public partial void TextureImage3DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        [NativeApi(EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
        public partial void TextureImage3DMultisampleCoverage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] int internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations);

        public NVTextureMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

