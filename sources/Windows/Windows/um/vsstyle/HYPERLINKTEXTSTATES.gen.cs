// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HYPERLINKTEXTSTATES.xml' path='doc/member[@name="HYPERLINKTEXTSTATES"]/*'/>
public enum HYPERLINKTEXTSTATES
{
    /// <include file='HYPERLINKTEXTSTATES.xml' path='doc/member[@name="HYPERLINKTEXTSTATES.TS_HYPERLINK_NORMAL"]/*'/>
    TS_HYPERLINK_NORMAL = 1,
    /// <include file='HYPERLINKTEXTSTATES.xml' path='doc/member[@name="HYPERLINKTEXTSTATES.TS_HYPERLINK_HOT"]/*'/>
    TS_HYPERLINK_HOT = 2,
    /// <include file='HYPERLINKTEXTSTATES.xml' path='doc/member[@name="HYPERLINKTEXTSTATES.TS_HYPERLINK_PRESSED"]/*'/>
    TS_HYPERLINK_PRESSED = 3,
    /// <include file='HYPERLINKTEXTSTATES.xml' path='doc/member[@name="HYPERLINKTEXTSTATES.TS_HYPERLINK_DISABLED"]/*'/>
    TS_HYPERLINK_DISABLED = 4,
}