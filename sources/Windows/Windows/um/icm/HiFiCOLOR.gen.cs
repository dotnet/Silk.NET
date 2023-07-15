// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HiFiCOLOR.xml' path='doc/member[@name="HiFiCOLOR"]/*'/>
public unsafe partial struct HiFiCOLOR
{
    /// <include file='HiFiCOLOR.xml' path='doc/member[@name="HiFiCOLOR.channel"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte channel[8];
}