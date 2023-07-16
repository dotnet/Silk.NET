// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY"]/*'/>
public enum D3D12_MESSAGE_SEVERITY
{
    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_CORRUPTION"]/*'/>
    D3D12_MESSAGE_SEVERITY_CORRUPTION = 0,
    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_ERROR"]/*'/>
    D3D12_MESSAGE_SEVERITY_ERROR = (D3D12_MESSAGE_SEVERITY_CORRUPTION + 1),
    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_WARNING"]/*'/>
    D3D12_MESSAGE_SEVERITY_WARNING = (D3D12_MESSAGE_SEVERITY_ERROR + 1),
    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_INFO"]/*'/>
    D3D12_MESSAGE_SEVERITY_INFO = (D3D12_MESSAGE_SEVERITY_WARNING + 1),
    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_MESSAGE"]/*'/>
    D3D12_MESSAGE_SEVERITY_MESSAGE = (D3D12_MESSAGE_SEVERITY_INFO + 1),
}