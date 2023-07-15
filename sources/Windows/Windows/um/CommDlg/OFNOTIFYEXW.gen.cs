// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OFNOTIFYEXW.xml' path='doc/member[@name="OFNOTIFYEXW"]/*'/>
public unsafe partial struct OFNOTIFYEXW
{
    /// <include file='OFNOTIFYEXW.xml' path='doc/member[@name="OFNOTIFYEXW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='OFNOTIFYEXW.xml' path='doc/member[@name="OFNOTIFYEXW.lpOFN"]/*'/>
    [NativeTypeName("LPOPENFILENAMEW")]
    public OPENFILENAMEW* lpOFN;
    /// <include file='OFNOTIFYEXW.xml' path='doc/member[@name="OFNOTIFYEXW.psf"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* psf;
    /// <include file='OFNOTIFYEXW.xml' path='doc/member[@name="OFNOTIFYEXW.pidl"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pidl;
}