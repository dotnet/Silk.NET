// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CODEINTEGRITY
{
    [NativeTypeName("#define CODEINTEGRITY_OPTION_ENABLED 0x01")]
    public const int CODEINTEGRITY_OPTION_ENABLED = 0x01;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_TESTSIGN 0x02")]
    public const int CODEINTEGRITY_OPTION_TESTSIGN = 0x02;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_UMCI_ENABLED 0x04")]
    public const int CODEINTEGRITY_OPTION_UMCI_ENABLED = 0x04;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_UMCI_AUDITMODE_ENABLED 0x08")]
    public const int CODEINTEGRITY_OPTION_UMCI_AUDITMODE_ENABLED = 0x08;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_UMCI_EXCLUSIONPATHS_ENABLED 0x10")]
    public const int CODEINTEGRITY_OPTION_UMCI_EXCLUSIONPATHS_ENABLED = 0x10;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_TEST_BUILD 0x20")]
    public const int CODEINTEGRITY_OPTION_TEST_BUILD = 0x20;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_PREPRODUCTION_BUILD 0x40")]
    public const int CODEINTEGRITY_OPTION_PREPRODUCTION_BUILD = 0x40;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_DEBUGMODE_ENABLED 0x80")]
    public const int CODEINTEGRITY_OPTION_DEBUGMODE_ENABLED = 0x80;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_FLIGHT_BUILD 0x100")]
    public const int CODEINTEGRITY_OPTION_FLIGHT_BUILD = 0x100;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_FLIGHTING_ENABLED 0x200")]
    public const int CODEINTEGRITY_OPTION_FLIGHTING_ENABLED = 0x200;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_KMCI_ENABLED 0x400")]
    public const int CODEINTEGRITY_OPTION_HVCI_KMCI_ENABLED = 0x400;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_KMCI_AUDITMODE_ENABLED 0x800")]
    public const int CODEINTEGRITY_OPTION_HVCI_KMCI_AUDITMODE_ENABLED = 0x800;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_KMCI_STRICTMODE_ENABLED 0x1000")]
    public const int CODEINTEGRITY_OPTION_HVCI_KMCI_STRICTMODE_ENABLED = 0x1000;

    [NativeTypeName("#define CODEINTEGRITY_OPTION_HVCI_IUM_ENABLED 0x2000")]
    public const int CODEINTEGRITY_OPTION_HVCI_IUM_ENABLED = 0x2000;
}
