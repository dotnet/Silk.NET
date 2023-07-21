// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP"]/*' />
public enum D2D1_TABLETRANSFER_PROP
{
    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_RED_TABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_RED_TABLE = 0,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_RED_DISABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_RED_DISABLE = 1,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_GREEN_TABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_GREEN_TABLE = 2,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_GREEN_DISABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_GREEN_DISABLE = 3,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_BLUE_TABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_BLUE_TABLE = 4,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_BLUE_DISABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_BLUE_DISABLE = 5,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_ALPHA_TABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_ALPHA_TABLE = 6,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE"]/*' />
    D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE = 7,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT"]/*' />
    D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT = 8,

    /// <include file='D2D1_TABLETRANSFER_PROP.xml' path='doc/member[@name="D2D1_TABLETRANSFER_PROP.D2D1_TABLETRANSFER_PROP_FORCE_DWORD"]/*' />
    D2D1_TABLETRANSFER_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
