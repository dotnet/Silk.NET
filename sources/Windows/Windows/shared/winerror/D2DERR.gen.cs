// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

public static partial class D2DERR
{
    [NativeTypeName("#define D2DERR_WRONG_STATE _HRESULT_TYPEDEF_(0x88990001L)")]
    public const int D2DERR_WRONG_STATE = unchecked((int)(0x88990001));

    [NativeTypeName("#define D2DERR_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x88990002L)")]
    public const int D2DERR_NOT_INITIALIZED = unchecked((int)(0x88990002));

    [NativeTypeName("#define D2DERR_UNSUPPORTED_OPERATION _HRESULT_TYPEDEF_(0x88990003L)")]
    public const int D2DERR_UNSUPPORTED_OPERATION = unchecked((int)(0x88990003));

    [NativeTypeName("#define D2DERR_SCANNER_FAILED _HRESULT_TYPEDEF_(0x88990004L)")]
    public const int D2DERR_SCANNER_FAILED = unchecked((int)(0x88990004));

    [NativeTypeName("#define D2DERR_SCREEN_ACCESS_DENIED _HRESULT_TYPEDEF_(0x88990005L)")]
    public const int D2DERR_SCREEN_ACCESS_DENIED = unchecked((int)(0x88990005));

    [NativeTypeName("#define D2DERR_DISPLAY_STATE_INVALID _HRESULT_TYPEDEF_(0x88990006L)")]
    public const int D2DERR_DISPLAY_STATE_INVALID = unchecked((int)(0x88990006));

    [NativeTypeName("#define D2DERR_ZERO_VECTOR _HRESULT_TYPEDEF_(0x88990007L)")]
    public const int D2DERR_ZERO_VECTOR = unchecked((int)(0x88990007));

    [NativeTypeName("#define D2DERR_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x88990008L)")]
    public const int D2DERR_INTERNAL_ERROR = unchecked((int)(0x88990008));

    [NativeTypeName("#define D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88990009L)")]
    public const int D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED = unchecked((int)(0x88990009));

    [NativeTypeName("#define D2DERR_INVALID_CALL _HRESULT_TYPEDEF_(0x8899000AL)")]
    public const int D2DERR_INVALID_CALL = unchecked((int)(0x8899000A));

    [NativeTypeName("#define D2DERR_NO_HARDWARE_DEVICE _HRESULT_TYPEDEF_(0x8899000BL)")]
    public const int D2DERR_NO_HARDWARE_DEVICE = unchecked((int)(0x8899000B));

    [NativeTypeName("#define D2DERR_RECREATE_TARGET _HRESULT_TYPEDEF_(0x8899000CL)")]
    public const int D2DERR_RECREATE_TARGET = unchecked((int)(0x8899000C));

    [NativeTypeName("#define D2DERR_TOO_MANY_SHADER_ELEMENTS _HRESULT_TYPEDEF_(0x8899000DL)")]
    public const int D2DERR_TOO_MANY_SHADER_ELEMENTS = unchecked((int)(0x8899000D));

    [NativeTypeName("#define D2DERR_SHADER_COMPILE_FAILED _HRESULT_TYPEDEF_(0x8899000EL)")]
    public const int D2DERR_SHADER_COMPILE_FAILED = unchecked((int)(0x8899000E));

    [NativeTypeName("#define D2DERR_MAX_TEXTURE_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x8899000FL)")]
    public const int D2DERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)(0x8899000F));

    [NativeTypeName("#define D2DERR_UNSUPPORTED_VERSION _HRESULT_TYPEDEF_(0x88990010L)")]
    public const int D2DERR_UNSUPPORTED_VERSION = unchecked((int)(0x88990010));

    [NativeTypeName("#define D2DERR_BAD_NUMBER _HRESULT_TYPEDEF_(0x88990011L)")]
    public const int D2DERR_BAD_NUMBER = unchecked((int)(0x88990011));

    [NativeTypeName("#define D2DERR_WRONG_FACTORY _HRESULT_TYPEDEF_(0x88990012L)")]
    public const int D2DERR_WRONG_FACTORY = unchecked((int)(0x88990012));

    [NativeTypeName("#define D2DERR_LAYER_ALREADY_IN_USE _HRESULT_TYPEDEF_(0x88990013L)")]
    public const int D2DERR_LAYER_ALREADY_IN_USE = unchecked((int)(0x88990013));

    [NativeTypeName("#define D2DERR_POP_CALL_DID_NOT_MATCH_PUSH _HRESULT_TYPEDEF_(0x88990014L)")]
    public const int D2DERR_POP_CALL_DID_NOT_MATCH_PUSH = unchecked((int)(0x88990014));

    [NativeTypeName("#define D2DERR_WRONG_RESOURCE_DOMAIN _HRESULT_TYPEDEF_(0x88990015L)")]
    public const int D2DERR_WRONG_RESOURCE_DOMAIN = unchecked((int)(0x88990015));

    [NativeTypeName("#define D2DERR_PUSH_POP_UNBALANCED _HRESULT_TYPEDEF_(0x88990016L)")]
    public const int D2DERR_PUSH_POP_UNBALANCED = unchecked((int)(0x88990016));

    [NativeTypeName("#define D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT _HRESULT_TYPEDEF_(0x88990017L)")]
    public const int D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT = unchecked((int)(0x88990017));

    [NativeTypeName("#define D2DERR_INCOMPATIBLE_BRUSH_TYPES _HRESULT_TYPEDEF_(0x88990018L)")]
    public const int D2DERR_INCOMPATIBLE_BRUSH_TYPES = unchecked((int)(0x88990018));

    [NativeTypeName("#define D2DERR_WIN32_ERROR _HRESULT_TYPEDEF_(0x88990019L)")]
    public const int D2DERR_WIN32_ERROR = unchecked((int)(0x88990019));

    [NativeTypeName("#define D2DERR_TARGET_NOT_GDI_COMPATIBLE _HRESULT_TYPEDEF_(0x8899001AL)")]
    public const int D2DERR_TARGET_NOT_GDI_COMPATIBLE = unchecked((int)(0x8899001A));

    [NativeTypeName("#define D2DERR_TEXT_EFFECT_IS_WRONG_TYPE _HRESULT_TYPEDEF_(0x8899001BL)")]
    public const int D2DERR_TEXT_EFFECT_IS_WRONG_TYPE = unchecked((int)(0x8899001B));

    [NativeTypeName("#define D2DERR_TEXT_RENDERER_NOT_RELEASED _HRESULT_TYPEDEF_(0x8899001CL)")]
    public const int D2DERR_TEXT_RENDERER_NOT_RELEASED = unchecked((int)(0x8899001C));

    [NativeTypeName("#define D2DERR_EXCEEDS_MAX_BITMAP_SIZE _HRESULT_TYPEDEF_(0x8899001DL)")]
    public const int D2DERR_EXCEEDS_MAX_BITMAP_SIZE = unchecked((int)(0x8899001D));

    [NativeTypeName("#define D2DERR_INVALID_GRAPH_CONFIGURATION _HRESULT_TYPEDEF_(0x8899001EL)")]
    public const int D2DERR_INVALID_GRAPH_CONFIGURATION = unchecked((int)(0x8899001E));

    [NativeTypeName("#define D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION _HRESULT_TYPEDEF_(0x8899001FL)")]
    public const int D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION = unchecked((int)(0x8899001F));

    [NativeTypeName("#define D2DERR_CYCLIC_GRAPH _HRESULT_TYPEDEF_(0x88990020L)")]
    public const int D2DERR_CYCLIC_GRAPH = unchecked((int)(0x88990020));

    [NativeTypeName("#define D2DERR_BITMAP_CANNOT_DRAW _HRESULT_TYPEDEF_(0x88990021L)")]
    public const int D2DERR_BITMAP_CANNOT_DRAW = unchecked((int)(0x88990021));

    [NativeTypeName("#define D2DERR_OUTSTANDING_BITMAP_REFERENCES _HRESULT_TYPEDEF_(0x88990022L)")]
    public const int D2DERR_OUTSTANDING_BITMAP_REFERENCES = unchecked((int)(0x88990022));

    [NativeTypeName("#define D2DERR_ORIGINAL_TARGET_NOT_BOUND _HRESULT_TYPEDEF_(0x88990023L)")]
    public const int D2DERR_ORIGINAL_TARGET_NOT_BOUND = unchecked((int)(0x88990023));

    [NativeTypeName("#define D2DERR_INVALID_TARGET _HRESULT_TYPEDEF_(0x88990024L)")]
    public const int D2DERR_INVALID_TARGET = unchecked((int)(0x88990024));

    [NativeTypeName("#define D2DERR_BITMAP_BOUND_AS_TARGET _HRESULT_TYPEDEF_(0x88990025L)")]
    public const int D2DERR_BITMAP_BOUND_AS_TARGET = unchecked((int)(0x88990025));

    [NativeTypeName("#define D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES _HRESULT_TYPEDEF_(0x88990026L)")]
    public const int D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES = unchecked((int)(0x88990026));

    [NativeTypeName("#define D2DERR_INTERMEDIATE_TOO_LARGE _HRESULT_TYPEDEF_(0x88990027L)")]
    public const int D2DERR_INTERMEDIATE_TOO_LARGE = unchecked((int)(0x88990027));

    [NativeTypeName("#define D2DERR_EFFECT_IS_NOT_REGISTERED _HRESULT_TYPEDEF_(0x88990028L)")]
    public const int D2DERR_EFFECT_IS_NOT_REGISTERED = unchecked((int)(0x88990028));

    [NativeTypeName("#define D2DERR_INVALID_PROPERTY _HRESULT_TYPEDEF_(0x88990029L)")]
    public const int D2DERR_INVALID_PROPERTY = unchecked((int)(0x88990029));

    [NativeTypeName("#define D2DERR_NO_SUBPROPERTIES _HRESULT_TYPEDEF_(0x8899002AL)")]
    public const int D2DERR_NO_SUBPROPERTIES = unchecked((int)(0x8899002A));

    [NativeTypeName("#define D2DERR_PRINT_JOB_CLOSED _HRESULT_TYPEDEF_(0x8899002BL)")]
    public const int D2DERR_PRINT_JOB_CLOSED = unchecked((int)(0x8899002B));

    [NativeTypeName("#define D2DERR_PRINT_FORMAT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8899002CL)")]
    public const int D2DERR_PRINT_FORMAT_NOT_SUPPORTED = unchecked((int)(0x8899002C));

    [NativeTypeName("#define D2DERR_TOO_MANY_TRANSFORM_INPUTS _HRESULT_TYPEDEF_(0x8899002DL)")]
    public const int D2DERR_TOO_MANY_TRANSFORM_INPUTS = unchecked((int)(0x8899002D));

    [NativeTypeName("#define D2DERR_INVALID_GLYPH_IMAGE _HRESULT_TYPEDEF_(0x8899002EL)")]
    public const int D2DERR_INVALID_GLYPH_IMAGE = unchecked((int)(0x8899002E));
}
