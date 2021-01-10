// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL
{
    [NativeName("Name", "GLenum")]
    public enum EGLEnum : int
    {
        [NativeName("Name", "EGL_ALPHA_SIZE")]
        AlphaSize = 0x3021,
        [NativeName("Name", "EGL_BAD_ACCESS")]
        BadAccess = 0x3002,
        [NativeName("Name", "EGL_BAD_ALLOC")]
        BadAlloc = 0x3003,
        [NativeName("Name", "EGL_BAD_ATTRIBUTE")]
        BadAttribute = 0x3004,
        [NativeName("Name", "EGL_BAD_CONFIG")]
        BadConfig = 0x3005,
        [NativeName("Name", "EGL_BAD_CONTEXT")]
        BadContext = 0x3006,
        [NativeName("Name", "EGL_BAD_CURRENT_SURFACE")]
        BadCurrentSurface = 0x3007,
        [NativeName("Name", "EGL_BAD_DISPLAY")]
        BadDisplay = 0x3008,
        [NativeName("Name", "EGL_BAD_MATCH")]
        BadMatch = 0x3009,
        [NativeName("Name", "EGL_BAD_NATIVE_PIXMAP")]
        BadNativePixmap = 0x300A,
        [NativeName("Name", "EGL_BAD_NATIVE_WINDOW")]
        BadNativeWindow = 0x300B,
        [NativeName("Name", "EGL_BAD_PARAMETER")]
        BadParameter = 0x300C,
        [NativeName("Name", "EGL_BAD_SURFACE")]
        BadSurface = 0x300D,
        [NativeName("Name", "EGL_BLUE_SIZE")]
        BlueSize = 0x3022,
        [NativeName("Name", "EGL_BUFFER_SIZE")]
        BufferSize = 0x3020,
        [NativeName("Name", "EGL_CONFIG_CAVEAT")]
        ConfigCaveat = 0x3027,
        [NativeName("Name", "EGL_CONFIG_ID")]
        ConfigID = 0x3028,
        [NativeName("Name", "EGL_CORE_NATIVE_ENGINE")]
        CoreNativeEngine = 0x305B,
        [NativeName("Name", "EGL_DEPTH_SIZE")]
        DepthSize = 0x3025,
        [NativeName("Name", "EGL_DONT_CARE")]
        DontCare = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_DRAW")]
        Draw = 0x3059,
        [NativeName("Name", "EGL_EXTENSIONS")]
        Extensions = 0x3055,
        [NativeName("Name", "EGL_FALSE")]
        False = 0x0,
        [NativeName("Name", "EGL_GREEN_SIZE")]
        GreenSize = 0x3023,
        [NativeName("Name", "EGL_HEIGHT")]
        Height = 0x3056,
        [NativeName("Name", "EGL_LARGEST_PBUFFER")]
        LargestPbuffer = 0x3058,
        [NativeName("Name", "EGL_LEVEL")]
        Level = 0x3029,
        [NativeName("Name", "EGL_MAX_PBUFFER_HEIGHT")]
        MaxPbufferHeight = 0x302A,
        [NativeName("Name", "EGL_MAX_PBUFFER_PIXELS")]
        MaxPbufferPixels = 0x302B,
        [NativeName("Name", "EGL_MAX_PBUFFER_WIDTH")]
        MaxPbufferWidth = 0x302C,
        [NativeName("Name", "EGL_NATIVE_RENDERABLE")]
        NativeRenderable = 0x302D,
        [NativeName("Name", "EGL_NATIVE_VISUAL_ID")]
        NativeVisualID = 0x302E,
        [NativeName("Name", "EGL_NATIVE_VISUAL_TYPE")]
        NativeVisualType = 0x302F,
        [NativeName("Name", "EGL_NONE")]
        None = 0x3038,
        [NativeName("Name", "EGL_NON_CONFORMANT_CONFIG")]
        NonConformantConfig = 0x3051,
        [NativeName("Name", "EGL_NOT_INITIALIZED")]
        NotInitialized = 0x3001,
        [NativeName("Name", "EGL_NO_CONTEXT")]
        NoContext = 0x0,
        [NativeName("Name", "EGL_NO_DISPLAY")]
        NoDisplay = 0x0,
        [NativeName("Name", "EGL_NO_SURFACE")]
        NoSurface = 0x0,
        [NativeName("Name", "EGL_PBUFFER_BIT")]
        PbufferBit = 0x1,
        [NativeName("Name", "EGL_PIXMAP_BIT")]
        PixmapBit = 0x2,
        [NativeName("Name", "EGL_READ")]
        Read = 0x305A,
        [NativeName("Name", "EGL_RED_SIZE")]
        RedSize = 0x3024,
        [NativeName("Name", "EGL_SAMPLES")]
        Samples = 0x3031,
        [NativeName("Name", "EGL_SAMPLE_BUFFERS")]
        SampleBuffers = 0x3032,
        [NativeName("Name", "EGL_SLOW_CONFIG")]
        SlowConfig = 0x3050,
        [NativeName("Name", "EGL_STENCIL_SIZE")]
        StencilSize = 0x3026,
        [NativeName("Name", "EGL_SUCCESS")]
        Success = 0x3000,
        [NativeName("Name", "EGL_SURFACE_TYPE")]
        SurfaceType = 0x3033,
        [NativeName("Name", "EGL_TRANSPARENT_BLUE_VALUE")]
        TransparentBlueValue = 0x3035,
        [NativeName("Name", "EGL_TRANSPARENT_GREEN_VALUE")]
        TransparentGreenValue = 0x3036,
        [NativeName("Name", "EGL_TRANSPARENT_RED_VALUE")]
        TransparentRedValue = 0x3037,
        [NativeName("Name", "EGL_TRANSPARENT_RGB")]
        TransparentRgb = 0x3052,
        [NativeName("Name", "EGL_TRANSPARENT_TYPE")]
        TransparentType = 0x3034,
        [NativeName("Name", "EGL_TRUE")]
        True = 0x1,
        [NativeName("Name", "EGL_VENDOR")]
        Vendor = 0x3053,
        [NativeName("Name", "EGL_VERSION")]
        Version = 0x3054,
        [NativeName("Name", "EGL_WIDTH")]
        Width = 0x3057,
        [NativeName("Name", "EGL_WINDOW_BIT")]
        WindowBit = 0x4,
        [NativeName("Name", "EGL_BACK_BUFFER")]
        BackBuffer = 0x3084,
        [NativeName("Name", "EGL_BIND_TO_TEXTURE_RGB")]
        BindToTextureRgb = 0x3039,
        [NativeName("Name", "EGL_BIND_TO_TEXTURE_RGBA")]
        BindToTextureRgba = 0x303A,
        [NativeName("Name", "EGL_CONTEXT_LOST")]
        ContextLost = 0x300E,
        [NativeName("Name", "EGL_MIN_SWAP_INTERVAL")]
        MinSwapInterval = 0x303B,
        [NativeName("Name", "EGL_MAX_SWAP_INTERVAL")]
        MaxSwapInterval = 0x303C,
        [NativeName("Name", "EGL_MIPMAP_TEXTURE")]
        MipmapTexture = 0x3082,
        [NativeName("Name", "EGL_MIPMAP_LEVEL")]
        MipmapLevel = 0x3083,
        [NativeName("Name", "EGL_NO_TEXTURE")]
        NoTexture = 0x305C,
        [NativeName("Name", "EGL_TEXTURE_2D")]
        Texture2D = 0x305F,
        [NativeName("Name", "EGL_TEXTURE_FORMAT")]
        TextureFormat = 0x3080,
        [NativeName("Name", "EGL_TEXTURE_RGB")]
        TextureRgb = 0x305D,
        [NativeName("Name", "EGL_TEXTURE_RGBA")]
        TextureRgba = 0x305E,
        [NativeName("Name", "EGL_TEXTURE_TARGET")]
        TextureTarget = 0x3081,
        [NativeName("Name", "EGL_ALPHA_FORMAT")]
        AlphaFormat = 0x3088,
        [NativeName("Name", "EGL_ALPHA_FORMAT_NONPRE")]
        AlphaFormatNonpre = 0x308B,
        [NativeName("Name", "EGL_ALPHA_FORMAT_PRE")]
        AlphaFormatPre = 0x308C,
        [NativeName("Name", "EGL_ALPHA_MASK_SIZE")]
        AlphaMaskSize = 0x303E,
        [NativeName("Name", "EGL_BUFFER_PRESERVED")]
        BufferPreserved = 0x3094,
        [NativeName("Name", "EGL_BUFFER_DESTROYED")]
        BufferDestroyed = 0x3095,
        [NativeName("Name", "EGL_CLIENT_APIS")]
        ClientApis = 0x308D,
        [NativeName("Name", "EGL_COLORSPACE")]
        Colorspace = 0x3087,
        [NativeName("Name", "EGL_COLORSPACE_sRGB")]
        ColorspaceSRgb = 0x3089,
        [NativeName("Name", "EGL_COLORSPACE_LINEAR")]
        ColorspaceLinear = 0x308A,
        [NativeName("Name", "EGL_COLOR_BUFFER_TYPE")]
        ColorBufferType = 0x303F,
        [NativeName("Name", "EGL_CONTEXT_CLIENT_TYPE")]
        ContextClientType = 0x3097,
        [NativeName("Name", "EGL_DISPLAY_SCALING")]
        DisplayScaling = 0x10000,
        [NativeName("Name", "EGL_HORIZONTAL_RESOLUTION")]
        HorizontalResolution = 0x3090,
        [NativeName("Name", "EGL_LUMINANCE_BUFFER")]
        LuminanceBuffer = 0x308F,
        [NativeName("Name", "EGL_LUMINANCE_SIZE")]
        LuminanceSize = 0x303D,
        [NativeName("Name", "EGL_OPENGL_ES_BIT")]
        OpenglESBit = 0x1,
        [NativeName("Name", "EGL_OPENVG_BIT")]
        OpenvgBit = 0x2,
        [NativeName("Name", "EGL_OPENGL_ES_API")]
        OpenglESApi = 0x30A0,
        [NativeName("Name", "EGL_OPENVG_API")]
        OpenvgApi = 0x30A1,
        [NativeName("Name", "EGL_OPENVG_IMAGE")]
        OpenvgImage = 0x3096,
        [NativeName("Name", "EGL_PIXEL_ASPECT_RATIO")]
        PixelAspectRatio = 0x3092,
        [NativeName("Name", "EGL_RENDERABLE_TYPE")]
        RenderableType = 0x3040,
        [NativeName("Name", "EGL_RENDER_BUFFER")]
        RenderBuffer = 0x3086,
        [NativeName("Name", "EGL_RGB_BUFFER")]
        RgbBuffer = 0x308E,
        [NativeName("Name", "EGL_SINGLE_BUFFER")]
        SingleBuffer = 0x3085,
        [NativeName("Name", "EGL_SWAP_BEHAVIOR")]
        SwapBehavior = 0x3093,
        [NativeName("Name", "EGL_UNKNOWN")]
        Unknown = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_VERTICAL_RESOLUTION")]
        VerticalResolution = 0x3091,
        [NativeName("Name", "EGL_CONFORMANT")]
        Conformant = 0x3042,
        [NativeName("Name", "EGL_CONTEXT_CLIENT_VERSION")]
        ContextClientVersion = 0x3098,
        [NativeName("Name", "EGL_MATCH_NATIVE_PIXMAP")]
        MatchNativePixmap = 0x3041,
        [NativeName("Name", "EGL_OPENGL_ES2_BIT")]
        OpenglES2Bit = 0x4,
        [NativeName("Name", "EGL_VG_ALPHA_FORMAT")]
        VGAlphaFormat = 0x3088,
        [NativeName("Name", "EGL_VG_ALPHA_FORMAT_NONPRE")]
        VGAlphaFormatNonpre = 0x308B,
        [NativeName("Name", "EGL_VG_ALPHA_FORMAT_PRE")]
        VGAlphaFormatPre = 0x308C,
        [NativeName("Name", "EGL_VG_ALPHA_FORMAT_PRE_BIT")]
        VGAlphaFormatPreBit = 0x40,
        [NativeName("Name", "EGL_VG_COLORSPACE")]
        VGColorspace = 0x3087,
        [NativeName("Name", "EGL_VG_COLORSPACE_sRGB")]
        VGColorspaceSRgb = 0x3089,
        [NativeName("Name", "EGL_VG_COLORSPACE_LINEAR")]
        VGColorspaceLinear = 0x308A,
        [NativeName("Name", "EGL_VG_COLORSPACE_LINEAR_BIT")]
        VGColorspaceLinearBit = 0x20,
        [NativeName("Name", "EGL_DEFAULT_DISPLAY")]
        DefaultDisplay = 0x0,
        [NativeName("Name", "EGL_MULTISAMPLE_RESOLVE_BOX_BIT")]
        MultisampleResolveBoxBit = 0x200,
        [NativeName("Name", "EGL_MULTISAMPLE_RESOLVE")]
        MultisampleResolve = 0x3099,
        [NativeName("Name", "EGL_MULTISAMPLE_RESOLVE_DEFAULT")]
        MultisampleResolveDefault = 0x309A,
        [NativeName("Name", "EGL_MULTISAMPLE_RESOLVE_BOX")]
        MultisampleResolveBox = 0x309B,
        [NativeName("Name", "EGL_OPENGL_API")]
        OpenglApi = 0x30A2,
        [NativeName("Name", "EGL_OPENGL_BIT")]
        OpenglBit = 0x8,
        [NativeName("Name", "EGL_SWAP_BEHAVIOR_PRESERVED_BIT")]
        SwapBehaviorPreservedBit = 0x400,
        [NativeName("Name", "EGL_CONTEXT_MAJOR_VERSION")]
        ContextMajorVersion = 0x3098,
        [NativeName("Name", "EGL_CONTEXT_MINOR_VERSION")]
        ContextMinorVersion = 0x30FB,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_PROFILE_MASK")]
        ContextOpenglProfileMask = 0x30FD,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY")]
        ContextOpenglResetNotificationStrategy = 0x31BD,
        [NativeName("Name", "EGL_NO_RESET_NOTIFICATION")]
        NoResetNotification = 0x31BE,
        [NativeName("Name", "EGL_LOSE_CONTEXT_ON_RESET")]
        LoseContextOnReset = 0x31BF,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT")]
        ContextOpenglCoreProfileBit = 0x1,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT")]
        ContextOpenglCompatibilityProfileBit = 0x2,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_DEBUG")]
        ContextOpenglDebug = 0x31B0,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE")]
        ContextOpenglForwardCompatible = 0x31B1,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_ROBUST_ACCESS")]
        ContextOpenglRobustAccess = 0x31B2,
        [NativeName("Name", "EGL_OPENGL_ES3_BIT")]
        OpenglES3Bit = 0x40,
        [NativeName("Name", "EGL_CL_EVENT_HANDLE")]
        CLEventHandle = 0x309C,
        [NativeName("Name", "EGL_SYNC_CL_EVENT")]
        SyncCLEvent = 0x30FE,
        [NativeName("Name", "EGL_SYNC_CL_EVENT_COMPLETE")]
        SyncCLEventComplete = 0x30FF,
        [NativeName("Name", "EGL_SYNC_PRIOR_COMMANDS_COMPLETE")]
        SyncPriorCommandsComplete = 0x30F0,
        [NativeName("Name", "EGL_SYNC_TYPE")]
        SyncType = 0x30F7,
        [NativeName("Name", "EGL_SYNC_STATUS")]
        SyncStatus = 0x30F1,
        [NativeName("Name", "EGL_SYNC_CONDITION")]
        SyncCondition = 0x30F8,
        [NativeName("Name", "EGL_SIGNALED")]
        Signaled = 0x30F2,
        [NativeName("Name", "EGL_UNSIGNALED")]
        Unsignaled = 0x30F3,
        [NativeName("Name", "EGL_SYNC_FLUSH_COMMANDS_BIT")]
        SyncFlushCommandsBit = 0x1,
        [NativeName("Name", "EGL_FOREVER")]
        Forever = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_TIMEOUT_EXPIRED")]
        TimeoutExpired = 0x30F5,
        [NativeName("Name", "EGL_CONDITION_SATISFIED")]
        ConditionSatisfied = 0x30F6,
        [NativeName("Name", "EGL_NO_SYNC")]
        NoSync = 0x0,
        [NativeName("Name", "EGL_SYNC_FENCE")]
        SyncFence = 0x30F9,
        [NativeName("Name", "EGL_GL_COLORSPACE")]
        GLColorspace = 0x309D,
        [NativeName("Name", "EGL_GL_COLORSPACE_SRGB")]
        GLColorspaceSrgb = 0x3089,
        [NativeName("Name", "EGL_GL_COLORSPACE_LINEAR")]
        GLColorspaceLinear = 0x308A,
        [NativeName("Name", "EGL_GL_RENDERBUFFER")]
        GLRenderbuffer = 0x30B9,
        [NativeName("Name", "EGL_GL_TEXTURE_2D")]
        GLTexture2D = 0x30B1,
        [NativeName("Name", "EGL_GL_TEXTURE_LEVEL")]
        GLTextureLevel = 0x30BC,
        [NativeName("Name", "EGL_GL_TEXTURE_3D")]
        GLTexture3D = 0x30B2,
        [NativeName("Name", "EGL_GL_TEXTURE_ZOFFSET")]
        GLTextureZoffset = 0x30BD,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
        GLTextureCubeMapPositiveX = 0x30B3,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
        GLTextureCubeMapNegativeX = 0x30B4,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
        GLTextureCubeMapPositiveY = 0x30B5,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
        GLTextureCubeMapNegativeY = 0x30B6,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
        GLTextureCubeMapPositiveZ = 0x30B7,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
        GLTextureCubeMapNegativeZ = 0x30B8,
        [NativeName("Name", "EGL_IMAGE_PRESERVED")]
        ImagePreserved = 0x30D2,
        [NativeName("Name", "EGL_NO_IMAGE")]
        NoImage = 0x0,
    }
}
