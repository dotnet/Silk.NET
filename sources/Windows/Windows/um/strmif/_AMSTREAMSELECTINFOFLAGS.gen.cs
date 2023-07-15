// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_AMSTREAMSELECTINFOFLAGS.xml' path='doc/member[@name="_AMSTREAMSELECTINFOFLAGS"]/*'/>
public enum _AMSTREAMSELECTINFOFLAGS
{
    /// <include file='_AMSTREAMSELECTINFOFLAGS.xml' path='doc/member[@name="_AMSTREAMSELECTINFOFLAGS.AMSTREAMSELECTINFO_ENABLED"]/*'/>
    AMSTREAMSELECTINFO_ENABLED = 0x1,
    /// <include file='_AMSTREAMSELECTINFOFLAGS.xml' path='doc/member[@name="_AMSTREAMSELECTINFOFLAGS.AMSTREAMSELECTINFO_EXCLUSIVE"]/*'/>
    AMSTREAMSELECTINFO_EXCLUSIVE = 0x2,
}