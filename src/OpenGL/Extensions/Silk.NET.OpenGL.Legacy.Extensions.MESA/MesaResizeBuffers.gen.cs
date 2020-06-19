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

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [Extension("MESA_resize_buffers")]
    public abstract unsafe partial class MesaResizeBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_resize_buffers";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glResizeBuffersMESA")]
        public abstract void ResizeBuffers();

        public MesaResizeBuffers(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

