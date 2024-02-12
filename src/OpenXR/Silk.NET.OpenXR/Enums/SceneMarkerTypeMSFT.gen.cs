// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneMarkerTypeMSFT")]
    public enum SceneMarkerTypeMSFT : int
    {
        [Obsolete("Deprecated in favour of \"QRCodeMsft\"")]
        [NativeName("Name", "XR_SCENE_MARKER_TYPE_QR_CODE_MSFT")]
        SceneMarkerTypeQRCodeMsft = 1,
        [NativeName("Name", "XR_SCENE_MARKER_TYPE_QR_CODE_MSFT")]
        QRCodeMsft = 1,
    }
}
