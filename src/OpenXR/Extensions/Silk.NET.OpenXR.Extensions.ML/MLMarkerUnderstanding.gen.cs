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

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_marker_understanding")]
    public unsafe partial class MLMarkerUnderstanding : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_marker_understanding";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerDetectorCreateInfoML* createInfo, [Count(Count = 0)] MarkerDetectorML* markerDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerDetectorCreateInfoML* createInfo, [Count(Count = 0)] ref MarkerDetectorML markerDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MarkerDetectorCreateInfoML createInfo, [Count(Count = 0)] MarkerDetectorML* markerDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public partial Result CreateMarkerDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MarkerDetectorCreateInfoML createInfo, [Count(Count = 0)] ref MarkerDetectorML markerDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerSpaceML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerSpaceCreateInfoML* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerSpaceML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerSpaceCreateInfoML* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerSpaceML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MarkerSpaceCreateInfoML createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceML", Convention = CallingConvention.Winapi)]
        public partial Result CreateMarkerSpaceML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MarkerSpaceCreateInfoML createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public partial Result DestroyMarkerDetectorML([Count(Count = 0)] MarkerDetectorML markerDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerDetectorStateML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerDetectorStateML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] MarkerDetectorStateML* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerDetectorStateML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerDetectorStateML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ref MarkerDetectorStateML state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerLengthML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerLengthML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] float* meters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerLengthML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerLengthML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] ref float meters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerNumberML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerNumberML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] ulong* number);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerNumberML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerNumberML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] ref ulong number);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerReprojectionErrorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerReprojectionErrorML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] float* reprojectionErrorMeters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerReprojectionErrorML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerReprojectionErrorML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] ref float reprojectionErrorMeters);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkersML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkersML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] uint* markerCountOutput, [Count(Parameter = "markerCapacityInput")] ulong* markers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkersML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkersML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] uint* markerCountOutput, [Count(Parameter = "markerCapacityInput")] ref ulong markers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkersML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkersML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] ref uint markerCountOutput, [Count(Parameter = "markerCapacityInput")] ulong* markers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkersML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkersML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] ref uint markerCountOutput, [Count(Parameter = "markerCapacityInput")] ref ulong markers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerStringML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerStringML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerStringML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerStringML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerStringML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerStringML", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSnapshotMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SnapshotMarkerDetectorML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] MarkerDetectorSnapshotInfoML* snapshotInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSnapshotMarkerDetectorML", Convention = CallingConvention.Winapi)]
        public partial Result SnapshotMarkerDetectorML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ref MarkerDetectorSnapshotInfoML snapshotInfo);

        /// <summary>To be documented.</summary>
        public unsafe Result GetMarkersML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint* markerCountOutput, [Count(Parameter = "markerCapacityInput")] Span<ulong> markers)
        {
            // ImplicitCountSpanOverloader
            return GetMarkersML(markerDetector, (uint) markers.Length, markerCountOutput, ref markers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetMarkersML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ref uint markerCountOutput, [Count(Parameter = "markerCapacityInput")] Span<ulong> markers)
        {
            // ImplicitCountSpanOverloader
            return GetMarkersML(markerDetector, (uint) markers.Length, ref markerCountOutput, ref markers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetMarkerStringML(markerDetector, marker, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetMarkerStringML([Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetMarkerStringML(markerDetector, marker, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        public MLMarkerUnderstanding(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

