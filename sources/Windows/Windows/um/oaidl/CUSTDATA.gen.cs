// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CUSTDATA.xml' path='doc/member[@name="CUSTDATA"]/*'/>
public unsafe partial struct CUSTDATA
{
    /// <include file='CUSTDATA.xml' path='doc/member[@name="CUSTDATA.cCustData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCustData;
    /// <include file='CUSTDATA.xml' path='doc/member[@name="CUSTDATA.prgCustData"]/*'/>
    [NativeTypeName("LPCUSTDATAITEM")]
    public CUSTDATAITEM* prgCustData;
}