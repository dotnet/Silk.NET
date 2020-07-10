/*
* Copyright (c) 2012-2014 AssimpNet - Nicholas Woodfield
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

namespace Silk.NET.Assimp
{
    /// <summary>
    /// Defines how UV coordinates outside the [0..1] range are handled. Commonly
    /// referred to as the 'wrapping mode'
    /// </summary>
    public enum TextureWrapMode
    {
        /// <summary>
        /// A texture coordinate u|v is translated to u % 1| v % 1.
        /// </summary>
        Wrap = 0x0,

        /// <summary>
        /// Texture coordinates outside [0...1] are clamped to the nearest valid value.
        /// </summary>
        Clamp = 0x1,

        /// <summary>
        /// A texture coordinate u|v becomes u1|v1 if (u - (u % 1)) % 2 is zero
        /// and 1 - (u % 1) | 1 - (v % 1) otherwise.
        /// </summary>
        Mirror = 0x2,

        /// <summary>
        /// If the texture coordinates for a pixel are outside [0...1] the texture is not
        /// applied to that pixel.
        /// </summary>
        Decal = 0x3,
    }
}