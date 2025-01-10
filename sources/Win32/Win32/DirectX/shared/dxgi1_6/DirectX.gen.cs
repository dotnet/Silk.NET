// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    [DllImport("dxgi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern HRESULT DXGIDeclareAdapterRemovalSupport();

    [DllImport("dxgi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT DXGIDisableVBlankVirtualization();
}
