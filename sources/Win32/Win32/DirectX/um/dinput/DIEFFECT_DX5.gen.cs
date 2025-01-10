// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DIEFFECT_DX5
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwDuration;

    [NativeTypeName("DWORD")]
    public uint dwSamplePeriod;

    [NativeTypeName("DWORD")]
    public uint dwGain;

    [NativeTypeName("DWORD")]
    public uint dwTriggerButton;

    [NativeTypeName("DWORD")]
    public uint dwTriggerRepeatInterval;

    [NativeTypeName("DWORD")]
    public uint cAxes;

    [NativeTypeName("LPDWORD")]
    public uint* rgdwAxes;

    [NativeTypeName("LPLONG")]
    public int* rglDirection;

    [NativeTypeName("LPDIENVELOPE")]
    public DIENVELOPE* lpEnvelope;

    [NativeTypeName("DWORD")]
    public uint cbTypeSpecificParams;

    [NativeTypeName("LPVOID")]
    public void* lpvTypeSpecificParams;
}
