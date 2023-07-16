// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TBSAVEPARAMSA.xml' path='doc/member[@name="TBSAVEPARAMSA"]/*'/>
public unsafe partial struct TBSAVEPARAMSA
{
    /// <include file='TBSAVEPARAMSA.xml' path='doc/member[@name="TBSAVEPARAMSA.hkr"]/*'/>
    public HKEY hkr;
    /// <include file='TBSAVEPARAMSA.xml' path='doc/member[@name="TBSAVEPARAMSA.pszSubKey"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszSubKey;
    /// <include file='TBSAVEPARAMSA.xml' path='doc/member[@name="TBSAVEPARAMSA.pszValueName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszValueName;
}