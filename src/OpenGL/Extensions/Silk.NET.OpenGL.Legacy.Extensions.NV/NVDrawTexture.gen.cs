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
    [Extension("NV_draw_texture")]
    public unsafe partial class NVDrawTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_texture";
        [NativeApi(EntryPoint = "glDrawTextureNV")]
        public partial void DrawTexture([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] float x0, [Flow(FlowDirection.In)] float y0, [Flow(FlowDirection.In)] float x1, [Flow(FlowDirection.In)] float y1, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float s0, [Flow(FlowDirection.In)] float t0, [Flow(FlowDirection.In)] float s1, [Flow(FlowDirection.In)] float t1);

        public NVDrawTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

