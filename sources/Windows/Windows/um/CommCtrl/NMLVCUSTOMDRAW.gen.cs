// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW"]/*'/>
public partial struct NMLVCUSTOMDRAW
{
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.nmcd"]/*'/>
    public NMCUSTOMDRAW nmcd;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.clrText"]/*'/>
    public COLORREF clrText;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.clrTextBk"]/*'/>
    public COLORREF clrTextBk;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.iSubItem"]/*'/>
    public int iSubItem;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.dwItemType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwItemType;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.clrFace"]/*'/>
    public COLORREF clrFace;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.iIconEffect"]/*'/>
    public int iIconEffect;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.iIconPhase"]/*'/>
    public int iIconPhase;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.iPartId"]/*'/>
    public int iPartId;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.iStateId"]/*'/>
    public int iStateId;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.rcText"]/*'/>
    public RECT rcText;
    /// <include file='NMLVCUSTOMDRAW.xml' path='doc/member[@name="NMLVCUSTOMDRAW.uAlign"]/*'/>
    public uint uAlign;
}