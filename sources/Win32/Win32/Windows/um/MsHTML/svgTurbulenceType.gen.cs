// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgTurbulenceType
{
    SVG_TURBULENCE_TYPE_UNKNOWN = 0,
    SVG_TURBULENCE_TYPE_FACTALNOISE = 1,
    SVG_TURBULENCE_TYPE_TURBULENCE = 2,
    svgTurbulenceType_Max = 2147483647,
}
