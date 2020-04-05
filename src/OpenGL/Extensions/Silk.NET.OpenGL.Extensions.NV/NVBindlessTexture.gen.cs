// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_bindless_texture")]
    public abstract unsafe partial class NVBindlessTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetImageHandleNV")]
        public abstract ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] NV format);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureHandleNV")]
        public abstract ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSamplerHandleNV")]
        public abstract ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsImageHandleResidentNV")]
        public abstract bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsTextureHandleResidentNV")]
        public abstract bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentNV")]
        public abstract void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeImageHandleResidentNV")]
        public abstract void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] NV access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentNV")]
        public abstract void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeTextureHandleResidentNV")]
        public abstract void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64NV")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vNV")]
        public abstract unsafe void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vNV")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64NV")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64vNV")]
        public abstract unsafe void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64vNV")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetImageHandleNV")]
        public abstract ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        public NVBindlessTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

