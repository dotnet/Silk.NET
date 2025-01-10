// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct Direct3DSurfaceDescription
{
    [NativeTypeName("INT32")]
    public int Width;

    [NativeTypeName("INT32")]
    public int Height;

    [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
    public DirectXPixelFormat Format;

    [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::Direct3DMultisampleDescription")]
    public Direct3DMultisampleDescription MultisampleDescription;
}
