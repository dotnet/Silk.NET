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

namespace Silk.NET.OpenGL.Legacy.Extensions.GL3DFX
{
    [Extension("3DFX_tbuffer")]
    public unsafe partial class C3DfxTbuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "3DFX_tbuffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTbufferMask3DFX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TbufferMask3Dfx([Flow(FlowDirection.In)] uint mask)
            => ImplTbufferMask3Dfx(mask);

        public C3DfxTbuffer(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

