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
    [Extension("XR_ANDROID_trackables")]
    public unsafe partial class AndroidTrackables : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_trackables";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAnchorSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSpaceCreateInfoANDROID* createInfo, [Count(Count = 0)] Space* anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAnchorSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSpaceCreateInfoANDROID* createInfo, [Count(Count = 0)] ref Space anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAnchorSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AnchorSpaceCreateInfoANDROID createInfo, [Count(Count = 0)] Space* anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public partial Result CreateAnchorSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AnchorSpaceCreateInfoANDROID createInfo, [Count(Count = 0)] ref Space anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTrackableTrackerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTrackableTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableTrackerCreateInfoANDROID* createInfo, [Count(Count = 0)] TrackableTrackerANDROID* trackableTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTrackableTrackerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTrackableTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableTrackerCreateInfoANDROID* createInfo, [Count(Count = 0)] ref TrackableTrackerANDROID trackableTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTrackableTrackerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTrackableTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableTrackerCreateInfoANDROID createInfo, [Count(Count = 0)] TrackableTrackerANDROID* trackableTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTrackableTrackerANDROID", Convention = CallingConvention.Winapi)]
        public partial Result CreateTrackableTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableTrackerCreateInfoANDROID createInfo, [Count(Count = 0)] ref TrackableTrackerANDROID trackableTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyTrackableTrackerANDROID", Convention = CallingConvention.Winapi)]
        public partial Result DestroyTrackableTracker([Count(Count = 0)] TrackableTrackerANDROID trackableTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedAnchorTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedAnchorTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedAnchorTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedAnchorTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedAnchorTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedAnchorTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedAnchorTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSupportedAnchorTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAllTrackablesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAllTrackables([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] uint* trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] ulong* trackables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAllTrackablesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAllTrackables([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] uint* trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] ref ulong trackables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAllTrackablesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAllTrackables([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] ref uint trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] ulong* trackables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAllTrackablesANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetAllTrackables([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] ref uint trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] ref ulong trackables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackablePlaneANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackablePlane([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] TrackablePlaneANDROID* planeOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackablePlaneANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackablePlane([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] ref TrackablePlaneANDROID planeOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackablePlaneANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetTrackablePlane([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableGetInfoANDROID getInfo, [Count(Count = 0)] TrackablePlaneANDROID* planeOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetTrackablePlaneANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetTrackablePlane([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TrackableGetInfoANDROID getInfo, [Count(Count = 0)] ref TrackablePlaneANDROID planeOutput);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSupportedAnchorTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSupportedAnchorTrackableTypes(instance, systemId, (uint) trackableTypes.Length, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSupportedAnchorTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSupportedAnchorTrackableTypes(instance, systemId, (uint) trackableTypes.Length, ref trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSupportedTrackableTypes(instance, systemId, (uint) trackableTypes.Length, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSupportedTrackableTypes(instance, systemId, (uint) trackableTypes.Length, ref trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetAllTrackables([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint* trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] Span<ulong> trackables)
        {
            // ImplicitCountSpanOverloader
            return GetAllTrackables(trackableTracker, (uint) trackables.Length, trackableCountOutput, ref trackables.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetAllTrackables([Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] ref uint trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] Span<ulong> trackables)
        {
            // ImplicitCountSpanOverloader
            return GetAllTrackables(trackableTracker, (uint) trackables.Length, ref trackableCountOutput, ref trackables.GetPinnableReference());
        }

        public AndroidTrackables(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

