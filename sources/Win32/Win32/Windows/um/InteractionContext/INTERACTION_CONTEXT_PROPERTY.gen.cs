// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum INTERACTION_CONTEXT_PROPERTY
{
    INTERACTION_CONTEXT_PROPERTY_MEASUREMENT_UNITS = 0x00000001,
    INTERACTION_CONTEXT_PROPERTY_INTERACTION_UI_FEEDBACK = 0x00000002,
    INTERACTION_CONTEXT_PROPERTY_FILTER_POINTERS = 0x00000003,
    INTERACTION_CONTEXT_PROPERTY_MAX = unchecked((int)(0xffffffff)),
}
