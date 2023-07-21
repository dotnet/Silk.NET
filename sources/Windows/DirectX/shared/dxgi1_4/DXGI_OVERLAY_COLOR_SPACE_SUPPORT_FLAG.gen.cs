// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG
{
    /// <include file='DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG.DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG_PRESENT"]/*' />
    DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG_PRESENT = 0x1,
}
