// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("dxcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT DXCoreCreateAdapterFactory(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvFactory
    );
}
