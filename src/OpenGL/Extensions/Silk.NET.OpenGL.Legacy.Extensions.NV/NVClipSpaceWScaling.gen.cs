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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_clip_space_w_scaling")]
    public abstract unsafe partial class NVClipSpaceWScaling : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewportPositionWScaleNV")]
        public abstract void ViewportPositionWScale([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float xcoeff, [Flow(FlowDirection.In)] float ycoeff);

        public NVClipSpaceWScaling(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

