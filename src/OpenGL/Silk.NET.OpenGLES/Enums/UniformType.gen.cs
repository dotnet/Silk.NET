// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "UniformType")]
    public enum UniformType : int
    {
        [NativeName("Name", "GL_INT")]
        Int = 0x1404,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_DOUBLE")]
        Double = 0x140A,
        [NativeName("Name", "GL_FLOAT_VEC2")]
        FloatVec2 = 0x8B50,
        [NativeName("Name", "GL_FLOAT_VEC3")]
        FloatVec3 = 0x8B51,
        [NativeName("Name", "GL_FLOAT_VEC4")]
        FloatVec4 = 0x8B52,
        [NativeName("Name", "GL_INT_VEC2")]
        IntVec2 = 0x8B53,
        [NativeName("Name", "GL_INT_VEC3")]
        IntVec3 = 0x8B54,
        [NativeName("Name", "GL_INT_VEC4")]
        IntVec4 = 0x8B55,
        [NativeName("Name", "GL_BOOL")]
        Bool = 0x8B56,
        [NativeName("Name", "GL_BOOL_VEC2")]
        BoolVec2 = 0x8B57,
        [NativeName("Name", "GL_BOOL_VEC3")]
        BoolVec3 = 0x8B58,
        [NativeName("Name", "GL_BOOL_VEC4")]
        BoolVec4 = 0x8B59,
        [NativeName("Name", "GL_FLOAT_MAT2")]
        FloatMat2 = 0x8B5A,
        [NativeName("Name", "GL_FLOAT_MAT3")]
        FloatMat3 = 0x8B5B,
        [NativeName("Name", "GL_FLOAT_MAT4")]
        FloatMat4 = 0x8B5C,
        [NativeName("Name", "GL_SAMPLER_1D")]
        Sampler1D = 0x8B5D,
        [NativeName("Name", "GL_SAMPLER_2D")]
        Sampler2D = 0x8B5E,
        [NativeName("Name", "GL_SAMPLER_3D")]
        Sampler3D = 0x8B5F,
        [NativeName("Name", "GL_SAMPLER_CUBE")]
        SamplerCube = 0x8B60,
        [NativeName("Name", "GL_SAMPLER_1D_SHADOW")]
        Sampler1DShadow = 0x8B61,
        [NativeName("Name", "GL_SAMPLER_2D_SHADOW")]
        Sampler2DShadow = 0x8B62,
        [NativeName("Name", "GL_SAMPLER_2D_RECT")]
        Sampler2DRect = 0x8B63,
        [NativeName("Name", "GL_SAMPLER_2D_RECT_SHADOW")]
        Sampler2DRectShadow = 0x8B64,
        [NativeName("Name", "GL_FLOAT_MAT2x3")]
        FloatMat2x3 = 0x8B65,
        [NativeName("Name", "GL_FLOAT_MAT2x4")]
        FloatMat2x4 = 0x8B66,
        [NativeName("Name", "GL_FLOAT_MAT3x2")]
        FloatMat3x2 = 0x8B67,
        [NativeName("Name", "GL_FLOAT_MAT3x4")]
        FloatMat3x4 = 0x8B68,
        [NativeName("Name", "GL_FLOAT_MAT4x2")]
        FloatMat4x2 = 0x8B69,
        [NativeName("Name", "GL_FLOAT_MAT4x3")]
        FloatMat4x3 = 0x8B6A,
        [NativeName("Name", "GL_SAMPLER_1D_ARRAY")]
        Sampler1DArray = 0x8DC0,
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY")]
        Sampler2DArray = 0x8DC1,
        [NativeName("Name", "GL_SAMPLER_BUFFER")]
        SamplerBuffer = 0x8DC2,
        [NativeName("Name", "GL_SAMPLER_1D_ARRAY_SHADOW")]
        Sampler1DArrayShadow = 0x8DC3,
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY_SHADOW")]
        Sampler2DArrayShadow = 0x8DC4,
        [NativeName("Name", "GL_SAMPLER_CUBE_SHADOW")]
        SamplerCubeShadow = 0x8DC5,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC2")]
        UnsignedIntVec2 = 0x8DC6,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC3")]
        UnsignedIntVec3 = 0x8DC7,
        [NativeName("Name", "GL_UNSIGNED_INT_VEC4")]
        UnsignedIntVec4 = 0x8DC8,
        [NativeName("Name", "GL_INT_SAMPLER_1D")]
        IntSampler1D = 0x8DC9,
        [NativeName("Name", "GL_INT_SAMPLER_2D")]
        IntSampler2D = 0x8DCA,
        [NativeName("Name", "GL_INT_SAMPLER_3D")]
        IntSampler3D = 0x8DCB,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE")]
        IntSamplerCube = 0x8DCC,
        [NativeName("Name", "GL_INT_SAMPLER_2D_RECT")]
        IntSampler2DRect = 0x8DCD,
        [NativeName("Name", "GL_INT_SAMPLER_1D_ARRAY")]
        IntSampler1DArray = 0x8DCE,
        [NativeName("Name", "GL_INT_SAMPLER_2D_ARRAY")]
        IntSampler2DArray = 0x8DCF,
        [NativeName("Name", "GL_INT_SAMPLER_BUFFER")]
        IntSamplerBuffer = 0x8DD0,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_1D")]
        UnsignedIntSampler1D = 0x8DD1,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D")]
        UnsignedIntSampler2D = 0x8DD2,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_3D")]
        UnsignedIntSampler3D = 0x8DD3,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE")]
        UnsignedIntSamplerCube = 0x8DD4,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_RECT")]
        UnsignedIntSampler2DRect = 0x8DD5,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_1D_ARRAY")]
        UnsignedIntSampler1DArray = 0x8DD6,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_ARRAY")]
        UnsignedIntSampler2DArray = 0x8DD7,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_BUFFER")]
        UnsignedIntSamplerBuffer = 0x8DD8,
        [NativeName("Name", "GL_DOUBLE_MAT2")]
        DoubleMat2 = 0x8F46,
        [NativeName("Name", "GL_DOUBLE_MAT3")]
        DoubleMat3 = 0x8F47,
        [NativeName("Name", "GL_DOUBLE_MAT4")]
        DoubleMat4 = 0x8F48,
        [NativeName("Name", "GL_DOUBLE_MAT2x3")]
        DoubleMat2x3 = 0x8F49,
        [NativeName("Name", "GL_DOUBLE_MAT2x4")]
        DoubleMat2x4 = 0x8F4A,
        [NativeName("Name", "GL_DOUBLE_MAT3x2")]
        DoubleMat3x2 = 0x8F4B,
        [NativeName("Name", "GL_DOUBLE_MAT3x4")]
        DoubleMat3x4 = 0x8F4C,
        [NativeName("Name", "GL_DOUBLE_MAT4x2")]
        DoubleMat4x2 = 0x8F4D,
        [NativeName("Name", "GL_DOUBLE_MAT4x3")]
        DoubleMat4x3 = 0x8F4E,
        [NativeName("Name", "GL_DOUBLE_VEC2")]
        DoubleVec2 = 0x8FFC,
        [NativeName("Name", "GL_DOUBLE_VEC3")]
        DoubleVec3 = 0x8FFD,
        [NativeName("Name", "GL_DOUBLE_VEC4")]
        DoubleVec4 = 0x8FFE,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY")]
        SamplerCubeMapArray = 0x900C,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW")]
        SamplerCubeMapArrayShadow = 0x900D,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE_MAP_ARRAY")]
        IntSamplerCubeMapArray = 0x900E,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY")]
        UnsignedIntSamplerCubeMapArray = 0x900F,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE")]
        Sampler2DMultisample = 0x9108,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE")]
        IntSampler2DMultisample = 0x9109,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
        UnsignedIntSampler2DMultisample = 0x910A,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        Sampler2DMultisampleArray = 0x910B,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        IntSampler2DMultisampleArray = 0x910C,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        UnsignedIntSampler2DMultisampleArray = 0x910D,
    }
}
