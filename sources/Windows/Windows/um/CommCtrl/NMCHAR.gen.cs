// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMCHAR.xml' path='doc/member[@name="NMCHAR"]/*'/>
public partial struct NMCHAR
{
    /// <include file='NMCHAR.xml' path='doc/member[@name="NMCHAR.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCHAR.xml' path='doc/member[@name="NMCHAR.ch"]/*'/>
    public uint ch;
    /// <include file='NMCHAR.xml' path='doc/member[@name="NMCHAR.dwItemPrev"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwItemPrev;
    /// <include file='NMCHAR.xml' path='doc/member[@name="NMCHAR.dwItemNext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwItemNext;
}