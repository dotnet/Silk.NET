// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrExternalCameraAttachedToDeviceOCULUS")]
    public enum ExternalCameraAttachedToDeviceOCULUS : int
    {
        [Obsolete("Deprecated in favour of \"NoneOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_NONE_OCULUS")]
        ExternalCameraAttachedToDeviceNoneOculus = 0,
        [Obsolete("Deprecated in favour of \"HmdOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_HMD_OCULUS")]
        ExternalCameraAttachedToDeviceHmdOculus = 1,
        [Obsolete("Deprecated in favour of \"LtouchOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_LTOUCH_OCULUS")]
        ExternalCameraAttachedToDeviceLtouchOculus = 2,
        [Obsolete("Deprecated in favour of \"RtouchOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_RTOUCH_OCULUS")]
        ExternalCameraAttachedToDeviceRtouchOculus = 3,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_NONE_OCULUS")]
        NoneOculus = 0,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_HMD_OCULUS")]
        HmdOculus = 1,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_LTOUCH_OCULUS")]
        LtouchOculus = 2,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_RTOUCH_OCULUS")]
        RtouchOculus = 3,
    }
}
