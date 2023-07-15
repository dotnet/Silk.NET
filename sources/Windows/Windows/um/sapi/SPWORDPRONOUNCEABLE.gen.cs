// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPWORDPRONOUNCEABLE.xml' path='doc/member[@name="SPWORDPRONOUNCEABLE"]/*'/>
public enum SPWORDPRONOUNCEABLE
{
    /// <include file='SPWORDPRONOUNCEABLE.xml' path='doc/member[@name="SPWORDPRONOUNCEABLE.SPWP_UNKNOWN_WORD_UNPRONOUNCEABLE"]/*'/>
    SPWP_UNKNOWN_WORD_UNPRONOUNCEABLE = 0,
    /// <include file='SPWORDPRONOUNCEABLE.xml' path='doc/member[@name="SPWORDPRONOUNCEABLE.SPWP_UNKNOWN_WORD_PRONOUNCEABLE"]/*'/>
    SPWP_UNKNOWN_WORD_PRONOUNCEABLE = 1,
    /// <include file='SPWORDPRONOUNCEABLE.xml' path='doc/member[@name="SPWORDPRONOUNCEABLE.SPWP_KNOWN_WORD_PRONOUNCEABLE"]/*'/>
    SPWP_KNOWN_WORD_PRONOUNCEABLE = 2,
}