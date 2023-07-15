// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D10_COLOR_WRITE_ENABLE"]/*'/>
[Flags]
public enum D3D10_COLOR_WRITE_ENABLE
{
    /// <include file='D3D10_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D10_COLOR_WRITE_ENABLE.D3D10_COLOR_WRITE_ENABLE_RED"]/*'/>
    D3D10_COLOR_WRITE_ENABLE_RED = 1,
    /// <include file='D3D10_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D10_COLOR_WRITE_ENABLE.D3D10_COLOR_WRITE_ENABLE_GREEN"]/*'/>
    D3D10_COLOR_WRITE_ENABLE_GREEN = 2,
    /// <include file='D3D10_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D10_COLOR_WRITE_ENABLE.D3D10_COLOR_WRITE_ENABLE_BLUE"]/*'/>
    D3D10_COLOR_WRITE_ENABLE_BLUE = 4,
    /// <include file='D3D10_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D10_COLOR_WRITE_ENABLE.D3D10_COLOR_WRITE_ENABLE_ALPHA"]/*'/>
    D3D10_COLOR_WRITE_ENABLE_ALPHA = 8,
    /// <include file='D3D10_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D10_COLOR_WRITE_ENABLE.D3D10_COLOR_WRITE_ENABLE_ALL"]/*'/>
    D3D10_COLOR_WRITE_ENABLE_ALL = (((D3D10_COLOR_WRITE_ENABLE_RED | D3D10_COLOR_WRITE_ENABLE_GREEN) | D3D10_COLOR_WRITE_ENABLE_BLUE) | D3D10_COLOR_WRITE_ENABLE_ALPHA),
}