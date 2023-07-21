// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_DISPLACEMENTMAP_PROP.xml' path='doc/member[@name="D2D1_DISPLACEMENTMAP_PROP"]/*' />
public enum D2D1_DISPLACEMENTMAP_PROP
{
    /// <include file='D2D1_DISPLACEMENTMAP_PROP.xml' path='doc/member[@name="D2D1_DISPLACEMENTMAP_PROP.D2D1_DISPLACEMENTMAP_PROP_SCALE"]/*' />
    D2D1_DISPLACEMENTMAP_PROP_SCALE = 0,

    /// <include file='D2D1_DISPLACEMENTMAP_PROP.xml' path='doc/member[@name="D2D1_DISPLACEMENTMAP_PROP.D2D1_DISPLACEMENTMAP_PROP_X_CHANNEL_SELECT"]/*' />
    D2D1_DISPLACEMENTMAP_PROP_X_CHANNEL_SELECT = 1,

    /// <include file='D2D1_DISPLACEMENTMAP_PROP.xml' path='doc/member[@name="D2D1_DISPLACEMENTMAP_PROP.D2D1_DISPLACEMENTMAP_PROP_Y_CHANNEL_SELECT"]/*' />
    D2D1_DISPLACEMENTMAP_PROP_Y_CHANNEL_SELECT = 2,

    /// <include file='D2D1_DISPLACEMENTMAP_PROP.xml' path='doc/member[@name="D2D1_DISPLACEMENTMAP_PROP.D2D1_DISPLACEMENTMAP_PROP_FORCE_DWORD"]/*' />
    D2D1_DISPLACEMENTMAP_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
