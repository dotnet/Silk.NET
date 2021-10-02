// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_COPP_ImageAspectRatio_EN300294")]
    public enum COPPImageAspectRatioEN300294 : int
    {
        [NativeName("Name", "COPP_AspectRatio_EN300294_FullFormat4by3")]
        CoppAspectRatioEN300294FullFormat4by3 = 0x0,
        [NativeName("Name", "COPP_AspectRatio_EN300294_Box14by9Center")]
        CoppAspectRatioEN300294Box14by9Center = 0x1,
        [NativeName("Name", "COPP_AspectRatio_EN300294_Box14by9Top")]
        CoppAspectRatioEN300294Box14by9Top = 0x2,
        [NativeName("Name", "COPP_AspectRatio_EN300294_Box16by9Center")]
        CoppAspectRatioEN300294Box16by9Center = 0x3,
        [NativeName("Name", "COPP_AspectRatio_EN300294_Box16by9Top")]
        CoppAspectRatioEN300294Box16by9Top = 0x4,
        [NativeName("Name", "COPP_AspectRatio_EN300294_BoxGT16by9Center")]
        CoppAspectRatioEN300294BoxGT16by9Center = 0x5,
        [NativeName("Name", "COPP_AspectRatio_EN300294_FullFormat4by3ProtectedCenter")]
        CoppAspectRatioEN300294FullFormat4by3ProtectedCenter = 0x6,
        [NativeName("Name", "COPP_AspectRatio_EN300294_FullFormat16by9Anamorphic")]
        CoppAspectRatioEN300294FullFormat16by9Anamorphic = 0x7,
        [NativeName("Name", "COPP_AspectRatio_ForceDWORD")]
        CoppAspectRatioForceDword = 0x7FFFFFFF,
    }
}
