// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_MESSAGE_SEVERITY
{
    D3D12_MESSAGE_SEVERITY_CORRUPTION = 0,
    D3D12_MESSAGE_SEVERITY_ERROR = (D3D12_MESSAGE_SEVERITY_CORRUPTION + 1),
    D3D12_MESSAGE_SEVERITY_WARNING = (D3D12_MESSAGE_SEVERITY_ERROR + 1),
    D3D12_MESSAGE_SEVERITY_INFO = (D3D12_MESSAGE_SEVERITY_WARNING + 1),
    D3D12_MESSAGE_SEVERITY_MESSAGE = (D3D12_MESSAGE_SEVERITY_INFO + 1),
}
