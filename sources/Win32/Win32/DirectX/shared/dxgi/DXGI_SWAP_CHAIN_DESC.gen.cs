// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_SWAP_CHAIN_DESC
{
    public DXGI_MODE_DESC BufferDesc;
    public DXGI_SAMPLE_DESC SampleDesc;

    [NativeTypeName("DXGI_USAGE")]
    public uint BufferUsage;
    public uint BufferCount;
    public HWND OutputWindow;
    public BOOL Windowed;
    public DXGI_SWAP_EFFECT SwapEffect;
    public uint Flags;
}
