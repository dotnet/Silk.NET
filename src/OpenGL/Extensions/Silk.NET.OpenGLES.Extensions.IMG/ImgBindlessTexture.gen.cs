// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    [Extension("IMG_bindless_texture")]
    public abstract unsafe partial class ImgBindlessTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureHandleIMG")]
        public abstract ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSamplerHandleIMG")]
        public abstract ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64IMG")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vIMG")]
        public abstract unsafe void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vIMG")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64IMG")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64vIMG")]
        public abstract unsafe void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64vIMG")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        public ImgBindlessTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

