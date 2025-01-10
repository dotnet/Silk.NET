// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_SECURITY_FLAGS
{
    WBEM_ENABLE = 1,
    WBEM_METHOD_EXECUTE = 2,
    WBEM_FULL_WRITE_REP = 4,
    WBEM_PARTIAL_WRITE_REP = 8,
    WBEM_WRITE_PROVIDER = 0x10,
    WBEM_REMOTE_ACCESS = 0x20,
    WBEM_RIGHT_SUBSCRIBE = 0x40,
    WBEM_RIGHT_PUBLISH = 0x80,
}
