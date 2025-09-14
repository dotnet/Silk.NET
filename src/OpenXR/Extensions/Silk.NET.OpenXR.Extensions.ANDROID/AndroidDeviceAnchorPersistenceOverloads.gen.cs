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

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    public static class AndroidDeviceAnchorPersistenceOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDeviceAnchorPersistence(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceAnchorPersistenceCreateInfoANDROID* createInfo, [Count(Count = 0)] Span<DeviceAnchorPersistenceANDROID> outHandle)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAnchorPersistence(session, createInfo, ref outHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDeviceAnchorPersistence(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceAnchorPersistenceCreateInfoANDROID> createInfo, [Count(Count = 0)] DeviceAnchorPersistenceANDROID* outHandle)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAnchorPersistence(session, in createInfo.GetPinnableReference(), outHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDeviceAnchorPersistence(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceAnchorPersistenceCreateInfoANDROID> createInfo, [Count(Count = 0)] Span<DeviceAnchorPersistenceANDROID> outHandle)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAnchorPersistence(session, in createInfo.GetPinnableReference(), ref outHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePersistedAnchorSpace(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PersistedAnchorSpaceCreateInfoANDROID* createInfo, [Count(Count = 0)] Span<Space> anchorOutput)
        {
            // SpanOverloader
            return thisApi.CreatePersistedAnchorSpace(handle, createInfo, ref anchorOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePersistedAnchorSpace(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PersistedAnchorSpaceCreateInfoANDROID> createInfo, [Count(Count = 0)] Space* anchorOutput)
        {
            // SpanOverloader
            return thisApi.CreatePersistedAnchorSpace(handle, in createInfo.GetPinnableReference(), anchorOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePersistedAnchorSpace(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PersistedAnchorSpaceCreateInfoANDROID> createInfo, [Count(Count = 0)] Span<Space> anchorOutput)
        {
            // SpanOverloader
            return thisApi.CreatePersistedAnchorSpace(handle, in createInfo.GetPinnableReference(), ref anchorOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePersistedAnchors(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] uint* anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] Span<UuidEXT> anchorIds)
        {
            // SpanOverloader
            return thisApi.EnumeratePersistedAnchors(handle, anchorIdCapacityInput, anchorIdCountOutput, ref anchorIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePersistedAnchors(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] Span<uint> anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] UuidEXT* anchorIds)
        {
            // SpanOverloader
            return thisApi.EnumeratePersistedAnchors(handle, anchorIdCapacityInput, ref anchorIdCountOutput.GetPinnableReference(), anchorIds);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePersistedAnchors(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0)] uint anchorIdCapacityInput, [Count(Count = 0)] Span<uint> anchorIdCountOutput, [Count(Parameter = "anchorIdCapacityInput")] Span<UuidEXT> anchorIds)
        {
            // SpanOverloader
            return thisApi.EnumeratePersistedAnchors(handle, anchorIdCapacityInput, ref anchorIdCountOutput.GetPinnableReference(), ref anchorIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedPersistenceAnchorTypes(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedPersistenceAnchorTypes(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedPersistenceAnchorTypes(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedPersistenceAnchorTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), trackableTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedPersistenceAnchorTypes(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedPersistenceAnchorTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAnchorPersistState(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* anchorId, [Count(Count = 0)] Span<AnchorPersistStateANDROID> persistState)
        {
            // SpanOverloader
            return thisApi.GetAnchorPersistState(handle, anchorId, ref persistState.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAnchorPersistState(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UuidEXT> anchorId, [Count(Count = 0)] AnchorPersistStateANDROID* persistState)
        {
            // SpanOverloader
            return thisApi.GetAnchorPersistState(handle, in anchorId.GetPinnableReference(), persistState);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAnchorPersistState(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UuidEXT> anchorId, [Count(Count = 0)] Span<AnchorPersistStateANDROID> persistState)
        {
            // SpanOverloader
            return thisApi.GetAnchorPersistState(handle, in anchorId.GetPinnableReference(), ref persistState.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistAnchor(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PersistedAnchorSpaceInfoANDROID* persistedInfo, [Count(Count = 0)] Span<UuidEXT> anchorIdOutput)
        {
            // SpanOverloader
            return thisApi.PersistAnchor(handle, persistedInfo, ref anchorIdOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistAnchor(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PersistedAnchorSpaceInfoANDROID> persistedInfo, [Count(Count = 0)] UuidEXT* anchorIdOutput)
        {
            // SpanOverloader
            return thisApi.PersistAnchor(handle, in persistedInfo.GetPinnableReference(), anchorIdOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistAnchor(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PersistedAnchorSpaceInfoANDROID> persistedInfo, [Count(Count = 0)] Span<UuidEXT> anchorIdOutput)
        {
            // SpanOverloader
            return thisApi.PersistAnchor(handle, in persistedInfo.GetPinnableReference(), ref anchorIdOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistAnchor(this AndroidDeviceAnchorPersistence thisApi, [Count(Count = 0)] DeviceAnchorPersistenceANDROID handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UuidEXT> anchorId)
        {
            // SpanOverloader
            return thisApi.UnpersistAnchor(handle, in anchorId.GetPinnableReference());
        }

    }
}

