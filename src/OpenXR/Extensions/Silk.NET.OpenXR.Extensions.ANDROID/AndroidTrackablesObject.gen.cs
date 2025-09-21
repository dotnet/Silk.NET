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
    [Extension("XR_ANDROID_trackables_object")]
    public unsafe partial class AndroidTrackablesObject : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_trackables_object";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableObjectANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackableObject([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] TrackableObjectANDROID* objectOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableObjectANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackableObject([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] ref TrackableObjectANDROID objectOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableObjectANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackableObject([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableGetInfoANDROID getInfo, [Count(Count = 0)] TrackableObjectANDROID* objectOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackableObjectANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetTrackableObject([Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableGetInfoANDROID getInfo, [Count(Count = 0)] ref TrackableObjectANDROID objectOutput);

        public AndroidTrackablesObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

