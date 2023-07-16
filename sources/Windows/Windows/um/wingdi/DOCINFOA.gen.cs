// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DOCINFOA.xml' path='doc/member[@name="DOCINFOA"]/*'/>
public unsafe partial struct DOCINFOA
{
    /// <include file='DOCINFOA.xml' path='doc/member[@name="DOCINFOA.cbSize"]/*'/>
    public int cbSize;
    /// <include file='DOCINFOA.xml' path='doc/member[@name="DOCINFOA.lpszDocName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszDocName;
    /// <include file='DOCINFOA.xml' path='doc/member[@name="DOCINFOA.lpszOutput"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszOutput;
    /// <include file='DOCINFOA.xml' path='doc/member[@name="DOCINFOA.lpszDatatype"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszDatatype;
    /// <include file='DOCINFOA.xml' path='doc/member[@name="DOCINFOA.fwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fwType;
}