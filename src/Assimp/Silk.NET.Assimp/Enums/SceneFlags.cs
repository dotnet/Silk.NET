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
    /// Defines the state of the imported scene data structure.
    /// </summary>
    [Flags]
    public enum SceneFlags : int
    {
        /// <summary>
        /// Default state of the scene, it imported successfully.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Specifies that the scene data structure that was imported is not complete.
        /// This flag bypasses some internal validations and allows the import
        /// of animation skeletons, material libaries, or camera animation paths
        /// using Assimp. Most applications won't support such data.
        /// </summary>
        Incomplete = 0x1,

        /// <summary>
        /// This flag is set by the <see cref="PostProcessSteps.ValidateDataStructure"/>
        /// post process step if validation is successful. In a validated scene you can be sure that any
        /// cross references in the data structure (e.g. vertex indices) are valid.
        /// </summary>
        Validated = 0x2,

        /// <summary>
        /// This flag is set by the <see cref="PostProcessSteps.ValidateDataStructure"/>
        /// post process step if validation is successful, but some issues have been found. This can for example
        /// mean that a texture that does not exist is referenced by a material or that the bone weights for a vertex
        /// do not sum to 1.0. In most cases you should still be able to use the import. This flag can be useful
        /// for applications which do not capture Assimp's log output.
        /// </summary>
        ValidationWarning = 0x4,

        /// <summary>
        /// This flag is set by the <see cref="PostProcessSteps.JoinIdenticalVertices"/> post process step.
        /// It indicates that the vertices of the output mesh are not in the internal verbose format anymore. In the
        /// verbose format, all vertices are unique where no vertex is ever referenced by more than one face.
        /// </summary>
        NonVerboseFormat = 0x8,

        /// <summary>
        /// Denotes the scene is pure height-map terrain data. Pure terrains usually consist of quads, sometimes triangles,
        /// in a regular grid. The x,y coordinates of all vertex positions refer to the x,y coordinates on the terrain height map, the
        /// z-axis stores the elevation at a specific point.
        /// <para>
        /// TER (Terragen) and HMP (3D Game Studio) are height map formats.
        /// </para>
        /// </summary>
        Terrain = 0x10
    }
}