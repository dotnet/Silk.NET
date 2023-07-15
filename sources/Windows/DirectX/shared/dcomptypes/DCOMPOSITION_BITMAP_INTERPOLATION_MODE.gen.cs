// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DCOMPOSITION_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="DCOMPOSITION_BITMAP_INTERPOLATION_MODE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum DCOMPOSITION_BITMAP_INTERPOLATION_MODE
{
    /// <include file='DCOMPOSITION_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="DCOMPOSITION_BITMAP_INTERPOLATION_MODE.DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR"]/*'/>
    DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
    /// <include file='DCOMPOSITION_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="DCOMPOSITION_BITMAP_INTERPOLATION_MODE.DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR"]/*'/>
    DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR = 1,
    /// <include file='DCOMPOSITION_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="DCOMPOSITION_BITMAP_INTERPOLATION_MODE.DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT"]/*'/>
    DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT = unchecked((int)(0xffffffff)),
}