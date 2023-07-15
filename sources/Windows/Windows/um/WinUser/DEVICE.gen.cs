// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DEVICE
{
    [NativeTypeName("#define DEVICE_NOTIFY_WINDOW_HANDLE 0x00000000")]
    public const int DEVICE_NOTIFY_WINDOW_HANDLE = 0x00000000;
    [NativeTypeName("#define DEVICE_NOTIFY_SERVICE_HANDLE 0x00000001")]
    public const int DEVICE_NOTIFY_SERVICE_HANDLE = 0x00000001;
    [NativeTypeName("#define DEVICE_NOTIFY_ALL_INTERFACE_CLASSES 0x00000004")]
    public const int DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 0x00000004;
}