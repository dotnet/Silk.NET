// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MAXIMUM
{
    [NativeTypeName("#define MAXIMUM_WAIT_OBJECTS 64")]
    public const int MAXIMUM_WAIT_OBJECTS = 64;
    [NativeTypeName("#define MAXIMUM_SUSPEND_COUNT MAXCHAR")]
    public const int MAXIMUM_SUSPEND_COUNT = 0x7f;
    [NativeTypeName("#define MAXIMUM_ALLOWED (0x02000000L)")]
    public const int MAXIMUM_ALLOWED = (0x02000000);
    [NativeTypeName("#define MAXIMUM_XSTATE_FEATURES (64)")]
    public const int MAXIMUM_XSTATE_FEATURES = (64);
    [NativeTypeName("#define MAXIMUM_REPARSE_DATA_BUFFER_SIZE ( 16 * 1024 )")]
    public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = (16 * 1024);
}