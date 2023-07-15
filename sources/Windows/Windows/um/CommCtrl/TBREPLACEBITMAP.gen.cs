// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TBREPLACEBITMAP.xml' path='doc/member[@name="TBREPLACEBITMAP"]/*'/>
public partial struct TBREPLACEBITMAP
{
    /// <include file='TBREPLACEBITMAP.xml' path='doc/member[@name="TBREPLACEBITMAP.hInstOld"]/*'/>
    public HINSTANCE hInstOld;
    /// <include file='TBREPLACEBITMAP.xml' path='doc/member[@name="TBREPLACEBITMAP.nIDOld"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint nIDOld;
    /// <include file='TBREPLACEBITMAP.xml' path='doc/member[@name="TBREPLACEBITMAP.hInstNew"]/*'/>
    public HINSTANCE hInstNew;
    /// <include file='TBREPLACEBITMAP.xml' path='doc/member[@name="TBREPLACEBITMAP.nIDNew"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint nIDNew;
    /// <include file='TBREPLACEBITMAP.xml' path='doc/member[@name="TBREPLACEBITMAP.nButtons"]/*'/>
    public int nButtons;
}