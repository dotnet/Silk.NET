// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_draw_buffers")]
    public unsafe partial class ArbDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ARB* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<ARB> bufs);

        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs);

        public ArbDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

