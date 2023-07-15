// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA"]/*'/>
public unsafe partial struct TCITEMHEADERA
{
    /// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA.mask"]/*'/>
    public uint mask;
    /// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA.lpReserved1"]/*'/>
    public uint lpReserved1;
    /// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA.lpReserved2"]/*'/>
    public uint lpReserved2;
    /// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TCITEMHEADERA.xml' path='doc/member[@name="TCITEMHEADERA.iImage"]/*'/>
    public int iImage;
}