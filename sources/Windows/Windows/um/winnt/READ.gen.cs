// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class READ
{
    [NativeTypeName("#define READ_CONTROL (0x00020000L)")]
    public const int READ_CONTROL = (0x00020000);
    [NativeTypeName("#define READ_THREAD_PROFILING_FLAG_DISPATCHING 0x00000001")]
    public const int READ_THREAD_PROFILING_FLAG_DISPATCHING = 0x00000001;
    [NativeTypeName("#define READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS 0x00000002")]
    public const int READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS = 0x00000002;
}