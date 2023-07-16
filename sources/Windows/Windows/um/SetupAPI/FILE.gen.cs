// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FILE
{
    [NativeTypeName("#define FILE_COMPRESSION_NONE 0")]
    public const int FILE_COMPRESSION_NONE = 0;
    [NativeTypeName("#define FILE_COMPRESSION_WINLZA 1")]
    public const int FILE_COMPRESSION_WINLZA = 1;
    [NativeTypeName("#define FILE_COMPRESSION_MSZIP 2")]
    public const int FILE_COMPRESSION_MSZIP = 2;
    [NativeTypeName("#define FILE_COMPRESSION_NTCAB 3")]
    public const int FILE_COMPRESSION_NTCAB = 3;
}