// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TAP_PARAMETER.xml' path='doc/member[@name="TAP_PARAMETER"]/*'/>
public enum TAP_PARAMETER
{
    /// <include file='TAP_PARAMETER.xml' path='doc/member[@name="TAP_PARAMETER.TAP_PARAMETER_MIN_CONTACT_COUNT"]/*'/>
    TAP_PARAMETER_MIN_CONTACT_COUNT = 0x00000000,
    /// <include file='TAP_PARAMETER.xml' path='doc/member[@name="TAP_PARAMETER.TAP_PARAMETER_MAX_CONTACT_COUNT"]/*'/>
    TAP_PARAMETER_MAX_CONTACT_COUNT = 0x00000001,
    /// <include file='TAP_PARAMETER.xml' path='doc/member[@name="TAP_PARAMETER.TAP_PARAMETER_MAX"]/*'/>
    TAP_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}