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
    [Extension("NV_texture_barrier")]
    public abstract unsafe partial class NVTextureBarrier : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBarrierNV")]
        public abstract void TextureBarrier();

        public NVTextureBarrier(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

