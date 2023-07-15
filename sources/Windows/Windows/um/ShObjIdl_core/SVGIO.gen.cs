// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SVGIO.xml' path='doc/member[@name="SVGIO"]/*'/>
public enum SVGIO
{
    /// <include file='SVGIO.xml' path='doc/member[@name="SVGIO.SVGIO_BACKGROUND"]/*'/>
    SVGIO_BACKGROUND = 0,
    /// <include file='SVGIO.xml' path='doc/member[@name="SVGIO.SVGIO_SELECTION"]/*'/>
    SVGIO_SELECTION = 0x1,
    /// <include file='SVGIO.xml' path='doc/member[@name="SVGIO.SVGIO_ALLVIEW"]/*'/>
    SVGIO_ALLVIEW = 0x2,
    /// <include file='SVGIO.xml' path='doc/member[@name="SVGIO.SVGIO_CHECKED"]/*'/>
    SVGIO_CHECKED = 0x3,
    /// <include file='SVGIO.xml' path='doc/member[@name="SVGIO.SVGIO_TYPE_MASK"]/*'/>
    SVGIO_TYPE_MASK = 0xf,
    /// <include file='SVGIO.xml' path='doc/member[@name="SVGIO.SVGIO_FLAG_VIEWORDER"]/*'/>
    SVGIO_FLAG_VIEWORDER = unchecked((int)(0x80000000)),
}