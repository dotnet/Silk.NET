// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE"]/*'/>
public enum DXGI_GPU_PREFERENCE
{
    /// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_UNSPECIFIED"]/*'/>
    DXGI_GPU_PREFERENCE_UNSPECIFIED = 0,
    /// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_MINIMUM_POWER"]/*'/>
    DXGI_GPU_PREFERENCE_MINIMUM_POWER = (DXGI_GPU_PREFERENCE_UNSPECIFIED + 1),
    /// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE"]/*'/>
    DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE = (DXGI_GPU_PREFERENCE_MINIMUM_POWER + 1),
}