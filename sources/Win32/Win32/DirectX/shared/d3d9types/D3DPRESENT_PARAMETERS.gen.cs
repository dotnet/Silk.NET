// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DPRESENT_PARAMETERS
{
    public uint BackBufferWidth;
    public uint BackBufferHeight;
    public D3DFORMAT BackBufferFormat;
    public uint BackBufferCount;
    public D3DMULTISAMPLE_TYPE MultiSampleType;

    [NativeTypeName("DWORD")]
    public uint MultiSampleQuality;
    public D3DSWAPEFFECT SwapEffect;
    public HWND hDeviceWindow;
    public BOOL Windowed;
    public BOOL EnableAutoDepthStencil;
    public D3DFORMAT AutoDepthStencilFormat;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public uint FullScreen_RefreshRateInHz;
    public uint PresentationInterval;
}
