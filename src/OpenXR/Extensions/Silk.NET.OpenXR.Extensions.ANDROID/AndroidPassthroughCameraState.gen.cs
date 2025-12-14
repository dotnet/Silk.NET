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
    [Extension("XR_ANDROID_passthrough_camera_state")]
    public unsafe partial class AndroidPassthroughCameraState : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_passthrough_camera_state";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPassthroughCameraStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPassthroughCameraState([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCameraStateGetInfoANDROID* getInfo, [Count(Count = 0)] PassthroughCameraStateANDROID* cameraStateOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPassthroughCameraStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPassthroughCameraState([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCameraStateGetInfoANDROID* getInfo, [Count(Count = 0)] ref PassthroughCameraStateANDROID cameraStateOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPassthroughCameraStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPassthroughCameraState([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PassthroughCameraStateGetInfoANDROID getInfo, [Count(Count = 0)] PassthroughCameraStateANDROID* cameraStateOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPassthroughCameraStateANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetPassthroughCameraState([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PassthroughCameraStateGetInfoANDROID getInfo, [Count(Count = 0)] ref PassthroughCameraStateANDROID cameraStateOutput);

        public AndroidPassthroughCameraState(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

