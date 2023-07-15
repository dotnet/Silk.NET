// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMMOUSE.xml' path='doc/member[@name="NMMOUSE"]/*'/>
public partial struct NMMOUSE
{
    /// <include file='NMMOUSE.xml' path='doc/member[@name="NMMOUSE.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMMOUSE.xml' path='doc/member[@name="NMMOUSE.dwItemSpec"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwItemSpec;
    /// <include file='NMMOUSE.xml' path='doc/member[@name="NMMOUSE.dwItemData"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwItemData;
    /// <include file='NMMOUSE.xml' path='doc/member[@name="NMMOUSE.pt"]/*'/>
    public POINT pt;
    /// <include file='NMMOUSE.xml' path='doc/member[@name="NMMOUSE.dwHitInfo"]/*'/>
    public LPARAM dwHitInfo;
}