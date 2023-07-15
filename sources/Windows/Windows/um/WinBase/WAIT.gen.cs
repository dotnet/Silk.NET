// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WAIT
{
    [NativeTypeName("#define WAIT_FAILED ((DWORD)0xFFFFFFFF)")]
    public const uint WAIT_FAILED = ((uint)(0xFFFFFFFF));
    [NativeTypeName("#define WAIT_OBJECT_0 ((STATUS_WAIT_0 ) + 0 )")]
    public const uint WAIT_OBJECT_0 = ((((uint)(0x00000000))) + 0);
    [NativeTypeName("#define WAIT_ABANDONED ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
    public const uint WAIT_ABANDONED = ((((uint)(0x00000080))) + 0);
    [NativeTypeName("#define WAIT_ABANDONED_0 ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
    public const uint WAIT_ABANDONED_0 = ((((uint)(0x00000080))) + 0);
    [NativeTypeName("#define WAIT_IO_COMPLETION STATUS_USER_APC")]
    public const uint WAIT_IO_COMPLETION = ((uint)(0x000000C0));
}