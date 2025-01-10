// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum tagOPEN_AS_INFO_FLAGS
{
    OAIF_ALLOW_REGISTRATION = 0x00000001,
    OAIF_REGISTER_EXT = 0x00000002,
    OAIF_EXEC = 0x00000004,
    OAIF_FORCE_REGISTRATION = 0x00000008,
    OAIF_HIDE_REGISTRATION = 0x00000020,
    OAIF_URL_PROTOCOL = 0x00000040,
    OAIF_FILE_IS_URI = 0x00000080,
}
