// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING"]/*'/>
public enum DXGI_SCALING
{
    /// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING.DXGI_SCALING_STRETCH"]/*'/>
    DXGI_SCALING_STRETCH = 0,
    /// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING.DXGI_SCALING_NONE"]/*'/>
    DXGI_SCALING_NONE = 1,
    /// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING.DXGI_SCALING_ASPECT_RATIO_STRETCH"]/*'/>
    DXGI_SCALING_ASPECT_RATIO_STRETCH = 2,
}