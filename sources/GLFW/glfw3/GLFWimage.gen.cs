// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
namespace Silk.NET.GLFW
{
    public unsafe partial struct GLFWimage
    {
        public int width;
        public int height;
        [NativeTypeName("unsigned char *")]
        public byte* pixels;
    }
}