// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMKEY.xml' path='doc/member[@name="NMKEY"]/*'/>
public partial struct NMKEY
{
    /// <include file='NMKEY.xml' path='doc/member[@name="NMKEY.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMKEY.xml' path='doc/member[@name="NMKEY.nVKey"]/*'/>
    public uint nVKey;
    /// <include file='NMKEY.xml' path='doc/member[@name="NMKEY.uFlags"]/*'/>
    public uint uFlags;
}