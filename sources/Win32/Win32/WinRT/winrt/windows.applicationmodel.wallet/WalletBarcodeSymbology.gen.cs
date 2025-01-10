// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete(
    "WalletBarcodeSymbology is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public enum WalletBarcodeSymbology
{
    WalletBarcodeSymbology_Invalid = 0,
    WalletBarcodeSymbology_Upca = 1,
    WalletBarcodeSymbology_Upce = 2,
    WalletBarcodeSymbology_Ean13 = 3,
    WalletBarcodeSymbology_Ean8 = 4,
    WalletBarcodeSymbology_Itf = 5,
    WalletBarcodeSymbology_Code39 = 6,
    WalletBarcodeSymbology_Code128 = 7,
    WalletBarcodeSymbology_Qr = 8,
    WalletBarcodeSymbology_Pdf417 = 9,
    WalletBarcodeSymbology_Aztec = 10,
    WalletBarcodeSymbology_Custom = 100000,
}
