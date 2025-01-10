// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum msidbFileAttributes
{
    msidbFileAttributesReadOnly = 0x00000001,
    msidbFileAttributesHidden = 0x00000002,
    msidbFileAttributesSystem = 0x00000004,
    msidbFileAttributesReserved0 = 0x00000008,
    msidbFileAttributesIsolatedComp = 0x00000010,
    msidbFileAttributesReserved1 = 0x00000040,
    msidbFileAttributesReserved2 = 0x00000080,
    msidbFileAttributesReserved3 = 0x00000100,
    msidbFileAttributesVital = 0x00000200,
    msidbFileAttributesChecksum = 0x00000400,
    msidbFileAttributesPatchAdded = 0x00001000,
    msidbFileAttributesNoncompressed = 0x00002000,
    msidbFileAttributesCompressed = 0x00004000,
    msidbFileAttributesReserved4 = 0x00008000,
}
