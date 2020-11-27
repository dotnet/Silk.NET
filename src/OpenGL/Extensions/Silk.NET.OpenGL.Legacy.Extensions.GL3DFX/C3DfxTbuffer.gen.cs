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

namespace Silk.NET.OpenGL.Legacy.Extensions.GL3DFX
{
    [Extension("3DFX_tbuffer")]
    public unsafe partial class C3DfxTbuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "3DFX_tbuffer";
        [NativeApi(EntryPoint = "glTbufferMask3DFX")]
        public partial void TbufferMask3Dfx([Flow(FlowDirection.In)] uint mask);

        public C3DfxTbuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

