// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DeviceStreamState
{
    DeviceStreamState_Stop = 0,
    DeviceStreamState_Pause = (DeviceStreamState_Stop + 1),
    DeviceStreamState_Run = (DeviceStreamState_Pause + 1),
    DeviceStreamState_Disabled = (DeviceStreamState_Run + 1),
}
