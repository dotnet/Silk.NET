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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_clip_space_w_scaling")]
    public unsafe partial class NVClipSpaceWScaling : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_clip_space_w_scaling";
        [NativeApi(EntryPoint = "glViewportPositionWScaleNV")]
        public partial void ViewportPositionWScale([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float xcoeff, [Flow(FlowDirection.In)] float ycoeff);

        public NVClipSpaceWScaling(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

