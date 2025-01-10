// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_DOMAIN
{
    DVD_DOMAIN_FirstPlay = 1,
    DVD_DOMAIN_VideoManagerMenu = (DVD_DOMAIN_FirstPlay + 1),
    DVD_DOMAIN_VideoTitleSetMenu = (DVD_DOMAIN_VideoManagerMenu + 1),
    DVD_DOMAIN_Title = (DVD_DOMAIN_VideoTitleSetMenu + 1),
    DVD_DOMAIN_Stop = (DVD_DOMAIN_Title + 1),
}
