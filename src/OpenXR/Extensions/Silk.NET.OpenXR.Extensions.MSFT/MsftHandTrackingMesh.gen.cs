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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_hand_tracking_mesh")]
    public unsafe partial class MsftHandTrackingMesh : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_hand_tracking_mesh";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandMeshSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateHandMeshSpaceMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandMeshSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandMeshSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateHandMeshSpaceMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandMeshSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandMeshSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateHandMeshSpaceMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandMeshSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandMeshSpaceMSFT", Convention = CallingConvention.Winapi)]
        public partial Result CreateHandMeshSpaceMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandMeshSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateHandMeshMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateHandMeshMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandMeshUpdateInfoMSFT* updateInfo, [Count(Count = 0)] HandMeshMSFT* handMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateHandMeshMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateHandMeshMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandMeshUpdateInfoMSFT* updateInfo, [Count(Count = 0)] ref HandMeshMSFT handMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateHandMeshMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateHandMeshMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandMeshUpdateInfoMSFT updateInfo, [Count(Count = 0)] HandMeshMSFT* handMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateHandMeshMSFT", Convention = CallingConvention.Winapi)]
        public partial Result UpdateHandMeshMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandMeshUpdateInfoMSFT updateInfo, [Count(Count = 0)] ref HandMeshMSFT handMesh);

        public MsftHandTrackingMesh(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

