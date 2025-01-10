// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete(
    "WalletSummaryViewPosition is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public enum WalletSummaryViewPosition
{
    WalletSummaryViewPosition_Hidden = 0,
    WalletSummaryViewPosition_Field1 = 1,
    WalletSummaryViewPosition_Field2 = 2,
}
