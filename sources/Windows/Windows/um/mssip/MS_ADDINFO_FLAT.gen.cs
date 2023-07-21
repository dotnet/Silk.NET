// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MS_ADDINFO_FLAT.xml' path='doc/member[@name="MS_ADDINFO_FLAT"]/*' />
public unsafe partial struct MS_ADDINFO_FLAT
{
    /// <include file='MS_ADDINFO_FLAT.xml' path='doc/member[@name="MS_ADDINFO_FLAT.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MS_ADDINFO_FLAT.xml' path='doc/member[@name="MS_ADDINFO_FLAT.pIndirectData"]/*' />
    [NativeTypeName("struct SIP_INDIRECT_DATA_ *")]
    public SIP_INDIRECT_DATA* pIndirectData;
}
