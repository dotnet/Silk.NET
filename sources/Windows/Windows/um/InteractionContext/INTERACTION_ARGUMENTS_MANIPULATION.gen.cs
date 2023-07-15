// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='INTERACTION_ARGUMENTS_MANIPULATION.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_MANIPULATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct INTERACTION_ARGUMENTS_MANIPULATION
{
    /// <include file='INTERACTION_ARGUMENTS_MANIPULATION.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_MANIPULATION.delta"]/*'/>
    public MANIPULATION_TRANSFORM delta;
    /// <include file='INTERACTION_ARGUMENTS_MANIPULATION.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_MANIPULATION.cumulative"]/*'/>
    public MANIPULATION_TRANSFORM cumulative;
    /// <include file='INTERACTION_ARGUMENTS_MANIPULATION.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_MANIPULATION.velocity"]/*'/>
    public MANIPULATION_VELOCITY velocity;
    /// <include file='INTERACTION_ARGUMENTS_MANIPULATION.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_MANIPULATION.railsState"]/*'/>
    public MANIPULATION_RAILS_STATE railsState;
}