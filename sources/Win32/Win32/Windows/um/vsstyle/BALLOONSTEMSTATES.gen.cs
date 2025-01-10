// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum BALLOONSTEMSTATES
{
    TTBSS_POINTINGUPLEFTWALL = 1,
    TTBSS_POINTINGUPCENTERED = 2,
    TTBSS_POINTINGUPRIGHTWALL = 3,
    TTBSS_POINTINGDOWNRIGHTWALL = 4,
    TTBSS_POINTINGDOWNCENTERED = 5,
    TTBSS_POINTINGDOWNLEFTWALL = 6,
}
