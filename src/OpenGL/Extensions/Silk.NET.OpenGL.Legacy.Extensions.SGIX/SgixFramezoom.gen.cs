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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_framezoom")]
    public unsafe partial class SgixFramezoom : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_framezoom";
        [NativeApi(EntryPoint = "glFrameZoomSGIX")]
        public partial void FrameZoom([Flow(FlowDirection.In)] int factor);

        public SgixFramezoom(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

