// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define SHIMGKEY_QUALITY L\"Compression\"")]
    public const string SHIMGKEY_QUALITY = "Compression";
    [NativeTypeName("#define SHIMGKEY_RAWFORMAT L\"RawDataFormat\"")]
    public const string SHIMGKEY_RAWFORMAT = "RawDataFormat";
    [NativeTypeName("#define SHIMGDEC_DEFAULT 0x00000000")]
    public const int SHIMGDEC_DEFAULT = 0x00000000;
    [NativeTypeName("#define SHIMGDEC_THUMBNAIL 0x00000001")]
    public const int SHIMGDEC_THUMBNAIL = 0x00000001;
    [NativeTypeName("#define SHIMGDEC_LOADFULL 0x00000002")]
    public const int SHIMGDEC_LOADFULL = 0x00000002;
}