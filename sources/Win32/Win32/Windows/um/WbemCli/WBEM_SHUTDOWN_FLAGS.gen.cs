// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_SHUTDOWN_FLAGS
{
    WBEM_SHUTDOWN_UNLOAD_COMPONENT = 1,
    WBEM_SHUTDOWN_WMI = 2,
    WBEM_SHUTDOWN_OS = 3,
}
