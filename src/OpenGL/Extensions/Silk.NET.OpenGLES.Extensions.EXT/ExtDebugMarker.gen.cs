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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_debug_marker")]
    public abstract unsafe partial class ExtDebugMarker : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        public abstract unsafe void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] char* marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        public abstract void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] Span<char> marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPopGroupMarkerEXT")]
        public abstract void PopGroupMarker();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        public abstract unsafe void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] char* marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        public abstract void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] Span<char> marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        public abstract void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        public abstract void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string marker);

        public ExtDebugMarker(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

