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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_buffers")]
    public unsafe partial class ExtDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersEXT")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersEXT")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in EXT bufs);

        public ExtDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

