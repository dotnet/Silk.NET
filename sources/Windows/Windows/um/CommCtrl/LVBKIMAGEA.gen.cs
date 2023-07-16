// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA"]/*'/>
public unsafe partial struct LVBKIMAGEA
{
    /// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA.ulFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulFlags;
    /// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA.hbm"]/*'/>
    public HBITMAP hbm;
    /// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA.pszImage"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszImage;
    /// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA.cchImageMax"]/*'/>
    public uint cchImageMax;
    /// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA.xOffsetPercent"]/*'/>
    public int xOffsetPercent;
    /// <include file='LVBKIMAGEA.xml' path='doc/member[@name="LVBKIMAGEA.yOffsetPercent"]/*'/>
    public int yOffsetPercent;
}