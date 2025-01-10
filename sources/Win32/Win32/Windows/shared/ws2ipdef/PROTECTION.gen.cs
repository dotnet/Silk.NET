// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PROTECTION
{
    [NativeTypeName("#define PROTECTION_LEVEL_UNRESTRICTED 10")]
    public const int PROTECTION_LEVEL_UNRESTRICTED = 10;

    [NativeTypeName("#define PROTECTION_LEVEL_EDGERESTRICTED 20")]
    public const int PROTECTION_LEVEL_EDGERESTRICTED = 20;

    [NativeTypeName("#define PROTECTION_LEVEL_RESTRICTED 30")]
    public const int PROTECTION_LEVEL_RESTRICTED = 30;

    [NativeTypeName("#define PROTECTION_LEVEL_DEFAULT ((UINT)-1)")]
    public const uint PROTECTION_LEVEL_DEFAULT = unchecked((uint)(-1));
}
