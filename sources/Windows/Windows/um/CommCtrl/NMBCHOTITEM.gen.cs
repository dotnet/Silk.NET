// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMBCHOTITEM.xml' path='doc/member[@name="NMBCHOTITEM"]/*'/>
public partial struct NMBCHOTITEM
{
    /// <include file='NMBCHOTITEM.xml' path='doc/member[@name="NMBCHOTITEM.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMBCHOTITEM.xml' path='doc/member[@name="NMBCHOTITEM.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}