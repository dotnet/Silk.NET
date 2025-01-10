// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmartCardCryptogramGeneratorOperationStatus
{
    SmartCardCryptogramGeneratorOperationStatus_Success = 0,
    SmartCardCryptogramGeneratorOperationStatus_AuthorizationFailed = 1,
    SmartCardCryptogramGeneratorOperationStatus_AuthorizationCanceled = 2,
    SmartCardCryptogramGeneratorOperationStatus_AuthorizationRequired = 3,
    SmartCardCryptogramGeneratorOperationStatus_CryptogramMaterialPackageStorageKeyExists = 4,
    SmartCardCryptogramGeneratorOperationStatus_NoCryptogramMaterialPackageStorageKey = 5,
    SmartCardCryptogramGeneratorOperationStatus_NoCryptogramMaterialPackage = 6,
    SmartCardCryptogramGeneratorOperationStatus_UnsupportedCryptogramMaterialPackage = 7,
    SmartCardCryptogramGeneratorOperationStatus_UnknownCryptogramMaterialName = 8,
    SmartCardCryptogramGeneratorOperationStatus_InvalidCryptogramMaterialUsage = 9,
    SmartCardCryptogramGeneratorOperationStatus_ApduResponseNotSent = 10,
    SmartCardCryptogramGeneratorOperationStatus_OtherError = 11,
    SmartCardCryptogramGeneratorOperationStatus_ValidationFailed = 12,
    SmartCardCryptogramGeneratorOperationStatus_NotSupported = 13,
}
