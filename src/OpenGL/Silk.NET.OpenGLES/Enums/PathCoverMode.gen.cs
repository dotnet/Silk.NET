// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum PathCoverMode
    {
        PathFillCoverModeNV = 0x9082,
        ConvexHullNV = 0x908B,
        BoundingBoxNV = 0x908D,
        BoundingBoxOfBoundingBoxesNV = 0x909C,
    }
}
