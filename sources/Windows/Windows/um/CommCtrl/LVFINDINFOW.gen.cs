// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVFINDINFOW.xml' path='doc/member[@name="LVFINDINFOW"]/*'/>
public unsafe partial struct LVFINDINFOW
{
    /// <include file='LVFINDINFOW.xml' path='doc/member[@name="LVFINDINFOW.flags"]/*'/>
    public uint flags;
    /// <include file='LVFINDINFOW.xml' path='doc/member[@name="LVFINDINFOW.psz"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* psz;
    /// <include file='LVFINDINFOW.xml' path='doc/member[@name="LVFINDINFOW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='LVFINDINFOW.xml' path='doc/member[@name="LVFINDINFOW.pt"]/*'/>
    public POINT pt;
    /// <include file='LVFINDINFOW.xml' path='doc/member[@name="LVFINDINFOW.vkDirection"]/*'/>
    public uint vkDirection;
}