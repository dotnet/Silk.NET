// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PROPERTY_UNITS
{
    PROPERTY_UNITS_DEFAULT = 0,
    PROPERTY_UNITS_INCHES = 1,
    PROPERTY_UNITS_CENTIMETERS = 2,
    PROPERTY_UNITS_DEGREES = 3,
    PROPERTY_UNITS_RADIANS = 4,
    PROPERTY_UNITS_SECONDS = 5,
    PROPERTY_UNITS_POUNDS = 6,
    PROPERTY_UNITS_GRAMS = 7,
    PROPERTY_UNITS_SILINEAR = 8,
    PROPERTY_UNITS_SIROTATION = 9,
    PROPERTY_UNITS_ENGLINEAR = 10,
    PROPERTY_UNITS_ENGROTATION = 11,
    PROPERTY_UNITS_SLUGS = 12,
    PROPERTY_UNITS_KELVIN = 13,
    PROPERTY_UNITS_FAHRENHEIT = 14,
    PROPERTY_UNITS_AMPERE = 15,
    PROPERTY_UNITS_CANDELA = 16,
}
