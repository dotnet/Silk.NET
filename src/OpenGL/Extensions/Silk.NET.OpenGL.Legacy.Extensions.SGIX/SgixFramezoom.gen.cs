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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_framezoom")]
    public abstract unsafe partial class SgixFramezoom : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_framezoom";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFrameZoomSGIX")]
        public abstract void FrameZoom([Flow(FlowDirection.In)] int factor);

        public SgixFramezoom(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

