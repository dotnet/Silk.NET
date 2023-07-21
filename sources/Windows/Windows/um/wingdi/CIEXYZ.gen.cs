// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CIEXYZ.xml' path='doc/member[@name="CIEXYZ"]/*' />
public partial struct CIEXYZ
{
    /// <include file='CIEXYZ.xml' path='doc/member[@name="CIEXYZ.ciexyzX"]/*' />
    [NativeTypeName("FXPT2DOT30")]
    public int ciexyzX;

    /// <include file='CIEXYZ.xml' path='doc/member[@name="CIEXYZ.ciexyzY"]/*' />
    [NativeTypeName("FXPT2DOT30")]
    public int ciexyzY;

    /// <include file='CIEXYZ.xml' path='doc/member[@name="CIEXYZ.ciexyzZ"]/*' />
    [NativeTypeName("FXPT2DOT30")]
    public int ciexyzZ;
}
