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
    [Extension("ARB_shader_image_load_store")]
    public abstract unsafe partial class ArbShaderImageLoadStore : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindImageTexture")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB access, [Flow(FlowDirection.In)] ARB format);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryBarrier")]
        public abstract void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindImageTexture")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        public ArbShaderImageLoadStore(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

