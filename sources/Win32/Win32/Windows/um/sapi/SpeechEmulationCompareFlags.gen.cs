// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechEmulationCompareFlags
{
    SECFIgnoreCase = 0x1,
    SECFIgnoreKanaType = 0x10000,
    SECFIgnoreWidth = 0x20000,
    SECFNoSpecialChars = 0x20000000,
    SECFEmulateResult = 0x40000000,
    SECFDefault = ((SECFIgnoreCase | SECFIgnoreKanaType) | SECFIgnoreWidth),
}
