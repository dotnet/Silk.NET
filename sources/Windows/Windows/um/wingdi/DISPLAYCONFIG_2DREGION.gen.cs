// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPLAYCONFIG_2DREGION.xml' path='doc/member[@name="DISPLAYCONFIG_2DREGION"]/*'/>
public partial struct DISPLAYCONFIG_2DREGION
{
    /// <include file='DISPLAYCONFIG_2DREGION.xml' path='doc/member[@name="DISPLAYCONFIG_2DREGION.cx"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cx;
    /// <include file='DISPLAYCONFIG_2DREGION.xml' path='doc/member[@name="DISPLAYCONFIG_2DREGION.cy"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cy;
}