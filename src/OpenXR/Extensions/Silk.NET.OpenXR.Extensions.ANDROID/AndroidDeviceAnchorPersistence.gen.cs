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
    [Extension("XR_ANDROID_device_anchor_persistence")]
    public unsafe partial class AndroidDeviceAnchorPersistence : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_device_anchor_persistence";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDeviceAnchorPersistenceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDeviceAnchorPersistence([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceAnchorPersistenceCreateInfoANDROID* createInfo, [Count(Count = 0)] DeviceAnchorPersistenceANDROID* outHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDeviceAnchorPersistenceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDeviceAnchorPersistence([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceAnchorPersistenceCreateInfoANDROID* createInfo, [Count(Count = 0)] ref DeviceAnchorPersistenceANDROID outHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDeviceAnchorPersistenceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDeviceAnchorPersistence([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceAnchorPersistenceCreateInfoANDROID createInfo, [Count(Count = 0)] DeviceAnchorPersistenceANDROID* outHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDeviceAnchorPersistenceANDROID", Convention = CallingConvention.Winapi)]
        public partial Result CreateDeviceAnchorPersistence([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceAnchorPersistenceCreateInfoANDROID createInfo, [Count(Count = 0)] ref DeviceAnchorPersistenceANDROID outHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePersistedAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePersistedAnchorSpace([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PersistedAnchorSpaceCreateInfoANDROID* createInfo, [Count(Count = 0)] Space* anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePersistedAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePersistedAnchorSpace([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PersistedAnchorSpaceCreateInfoANDROID* createInfo, [Count(Count = 0)] ref Space anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePersistedAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePersistedAnchorSpace([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PersistedAnchorSpaceCreateInfoANDROID createInfo, [Count(Count = 0)] Space* anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePersistedAnchorSpaceANDROID", Convention = CallingConvention.Winapi)]
        public partial Result CreatePersistedAnchorSpace([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PersistedAnchorSpaceCreateInfoANDROID createInfo, [Count(Count = 0)] ref Space anchorOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyDeviceAnchorPersistenceANDROID", Convention = CallingConvention.Winapi)]
        public partial Result DestroyDeviceAnchorPersistence([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedAnchorsANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePersistedAnchors([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] uint* anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] UuidEXT* anchorIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedAnchorsANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePersistedAnchors([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] uint* anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] ref UuidEXT anchorIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedAnchorsANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePersistedAnchors([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] ref uint anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] UuidEXT* anchorIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedAnchorsANDROID", Convention = CallingConvention.Winapi)]
        public partial Result EnumeratePersistedAnchors([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] ref uint anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] ref UuidEXT anchorIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedPersistenceAnchorTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedPersistenceAnchorTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedPersistenceAnchorTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedPersistenceAnchorTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedPersistenceAnchorTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSupportedPersistenceAnchorTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSupportedPersistenceAnchorTypesANDROID", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSupportedPersistenceAnchorTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAnchorPersistStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAnchorPersistState([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* anchorId, [Count(Count = 0)] AnchorPersistStateANDROID* persistState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAnchorPersistStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAnchorPersistState([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* anchorId, [Count(Count = 0)] ref AnchorPersistStateANDROID persistState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAnchorPersistStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAnchorPersistState([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UuidEXT anchorId, [Count(Count = 0)] AnchorPersistStateANDROID* persistState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAnchorPersistStateANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetAnchorPersistState([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UuidEXT anchorId, [Count(Count = 0)] ref AnchorPersistStateANDROID persistState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistAnchor([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PersistedAnchorSpaceInfoANDROID* persistedInfo, [Count(Count = 0)] UuidEXT* anchorIdOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistAnchor([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PersistedAnchorSpaceInfoANDROID* persistedInfo, [Count(Count = 0)] ref UuidEXT anchorIdOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistAnchor([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PersistedAnchorSpaceInfoANDROID persistedInfo, [Count(Count = 0)] UuidEXT* anchorIdOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistAnchorANDROID", Convention = CallingConvention.Winapi)]
        public partial Result PersistAnchor([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PersistedAnchorSpaceInfoANDROID persistedInfo, [Count(Count = 0)] ref UuidEXT anchorIdOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistAnchor([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* anchorId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistAnchorANDROID", Convention = CallingConvention.Winapi)]
        public partial Result UnpersistAnchor([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UuidEXT anchorId);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumeratePersistedAnchors([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint* anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] Span<UuidEXT> anchorIds)
        {
            // ImplicitCountSpanOverloader
            return EnumeratePersistedAnchors(handle, (uint) anchorIds.Length, anchorIdCountOutput, ref anchorIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumeratePersistedAnchors([Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] ref uint anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] Span<UuidEXT> anchorIds)
        {
            // ImplicitCountSpanOverloader
            return EnumeratePersistedAnchors(handle, (uint) anchorIds.Length, ref anchorIdCountOutput, ref anchorIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSupportedPersistenceAnchorTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSupportedPersistenceAnchorTypes(instance, systemId, (uint) trackableTypes.Length, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSupportedPersistenceAnchorTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSupportedPersistenceAnchorTypes(instance, systemId, (uint) trackableTypes.Length, ref trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        public AndroidDeviceAnchorPersistence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

