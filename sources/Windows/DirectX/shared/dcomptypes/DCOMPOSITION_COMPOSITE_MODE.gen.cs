// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum DCOMPOSITION_COMPOSITE_MODE
{
    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER"]/*'/>
    DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER = 0,
    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT"]/*'/>
    DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT = 1,
    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND"]/*'/>
    DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND = 2,
    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_INHERIT"]/*'/>
    DCOMPOSITION_COMPOSITE_MODE_INHERIT = unchecked((int)(0xffffffff)),
}