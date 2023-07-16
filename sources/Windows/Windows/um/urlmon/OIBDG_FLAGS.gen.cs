// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OIBDG_FLAGS.xml' path='doc/member[@name="OIBDG_FLAGS"]/*'/>
public enum OIBDG_FLAGS
{
    /// <include file='OIBDG_FLAGS.xml' path='doc/member[@name="OIBDG_FLAGS.OIBDG_APARTMENTTHREADED"]/*'/>
    OIBDG_APARTMENTTHREADED = 0x100,
    /// <include file='OIBDG_FLAGS.xml' path='doc/member[@name="OIBDG_FLAGS.OIBDG_DATAONLY"]/*'/>
    OIBDG_DATAONLY = 0x1000,
}