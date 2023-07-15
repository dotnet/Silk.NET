// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMDATETIMEWMKEYDOWNW.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNW"]/*'/>
public unsafe partial struct NMDATETIMEWMKEYDOWNW
{
    /// <include file='NMDATETIMEWMKEYDOWNW.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNW.nmhdr"]/*'/>
    public NMHDR nmhdr;
    /// <include file='NMDATETIMEWMKEYDOWNW.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNW.nVirtKey"]/*'/>
    public int nVirtKey;
    /// <include file='NMDATETIMEWMKEYDOWNW.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNW.pszFormat"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszFormat;
    /// <include file='NMDATETIMEWMKEYDOWNW.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNW.st"]/*'/>
    public SYSTEMTIME st;
}