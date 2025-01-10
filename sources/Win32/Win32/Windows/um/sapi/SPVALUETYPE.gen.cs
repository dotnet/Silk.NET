// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPVALUETYPE
{
    SPDF_PROPERTY = 0x1,
    SPDF_REPLACEMENT = 0x2,
    SPDF_RULE = 0x4,
    SPDF_DISPLAYTEXT = 0x8,
    SPDF_LEXICALFORM = 0x10,
    SPDF_PRONUNCIATION = 0x20,
    SPDF_AUDIO = 0x40,
    SPDF_ALTERNATES = 0x80,
    SPDF_ALL = 0xff,
}
