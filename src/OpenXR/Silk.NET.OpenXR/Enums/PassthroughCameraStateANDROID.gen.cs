// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPassthroughCameraStateANDROID")]
    public enum PassthroughCameraStateANDROID : int
    {
        [Obsolete("Deprecated in favour of \"DisabledAndroid\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_DISABLED_ANDROID")]
        PassthroughCameraStateDisabledAndroid = 0,
        [Obsolete("Deprecated in favour of \"InitializingAndroid\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_INITIALIZING_ANDROID")]
        PassthroughCameraStateInitializingAndroid = 1,
        [Obsolete("Deprecated in favour of \"ReadyAndroid\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_READY_ANDROID")]
        PassthroughCameraStateReadyAndroid = 2,
        [Obsolete("Deprecated in favour of \"ErrorAndroid\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_ERROR_ANDROID")]
        PassthroughCameraStateErrorAndroid = 3,
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_DISABLED_ANDROID")]
        DisabledAndroid = 0,
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_INITIALIZING_ANDROID")]
        InitializingAndroid = 1,
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_READY_ANDROID")]
        ReadyAndroid = 2,
        [NativeName("Name", "XR_PASSTHROUGH_CAMERA_STATE_ERROR_ANDROID")]
        ErrorAndroid = 3,
    }
}
