// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO"]/*'/>
public unsafe partial struct MCGRIDINFO
{
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.dwPart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPart;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.iCalendar"]/*'/>
    public int iCalendar;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.iRow"]/*'/>
    public int iRow;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.iCol"]/*'/>
    public int iCol;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.bSelected"]/*'/>
    public BOOL bSelected;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.stStart"]/*'/>
    public SYSTEMTIME stStart;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.stEnd"]/*'/>
    public SYSTEMTIME stEnd;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.rc"]/*'/>
    public RECT rc;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.pszName"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pszName;
    /// <include file='MCGRIDINFO.xml' path='doc/member[@name="MCGRIDINFO.cchName"]/*'/>
    [NativeTypeName("size_t")]
    public nuint cchName;
}