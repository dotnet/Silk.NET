// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVINFO.xml' path='doc/member[@name="DVINFO"]/*' />
public unsafe partial struct DVINFO
{
    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVAAuxSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDVAAuxSrc;

    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVAAuxCtl"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDVAAuxCtl;

    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVAAuxSrc1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDVAAuxSrc1;

    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVAAuxCtl1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDVAAuxCtl1;

    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVVAuxSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDVVAuxSrc;

    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVVAuxCtl"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDVVAuxCtl;

    /// <include file='DVINFO.xml' path='doc/member[@name="DVINFO.dwDVReserved"]/*' />
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwDVReserved[2];
}
