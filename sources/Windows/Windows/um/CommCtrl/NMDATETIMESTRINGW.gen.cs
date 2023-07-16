// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMDATETIMESTRINGW.xml' path='doc/member[@name="NMDATETIMESTRINGW"]/*'/>
public unsafe partial struct NMDATETIMESTRINGW
{
    /// <include file='NMDATETIMESTRINGW.xml' path='doc/member[@name="NMDATETIMESTRINGW.nmhdr"]/*'/>
    public NMHDR nmhdr;
    /// <include file='NMDATETIMESTRINGW.xml' path='doc/member[@name="NMDATETIMESTRINGW.pszUserString"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszUserString;
    /// <include file='NMDATETIMESTRINGW.xml' path='doc/member[@name="NMDATETIMESTRINGW.st"]/*'/>
    public SYSTEMTIME st;
    /// <include file='NMDATETIMESTRINGW.xml' path='doc/member[@name="NMDATETIMESTRINGW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}