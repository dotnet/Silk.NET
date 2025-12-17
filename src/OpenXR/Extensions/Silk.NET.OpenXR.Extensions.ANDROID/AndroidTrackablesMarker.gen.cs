// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    [Extension("XR_ANDROID_trackables_marker")]
    public unsafe partial class AndroidTrackablesMarker : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_trackables_marker";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableMarkerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackableMarker([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] TrackableMarkerANDROID* markerOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableMarkerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackableMarker([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] ref TrackableMarkerANDROID markerOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableMarkerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackableMarker([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableGetInfoANDROID getInfo, [Count(Count = 0)] TrackableMarkerANDROID* markerOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableMarkerANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetTrackableMarker([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableGetInfoANDROID getInfo, [Count(Count = 0)] ref TrackableMarkerANDROID markerOutput);

        public AndroidTrackablesMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

