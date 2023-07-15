// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CROSS_SLIDE_PARAMETER.xml' path='doc/member[@name="CROSS_SLIDE_PARAMETER"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct CROSS_SLIDE_PARAMETER
{
    /// <include file='CROSS_SLIDE_PARAMETER.xml' path='doc/member[@name="CROSS_SLIDE_PARAMETER.threshold"]/*'/>
    public CROSS_SLIDE_THRESHOLD threshold;
    /// <include file='CROSS_SLIDE_PARAMETER.xml' path='doc/member[@name="CROSS_SLIDE_PARAMETER.distance"]/*'/>
    public float distance;
}