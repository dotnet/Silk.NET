// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BinaryStringEncoding
{
    BinaryStringEncoding_Utf8 = 0,
    BinaryStringEncoding_Utf16LE = 1,
    BinaryStringEncoding_Utf16BE = 2,
}
