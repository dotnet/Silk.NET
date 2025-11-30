// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AttributeType")]
[Transformed]
public enum AttributeType : uint
{
    [NativeName("GL_FLOAT")]
    Float = unchecked((uint)0x1406),

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NativeName("GL_INT")]
    Int = unchecked((uint)0x1404),

    [NativeName("GL_DOUBLE")]
    Double = unchecked((uint)0x140A),

    [NativeName("GL_FLOAT_VEC2")]
    FloatVec2 = unchecked((uint)0x8B50),

    [NativeName("GL_FLOAT_VEC3")]
    FloatVec3 = unchecked((uint)0x8B51),

    [NativeName("GL_FLOAT_VEC4")]
    FloatVec4 = unchecked((uint)0x8B52),

    [NativeName("GL_INT_VEC2")]
    IntVec2 = unchecked((uint)0x8B53),

    [NativeName("GL_INT_VEC3")]
    IntVec3 = unchecked((uint)0x8B54),

    [NativeName("GL_INT_VEC4")]
    IntVec4 = unchecked((uint)0x8B55),

    [NativeName("GL_BOOL")]
    Bool = unchecked((uint)0x8B56),

    [NativeName("GL_BOOL_VEC2")]
    BoolVec2 = unchecked((uint)0x8B57),

    [NativeName("GL_BOOL_VEC3")]
    BoolVec3 = unchecked((uint)0x8B58),

    [NativeName("GL_BOOL_VEC4")]
    BoolVec4 = unchecked((uint)0x8B59),

    [NativeName("GL_FLOAT_MAT2")]
    FloatMat2 = unchecked((uint)0x8B5A),

    [NativeName("GL_FLOAT_MAT3")]
    FloatMat3 = unchecked((uint)0x8B5B),

    [NativeName("GL_FLOAT_MAT4")]
    FloatMat4 = unchecked((uint)0x8B5C),

    [NativeName("GL_SAMPLER_1D")]
    Sampler1D = unchecked((uint)0x8B5D),

    [NativeName("GL_SAMPLER_2D")]
    Sampler2D = unchecked((uint)0x8B5E),

    [NativeName("GL_SAMPLER_3D")]
    Sampler3D = unchecked((uint)0x8B5F),

    [NativeName("GL_SAMPLER_CUBE")]
    SamplerCube = unchecked((uint)0x8B60),

    [NativeName("GL_SAMPLER_1D_SHADOW")]
    Sampler1DShadow = unchecked((uint)0x8B61),

    [NativeName("GL_SAMPLER_2D_SHADOW")]
    Sampler2DShadow = unchecked((uint)0x8B62),

    [NativeName("GL_FLOAT_MAT2x3")]
    FloatMat2X3 = unchecked((uint)0x8B65),

    [NativeName("GL_FLOAT_MAT2x4")]
    FloatMat2X4 = unchecked((uint)0x8B66),

    [NativeName("GL_FLOAT_MAT3x2")]
    FloatMat3X2 = unchecked((uint)0x8B67),

    [NativeName("GL_FLOAT_MAT3x4")]
    FloatMat3X4 = unchecked((uint)0x8B68),

    [NativeName("GL_FLOAT_MAT4x2")]
    FloatMat4X2 = unchecked((uint)0x8B69),

    [NativeName("GL_FLOAT_MAT4x3")]
    FloatMat4X3 = unchecked((uint)0x8B6A),

    [NativeName("GL_SAMPLER_1D_ARRAY_SHADOW")]
    Sampler1DArrayShadow = unchecked((uint)0x8DC3),

    [NativeName("GL_SAMPLER_2D_ARRAY_SHADOW")]
    Sampler2DArrayShadow = unchecked((uint)0x8DC4),

    [NativeName("GL_SAMPLER_CUBE_SHADOW")]
    SamplerCubeShadow = unchecked((uint)0x8DC5),

    [NativeName("GL_UNSIGNED_INT_VEC2")]
    UnsignedIntVec2 = unchecked((uint)0x8DC6),

    [NativeName("GL_UNSIGNED_INT_VEC3")]
    UnsignedIntVec3 = unchecked((uint)0x8DC7),

    [NativeName("GL_UNSIGNED_INT_VEC4")]
    UnsignedIntVec4 = unchecked((uint)0x8DC8),

    [NativeName("GL_INT_SAMPLER_1D")]
    IntSampler1D = unchecked((uint)0x8DC9),

    [NativeName("GL_INT_SAMPLER_2D")]
    IntSampler2D = unchecked((uint)0x8DCA),

    [NativeName("GL_INT_SAMPLER_3D")]
    IntSampler3D = unchecked((uint)0x8DCB),

    [NativeName("GL_INT_SAMPLER_CUBE")]
    IntSamplerCube = unchecked((uint)0x8DCC),

    [NativeName("GL_INT_SAMPLER_1D_ARRAY")]
    IntSampler1DArray = unchecked((uint)0x8DCE),

    [NativeName("GL_INT_SAMPLER_2D_ARRAY")]
    IntSampler2DArray = unchecked((uint)0x8DCF),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D")]
    UnsignedIntSampler1D = unchecked((uint)0x8DD1),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D")]
    UnsignedIntSampler2D = unchecked((uint)0x8DD2),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_3D")]
    UnsignedIntSampler3D = unchecked((uint)0x8DD3),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE")]
    UnsignedIntSamplerCube = unchecked((uint)0x8DD4),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY")]
    UnsignedIntSampler1DArray = unchecked((uint)0x8DD6),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY")]
    UnsignedIntSampler2DArray = unchecked((uint)0x8DD7),

    [NativeName("GL_SAMPLER_2D_RECT")]
    Sampler2DRect = unchecked((uint)0x8B63),

    [NativeName("GL_SAMPLER_2D_RECT_SHADOW")]
    Sampler2DRectShadow = unchecked((uint)0x8B64),

    [NativeName("GL_SAMPLER_BUFFER")]
    SamplerBuffer = unchecked((uint)0x8DC2),

    [NativeName("GL_INT_SAMPLER_2D_RECT")]
    IntSampler2DRect = unchecked((uint)0x8DCD),

    [NativeName("GL_INT_SAMPLER_BUFFER")]
    IntSamplerBuffer = unchecked((uint)0x8DD0),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_RECT")]
    UnsignedIntSampler2DRect = unchecked((uint)0x8DD5),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_BUFFER")]
    UnsignedIntSamplerBuffer = unchecked((uint)0x8DD8),

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE")]
    Sampler2DMultisample = unchecked((uint)0x9108),

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE")]
    IntSampler2DMultisample = unchecked((uint)0x9109),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
    UnsignedIntSampler2DMultisample = unchecked((uint)0x910A),

    [NativeName("GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    Sampler2DMultisampleArray = unchecked((uint)0x910B),

    [NativeName("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    IntSampler2DMultisampleArray = unchecked((uint)0x910C),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntSampler2DMultisampleArray = unchecked((uint)0x910D),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY")]
    SamplerCubeMapArray = unchecked((uint)0x900C),

    [NativeName("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW")]
    SamplerCubeMapArrayShadow = unchecked((uint)0x900D),

    [NativeName("GL_INT_SAMPLER_CUBE_MAP_ARRAY")]
    IntSamplerCubeMapArray = unchecked((uint)0x900E),

    [NativeName("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY")]
    UnsignedIntSamplerCubeMapArray = unchecked((uint)0x900F),

    [NativeName("GL_DOUBLE_VEC2")]
    DoubleVec2 = unchecked((uint)0x8FFC),

    [NativeName("GL_DOUBLE_VEC3")]
    DoubleVec3 = unchecked((uint)0x8FFD),

    [NativeName("GL_DOUBLE_VEC4")]
    DoubleVec4 = unchecked((uint)0x8FFE),

    [NativeName("GL_DOUBLE_MAT2")]
    DoubleMat2 = unchecked((uint)0x8F46),

    [NativeName("GL_DOUBLE_MAT3")]
    DoubleMat3 = unchecked((uint)0x8F47),

    [NativeName("GL_DOUBLE_MAT4")]
    DoubleMat4 = unchecked((uint)0x8F48),

    [NativeName("GL_DOUBLE_MAT2x3")]
    DoubleMat2X3 = unchecked((uint)0x8F49),

    [NativeName("GL_DOUBLE_MAT2x4")]
    DoubleMat2X4 = unchecked((uint)0x8F4A),

    [NativeName("GL_DOUBLE_MAT3x2")]
    DoubleMat3X2 = unchecked((uint)0x8F4B),

    [NativeName("GL_DOUBLE_MAT3x4")]
    DoubleMat3X4 = unchecked((uint)0x8F4C),

    [NativeName("GL_DOUBLE_MAT4x2")]
    DoubleMat4X2 = unchecked((uint)0x8F4D),

    [NativeName("GL_DOUBLE_MAT4x3")]
    DoubleMat4X3 = unchecked((uint)0x8F4E),

    [NativeName("GL_IMAGE_1D")]
    Image1D = unchecked((uint)0x904C),

    [NativeName("GL_IMAGE_2D")]
    Image2D = unchecked((uint)0x904D),

    [NativeName("GL_IMAGE_3D")]
    Image3D = unchecked((uint)0x904E),

    [NativeName("GL_IMAGE_2D_RECT")]
    Image2DRect = unchecked((uint)0x904F),

    [NativeName("GL_IMAGE_CUBE")]
    ImageCube = unchecked((uint)0x9050),

    [NativeName("GL_IMAGE_BUFFER")]
    ImageBuffer = unchecked((uint)0x9051),

    [NativeName("GL_IMAGE_1D_ARRAY")]
    Image1DArray = unchecked((uint)0x9052),

    [NativeName("GL_IMAGE_2D_ARRAY")]
    Image2DArray = unchecked((uint)0x9053),

    [NativeName("GL_IMAGE_CUBE_MAP_ARRAY")]
    ImageCubeMapArray = unchecked((uint)0x9054),

    [NativeName("GL_IMAGE_2D_MULTISAMPLE")]
    Image2DMultisample = unchecked((uint)0x9055),

    [NativeName("GL_IMAGE_2D_MULTISAMPLE_ARRAY")]
    Image2DMultisampleArray = unchecked((uint)0x9056),

    [NativeName("GL_INT_IMAGE_1D")]
    IntImage1D = unchecked((uint)0x9057),

    [NativeName("GL_INT_IMAGE_2D")]
    IntImage2D = unchecked((uint)0x9058),

    [NativeName("GL_INT_IMAGE_3D")]
    IntImage3D = unchecked((uint)0x9059),

    [NativeName("GL_INT_IMAGE_2D_RECT")]
    IntImage2DRect = unchecked((uint)0x905A),

    [NativeName("GL_INT_IMAGE_CUBE")]
    IntImageCube = unchecked((uint)0x905B),

    [NativeName("GL_INT_IMAGE_BUFFER")]
    IntImageBuffer = unchecked((uint)0x905C),

    [NativeName("GL_INT_IMAGE_1D_ARRAY")]
    IntImage1DArray = unchecked((uint)0x905D),

    [NativeName("GL_INT_IMAGE_2D_ARRAY")]
    IntImage2DArray = unchecked((uint)0x905E),

    [NativeName("GL_INT_IMAGE_CUBE_MAP_ARRAY")]
    IntImageCubeMapArray = unchecked((uint)0x905F),

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE")]
    IntImage2DMultisample = unchecked((uint)0x9060),

    [NativeName("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    IntImage2DMultisampleArray = unchecked((uint)0x9061),

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D")]
    UnsignedIntImage1D = unchecked((uint)0x9062),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D")]
    UnsignedIntImage2D = unchecked((uint)0x9063),

    [NativeName("GL_UNSIGNED_INT_IMAGE_3D")]
    UnsignedIntImage3D = unchecked((uint)0x9064),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_RECT")]
    UnsignedIntImage2DRect = unchecked((uint)0x9065),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE")]
    UnsignedIntImageCube = unchecked((uint)0x9066),

    [NativeName("GL_UNSIGNED_INT_IMAGE_BUFFER")]
    UnsignedIntImageBuffer = unchecked((uint)0x9067),

    [NativeName("GL_UNSIGNED_INT_IMAGE_1D_ARRAY")]
    UnsignedIntImage1DArray = unchecked((uint)0x9068),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
    UnsignedIntImage2DArray = unchecked((uint)0x9069),

    [NativeName("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
    UnsignedIntImageCubeMapArray = unchecked((uint)0x906A),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE")]
    UnsignedIntImage2DMultisample = unchecked((uint)0x906B),

    [NativeName("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
    UnsignedIntImage2DMultisampleArray = unchecked((uint)0x906C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64ARB = unchecked((uint)0x140F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_ARB")]
    Int64ARB = unchecked((uint)0x140E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_VEC2_ARB")]
    Int64Vec2ARB = unchecked((uint)0x8FE9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_VEC3_ARB")]
    Int64Vec3ARB = unchecked((uint)0x8FEA),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_VEC4_ARB")]
    Int64Vec4ARB = unchecked((uint)0x8FEB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC2_ARB")]
    UnsignedInt64Vec2ARB = unchecked((uint)0x8FF5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC3_ARB")]
    UnsignedInt64Vec3ARB = unchecked((uint)0x8FF6),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_VEC4_ARB")]
    UnsignedInt64Vec4ARB = unchecked((uint)0x8FF7),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_VEC2_ARB")]
    FloatVec2ARB = unchecked((uint)0x8B50),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_VEC3_ARB")]
    FloatVec3ARB = unchecked((uint)0x8B51),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_VEC4_ARB")]
    FloatVec4ARB = unchecked((uint)0x8B52),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_VEC2_ARB")]
    IntVec2ARB = unchecked((uint)0x8B53),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_VEC3_ARB")]
    IntVec3ARB = unchecked((uint)0x8B54),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT_VEC4_ARB")]
    IntVec4ARB = unchecked((uint)0x8B55),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_ARB")]
    BoolARB = unchecked((uint)0x8B56),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_VEC2_ARB")]
    BoolVec2ARB = unchecked((uint)0x8B57),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_VEC3_ARB")]
    BoolVec3ARB = unchecked((uint)0x8B58),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BOOL_VEC4_ARB")]
    BoolVec4ARB = unchecked((uint)0x8B59),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_MAT2_ARB")]
    FloatMat2ARB = unchecked((uint)0x8B5A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_MAT3_ARB")]
    FloatMat3ARB = unchecked((uint)0x8B5B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FLOAT_MAT4_ARB")]
    FloatMat4ARB = unchecked((uint)0x8B5C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_1D_ARB")]
    Sampler1DARB = unchecked((uint)0x8B5D),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_ARB")]
    Sampler2DARB = unchecked((uint)0x8B5E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_3D_ARB")]
    Sampler3DARB = unchecked((uint)0x8B5F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_CUBE_ARB")]
    SamplerCubeARB = unchecked((uint)0x8B60),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_1D_SHADOW_ARB")]
    Sampler1DShadowARB = unchecked((uint)0x8B61),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_SHADOW_ARB")]
    Sampler2DShadowARB = unchecked((uint)0x8B62),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_RECT_ARB")]
    Sampler2DRectARB = unchecked((uint)0x8B63),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SAMPLER_2D_RECT_SHADOW_ARB")]
    Sampler2DRectShadowARB = unchecked((uint)0x8B64),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT64_NV")]
    Int64NV = unchecked((uint)0x140E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64NV = unchecked((uint)0x140F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_SAMPLER_3D_OES")]
    Sampler3DOES = unchecked((uint)0x8B5F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SAMPLER_2D_SHADOW_EXT")]
    Sampler2DShadowEXT = unchecked((uint)0x8B62),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT2x3_NV")]
    FloatMat2X3NV = unchecked((uint)0x8B65),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT2x4_NV")]
    FloatMat2X4NV = unchecked((uint)0x8B66),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT3x2_NV")]
    FloatMat3X2NV = unchecked((uint)0x8B67),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT3x4_NV")]
    FloatMat3X4NV = unchecked((uint)0x8B68),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT4x2_NV")]
    FloatMat4X2NV = unchecked((uint)0x8B69),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_MAT4x3_NV")]
    FloatMat4X3NV = unchecked((uint)0x8B6A),
}
