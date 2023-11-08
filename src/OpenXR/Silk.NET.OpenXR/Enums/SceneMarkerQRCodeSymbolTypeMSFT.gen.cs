// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneMarkerQRCodeSymbolTypeMSFT")]
    public enum SceneMarkerQRCodeSymbolTypeMSFT : int
    {
        [Obsolete("Deprecated in favour of \"QRCodeMsft\"")]
        [NativeName("Name", "XR_SCENE_MARKER_QR_CODE_SYMBOL_TYPE_QR_CODE_MSFT")]
        SceneMarkerQRCodeSymbolTypeQRCodeMsft = 1,
        [Obsolete("Deprecated in favour of \"MicroQRCodeMsft\"")]
        [NativeName("Name", "XR_SCENE_MARKER_QR_CODE_SYMBOL_TYPE_MICRO_QR_CODE_MSFT")]
        SceneMarkerQRCodeSymbolTypeMicroQRCodeMsft = 2,
        [NativeName("Name", "XR_SCENE_MARKER_QR_CODE_SYMBOL_TYPE_QR_CODE_MSFT")]
        QRCodeMsft = 1,
        [NativeName("Name", "XR_SCENE_MARKER_QR_CODE_SYMBOL_TYPE_MICRO_QR_CODE_MSFT")]
        MicroQRCodeMsft = 2,
    }
}
