// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DVD_DOMAIN.xml' path='doc/member[@name="DVD_DOMAIN"]/*'/>
public enum DVD_DOMAIN
{
    /// <include file='DVD_DOMAIN.xml' path='doc/member[@name="DVD_DOMAIN.DVD_DOMAIN_FirstPlay"]/*'/>
    DVD_DOMAIN_FirstPlay = 1,
    /// <include file='DVD_DOMAIN.xml' path='doc/member[@name="DVD_DOMAIN.DVD_DOMAIN_VideoManagerMenu"]/*'/>
    DVD_DOMAIN_VideoManagerMenu = (DVD_DOMAIN_FirstPlay + 1),
    /// <include file='DVD_DOMAIN.xml' path='doc/member[@name="DVD_DOMAIN.DVD_DOMAIN_VideoTitleSetMenu"]/*'/>
    DVD_DOMAIN_VideoTitleSetMenu = (DVD_DOMAIN_VideoManagerMenu + 1),
    /// <include file='DVD_DOMAIN.xml' path='doc/member[@name="DVD_DOMAIN.DVD_DOMAIN_Title"]/*'/>
    DVD_DOMAIN_Title = (DVD_DOMAIN_VideoTitleSetMenu + 1),
    /// <include file='DVD_DOMAIN.xml' path='doc/member[@name="DVD_DOMAIN.DVD_DOMAIN_Stop"]/*'/>
    DVD_DOMAIN_Stop = (DVD_DOMAIN_Title + 1),
}