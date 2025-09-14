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
    [Extension("XR_ANDROID_raycast")]
    public unsafe partial class AndroidRaycast : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_raycast";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRaycastSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRaycastSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRaycastSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRaycastSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRaycastSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRaycastSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRaycastSupportedTrackableTypesANDROID", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateRaycastSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] ref TrackableTypeANDROID trackableTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRaycastANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result Raycast([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RaycastInfoANDROID* rayInfo, [Count(Count = 0)] RaycastHitResultsANDROID* results);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRaycastANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result Raycast([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RaycastInfoANDROID* rayInfo, [Count(Count = 0)] ref RaycastHitResultsANDROID results);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRaycastANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result Raycast([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RaycastInfoANDROID rayInfo, [Count(Count = 0)] RaycastHitResultsANDROID* results);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRaycastANDROID", Convention = CallingConvention.Winapi)]
        public partial Result Raycast([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RaycastInfoANDROID rayInfo, [Count(Count = 0)] ref RaycastHitResultsANDROID results);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRaycastSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRaycastSupportedTrackableTypes(instance, systemId, (uint) trackableTypes.Length, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRaycastSupportedTrackableTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRaycastSupportedTrackableTypes(instance, systemId, (uint) trackableTypes.Length, ref trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        public AndroidRaycast(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

