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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_get_frame_timestamps")]
    public unsafe partial class AndroidGetFrameTimestamps : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_get_frame_timestamps";
        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID")]
        public unsafe partial bool GetCompositorTiming([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* names, [Flow(FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID")]
        public unsafe partial bool GetCompositorTiming([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* names, [Flow(FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID")]
        public unsafe partial bool GetCompositorTiming([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] in int names, [Flow(FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID")]
        public partial bool GetCompositorTiming([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] in int names, [Flow(FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingSupportedANDROID")]
        public partial bool GetCompositorTimingSupporte([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID")]
        public unsafe partial bool GetFrameTimestamp([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* timestamps, [Flow(FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID")]
        public unsafe partial bool GetFrameTimestamp([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* timestamps, [Flow(FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID")]
        public unsafe partial bool GetFrameTimestamp([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] in int timestamps, [Flow(FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID")]
        public partial bool GetFrameTimestamp([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] in int timestamps, [Flow(FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampSupportedANDROID")]
        public partial bool GetFrameTimestampSupporte([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int timestamp);

        [NativeApi(EntryPoint = "eglGetNextFrameIdANDROID")]
        public unsafe partial bool GetNextFrameId([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.Out)] ulong* frameId);

        [NativeApi(EntryPoint = "eglGetNextFrameIdANDROID")]
        public partial bool GetNextFrameId([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.Out)] out ulong frameId);

        public AndroidGetFrameTimestamps(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

