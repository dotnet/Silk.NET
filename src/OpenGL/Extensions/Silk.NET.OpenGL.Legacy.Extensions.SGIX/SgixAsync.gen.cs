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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_async")]
    public unsafe partial class SgixAsync : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_async";
        [NativeApi(EntryPoint = "glAsyncMarkerSGIX")]
        public partial void AsyncMarker([Flow(FlowDirection.In)] uint marker);

        [NativeApi(EntryPoint = "glDeleteAsyncMarkersSGIX")]
        public partial void DeleteAsyncMarkers([Flow(FlowDirection.In)] uint marker, [Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glFinishAsyncSGIX")]
        public unsafe partial int FinishAsync([Count(Count = 1), Flow(FlowDirection.Out)] uint* markerp);

        [NativeApi(EntryPoint = "glFinishAsyncSGIX")]
        public partial int FinishAsync([Count(Count = 1), Flow(FlowDirection.Out)] out uint markerp);

        [NativeApi(EntryPoint = "glGenAsyncMarkersSGIX")]
        public partial uint GenAsyncMarkers([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glIsAsyncMarkerSGIX")]
        public partial bool IsAsyncMarker([Flow(FlowDirection.In)] uint marker);

        [NativeApi(EntryPoint = "glPollAsyncSGIX")]
        public unsafe partial int PollAsync([Count(Count = 1), Flow(FlowDirection.Out)] uint* markerp);

        [NativeApi(EntryPoint = "glPollAsyncSGIX")]
        public partial int PollAsync([Count(Count = 1), Flow(FlowDirection.Out)] out uint markerp);

        public SgixAsync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

