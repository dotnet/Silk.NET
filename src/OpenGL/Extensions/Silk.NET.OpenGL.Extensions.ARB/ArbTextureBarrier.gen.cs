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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_texture_barrier")]
    public abstract unsafe partial class ArbTextureBarrier : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_barrier";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glTextureBarrier")]
        public abstract void TextureBarrier();

        public ArbTextureBarrier(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

