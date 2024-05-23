// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum GetPName : uint
{
    PointSize = unchecked((uint)0x0B11),
    PointSizeRange = unchecked((uint)0x0B12),
    PointSizeGranularity = unchecked((uint)0x0B13),
    LineSmooth = unchecked((uint)0x0B20),
    LineWidth = unchecked((uint)0x0B21),
    LineWidthRange = unchecked((uint)0x0B22),
    LineWidthGranularity = unchecked((uint)0x0B23),
    PolygonMode = unchecked((uint)0x0B40),
    PolygonSmooth = unchecked((uint)0x0B41),
    CullFace = unchecked((uint)0x0B44),
    CullFaceMode = unchecked((uint)0x0B45),
    FrontFace = unchecked((uint)0x0B46),
    DepthRange = unchecked((uint)0x0B70),
    DepthTest = unchecked((uint)0x0B71),
    DepthWritemask = unchecked((uint)0x0B72),
    DepthClearValue = unchecked((uint)0x0B73),
    DepthFunc = unchecked((uint)0x0B74),
    StencilTest = unchecked((uint)0x0B90),
    StencilClearValue = unchecked((uint)0x0B91),
    StencilFunc = unchecked((uint)0x0B92),
    StencilValueMask = unchecked((uint)0x0B93),
    StencilFail = unchecked((uint)0x0B94),
    StencilPassDepthFail = unchecked((uint)0x0B95),
    StencilPassDepthPass = unchecked((uint)0x0B96),
    StencilRef = unchecked((uint)0x0B97),
    StencilWritemask = unchecked((uint)0x0B98),
    Viewport = unchecked((uint)0x0BA2),
    Dither = unchecked((uint)0x0BD0),
    BlendDst = unchecked((uint)0x0BE0),
    BlendSrc = unchecked((uint)0x0BE1),
    Blend = unchecked((uint)0x0BE2),
    LogicOpMode = unchecked((uint)0x0BF0),
    DrawBuffer = unchecked((uint)0x0C01),
    ReadBuffer = unchecked((uint)0x0C02),
    ScissorBox = unchecked((uint)0x0C10),
    ScissorTest = unchecked((uint)0x0C11),
    ColorClearValue = unchecked((uint)0x0C22),
    ColorWritemask = unchecked((uint)0x0C23),
    Doublebuffer = unchecked((uint)0x0C32),
    Stereo = unchecked((uint)0x0C33),
    LineSmoothHint = unchecked((uint)0x0C52),
    PolygonSmoothHint = unchecked((uint)0x0C53),
    UnpackSwapBytes = unchecked((uint)0x0CF0),
    UnpackLsbFirst = unchecked((uint)0x0CF1),
    UnpackRowLength = unchecked((uint)0x0CF2),
    UnpackSkipRows = unchecked((uint)0x0CF3),
    UnpackSkipPixels = unchecked((uint)0x0CF4),
    UnpackAlignment = unchecked((uint)0x0CF5),
    PackSwapBytes = unchecked((uint)0x0D00),
    PackLsbFirst = unchecked((uint)0x0D01),
    PackRowLength = unchecked((uint)0x0D02),
    PackSkipRows = unchecked((uint)0x0D03),
    PackSkipPixels = unchecked((uint)0x0D04),
    PackAlignment = unchecked((uint)0x0D05),
    MaxTextureSize = unchecked((uint)0x0D33),
    MaxViewportDims = unchecked((uint)0x0D3A),
    SubpixelBits = unchecked((uint)0x0D50),
    Texture1D = unchecked((uint)0x0DE0),
    Texture2D = unchecked((uint)0x0DE1),
    ColorLogicOp = unchecked((uint)0x0BF2),
    PolygonOffsetUnits = unchecked((uint)0x2A00),
    PolygonOffsetPoint = unchecked((uint)0x2A01),
    PolygonOffsetLine = unchecked((uint)0x2A02),
    PolygonOffsetFill = unchecked((uint)0x8037),
    PolygonOffsetFactor = unchecked((uint)0x8038),
    TextureBinding1D = unchecked((uint)0x8068),
    TextureBinding2D = unchecked((uint)0x8069),
    VertexArray = unchecked((uint)0x8074),
    TextureBinding3D = unchecked((uint)0x806A),
    PackSkipImages = unchecked((uint)0x806B),
    PackImageHeight = unchecked((uint)0x806C),
    UnpackSkipImages = unchecked((uint)0x806D),
    UnpackImageHeight = unchecked((uint)0x806E),
    Max3DTextureSize = unchecked((uint)0x8073),
    MaxElementsVertices = unchecked((uint)0x80E8),
    MaxElementsIndices = unchecked((uint)0x80E9),
    SmoothPointSizeRange = unchecked((uint)0x0B12),
    SmoothPointSizeGranularity = unchecked((uint)0x0B13),
    SmoothLineWidthRange = unchecked((uint)0x0B22),
    SmoothLineWidthGranularity = unchecked((uint)0x0B23),
    AliasedLineWidthRange = unchecked((uint)0x846E),
    ActiveTexture = unchecked((uint)0x84E0),
    SampleBuffers = unchecked((uint)0x80A8),
    Samples = unchecked((uint)0x80A9),
    SampleCoverageValue = unchecked((uint)0x80AA),
    SampleCoverageInvert = unchecked((uint)0x80AB),
    TextureBindingCubeMap = unchecked((uint)0x8514),
    MaxCubeMapTextureSize = unchecked((uint)0x851C),
    TextureCompressionHint = unchecked((uint)0x84EF),
    NumCompressedTextureFormats = unchecked((uint)0x86A2),
    CompressedTextureFormats = unchecked((uint)0x86A3),
    BlendDstRgb = unchecked((uint)0x80C8),
    BlendSrcRgb = unchecked((uint)0x80C9),
    BlendDstAlpha = unchecked((uint)0x80CA),
    BlendSrcAlpha = unchecked((uint)0x80CB),
    PointFadeThresholdSize = unchecked((uint)0x8128),
    MaxTextureLodBias = unchecked((uint)0x84FD),
    BlendColor = unchecked((uint)0x8005),
    BlendEquation = unchecked((uint)0x8009),
    ArrayBufferBinding = unchecked((uint)0x8894),
    ElementArrayBufferBinding = unchecked((uint)0x8895),
    BlendEquationRgb = unchecked((uint)0x8009),
    StencilBackFunc = unchecked((uint)0x8800),
    StencilBackFail = unchecked((uint)0x8801),
    StencilBackPassDepthFail = unchecked((uint)0x8802),
    StencilBackPassDepthPass = unchecked((uint)0x8803),
    MaxDrawBuffers = unchecked((uint)0x8824),
    BlendEquationAlpha = unchecked((uint)0x883D),
    MaxVertexAttribs = unchecked((uint)0x8869),
    MaxTextureImageUnits = unchecked((uint)0x8872),
    MaxFragmentUniformComponents = unchecked((uint)0x8B49),
    MaxVertexUniformComponents = unchecked((uint)0x8B4A),
    MaxVaryingFloats = unchecked((uint)0x8B4B),
    MaxVertexTextureImageUnits = unchecked((uint)0x8B4C),
    MaxCombinedTextureImageUnits = unchecked((uint)0x8B4D),
    FragmentShaderDerivativeHint = unchecked((uint)0x8B8B),
    CurrentProgram = unchecked((uint)0x8B8D),
    StencilBackRef = unchecked((uint)0x8CA3),
    StencilBackValueMask = unchecked((uint)0x8CA4),
    StencilBackWritemask = unchecked((uint)0x8CA5),
    PixelPackBufferBinding = unchecked((uint)0x88ED),
    PixelUnpackBufferBinding = unchecked((uint)0x88EF),
    MaxClipDistances = unchecked((uint)0x0D32),
    MajorVersion = unchecked((uint)0x821B),
    MinorVersion = unchecked((uint)0x821C),
    NumExtensions = unchecked((uint)0x821D),
    ContextFlags = unchecked((uint)0x821E),
    MaxArrayTextureLayers = unchecked((uint)0x88FF),
    MinProgramTexelOffset = unchecked((uint)0x8904),
    MaxProgramTexelOffset = unchecked((uint)0x8905),
    MaxVaryingComponents = unchecked((uint)0x8B4B),
    TextureBinding1DArray = unchecked((uint)0x8C1C),
    TextureBinding2DArray = unchecked((uint)0x8C1D),
    TransformFeedbackBufferStart = unchecked((uint)0x8C84),
    TransformFeedbackBufferSize = unchecked((uint)0x8C85),
    TransformFeedbackBufferBinding = unchecked((uint)0x8C8F),
    MaxRenderbufferSize = unchecked((uint)0x84E8),
    DrawFramebufferBinding = unchecked((uint)0x8CA6),
    RenderbufferBinding = unchecked((uint)0x8CA7),
    ReadFramebufferBinding = unchecked((uint)0x8CAA),
    MaxColorAttachments = unchecked((uint)0x8CDF),
    VertexArrayBinding = unchecked((uint)0x85B5),
    MaxTextureBufferSize = unchecked((uint)0x8C2B),
    TextureBindingBuffer = unchecked((uint)0x8C2C),
    TextureBindingRectAngle = unchecked((uint)0x84F6),
    MaxRectangleTextureSize = unchecked((uint)0x84F8),
    PrimitiveRestartIndex = unchecked((uint)0x8F9E),
    UniformBufferBinding = unchecked((uint)0x8A28),
    UniformBufferStart = unchecked((uint)0x8A29),
    UniformBufferSize = unchecked((uint)0x8A2A),
    MaxVertexUniformBlocks = unchecked((uint)0x8A2B),
    MaxGeometryUniformBlocks = unchecked((uint)0x8A2C),
    MaxFragmentUniformBlocks = unchecked((uint)0x8A2D),
    MaxCombinedUniformBlocks = unchecked((uint)0x8A2E),
    MaxUniformBufferBindings = unchecked((uint)0x8A2F),
    MaxUniformBlockSize = unchecked((uint)0x8A30),
    MaxCombinedVertexUniformComponents = unchecked((uint)0x8A31),
    MaxCombinedGeometryUniformComponents = unchecked((uint)0x8A32),
    MaxCombinedFragmentUniformComponents = unchecked((uint)0x8A33),
    UniformBufferOffsetAlignment = unchecked((uint)0x8A34),
    ProgramPointSize = unchecked((uint)0x8642),
    MaxGeometryTextureImageUnits = unchecked((uint)0x8C29),
    MaxGeometryUniformComponents = unchecked((uint)0x8DDF),
    MaxVertexOutputComponents = unchecked((uint)0x9122),
    MaxGeometryInputComponents = unchecked((uint)0x9123),
    MaxGeometryOutputComponents = unchecked((uint)0x9124),
    MaxFragmentInputComponents = unchecked((uint)0x9125),
    ContextProfileMask = unchecked((uint)0x9126),
    ProvokingVertex = unchecked((uint)0x8E4F),
    MaxServerWaitTimeout = unchecked((uint)0x9111),
    MaxSampleMaskWords = unchecked((uint)0x8E59),
    TextureBinding2DMultisample = unchecked((uint)0x9104),
    TextureBinding2DMultisampleArray = unchecked((uint)0x9105),
    MaxColorTextureSamples = unchecked((uint)0x910E),
    MaxDepthTextureSamples = unchecked((uint)0x910F),
    MaxIntegerSamples = unchecked((uint)0x9110),
    MaxDualSourceDrawBuffers = unchecked((uint)0x88FC),
    SamplerBinding = unchecked((uint)0x8919),
    Timestamp = unchecked((uint)0x8E28),
    MaxTessControlUniformBlocks = unchecked((uint)0x8E89),
    MaxTessEvaluationUniformBlocks = unchecked((uint)0x8E8A),
    ImplementationColorReadType = unchecked((uint)0x8B9A),
    ImplementationColorReadFormat = unchecked((uint)0x8B9B),
    ShaderCompiler = unchecked((uint)0x8DFA),
    ShaderBinaryFormats = unchecked((uint)0x8DF8),
    NumShaderBinaryFormats = unchecked((uint)0x8DF9),
    MaxVertexUniformVectors = unchecked((uint)0x8DFB),
    MaxVaryingVectors = unchecked((uint)0x8DFC),
    MaxFragmentUniformVectors = unchecked((uint)0x8DFD),
    NumProgramBinaryFormats = unchecked((uint)0x87FE),
    ProgramBinaryFormats = unchecked((uint)0x87FF),
    ProgramPipelineBinding = unchecked((uint)0x825A),
    MaxViewports = unchecked((uint)0x825B),
    ViewportSubpixelBits = unchecked((uint)0x825C),
    ViewportBoundsRange = unchecked((uint)0x825D),
    LayerProvokingVertex = unchecked((uint)0x825E),
    ViewportIndexProvokingVertex = unchecked((uint)0x825F),
    MinMapBufferAlignment = unchecked((uint)0x90BC),
    MaxVertexAtomicCounters = unchecked((uint)0x92D2),
    MaxTessControlAtomicCounters = unchecked((uint)0x92D3),
    MaxTessEvaluationAtomicCounters = unchecked((uint)0x92D4),
    MaxGeometryAtomicCounters = unchecked((uint)0x92D5),
    MaxFragmentAtomicCounters = unchecked((uint)0x92D6),
    MaxCombinedAtomicCounters = unchecked((uint)0x92D7),
    MaxElementIndex = unchecked((uint)0x8D6B),
    MaxComputeUniformBlocks = unchecked((uint)0x91BB),
    MaxComputeTextureImageUnits = unchecked((uint)0x91BC),
    MaxComputeUniformComponents = unchecked((uint)0x8263),
    MaxComputeAtomicCounterBuffers = unchecked((uint)0x8264),
    MaxComputeAtomicCounters = unchecked((uint)0x8265),
    MaxCombinedComputeUniformComponents = unchecked((uint)0x8266),
    MaxComputeWorkGroupInvocations = unchecked((uint)0x90EB),
    MaxComputeWorkGroupCount = unchecked((uint)0x91BE),
    MaxComputeWorkGroupSize = unchecked((uint)0x91BF),
    DispatchIndirectBufferBinding = unchecked((uint)0x90EF),
    MaxDebugGroupStackDepth = unchecked((uint)0x826C),
    DebugGroupStackDepth = unchecked((uint)0x826D),
    MaxLabelLength = unchecked((uint)0x82E8),
    MaxUniformLocations = unchecked((uint)0x826E),
    MaxFramebufferWidth = unchecked((uint)0x9315),
    MaxFramebufferHeight = unchecked((uint)0x9316),
    MaxFramebufferLayers = unchecked((uint)0x9317),
    MaxFramebufferSamples = unchecked((uint)0x9318),
    ShaderStorageBufferBinding = unchecked((uint)0x90D3),
    ShaderStorageBufferStart = unchecked((uint)0x90D4),
    ShaderStorageBufferSize = unchecked((uint)0x90D5),
    MaxVertexShaderStorageBlocks = unchecked((uint)0x90D6),
    MaxGeometryShaderStorageBlocks = unchecked((uint)0x90D7),
    MaxTessControlShaderStorageBlocks = unchecked((uint)0x90D8),
    MaxTessEvaluationShaderStorageBlocks = unchecked((uint)0x90D9),
    MaxFragmentShaderStorageBlocks = unchecked((uint)0x90DA),
    MaxComputeShaderStorageBlocks = unchecked((uint)0x90DB),
    MaxCombinedShaderStorageBlocks = unchecked((uint)0x90DC),
    MaxShaderStorageBufferBindings = unchecked((uint)0x90DD),
    ShaderStorageBufferOffsetAlignment = unchecked((uint)0x90DF),
    TextureBufferOffsetAlignment = unchecked((uint)0x919F),
    VertexBindingDivisor = unchecked((uint)0x82D6),
    VertexBindingOffset = unchecked((uint)0x82D7),
    VertexBindingStride = unchecked((uint)0x82D8),
    MaxVertexAttribRelativeOffset = unchecked((uint)0x82D9),
    MaxVertexAttribBindings = unchecked((uint)0x82DA),
    ShadingRateImagePerPrimitiveNV = unchecked((uint)0x95B1),
    ShadingRateImagePaletteCountNV = unchecked((uint)0x95B2),
    CurrentColor = unchecked((uint)0x0B00),
    CurrentIndex = unchecked((uint)0x0B01),
    CurrentNormal = unchecked((uint)0x0B02),
    CurrentTextureCoords = unchecked((uint)0x0B03),
    CurrentRasterColor = unchecked((uint)0x0B04),
    CurrentRasterIndex = unchecked((uint)0x0B05),
    CurrentRasterTextureCoords = unchecked((uint)0x0B06),
    CurrentRasterPosition = unchecked((uint)0x0B07),
    CurrentRasterPositionValid = unchecked((uint)0x0B08),
    CurrentRasterDistance = unchecked((uint)0x0B09),
    PointSmooth = unchecked((uint)0x0B10),
    LineStipple = unchecked((uint)0x0B24),
    LineStipplePattern = unchecked((uint)0x0B25),
    LineStippleRepeat = unchecked((uint)0x0B26),
    ListMode = unchecked((uint)0x0B30),
    MaxListNesting = unchecked((uint)0x0B31),
    ListBase = unchecked((uint)0x0B32),
    ListIndex = unchecked((uint)0x0B33),
    PolygonStipple = unchecked((uint)0x0B42),
    EdgeFlag = unchecked((uint)0x0B43),
    Lighting = unchecked((uint)0x0B50),
    LightModelLocalViewer = unchecked((uint)0x0B51),
    LightModelTwoSide = unchecked((uint)0x0B52),
    LightModelAmbient = unchecked((uint)0x0B53),
    ShadeModel = unchecked((uint)0x0B54),
    ColorMaterialFace = unchecked((uint)0x0B55),
    ColorMaterialParameter = unchecked((uint)0x0B56),
    ColorMaterial = unchecked((uint)0x0B57),
    FOG = unchecked((uint)0x0B60),
    FogIndex = unchecked((uint)0x0B61),
    FogDensity = unchecked((uint)0x0B62),
    FogStart = unchecked((uint)0x0B63),
    FogEnd = unchecked((uint)0x0B64),
    FogMode = unchecked((uint)0x0B65),
    FogColor = unchecked((uint)0x0B66),
    AccumClearValue = unchecked((uint)0x0B80),
    MatrixMode = unchecked((uint)0x0BA0),
    Normalize = unchecked((uint)0x0BA1),
    ModelviewStackDepth = unchecked((uint)0x0BA3),
    ProjectionStackDepth = unchecked((uint)0x0BA4),
    TextureStackDepth = unchecked((uint)0x0BA5),
    ModelviewMatrix = unchecked((uint)0x0BA6),
    ProjectionMatrix = unchecked((uint)0x0BA7),
    TextureMatrix = unchecked((uint)0x0BA8),
    AttribStackDepth = unchecked((uint)0x0BB0),
    AlphaTest = unchecked((uint)0x0BC0),
    AlphaTestFunc = unchecked((uint)0x0BC1),
    AlphaTestRef = unchecked((uint)0x0BC2),
    LogicOp = unchecked((uint)0x0BF1),
    AuxBuffers = unchecked((uint)0x0C00),
    IndexClearValue = unchecked((uint)0x0C20),
    IndexWritemask = unchecked((uint)0x0C21),
    IndexMode = unchecked((uint)0x0C30),
    RgbaMode = unchecked((uint)0x0C31),
    RenderMode = unchecked((uint)0x0C40),
    PerspectiveCorrectionHint = unchecked((uint)0x0C50),
    PointSmoothHint = unchecked((uint)0x0C51),
    FogHint = unchecked((uint)0x0C54),
    TextureGenS = unchecked((uint)0x0C60),
    TextureGenT = unchecked((uint)0x0C61),
    TextureGenR = unchecked((uint)0x0C62),
    TextureGenQ = unchecked((uint)0x0C63),
    PixelMapIToISize = unchecked((uint)0x0CB0),
    PixelMapSToSSize = unchecked((uint)0x0CB1),
    PixelMapIToRSize = unchecked((uint)0x0CB2),
    PixelMapIToGSize = unchecked((uint)0x0CB3),
    PixelMapIToBSize = unchecked((uint)0x0CB4),
    PixelMapIToASize = unchecked((uint)0x0CB5),
    PixelMapRToRSize = unchecked((uint)0x0CB6),
    PixelMapGToGSize = unchecked((uint)0x0CB7),
    PixelMapBToBSize = unchecked((uint)0x0CB8),
    PixelMapAToASize = unchecked((uint)0x0CB9),
    MapColor = unchecked((uint)0x0D10),
    MapStencil = unchecked((uint)0x0D11),
    IndexShift = unchecked((uint)0x0D12),
    IndexOffset = unchecked((uint)0x0D13),
    RedScale = unchecked((uint)0x0D14),
    RedBias = unchecked((uint)0x0D15),
    ZoomX = unchecked((uint)0x0D16),
    ZoomY = unchecked((uint)0x0D17),
    GreenScale = unchecked((uint)0x0D18),
    GreenBias = unchecked((uint)0x0D19),
    BlueScale = unchecked((uint)0x0D1A),
    BlueBias = unchecked((uint)0x0D1B),
    AlphaScale = unchecked((uint)0x0D1C),
    AlphaBias = unchecked((uint)0x0D1D),
    DepthScale = unchecked((uint)0x0D1E),
    DepthBias = unchecked((uint)0x0D1F),
    MaxEvalOrder = unchecked((uint)0x0D30),
    MaxLights = unchecked((uint)0x0D31),
    MaxClipPlanes = unchecked((uint)0x0D32),
    MaxPixelMapTable = unchecked((uint)0x0D34),
    MaxAttribStackDepth = unchecked((uint)0x0D35),
    MaxModelviewStackDepth = unchecked((uint)0x0D36),
    MaxNameStackDepth = unchecked((uint)0x0D37),
    MaxProjectionStackDepth = unchecked((uint)0x0D38),
    MaxTextureStackDepth = unchecked((uint)0x0D39),
    IndexBits = unchecked((uint)0x0D51),
    RedBits = unchecked((uint)0x0D52),
    GreenBits = unchecked((uint)0x0D53),
    BlueBits = unchecked((uint)0x0D54),
    AlphaBits = unchecked((uint)0x0D55),
    DepthBits = unchecked((uint)0x0D56),
    StencilBits = unchecked((uint)0x0D57),
    AccumRedBits = unchecked((uint)0x0D58),
    AccumGreenBits = unchecked((uint)0x0D59),
    AccumBlueBits = unchecked((uint)0x0D5A),
    AccumAlphaBits = unchecked((uint)0x0D5B),
    NameStackDepth = unchecked((uint)0x0D70),
    AutoNormal = unchecked((uint)0x0D80),
    Map1Color4 = unchecked((uint)0x0D90),
    Map1Index = unchecked((uint)0x0D91),
    Map1Normal = unchecked((uint)0x0D92),
    Map1TextureCoord1 = unchecked((uint)0x0D93),
    Map1TextureCoord2 = unchecked((uint)0x0D94),
    Map1TextureCoord3 = unchecked((uint)0x0D95),
    Map1TextureCoord4 = unchecked((uint)0x0D96),
    Map1Vertex3 = unchecked((uint)0x0D97),
    Map1Vertex4 = unchecked((uint)0x0D98),
    Map2Color4 = unchecked((uint)0x0DB0),
    Map2Index = unchecked((uint)0x0DB1),
    Map2Normal = unchecked((uint)0x0DB2),
    Map2TextureCoord1 = unchecked((uint)0x0DB3),
    Map2TextureCoord2 = unchecked((uint)0x0DB4),
    Map2TextureCoord3 = unchecked((uint)0x0DB5),
    Map2TextureCoord4 = unchecked((uint)0x0DB6),
    Map2Vertex3 = unchecked((uint)0x0DB7),
    Map2Vertex4 = unchecked((uint)0x0DB8),
    Map1GridDomain = unchecked((uint)0x0DD0),
    Map1GridSegments = unchecked((uint)0x0DD1),
    Map2GridDomain = unchecked((uint)0x0DD2),
    Map2GridSegments = unchecked((uint)0x0DD3),
    ClipPlane0 = unchecked((uint)0x3000),
    ClipPlane1 = unchecked((uint)0x3001),
    ClipPlane2 = unchecked((uint)0x3002),
    ClipPlane3 = unchecked((uint)0x3003),
    ClipPlane4 = unchecked((uint)0x3004),
    ClipPlane5 = unchecked((uint)0x3005),
    Light0 = unchecked((uint)0x4000),
    Light1 = unchecked((uint)0x4001),
    Light2 = unchecked((uint)0x4002),
    Light3 = unchecked((uint)0x4003),
    Light4 = unchecked((uint)0x4004),
    Light5 = unchecked((uint)0x4005),
    Light6 = unchecked((uint)0x4006),
    Light7 = unchecked((uint)0x4007),
    ClientAttribStackDepth = unchecked((uint)0x0BB1),
    IndexLogicOp = unchecked((uint)0x0BF1),
    MaxClientAttribStackDepth = unchecked((uint)0x0D3B),
    FeedbackBufferSize = unchecked((uint)0x0DF1),
    FeedbackBufferType = unchecked((uint)0x0DF2),
    SelectionBufferSize = unchecked((uint)0x0DF4),
    NormalArray = unchecked((uint)0x8075),
    ColorArray = unchecked((uint)0x8076),
    IndexArray = unchecked((uint)0x8077),
    TextureCoordArray = unchecked((uint)0x8078),
    EdgeFlagArray = unchecked((uint)0x8079),
    VertexArraySize = unchecked((uint)0x807A),
    VertexArrayType = unchecked((uint)0x807B),
    VertexArrayStride = unchecked((uint)0x807C),
    NormalArrayType = unchecked((uint)0x807E),
    NormalArrayStride = unchecked((uint)0x807F),
    ColorArraySize = unchecked((uint)0x8081),
    ColorArrayType = unchecked((uint)0x8082),
    ColorArrayStride = unchecked((uint)0x8083),
    IndexArrayType = unchecked((uint)0x8085),
    IndexArrayStride = unchecked((uint)0x8086),
    TextureCoordArraySize = unchecked((uint)0x8088),
    TextureCoordArrayType = unchecked((uint)0x8089),
    TextureCoordArrayStride = unchecked((uint)0x808A),
    EdgeFlagArrayStride = unchecked((uint)0x808C),
    LightModelColorControl = unchecked((uint)0x81F8),
    AliasedPointSizeRange = unchecked((uint)0x846D),
    PointSizeMin = unchecked((uint)0x8126),
    PointSizeMax = unchecked((uint)0x8127),
    PointDistanceAttenuation = unchecked((uint)0x8129),
    PointSizeMinARB = unchecked((uint)0x8126),
    PointSizeMaxARB = unchecked((uint)0x8127),
    PointFadeThresholdSizeARB = unchecked((uint)0x8128),
    PointDistanceAttenuationARB = unchecked((uint)0x8129),
    TextureBindingCubeMapARB = unchecked((uint)0x8514),
    MaxCubeMapTextureSizeARB = unchecked((uint)0x851C),
    TextureBindingRectangleARB = unchecked((uint)0x84F6),
    FragmentShaderATI = unchecked((uint)0x8920),
    BlendColorEXT = unchecked((uint)0x8005),
    BlendEquationEXT = unchecked((uint)0x8009),
    PackCmykHintEXT = unchecked((uint)0x800E),
    UnpackCmykHintEXT = unchecked((uint)0x800F),
    Convolution1DEXT = unchecked((uint)0x8010),
    Convolution2DEXT = unchecked((uint)0x8011),
    Separable2DEXT = unchecked((uint)0x8012),
    PostConvolutionRedScaleEXT = unchecked((uint)0x801C),
    PostConvolutionGreenScaleEXT = unchecked((uint)0x801D),
    PostConvolutionBlueScaleEXT = unchecked((uint)0x801E),
    PostConvolutionAlphaScaleEXT = unchecked((uint)0x801F),
    PostConvolutionRedBiasEXT = unchecked((uint)0x8020),
    PostConvolutionGreenBiasEXT = unchecked((uint)0x8021),
    PostConvolutionBlueBiasEXT = unchecked((uint)0x8022),
    PostConvolutionAlphaBiasEXT = unchecked((uint)0x8023),
    MaxColorAttachmentsEXT = unchecked((uint)0x8CDF),
    HistogramEXT = unchecked((uint)0x8024),
    MinmaxEXT = unchecked((uint)0x802E),
    NumDeviceUuidsEXT = unchecked((uint)0x9596),
    DeviceUuidEXT = unchecked((uint)0x9597),
    DriverUuidEXT = unchecked((uint)0x9598),
    DeviceLuidEXT = unchecked((uint)0x9599),
    DeviceNodeMaskEXT = unchecked((uint)0x959A),
    PointSizeMinEXT = unchecked((uint)0x8126),
    PointSizeMaxEXT = unchecked((uint)0x8127),
    PointFadeThresholdSizeEXT = unchecked((uint)0x8128),
    DistanceAttenuationEXT = unchecked((uint)0x8129),
    PolygonOffsetBiasEXT = unchecked((uint)0x8039),
    RescaleNormalEXT = unchecked((uint)0x803A),
    SharedTexturePaletteEXT = unchecked((uint)0x81FB),
    PackSkipImagesEXT = unchecked((uint)0x806B),
    PackImageHeightEXT = unchecked((uint)0x806C),
    UnpackSkipImagesEXT = unchecked((uint)0x806D),
    UnpackImageHeightEXT = unchecked((uint)0x806E),
    Texture3DEXT = unchecked((uint)0x806F),
    Max3DTextureSizeEXT = unchecked((uint)0x8073),
    TextureBindingCubeMapEXT = unchecked((uint)0x8514),
    MaxCubeMapTextureSizeEXT = unchecked((uint)0x851C),
    Texture3DBindingEXT = unchecked((uint)0x806A),
    VertexArrayCountEXT = unchecked((uint)0x807D),
    NormalArrayCountEXT = unchecked((uint)0x8080),
    ColorArrayCountEXT = unchecked((uint)0x8084),
    IndexArrayCountEXT = unchecked((uint)0x8087),
    TextureCoordArrayCountEXT = unchecked((uint)0x808B),
    EdgeFlagArrayCountEXT = unchecked((uint)0x808D),
    Modelview0StackDepthEXT = unchecked((uint)0x0BA3),
    Modelview0MatrixEXT = unchecked((uint)0x0BA6),
    TextureBindingRectangleNV = unchecked((uint)0x84F6),
    MaxTimelineSemaphoreValueDifferenceNV = unchecked((uint)0x95B6),
    DetailTexture2DBindingSGIS = unchecked((uint)0x8096),
    FogFuncPointsSGIS = unchecked((uint)0x812B),
    MaxFogFuncPointsSGIS = unchecked((uint)0x812C),
    GenerateMipmapHintSGIS = unchecked((uint)0x8192),
    MultisampleSGIS = unchecked((uint)0x809D),
    SampleAlphaToMaskSGIS = unchecked((uint)0x809E),
    SampleAlphaToOneSGIS = unchecked((uint)0x809F),
    SampleMaskSGIS = unchecked((uint)0x80A0),
    SampleBuffersSGIS = unchecked((uint)0x80A8),
    SamplesSGIS = unchecked((uint)0x80A9),
    SampleMaskValueSGIS = unchecked((uint)0x80AA),
    SampleMaskInvertSGIS = unchecked((uint)0x80AB),
    SamplePatternSGIS = unchecked((uint)0x80AC),
    PixelTextureSGIS = unchecked((uint)0x8353),
    PointSizeMinSGIS = unchecked((uint)0x8126),
    PointSizeMaxSGIS = unchecked((uint)0x8127),
    PointFadeThresholdSizeSGIS = unchecked((uint)0x8128),
    DistanceAttenuationSGIS = unchecked((uint)0x8129),
    PackSkipVolumesSGIS = unchecked((uint)0x8130),
    PackImageDepthSGIS = unchecked((uint)0x8131),
    UnpackSkipVolumesSGIS = unchecked((uint)0x8132),
    UnpackImageDepthSGIS = unchecked((uint)0x8133),
    Texture4DSGIS = unchecked((uint)0x8134),
    Max4DTextureSizeSGIS = unchecked((uint)0x8138),
    Texture4DBindingSGIS = unchecked((uint)0x814F),
    AsyncMarkerSGIX = unchecked((uint)0x8329),
    AsyncHistogramSGIX = unchecked((uint)0x832C),
    MaxAsyncHistogramSGIX = unchecked((uint)0x832D),
    AsyncTexImageSGIX = unchecked((uint)0x835C),
    AsyncDrawPixelsSGIX = unchecked((uint)0x835D),
    AsyncReadPixelsSGIX = unchecked((uint)0x835E),
    MaxAsyncTexImageSGIX = unchecked((uint)0x835F),
    MaxAsyncDrawPixelsSGIX = unchecked((uint)0x8360),
    MaxAsyncReadPixelsSGIX = unchecked((uint)0x8361),
    CalligraphicFragmentSGIX = unchecked((uint)0x8183),
    MaxClipmapDepthSGIX = unchecked((uint)0x8177),
    MaxClipmapVirtualDepthSGIX = unchecked((uint)0x8178),
    ConvolutionHintSGIX = unchecked((uint)0x8316),
    FogOffsetSGIX = unchecked((uint)0x8198),
    FogOffsetValueSGIX = unchecked((uint)0x8199),
    FragmentLightingSGIX = unchecked((uint)0x8400),
    FragmentColorMaterialSGIX = unchecked((uint)0x8401),
    FragmentColorMaterialFaceSGIX = unchecked((uint)0x8402),
    FragmentColorMaterialParameterSGIX = unchecked((uint)0x8403),
    MaxFragmentLightsSGIX = unchecked((uint)0x8404),
    MaxActiveLightsSGIX = unchecked((uint)0x8405),
    LightEnvModeSGIX = unchecked((uint)0x8407),
    FragmentLightModelLocalViewerSGIX = unchecked((uint)0x8408),
    FragmentLightModelTwoSideSGIX = unchecked((uint)0x8409),
    FragmentLightModelAmbientSGIX = unchecked((uint)0x840A),
    FragmentLightModelNormalInterpolationSGIX = unchecked((uint)0x840B),
    FragmentLight0SGIX = unchecked((uint)0x840C),
    FramezoomSGIX = unchecked((uint)0x818B),
    FramezoomFactorSGIX = unchecked((uint)0x818C),
    MaxFramezoomFactorSGIX = unchecked((uint)0x818D),
    InstrumentMeasurementsSGIX = unchecked((uint)0x8181),
    InterlaceSGIX = unchecked((uint)0x8094),
    IrInstrument1SGIX = unchecked((uint)0x817F),
    PixelTexGenSGIX = unchecked((uint)0x8139),
    PixelTexGenModeSGIX = unchecked((uint)0x832B),
    PixelTileBestAlignmentSGIX = unchecked((uint)0x813E),
    PixelTileCacheIncrementSGIX = unchecked((uint)0x813F),
    PixelTileWidthSGIX = unchecked((uint)0x8140),
    PixelTileHeightSGIX = unchecked((uint)0x8141),
    PixelTileGridWidthSGIX = unchecked((uint)0x8142),
    PixelTileGridHeightSGIX = unchecked((uint)0x8143),
    PixelTileGridDepthSGIX = unchecked((uint)0x8144),
    PixelTileCacheSizeSGIX = unchecked((uint)0x8145),
    DeformationsMaskSGIX = unchecked((uint)0x8196),
    ReferencePlaneSGIX = unchecked((uint)0x817D),
    ReferencePlaneEquationSGIX = unchecked((uint)0x817E),
    PackResampleSGIX = unchecked((uint)0x842E),
    UnpackResampleSGIX = unchecked((uint)0x842F),
    SpriteSGIX = unchecked((uint)0x8148),
    SpriteModeSGIX = unchecked((uint)0x8149),
    SpriteAxisSGIX = unchecked((uint)0x814A),
    SpriteTranslationSGIX = unchecked((uint)0x814B),
    PackSubsampleRateSGIX = unchecked((uint)0x85A0),
    UnpackSubsampleRateSGIX = unchecked((uint)0x85A1),
    PostTextureFilterBiasRangeSGIX = unchecked((uint)0x817B),
    PostTextureFilterScaleRangeSGIX = unchecked((uint)0x817C),
    VertexPreclipSGIX = unchecked((uint)0x83EE),
    VertexPreclipHintSGIX = unchecked((uint)0x83EF),
    ColorMatrixSGI = unchecked((uint)0x80B1),
    ColorMatrixStackDepthSGI = unchecked((uint)0x80B2),
    MaxColorMatrixStackDepthSGI = unchecked((uint)0x80B3),
    PostColorMatrixRedScaleSGI = unchecked((uint)0x80B4),
    PostColorMatrixGreenScaleSGI = unchecked((uint)0x80B5),
    PostColorMatrixBlueScaleSGI = unchecked((uint)0x80B6),
    PostColorMatrixAlphaScaleSGI = unchecked((uint)0x80B7),
    PostColorMatrixRedBiasSGI = unchecked((uint)0x80B8),
    PostColorMatrixGreenBiasSGI = unchecked((uint)0x80B9),
    PostColorMatrixBlueBiasSGI = unchecked((uint)0x80BA),
    PostColorMatrixAlphaBiasSGI = unchecked((uint)0x80BB),
    ColorTableSGI = unchecked((uint)0x80D0),
    PostConvolutionColorTableSGI = unchecked((uint)0x80D1),
    PostColorMatrixColorTableSGI = unchecked((uint)0x80D2),
    TextureColorTableSGI = unchecked((uint)0x80BC),
    BlendEquationOES = unchecked((uint)0x8009),
    TextureBindingCubeMapOES = unchecked((uint)0x8514),
    MaxCubeMapTextureSizeOES = unchecked((uint)0x851C),
    TextureGenStrOES = unchecked((uint)0x8D60),
    FetchPerSampleARM = unchecked((uint)0x8F65),
    FragmentShaderFramebufferFetchMrtARM = unchecked((uint)0x8F66),
    TimestampEXT = unchecked((uint)0x8E28),
    ShadingRateEXT = unchecked((uint)0x96D0),
    MinFragmentShadingRateAttachmentTexelWidthEXT = unchecked((uint)0x96D7),
    MaxFragmentShadingRateAttachmentTexelWidthEXT = unchecked((uint)0x96D8),
    MinFragmentShadingRateAttachmentTexelHeightEXT = unchecked((uint)0x96D9),
    MaxFragmentShadingRateAttachmentTexelHeightEXT = unchecked((uint)0x96DA),
    MaxFragmentShadingRateAttachmentTexelAspectRatioEXT = unchecked((uint)0x96DB),
    MaxFragmentShadingRateAttachmentLayersEXT = unchecked((uint)0x96DC),
    FragmentShadingRateWithShaderDepthStencilWritesSupportedEXT = unchecked((uint)0x96DD),
    FragmentShadingRateWithSampleMaskSupportedEXT = unchecked((uint)0x96DE),
    FragmentShadingRateAttachmentWithDefaultFramebufferSupportedEXT = unchecked((uint)0x96DF),
    FragmentShadingRateNonTrivialCombinersSupportedEXT = unchecked((uint)0x8F6F),
    DrawBufferEXT = unchecked((uint)0x0C01),
    ReadBufferEXT = unchecked((uint)0x0C02),
    MaxColorAttachmentsNV = unchecked((uint)0x8CDF),
    PackRowLengthNV = unchecked((uint)0x0D02),
    PackSkipRowsNV = unchecked((uint)0x0D03),
    PackSkipPixelsNV = unchecked((uint)0x0D04),
    ReadBufferNV = unchecked((uint)0x0C02),
    AlphaTestQCOM = unchecked((uint)0x0BC0),
    AlphaTestFuncQCOM = unchecked((uint)0x0BC1),
    AlphaTestRefQCOM = unchecked((uint)0x0BC2),
    MotionEstimationSearchBlockXQCOM = unchecked((uint)0x8C90),
    MotionEstimationSearchBlockYQCOM = unchecked((uint)0x8C91),
    FramebufferFetchNoncoherentQCOM = unchecked((uint)0x96A2),
    ShadingRateQCOM = unchecked((uint)0x96A4)
}