// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE"]/*'/>
public enum SPSHORTCUTTYPE
{
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPSHT_NotOverriden"]/*'/>
    SPSHT_NotOverriden = -1,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPSHT_Unknown"]/*'/>
    SPSHT_Unknown = 0,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPSHT_EMAIL"]/*'/>
    SPSHT_EMAIL = 0x1000,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPSHT_OTHER"]/*'/>
    SPSHT_OTHER = 0x2000,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPPS_RESERVED1"]/*'/>
    SPPS_RESERVED1 = 0x3000,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPPS_RESERVED2"]/*'/>
    SPPS_RESERVED2 = 0x4000,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPPS_RESERVED3"]/*'/>
    SPPS_RESERVED3 = 0x5000,
    /// <include file='SPSHORTCUTTYPE.xml' path='doc/member[@name="SPSHORTCUTTYPE.SPPS_RESERVED4"]/*'/>
    SPPS_RESERVED4 = 0xf000,
}