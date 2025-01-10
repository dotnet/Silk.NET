// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum Direct3DBindings : uint
{
    Direct3DBindings_VertexBuffer = 0x1,
    Direct3DBindings_IndexBuffer = 0x2,
    Direct3DBindings_ConstantBuffer = 0x4,
    Direct3DBindings_ShaderResource = 0x8,
    Direct3DBindings_StreamOutput = 0x10,
    Direct3DBindings_RenderTarget = 0x20,
    Direct3DBindings_DepthStencil = 0x40,
    Direct3DBindings_UnorderedAccess = 0x80,
    Direct3DBindings_Decoder = 0x200,
    Direct3DBindings_VideoEncoder = 0x400,
}
