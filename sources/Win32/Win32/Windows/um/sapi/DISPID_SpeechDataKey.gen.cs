// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechDataKey
{
    DISPID_SDKSetBinaryValue = 1,
    DISPID_SDKGetBinaryValue = (DISPID_SDKSetBinaryValue + 1),
    DISPID_SDKSetStringValue = (DISPID_SDKGetBinaryValue + 1),
    DISPID_SDKGetStringValue = (DISPID_SDKSetStringValue + 1),
    DISPID_SDKSetLongValue = (DISPID_SDKGetStringValue + 1),
    DISPID_SDKGetlongValue = (DISPID_SDKSetLongValue + 1),
    DISPID_SDKOpenKey = (DISPID_SDKGetlongValue + 1),
    DISPID_SDKCreateKey = (DISPID_SDKOpenKey + 1),
    DISPID_SDKDeleteKey = (DISPID_SDKCreateKey + 1),
    DISPID_SDKDeleteValue = (DISPID_SDKDeleteKey + 1),
    DISPID_SDKEnumKeys = (DISPID_SDKDeleteValue + 1),
    DISPID_SDKEnumValues = (DISPID_SDKEnumKeys + 1),
}
