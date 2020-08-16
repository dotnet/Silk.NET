// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_bindless_texture")]
    public unsafe partial class NVBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_bindless_texture";
        [NativeApi(EntryPoint = "glGetImageHandleNV")]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] NV format);

        [NativeApi(EntryPoint = "glGetTextureHandleNV")]
        public partial ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetTextureSamplerHandleNV")]
        public partial ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glIsImageHandleResidentNV")]
        public partial bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glIsTextureHandleResidentNV")]
        public partial bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentNV")]
        public partial void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleResidentNV")]
        public partial void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentNV")]
        public partial void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeTextureHandleResidentNV")]
        public partial void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64NV")]
        public partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vNV")]
        public unsafe partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vNV")]
        public partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> values);

        [NativeApi(EntryPoint = "glUniformHandleui64NV")]
        public partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformHandleui64vNV")]
        public unsafe partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformHandleui64vNV")]
        public partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        [NativeApi(EntryPoint = "glGetImageHandleNV")]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        public NVBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

