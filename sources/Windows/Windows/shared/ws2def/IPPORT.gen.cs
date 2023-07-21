// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class IPPORT
{
    [NativeTypeName("#define IPPORT_TCPMUX 1")]
    public const int IPPORT_TCPMUX = 1;

    [NativeTypeName("#define IPPORT_ECHO 7")]
    public const int IPPORT_ECHO = 7;

    [NativeTypeName("#define IPPORT_DISCARD 9")]
    public const int IPPORT_DISCARD = 9;

    [NativeTypeName("#define IPPORT_SYSTAT 11")]
    public const int IPPORT_SYSTAT = 11;

    [NativeTypeName("#define IPPORT_DAYTIME 13")]
    public const int IPPORT_DAYTIME = 13;

    [NativeTypeName("#define IPPORT_NETSTAT 15")]
    public const int IPPORT_NETSTAT = 15;

    [NativeTypeName("#define IPPORT_QOTD 17")]
    public const int IPPORT_QOTD = 17;

    [NativeTypeName("#define IPPORT_MSP 18")]
    public const int IPPORT_MSP = 18;

    [NativeTypeName("#define IPPORT_CHARGEN 19")]
    public const int IPPORT_CHARGEN = 19;

    [NativeTypeName("#define IPPORT_FTP_DATA 20")]
    public const int IPPORT_FTP_DATA = 20;

    [NativeTypeName("#define IPPORT_FTP 21")]
    public const int IPPORT_FTP = 21;

    [NativeTypeName("#define IPPORT_TELNET 23")]
    public const int IPPORT_TELNET = 23;

    [NativeTypeName("#define IPPORT_SMTP 25")]
    public const int IPPORT_SMTP = 25;

    [NativeTypeName("#define IPPORT_TIMESERVER 37")]
    public const int IPPORT_TIMESERVER = 37;

    [NativeTypeName("#define IPPORT_NAMESERVER 42")]
    public const int IPPORT_NAMESERVER = 42;

    [NativeTypeName("#define IPPORT_WHOIS 43")]
    public const int IPPORT_WHOIS = 43;

    [NativeTypeName("#define IPPORT_MTP 57")]
    public const int IPPORT_MTP = 57;

    [NativeTypeName("#define IPPORT_TFTP 69")]
    public const int IPPORT_TFTP = 69;

    [NativeTypeName("#define IPPORT_RJE 77")]
    public const int IPPORT_RJE = 77;

    [NativeTypeName("#define IPPORT_FINGER 79")]
    public const int IPPORT_FINGER = 79;

    [NativeTypeName("#define IPPORT_TTYLINK 87")]
    public const int IPPORT_TTYLINK = 87;

    [NativeTypeName("#define IPPORT_SUPDUP 95")]
    public const int IPPORT_SUPDUP = 95;

    [NativeTypeName("#define IPPORT_POP3 110")]
    public const int IPPORT_POP3 = 110;

    [NativeTypeName("#define IPPORT_NTP 123")]
    public const int IPPORT_NTP = 123;

    [NativeTypeName("#define IPPORT_EPMAP 135")]
    public const int IPPORT_EPMAP = 135;

    [NativeTypeName("#define IPPORT_NETBIOS_NS 137")]
    public const int IPPORT_NETBIOS_NS = 137;

    [NativeTypeName("#define IPPORT_NETBIOS_DGM 138")]
    public const int IPPORT_NETBIOS_DGM = 138;

    [NativeTypeName("#define IPPORT_NETBIOS_SSN 139")]
    public const int IPPORT_NETBIOS_SSN = 139;

    [NativeTypeName("#define IPPORT_IMAP 143")]
    public const int IPPORT_IMAP = 143;

    [NativeTypeName("#define IPPORT_SNMP 161")]
    public const int IPPORT_SNMP = 161;

    [NativeTypeName("#define IPPORT_SNMP_TRAP 162")]
    public const int IPPORT_SNMP_TRAP = 162;

    [NativeTypeName("#define IPPORT_IMAP3 220")]
    public const int IPPORT_IMAP3 = 220;

    [NativeTypeName("#define IPPORT_LDAP 389")]
    public const int IPPORT_LDAP = 389;

    [NativeTypeName("#define IPPORT_HTTPS 443")]
    public const int IPPORT_HTTPS = 443;

    [NativeTypeName("#define IPPORT_MICROSOFT_DS 445")]
    public const int IPPORT_MICROSOFT_DS = 445;

    [NativeTypeName("#define IPPORT_EXECSERVER 512")]
    public const int IPPORT_EXECSERVER = 512;

    [NativeTypeName("#define IPPORT_LOGINSERVER 513")]
    public const int IPPORT_LOGINSERVER = 513;

    [NativeTypeName("#define IPPORT_CMDSERVER 514")]
    public const int IPPORT_CMDSERVER = 514;

    [NativeTypeName("#define IPPORT_EFSSERVER 520")]
    public const int IPPORT_EFSSERVER = 520;

    [NativeTypeName("#define IPPORT_BIFFUDP 512")]
    public const int IPPORT_BIFFUDP = 512;

    [NativeTypeName("#define IPPORT_WHOSERVER 513")]
    public const int IPPORT_WHOSERVER = 513;

    [NativeTypeName("#define IPPORT_ROUTESERVER 520")]
    public const int IPPORT_ROUTESERVER = 520;

    [NativeTypeName("#define IPPORT_RESERVED 1024")]
    public const int IPPORT_RESERVED = 1024;

    [NativeTypeName("#define IPPORT_REGISTERED_MIN IPPORT_RESERVED")]
    public const int IPPORT_REGISTERED_MIN = 1024;

    [NativeTypeName("#define IPPORT_REGISTERED_MAX 0xbfff")]
    public const int IPPORT_REGISTERED_MAX = 0xbfff;

    [NativeTypeName("#define IPPORT_DYNAMIC_MIN 0xc000")]
    public const int IPPORT_DYNAMIC_MIN = 0xc000;

    [NativeTypeName("#define IPPORT_DYNAMIC_MAX 0xffff")]
    public const int IPPORT_DYNAMIC_MAX = 0xffff;
}
