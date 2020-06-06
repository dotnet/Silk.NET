// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_clip_control")]
    public unsafe partial class ExtClipControl : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_clip_control";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="origin">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClipControlEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClipControl([Flow(FlowDirection.In)] EXT origin, [Flow(FlowDirection.In)] EXT depth)
            => ImplClipControl(origin, depth);

        public ExtClipControl(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

