// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AttributeType")]
public enum AttributeType : uint
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

    [NativeName("GL_IMAGE_1D")]
    Image1D = 36940,

    [NativeName("GL_IMAGE_2D")]
    Image2D = 36941,

    [NativeName("GL_IMAGE_3D")]
    Image3D = 36942,

    [NativeName("GL_IMAGE_2D_RECT")]
    Image2DRect = 36943,

    [NativeName("GL_IMAGE_CUBE")]
    ImageCube = 36944,

    [NativeName("GL_IMAGE_BUFFER")]
    ImageBuffer = 36945,

    [NativeName("GL_IMAGE_1D_ARRAY")]
    Image1DArray = 36946,

    [NativeName("GL_IMAGE_2D_ARRAY")]
    Image2DArray = 36947,

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY")]
    ImageCubeMapArray = 36948,

    [NativeName("GL_IMAGE_2D_MULTISAMPLE")]
    Image2DMultisample = 36949,

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY")]
    Image2DMultisampleArray = 36950,

    [NativeName("GL_INT_IMAGE_1D")]
    IntImage1D = 36951,

    [NativeName("GL_INT_IMAGE_2D")]
    IntImage2D = 36952,

    [NativeName("GL_INT_IMAGE_3D")]
    IntImage3D = 36953,

    [NativeName("GL_INT_IMAGE_2D_RECT")]
    IntImage2DRect = 36954,

    [NativeName("GL_INT_IMAGE_CUBE")]
    IntImageCube = 36955,

    [NativeName("GL_INT_IMAGE_BUFFER")]
    IntImageBuffer = 36956,

    [NativeName("GL_INT_IMAGE_1D_ARRAY")]
    IntImage1DArray = 36957,

    [NativeName("GL_INT_IMAGE_2D_ARRAY")]
    IntImage2DArray = 36958,

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY")]
    IntImageCubeMapArray = 36959,

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE")]
    IntImage2DMultisample = 36960,

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    IntImage2DMultisampleArray = 36961,

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D")]
    UnsignedIntImage1D = 36962,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D")]
    UnsignedIntImage2D = 36963,

    [NativeName("GL_UNSIGNED_INT_IMAGE_3D")]
    UnsignedIntImage3D = 36964,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT")]
    UnsignedIntImage2DRect = 36965,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE")]
    UnsignedIntImageCube = 36966,

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER")]
    UnsignedIntImageBuffer = 36967,

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY")]
    UnsignedIntImage1DArray = 36968,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
    UnsignedIntImage2DArray = 36969,

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
    UnsignedIntImageCubeMapArray = 36970,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE")]
    UnsignedIntImage2DMultisample = 36971,

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntImage2DMultisampleArray = 36972,

    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64ARB = 5135,

    [NativeName("GL_INT64_ARB")]
    Int64ARB = 5134,

    [NativeName("GL_INT64_VEC2_ARB")]
    Int64Vec2ARB = 36841,

    [NativeName("GL_INT64_VEC3_ARB")]
    Int64Vec3ARB = 36842,

    [NativeName("GL_INT64_VEC4_ARB")]
    Int64Vec4ARB = 36843,

    [NativeName("GL_UNSIGNED_INT64_VEC2_ARB")]
    UnsignedInt64Vec2ARB = 36853,

    [NativeName("GL_UNSIGNED_INT64_VEC3_ARB")]
    UnsignedInt64Vec3ARB = 36854,

    [NativeName("GL_UNSIGNED_INT64_VEC4_ARB")]
    UnsignedInt64Vec4ARB = 36855,

    [NativeName("GL_FLOAT_VEC2_ARB")]
    FloatVec2ARB = 35664,

    [NativeName("GL_FLOAT_VEC3_ARB")]
    FloatVec3ARB = 35665,

    [NativeName("GL_FLOAT_VEC4_ARB")]
    FloatVec4ARB = 35666,

    [NativeName("GL_INT_VEC2_ARB")]
    IntVec2ARB = 35667,

    [NativeName("GL_INT_VEC3_ARB")]
    IntVec3ARB = 35668,

    [NativeName("GL_INT_VEC4_ARB")]
    IntVec4ARB = 35669,

    [NativeName("GL_BOOL_ARB")]
    BoolARB = 35670,

    [NativeName("GL_BOOL_VEC2_ARB")]
    BoolVec2ARB = 35671,

    [NativeName("GL_BOOL_VEC3_ARB")]
    BoolVec3ARB = 35672,

    [NativeName("GL_BOOL_VEC4_ARB")]
    BoolVec4ARB = 35673,

    [NativeName("GL_FLOAT_MAT2_ARB")]
    FloatMat2ARB = 35674,

    [NativeName("GL_FLOAT_MAT3_ARB")]
    FloatMat3ARB = 35675,

    [NativeName("GL_FLOAT_MAT4_ARB")]
    FloatMat4ARB = 35676,

    [NativeName("GL_SAMPLER_1D_ARB")]
    Sampler1DARB = 35677,

    [NativeName("GL_SAMPLER_2D_ARB")]
    Sampler2DARB = 35678,

    [NativeName("GL_SAMPLER_3D_ARB")]
    Sampler3DARB = 35679,

    [NativeName("GL_SAMPLER_CUBE_ARB")]
    SamplerCubeARB = 35680,

    [NativeName("GL_SAMPLER_1D_SHADOW_ARB")]
    Sampler1DShadowARB = 35681,

    [NativeName("GL_SAMPLER_2D_SHADOW_ARB")]
    Sampler2DShadowARB = 35682,

    [NativeName("GL_SAMPLER_2D_RECT_ARB")]
    Sampler2DRectARB = 35683,

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW_ARB")]
    Sampler2DRectShadowARB = 35684,

    [NativeName("GL_INT64_NV")]
    Int64NV = 5134,

    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64NV = 5135,

    [NativeName("GL_SAMPLER_3D_OES")]
    Sampler3DOES = 35679,

    [NativeName("GL_SAMPLER_2D_SHADOW_EXT")]
    Sampler2DShadowEXT = 35682,

    [NativeName("GL_FLOAT_MAT2x3_NV")]
    FloatMAT2X3NV = 35685,

    [NativeName("GL_FLOAT_MAT2x4_NV")]
    FloatMAT2X4NV = 35686,

    [NativeName("GL_FLOAT_MAT3x2_NV")]
    FloatMAT3X2NV = 35687,

    [NativeName("GL_FLOAT_MAT3x4_NV")]
    FloatMAT3X4NV = 35688,

    [NativeName("GL_FLOAT_MAT4x2_NV")]
    FloatMAT4X2NV = 35689,

    [NativeName("GL_FLOAT_MAT4x3_NV")]
    FloatMAT4X3NV = 35690,
}
