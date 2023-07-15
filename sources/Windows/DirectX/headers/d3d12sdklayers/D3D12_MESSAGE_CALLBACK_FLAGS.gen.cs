// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_MESSAGE_CALLBACK_FLAGS.xml' path='doc/member[@name="D3D12_MESSAGE_CALLBACK_FLAGS"]/*'/>
[Flags]
public enum D3D12_MESSAGE_CALLBACK_FLAGS
{
    /// <include file='D3D12_MESSAGE_CALLBACK_FLAGS.xml' path='doc/member[@name="D3D12_MESSAGE_CALLBACK_FLAGS.D3D12_MESSAGE_CALLBACK_FLAG_NONE"]/*'/>
    D3D12_MESSAGE_CALLBACK_FLAG_NONE = 0,
    /// <include file='D3D12_MESSAGE_CALLBACK_FLAGS.xml' path='doc/member[@name="D3D12_MESSAGE_CALLBACK_FLAGS.D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS"]/*'/>
    D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS = 0x1,
}