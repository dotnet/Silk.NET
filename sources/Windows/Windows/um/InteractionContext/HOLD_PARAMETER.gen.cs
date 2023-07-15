// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HOLD_PARAMETER.xml' path='doc/member[@name="HOLD_PARAMETER"]/*'/>
public enum HOLD_PARAMETER
{
    /// <include file='HOLD_PARAMETER.xml' path='doc/member[@name="HOLD_PARAMETER.HOLD_PARAMETER_MIN_CONTACT_COUNT"]/*'/>
    HOLD_PARAMETER_MIN_CONTACT_COUNT = 0x00000000,
    /// <include file='HOLD_PARAMETER.xml' path='doc/member[@name="HOLD_PARAMETER.HOLD_PARAMETER_MAX_CONTACT_COUNT"]/*'/>
    HOLD_PARAMETER_MAX_CONTACT_COUNT = 0x00000001,
    /// <include file='HOLD_PARAMETER.xml' path='doc/member[@name="HOLD_PARAMETER.HOLD_PARAMETER_THRESHOLD_RADIUS"]/*'/>
    HOLD_PARAMETER_THRESHOLD_RADIUS = 0x00000002,
    /// <include file='HOLD_PARAMETER.xml' path='doc/member[@name="HOLD_PARAMETER.HOLD_PARAMETER_THRESHOLD_START_DELAY"]/*'/>
    HOLD_PARAMETER_THRESHOLD_START_DELAY = 0x00000003,
    /// <include file='HOLD_PARAMETER.xml' path='doc/member[@name="HOLD_PARAMETER.HOLD_PARAMETER_MAX"]/*'/>
    HOLD_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}