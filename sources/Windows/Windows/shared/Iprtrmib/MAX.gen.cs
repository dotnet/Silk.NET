// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_SCOPE_NAME_LEN 255")]
    public const int MAX_SCOPE_NAME_LEN = 255;
    [NativeTypeName("#define MAX_MIB_OFFSET 8")]
    public const int MAX_MIB_OFFSET = 8;
}