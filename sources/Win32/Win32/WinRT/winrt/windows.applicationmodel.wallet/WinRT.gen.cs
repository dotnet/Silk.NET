// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletBarcode =
        "Windows.ApplicationModel.Wallet.IWalletBarcode";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletBarcodeFactory =
        "Windows.ApplicationModel.Wallet.IWalletBarcodeFactory";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletItem =
        "Windows.ApplicationModel.Wallet.IWalletItem";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletItemCustomProperty =
        "Windows.ApplicationModel.Wallet.IWalletItemCustomProperty";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletItemCustomPropertyFactory =
        "Windows.ApplicationModel.Wallet.IWalletItemCustomPropertyFactory";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletItemFactory =
        "Windows.ApplicationModel.Wallet.IWalletItemFactory";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletItemStore =
        "Windows.ApplicationModel.Wallet.IWalletItemStore";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletItemStore2 =
        "Windows.ApplicationModel.Wallet.IWalletItemStore2";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletManagerStatics =
        "Windows.ApplicationModel.Wallet.IWalletManagerStatics";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletRelevantLocation =
        "Windows.ApplicationModel.Wallet.IWalletRelevantLocation";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletTransaction =
        "Windows.ApplicationModel.Wallet.IWalletTransaction";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletVerb =
        "Windows.ApplicationModel.Wallet.IWalletVerb";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_ApplicationModel_Wallet_IWalletVerbFactory =
        "Windows.ApplicationModel.Wallet.IWalletVerbFactory";

    [NativeTypeName("const WCHAR[46]")]
    [Obsolete(
        "WalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletBarcode =
        "Windows.ApplicationModel.Wallet.WalletBarcode";

    [NativeTypeName("const WCHAR[43]")]
    [Obsolete(
        "WalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletItem =
        "Windows.ApplicationModel.Wallet.WalletItem";

    [NativeTypeName("const WCHAR[57]")]
    [Obsolete(
        "WalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletItemCustomProperty =
        "Windows.ApplicationModel.Wallet.WalletItemCustomProperty";

    [NativeTypeName("const WCHAR[48]")]
    [Obsolete(
        "WalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletItemStore =
        "Windows.ApplicationModel.Wallet.WalletItemStore";

    [NativeTypeName("const WCHAR[46]")]
    [Obsolete(
        "WalletManager is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletManager =
        "Windows.ApplicationModel.Wallet.WalletManager";

    [NativeTypeName("const WCHAR[55]")]
    [Obsolete(
        "WalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletRelevantLocation =
        "Windows.ApplicationModel.Wallet.WalletRelevantLocation";

    [NativeTypeName("const WCHAR[50]")]
    [Obsolete(
        "WalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletTransaction =
        "Windows.ApplicationModel.Wallet.WalletTransaction";

    [NativeTypeName("const WCHAR[43]")]
    [Obsolete(
        "WalletVerb is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Wallet_WalletVerb =
        "Windows.ApplicationModel.Wallet.WalletVerb";

    [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_WALLET_WALLETCONTRACT_VERSION 0x20000")]
    public const int WINDOWS_APPLICATIONMODEL_WALLET_WALLETCONTRACT_VERSION = 0x20000;
}
