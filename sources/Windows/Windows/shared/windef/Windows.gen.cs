// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define HFILE_ERROR ((HFILE)-1)")]
    public const int HFILE_ERROR = ((int)(-1));
    [NativeTypeName("#define APP_LOCAL_DEVICE_ID_SIZE 32")]
    public const int APP_LOCAL_DEVICE_ID_SIZE = 32;
}