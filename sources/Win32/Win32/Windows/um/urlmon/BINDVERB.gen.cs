// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum BINDVERB
{
    BINDVERB_GET = 0,
    BINDVERB_POST = 0x1,
    BINDVERB_PUT = 0x2,
    BINDVERB_CUSTOM = 0x3,
    BINDVERB_RESERVED1 = 0x4,
}
