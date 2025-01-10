// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ICardAddedEventArgs =
        "Windows.Devices.SmartCards.ICardAddedEventArgs";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ICardRemovedEventArgs =
        "Windows.Devices.SmartCards.ICardRemovedEventArgs";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_SmartCards_IKnownSmartCardAppletIds =
        "Windows.Devices.SmartCards.IKnownSmartCardAppletIds";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCard =
        "Windows.Devices.SmartCards.ISmartCard";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAppletIdGroup =
        "Windows.Devices.SmartCards.ISmartCardAppletIdGroup";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAppletIdGroup2 =
        "Windows.Devices.SmartCards.ISmartCardAppletIdGroup2";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAppletIdGroupFactory =
        "Windows.Devices.SmartCards.ISmartCardAppletIdGroupFactory";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAppletIdGroupRegistration =
        "Windows.Devices.SmartCards.ISmartCardAppletIdGroupRegistration";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAppletIdGroupRegistration2 =
        "Windows.Devices.SmartCards.ISmartCardAppletIdGroupRegistration2";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAppletIdGroupStatics =
        "Windows.Devices.SmartCards.ISmartCardAppletIdGroupStatics";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAutomaticResponseApdu =
        "Windows.Devices.SmartCards.ISmartCardAutomaticResponseApdu";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAutomaticResponseApdu2 =
        "Windows.Devices.SmartCards.ISmartCardAutomaticResponseApdu2";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAutomaticResponseApdu3 =
        "Windows.Devices.SmartCards.ISmartCardAutomaticResponseApdu3";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardAutomaticResponseApduFactory =
        "Windows.Devices.SmartCards.ISmartCardAutomaticResponseApduFactory";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardChallengeContext =
        "Windows.Devices.SmartCards.ISmartCardChallengeContext";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardConnect =
        "Windows.Devices.SmartCards.ISmartCardConnect";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardConnection =
        "Windows.Devices.SmartCards.ISmartCardConnection";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGenerator =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGenerator";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGenerator2 =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGenerator2";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGeneratorStatics =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGeneratorStatics";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGeneratorStatics2 =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGeneratorStatics2";

    [NativeTypeName("const WCHAR[93]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult";

    [NativeTypeName("const WCHAR[100]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult";

    [NativeTypeName("const WCHAR[95]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult =
        "Windows.Devices.SmartCards.ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramMaterialCharacteristics =
        "Windows.Devices.SmartCards.ISmartCardCryptogramMaterialCharacteristics";

    [NativeTypeName("const WCHAR[78]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramMaterialPackageCharacteristics =
        "Windows.Devices.SmartCards.ISmartCardCryptogramMaterialPackageCharacteristics";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramMaterialPossessionProof =
        "Windows.Devices.SmartCards.ISmartCardCryptogramMaterialPossessionProof";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramPlacementStep =
        "Windows.Devices.SmartCards.ISmartCardCryptogramPlacementStep";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramStorageKeyCharacteristics =
        "Windows.Devices.SmartCards.ISmartCardCryptogramStorageKeyCharacteristics";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramStorageKeyInfo =
        "Windows.Devices.SmartCards.ISmartCardCryptogramStorageKeyInfo";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardCryptogramStorageKeyInfo2 =
        "Windows.Devices.SmartCards.ISmartCardCryptogramStorageKeyInfo2";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulator =
        "Windows.Devices.SmartCards.ISmartCardEmulator";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulator2 =
        "Windows.Devices.SmartCards.ISmartCardEmulator2";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorApduReceivedEventArgs =
        "Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorApduReceivedEventArgs2 =
        "Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgs2";

    [NativeTypeName("const WCHAR[82]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorApduReceivedEventArgsWithCryptograms =
        "Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgsWithCryptograms";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorConnectionDeactivatedEventArgs =
        "Windows.Devices.SmartCards.ISmartCardEmulatorConnectionDeactivatedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorConnectionProperties =
        "Windows.Devices.SmartCards.ISmartCardEmulatorConnectionProperties";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorStatics =
        "Windows.Devices.SmartCards.ISmartCardEmulatorStatics";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorStatics2 =
        "Windows.Devices.SmartCards.ISmartCardEmulatorStatics2";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardEmulatorStatics3 =
        "Windows.Devices.SmartCards.ISmartCardEmulatorStatics3";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardPinPolicy =
        "Windows.Devices.SmartCards.ISmartCardPinPolicy";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardPinResetDeferral =
        "Windows.Devices.SmartCards.ISmartCardPinResetDeferral";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardPinResetRequest =
        "Windows.Devices.SmartCards.ISmartCardPinResetRequest";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardProvisioning =
        "Windows.Devices.SmartCards.ISmartCardProvisioning";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardProvisioning2 =
        "Windows.Devices.SmartCards.ISmartCardProvisioning2";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardProvisioningStatics =
        "Windows.Devices.SmartCards.ISmartCardProvisioningStatics";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardProvisioningStatics2 =
        "Windows.Devices.SmartCards.ISmartCardProvisioningStatics2";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardReader =
        "Windows.Devices.SmartCards.ISmartCardReader";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardReaderStatics =
        "Windows.Devices.SmartCards.ISmartCardReaderStatics";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardTriggerDetails =
        "Windows.Devices.SmartCards.ISmartCardTriggerDetails";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardTriggerDetails2 =
        "Windows.Devices.SmartCards.ISmartCardTriggerDetails2";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Devices_SmartCards_ISmartCardTriggerDetails3 =
        "Windows.Devices.SmartCards.ISmartCardTriggerDetails3";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_CardAddedEventArgs =
        "Windows.Devices.SmartCards.CardAddedEventArgs";

    [NativeTypeName("const WCHAR[48]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_CardRemovedEventArgs =
        "Windows.Devices.SmartCards.CardRemovedEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_KnownSmartCardAppletIds =
        "Windows.Devices.SmartCards.KnownSmartCardAppletIds";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCard =
        "Windows.Devices.SmartCards.SmartCard";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardAppletIdGroup =
        "Windows.Devices.SmartCards.SmartCardAppletIdGroup";

    [NativeTypeName("const WCHAR[62]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardAppletIdGroupRegistration =
        "Windows.Devices.SmartCards.SmartCardAppletIdGroupRegistration";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardAutomaticResponseApdu =
        "Windows.Devices.SmartCards.SmartCardAutomaticResponseApdu";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardChallengeContext =
        "Windows.Devices.SmartCards.SmartCardChallengeContext";

    [NativeTypeName("const WCHAR[47]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardConnection =
        "Windows.Devices.SmartCards.SmartCardConnection";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramGenerator =
        "Windows.Devices.SmartCards.SmartCardCryptogramGenerator";

    [NativeTypeName("const WCHAR[92]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult =
        "Windows.Devices.SmartCards.SmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult";

    [NativeTypeName("const WCHAR[99]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult =
        "Windows.Devices.SmartCards.SmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult";

    [NativeTypeName("const WCHAR[94]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult =
        "Windows.Devices.SmartCards.SmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult";

    [NativeTypeName("const WCHAR[70]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramMaterialCharacteristics =
        "Windows.Devices.SmartCards.SmartCardCryptogramMaterialCharacteristics";

    [NativeTypeName("const WCHAR[77]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramMaterialPackageCharacteristics =
        "Windows.Devices.SmartCards.SmartCardCryptogramMaterialPackageCharacteristics";

    [NativeTypeName("const WCHAR[70]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramMaterialPossessionProof =
        "Windows.Devices.SmartCards.SmartCardCryptogramMaterialPossessionProof";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramPlacementStep =
        "Windows.Devices.SmartCards.SmartCardCryptogramPlacementStep";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramStorageKeyCharacteristics =
        "Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyCharacteristics";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardCryptogramStorageKeyInfo =
        "Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyInfo";

    [NativeTypeName("const WCHAR[45]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardEmulator =
        "Windows.Devices.SmartCards.SmartCardEmulator";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardEmulatorApduReceivedEventArgs =
        "Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs";

    [NativeTypeName("const WCHAR[75]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardEmulatorConnectionDeactivatedEventArgs =
        "Windows.Devices.SmartCards.SmartCardEmulatorConnectionDeactivatedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardEmulatorConnectionProperties =
        "Windows.Devices.SmartCards.SmartCardEmulatorConnectionProperties";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardPinPolicy =
        "Windows.Devices.SmartCards.SmartCardPinPolicy";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardPinResetDeferral =
        "Windows.Devices.SmartCards.SmartCardPinResetDeferral";

    [NativeTypeName("const WCHAR[52]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardPinResetRequest =
        "Windows.Devices.SmartCards.SmartCardPinResetRequest";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardProvisioning =
        "Windows.Devices.SmartCards.SmartCardProvisioning";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardReader =
        "Windows.Devices.SmartCards.SmartCardReader";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Devices_SmartCards_SmartCardTriggerDetails =
        "Windows.Devices.SmartCards.SmartCardTriggerDetails";

    [NativeTypeName(
        "#define WINDOWS_DEVICES_SMARTCARDS_SMARTCARDBACKGROUNDTRIGGERCONTRACT_VERSION 0x30000"
    )]
    public const int WINDOWS_DEVICES_SMARTCARDS_SMARTCARDBACKGROUNDTRIGGERCONTRACT_VERSION =
        0x30000;

    [NativeTypeName("#define WINDOWS_DEVICES_SMARTCARDS_SMARTCARDEMULATORCONTRACT_VERSION 0x60000")]
    public const int WINDOWS_DEVICES_SMARTCARDS_SMARTCARDEMULATORCONTRACT_VERSION = 0x60000;
}
