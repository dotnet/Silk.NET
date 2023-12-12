// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetPName")]
    public enum GetPName : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_COLOR")]
        CurrentColor = 0xB00,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_INDEX")]
        CurrentIndex = 0xB01,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_NORMAL")]
        CurrentNormal = 0xB02,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_TEXTURE_COORDS")]
        CurrentTextureCoords = 0xB03,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_RASTER_COLOR")]
        CurrentRasterColor = 0xB04,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_RASTER_INDEX")]
        CurrentRasterIndex = 0xB05,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_RASTER_TEXTURE_COORDS")]
        CurrentRasterTextureCoords = 0xB06,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_RASTER_POSITION")]
        CurrentRasterPosition = 0xB07,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_RASTER_POSITION_VALID")]
        CurrentRasterPositionValid = 0xB08,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_RASTER_DISTANCE")]
        CurrentRasterDistance = 0xB09,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SMOOTH")]
        PointSmooth = 0xB10,
        [NativeName("Name", "GL_POINT_SIZE")]
        PointSize = 0xB11,
        [NativeName("Name", "GL_POINT_SIZE_RANGE")]
        PointSizeRange = 0xB12,
        [NativeName("Name", "GL_SMOOTH_POINT_SIZE_RANGE")]
        SmoothPointSizeRange = 0xB12,
        [NativeName("Name", "GL_POINT_SIZE_GRANULARITY")]
        PointSizeGranularity = 0xB13,
        [NativeName("Name", "GL_SMOOTH_POINT_SIZE_GRANULARITY")]
        SmoothPointSizeGranularity = 0xB13,
        [NativeName("Name", "GL_LINE_SMOOTH")]
        LineSmooth = 0xB20,
        [NativeName("Name", "GL_LINE_WIDTH")]
        LineWidth = 0xB21,
        [NativeName("Name", "GL_LINE_WIDTH_RANGE")]
        LineWidthRange = 0xB22,
        [NativeName("Name", "GL_SMOOTH_LINE_WIDTH_RANGE")]
        SmoothLineWidthRange = 0xB22,
        [NativeName("Name", "GL_LINE_WIDTH_GRANULARITY")]
        LineWidthGranularity = 0xB23,
        [NativeName("Name", "GL_SMOOTH_LINE_WIDTH_GRANULARITY")]
        SmoothLineWidthGranularity = 0xB23,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LINE_STIPPLE")]
        LineStipple = 0xB24,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LINE_STIPPLE_PATTERN")]
        LineStipplePattern = 0xB25,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LINE_STIPPLE_REPEAT")]
        LineStippleRepeat = 0xB26,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIST_MODE")]
        ListMode = 0xB30,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_LIST_NESTING")]
        MaxListNesting = 0xB31,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIST_BASE")]
        ListBase = 0xB32,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIST_INDEX")]
        ListIndex = 0xB33,
        [NativeName("Name", "GL_POLYGON_MODE")]
        PolygonMode = 0xB40,
        [NativeName("Name", "GL_POLYGON_SMOOTH")]
        PolygonSmooth = 0xB41,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POLYGON_STIPPLE")]
        PolygonStipple = 0xB42,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EDGE_FLAG")]
        EdgeFlag = 0xB43,
        [NativeName("Name", "GL_CULL_FACE")]
        CullFace = 0xB44,
        [NativeName("Name", "GL_CULL_FACE_MODE")]
        CullFaceMode = 0xB45,
        [NativeName("Name", "GL_FRONT_FACE")]
        FrontFace = 0xB46,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHTING")]
        Lighting = 0xB50,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_LOCAL_VIEWER")]
        LightModelLocalViewer = 0xB51,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_TWO_SIDE")]
        LightModelTwoSide = 0xB52,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_AMBIENT")]
        LightModelAmbient = 0xB53,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SHADE_MODEL")]
        ShadeModel = 0xB54,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_MATERIAL_FACE")]
        ColorMaterialFace = 0xB55,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_MATERIAL_PARAMETER")]
        ColorMaterialParameter = 0xB56,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_MATERIAL")]
        ColorMaterial = 0xB57,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG")]
        Fog = 0xB60,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_INDEX")]
        FogIndex = 0xB61,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_DENSITY")]
        FogDensity = 0xB62,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_START")]
        FogStart = 0xB63,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_END")]
        FogEnd = 0xB64,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_MODE")]
        FogMode = 0xB65,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_COLOR")]
        FogColor = 0xB66,
        [NativeName("Name", "GL_DEPTH_RANGE")]
        DepthRange = 0xB70,
        [NativeName("Name", "GL_DEPTH_TEST")]
        DepthTest = 0xB71,
        [NativeName("Name", "GL_DEPTH_WRITEMASK")]
        DepthWritemask = 0xB72,
        [NativeName("Name", "GL_DEPTH_CLEAR_VALUE")]
        DepthClearValue = 0xB73,
        [NativeName("Name", "GL_DEPTH_FUNC")]
        DepthFunc = 0xB74,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM_CLEAR_VALUE")]
        AccumClearValue = 0xB80,
        [NativeName("Name", "GL_STENCIL_TEST")]
        StencilTest = 0xB90,
        [NativeName("Name", "GL_STENCIL_CLEAR_VALUE")]
        StencilClearValue = 0xB91,
        [NativeName("Name", "GL_STENCIL_FUNC")]
        StencilFunc = 0xB92,
        [NativeName("Name", "GL_STENCIL_VALUE_MASK")]
        StencilValueMask = 0xB93,
        [NativeName("Name", "GL_STENCIL_FAIL")]
        StencilFail = 0xB94,
        [NativeName("Name", "GL_STENCIL_PASS_DEPTH_FAIL")]
        StencilPassDepthFail = 0xB95,
        [NativeName("Name", "GL_STENCIL_PASS_DEPTH_PASS")]
        StencilPassDepthPass = 0xB96,
        [NativeName("Name", "GL_STENCIL_REF")]
        StencilRef = 0xB97,
        [NativeName("Name", "GL_STENCIL_WRITEMASK")]
        StencilWritemask = 0xB98,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MATRIX_MODE")]
        MatrixMode = 0xBA0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMALIZE")]
        Normalize = 0xBA1,
        [NativeName("Name", "GL_VIEWPORT")]
        Viewport = 0xBA2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MODELVIEW_STACK_DEPTH")]
        ModelviewStackDepth = 0xBA3,
        [NativeName("Name", "GL_MODELVIEW0_STACK_DEPTH_EXT")]
        Modelview0StackDepthExt = 0xBA3,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PROJECTION_STACK_DEPTH")]
        ProjectionStackDepth = 0xBA4,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_STACK_DEPTH")]
        TextureStackDepth = 0xBA5,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MODELVIEW_MATRIX")]
        ModelviewMatrix = 0xBA6,
        [NativeName("Name", "GL_MODELVIEW0_MATRIX_EXT")]
        Modelview0MatrixExt = 0xBA6,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PROJECTION_MATRIX")]
        ProjectionMatrix = 0xBA7,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_MATRIX")]
        TextureMatrix = 0xBA8,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ATTRIB_STACK_DEPTH")]
        AttribStackDepth = 0xBB0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIENT_ATTRIB_STACK_DEPTH")]
        ClientAttribStackDepth = 0xBB1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_TEST")]
        AlphaTest = 0xBC0,
        [NativeName("Name", "GL_ALPHA_TEST_QCOM")]
        AlphaTestQCom = 0xBC0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_TEST_FUNC")]
        AlphaTestFunc = 0xBC1,
        [NativeName("Name", "GL_ALPHA_TEST_FUNC_QCOM")]
        AlphaTestFuncQCom = 0xBC1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_TEST_REF")]
        AlphaTestRef = 0xBC2,
        [NativeName("Name", "GL_ALPHA_TEST_REF_QCOM")]
        AlphaTestRefQCom = 0xBC2,
        [NativeName("Name", "GL_DITHER")]
        Dither = 0xBD0,
        [NativeName("Name", "GL_BLEND_DST")]
        BlendDst = 0xBE0,
        [NativeName("Name", "GL_BLEND_SRC")]
        BlendSrc = 0xBE1,
        [NativeName("Name", "GL_BLEND")]
        Blend = 0xBE2,
        [NativeName("Name", "GL_LOGIC_OP_MODE")]
        LogicOpMode = 0xBF0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_LOGIC_OP")]
        IndexLogicOp = 0xBF1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LOGIC_OP")]
        LogicOp = 0xBF1,
        [NativeName("Name", "GL_COLOR_LOGIC_OP")]
        ColorLogicOp = 0xBF2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUX_BUFFERS")]
        AuxBuffers = 0xC00,
        [NativeName("Name", "GL_DRAW_BUFFER")]
        DrawBuffer = 0xC01,
        [NativeName("Name", "GL_DRAW_BUFFER_EXT")]
        DrawBufferExt = 0xC01,
        [NativeName("Name", "GL_READ_BUFFER")]
        ReadBuffer = 0xC02,
        [NativeName("Name", "GL_READ_BUFFER_EXT")]
        ReadBufferExt = 0xC02,
        [NativeName("Name", "GL_READ_BUFFER_NV")]
        ReadBufferNV = 0xC02,
        [NativeName("Name", "GL_SCISSOR_BOX")]
        ScissorBox = 0xC10,
        [NativeName("Name", "GL_SCISSOR_TEST")]
        ScissorTest = 0xC11,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_CLEAR_VALUE")]
        IndexClearValue = 0xC20,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_WRITEMASK")]
        IndexWritemask = 0xC21,
        [NativeName("Name", "GL_COLOR_CLEAR_VALUE")]
        ColorClearValue = 0xC22,
        [NativeName("Name", "GL_COLOR_WRITEMASK")]
        ColorWritemask = 0xC23,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_MODE")]
        IndexMode = 0xC30,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RGBA_MODE")]
        RgbaMode = 0xC31,
        [NativeName("Name", "GL_DOUBLEBUFFER")]
        Doublebuffer = 0xC32,
        [NativeName("Name", "GL_STEREO")]
        Stereo = 0xC33,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RENDER_MODE")]
        RenderMode = 0xC40,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PERSPECTIVE_CORRECTION_HINT")]
        PerspectiveCorrectionHint = 0xC50,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SMOOTH_HINT")]
        PointSmoothHint = 0xC51,
        [NativeName("Name", "GL_LINE_SMOOTH_HINT")]
        LineSmoothHint = 0xC52,
        [NativeName("Name", "GL_POLYGON_SMOOTH_HINT")]
        PolygonSmoothHint = 0xC53,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_HINT")]
        FogHint = 0xC54,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_S")]
        TextureGenS = 0xC60,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_T")]
        TextureGenT = 0xC61,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_R")]
        TextureGenR = 0xC62,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_GEN_Q")]
        TextureGenQ = 0xC63,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_I_SIZE")]
        PixelMapIToISize = 0xCB0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_S_TO_S_SIZE")]
        PixelMapSToSSize = 0xCB1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_R_SIZE")]
        PixelMapIToRSize = 0xCB2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_G_SIZE")]
        PixelMapIToGSize = 0xCB3,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_B_SIZE")]
        PixelMapIToBSize = 0xCB4,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_I_TO_A_SIZE")]
        PixelMapIToASize = 0xCB5,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_R_TO_R_SIZE")]
        PixelMapRToRSize = 0xCB6,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_G_TO_G_SIZE")]
        PixelMapGToGSize = 0xCB7,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_B_TO_B_SIZE")]
        PixelMapBToBSize = 0xCB8,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MAP_A_TO_A_SIZE")]
        PixelMapAToASize = 0xCB9,
        [NativeName("Name", "GL_UNPACK_SWAP_BYTES")]
        UnpackSwapBytes = 0xCF0,
        [NativeName("Name", "GL_UNPACK_LSB_FIRST")]
        UnpackLsbFirst = 0xCF1,
        [NativeName("Name", "GL_UNPACK_ROW_LENGTH")]
        UnpackRowLength = 0xCF2,
        [NativeName("Name", "GL_UNPACK_SKIP_ROWS")]
        UnpackSkipRows = 0xCF3,
        [NativeName("Name", "GL_UNPACK_SKIP_PIXELS")]
        UnpackSkipPixels = 0xCF4,
        [NativeName("Name", "GL_UNPACK_ALIGNMENT")]
        UnpackAlignment = 0xCF5,
        [NativeName("Name", "GL_PACK_SWAP_BYTES")]
        PackSwapBytes = 0xD00,
        [NativeName("Name", "GL_PACK_LSB_FIRST")]
        PackLsbFirst = 0xD01,
        [NativeName("Name", "GL_PACK_ROW_LENGTH")]
        PackRowLength = 0xD02,
        [NativeName("Name", "GL_PACK_ROW_LENGTH_NV")]
        PackRowLengthNV = 0xD02,
        [NativeName("Name", "GL_PACK_SKIP_ROWS")]
        PackSkipRows = 0xD03,
        [NativeName("Name", "GL_PACK_SKIP_ROWS_NV")]
        PackSkipRowsNV = 0xD03,
        [NativeName("Name", "GL_PACK_SKIP_PIXELS")]
        PackSkipPixels = 0xD04,
        [NativeName("Name", "GL_PACK_SKIP_PIXELS_NV")]
        PackSkipPixelsNV = 0xD04,
        [NativeName("Name", "GL_PACK_ALIGNMENT")]
        PackAlignment = 0xD05,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP_COLOR")]
        MapColor = 0xD10,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP_STENCIL")]
        MapStencil = 0xD11,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_SHIFT")]
        IndexShift = 0xD12,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_OFFSET")]
        IndexOffset = 0xD13,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RED_SCALE")]
        RedScale = 0xD14,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RED_BIAS")]
        RedBias = 0xD15,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ZOOM_X")]
        ZoomX = 0xD16,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ZOOM_Y")]
        ZoomY = 0xD17,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_GREEN_SCALE")]
        GreenScale = 0xD18,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_GREEN_BIAS")]
        GreenBias = 0xD19,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_BLUE_SCALE")]
        BlueScale = 0xD1A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_BLUE_BIAS")]
        BlueBias = 0xD1B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_SCALE")]
        AlphaScale = 0xD1C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_BIAS")]
        AlphaBias = 0xD1D,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_DEPTH_SCALE")]
        DepthScale = 0xD1E,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_DEPTH_BIAS")]
        DepthBias = 0xD1F,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_EVAL_ORDER")]
        MaxEvalOrder = 0xD30,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_LIGHTS")]
        MaxLights = 0xD31,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_CLIP_PLANES")]
        MaxClipPlanes = 0xD32,
        [NativeName("Name", "GL_MAX_CLIP_DISTANCES")]
        MaxClipDistances = 0xD32,
        [NativeName("Name", "GL_MAX_TEXTURE_SIZE")]
        MaxTextureSize = 0xD33,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_PIXEL_MAP_TABLE")]
        MaxPixelMapTable = 0xD34,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_ATTRIB_STACK_DEPTH")]
        MaxAttribStackDepth = 0xD35,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_MODELVIEW_STACK_DEPTH")]
        MaxModelviewStackDepth = 0xD36,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_NAME_STACK_DEPTH")]
        MaxNameStackDepth = 0xD37,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_PROJECTION_STACK_DEPTH")]
        MaxProjectionStackDepth = 0xD38,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_TEXTURE_STACK_DEPTH")]
        MaxTextureStackDepth = 0xD39,
        [NativeName("Name", "GL_MAX_VIEWPORT_DIMS")]
        MaxViewportDims = 0xD3A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAX_CLIENT_ATTRIB_STACK_DEPTH")]
        MaxClientAttribStackDepth = 0xD3B,
        [NativeName("Name", "GL_SUBPIXEL_BITS")]
        SubpixelBits = 0xD50,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_BITS")]
        IndexBits = 0xD51,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RED_BITS")]
        RedBits = 0xD52,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_GREEN_BITS")]
        GreenBits = 0xD53,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_BLUE_BITS")]
        BlueBits = 0xD54,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_BITS")]
        AlphaBits = 0xD55,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_DEPTH_BITS")]
        DepthBits = 0xD56,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_STENCIL_BITS")]
        StencilBits = 0xD57,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM_RED_BITS")]
        AccumRedBits = 0xD58,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM_GREEN_BITS")]
        AccumGreenBits = 0xD59,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM_BLUE_BITS")]
        AccumBlueBits = 0xD5A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM_ALPHA_BITS")]
        AccumAlphaBits = 0xD5B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NAME_STACK_DEPTH")]
        NameStackDepth = 0xD70,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUTO_NORMAL")]
        AutoNormal = 0xD80,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_COLOR_4")]
        Map1Color4 = 0xD90,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_INDEX")]
        Map1Index = 0xD91,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_NORMAL")]
        Map1Normal = 0xD92,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_1")]
        Map1TextureCoord1 = 0xD93,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_2")]
        Map1TextureCoord2 = 0xD94,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_3")]
        Map1TextureCoord3 = 0xD95,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_4")]
        Map1TextureCoord4 = 0xD96,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_VERTEX_3")]
        Map1Vertex3 = 0xD97,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_VERTEX_4")]
        Map1Vertex4 = 0xD98,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_COLOR_4")]
        Map2Color4 = 0xDB0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_INDEX")]
        Map2Index = 0xDB1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_NORMAL")]
        Map2Normal = 0xDB2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_1")]
        Map2TextureCoord1 = 0xDB3,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_2")]
        Map2TextureCoord2 = 0xDB4,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_3")]
        Map2TextureCoord3 = 0xDB5,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_4")]
        Map2TextureCoord4 = 0xDB6,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_VERTEX_3")]
        Map2Vertex3 = 0xDB7,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_VERTEX_4")]
        Map2Vertex4 = 0xDB8,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_GRID_DOMAIN")]
        Map1GridDomain = 0xDD0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_GRID_SEGMENTS")]
        Map1GridSegments = 0xDD1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_GRID_DOMAIN")]
        Map2GridDomain = 0xDD2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_GRID_SEGMENTS")]
        Map2GridSegments = 0xDD3,
        [NativeName("Name", "GL_TEXTURE_1D")]
        Texture1D = 0xDE0,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FEEDBACK_BUFFER_SIZE")]
        FeedbackBufferSize = 0xDF1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FEEDBACK_BUFFER_TYPE")]
        FeedbackBufferType = 0xDF2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SELECTION_BUFFER_SIZE")]
        SelectionBufferSize = 0xDF4,
        [NativeName("Name", "GL_POLYGON_OFFSET_UNITS")]
        PolygonOffsetUnits = 0x2A00,
        [NativeName("Name", "GL_POLYGON_OFFSET_POINT")]
        PolygonOffsetPoint = 0x2A01,
        [NativeName("Name", "GL_POLYGON_OFFSET_LINE")]
        PolygonOffsetLine = 0x2A02,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE0")]
        ClipPlane0 = 0x3000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE1")]
        ClipPlane1 = 0x3001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE2")]
        ClipPlane2 = 0x3002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE3")]
        ClipPlane3 = 0x3003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE4")]
        ClipPlane4 = 0x3004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CLIP_PLANE5")]
        ClipPlane5 = 0x3005,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT0")]
        Light0 = 0x4000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT1")]
        Light1 = 0x4001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT2")]
        Light2 = 0x4002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT3")]
        Light3 = 0x4003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT4")]
        Light4 = 0x4004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT5")]
        Light5 = 0x4005,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT6")]
        Light6 = 0x4006,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT7")]
        Light7 = 0x4007,
        [NativeName("Name", "GL_BLEND_COLOR")]
        BlendColor = 0x8005,
        [NativeName("Name", "GL_BLEND_COLOR_EXT")]
        BlendColorExt = 0x8005,
        [NativeName("Name", "GL_BLEND_EQUATION")]
        BlendEquation = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_EXT")]
        BlendEquationExt = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_OES")]
        BlendEquationOes = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_RGB")]
        BlendEquationRgb = 0x8009,
        [NativeName("Name", "GL_PACK_CMYK_HINT_EXT")]
        PackCmykHintExt = 0x800E,
        [NativeName("Name", "GL_UNPACK_CMYK_HINT_EXT")]
        UnpackCmykHintExt = 0x800F,
        [NativeName("Name", "GL_CONVOLUTION_1D_EXT")]
        Convolution1DExt = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D_EXT")]
        Convolution2DExt = 0x8011,
        [NativeName("Name", "GL_SEPARABLE_2D_EXT")]
        Separable2DExt = 0x8012,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE_EXT")]
        PostConvolutionRedScaleExt = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
        PostConvolutionGreenScaleExt = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
        PostConvolutionBlueScaleExt = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
        PostConvolutionAlphaScaleExt = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS_EXT")]
        PostConvolutionRedBiasExt = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
        PostConvolutionGreenBiasExt = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
        PostConvolutionBlueBiasExt = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
        PostConvolutionAlphaBiasExt = 0x8023,
        [NativeName("Name", "GL_HISTOGRAM_EXT")]
        HistogramExt = 0x8024,
        [NativeName("Name", "GL_MINMAX_EXT")]
        MinmaxExt = 0x802E,
        [NativeName("Name", "GL_POLYGON_OFFSET_FILL")]
        PolygonOffsetFill = 0x8037,
        [NativeName("Name", "GL_POLYGON_OFFSET_FACTOR")]
        PolygonOffsetFactor = 0x8038,
        [NativeName("Name", "GL_POLYGON_OFFSET_BIAS_EXT")]
        PolygonOffsetBiasExt = 0x8039,
        [NativeName("Name", "GL_RESCALE_NORMAL_EXT")]
        RescaleNormalExt = 0x803A,
        [NativeName("Name", "GL_TEXTURE_BINDING_1D")]
        TextureBinding1D = 0x8068,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D")]
        TextureBinding2D = 0x8069,
        [NativeName("Name", "GL_TEXTURE_3D_BINDING_EXT")]
        Texture3DBindingExt = 0x806A,
        [NativeName("Name", "GL_TEXTURE_BINDING_3D")]
        TextureBinding3D = 0x806A,
        [NativeName("Name", "GL_PACK_SKIP_IMAGES")]
        PackSkipImages = 0x806B,
        [NativeName("Name", "GL_PACK_SKIP_IMAGES_EXT")]
        PackSkipImagesExt = 0x806B,
        [NativeName("Name", "GL_PACK_IMAGE_HEIGHT")]
        PackImageHeight = 0x806C,
        [NativeName("Name", "GL_PACK_IMAGE_HEIGHT_EXT")]
        PackImageHeightExt = 0x806C,
        [NativeName("Name", "GL_UNPACK_SKIP_IMAGES")]
        UnpackSkipImages = 0x806D,
        [NativeName("Name", "GL_UNPACK_SKIP_IMAGES_EXT")]
        UnpackSkipImagesExt = 0x806D,
        [NativeName("Name", "GL_UNPACK_IMAGE_HEIGHT")]
        UnpackImageHeight = 0x806E,
        [NativeName("Name", "GL_UNPACK_IMAGE_HEIGHT_EXT")]
        UnpackImageHeightExt = 0x806E,
        [NativeName("Name", "GL_TEXTURE_3D_EXT")]
        Texture3DExt = 0x806F,
        [NativeName("Name", "GL_MAX_3D_TEXTURE_SIZE")]
        Max3DTextureSize = 0x8073,
        [NativeName("Name", "GL_MAX_3D_TEXTURE_SIZE_EXT")]
        Max3DTextureSizeExt = 0x8073,
        [NativeName("Name", "GL_VERTEX_ARRAY")]
        VertexArray = 0x8074,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMAL_ARRAY")]
        NormalArray = 0x8075,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_ARRAY")]
        ColorArray = 0x8076,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_ARRAY")]
        IndexArray = 0x8077,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY")]
        TextureCoordArray = 0x8078,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY")]
        EdgeFlagArray = 0x8079,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_VERTEX_ARRAY_SIZE")]
        VertexArraySize = 0x807A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_VERTEX_ARRAY_TYPE")]
        VertexArrayType = 0x807B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_VERTEX_ARRAY_STRIDE")]
        VertexArrayStride = 0x807C,
        [NativeName("Name", "GL_VERTEX_ARRAY_COUNT_EXT")]
        VertexArrayCountExt = 0x807D,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMAL_ARRAY_TYPE")]
        NormalArrayType = 0x807E,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMAL_ARRAY_STRIDE")]
        NormalArrayStride = 0x807F,
        [NativeName("Name", "GL_NORMAL_ARRAY_COUNT_EXT")]
        NormalArrayCountExt = 0x8080,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_ARRAY_SIZE")]
        ColorArraySize = 0x8081,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_ARRAY_TYPE")]
        ColorArrayType = 0x8082,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_ARRAY_STRIDE")]
        ColorArrayStride = 0x8083,
        [NativeName("Name", "GL_COLOR_ARRAY_COUNT_EXT")]
        ColorArrayCountExt = 0x8084,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_ARRAY_TYPE")]
        IndexArrayType = 0x8085,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_ARRAY_STRIDE")]
        IndexArrayStride = 0x8086,
        [NativeName("Name", "GL_INDEX_ARRAY_COUNT_EXT")]
        IndexArrayCountExt = 0x8087,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_SIZE")]
        TextureCoordArraySize = 0x8088,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_TYPE")]
        TextureCoordArrayType = 0x8089,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_STRIDE")]
        TextureCoordArrayStride = 0x808A,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_COUNT_EXT")]
        TextureCoordArrayCountExt = 0x808B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_STRIDE")]
        EdgeFlagArrayStride = 0x808C,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_COUNT_EXT")]
        EdgeFlagArrayCountExt = 0x808D,
        [NativeName("Name", "GL_INTERLACE_SGIX")]
        InterlaceSgix = 0x8094,
        [NativeName("Name", "GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
        DetailTexture2DBindingSgis = 0x8096,
        [NativeName("Name", "GL_MULTISAMPLE_SGIS")]
        MultisampleSgis = 0x809D,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
        SampleAlphaToMaskSgis = 0x809E,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
        SampleAlphaToOneSgis = 0x809F,
        [NativeName("Name", "GL_SAMPLE_MASK_SGIS")]
        SampleMaskSgis = 0x80A0,
        [NativeName("Name", "GL_SAMPLE_BUFFERS")]
        SampleBuffers = 0x80A8,
        [NativeName("Name", "GL_SAMPLE_BUFFERS_SGIS")]
        SampleBuffersSgis = 0x80A8,
        [NativeName("Name", "GL_SAMPLES")]
        Samples = 0x80A9,
        [NativeName("Name", "GL_SAMPLES_SGIS")]
        SamplesSgis = 0x80A9,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_VALUE")]
        SampleCoverageValue = 0x80AA,
        [NativeName("Name", "GL_SAMPLE_MASK_VALUE_SGIS")]
        SampleMaskValueSgis = 0x80AA,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_INVERT")]
        SampleCoverageInvert = 0x80AB,
        [NativeName("Name", "GL_SAMPLE_MASK_INVERT_SGIS")]
        SampleMaskInvertSgis = 0x80AB,
        [NativeName("Name", "GL_SAMPLE_PATTERN_SGIS")]
        SamplePatternSgis = 0x80AC,
        [NativeName("Name", "GL_COLOR_MATRIX_SGI")]
        ColorMatrixSgi = 0x80B1,
        [NativeName("Name", "GL_COLOR_MATRIX_STACK_DEPTH_SGI")]
        ColorMatrixStackDepthSgi = 0x80B2,
        [NativeName("Name", "GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI")]
        MaxColorMatrixStackDepthSgi = 0x80B3,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
        PostColorMatrixRedScaleSgi = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
        PostColorMatrixGreenScaleSgi = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
        PostColorMatrixBlueScaleSgi = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
        PostColorMatrixRedBiasSgi = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
        PostColorMatrixGreenBiasSgi = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
        PostColorMatrixBlueBiasSgi = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
        PostColorMatrixAlphaBiasSgi = 0x80BB,
        [NativeName("Name", "GL_TEXTURE_COLOR_TABLE_SGI")]
        TextureColorTableSgi = 0x80BC,
        [NativeName("Name", "GL_BLEND_DST_RGB")]
        BlendDstRgb = 0x80C8,
        [NativeName("Name", "GL_BLEND_SRC_RGB")]
        BlendSrcRgb = 0x80C9,
        [NativeName("Name", "GL_BLEND_DST_ALPHA")]
        BlendDstAlpha = 0x80CA,
        [NativeName("Name", "GL_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x80CB,
        [NativeName("Name", "GL_COLOR_TABLE_SGI")]
        ColorTableSgi = 0x80D0,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
        PostConvolutionColorTableSgi = 0x80D1,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
        PostColorMatrixColorTableSgi = 0x80D2,
        [NativeName("Name", "GL_MAX_ELEMENTS_VERTICES")]
        MaxElementsVertices = 0x80E8,
        [NativeName("Name", "GL_MAX_ELEMENTS_INDICES")]
        MaxElementsIndices = 0x80E9,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SIZE_MIN")]
        PointSizeMin = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_ARB")]
        PointSizeMinArb = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        PointSizeMinExt = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_SGIS")]
        PointSizeMinSgis = 0x8126,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SIZE_MAX")]
        PointSizeMax = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_ARB")]
        PointSizeMaxArb = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        PointSizeMaxExt = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_SGIS")]
        PointSizeMaxSgis = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE")]
        PointFadeThresholdSize = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
        PointFadeThresholdSizeArb = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        PointFadeThresholdSizeExt = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
        PointFadeThresholdSizeSgis = 0x8128,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_EXT")]
        DistanceAttenuationExt = 0x8129,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_SGIS")]
        DistanceAttenuationSgis = 0x8129,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_DISTANCE_ATTENUATION")]
        PointDistanceAttenuation = 0x8129,
        [NativeName("Name", "GL_POINT_DISTANCE_ATTENUATION_ARB")]
        PointDistanceAttenuationArb = 0x8129,
        [NativeName("Name", "GL_FOG_FUNC_POINTS_SGIS")]
        FogFuncPointsSgis = 0x812B,
        [NativeName("Name", "GL_MAX_FOG_FUNC_POINTS_SGIS")]
        MaxFogFuncPointsSgis = 0x812C,
        [NativeName("Name", "GL_PACK_SKIP_VOLUMES_SGIS")]
        PackSkipVolumesSgis = 0x8130,
        [NativeName("Name", "GL_PACK_IMAGE_DEPTH_SGIS")]
        PackImageDepthSgis = 0x8131,
        [NativeName("Name", "GL_UNPACK_SKIP_VOLUMES_SGIS")]
        UnpackSkipVolumesSgis = 0x8132,
        [NativeName("Name", "GL_UNPACK_IMAGE_DEPTH_SGIS")]
        UnpackImageDepthSgis = 0x8133,
        [NativeName("Name", "GL_TEXTURE_4D_SGIS")]
        Texture4DSgis = 0x8134,
        [NativeName("Name", "GL_MAX_4D_TEXTURE_SIZE_SGIS")]
        Max4DTextureSizeSgis = 0x8138,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_SGIX")]
        PixelTexGenSgix = 0x8139,
        [NativeName("Name", "GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX")]
        PixelTileBestAlignmentSgix = 0x813E,
        [NativeName("Name", "GL_PIXEL_TILE_CACHE_INCREMENT_SGIX")]
        PixelTileCacheIncrementSgix = 0x813F,
        [NativeName("Name", "GL_PIXEL_TILE_WIDTH_SGIX")]
        PixelTileWidthSgix = 0x8140,
        [NativeName("Name", "GL_PIXEL_TILE_HEIGHT_SGIX")]
        PixelTileHeightSgix = 0x8141,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
        PixelTileGridWidthSgix = 0x8142,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
        PixelTileGridHeightSgix = 0x8143,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
        PixelTileGridDepthSgix = 0x8144,
        [NativeName("Name", "GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
        PixelTileCacheSizeSgix = 0x8145,
        [NativeName("Name", "GL_SPRITE_SGIX")]
        SpriteSgix = 0x8148,
        [NativeName("Name", "GL_SPRITE_MODE_SGIX")]
        SpriteModeSgix = 0x8149,
        [NativeName("Name", "GL_SPRITE_AXIS_SGIX")]
        SpriteAxisSgix = 0x814A,
        [NativeName("Name", "GL_SPRITE_TRANSLATION_SGIX")]
        SpriteTranslationSgix = 0x814B,
        [NativeName("Name", "GL_TEXTURE_4D_BINDING_SGIS")]
        Texture4DBindingSgis = 0x814F,
        [NativeName("Name", "GL_MAX_CLIPMAP_DEPTH_SGIX")]
        MaxClipmapDepthSgix = 0x8177,
        [NativeName("Name", "GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
        MaxClipmapVirtualDepthSgix = 0x8178,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
        PostTextureFilterBiasRangeSgix = 0x817B,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
        PostTextureFilterScaleRangeSgix = 0x817C,
        [NativeName("Name", "GL_REFERENCE_PLANE_SGIX")]
        ReferencePlaneSgix = 0x817D,
        [NativeName("Name", "GL_REFERENCE_PLANE_EQUATION_SGIX")]
        ReferencePlaneEquationSgix = 0x817E,
        [NativeName("Name", "GL_IR_INSTRUMENT1_SGIX")]
        IRInstrument1Sgix = 0x817F,
        [NativeName("Name", "GL_INSTRUMENT_MEASUREMENTS_SGIX")]
        InstrumentMeasurementsSgix = 0x8181,
        [NativeName("Name", "GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
        CalligraphicFragmentSgix = 0x8183,
        [NativeName("Name", "GL_FRAMEZOOM_SGIX")]
        FramezoomSgix = 0x818B,
        [NativeName("Name", "GL_FRAMEZOOM_FACTOR_SGIX")]
        FramezoomFactorSgix = 0x818C,
        [NativeName("Name", "GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
        MaxFramezoomFactorSgix = 0x818D,
        [NativeName("Name", "GL_GENERATE_MIPMAP_HINT_SGIS")]
        GenerateMipmapHintSgis = 0x8192,
        [NativeName("Name", "GL_DEFORMATIONS_MASK_SGIX")]
        DeformationsMaskSgix = 0x8196,
        [NativeName("Name", "GL_FOG_OFFSET_SGIX")]
        FogOffsetSgix = 0x8198,
        [NativeName("Name", "GL_FOG_OFFSET_VALUE_SGIX")]
        FogOffsetValueSgix = 0x8199,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL")]
        LightModelColorControl = 0x81F8,
        [NativeName("Name", "GL_SHARED_TEXTURE_PALETTE_EXT")]
        SharedTexturePaletteExt = 0x81FB,
        [NativeName("Name", "GL_MAJOR_VERSION")]
        MajorVersion = 0x821B,
        [NativeName("Name", "GL_MINOR_VERSION")]
        MinorVersion = 0x821C,
        [NativeName("Name", "GL_NUM_EXTENSIONS")]
        NumExtensions = 0x821D,
        [NativeName("Name", "GL_CONTEXT_FLAGS")]
        ContextFlags = 0x821E,
        [NativeName("Name", "GL_PROGRAM_PIPELINE_BINDING")]
        ProgramPipelineBinding = 0x825A,
        [NativeName("Name", "GL_MAX_VIEWPORTS")]
        MaxViewports = 0x825B,
        [NativeName("Name", "GL_VIEWPORT_SUBPIXEL_BITS")]
        ViewportSubpixelBits = 0x825C,
        [NativeName("Name", "GL_VIEWPORT_BOUNDS_RANGE")]
        ViewportBoundsRange = 0x825D,
        [NativeName("Name", "GL_LAYER_PROVOKING_VERTEX")]
        LayerProvokingVertex = 0x825E,
        [NativeName("Name", "GL_VIEWPORT_INDEX_PROVOKING_VERTEX")]
        ViewportIndexProvokingVertex = 0x825F,
        [NativeName("Name", "GL_MAX_COMPUTE_UNIFORM_COMPONENTS")]
        MaxComputeUniformComponents = 0x8263,
        [NativeName("Name", "GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS")]
        MaxComputeAtomicCounterBuffers = 0x8264,
        [NativeName("Name", "GL_MAX_COMPUTE_ATOMIC_COUNTERS")]
        MaxComputeAtomicCounters = 0x8265,
        [NativeName("Name", "GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS")]
        MaxCombinedComputeUniformComponents = 0x8266,
        [NativeName("Name", "GL_MAX_DEBUG_GROUP_STACK_DEPTH")]
        MaxDebugGroupStackDepth = 0x826C,
        [NativeName("Name", "GL_DEBUG_GROUP_STACK_DEPTH")]
        DebugGroupStackDepth = 0x826D,
        [NativeName("Name", "GL_MAX_UNIFORM_LOCATIONS")]
        MaxUniformLocations = 0x826E,
        [NativeName("Name", "GL_VERTEX_BINDING_DIVISOR")]
        VertexBindingDivisor = 0x82D6,
        [NativeName("Name", "GL_VERTEX_BINDING_OFFSET")]
        VertexBindingOffset = 0x82D7,
        [NativeName("Name", "GL_VERTEX_BINDING_STRIDE")]
        VertexBindingStride = 0x82D8,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        MaxVertexAttribRelativeOffset = 0x82D9,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_BINDINGS")]
        MaxVertexAttribBindings = 0x82DA,
        [NativeName("Name", "GL_MAX_LABEL_LENGTH")]
        MaxLabelLength = 0x82E8,
        [NativeName("Name", "GL_CONVOLUTION_HINT_SGIX")]
        ConvolutionHintSgix = 0x8316,
        [NativeName("Name", "GL_ASYNC_MARKER_SGIX")]
        AsyncMarkerSgix = 0x8329,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_MODE_SGIX")]
        PixelTexGenModeSgix = 0x832B,
        [NativeName("Name", "GL_ASYNC_HISTOGRAM_SGIX")]
        AsyncHistogramSgix = 0x832C,
        [NativeName("Name", "GL_MAX_ASYNC_HISTOGRAM_SGIX")]
        MaxAsyncHistogramSgix = 0x832D,
        [NativeName("Name", "GL_PIXEL_TEXTURE_SGIS")]
        PixelTextureSgis = 0x8353,
        [NativeName("Name", "GL_ASYNC_TEX_IMAGE_SGIX")]
        AsyncTexImageSgix = 0x835C,
        [NativeName("Name", "GL_ASYNC_DRAW_PIXELS_SGIX")]
        AsyncDrawPixelsSgix = 0x835D,
        [NativeName("Name", "GL_ASYNC_READ_PIXELS_SGIX")]
        AsyncReadPixelsSgix = 0x835E,
        [NativeName("Name", "GL_MAX_ASYNC_TEX_IMAGE_SGIX")]
        MaxAsyncTexImageSgix = 0x835F,
        [NativeName("Name", "GL_MAX_ASYNC_DRAW_PIXELS_SGIX")]
        MaxAsyncDrawPixelsSgix = 0x8360,
        [NativeName("Name", "GL_MAX_ASYNC_READ_PIXELS_SGIX")]
        MaxAsyncReadPixelsSgix = 0x8361,
        [NativeName("Name", "GL_VERTEX_PRECLIP_SGIX")]
        VertexPreclipSgix = 0x83EE,
        [NativeName("Name", "GL_VERTEX_PRECLIP_HINT_SGIX")]
        VertexPreclipHintSgix = 0x83EF,
        [NativeName("Name", "GL_FRAGMENT_LIGHTING_SGIX")]
        FragmentLightingSgix = 0x8400,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
        FragmentColorMaterialSgix = 0x8401,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX")]
        FragmentColorMaterialFaceSgix = 0x8402,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX")]
        FragmentColorMaterialParameterSgix = 0x8403,
        [NativeName("Name", "GL_MAX_FRAGMENT_LIGHTS_SGIX")]
        MaxFragmentLightsSgix = 0x8404,
        [NativeName("Name", "GL_MAX_ACTIVE_LIGHTS_SGIX")]
        MaxActiveLightsSgix = 0x8405,
        [NativeName("Name", "GL_LIGHT_ENV_MODE_SGIX")]
        LightEnvModeSgix = 0x8407,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
        FragmentLightModelLocalViewerSgix = 0x8408,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
        FragmentLightModelTwoSideSgix = 0x8409,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
        FragmentLightModelAmbientSgix = 0x840A,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
        FragmentLightModelNormalInterpolationSgix = 0x840B,
        [NativeName("Name", "GL_FRAGMENT_LIGHT0_SGIX")]
        FragmentLight0Sgix = 0x840C,
        [NativeName("Name", "GL_PACK_RESAMPLE_SGIX")]
        PackResampleSgix = 0x842E,
        [NativeName("Name", "GL_UNPACK_RESAMPLE_SGIX")]
        UnpackResampleSgix = 0x842F,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALIASED_POINT_SIZE_RANGE")]
        AliasedPointSizeRange = 0x846D,
        [NativeName("Name", "GL_ALIASED_LINE_WIDTH_RANGE")]
        AliasedLineWidthRange = 0x846E,
        [NativeName("Name", "GL_ACTIVE_TEXTURE")]
        ActiveTexture = 0x84E0,
        [NativeName("Name", "GL_MAX_RENDERBUFFER_SIZE")]
        MaxRenderbufferSize = 0x84E8,
        [NativeName("Name", "GL_TEXTURE_COMPRESSION_HINT")]
        TextureCompressionHint = 0x84EF,
        [NativeName("Name", "GL_TEXTURE_BINDING_RECTANGLE")]
        TextureBindingRectangle = 0x84F6,
        [NativeName("Name", "GL_TEXTURE_BINDING_RECTANGLE_ARB")]
        TextureBindingRectangleArb = 0x84F6,
        [NativeName("Name", "GL_TEXTURE_BINDING_RECTANGLE_NV")]
        TextureBindingRectangleNV = 0x84F6,
        [NativeName("Name", "GL_MAX_RECTANGLE_TEXTURE_SIZE")]
        MaxRectangleTextureSize = 0x84F8,
        [NativeName("Name", "GL_MAX_TEXTURE_LOD_BIAS")]
        MaxTextureLodBias = 0x84FD,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP")]
        TextureBindingCubeMap = 0x8514,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
        TextureBindingCubeMapArb = 0x8514,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
        TextureBindingCubeMapExt = 0x8514,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_OES")]
        TextureBindingCubeMapOes = 0x8514,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE")]
        MaxCubeMapTextureSize = 0x851C,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
        MaxCubeMapTextureSizeArb = 0x851C,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
        MaxCubeMapTextureSizeExt = 0x851C,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
        MaxCubeMapTextureSizeOes = 0x851C,
        [NativeName("Name", "GL_PACK_SUBSAMPLE_RATE_SGIX")]
        PackSubsampleRateSgix = 0x85A0,
        [NativeName("Name", "GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
        UnpackSubsampleRateSgix = 0x85A1,
        [NativeName("Name", "GL_VERTEX_ARRAY_BINDING")]
        VertexArrayBinding = 0x85B5,
        [NativeName("Name", "GL_PROGRAM_POINT_SIZE")]
        ProgramPointSize = 0x8642,
        [NativeName("Name", "GL_NUM_COMPRESSED_TEXTURE_FORMATS")]
        NumCompressedTextureFormats = 0x86A2,
        [NativeName("Name", "GL_COMPRESSED_TEXTURE_FORMATS")]
        CompressedTextureFormats = 0x86A3,
        [NativeName("Name", "GL_NUM_PROGRAM_BINARY_FORMATS")]
        NumProgramBinaryFormats = 0x87FE,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMATS")]
        ProgramBinaryFormats = 0x87FF,
        [NativeName("Name", "GL_STENCIL_BACK_FUNC")]
        StencilBackFunc = 0x8800,
        [NativeName("Name", "GL_STENCIL_BACK_FAIL")]
        StencilBackFail = 0x8801,
        [NativeName("Name", "GL_STENCIL_BACK_PASS_DEPTH_FAIL")]
        StencilBackPassDepthFail = 0x8802,
        [NativeName("Name", "GL_STENCIL_BACK_PASS_DEPTH_PASS")]
        StencilBackPassDepthPass = 0x8803,
        [NativeName("Name", "GL_MAX_DRAW_BUFFERS")]
        MaxDrawBuffers = 0x8824,
        [NativeName("Name", "GL_BLEND_EQUATION_ALPHA")]
        BlendEquationAlpha = 0x883D,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIBS")]
        MaxVertexAttribs = 0x8869,
        [NativeName("Name", "GL_MAX_TEXTURE_IMAGE_UNITS")]
        MaxTextureImageUnits = 0x8872,
        [NativeName("Name", "GL_ARRAY_BUFFER_BINDING")]
        ArrayBufferBinding = 0x8894,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BUFFER_BINDING")]
        ElementArrayBufferBinding = 0x8895,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_BINDING")]
        PixelPackBufferBinding = 0x88ED,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_BINDING")]
        PixelUnpackBufferBinding = 0x88EF,
        [NativeName("Name", "GL_MAX_DUAL_SOURCE_DRAW_BUFFERS")]
        MaxDualSourceDrawBuffers = 0x88FC,
        [NativeName("Name", "GL_MAX_ARRAY_TEXTURE_LAYERS")]
        MaxArrayTextureLayers = 0x88FF,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXEL_OFFSET")]
        MinProgramTexelOffset = 0x8904,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXEL_OFFSET")]
        MaxProgramTexelOffset = 0x8905,
        [NativeName("Name", "GL_SAMPLER_BINDING")]
        SamplerBinding = 0x8919,
        [NativeName("Name", "GL_FRAGMENT_SHADER_ATI")]
        FragmentShaderAti = 0x8920,
        [NativeName("Name", "GL_UNIFORM_BUFFER_BINDING")]
        UniformBufferBinding = 0x8A28,
        [NativeName("Name", "GL_UNIFORM_BUFFER_START")]
        UniformBufferStart = 0x8A29,
        [NativeName("Name", "GL_UNIFORM_BUFFER_SIZE")]
        UniformBufferSize = 0x8A2A,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_BLOCKS")]
        MaxVertexUniformBlocks = 0x8A2B,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_BLOCKS")]
        MaxGeometryUniformBlocks = 0x8A2C,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_BLOCKS")]
        MaxFragmentUniformBlocks = 0x8A2D,
        [NativeName("Name", "GL_MAX_COMBINED_UNIFORM_BLOCKS")]
        MaxCombinedUniformBlocks = 0x8A2E,
        [NativeName("Name", "GL_MAX_UNIFORM_BUFFER_BINDINGS")]
        MaxUniformBufferBindings = 0x8A2F,
        [NativeName("Name", "GL_MAX_UNIFORM_BLOCK_SIZE")]
        MaxUniformBlockSize = 0x8A30,
        [NativeName("Name", "GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS")]
        MaxCombinedVertexUniformComponents = 0x8A31,
        [NativeName("Name", "GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS")]
        MaxCombinedGeometryUniformComponents = 0x8A32,
        [NativeName("Name", "GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS")]
        MaxCombinedFragmentUniformComponents = 0x8A33,
        [NativeName("Name", "GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT")]
        UniformBufferOffsetAlignment = 0x8A34,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_COMPONENTS")]
        MaxFragmentUniformComponents = 0x8B49,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_COMPONENTS")]
        MaxVertexUniformComponents = 0x8B4A,
        [NativeName("Name", "GL_MAX_VARYING_FLOATS")]
        MaxVaryingFloats = 0x8B4B,
        [NativeName("Name", "GL_MAX_VARYING_COMPONENTS")]
        MaxVaryingComponents = 0x8B4B,
        [NativeName("Name", "GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
        MaxVertexTextureImageUnits = 0x8B4C,
        [NativeName("Name", "GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
        MaxCombinedTextureImageUnits = 0x8B4D,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
        FragmentShaderDerivativeHint = 0x8B8B,
        [NativeName("Name", "GL_CURRENT_PROGRAM")]
        CurrentProgram = 0x8B8D,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_TYPE")]
        ImplementationColorReadType = 0x8B9A,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
        ImplementationColorReadFormat = 0x8B9B,
        [NativeName("Name", "GL_TEXTURE_BINDING_1D_ARRAY")]
        TextureBinding1DArray = 0x8C1C,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_ARRAY")]
        TextureBinding2DArray = 0x8C1D,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS")]
        MaxGeometryTextureImageUnits = 0x8C29,
        [NativeName("Name", "GL_MAX_TEXTURE_BUFFER_SIZE")]
        MaxTextureBufferSize = 0x8C2B,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER")]
        TextureBindingBuffer = 0x8C2C,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START")]
        TransformFeedbackBufferStart = 0x8C84,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
        TransformFeedbackBufferSize = 0x8C85,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
        TransformFeedbackBufferBinding = 0x8C8F,
        [NativeName("Name", "GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
        MotionEstimationSearchBlockXQCom = 0x8C90,
        [NativeName("Name", "GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
        MotionEstimationSearchBlockYQCom = 0x8C91,
        [NativeName("Name", "GL_STENCIL_BACK_REF")]
        StencilBackRef = 0x8CA3,
        [NativeName("Name", "GL_STENCIL_BACK_VALUE_MASK")]
        StencilBackValueMask = 0x8CA4,
        [NativeName("Name", "GL_STENCIL_BACK_WRITEMASK")]
        StencilBackWritemask = 0x8CA5,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING")]
        DrawFramebufferBinding = 0x8CA6,
        [NativeName("Name", "GL_RENDERBUFFER_BINDING")]
        RenderbufferBinding = 0x8CA7,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING")]
        ReadFramebufferBinding = 0x8CAA,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS")]
        MaxColorAttachments = 0x8CDF,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS_EXT")]
        MaxColorAttachmentsExt = 0x8CDF,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS_NV")]
        MaxColorAttachmentsNV = 0x8CDF,
        [NativeName("Name", "GL_TEXTURE_GEN_STR_OES")]
        TextureGenStrOes = 0x8D60,
        [NativeName("Name", "GL_MAX_ELEMENT_INDEX")]
        MaxElementIndex = 0x8D6B,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_COMPONENTS")]
        MaxGeometryUniformComponents = 0x8DDF,
        [NativeName("Name", "GL_SHADER_BINARY_FORMATS")]
        ShaderBinaryFormats = 0x8DF8,
        [NativeName("Name", "GL_NUM_SHADER_BINARY_FORMATS")]
        NumShaderBinaryFormats = 0x8DF9,
        [NativeName("Name", "GL_SHADER_COMPILER")]
        ShaderCompiler = 0x8DFA,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_VECTORS")]
        MaxVertexUniformVectors = 0x8DFB,
        [NativeName("Name", "GL_MAX_VARYING_VECTORS")]
        MaxVaryingVectors = 0x8DFC,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_VECTORS")]
        MaxFragmentUniformVectors = 0x8DFD,
        [NativeName("Name", "GL_TIMESTAMP")]
        Timestamp = 0x8E28,
        [NativeName("Name", "GL_TIMESTAMP_EXT")]
        TimestampExt = 0x8E28,
        [NativeName("Name", "GL_PROVOKING_VERTEX")]
        ProvokingVertex = 0x8E4F,
        [NativeName("Name", "GL_MAX_SAMPLE_MASK_WORDS")]
        MaxSampleMaskWords = 0x8E59,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
        MaxTessControlUniformBlocks = 0x8E89,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
        MaxTessEvaluationUniformBlocks = 0x8E8A,
        [NativeName("Name", "GL_FETCH_PER_SAMPLE_ARM")]
        FetchPerSampleArm = 0x8F65,
        [NativeName("Name", "GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM")]
        FragmentShaderFramebufferFetchMrtArm = 0x8F66,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_NON_TRIVIAL_COMBINERS_SUPPORTED_EXT")]
        FragmentShadingRateNonTrivialCombinersSupportedExt = 0x8F6F,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_INDEX")]
        PrimitiveRestartIndex = 0x8F9E,
        [NativeName("Name", "GL_MIN_MAP_BUFFER_ALIGNMENT")]
        MinMapBufferAlignment = 0x90BC,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_BINDING")]
        ShaderStorageBufferBinding = 0x90D3,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_START")]
        ShaderStorageBufferStart = 0x90D4,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_SIZE")]
        ShaderStorageBufferSize = 0x90D5,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS")]
        MaxVertexShaderStorageBlocks = 0x90D6,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS")]
        MaxGeometryShaderStorageBlocks = 0x90D7,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS")]
        MaxTessControlShaderStorageBlocks = 0x90D8,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS")]
        MaxTessEvaluationShaderStorageBlocks = 0x90D9,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS")]
        MaxFragmentShaderStorageBlocks = 0x90DA,
        [NativeName("Name", "GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS")]
        MaxComputeShaderStorageBlocks = 0x90DB,
        [NativeName("Name", "GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS")]
        MaxCombinedShaderStorageBlocks = 0x90DC,
        [NativeName("Name", "GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS")]
        MaxShaderStorageBufferBindings = 0x90DD,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS")]
        MaxComputeWorkGroupInvocations = 0x90EB,
        [NativeName("Name", "GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
        DispatchIndirectBufferBinding = 0x90EF,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
        TextureBinding2DMultisample = 0x9104,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
        TextureBinding2DMultisampleArray = 0x9105,
        [NativeName("Name", "GL_MAX_COLOR_TEXTURE_SAMPLES")]
        MaxColorTextureSamples = 0x910E,
        [NativeName("Name", "GL_MAX_DEPTH_TEXTURE_SAMPLES")]
        MaxDepthTextureSamples = 0x910F,
        [NativeName("Name", "GL_MAX_INTEGER_SAMPLES")]
        MaxIntegerSamples = 0x9110,
        [NativeName("Name", "GL_MAX_SERVER_WAIT_TIMEOUT")]
        MaxServerWaitTimeout = 0x9111,
        [NativeName("Name", "GL_MAX_VERTEX_OUTPUT_COMPONENTS")]
        MaxVertexOutputComponents = 0x9122,
        [NativeName("Name", "GL_MAX_GEOMETRY_INPUT_COMPONENTS")]
        MaxGeometryInputComponents = 0x9123,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_COMPONENTS")]
        MaxGeometryOutputComponents = 0x9124,
        [NativeName("Name", "GL_MAX_FRAGMENT_INPUT_COMPONENTS")]
        MaxFragmentInputComponents = 0x9125,
        [NativeName("Name", "GL_CONTEXT_PROFILE_MASK")]
        ContextProfileMask = 0x9126,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
        TextureBufferOffsetAlignment = 0x919F,
        [NativeName("Name", "GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
        MaxComputeUniformBlocks = 0x91BB,
        [NativeName("Name", "GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
        MaxComputeTextureImageUnits = 0x91BC,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_COUNT")]
        MaxComputeWorkGroupCount = 0x91BE,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_SIZE")]
        MaxComputeWorkGroupSize = 0x91BF,
        [NativeName("Name", "GL_MAX_VERTEX_ATOMIC_COUNTERS")]
        MaxVertexAtomicCounters = 0x92D2,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS")]
        MaxTessControlAtomicCounters = 0x92D3,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS")]
        MaxTessEvaluationAtomicCounters = 0x92D4,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTERS")]
        MaxGeometryAtomicCounters = 0x92D5,
        [NativeName("Name", "GL_MAX_FRAGMENT_ATOMIC_COUNTERS")]
        MaxFragmentAtomicCounters = 0x92D6,
        [NativeName("Name", "GL_MAX_COMBINED_ATOMIC_COUNTERS")]
        MaxCombinedAtomicCounters = 0x92D7,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_WIDTH")]
        MaxFramebufferWidth = 0x9315,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_HEIGHT")]
        MaxFramebufferHeight = 0x9316,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_LAYERS")]
        MaxFramebufferLayers = 0x9317,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_SAMPLES")]
        MaxFramebufferSamples = 0x9318,
        [NativeName("Name", "GL_NUM_DEVICE_UUIDS_EXT")]
        NumDeviceUuidsExt = 0x9596,
        [NativeName("Name", "GL_DEVICE_UUID_EXT")]
        DeviceUuidExt = 0x9597,
        [NativeName("Name", "GL_DRIVER_UUID_EXT")]
        DriverUuidExt = 0x9598,
        [NativeName("Name", "GL_DEVICE_LUID_EXT")]
        DeviceLuidExt = 0x9599,
        [NativeName("Name", "GL_DEVICE_NODE_MASK_EXT")]
        DeviceNodeMaskExt = 0x959A,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
        ShadingRateImagePerPrimitiveNV = 0x95B1,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
        ShadingRateImagePaletteCountNV = 0x95B2,
        [NativeName("Name", "GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
        MaxTimelineSemaphoreValueDifferenceNV = 0x95B6,
        [NativeName("Name", "GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
        FramebufferFetchNoncoherentQCom = 0x96A2,
        [NativeName("Name", "GL_SHADING_RATE_QCOM")]
        ShadingRateQCom = 0x96A4,
        [NativeName("Name", "GL_SHADING_RATE_EXT")]
        ShadingRateExt = 0x96D0,
        [NativeName("Name", "GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
        MinFragmentShadingRateAttachmentTexelWidthExt = 0x96D7,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
        MaxFragmentShadingRateAttachmentTexelWidthExt = 0x96D8,
        [NativeName("Name", "GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
        MinFragmentShadingRateAttachmentTexelHeightExt = 0x96D9,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
        MaxFragmentShadingRateAttachmentTexelHeightExt = 0x96DA,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_ASPECT_RATIO_EXT")]
        MaxFragmentShadingRateAttachmentTexelAspectRatioExt = 0x96DB,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_LAYERS_EXT")]
        MaxFragmentShadingRateAttachmentLayersExt = 0x96DC,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_WITH_SHADER_DEPTH_STENCIL_WRITES_SUPPORTED_EXT")]
        FragmentShadingRateWithShaderDepthStencilWritesSupportedExt = 0x96DD,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_WITH_SAMPLE_MASK_SUPPORTED_EXT")]
        FragmentShadingRateWithSampleMaskSupportedExt = 0x96DE,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_ATTACHMENT_WITH_DEFAULT_FRAMEBUFFER_SUPPORTED_EXT")]
        FragmentShadingRateAttachmentWithDefaultFramebufferSupportedExt = 0x96DF,
        [NativeName("Name", "GL_SHADER_CORE_COUNT_ARM")]
        ShaderCoreCountArm = 0x96F0,
        [NativeName("Name", "GL_SHADER_CORE_ACTIVE_COUNT_ARM")]
        ShaderCoreActiveCountArm = 0x96F1,
        [NativeName("Name", "GL_SHADER_CORE_PRESENT_MASK_ARM")]
        ShaderCorePresentMaskArm = 0x96F2,
        [NativeName("Name", "GL_SHADER_CORE_MAX_WARP_COUNT_ARM")]
        ShaderCoreMaxWarpCountArm = 0x96F3,
        [NativeName("Name", "GL_SHADER_CORE_PIXEL_RATE_ARM")]
        ShaderCorePixelRateArm = 0x96F4,
        [NativeName("Name", "GL_SHADER_CORE_TEXEL_RATE_ARM")]
        ShaderCoreTexelRateArm = 0x96F5,
        [NativeName("Name", "GL_SHADER_CORE_FMA_RATE_ARM")]
        ShaderCoreFmaRateArm = 0x96F6,
    }
}
