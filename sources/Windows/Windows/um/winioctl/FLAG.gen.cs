// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FLAG
{
    [NativeTypeName("#define FLAG_USN_TRACK_MODIFIED_RANGES_ENABLE 0x00000001")]
    public const int FLAG_USN_TRACK_MODIFIED_RANGES_ENABLE = 0x00000001;
}