// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_DEVICE_CAPS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_DEVICE_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE"]/*'/>
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE = 0x1,
    /// <include file='D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC"]/*'/>
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC = 0x2,
    /// <include file='D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION"]/*'/>
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION = 0x4,
    /// <include file='D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION"]/*'/>
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION = 0x8,
    /// <include file='D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_DEVICE_CAPS.D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE"]/*'/>
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE = 0x10,
}