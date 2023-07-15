// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_AMRESCTL_RESERVEFLAGS.xml' path='doc/member[@name="_AMRESCTL_RESERVEFLAGS"]/*'/>
public enum _AMRESCTL_RESERVEFLAGS
{
    /// <include file='_AMRESCTL_RESERVEFLAGS.xml' path='doc/member[@name="_AMRESCTL_RESERVEFLAGS.AMRESCTL_RESERVEFLAGS_RESERVE"]/*'/>
    AMRESCTL_RESERVEFLAGS_RESERVE = 0,
    /// <include file='_AMRESCTL_RESERVEFLAGS.xml' path='doc/member[@name="_AMRESCTL_RESERVEFLAGS.AMRESCTL_RESERVEFLAGS_UNRESERVE"]/*'/>
    AMRESCTL_RESERVEFLAGS_UNRESERVE = 0x1,
}