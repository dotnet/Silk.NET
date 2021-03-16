// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
    /// Static class containing preset properties for post processing options.
    /// </summary>
    public static class PostProcessPreset
    {
        /// <summary>
        /// PostProcess configuration for (some) Direct3D conventions,
        /// left handed geometry, upper left origin for UV coordinates,
        /// and clockwise face order, suitable for CCW culling.
        /// </summary>
        public static PostProcessSteps ConvertToLeftHanded
        {
            get
            {
                return PostProcessSteps.MakeLeftHanded |
                    PostProcessSteps.FlipUVs |
                    PostProcessSteps.FlipWindingOrder;
            }
        }

        /// <summary>
        /// PostProcess configuration for optimizing data for real-time.
        /// Does the following steps:
        /// 
        /// <see cref="PostProcessSteps.CalculateTangentSpace"/>, <see cref="PostProcessSteps.GenerateNormals"/>, 
        /// <see cref="PostProcessSteps.JoinIdenticalVertices"/>, <see cref="PostProcessSteps.Triangulate"/>,
        /// <see cref="PostProcessSteps.GenerateUVCoords"/>, and <see cref="PostProcessSteps.SortByPrimitiveType"/>
        /// </summary>
        public static PostProcessSteps TargetRealTimeFast
        {
            get
            {
                return PostProcessSteps.CalculateTangentSpace |
                    PostProcessSteps.GenerateNormals |
                    PostProcessSteps.JoinIdenticalVertices |
                    PostProcessSteps.Triangulate |
                    PostProcessSteps.GenerateUVCoords |
                    PostProcessSteps.SortByPrimitiveType;
            }
        }

        /// <summary>
        /// PostProcess configuration for optimizing
        /// data for real-time rendering. Does the following steps:
        /// 
        /// <see cref="PostProcessSteps.CalculateTangentSpace"/>, <see cref="PostProcessSteps.GenerateSmoothNormals"/>, 
        /// <see cref="PostProcessSteps.JoinIdenticalVertices"/>, <see cref="PostProcessSteps.Triangulate"/>,
        /// <see cref="PostProcessSteps.GenerateUVCoords"/>, <see cref="PostProcessSteps.SortByPrimitiveType"/>
        /// <see cref="PostProcessSteps.LimitBoneWeights"/>, <see cref="PostProcessSteps.RemoveRedundantMaterials"/>,
        /// <see cref="PostProcessSteps.SplitLargeMeshes"/>, <see cref="PostProcessSteps.FindDegenerates"/>, and
        /// <see cref="PostProcessSteps.FindInvalidData"/>
        /// </summary>
        public static PostProcessSteps TargetRealTimeQuality
        {
            get
            {
                return PostProcessSteps.CalculateTangentSpace |
                    PostProcessSteps.GenerateSmoothNormals |
                    PostProcessSteps.JoinIdenticalVertices |
                    PostProcessSteps.LimitBoneWeights |
                    PostProcessSteps.RemoveRedundantMaterials |
                    PostProcessSteps.SplitLargeMeshes |
                    PostProcessSteps.Triangulate |
                    PostProcessSteps.GenerateUVCoords |
                    PostProcessSteps.SortByPrimitiveType |
                    PostProcessSteps.FindDegenerates |
                    PostProcessSteps.FindInvalidData;
            }
        }

        /// <summary>
        /// PostProcess configuration for heavily optimizing the data
        /// for real-time rendering. Includes all flags in
        /// <see cref="PostProcessPreset.TargetRealTimeQuality"/> as well as 
        /// <see cref="PostProcessSteps.FindInstances"/>, <see cref="PostProcessSteps.ValidateDataStructure"/>, and
        /// <see cref="PostProcessSteps.OptimizeMeshes"/>
        /// </summary>
        public static PostProcessSteps TargetRealTimeMaximumQuality
        {
            get
            {
                return TargetRealTimeQuality |
                    PostProcessSteps.FindInstances |
                    PostProcessSteps.ValidateDataStructure |
                    PostProcessSteps.OptimizeMeshes;
            }
        }
    }
}
