// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_OPACITY_PROP.xml' path='doc/member[@name="D2D1_OPACITY_PROP"]/*' />
public enum D2D1_OPACITY_PROP
{
    /// <include file='D2D1_OPACITY_PROP.xml' path='doc/member[@name="D2D1_OPACITY_PROP.D2D1_OPACITY_PROP_OPACITY"]/*' />
    D2D1_OPACITY_PROP_OPACITY = 0,

    /// <include file='D2D1_OPACITY_PROP.xml' path='doc/member[@name="D2D1_OPACITY_PROP.D2D1_OPACITY_PROP_FORCE_DWORD"]/*' />
    D2D1_OPACITY_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
