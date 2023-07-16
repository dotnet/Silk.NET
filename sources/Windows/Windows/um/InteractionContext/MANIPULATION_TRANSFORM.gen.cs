// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MANIPULATION_TRANSFORM.xml' path='doc/member[@name="MANIPULATION_TRANSFORM"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct MANIPULATION_TRANSFORM
{
    /// <include file='MANIPULATION_TRANSFORM.xml' path='doc/member[@name="MANIPULATION_TRANSFORM.translationX"]/*'/>
    public float translationX;
    /// <include file='MANIPULATION_TRANSFORM.xml' path='doc/member[@name="MANIPULATION_TRANSFORM.translationY"]/*'/>
    public float translationY;
    /// <include file='MANIPULATION_TRANSFORM.xml' path='doc/member[@name="MANIPULATION_TRANSFORM.scale"]/*'/>
    public float scale;
    /// <include file='MANIPULATION_TRANSFORM.xml' path='doc/member[@name="MANIPULATION_TRANSFORM.expansion"]/*'/>
    public float expansion;
    /// <include file='MANIPULATION_TRANSFORM.xml' path='doc/member[@name="MANIPULATION_TRANSFORM.rotation"]/*'/>
    public float rotation;
}