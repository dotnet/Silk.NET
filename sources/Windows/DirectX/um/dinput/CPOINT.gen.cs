// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='CPOINT.xml' path='doc/member[@name="CPOINT"]/*' />
public partial struct CPOINT
{
    /// <include file='CPOINT.xml' path='doc/member[@name="CPOINT.lP"]/*' />
    [NativeTypeName("LONG")]
    public int lP;

    /// <include file='CPOINT.xml' path='doc/member[@name="CPOINT.dwLog"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLog;
}
