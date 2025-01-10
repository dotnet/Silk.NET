// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class OS
{
    [NativeTypeName("#define OS_WINDOWS 0")]
    public const int OS_WINDOWS = 0;

    [NativeTypeName("#define OS_NT 1")]
    public const int OS_NT = 1;

    [NativeTypeName("#define OS_WIN95ORGREATER 2")]
    public const int OS_WIN95ORGREATER = 2;

    [NativeTypeName("#define OS_NT4ORGREATER 3")]
    public const int OS_NT4ORGREATER = 3;

    [NativeTypeName("#define OS_WIN98ORGREATER 5")]
    public const int OS_WIN98ORGREATER = 5;

    [NativeTypeName("#define OS_WIN98_GOLD 6")]
    public const int OS_WIN98_GOLD = 6;

    [NativeTypeName("#define OS_WIN2000ORGREATER 7")]
    public const int OS_WIN2000ORGREATER = 7;

    [NativeTypeName("#define OS_WIN2000PRO 8")]
    public const int OS_WIN2000PRO = 8;

    [NativeTypeName("#define OS_WIN2000SERVER 9")]
    public const int OS_WIN2000SERVER = 9;

    [NativeTypeName("#define OS_WIN2000ADVSERVER 10")]
    public const int OS_WIN2000ADVSERVER = 10;

    [NativeTypeName("#define OS_WIN2000DATACENTER 11")]
    public const int OS_WIN2000DATACENTER = 11;

    [NativeTypeName("#define OS_WIN2000TERMINAL 12")]
    public const int OS_WIN2000TERMINAL = 12;

    [NativeTypeName("#define OS_EMBEDDED 13")]
    public const int OS_EMBEDDED = 13;

    [NativeTypeName("#define OS_TERMINALCLIENT 14")]
    public const int OS_TERMINALCLIENT = 14;

    [NativeTypeName("#define OS_TERMINALREMOTEADMIN 15")]
    public const int OS_TERMINALREMOTEADMIN = 15;

    [NativeTypeName("#define OS_WIN95_GOLD 16")]
    public const int OS_WIN95_GOLD = 16;

    [NativeTypeName("#define OS_MEORGREATER 17")]
    public const int OS_MEORGREATER = 17;

    [NativeTypeName("#define OS_XPORGREATER 18")]
    public const int OS_XPORGREATER = 18;

    [NativeTypeName("#define OS_HOME 19")]
    public const int OS_HOME = 19;

    [NativeTypeName("#define OS_PROFESSIONAL 20")]
    public const int OS_PROFESSIONAL = 20;

    [NativeTypeName("#define OS_DATACENTER 21")]
    public const int OS_DATACENTER = 21;

    [NativeTypeName("#define OS_ADVSERVER 22")]
    public const int OS_ADVSERVER = 22;

    [NativeTypeName("#define OS_SERVER 23")]
    public const int OS_SERVER = 23;

    [NativeTypeName("#define OS_TERMINALSERVER 24")]
    public const int OS_TERMINALSERVER = 24;

    [NativeTypeName("#define OS_PERSONALTERMINALSERVER 25")]
    public const int OS_PERSONALTERMINALSERVER = 25;

    [NativeTypeName("#define OS_FASTUSERSWITCHING 26")]
    public const int OS_FASTUSERSWITCHING = 26;

    [NativeTypeName("#define OS_WELCOMELOGONUI 27")]
    public const int OS_WELCOMELOGONUI = 27;

    [NativeTypeName("#define OS_DOMAINMEMBER 28")]
    public const int OS_DOMAINMEMBER = 28;

    [NativeTypeName("#define OS_ANYSERVER 29")]
    public const int OS_ANYSERVER = 29;

    [NativeTypeName("#define OS_WOW6432 30")]
    public const int OS_WOW6432 = 30;

    [NativeTypeName("#define OS_WEBSERVER 31")]
    public const int OS_WEBSERVER = 31;

    [NativeTypeName("#define OS_SMALLBUSINESSSERVER 32")]
    public const int OS_SMALLBUSINESSSERVER = 32;

    [NativeTypeName("#define OS_TABLETPC 33")]
    public const int OS_TABLETPC = 33;

    [NativeTypeName("#define OS_SERVERADMINUI 34")]
    public const int OS_SERVERADMINUI = 34;

    [NativeTypeName("#define OS_MEDIACENTER 35")]
    public const int OS_MEDIACENTER = 35;

    [NativeTypeName("#define OS_APPLIANCE 36")]
    public const int OS_APPLIANCE = 36;
}
