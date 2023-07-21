// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DI
{
    [NativeTypeName("#define DI_APPBANDING 0x00000001")]
    public const int DI_APPBANDING = 0x00000001;

    [NativeTypeName("#define DI_ROPS_READ_DESTINATION 0x00000002")]
    public const int DI_ROPS_READ_DESTINATION = 0x00000002;
}
