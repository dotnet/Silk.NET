// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_CROP_PROP.xml' path='doc/member[@name="D2D1_CROP_PROP"]/*' />
public enum D2D1_CROP_PROP
{
    /// <include file='D2D1_CROP_PROP.xml' path='doc/member[@name="D2D1_CROP_PROP.D2D1_CROP_PROP_RECT"]/*' />
    D2D1_CROP_PROP_RECT = 0,

    /// <include file='D2D1_CROP_PROP.xml' path='doc/member[@name="D2D1_CROP_PROP.D2D1_CROP_PROP_BORDER_MODE"]/*' />
    D2D1_CROP_PROP_BORDER_MODE = 1,

    /// <include file='D2D1_CROP_PROP.xml' path='doc/member[@name="D2D1_CROP_PROP.D2D1_CROP_PROP_FORCE_DWORD"]/*' />
    D2D1_CROP_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
