// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS"]/*'/>
public enum DXGI_RECLAIM_RESOURCE_RESULTS
{
    /// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS.DXGI_RECLAIM_RESOURCE_RESULT_OK"]/*'/>
    DXGI_RECLAIM_RESOURCE_RESULT_OK = 0,
    /// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS.DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED"]/*'/>
    DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED = 1,
    /// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS.DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED"]/*'/>
    DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED = 2,
}