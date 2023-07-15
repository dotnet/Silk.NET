// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMDATETIMESTRINGA.xml' path='doc/member[@name="NMDATETIMESTRINGA"]/*'/>
public unsafe partial struct NMDATETIMESTRINGA
{
    /// <include file='NMDATETIMESTRINGA.xml' path='doc/member[@name="NMDATETIMESTRINGA.nmhdr"]/*'/>
    public NMHDR nmhdr;
    /// <include file='NMDATETIMESTRINGA.xml' path='doc/member[@name="NMDATETIMESTRINGA.pszUserString"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszUserString;
    /// <include file='NMDATETIMESTRINGA.xml' path='doc/member[@name="NMDATETIMESTRINGA.st"]/*'/>
    public SYSTEMTIME st;
    /// <include file='NMDATETIMESTRINGA.xml' path='doc/member[@name="NMDATETIMESTRINGA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}