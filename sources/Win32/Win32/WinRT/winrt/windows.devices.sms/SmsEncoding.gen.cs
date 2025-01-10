// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmsEncoding
{
    SmsEncoding_Unknown = 0,
    SmsEncoding_Optimal = 1,
    SmsEncoding_SevenBitAscii = 2,
    SmsEncoding_Unicode = 3,
    SmsEncoding_GsmSevenBit = 4,
    SmsEncoding_EightBit = 5,
    SmsEncoding_Latin = 6,
    SmsEncoding_Korean = 7,
    SmsEncoding_IA5 = 8,
    SmsEncoding_ShiftJis = 9,
    SmsEncoding_LatinHebrew = 10,
}
