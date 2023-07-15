// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMTRBTHUMBPOSCHANGING.xml' path='doc/member[@name="NMTRBTHUMBPOSCHANGING"]/*'/>
public partial struct NMTRBTHUMBPOSCHANGING
{
    /// <include file='NMTRBTHUMBPOSCHANGING.xml' path='doc/member[@name="NMTRBTHUMBPOSCHANGING.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTRBTHUMBPOSCHANGING.xml' path='doc/member[@name="NMTRBTHUMBPOSCHANGING.dwPos"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPos;
    /// <include file='NMTRBTHUMBPOSCHANGING.xml' path='doc/member[@name="NMTRBTHUMBPOSCHANGING.nReason"]/*'/>
    public int nReason;
}