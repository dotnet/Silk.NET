// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class KEY
{
    [NativeTypeName("#define KEY_QUERY_VALUE (0x0001)")]
    public const int KEY_QUERY_VALUE = (0x0001);
    [NativeTypeName("#define KEY_SET_VALUE (0x0002)")]
    public const int KEY_SET_VALUE = (0x0002);
    [NativeTypeName("#define KEY_CREATE_SUB_KEY (0x0004)")]
    public const int KEY_CREATE_SUB_KEY = (0x0004);
    [NativeTypeName("#define KEY_ENUMERATE_SUB_KEYS (0x0008)")]
    public const int KEY_ENUMERATE_SUB_KEYS = (0x0008);
    [NativeTypeName("#define KEY_NOTIFY (0x0010)")]
    public const int KEY_NOTIFY = (0x0010);
    [NativeTypeName("#define KEY_CREATE_LINK (0x0020)")]
    public const int KEY_CREATE_LINK = (0x0020);
    [NativeTypeName("#define KEY_WOW64_32KEY (0x0200)")]
    public const int KEY_WOW64_32KEY = (0x0200);
    [NativeTypeName("#define KEY_WOW64_64KEY (0x0100)")]
    public const int KEY_WOW64_64KEY = (0x0100);
    [NativeTypeName("#define KEY_WOW64_RES (0x0300)")]
    public const int KEY_WOW64_RES = (0x0300);
    [NativeTypeName("#define KEY_READ ((STANDARD_RIGHTS_READ       |\\\r\n                                  KEY_QUERY_VALUE            |\\\r\n                                  KEY_ENUMERATE_SUB_KEYS     |\\\r\n                                  KEY_NOTIFY)                 \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
    public const int KEY_READ = ((((0x00020000)) | (0x0001) | (0x0008) | (0x0010)) & (~(0x00100000)));
    [NativeTypeName("#define KEY_WRITE ((STANDARD_RIGHTS_WRITE      |\\\r\n                                  KEY_SET_VALUE              |\\\r\n                                  KEY_CREATE_SUB_KEY)         \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
    public const int KEY_WRITE = ((((0x00020000)) | (0x0002) | (0x0004)) & (~(0x00100000)));
    [NativeTypeName("#define KEY_EXECUTE ((KEY_READ)                   \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
    public const int KEY_EXECUTE = ((((((0x00020000)) | (0x0001) | (0x0008) | (0x0010)) & (~(0x00100000)))) & (~(0x00100000)));
    [NativeTypeName("#define KEY_ALL_ACCESS ((STANDARD_RIGHTS_ALL        |\\\r\n                                  KEY_QUERY_VALUE            |\\\r\n                                  KEY_SET_VALUE              |\\\r\n                                  KEY_CREATE_SUB_KEY         |\\\r\n                                  KEY_ENUMERATE_SUB_KEYS     |\\\r\n                                  KEY_NOTIFY                 |\\\r\n                                  KEY_CREATE_LINK)            \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
    public const int KEY_ALL_ACCESS = (((0x001F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020)) & (~(0x00100000)));
}