// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OFNOTIFYW.xml' path='doc/member[@name="OFNOTIFYW"]/*'/>
public unsafe partial struct OFNOTIFYW
{
    /// <include file='OFNOTIFYW.xml' path='doc/member[@name="OFNOTIFYW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='OFNOTIFYW.xml' path='doc/member[@name="OFNOTIFYW.lpOFN"]/*'/>
    [NativeTypeName("LPOPENFILENAMEW")]
    public OPENFILENAMEW* lpOFN;
    /// <include file='OFNOTIFYW.xml' path='doc/member[@name="OFNOTIFYW.pszFile"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszFile;
}