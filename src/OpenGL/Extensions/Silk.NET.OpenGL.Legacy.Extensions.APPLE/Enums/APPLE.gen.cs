// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [NativeName("Name", "GLenum")]
    public enum APPLE : int
    {
        [NativeName("Name", "GL_AUX_DEPTH_STENCIL_APPLE")]
        AuxDepthStencilApple = 0x8A14,
        [NativeName("Name", "GL_UNPACK_CLIENT_STORAGE_APPLE")]
        UnpackClientStorageApple = 0x85B2,
        [NativeName("Name", "GL_ELEMENT_ARRAY_APPLE")]
        ElementArrayApple = 0x8A0C,
        [NativeName("Name", "GL_ELEMENT_ARRAY_TYPE_APPLE")]
        ElementArrayTypeApple = 0x8A0D,
        [NativeName("Name", "GL_ELEMENT_ARRAY_POINTER_APPLE")]
        ElementArrayPointerApple = 0x8A0E,
        [NativeName("Name", "GL_DRAW_PIXELS_APPLE")]
        DrawPixelsApple = 0x8A0A,
        [NativeName("Name", "GL_FENCE_APPLE")]
        FenceApple = 0x8A0B,
        [NativeName("Name", "GL_HALF_APPLE")]
        HalfApple = 0x140B,
        [NativeName("Name", "GL_RGBA_FLOAT32_APPLE")]
        RgbaFloat32Apple = 0x8814,
        [NativeName("Name", "GL_RGB_FLOAT32_APPLE")]
        RgbFloat32Apple = 0x8815,
        [NativeName("Name", "GL_ALPHA_FLOAT32_APPLE")]
        AlphaFloat32Apple = 0x8816,
        [NativeName("Name", "GL_INTENSITY_FLOAT32_APPLE")]
        IntensityFloat32Apple = 0x8817,
        [NativeName("Name", "GL_LUMINANCE_FLOAT32_APPLE")]
        LuminanceFloat32Apple = 0x8818,
        [NativeName("Name", "GL_LUMINANCE_ALPHA_FLOAT32_APPLE")]
        LuminanceAlphaFloat32Apple = 0x8819,
        [NativeName("Name", "GL_RGBA_FLOAT16_APPLE")]
        RgbaFloat16Apple = 0x881A,
        [NativeName("Name", "GL_RGB_FLOAT16_APPLE")]
        RgbFloat16Apple = 0x881B,
        [NativeName("Name", "GL_ALPHA_FLOAT16_APPLE")]
        AlphaFloat16Apple = 0x881C,
        [NativeName("Name", "GL_INTENSITY_FLOAT16_APPLE")]
        IntensityFloat16Apple = 0x881D,
        [NativeName("Name", "GL_LUMINANCE_FLOAT16_APPLE")]
        LuminanceFloat16Apple = 0x881E,
        [NativeName("Name", "GL_LUMINANCE_ALPHA_FLOAT16_APPLE")]
        LuminanceAlphaFloat16Apple = 0x881F,
        [NativeName("Name", "GL_COLOR_FLOAT_APPLE")]
        ColorFloatApple = 0x8A0F,
        [NativeName("Name", "GL_BUFFER_SERIALIZED_MODIFY_APPLE")]
        BufferSerializedModifyApple = 0x8A12,
        [NativeName("Name", "GL_BUFFER_FLUSHING_UNMAP_APPLE")]
        BufferFlushingUnmapApple = 0x8A13,
        [NativeName("Name", "GL_BUFFER_OBJECT_APPLE")]
        BufferObjectApple = 0x85B3,
        [NativeName("Name", "GL_RELEASED_APPLE")]
        ReleasedApple = 0x8A19,
        [NativeName("Name", "GL_VOLATILE_APPLE")]
        VolatileApple = 0x8A1A,
        [NativeName("Name", "GL_RETAINED_APPLE")]
        RetainedApple = 0x8A1B,
        [NativeName("Name", "GL_UNDEFINED_APPLE")]
        UndefinedApple = 0x8A1C,
        [NativeName("Name", "GL_PURGEABLE_APPLE")]
        PurgeableApple = 0x8A1D,
        [NativeName("Name", "GL_RGB_422_APPLE")]
        Rgb422Apple = 0x8A1F,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_APPLE")]
        UnsignedShort88Apple = 0x85BA,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_REV_APPLE")]
        UnsignedShort88RevApple = 0x85BB,
        [NativeName("Name", "GL_RGB_RAW_422_APPLE")]
        RgbRaw422Apple = 0x8A51,
        [NativeName("Name", "GL_PACK_ROW_BYTES_APPLE")]
        PackRowBytesApple = 0x8A15,
        [NativeName("Name", "GL_UNPACK_ROW_BYTES_APPLE")]
        UnpackRowBytesApple = 0x8A16,
        [NativeName("Name", "GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE")]
        LightModelSpecularVectorApple = 0x85B0,
        [NativeName("Name", "GL_TEXTURE_RANGE_LENGTH_APPLE")]
        TextureRangeLengthApple = 0x85B7,
        [NativeName("Name", "GL_TEXTURE_RANGE_POINTER_APPLE")]
        TextureRangePointerApple = 0x85B8,
        [NativeName("Name", "GL_TEXTURE_STORAGE_HINT_APPLE")]
        TextureStorageHintApple = 0x85BC,
        [NativeName("Name", "GL_STORAGE_PRIVATE_APPLE")]
        StoragePrivateApple = 0x85BD,
        [NativeName("Name", "GL_STORAGE_CACHED_APPLE")]
        StorageCachedApple = 0x85BE,
        [NativeName("Name", "GL_STORAGE_SHARED_APPLE")]
        StorageSharedApple = 0x85BF,
        [NativeName("Name", "GL_TRANSFORM_HINT_APPLE")]
        TransformHintApple = 0x85B1,
        [NativeName("Name", "GL_VERTEX_ARRAY_BINDING_APPLE")]
        VertexArrayBindingApple = 0x85B5,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_APPLE")]
        VertexArrayRangeApple = 0x851D,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE")]
        VertexArrayRangeLengthApple = 0x851E,
        [NativeName("Name", "GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
        VertexArrayStorageHintApple = 0x851F,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_POINTER_APPLE")]
        VertexArrayRangePointerApple = 0x8521,
        [NativeName("Name", "GL_STORAGE_CLIENT_APPLE")]
        StorageClientApple = 0x85B4,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP1_APPLE")]
        VertexAttribMap1Apple = 0x8A00,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP2_APPLE")]
        VertexAttribMap2Apple = 0x8A01,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE")]
        VertexAttribMap1SizeApple = 0x8A02,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE")]
        VertexAttribMap1CoeffApple = 0x8A03,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE")]
        VertexAttribMap1OrderApple = 0x8A04,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE")]
        VertexAttribMap1DomainApple = 0x8A05,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE")]
        VertexAttribMap2SizeApple = 0x8A06,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE")]
        VertexAttribMap2CoeffApple = 0x8A07,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE")]
        VertexAttribMap2OrderApple = 0x8A08,
        [NativeName("Name", "GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE")]
        VertexAttribMap2DomainApple = 0x8A09,
        [NativeName("Name", "GL_YCBCR_422_APPLE")]
        Ycbcr422Apple = 0x85B9,
    }
}
