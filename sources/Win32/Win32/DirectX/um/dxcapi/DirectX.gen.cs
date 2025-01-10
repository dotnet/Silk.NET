// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("dxcompiler", ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    );

    [DllImport("dxcompiler", ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance2(
        IMalloc pMalloc,
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    );
}
