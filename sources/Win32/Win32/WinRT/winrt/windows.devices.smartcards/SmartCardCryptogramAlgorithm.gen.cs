// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmartCardCryptogramAlgorithm
{
    SmartCardCryptogramAlgorithm_None = 0,
    SmartCardCryptogramAlgorithm_CbcMac = 1,
    SmartCardCryptogramAlgorithm_Cvc3Umd = 2,
    SmartCardCryptogramAlgorithm_DecimalizedMsd = 3,
    SmartCardCryptogramAlgorithm_Cvc3MD = 4,
    SmartCardCryptogramAlgorithm_Sha1 = 5,
    SmartCardCryptogramAlgorithm_SignedDynamicApplicationData = 6,
    SmartCardCryptogramAlgorithm_RsaPkcs1 = 7,
    SmartCardCryptogramAlgorithm_Sha256Hmac = 8,
}
