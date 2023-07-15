// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW"]/*'/>
public unsafe partial struct LVBKIMAGEW
{
    /// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW.ulFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulFlags;
    /// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW.hbm"]/*'/>
    public HBITMAP hbm;
    /// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW.pszImage"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszImage;
    /// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW.cchImageMax"]/*'/>
    public uint cchImageMax;
    /// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW.xOffsetPercent"]/*'/>
    public int xOffsetPercent;
    /// <include file='LVBKIMAGEW.xml' path='doc/member[@name="LVBKIMAGEW.yOffsetPercent"]/*'/>
    public int yOffsetPercent;
}