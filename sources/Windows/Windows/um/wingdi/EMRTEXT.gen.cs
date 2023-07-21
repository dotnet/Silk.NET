// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT"]/*' />
public partial struct EMRTEXT
{
    /// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT.ptlReference"]/*' />
    public POINTL ptlReference;

    /// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT.nChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint nChars;

    /// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT.offString"]/*' />
    [NativeTypeName("DWORD")]
    public uint offString;

    /// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT.fOptions"]/*' />
    [NativeTypeName("DWORD")]
    public uint fOptions;

    /// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT.rcl"]/*' />
    public RECTL rcl;

    /// <include file='EMRTEXT.xml' path='doc/member[@name="EMRTEXT.offDx"]/*' />
    [NativeTypeName("DWORD")]
    public uint offDx;
}
