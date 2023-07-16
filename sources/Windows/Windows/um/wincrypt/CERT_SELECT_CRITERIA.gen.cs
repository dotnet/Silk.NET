// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_SELECT_CRITERIA.xml' path='doc/member[@name="CERT_SELECT_CRITERIA"]/*'/>
public unsafe partial struct CERT_SELECT_CRITERIA
{
    /// <include file='CERT_SELECT_CRITERIA.xml' path='doc/member[@name="CERT_SELECT_CRITERIA.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='CERT_SELECT_CRITERIA.xml' path='doc/member[@name="CERT_SELECT_CRITERIA.cPara"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cPara;
    /// <include file='CERT_SELECT_CRITERIA.xml' path='doc/member[@name="CERT_SELECT_CRITERIA.ppPara"]/*'/>
    public void** ppPara;
}