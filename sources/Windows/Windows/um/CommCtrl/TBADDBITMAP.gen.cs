// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TBADDBITMAP.xml' path='doc/member[@name="TBADDBITMAP"]/*'/>
public partial struct TBADDBITMAP
{
    /// <include file='TBADDBITMAP.xml' path='doc/member[@name="TBADDBITMAP.hInst"]/*'/>
    public HINSTANCE hInst;
    /// <include file='TBADDBITMAP.xml' path='doc/member[@name="TBADDBITMAP.nID"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint nID;
}