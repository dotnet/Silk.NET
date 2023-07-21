// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE"]/*' />
public enum D3D12_WRITEBUFFERIMMEDIATE_MODE
{
    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE.D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT"]/*' />
    D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT = 0,

    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE.D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN"]/*' />
    D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN = 0x1,

    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE.D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT"]/*' />
    D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT = 0x2,
}
