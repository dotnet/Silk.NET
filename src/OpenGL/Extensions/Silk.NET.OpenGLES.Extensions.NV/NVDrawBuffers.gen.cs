// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_draw_buffers")]
    public unsafe partial class NVDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersNV")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] NV* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersNV")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in NV bufs);

        public NVDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

