// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DOWNSTATES.xml' path='doc/member[@name="DOWNSTATES"]/*'/>
public enum DOWNSTATES
{
    /// <include file='DOWNSTATES.xml' path='doc/member[@name="DOWNSTATES.DNS_NORMAL"]/*'/>
    DNS_NORMAL = 1,
    /// <include file='DOWNSTATES.xml' path='doc/member[@name="DOWNSTATES.DNS_HOT"]/*'/>
    DNS_HOT = 2,
    /// <include file='DOWNSTATES.xml' path='doc/member[@name="DOWNSTATES.DNS_PRESSED"]/*'/>
    DNS_PRESSED = 3,
    /// <include file='DOWNSTATES.xml' path='doc/member[@name="DOWNSTATES.DNS_DISABLED"]/*'/>
    DNS_DISABLED = 4,
}