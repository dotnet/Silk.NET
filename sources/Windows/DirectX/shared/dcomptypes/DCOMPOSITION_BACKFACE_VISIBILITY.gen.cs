// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum DCOMPOSITION_BACKFACE_VISIBILITY
{
    /// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY.DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE"]/*'/>
    DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE = 0,
    /// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY.DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN"]/*'/>
    DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN = 1,
    /// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY.DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT"]/*'/>
    DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT = unchecked((int)(0xffffffff)),
}