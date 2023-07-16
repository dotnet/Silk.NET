// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DXGI_OVERLAY_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_SUPPORT_FLAG"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum DXGI_OVERLAY_SUPPORT_FLAG
{
    /// <include file='DXGI_OVERLAY_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_SUPPORT_FLAG.DXGI_OVERLAY_SUPPORT_FLAG_DIRECT"]/*'/>
    DXGI_OVERLAY_SUPPORT_FLAG_DIRECT = 0x1,
    /// <include file='DXGI_OVERLAY_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_SUPPORT_FLAG.DXGI_OVERLAY_SUPPORT_FLAG_SCALING"]/*'/>
    DXGI_OVERLAY_SUPPORT_FLAG_SCALING = 0x2,
}