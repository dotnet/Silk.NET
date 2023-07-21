// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV"]/*' />
public unsafe partial struct DIPROPCALPOV
{
    /// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV.diph"]/*' />
    public DIPROPHEADER diph;

    /// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV.lMin"]/*' />
    [NativeTypeName("LONG[5]")]
    public fixed int lMin[5];

    /// <include file='DIPROPCALPOV.xml' path='doc/member[@name="DIPROPCALPOV.lMax"]/*' />
    [NativeTypeName("LONG[5]")]
    public fixed int lMax[5];
}
