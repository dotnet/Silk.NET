// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_async")]
    public abstract unsafe partial class SgixAsync : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAsyncMarkerSGIX")]
        public abstract void AsyncMarker([Flow(FlowDirection.In)] uint marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteAsyncMarkersSGIX")]
        public abstract void DeleteAsyncMarkers([Flow(FlowDirection.In)] uint marker, [Flow(FlowDirection.In)] uint range);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinishAsyncSGIX")]
        public abstract unsafe int FinishAsync([Count(Count = 1), Flow(FlowDirection.Out)] uint* markerp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinishAsyncSGIX")]
        public abstract int FinishAsync([Count(Count = 1), Flow(FlowDirection.Out)] out uint markerp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenAsyncMarkersSGIX")]
        public abstract uint GenAsyncMarkers([Flow(FlowDirection.In)] uint range);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsAsyncMarkerSGIX")]
        public abstract bool IsAsyncMarker([Flow(FlowDirection.In)] uint marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPollAsyncSGIX")]
        public abstract unsafe int PollAsync([Count(Count = 1), Flow(FlowDirection.Out)] uint* markerp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPollAsyncSGIX")]
        public abstract int PollAsync([Count(Count = 1), Flow(FlowDirection.Out)] out uint markerp);

        public SgixAsync(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

