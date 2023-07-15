// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_MEMORY_SEGMENT_GROUP.xml' path='doc/member[@name="DXGI_MEMORY_SEGMENT_GROUP"]/*'/>
public enum DXGI_MEMORY_SEGMENT_GROUP
{
    /// <include file='DXGI_MEMORY_SEGMENT_GROUP.xml' path='doc/member[@name="DXGI_MEMORY_SEGMENT_GROUP.DXGI_MEMORY_SEGMENT_GROUP_LOCAL"]/*'/>
    DXGI_MEMORY_SEGMENT_GROUP_LOCAL = 0,
    /// <include file='DXGI_MEMORY_SEGMENT_GROUP.xml' path='doc/member[@name="DXGI_MEMORY_SEGMENT_GROUP.DXGI_MEMORY_SEGMENT_GROUP_NON_LOCAL"]/*'/>
    DXGI_MEMORY_SEGMENT_GROUP_NON_LOCAL = 1,
}