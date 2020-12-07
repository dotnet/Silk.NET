// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [Extension("MESA_resize_buffers")]
    public unsafe partial class MesaResizeBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_resize_buffers";
        [NativeApi(EntryPoint = "glResizeBuffersMESA")]
        public partial void ResizeBuffers();

        public MesaResizeBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

