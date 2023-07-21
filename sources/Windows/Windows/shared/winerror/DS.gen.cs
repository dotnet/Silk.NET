// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DS
{
    [NativeTypeName("#define DS_S_SUCCESS NO_ERROR")]
    public const int DS_S_SUCCESS = 0;
}
