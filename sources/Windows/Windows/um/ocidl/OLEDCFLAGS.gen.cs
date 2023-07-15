// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLEDCFLAGS.xml' path='doc/member[@name="OLEDCFLAGS"]/*'/>
public enum OLEDCFLAGS
{
    /// <include file='OLEDCFLAGS.xml' path='doc/member[@name="OLEDCFLAGS.OLEDC_NODRAW"]/*'/>
    OLEDC_NODRAW = 0x1,
    /// <include file='OLEDCFLAGS.xml' path='doc/member[@name="OLEDCFLAGS.OLEDC_PAINTBKGND"]/*'/>
    OLEDC_PAINTBKGND = 0x2,
    /// <include file='OLEDCFLAGS.xml' path='doc/member[@name="OLEDCFLAGS.OLEDC_OFFSCREEN"]/*'/>
    OLEDC_OFFSCREEN = 0x4,
}