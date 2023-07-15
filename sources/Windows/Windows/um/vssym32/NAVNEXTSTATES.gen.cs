// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NAVNEXTSTATES.xml' path='doc/member[@name="NAVNEXTSTATES"]/*'/>
public enum NAVNEXTSTATES
{
    /// <include file='NAVNEXTSTATES.xml' path='doc/member[@name="NAVNEXTSTATES.MCNN_NORMAL"]/*'/>
    MCNN_NORMAL = 1,
    /// <include file='NAVNEXTSTATES.xml' path='doc/member[@name="NAVNEXTSTATES.MCNN_HOT"]/*'/>
    MCNN_HOT = 2,
    /// <include file='NAVNEXTSTATES.xml' path='doc/member[@name="NAVNEXTSTATES.MCNN_PRESSED"]/*'/>
    MCNN_PRESSED = 3,
    /// <include file='NAVNEXTSTATES.xml' path='doc/member[@name="NAVNEXTSTATES.MCNN_DISABLED"]/*'/>
    MCNN_DISABLED = 4,
}