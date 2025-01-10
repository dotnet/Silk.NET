// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DIDEVICEIMAGEINFOHEADERW
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwSizeImageInfo;

    [NativeTypeName("DWORD")]
    public uint dwcViews;

    [NativeTypeName("DWORD")]
    public uint dwcButtons;

    [NativeTypeName("DWORD")]
    public uint dwcAxes;

    [NativeTypeName("DWORD")]
    public uint dwcPOVs;

    [NativeTypeName("DWORD")]
    public uint dwBufferSize;

    [NativeTypeName("DWORD")]
    public uint dwBufferUsed;

    [NativeTypeName("LPDIDEVICEIMAGEINFOW")]
    public DIDEVICEIMAGEINFOW* lprgImageInfoArray;
}
