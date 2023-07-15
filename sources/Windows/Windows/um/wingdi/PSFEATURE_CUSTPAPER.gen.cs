// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PSFEATURE_CUSTPAPER.xml' path='doc/member[@name="PSFEATURE_CUSTPAPER"]/*'/>
public partial struct PSFEATURE_CUSTPAPER
{
    /// <include file='PSFEATURE_CUSTPAPER.xml' path='doc/member[@name="PSFEATURE_CUSTPAPER.lOrientation"]/*'/>
    [NativeTypeName("LONG")]
    public int lOrientation;
    /// <include file='PSFEATURE_CUSTPAPER.xml' path='doc/member[@name="PSFEATURE_CUSTPAPER.lWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int lWidth;
    /// <include file='PSFEATURE_CUSTPAPER.xml' path='doc/member[@name="PSFEATURE_CUSTPAPER.lHeight"]/*'/>
    [NativeTypeName("LONG")]
    public int lHeight;
    /// <include file='PSFEATURE_CUSTPAPER.xml' path='doc/member[@name="PSFEATURE_CUSTPAPER.lWidthOffset"]/*'/>
    [NativeTypeName("LONG")]
    public int lWidthOffset;
    /// <include file='PSFEATURE_CUSTPAPER.xml' path='doc/member[@name="PSFEATURE_CUSTPAPER.lHeightOffset"]/*'/>
    [NativeTypeName("LONG")]
    public int lHeightOffset;
}