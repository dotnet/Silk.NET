// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.IP_PREFIX_ORIGIN;

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define NlpoOther IpPrefixOriginOther")]
    public const IP_PREFIX_ORIGIN NlpoOther = IpPrefixOriginOther;

    [NativeTypeName("#define NlpoManual IpPrefixOriginManual")]
    public const IP_PREFIX_ORIGIN NlpoManual = IpPrefixOriginManual;

    [NativeTypeName("#define NlpoWellKnown IpPrefixOriginWellKnown")]
    public const IP_PREFIX_ORIGIN NlpoWellKnown = IpPrefixOriginWellKnown;

    [NativeTypeName("#define NlpoDhcp IpPrefixOriginDhcp")]
    public const IP_PREFIX_ORIGIN NlpoDhcp = IpPrefixOriginDhcp;

    [NativeTypeName("#define NlpoRouterAdvertisement IpPrefixOriginRouterAdvertisement")]
    public const IP_PREFIX_ORIGIN NlpoRouterAdvertisement = IpPrefixOriginRouterAdvertisement;

    [NativeTypeName("#define NL_MAX_METRIC_COMPONENT ((((ULONG) 1) << 31) - 1)")]
    public const uint NL_MAX_METRIC_COMPONENT = ((((uint)(1)) << 31) - 1);
}
