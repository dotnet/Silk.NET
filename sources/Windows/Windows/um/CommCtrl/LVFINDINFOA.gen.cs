// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVFINDINFOA.xml' path='doc/member[@name="LVFINDINFOA"]/*'/>
public unsafe partial struct LVFINDINFOA
{
    /// <include file='LVFINDINFOA.xml' path='doc/member[@name="LVFINDINFOA.flags"]/*'/>
    public uint flags;
    /// <include file='LVFINDINFOA.xml' path='doc/member[@name="LVFINDINFOA.psz"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* psz;
    /// <include file='LVFINDINFOA.xml' path='doc/member[@name="LVFINDINFOA.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='LVFINDINFOA.xml' path='doc/member[@name="LVFINDINFOA.pt"]/*'/>
    public POINT pt;
    /// <include file='LVFINDINFOA.xml' path='doc/member[@name="LVFINDINFOA.vkDirection"]/*'/>
    public uint vkDirection;
}