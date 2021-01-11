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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_stream_consumer_egloutput")]
    public unsafe partial class ExtStreamConsumerEgloutput : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_stream_consumer_egloutput";
        [NativeApi(EntryPoint = "eglStreamConsumerOutputEXT")]
        public partial int StreamConsumerOutput([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] nint layer);

        public ExtStreamConsumerEgloutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

