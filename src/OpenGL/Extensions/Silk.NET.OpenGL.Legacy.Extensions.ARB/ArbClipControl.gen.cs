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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_clip_control")]
    public unsafe partial class ArbClipControl : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_clip_control";
        [NativeApi(EntryPoint = "glClipControl")]
        public partial void ClipControl([Flow(FlowDirection.In)] ARB origin, [Flow(FlowDirection.In)] ARB depth);

        [NativeApi(EntryPoint = "glClipControl")]
        public partial void ClipControl([Flow(FlowDirection.In)] ARB origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        [NativeApi(EntryPoint = "glClipControl")]
        public partial void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ARB depth);

        [NativeApi(EntryPoint = "glClipControl")]
        public partial void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        public ArbClipControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

