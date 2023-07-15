// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_DEBUG_RLO_FLAGS.xml' path='doc/member[@name="DXGI_DEBUG_RLO_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DXGI_DEBUG_RLO_FLAGS
{
    /// <include file='DXGI_DEBUG_RLO_FLAGS.xml' path='doc/member[@name="DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_SUMMARY"]/*'/>
    DXGI_DEBUG_RLO_SUMMARY = 0x1,
    /// <include file='DXGI_DEBUG_RLO_FLAGS.xml' path='doc/member[@name="DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_DETAIL"]/*'/>
    DXGI_DEBUG_RLO_DETAIL = 0x2,
    /// <include file='DXGI_DEBUG_RLO_FLAGS.xml' path='doc/member[@name="DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_IGNORE_INTERNAL"]/*'/>
    DXGI_DEBUG_RLO_IGNORE_INTERNAL = 0x4,
    /// <include file='DXGI_DEBUG_RLO_FLAGS.xml' path='doc/member[@name="DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL"]/*'/>
    DXGI_DEBUG_RLO_ALL = 0x7,
}