// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TRANSACTIONMANAGER
{
    [NativeTypeName("#define TRANSACTIONMANAGER_OBJECT_PATH L\"\\\\TransactionManager\\\\\"")]
    public const string TRANSACTIONMANAGER_OBJECT_PATH = "\\TransactionManager\\";

    [NativeTypeName("#define TRANSACTIONMANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(TRANSACTIONMANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
    public const uint TRANSACTIONMANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (42 + (38 * 2));
}
