// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_INFO
{
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint pointerType;

    [NativeTypeName("UINT32")]
    public uint pointerId;

    [NativeTypeName("UINT32")]
    public uint frameId;

    [NativeTypeName("POINTER_FLAGS")]
    public uint pointerFlags;
    public HANDLE sourceDevice;
    public HWND hwndTarget;
    public POINT ptPixelLocation;
    public POINT ptHimetricLocation;
    public POINT ptPixelLocationRaw;
    public POINT ptHimetricLocationRaw;

    [NativeTypeName("DWORD")]
    public uint dwTime;

    [NativeTypeName("UINT32")]
    public uint historyCount;

    [NativeTypeName("INT32")]
    public int InputData;

    [NativeTypeName("DWORD")]
    public uint dwKeyStates;

    [NativeTypeName("UINT64")]
    public ulong PerformanceCount;
    public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
}
