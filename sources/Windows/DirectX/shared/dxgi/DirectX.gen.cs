// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateDXGIFactory"]/*'/>
    [DllImport("dxgi", ExactSpelling = true)]
    public static extern HRESULT CreateDXGIFactory([NativeTypeName("const IID &")] Guid* riid, void** ppFactory);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateDXGIFactory1"]/*'/>
    [DllImport("dxgi", ExactSpelling = true)]
    public static extern HRESULT CreateDXGIFactory1([NativeTypeName("const IID &")] Guid* riid, void** ppFactory);
}