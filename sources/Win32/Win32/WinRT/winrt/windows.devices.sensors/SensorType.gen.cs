// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SensorType
{
    SensorType_Accelerometer = 0,
    SensorType_ActivitySensor = 1,
    SensorType_Barometer = 2,
    SensorType_Compass = 3,
    SensorType_CustomSensor = 4,
    SensorType_Gyroscope = 5,
    SensorType_ProximitySensor = 6,
    SensorType_Inclinometer = 7,
    SensorType_LightSensor = 8,
    SensorType_OrientationSensor = 9,
    SensorType_Pedometer = 10,
    SensorType_RelativeInclinometer = 11,
    SensorType_RelativeOrientationSensor = 12,
    SensorType_SimpleOrientationSensor = 13,
}
