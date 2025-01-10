// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WICPersistOptions
{
    WICPersistOptionDefault = 0,
    WICPersistOptionLittleEndian = 0,
    WICPersistOptionBigEndian = 0x1,
    WICPersistOptionStrictFormat = 0x2,
    WICPersistOptionNoCacheStream = 0x4,
    WICPersistOptionPreferUTF8 = 0x8,
    WICPersistOptionMask = 0xffff,
}
