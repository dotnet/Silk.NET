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

using System;

namespace Silk.NET.Assimp
{
    /// <summary>
    /// Enumerates components of the scene or mesh data that
    /// can be excluded from the import using the post process step
    /// RemoveComponent.
    /// </summary>
    [Flags]
    public enum ExcludeComponent
    {
        /// <summary>
        /// No components to be excluded.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Removes normal vectors
        /// </summary>
        Normals = 0x2,

        /// <summary>
        /// Removes tangents/binormals
        /// </summary>
        TangentBasis = 0x4,

        /// <summary>
        /// Removes all color sets.
        /// </summary>
        Colors = 0x8,

        /// <summary>
        /// Removes all texture UV sets.
        /// </summary>
        TexCoords = 0x10,

        /// <summary>
        /// Remove all boneweights from all meshes. Scenegraph
        /// nodes corresponding to the bones are NOT removed.
        /// Use OptimizeGraph step to remove them.
        /// </summary>
        Boneweights = 0x20,

        /// <summary>
        /// Removes all node animations.  Coressponding scenegraph
        /// nodes are NOT removed. Use OptimizeGraph step to 
        /// remove them.
        /// </summary>
        Animations = 0x40,

        /// <summary>
        /// Removes all embedded textures.
        /// </summary>
        Textures = 0x80,

        /// <summary>
        /// Removes all light sources. The corresponding scenegraph nodes are
        /// NOT removed. Use the OptimizeGraph step to do this.
        /// </summary>
        Lights = 0x100,

        /// <summary>
        /// Removes all cameras. The corresponding scenegraph
        /// nodes are NOT removed. Use the OptimizeGraph step
        /// to do this.
        /// </summary>
        Cameras = 0x200,

        /// <summary>
        /// Removes all meshes.
        /// </summary>
        Meshes = 0x400,

        /// <summary>
        /// Removes all materials. One default material will be generated.
        /// </summary>
        Materials = 0x800
    }
}