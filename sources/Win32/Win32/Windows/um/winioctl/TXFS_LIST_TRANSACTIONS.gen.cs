// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TXFS_LIST_TRANSACTIONS
{
    [NativeTypeName("DWORDLONG")]
    public ulong NumberOfTransactions;

    [NativeTypeName("DWORDLONG")]
    public ulong BufferSizeRequired;
}
