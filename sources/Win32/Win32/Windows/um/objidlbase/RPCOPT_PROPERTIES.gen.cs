// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum RPCOPT_PROPERTIES
{
    COMBND_RPCTIMEOUT = 0x1,
    COMBND_SERVER_LOCALITY = 0x2,
    COMBND_RESERVED1 = 0x4,
    COMBND_RESERVED2 = 0x5,
    COMBND_RESERVED3 = 0x8,
    COMBND_RESERVED4 = 0x10,
}
