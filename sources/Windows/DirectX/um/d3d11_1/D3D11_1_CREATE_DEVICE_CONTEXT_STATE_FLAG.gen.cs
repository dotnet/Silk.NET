// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG.xml' path='doc/member[@name="D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG"]/*'/>
[Flags]
public enum D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG
{
    /// <include file='D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG.xml' path='doc/member[@name="D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG.D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED"]/*'/>
    D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED = 0x1,
}