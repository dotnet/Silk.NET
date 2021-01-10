// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "EGL_FRONT_BUFFER_EXT")]
        FrontBufferExt = 0x3464,
        [NativeName("Name", "EGL_BUFFER_AGE_EXT")]
        BufferAgeExt = 0x313D,
        [NativeName("Name", "EGL_SYNC_CLIENT_EXT")]
        SyncClientExt = 0x3364,
        [NativeName("Name", "EGL_SYNC_CLIENT_SIGNAL_EXT")]
        SyncClientSignalExt = 0x3365,
        [NativeName("Name", "EGL_PRIMARY_COMPOSITOR_CONTEXT_EXT")]
        PrimaryCompositorContextExt = 0x3460,
        [NativeName("Name", "EGL_EXTERNAL_REF_ID_EXT")]
        ExternalRefIDExt = 0x3461,
        [NativeName("Name", "EGL_COMPOSITOR_DROP_NEWEST_FRAME_EXT")]
        CompositorDropNewestFrameExt = 0x3462,
        [NativeName("Name", "EGL_COMPOSITOR_KEEP_NEWEST_FRAME_EXT")]
        CompositorKeepNewestFrameExt = 0x3463,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_ROBUST_ACCESS_EXT")]
        ContextOpenglRobustAccessExt = 0x30BF,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY_EXT")]
        ContextOpenglResetNotificationStrategyExt = 0x3138,
        [NativeName("Name", "EGL_NO_RESET_NOTIFICATION_EXT")]
        NoResetNotificationExt = 0x31BE,
        [NativeName("Name", "EGL_LOSE_CONTEXT_ON_RESET_EXT")]
        LoseContextOnResetExt = 0x31BF,
        [NativeName("Name", "EGL_NO_DEVICE_EXT")]
        NoDeviceExt = 0x0,
        [NativeName("Name", "EGL_BAD_DEVICE_EXT")]
        BadDeviceExt = 0x322B,
        [NativeName("Name", "EGL_DEVICE_EXT")]
        DeviceExt = 0x322C,
        [NativeName("Name", "EGL_DRM_DEVICE_FILE_EXT")]
        DrmDeviceFileExt = 0x3233,
        [NativeName("Name", "EGL_DRM_MASTER_FD_EXT")]
        DrmMasterFDExt = 0x333C,
        [NativeName("Name", "EGL_OPENWF_DEVICE_ID_EXT")]
        OpenwfDeviceIDExt = 0x3237,
        [NativeName("Name", "EGL_RENDERER_EXT")]
        RendererExt = 0x335F,
        [NativeName("Name", "EGL_GL_COLORSPACE_BT2020_LINEAR_EXT")]
        GLColorspaceBT2020LinearExt = 0x333F,
        [NativeName("Name", "EGL_GL_COLORSPACE_BT2020_PQ_EXT")]
        GLColorspaceBT2020PQExt = 0x3340,
        [NativeName("Name", "EGL_GL_COLORSPACE_DISPLAY_P3_EXT")]
        GLColorspaceDisplayP3Ext = 0x3363,
        [NativeName("Name", "EGL_GL_COLORSPACE_DISPLAY_P3_LINEAR_EXT")]
        GLColorspaceDisplayP3LinearExt = 0x3362,
        [NativeName("Name", "EGL_GL_COLORSPACE_DISPLAY_P3_PASSTHROUGH_EXT")]
        GLColorspaceDisplayP3PassthroughExt = 0x3490,
        [NativeName("Name", "EGL_GL_COLORSPACE_SCRGB_EXT")]
        GLColorspaceScrgbExt = 0x3351,
        [NativeName("Name", "EGL_GL_COLORSPACE_SCRGB_LINEAR_EXT")]
        GLColorspaceScrgbLinearExt = 0x3350,
        [NativeName("Name", "EGL_LINUX_DMA_BUF_EXT")]
        LinuxDmaBufExt = 0x3270,
        [NativeName("Name", "EGL_LINUX_DRM_FOURCC_EXT")]
        LinuxDrmFourccExt = 0x3271,
        [NativeName("Name", "EGL_DMA_BUF_PLANE0_FD_EXT")]
        DmaBufPlane0FDExt = 0x3272,
        [NativeName("Name", "EGL_DMA_BUF_PLANE0_OFFSET_EXT")]
        DmaBufPlane0OffsetExt = 0x3273,
        [NativeName("Name", "EGL_DMA_BUF_PLANE0_PITCH_EXT")]
        DmaBufPlane0PitchExt = 0x3274,
        [NativeName("Name", "EGL_DMA_BUF_PLANE1_FD_EXT")]
        DmaBufPlane1FDExt = 0x3275,
        [NativeName("Name", "EGL_DMA_BUF_PLANE1_OFFSET_EXT")]
        DmaBufPlane1OffsetExt = 0x3276,
        [NativeName("Name", "EGL_DMA_BUF_PLANE1_PITCH_EXT")]
        DmaBufPlane1PitchExt = 0x3277,
        [NativeName("Name", "EGL_DMA_BUF_PLANE2_FD_EXT")]
        DmaBufPlane2FDExt = 0x3278,
        [NativeName("Name", "EGL_DMA_BUF_PLANE2_OFFSET_EXT")]
        DmaBufPlane2OffsetExt = 0x3279,
        [NativeName("Name", "EGL_DMA_BUF_PLANE2_PITCH_EXT")]
        DmaBufPlane2PitchExt = 0x327A,
        [NativeName("Name", "EGL_YUV_COLOR_SPACE_HINT_EXT")]
        YuvColorSpaceHintExt = 0x327B,
        [NativeName("Name", "EGL_SAMPLE_RANGE_HINT_EXT")]
        SampleRangeHintExt = 0x327C,
        [NativeName("Name", "EGL_YUV_CHROMA_HORIZONTAL_SITING_HINT_EXT")]
        YuvChromaHorizontalSitingHintExt = 0x327D,
        [NativeName("Name", "EGL_YUV_CHROMA_VERTICAL_SITING_HINT_EXT")]
        YuvChromaVerticalSitingHintExt = 0x327E,
        [NativeName("Name", "EGL_ITU_REC601_EXT")]
        ItuRec601Ext = 0x327F,
        [NativeName("Name", "EGL_ITU_REC709_EXT")]
        ItuRec709Ext = 0x3280,
        [NativeName("Name", "EGL_ITU_REC2020_EXT")]
        ItuRec2020Ext = 0x3281,
        [NativeName("Name", "EGL_YUV_FULL_RANGE_EXT")]
        YuvFullRangeExt = 0x3282,
        [NativeName("Name", "EGL_YUV_NARROW_RANGE_EXT")]
        YuvNarrowRangeExt = 0x3283,
        [NativeName("Name", "EGL_YUV_CHROMA_SITING_0_EXT")]
        YuvChromaSiting0Ext = 0x3284,
        [NativeName("Name", "EGL_YUV_CHROMA_SITING_0_5_EXT")]
        YuvChromaSiting05Ext = 0x3285,
        [NativeName("Name", "EGL_DMA_BUF_PLANE3_FD_EXT")]
        DmaBufPlane3FDExt = 0x3440,
        [NativeName("Name", "EGL_DMA_BUF_PLANE3_OFFSET_EXT")]
        DmaBufPlane3OffsetExt = 0x3441,
        [NativeName("Name", "EGL_DMA_BUF_PLANE3_PITCH_EXT")]
        DmaBufPlane3PitchExt = 0x3442,
        [NativeName("Name", "EGL_DMA_BUF_PLANE0_MODIFIER_LO_EXT")]
        DmaBufPlane0ModifierLOExt = 0x3443,
        [NativeName("Name", "EGL_DMA_BUF_PLANE0_MODIFIER_HI_EXT")]
        DmaBufPlane0ModifierHIExt = 0x3444,
        [NativeName("Name", "EGL_DMA_BUF_PLANE1_MODIFIER_LO_EXT")]
        DmaBufPlane1ModifierLOExt = 0x3445,
        [NativeName("Name", "EGL_DMA_BUF_PLANE1_MODIFIER_HI_EXT")]
        DmaBufPlane1ModifierHIExt = 0x3446,
        [NativeName("Name", "EGL_DMA_BUF_PLANE2_MODIFIER_LO_EXT")]
        DmaBufPlane2ModifierLOExt = 0x3447,
        [NativeName("Name", "EGL_DMA_BUF_PLANE2_MODIFIER_HI_EXT")]
        DmaBufPlane2ModifierHIExt = 0x3448,
        [NativeName("Name", "EGL_DMA_BUF_PLANE3_MODIFIER_LO_EXT")]
        DmaBufPlane3ModifierLOExt = 0x3449,
        [NativeName("Name", "EGL_DMA_BUF_PLANE3_MODIFIER_HI_EXT")]
        DmaBufPlane3ModifierHIExt = 0x344A,
        [NativeName("Name", "EGL_GL_COLORSPACE")]
        GLColorspace = 0x309D,
        [NativeName("Name", "EGL_GL_COLORSPACE_DEFAULT_EXT")]
        GLColorspaceDefaultExt = 0x314D,
        [NativeName("Name", "EGL_IMPORT_SYNC_TYPE_EXT")]
        ImportSyncTypeExt = 0x3470,
        [NativeName("Name", "EGL_IMPORT_IMPLICIT_SYNC_EXT")]
        ImportImplicitSyncExt = 0x3471,
        [NativeName("Name", "EGL_IMPORT_EXPLICIT_SYNC_EXT")]
        ImportExplicitSyncExt = 0x3472,
        [NativeName("Name", "EGL_MULTIVIEW_VIEW_COUNT_EXT")]
        MultiviewViewCountExt = 0x3134,
        [NativeName("Name", "EGL_NO_OUTPUT_LAYER_EXT")]
        NoOutputLayerExt = 0x0,
        [NativeName("Name", "EGL_NO_OUTPUT_PORT_EXT")]
        NoOutputPortExt = 0x0,
        [NativeName("Name", "EGL_BAD_OUTPUT_LAYER_EXT")]
        BadOutputLayerExt = 0x322D,
        [NativeName("Name", "EGL_BAD_OUTPUT_PORT_EXT")]
        BadOutputPortExt = 0x322E,
        [NativeName("Name", "EGL_SWAP_INTERVAL_EXT")]
        SwapIntervalExt = 0x322F,
        [NativeName("Name", "EGL_DRM_CRTC_EXT")]
        DrmCrtcExt = 0x3234,
        [NativeName("Name", "EGL_DRM_PLANE_EXT")]
        DrmPlaneExt = 0x3235,
        [NativeName("Name", "EGL_DRM_CONNECTOR_EXT")]
        DrmConnectorExt = 0x3236,
        [NativeName("Name", "EGL_OPENWF_PIPELINE_ID_EXT")]
        OpenwfPipelineIDExt = 0x3238,
        [NativeName("Name", "EGL_OPENWF_PORT_ID_EXT")]
        OpenwfPortIDExt = 0x3239,
        [NativeName("Name", "EGL_COLOR_COMPONENT_TYPE_EXT")]
        ColorComponentTypeExt = 0x3339,
        [NativeName("Name", "EGL_COLOR_COMPONENT_TYPE_FIXED_EXT")]
        ColorComponentTypeFixedExt = 0x333A,
        [NativeName("Name", "EGL_COLOR_COMPONENT_TYPE_FLOAT_EXT")]
        ColorComponentTypeFloatExt = 0x333B,
        [NativeName("Name", "EGL_PLATFORM_DEVICE_EXT")]
        PlatformDeviceExt = 0x313F,
        [NativeName("Name", "EGL_PLATFORM_WAYLAND_EXT")]
        PlatformWaylandExt = 0x31D8,
        [NativeName("Name", "EGL_PLATFORM_X11_EXT")]
        PlatformX11Ext = 0x31D5,
        [NativeName("Name", "EGL_PLATFORM_X11_SCREEN_EXT")]
        PlatformX11ScreenExt = 0x31D6,
        [NativeName("Name", "EGL_PLATFORM_XCB_EXT")]
        PlatformXcbExt = 0x31DC,
        [NativeName("Name", "EGL_PLATFORM_XCB_SCREEN_EXT")]
        PlatformXcbScreenExt = 0x31DE,
        [NativeName("Name", "EGL_PROTECTED_CONTENT_EXT")]
        ProtectedContentExt = 0x32C0,
        [NativeName("Name", "EGL_CTA861_3_MAX_CONTENT_LIGHT_LEVEL_EXT")]
        Cta8613MaxContentLightLevelExt = 0x3360,
        [NativeName("Name", "EGL_CTA861_3_MAX_FRAME_AVERAGE_LEVEL_EXT")]
        Cta8613MaxFrameAverageLevelExt = 0x3361,
        [NativeName("Name", "EGL_SMPTE2086_DISPLAY_PRIMARY_RX_EXT")]
        Smpte2086DisplayPrimaryRXExt = 0x3341,
        [NativeName("Name", "EGL_SMPTE2086_DISPLAY_PRIMARY_RY_EXT")]
        Smpte2086DisplayPrimaryRYExt = 0x3342,
        [NativeName("Name", "EGL_SMPTE2086_DISPLAY_PRIMARY_GX_EXT")]
        Smpte2086DisplayPrimaryGXExt = 0x3343,
        [NativeName("Name", "EGL_SMPTE2086_DISPLAY_PRIMARY_GY_EXT")]
        Smpte2086DisplayPrimaryGYExt = 0x3344,
        [NativeName("Name", "EGL_SMPTE2086_DISPLAY_PRIMARY_BX_EXT")]
        Smpte2086DisplayPrimaryBXExt = 0x3345,
        [NativeName("Name", "EGL_SMPTE2086_DISPLAY_PRIMARY_BY_EXT")]
        Smpte2086DisplayPrimaryByExt = 0x3346,
        [NativeName("Name", "EGL_SMPTE2086_WHITE_POINT_X_EXT")]
        Smpte2086WhitePointXExt = 0x3347,
        [NativeName("Name", "EGL_SMPTE2086_WHITE_POINT_Y_EXT")]
        Smpte2086WhitePointYExt = 0x3348,
        [NativeName("Name", "EGL_SMPTE2086_MAX_LUMINANCE_EXT")]
        Smpte2086MaxLuminanceExt = 0x3349,
        [NativeName("Name", "EGL_SMPTE2086_MIN_LUMINANCE_EXT")]
        Smpte2086MinLuminanceExt = 0x334A,
        [NativeName("Name", "EGL_METADATA_SCALING_EXT")]
        MetadataScalingExt = 0x50000,
        [NativeName("Name", "EGL_YUV_ORDER_EXT")]
        YuvOrderExt = 0x3301,
        [NativeName("Name", "EGL_YUV_NUMBER_OF_PLANES_EXT")]
        YuvNumberOfPlanesExt = 0x3311,
        [NativeName("Name", "EGL_YUV_SUBSAMPLE_EXT")]
        YuvSubsampleExt = 0x3312,
        [NativeName("Name", "EGL_YUV_DEPTH_RANGE_EXT")]
        YuvDepthRangeExt = 0x3317,
        [NativeName("Name", "EGL_YUV_CSC_STANDARD_EXT")]
        YuvCscStandardExt = 0x330A,
        [NativeName("Name", "EGL_YUV_PLANE_BPP_EXT")]
        YuvPlaneBppExt = 0x331A,
        [NativeName("Name", "EGL_YUV_BUFFER_EXT")]
        YuvBufferExt = 0x3300,
        [NativeName("Name", "EGL_YUV_ORDER_YUV_EXT")]
        YuvOrderYuvExt = 0x3302,
        [NativeName("Name", "EGL_YUV_ORDER_YVU_EXT")]
        YuvOrderYvuExt = 0x3303,
        [NativeName("Name", "EGL_YUV_ORDER_YUYV_EXT")]
        YuvOrderYuyvExt = 0x3304,
        [NativeName("Name", "EGL_YUV_ORDER_UYVY_EXT")]
        YuvOrderUyvyExt = 0x3305,
        [NativeName("Name", "EGL_YUV_ORDER_YVYU_EXT")]
        YuvOrderYvyuExt = 0x3306,
        [NativeName("Name", "EGL_YUV_ORDER_VYUY_EXT")]
        YuvOrderVyuyExt = 0x3307,
        [NativeName("Name", "EGL_YUV_ORDER_AYUV_EXT")]
        YuvOrderAyuvExt = 0x3308,
        [NativeName("Name", "EGL_YUV_SUBSAMPLE_4_2_0_EXT")]
        YuvSubsample420Ext = 0x3313,
        [NativeName("Name", "EGL_YUV_SUBSAMPLE_4_2_2_EXT")]
        YuvSubsample422Ext = 0x3314,
        [NativeName("Name", "EGL_YUV_SUBSAMPLE_4_4_4_EXT")]
        YuvSubsample444Ext = 0x3315,
        [NativeName("Name", "EGL_YUV_DEPTH_RANGE_LIMITED_EXT")]
        YuvDepthRangeLimitedExt = 0x3318,
        [NativeName("Name", "EGL_YUV_DEPTH_RANGE_FULL_EXT")]
        YuvDepthRangeFullExt = 0x3319,
        [NativeName("Name", "EGL_YUV_CSC_STANDARD_601_EXT")]
        YuvCscStandard601Ext = 0x330B,
        [NativeName("Name", "EGL_YUV_CSC_STANDARD_709_EXT")]
        YuvCscStandard709Ext = 0x330C,
        [NativeName("Name", "EGL_YUV_CSC_STANDARD_2020_EXT")]
        YuvCscStandard2020Ext = 0x330D,
        [NativeName("Name", "EGL_YUV_PLANE_BPP_0_EXT")]
        YuvPlaneBpp0Ext = 0x331B,
        [NativeName("Name", "EGL_YUV_PLANE_BPP_8_EXT")]
        YuvPlaneBpp8Ext = 0x331C,
        [NativeName("Name", "EGL_YUV_PLANE_BPP_10_EXT")]
        YuvPlaneBpp10Ext = 0x331D,
    }
}
