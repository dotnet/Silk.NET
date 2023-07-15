// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='TKBLayoutType.xml' path='doc/member[@name="TKBLayoutType"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum TKBLayoutType
{
    /// <include file='TKBLayoutType.xml' path='doc/member[@name="TKBLayoutType.TKBLT_UNDEFINED"]/*'/>
    TKBLT_UNDEFINED = 0,
    /// <include file='TKBLayoutType.xml' path='doc/member[@name="TKBLayoutType.TKBLT_CLASSIC"]/*'/>
    TKBLT_CLASSIC = 1,
    /// <include file='TKBLayoutType.xml' path='doc/member[@name="TKBLayoutType.TKBLT_OPTIMIZED"]/*'/>
    TKBLT_OPTIMIZED = 2,
}