// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _DVENCODERRESOLUTION
{
    DVENCODERRESOLUTION_720x480 = 2012,
    DVENCODERRESOLUTION_360x240 = 2013,
    DVENCODERRESOLUTION_180x120 = 2014,
    DVENCODERRESOLUTION_88x60 = 2015,
}
