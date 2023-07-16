// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags"]/*'/>
public enum VMRSurfaceAllocationFlags
{
    /// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags.AMAP_PIXELFORMAT_VALID"]/*'/>
    AMAP_PIXELFORMAT_VALID = 0x1,
    /// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags.AMAP_3D_TARGET"]/*'/>
    AMAP_3D_TARGET = 0x2,
    /// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags.AMAP_ALLOW_SYSMEM"]/*'/>
    AMAP_ALLOW_SYSMEM = 0x4,
    /// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags.AMAP_FORCE_SYSMEM"]/*'/>
    AMAP_FORCE_SYSMEM = 0x8,
    /// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags.AMAP_DIRECTED_FLIP"]/*'/>
    AMAP_DIRECTED_FLIP = 0x10,
    /// <include file='VMRSurfaceAllocationFlags.xml' path='doc/member[@name="VMRSurfaceAllocationFlags.AMAP_DXVA_TARGET"]/*'/>
    AMAP_DXVA_TARGET = 0x20,
}