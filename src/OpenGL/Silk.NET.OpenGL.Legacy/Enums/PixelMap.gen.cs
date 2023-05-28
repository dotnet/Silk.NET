// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelMap")]
    public enum PixelMap : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_I")]
        PixelMapIToI = 0xC70,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_S_TO_S")]
        PixelMapSToS = 0xC71,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_R")]
        PixelMapIToR = 0xC72,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_G")]
        PixelMapIToG = 0xC73,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_B")]
        PixelMapIToB = 0xC74,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_A")]
        PixelMapIToA = 0xC75,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_R_TO_R")]
        PixelMapRToR = 0xC76,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_G_TO_G")]
        PixelMapGToG = 0xC77,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_B_TO_B")]
        PixelMapBToB = 0xC78,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_A_TO_A")]
        PixelMapAToA = 0xC79,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_I")]
        IToI = 0xC70,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_S_TO_S")]
        SToS = 0xC71,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_R")]
        IToR = 0xC72,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_G")]
        IToG = 0xC73,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_B")]
        IToB = 0xC74,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_A")]
        IToA = 0xC75,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_R_TO_R")]
        RToR = 0xC76,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_G_TO_G")]
        GToG = 0xC77,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_B_TO_B")]
        BToB = 0xC78,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_A_TO_A")]
        AToA = 0xC79,
    }
}
