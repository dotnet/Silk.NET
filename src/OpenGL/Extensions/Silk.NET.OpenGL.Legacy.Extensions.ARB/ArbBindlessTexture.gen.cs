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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_bindless_texture")]
    public abstract unsafe partial class ArbBindlessTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        public abstract ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB format);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureHandleARB")]
        public abstract ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSamplerHandleARB")]
        public abstract ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsImageHandleResidentARB")]
        public abstract bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsTextureHandleResidentARB")]
        public abstract bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentARB")]
        public abstract void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeImageHandleResidentARB")]
        public abstract void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] ARB access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentARB")]
        public abstract void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeTextureHandleResidentARB")]
        public abstract void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64ARB")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        public abstract unsafe void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64ARB")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        public abstract unsafe void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1ui64ARB")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        public abstract unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<ulong> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        public abstract ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        public ArbBindlessTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

