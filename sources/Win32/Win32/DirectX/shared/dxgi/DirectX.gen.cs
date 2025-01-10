// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("dxgi", ExactSpelling = true)]
    public static extern HRESULT CreateDXGIFactory(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFactory
    );

    [DllImport("dxgi", ExactSpelling = true)]
    public static extern HRESULT CreateDXGIFactory1(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFactory
    );
}
