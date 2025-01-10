// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmartCardReaderKind
{
    SmartCardReaderKind_Any = 0,
    SmartCardReaderKind_Generic = 1,
    SmartCardReaderKind_Tpm = 2,
    SmartCardReaderKind_Nfc = 3,
    SmartCardReaderKind_Uicc = 4,
    SmartCardReaderKind_EmbeddedSE = 5,
}
