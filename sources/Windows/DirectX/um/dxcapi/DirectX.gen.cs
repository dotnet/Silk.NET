// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DxcCreateInstance"]/*' />
    [DllImport("dxcompiler", ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DxcCreateInstance2"]/*' />
    [DllImport("dxcompiler", ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance2(IMalloc* pMalloc, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
}
