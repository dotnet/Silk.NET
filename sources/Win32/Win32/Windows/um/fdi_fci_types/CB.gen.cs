// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi_fci_types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CB
{
    [NativeTypeName("#define CB_MAX_CHUNK 32768U")]
    public const uint CB_MAX_CHUNK = 32768U;

    [NativeTypeName("#define CB_MAX_DISK 0x7fffffffL")]
    public const int CB_MAX_DISK = 0x7fffffff;

    [NativeTypeName("#define CB_MAX_FILENAME 256")]
    public const int CB_MAX_FILENAME = 256;

    [NativeTypeName("#define CB_MAX_CABINET_NAME 256")]
    public const int CB_MAX_CABINET_NAME = 256;

    [NativeTypeName("#define CB_MAX_CAB_PATH 256")]
    public const int CB_MAX_CAB_PATH = 256;

    [NativeTypeName("#define CB_MAX_DISK_NAME 256")]
    public const int CB_MAX_DISK_NAME = 256;
}
