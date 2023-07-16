// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CREATE
{
    [NativeTypeName("#define CREATE_MUTEX_INITIAL_OWNER 0x00000001")]
    public const int CREATE_MUTEX_INITIAL_OWNER = 0x00000001;
    [NativeTypeName("#define CREATE_EVENT_MANUAL_RESET 0x00000001")]
    public const int CREATE_EVENT_MANUAL_RESET = 0x00000001;
    [NativeTypeName("#define CREATE_EVENT_INITIAL_SET 0x00000002")]
    public const int CREATE_EVENT_INITIAL_SET = 0x00000002;
    [NativeTypeName("#define CREATE_WAITABLE_TIMER_MANUAL_RESET 0x00000001")]
    public const int CREATE_WAITABLE_TIMER_MANUAL_RESET = 0x00000001;
    [NativeTypeName("#define CREATE_WAITABLE_TIMER_HIGH_RESOLUTION 0x00000002")]
    public const int CREATE_WAITABLE_TIMER_HIGH_RESOLUTION = 0x00000002;
}