// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVITEMINDEX.xml' path='doc/member[@name="LVITEMINDEX"]/*'/>
public partial struct LVITEMINDEX
{
    /// <include file='LVITEMINDEX.xml' path='doc/member[@name="LVITEMINDEX.iItem"]/*'/>
    public int iItem;
    /// <include file='LVITEMINDEX.xml' path='doc/member[@name="LVITEMINDEX.iGroup"]/*'/>
    public int iGroup;
}