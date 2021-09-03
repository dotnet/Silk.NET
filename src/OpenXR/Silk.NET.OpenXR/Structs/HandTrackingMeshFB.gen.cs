// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandTrackingMeshFB")]
    public unsafe partial struct HandTrackingMeshFB
    {
        public HandTrackingMeshFB
        (
            StructureType? type = StructureType.TypeHandTrackingMeshFB,
            void* next = null,
            uint? jointCapacityInput = null,
            uint? jointCountOutput = null,
            Posef* jointBindPoses = null,
            float* jointRadii = null,
            HandJointEXT* jointParents = null,
            uint? vertexCapacityInput = null,
            uint? vertexCountOutput = null,
            Vector3f* vertexPositions = null,
            Vector3f* vertexNormals = null,
            Vector2f* vertexUVs = null,
            Silk.NET.Maths.Vector4D<short>* vertexBlendIndices = null,
            Vector4f* vertexBlendWeights = null,
            uint? indexCapacityInput = null,
            uint? indexCountOutput = null,
            short* indices = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (jointCapacityInput is not null)
            {
                JointCapacityInput = jointCapacityInput.Value;
            }

            if (jointCountOutput is not null)
            {
                JointCountOutput = jointCountOutput.Value;
            }

            if (jointBindPoses is not null)
            {
                JointBindPoses = jointBindPoses;
            }

            if (jointRadii is not null)
            {
                JointRadii = jointRadii;
            }

            if (jointParents is not null)
            {
                JointParents = jointParents;
            }

            if (vertexCapacityInput is not null)
            {
                VertexCapacityInput = vertexCapacityInput.Value;
            }

            if (vertexCountOutput is not null)
            {
                VertexCountOutput = vertexCountOutput.Value;
            }

            if (vertexPositions is not null)
            {
                VertexPositions = vertexPositions;
            }

            if (vertexNormals is not null)
            {
                VertexNormals = vertexNormals;
            }

            if (vertexUVs is not null)
            {
                VertexUVs = vertexUVs;
            }

            if (vertexBlendIndices is not null)
            {
                VertexBlendIndices = vertexBlendIndices;
            }

            if (vertexBlendWeights is not null)
            {
                VertexBlendWeights = vertexBlendWeights;
            }

            if (indexCapacityInput is not null)
            {
                IndexCapacityInput = indexCapacityInput.Value;
            }

            if (indexCountOutput is not null)
            {
                IndexCountOutput = indexCountOutput.Value;
            }

            if (indices is not null)
            {
                Indices = indices;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointCapacityInput")]
        public uint JointCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointCountOutput")]
        public uint JointCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrPosef*")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "jointBindPoses")]
        public Posef* JointBindPoses;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "jointRadii")]
        public float* JointRadii;
/// <summary></summary>
        [NativeName("Type", "XrHandJointEXT*")]
        [NativeName("Type.Name", "XrHandJointEXT")]
        [NativeName("Name", "jointParents")]
        public HandJointEXT* JointParents;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCapacityInput")]
        public uint VertexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCountOutput")]
        public uint VertexCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrVector3f*")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "vertexPositions")]
        public Vector3f* VertexPositions;
/// <summary></summary>
        [NativeName("Type", "XrVector3f*")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "vertexNormals")]
        public Vector3f* VertexNormals;
/// <summary></summary>
        [NativeName("Type", "XrVector2f*")]
        [NativeName("Type.Name", "XrVector2f")]
        [NativeName("Name", "vertexUVs")]
        public Vector2f* VertexUVs;
/// <summary></summary>
        [NativeName("Type", "XrVector4sFB*")]
        [NativeName("Type.Name", "XrVector4sFB")]
        [NativeName("Name", "vertexBlendIndices")]
        public Silk.NET.Maths.Vector4D<short>* VertexBlendIndices;
/// <summary></summary>
        [NativeName("Type", "XrVector4f*")]
        [NativeName("Type.Name", "XrVector4f")]
        [NativeName("Name", "vertexBlendWeights")]
        public Vector4f* VertexBlendWeights;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCapacityInput")]
        public uint IndexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCountOutput")]
        public uint IndexCountOutput;
/// <summary></summary>
        [NativeName("Type", "int16_t*")]
        [NativeName("Type.Name", "int16_t")]
        [NativeName("Name", "indices")]
        public short* Indices;
    }
}
