// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_TRANSACTION_DESCRIPTION_LENGTH 64")]
    public const int MAX_TRANSACTION_DESCRIPTION_LENGTH = 64;

    [NativeTypeName("#define MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH 64")]
    public const int MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH = 64;
}
