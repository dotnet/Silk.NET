// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT"]/*' />
public enum COMPUTER_NAME_FORMAT
{
    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNameNetBIOS"]/*' />
    ComputerNameNetBIOS,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNameDnsHostname"]/*' />
    ComputerNameDnsHostname,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNameDnsDomain"]/*' />
    ComputerNameDnsDomain,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNameDnsFullyQualified"]/*' />
    ComputerNameDnsFullyQualified,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNamePhysicalNetBIOS"]/*' />
    ComputerNamePhysicalNetBIOS,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsHostname"]/*' />
    ComputerNamePhysicalDnsHostname,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsDomain"]/*' />
    ComputerNamePhysicalDnsDomain,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsFullyQualified"]/*' />
    ComputerNamePhysicalDnsFullyQualified,

    /// <include file='COMPUTER_NAME_FORMAT.xml' path='doc/member[@name="COMPUTER_NAME_FORMAT.ComputerNameMax"]/*' />
    ComputerNameMax,
}
