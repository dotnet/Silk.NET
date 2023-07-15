// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TVSORTCB.xml' path='doc/member[@name="TVSORTCB"]/*'/>
public unsafe partial struct TVSORTCB
{
    /// <include file='TVSORTCB.xml' path='doc/member[@name="TVSORTCB.hParent"]/*'/>
    public HTREEITEM hParent;
    /// <include file='TVSORTCB.xml' path='doc/member[@name="TVSORTCB.lpfnCompare"]/*'/>
    [NativeTypeName("PFNTVCOMPARE")]
    public delegate* unmanaged<LPARAM, LPARAM, LPARAM, int> lpfnCompare;
    /// <include file='TVSORTCB.xml' path='doc/member[@name="TVSORTCB.lParam"]/*'/>
    public LPARAM lParam;
}