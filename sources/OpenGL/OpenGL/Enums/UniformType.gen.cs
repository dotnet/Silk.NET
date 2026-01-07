// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("UniformType")]
public enum UniformType : uint
{
    [NativeName("GL_INT")]
    Int = 5124,

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,

    [NativeName("GL_FLOAT")]
    Float = 5126,

    [NativeName("GL_DOUBLE")]
    Double = 5130,

    [NativeName("GL_FLOAT_VEC2")]
    FloatVec2 = 35664,

    [NativeName("GL_FLOAT_VEC3")]
    FloatVec3 = 35665,

    [NativeName("GL_FLOAT_VEC4")]
    FloatVec4 = 35666,

    [NativeName("GL_INT_VEC2")]
    IntVec2 = 35667,

    [NativeName("GL_INT_VEC3")]
    IntVec3 = 35668,

    [NativeName("GL_INT_VEC4")]
    IntVec4 = 35669,

    [NativeName("GL_BOOL")]
    Bool = 35670,

    [NativeName("GL_BOOL_VEC2")]
    BoolVec2 = 35671,

    [NativeName("GL_BOOL_VEC3")]
    BoolVec3 = 35672,

    [NativeName("GL_BOOL_VEC4")]
    BoolVec4 = 35673,

    [NativeName("GL_FLOAT_MAT2")]
    FloatMat2 = 35674,

    [NativeName("GL_FLOAT_MAT3")]
    FloatMat3 = 35675,

    [NativeName("GL_FLOAT_MAT4")]
    FloatMat4 = 35676,

    [NativeName("GL_SAMPLER_1D")]
    Sampler1D = 35677,

    [NativeName("GL_SAMPLER_2D")]
    Sampler2D = 35678,

    [NativeName("GL_SAMPLER_3D")]
    Sampler3D = 35679,

    [NativeName("GL_SAMPLER_CUBE")]
    SamplerCube = 35680,

    [NativeName("GL_SAMPLER_1D_SHADOW")]
    Sampler1DShadow = 35681,

    [NativeName("GL_SAMPLER_2D_SHADOW")]
    Sampler2DShadow = 35682,

    [NativeName("GL_FLOAT_MAT2x3")]
    FloatMAT2X3 = 35685,

    [NativeName("GL_FLOAT_MAT2x4")]
    FloatMAT2X4 = 35686,

    [NativeName("GL_FLOAT_MAT3x2")]
    FloatMAT3X2 = 35687,

    [NativeName("GL_FLOAT_MAT3x4")]
    FloatMAT3X4 = 35688,

    [NativeName("GL_FLOAT_MAT4x2")]
    FloatMAT4X2 = 35689,

    [NativeName("GL_FLOAT_MAT4x3")]
    FloatMAT4X3 = 35690,

    [NativeName("GL_SAMPLER_1D_ARRAY")]
    Sampler1DArray = 36288,

    [NativeName("GL_SAMPLER_2D_ARRAY")]
    Sampler2DArray = 36289,

    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW")]
    Sampler1DArrayShadow = 36291,

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW")]
    Sampler2DArrayShadow = 36292,

    [NativeName("GL_SAMPLER_CUBE_SHADOW")]
    SamplerCubeShadow = 36293,

    [NativeName("GL_UNSIGNED_INT_VEC2")]
    UnsignedIntVec2 = 36294,

    [NativeName("GL_UNSIGNED_INT_VEC3")]
    UnsignedIntVec3 = 36295,

    [NativeName("GL_UNSIGNED_INT_VEC4")]
    UnsignedIntVec4 = 36296,

    [NativeName("GL_INT_SAMPLER_1D")]
    IntSampler1D = 36297,

    [NativeName("GL_INT_SAMPLER_2D")]
    IntSampler2D = 36298,

    [NativeName("GL_INT_SAMPLER_3D")]
    IntSampler3D = 36299,

    [NativeName("GL_INT_SAMPLER_CUBE")]
    IntSamplerCube = 36300,

    [NativeName("GL_INT_SAMPLER_1D_ARRAY")]
    IntSampler1DArray = 36302,

    [NativeName("GL_INT_SAMPLER_2D_ARRAY")]
    IntSampler2DArray = 36303,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D")]
    UnsignedIntSampler1D = 36305,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D")]
    UnsignedIntSampler2D = 36306,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D")]
    UnsignedIntSampler3D = 36307,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE")]
    UnsignedIntSamplerCube = 36308,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY")]
    UnsignedIntSampler1DArray = 36310,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY")]
    UnsignedIntSampler2DArray = 36311,

    [NativeName("GL_SAMPLER_2D_RECT")]
    Sampler2DRect = 35683,

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW")]
    Sampler2DRectShadow = 35684,

    [NativeName("GL_SAMPLER_BUFFER")]
    SamplerBuffer = 36290,

    [NativeName("GL_INT_SAMPLER_2D_RECT")]
    IntSampler2DRect = 36301,

    [NativeName("GL_INT_SAMPLER_BUFFER")]
    IntSamplerBuffer = 36304,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT")]
    UnsignedIntSampler2DRect = 36309,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER")]
    UnsignedIntSamplerBuffer = 36312,

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE")]
    Sampler2DMultisample = 37128,

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE")]
    IntSampler2DMultisample = 37129,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
    UnsignedIntSampler2DMultisample = 37130,

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    Sampler2DMultisampleArray = 37131,

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    IntSampler2DMultisampleArray = 37132,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntSampler2DMultisampleArray = 37133,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY")]
    SamplerCubeMapArray = 36876,

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW")]
    SamplerCubeMapArrayShadow = 36877,

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY")]
    IntSamplerCubeMapArray = 36878,

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY")]
    UnsignedIntSamplerCubeMapArray = 36879,

    [NativeName("GL_DOUBLE_VEC2")]
    DoubleVec2 = 36860,

    [NativeName("GL_DOUBLE_VEC3")]
    DoubleVec3 = 36861,

    [NativeName("GL_DOUBLE_VEC4")]
    DoubleVec4 = 36862,

    [NativeName("GL_DOUBLE_MAT2")]
    DoubleMat2 = 36678,

    [NativeName("GL_DOUBLE_MAT3")]
    DoubleMat3 = 36679,

    [NativeName("GL_DOUBLE_MAT4")]
    DoubleMat4 = 36680,

    [NativeName("GL_DOUBLE_MAT2x3")]
    DoubleMAT2X3 = 36681,

    [NativeName("GL_DOUBLE_MAT2x4")]
    DoubleMAT2X4 = 36682,

    [NativeName("GL_DOUBLE_MAT3x2")]
    DoubleMAT3X2 = 36683,

    [NativeName("GL_DOUBLE_MAT3x4")]
    DoubleMAT3X4 = 36684,

    [NativeName("GL_DOUBLE_MAT4x2")]
    DoubleMAT4X2 = 36685,

    [NativeName("GL_DOUBLE_MAT4x3")]
    DoubleMAT4X3 = 36686,
}
