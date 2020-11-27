// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_draw_buffers")]
    public unsafe partial class AtiDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersATI")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ATI* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersATI")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in ATI bufs);

        [NativeApi(EntryPoint = "glDrawBuffersATI")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersATI")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in DrawBufferMode bufs);

        public AtiDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

