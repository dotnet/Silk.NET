// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='INTERACTION_CONTEXT_PROPERTY.xml' path='doc/member[@name="INTERACTION_CONTEXT_PROPERTY"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum INTERACTION_CONTEXT_PROPERTY
{
    /// <include file='INTERACTION_CONTEXT_PROPERTY.xml' path='doc/member[@name="INTERACTION_CONTEXT_PROPERTY.INTERACTION_CONTEXT_PROPERTY_MEASUREMENT_UNITS"]/*'/>
    INTERACTION_CONTEXT_PROPERTY_MEASUREMENT_UNITS = 0x00000001,
    /// <include file='INTERACTION_CONTEXT_PROPERTY.xml' path='doc/member[@name="INTERACTION_CONTEXT_PROPERTY.INTERACTION_CONTEXT_PROPERTY_INTERACTION_UI_FEEDBACK"]/*'/>
    INTERACTION_CONTEXT_PROPERTY_INTERACTION_UI_FEEDBACK = 0x00000002,
    /// <include file='INTERACTION_CONTEXT_PROPERTY.xml' path='doc/member[@name="INTERACTION_CONTEXT_PROPERTY.INTERACTION_CONTEXT_PROPERTY_FILTER_POINTERS"]/*'/>
    INTERACTION_CONTEXT_PROPERTY_FILTER_POINTERS = 0x00000003,
    /// <include file='INTERACTION_CONTEXT_PROPERTY.xml' path='doc/member[@name="INTERACTION_CONTEXT_PROPERTY.INTERACTION_CONTEXT_PROPERTY_MAX"]/*'/>
    INTERACTION_CONTEXT_PROPERTY_MAX = unchecked((int)(0xffffffff)),
}