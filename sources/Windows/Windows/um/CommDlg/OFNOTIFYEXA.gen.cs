// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OFNOTIFYEXA.xml' path='doc/member[@name="OFNOTIFYEXA"]/*'/>
public unsafe partial struct OFNOTIFYEXA
{
    /// <include file='OFNOTIFYEXA.xml' path='doc/member[@name="OFNOTIFYEXA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='OFNOTIFYEXA.xml' path='doc/member[@name="OFNOTIFYEXA.lpOFN"]/*'/>
    [NativeTypeName("LPOPENFILENAMEA")]
    public OPENFILENAMEA* lpOFN;
    /// <include file='OFNOTIFYEXA.xml' path='doc/member[@name="OFNOTIFYEXA.psf"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* psf;
    /// <include file='OFNOTIFYEXA.xml' path='doc/member[@name="OFNOTIFYEXA.pidl"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pidl;
}