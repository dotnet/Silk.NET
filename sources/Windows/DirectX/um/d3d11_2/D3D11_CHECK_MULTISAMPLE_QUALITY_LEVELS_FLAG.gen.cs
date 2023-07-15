// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG.xml' path='doc/member[@name="D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG
{
    /// <include file='D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG.xml' path='doc/member[@name="D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG.D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_TILED_RESOURCE"]/*'/>
    D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_TILED_RESOURCE = 0x1,
}