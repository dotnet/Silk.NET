// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmartCardCryptographicKeyAttestationStatus
{
    SmartCardCryptographicKeyAttestationStatus_NoAttestation = 0,
    SmartCardCryptographicKeyAttestationStatus_SoftwareKeyWithoutTpm = 1,
    SmartCardCryptographicKeyAttestationStatus_SoftwareKeyWithTpm = 2,
    SmartCardCryptographicKeyAttestationStatus_TpmKeyUnknownAttestationStatus = 3,
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithoutAttestationCapability = 4,
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithTemporaryAttestationFailure = 5,
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithLongTermAttestationFailure = 6,
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithAttestation = 7,
}
