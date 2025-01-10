// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum INTERNAL_IF_OPER_STATUS
{
    IF_OPER_STATUS_NON_OPERATIONAL = 0,
    IF_OPER_STATUS_UNREACHABLE = 1,
    IF_OPER_STATUS_DISCONNECTED = 2,
    IF_OPER_STATUS_CONNECTING = 3,
    IF_OPER_STATUS_CONNECTED = 4,
    IF_OPER_STATUS_OPERATIONAL = 5,
}
