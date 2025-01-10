// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("dxgi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT CreateDXGIFactory2(
        uint Flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFactory
    );

    [DllImport("dxgi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DXGIGetDebugInterface1(
        uint Flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** pDebug
    );
}
