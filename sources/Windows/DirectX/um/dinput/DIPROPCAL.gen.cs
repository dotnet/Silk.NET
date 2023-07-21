// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIPROPCAL.xml' path='doc/member[@name="DIPROPCAL"]/*' />
public partial struct DIPROPCAL
{
    /// <include file='DIPROPCAL.xml' path='doc/member[@name="DIPROPCAL.diph"]/*' />
    public DIPROPHEADER diph;

    /// <include file='DIPROPCAL.xml' path='doc/member[@name="DIPROPCAL.lMin"]/*' />
    [NativeTypeName("LONG")]
    public int lMin;

    /// <include file='DIPROPCAL.xml' path='doc/member[@name="DIPROPCAL.lCenter"]/*' />
    [NativeTypeName("LONG")]
    public int lCenter;

    /// <include file='DIPROPCAL.xml' path='doc/member[@name="DIPROPCAL.lMax"]/*' />
    [NativeTypeName("LONG")]
    public int lMax;
}
