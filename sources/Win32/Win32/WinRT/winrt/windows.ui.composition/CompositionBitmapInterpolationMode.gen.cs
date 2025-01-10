// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CompositionBitmapInterpolationMode
{
    CompositionBitmapInterpolationMode_NearestNeighbor = 0,
    CompositionBitmapInterpolationMode_Linear = 1,
    CompositionBitmapInterpolationMode_MagLinearMinLinearMipLinear = 2,
    CompositionBitmapInterpolationMode_MagLinearMinLinearMipNearest = 3,
    CompositionBitmapInterpolationMode_MagLinearMinNearestMipLinear = 4,
    CompositionBitmapInterpolationMode_MagLinearMinNearestMipNearest = 5,
    CompositionBitmapInterpolationMode_MagNearestMinLinearMipLinear = 6,
    CompositionBitmapInterpolationMode_MagNearestMinLinearMipNearest = 7,
    CompositionBitmapInterpolationMode_MagNearestMinNearestMipLinear = 8,
    CompositionBitmapInterpolationMode_MagNearestMinNearestMipNearest = 9,
}
