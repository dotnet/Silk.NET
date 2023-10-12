﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_COUNTER_INFO.xml' path='doc/member[@name="D3D11_COUNTER_INFO"]/*' />
public partial struct D3D11_COUNTER_INFO
{
    /// <include file='D3D11_COUNTER_INFO.xml' path='doc/member[@name="D3D11_COUNTER_INFO.LastDeviceDependentCounter"]/*' />
    public D3D11_COUNTER LastDeviceDependentCounter;

    /// <include file='D3D11_COUNTER_INFO.xml' path='doc/member[@name="D3D11_COUNTER_INFO.NumSimultaneousCounters"]/*' />
    public uint NumSimultaneousCounters;

    /// <include file='D3D11_COUNTER_INFO.xml' path='doc/member[@name="D3D11_COUNTER_INFO.NumDetectableParallelUnits"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumDetectableParallelUnits;
}