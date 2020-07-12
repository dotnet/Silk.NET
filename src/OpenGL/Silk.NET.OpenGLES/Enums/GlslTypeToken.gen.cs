// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GlslTypeToken")]
    public enum GlslTypeToken
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
        [NativeName("Name", "GL_IMAGE_1D")]
        Image1D = 0x904C,
        [NativeName("Name", "GL_IMAGE_2D")]
        Image2D = 0x904D,
        [NativeName("Name", "GL_IMAGE_3D")]
        Image3D = 0x904E,
        [NativeName("Name", "GL_IMAGE_2D_RECT")]
        Image2DRect = 0x904F,
        [NativeName("Name", "GL_IMAGE_CUBE")]
        ImageCube = 0x9050,
        [NativeName("Name", "GL_IMAGE_BUFFER")]
        ImageBuffer = 0x9051,
        [NativeName("Name", "GL_IMAGE_1D_ARRAY")]
        Image1DArray = 0x9052,
        [NativeName("Name", "GL_IMAGE_2D_ARRAY")]
        Image2DArray = 0x9053,
        [NativeName("Name", "GL_IMAGE_CUBE_MAP_ARRAY")]
        ImageCubeMapArray = 0x9054,
        [NativeName("Name", "GL_IMAGE_2D_MULTISAMPLE")]
        Image2DMultisample = 0x9055,
        [NativeName("Name", "GL_IMAGE_2D_MULTISAMPLE_ARRAY")]
        Image2DMultisampleArray = 0x9056,
        [NativeName("Name", "GL_INT_IMAGE_1D")]
        IntImage1D = 0x9057,
        [NativeName("Name", "GL_INT_IMAGE_2D")]
        IntImage2D = 0x9058,
        [NativeName("Name", "GL_INT_IMAGE_3D")]
        IntImage3D = 0x9059,
        [NativeName("Name", "GL_INT_IMAGE_2D_RECT")]
        IntImage2DRect = 0x905A,
        [NativeName("Name", "GL_INT_IMAGE_CUBE")]
        IntImageCube = 0x905B,
        [NativeName("Name", "GL_INT_IMAGE_BUFFER")]
        IntImageBuffer = 0x905C,
        [NativeName("Name", "GL_INT_IMAGE_1D_ARRAY")]
        IntImage1DArray = 0x905D,
        [NativeName("Name", "GL_INT_IMAGE_2D_ARRAY")]
        IntImage2DArray = 0x905E,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_MAP_ARRAY")]
        IntImageCubeMapArray = 0x905F,
        [NativeName("Name", "GL_INT_IMAGE_2D_MULTISAMPLE")]
        IntImage2DMultisample = 0x9060,
        [NativeName("Name", "GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
        IntImage2DMultisampleArray = 0x9061,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_1D")]
        UnsignedIntImage1D = 0x9062,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D")]
        UnsignedIntImage2D = 0x9063,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_3D")]
        UnsignedIntImage3D = 0x9064,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_RECT")]
        UnsignedIntImage2DRect = 0x9065,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE")]
        UnsignedIntImageCube = 0x9066,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_BUFFER")]
        UnsignedIntImageBuffer = 0x9067,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_1D_ARRAY")]
        UnsignedIntImage1DArray = 0x9068,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
        UnsignedIntImage2DArray = 0x9069,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
        UnsignedIntImageCubeMapArray = 0x906A,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE")]
        UnsignedIntImage2DMultisample = 0x906B,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
        UnsignedIntImage2DMultisampleArray = 0x906C,
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
        [NativeName("Name", "GL_UNSIGNED_INT_ATOMIC_COUNTER")]
        UnsignedIntAtomicCounter = 0x92DB,
    }
}
