// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NAVPREVSTATES.xml' path='doc/member[@name="NAVPREVSTATES"]/*'/>
public enum NAVPREVSTATES
{
    /// <include file='NAVPREVSTATES.xml' path='doc/member[@name="NAVPREVSTATES.MCNP_NORMAL"]/*'/>
    MCNP_NORMAL = 1,
    /// <include file='NAVPREVSTATES.xml' path='doc/member[@name="NAVPREVSTATES.MCNP_HOT"]/*'/>
    MCNP_HOT = 2,
    /// <include file='NAVPREVSTATES.xml' path='doc/member[@name="NAVPREVSTATES.MCNP_PRESSED"]/*'/>
    MCNP_PRESSED = 3,
    /// <include file='NAVPREVSTATES.xml' path='doc/member[@name="NAVPREVSTATES.MCNP_DISABLED"]/*'/>
    MCNP_DISABLED = 4,
}