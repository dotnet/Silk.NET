// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SDL;

public partial struct GamepadHandle
{
    private unsafe GamepadHandle(void* handle) => Handle = handle;

    // conversion from void ptr
    public static unsafe explicit operator GamepadHandle (void* handle) => new GamepadHandle(handle);
}

public partial struct JoystickHandle
{
    private unsafe JoystickHandle(void* handle) => Handle = handle;

    // conversion from void ptr
    public static unsafe explicit operator JoystickHandle (void* handle) => new JoystickHandle(handle);
}

public partial struct SensorHandle
{
    private unsafe SensorHandle(void* handle) => Handle = handle;

    // conversion from void ptr
    public static unsafe explicit operator SensorHandle (void* handle) => new SensorHandle(handle);
}

public partial struct HidDeviceHandle
{
    private unsafe HidDeviceHandle(void* handle) => Handle = handle;

    // conversion from void ptr
    public static unsafe explicit operator HidDeviceHandle (void* handle) => new HidDeviceHandle(handle);
}
