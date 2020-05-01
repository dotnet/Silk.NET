// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_get_frame_timestamps")]
    public abstract unsafe partial class AndroidGetFrameTimestamps : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_get_frame_timestamps";
        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID")]
        public abstract unsafe bool GetCompositorTiming([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* names, [Flow(FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID")]
        public abstract bool GetCompositorTiming([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] Span<int> names, [Flow(FlowDirection.Out)] Span<long> values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingSupportedANDROID")]
        public abstract bool GetCompositorTimingSupporte([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID")]
        public abstract unsafe bool GetFrameTimestamp([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* timestamps, [Flow(FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID")]
        public abstract bool GetFrameTimestamp([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] Span<int> timestamps, [Flow(FlowDirection.Out)] Span<long> values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampSupportedANDROID")]
        public abstract bool GetFrameTimestampSupporte([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int timestamp);

        [NativeApi(EntryPoint = "eglGetNextFrameIdANDROID")]
        public abstract unsafe bool GetNextFrameId([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.Out)] ulong* frameId);

        [NativeApi(EntryPoint = "eglGetNextFrameIdANDROID")]
        public abstract bool GetNextFrameId([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.Out)] Span<ulong> frameId);

        public unsafe bool GetCompositorTiming([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* names, [Flow(FlowDirection.Out)] long* values)
        {
            // IntPtrOverloader
            return GetCompositorTiming(new IntPtr(dpy), new IntPtr(surface), numTimestamps, names, values);
        }

        public unsafe bool GetCompositorTiming([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] Span<int> names, [Flow(FlowDirection.Out)] Span<long> values)
        {
            // IntPtrOverloader
            return GetCompositorTiming(new IntPtr(dpy), new IntPtr(surface), numTimestamps, names, values);
        }

        public unsafe bool GetCompositorTimingSupporte([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return GetCompositorTimingSupporte(new IntPtr(dpy), new IntPtr(surface), name);
        }

        public unsafe bool GetFrameTimestamp([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* timestamps, [Flow(FlowDirection.Out)] long* values)
        {
            // IntPtrOverloader
            return GetFrameTimestamp(new IntPtr(dpy), new IntPtr(surface), frameId, numTimestamps, timestamps, values);
        }

        public unsafe bool GetFrameTimestamp([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] Span<int> timestamps, [Flow(FlowDirection.Out)] Span<long> values)
        {
            // IntPtrOverloader
            return GetFrameTimestamp(new IntPtr(dpy), new IntPtr(surface), frameId, numTimestamps, timestamps, values);
        }

        public unsafe bool GetFrameTimestampSupporte([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int timestamp)
        {
            // IntPtrOverloader
            return GetFrameTimestampSupporte(new IntPtr(dpy), new IntPtr(surface), timestamp);
        }

        public unsafe bool GetNextFrameId([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.Out)] ulong* frameId)
        {
            // IntPtrOverloader
            return GetNextFrameId(new IntPtr(dpy), new IntPtr(surface), frameId);
        }

        public unsafe bool GetNextFrameId([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.Out)] Span<ulong> frameId)
        {
            // IntPtrOverloader
            return GetNextFrameId(new IntPtr(dpy), new IntPtr(surface), frameId);
        }

        public AndroidGetFrameTimestamps(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

