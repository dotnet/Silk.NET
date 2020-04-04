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

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    [Extension("GREMEDY_frame_terminator")]
    public abstract unsafe partial class GremedyFrameTerminator : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFrameTerminatorGREMEDY")]
        public abstract void FrameTerminator();

        public GremedyFrameTerminator(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

