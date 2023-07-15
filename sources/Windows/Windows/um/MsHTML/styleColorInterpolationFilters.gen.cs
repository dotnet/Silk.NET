// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleColorInterpolationFilters.xml' path='doc/member[@name="styleColorInterpolationFilters"]/*'/>
public enum styleColorInterpolationFilters
{
    /// <include file='styleColorInterpolationFilters.xml' path='doc/member[@name="styleColorInterpolationFilters.styleColorInterpolationFiltersAuto"]/*'/>
    styleColorInterpolationFiltersAuto = 0,
    /// <include file='styleColorInterpolationFilters.xml' path='doc/member[@name="styleColorInterpolationFilters.styleColorInterpolationFiltersSRgb"]/*'/>
    styleColorInterpolationFiltersSRgb = 1,
    /// <include file='styleColorInterpolationFilters.xml' path='doc/member[@name="styleColorInterpolationFilters.styleColorInterpolationFiltersLinearRgb"]/*'/>
    styleColorInterpolationFiltersLinearRgb = 2,
    /// <include file='styleColorInterpolationFilters.xml' path='doc/member[@name="styleColorInterpolationFilters.styleColorInterpolationFiltersNotSet"]/*'/>
    styleColorInterpolationFiltersNotSet = 3,
    /// <include file='styleColorInterpolationFilters.xml' path='doc/member[@name="styleColorInterpolationFilters.styleColorInterpolationFilters_Max"]/*'/>
    styleColorInterpolationFilters_Max = 2147483647,
}