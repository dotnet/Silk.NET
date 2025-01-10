// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete(
    "WalletDetailViewPosition is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public enum WalletDetailViewPosition
{
    WalletDetailViewPosition_Hidden = 0,
    WalletDetailViewPosition_HeaderField1 = 1,
    WalletDetailViewPosition_HeaderField2 = 2,
    WalletDetailViewPosition_PrimaryField1 = 3,
    WalletDetailViewPosition_PrimaryField2 = 4,
    WalletDetailViewPosition_SecondaryField1 = 5,
    WalletDetailViewPosition_SecondaryField2 = 6,
    WalletDetailViewPosition_SecondaryField3 = 7,
    WalletDetailViewPosition_SecondaryField4 = 8,
    WalletDetailViewPosition_SecondaryField5 = 9,
    WalletDetailViewPosition_CenterField1 = 10,
    WalletDetailViewPosition_FooterField1 = 11,
    WalletDetailViewPosition_FooterField2 = 12,
    WalletDetailViewPosition_FooterField3 = 13,
    WalletDetailViewPosition_FooterField4 = 14,
}
