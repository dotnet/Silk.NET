// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPVLIMITS.xml' path='doc/member[@name="SPVLIMITS"]/*'/>
public enum SPVLIMITS
{
    /// <include file='SPVLIMITS.xml' path='doc/member[@name="SPVLIMITS.SPMIN_VOLUME"]/*'/>
    SPMIN_VOLUME = 0,
    /// <include file='SPVLIMITS.xml' path='doc/member[@name="SPVLIMITS.SPMAX_VOLUME"]/*'/>
    SPMAX_VOLUME = 100,
    /// <include file='SPVLIMITS.xml' path='doc/member[@name="SPVLIMITS.SPMIN_RATE"]/*'/>
    SPMIN_RATE = -10,
    /// <include file='SPVLIMITS.xml' path='doc/member[@name="SPVLIMITS.SPMAX_RATE"]/*'/>
    SPMAX_RATE = 10,
}