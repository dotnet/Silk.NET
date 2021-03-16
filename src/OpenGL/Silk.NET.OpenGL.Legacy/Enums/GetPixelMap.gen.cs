// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetPixelMap")]
    public enum GetPixelMap : int
    {
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_I")]
        PixelMapIToI = 0xC70,
        [NativeName("Name", "GL_PIXEL_MAP_S_TO_S")]
        PixelMapSToS = 0xC71,
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_R")]
        PixelMapIToR = 0xC72,
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_G")]
        PixelMapIToG = 0xC73,
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_B")]
        PixelMapIToB = 0xC74,
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_A")]
        PixelMapIToA = 0xC75,
        [NativeName("Name", "GL_PIXEL_MAP_R_TO_R")]
        PixelMapRToR = 0xC76,
        [NativeName("Name", "GL_PIXEL_MAP_G_TO_G")]
        PixelMapGToG = 0xC77,
        [NativeName("Name", "GL_PIXEL_MAP_B_TO_B")]
        PixelMapBToB = 0xC78,
        [NativeName("Name", "GL_PIXEL_MAP_A_TO_A")]
        PixelMapAToA = 0xC79,
    }
}
