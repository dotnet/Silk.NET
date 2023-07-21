// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SIP_CAP_SET_V2.xml' path='doc/member[@name="SIP_CAP_SET_V2"]/*' />
public partial struct SIP_CAP_SET_V2
{
    /// <include file='SIP_CAP_SET_V2.xml' path='doc/member[@name="SIP_CAP_SET_V2.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIP_CAP_SET_V2.xml' path='doc/member[@name="SIP_CAP_SET_V2.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SIP_CAP_SET_V2.xml' path='doc/member[@name="SIP_CAP_SET_V2.isMultiSign"]/*' />
    public BOOL isMultiSign;

    /// <include file='SIP_CAP_SET_V2.xml' path='doc/member[@name="SIP_CAP_SET_V2.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}
