// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_POSTERIZE_PROP.xml' path='doc/member[@name="D2D1_POSTERIZE_PROP"]/*' />
public enum D2D1_POSTERIZE_PROP
{
    /// <include file='D2D1_POSTERIZE_PROP.xml' path='doc/member[@name="D2D1_POSTERIZE_PROP.D2D1_POSTERIZE_PROP_RED_VALUE_COUNT"]/*' />
    D2D1_POSTERIZE_PROP_RED_VALUE_COUNT = 0,

    /// <include file='D2D1_POSTERIZE_PROP.xml' path='doc/member[@name="D2D1_POSTERIZE_PROP.D2D1_POSTERIZE_PROP_GREEN_VALUE_COUNT"]/*' />
    D2D1_POSTERIZE_PROP_GREEN_VALUE_COUNT = 1,

    /// <include file='D2D1_POSTERIZE_PROP.xml' path='doc/member[@name="D2D1_POSTERIZE_PROP.D2D1_POSTERIZE_PROP_BLUE_VALUE_COUNT"]/*' />
    D2D1_POSTERIZE_PROP_BLUE_VALUE_COUNT = 2,

    /// <include file='D2D1_POSTERIZE_PROP.xml' path='doc/member[@name="D2D1_POSTERIZE_PROP.D2D1_POSTERIZE_PROP_FORCE_DWORD"]/*' />
    D2D1_POSTERIZE_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
