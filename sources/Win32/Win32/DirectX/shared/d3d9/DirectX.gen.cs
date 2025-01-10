// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d3d9", ExactSpelling = true)]
    public static extern IDirect3D9 Direct3DCreate9(uint SDKVersion);

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern int D3DPERF_BeginEvent(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] ushort* wszName
    );

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern int D3DPERF_EndEvent();

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern void D3DPERF_SetMarker(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] ushort* wszName
    );

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern void D3DPERF_SetRegion(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] ushort* wszName
    );

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern BOOL D3DPERF_QueryRepeatFrame();

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern void D3DPERF_SetOptions([NativeTypeName("DWORD")] uint dwOptions);

    [DllImport("d3d9", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint D3DPERF_GetStatus();

    [DllImport("d3d9", ExactSpelling = true)]
    public static extern HRESULT Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex* param1);

    [NativeTypeName("#define DIRECT3D_VERSION 0x0900")]
    public const int DIRECT3D_VERSION = 0x0900;

    [NativeTypeName("#define D3D9b_SDK_VERSION 31")]
    public const int D3D9b_SDK_VERSION = 31;

    [NativeTypeName("#define D3DSPD_IUNKNOWN 0x00000001L")]
    public const int D3DSPD_IUNKNOWN = 0x00000001;

    [NativeTypeName("#define D3DADAPTER_DEFAULT 0")]
    public const int D3DADAPTER_DEFAULT = 0;

    [NativeTypeName("#define _FACD3D 0x876")]
    public const int _FACD3D = 0x876;
}
