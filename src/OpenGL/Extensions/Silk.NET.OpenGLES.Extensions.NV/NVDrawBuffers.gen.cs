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

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_draw_buffers")]
    public abstract unsafe partial class NVDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersNV")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] NV* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersNV")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<NV> bufs);

        public NVDrawBuffers(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

