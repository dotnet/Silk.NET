// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_STATUS_TYPE
{
    WBEM_STATUS_COMPLETE = 0,
    WBEM_STATUS_REQUIREMENTS = 1,
    WBEM_STATUS_PROGRESS = 2,
    WBEM_STATUS_LOGGING_INFORMATION = 0x100,
    WBEM_STATUS_LOGGING_INFORMATION_PROVIDER = 0x200,
    WBEM_STATUS_LOGGING_INFORMATION_HOST = 0x400,
    WBEM_STATUS_LOGGING_INFORMATION_REPOSITORY = 0x800,
    WBEM_STATUS_LOGGING_INFORMATION_ESS = 0x1000,
}
