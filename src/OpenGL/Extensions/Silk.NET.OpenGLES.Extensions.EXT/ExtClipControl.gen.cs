// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_clip_control")]
    public abstract unsafe partial class ExtClipControl : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClipControlEXT")]
        public abstract void ClipControl([Flow(FlowDirection.In)] EXT origin, [Flow(FlowDirection.In)] EXT depth);

        public ExtClipControl(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

