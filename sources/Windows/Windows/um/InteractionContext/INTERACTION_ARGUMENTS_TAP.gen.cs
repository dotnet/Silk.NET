// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='INTERACTION_ARGUMENTS_TAP.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_TAP"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct INTERACTION_ARGUMENTS_TAP
{
    /// <include file='INTERACTION_ARGUMENTS_TAP.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_TAP.count"]/*'/>
    [NativeTypeName("UINT32")]
    public uint count;
}