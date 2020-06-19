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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_buffers")]
    public abstract unsafe partial class ExtDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersEXT")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersEXT")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<EXT> bufs);

        public ExtDrawBuffers(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

