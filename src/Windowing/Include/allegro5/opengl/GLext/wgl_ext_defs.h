#ifndef WGL_ARB_buffer_region
#define WGL_ARB_buffer_region
#define WGL_FRONT_COLOR_BUFFER_BIT_ARB 0x00000001
#define WGL_BACK_COLOR_BUFFER_BIT_ARB  0x00000002
#define WGL_DEPTH_BUFFER_BIT_ARB       0x00000004
#define WGL_STENCIL_BUFFER_BIT_ARB     0x00000008
#endif

#ifndef WGL_ARB_multisample
#define WGL_ARB_multisample
#define WGL_SAMPLE_BUFFERS_ARB         0x2041
#define WGL_SAMPLES_ARB                0x2042
#endif

#ifndef WGL_ARB_pixel_format
#define WGL_ARB_pixel_format
#define WGL_NUMBER_PIXEL_FORMATS_ARB   0x2000
#define WGL_DRAW_TO_WINDOW_ARB         0x2001
#define WGL_DRAW_TO_BITMAP_ARB         0x2002
#define WGL_ACCELERATION_ARB           0x2003
#define WGL_NEED_PALETTE_ARB           0x2004
#define WGL_NEED_SYSTEM_PALETTE_ARB    0x2005
#define WGL_SWAP_LAYER_BUFFERS_ARB     0x2006
#define WGL_SWAP_METHOD_ARB            0x2007
#define WGL_NUMBER_OVERLAYS_ARB        0x2008
#define WGL_NUMBER_UNDERLAYS_ARB       0x2009
#define WGL_TRANSPARENT_ARB            0x200A
#define WGL_TRANSPARENT_RED_VALUE_ARB  0x2037
#define WGL_TRANSPARENT_GREEN_VALUE_ARB 0x2038
#define WGL_TRANSPARENT_BLUE_VALUE_ARB 0x2039
#define WGL_TRANSPARENT_ALPHA_VALUE_ARB 0x203A
#define WGL_TRANSPARENT_INDEX_VALUE_ARB 0x203B
#define WGL_SHARE_DEPTH_ARB            0x200C
#define WGL_SHARE_STENCIL_ARB          0x200D
#define WGL_SHARE_ACCUM_ARB            0x200E
#define WGL_SUPPORT_GDI_ARB            0x200F
#define WGL_SUPPORT_OPENGL_ARB         0x2010
#define WGL_DOUBLE_BUFFER_ARB          0x2011
#define WGL_STEREO_ARB                 0x2012
#define WGL_PIXEL_TYPE_ARB             0x2013
#define WGL_COLOR_BITS_ARB             0x2014
#define WGL_RED_BITS_ARB               0x2015
#define WGL_RED_SHIFT_ARB              0x2016
#define WGL_GREEN_BITS_ARB             0x2017
#define WGL_GREEN_SHIFT_ARB            0x2018
#define WGL_BLUE_BITS_ARB              0x2019
#define WGL_BLUE_SHIFT_ARB             0x201A
#define WGL_ALPHA_BITS_ARB             0x201B
#define WGL_ALPHA_SHIFT_ARB            0x201C
#define WGL_ACCUM_BITS_ARB             0x201D
#define WGL_ACCUM_RED_BITS_ARB         0x201E
#define WGL_ACCUM_GREEN_BITS_ARB       0x201F
#define WGL_ACCUM_BLUE_BITS_ARB        0x2020
#define WGL_ACCUM_ALPHA_BITS_ARB       0x2021
#define WGL_DEPTH_BITS_ARB             0x2022
#define WGL_STENCIL_BITS_ARB           0x2023
#define WGL_AUX_BUFFERS_ARB            0x2024
#define WGL_NO_ACCELERATION_ARB        0x2025
#define WGL_GENERIC_ACCELERATION_ARB   0x2026
#define WGL_FULL_ACCELERATION_ARB      0x2027
#define WGL_SWAP_EXCHANGE_ARB          0x2028
#define WGL_SWAP_COPY_ARB              0x2029
#define WGL_SWAP_UNDEFINED_ARB         0x202A
#define WGL_TYPE_RGBA_ARB              0x202B
#define WGL_TYPE_COLORINDEX_ARB        0x202C
#endif

#ifndef WGL_ARB_make_current_read
#define WGL_ARB_make_current_read
#define ERROR_INVALID_PIXEL_TYPE_ARB   0x2043
#define ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB 0x2054
#endif

#ifndef WGL_ARB_pbuffer
#define WGL_ARB_pbuffer
DECLARE_HANDLE(HPBUFFERARB);
#define WGL_DRAW_TO_PBUFFER_ARB        0x202D
#define WGL_MAX_PBUFFER_PIXELS_ARB     0x202E
#define WGL_MAX_PBUFFER_WIDTH_ARB      0x202F
#define WGL_MAX_PBUFFER_HEIGHT_ARB     0x2030
#define WGL_PBUFFER_LARGEST_ARB        0x2033
#define WGL_PBUFFER_WIDTH_ARB          0x2034
#define WGL_PBUFFER_HEIGHT_ARB         0x2035
#define WGL_PBUFFER_LOST_ARB           0x2036
#endif

#ifndef WGL_ARB_render_texture
#define WGL_ARB_render_texture
#define WGL_BIND_TO_TEXTURE_RGB_ARB    0x2070
#define WGL_BIND_TO_TEXTURE_RGBA_ARB   0x2071
#define WGL_TEXTURE_FORMAT_ARB         0x2072
#define WGL_TEXTURE_TARGET_ARB         0x2073
#define WGL_MIPMAP_TEXTURE_ARB         0x2074
#define WGL_TEXTURE_RGB_ARB            0x2075
#define WGL_TEXTURE_RGBA_ARB           0x2076
#define WGL_NO_TEXTURE_ARB             0x2077
#define WGL_TEXTURE_CUBE_MAP_ARB       0x2078
#define WGL_TEXTURE_1D_ARB             0x2079
#define WGL_TEXTURE_2D_ARB             0x207A
#define WGL_MIPMAP_LEVEL_ARB           0x207B
#define WGL_CUBE_MAP_FACE_ARB          0x207C
#define WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB 0x207D
#define WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB 0x207E
#define WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB 0x207F
#define WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB 0x2080
#define WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB 0x2081
#define WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB 0x2082
#define WGL_FRONT_LEFT_ARB             0x2083
#define WGL_FRONT_RIGHT_ARB            0x2084
#define WGL_BACK_LEFT_ARB              0x2085
#define WGL_BACK_RIGHT_ARB             0x2086
#define WGL_AUX0_ARB                   0x2087
#define WGL_AUX1_ARB                   0x2088
#define WGL_AUX2_ARB                   0x2089
#define WGL_AUX3_ARB                   0x208A
#define WGL_AUX4_ARB                   0x208B
#define WGL_AUX5_ARB                   0x208C
#define WGL_AUX6_ARB                   0x208D
#define WGL_AUX7_ARB                   0x208E
#define WGL_AUX8_ARB                   0x208F
#define WGL_AUX9_ARB                   0x2090
#endif


#ifndef WGL_ARB_pixel_format_float
#define WGL_ARB_pixel_format_float
#define AWGL_ARB_pixel_format_float
#define WGL_TYPE_RGBA_FLOAT_ARB        0x21A0
#endif

#ifndef WGL_ARB_create_context
#define WGL_ARB_create_context
#define WGL_CONTEXT_DEBUG_BIT_ARB      0x0001
#define WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB 0x0002
#define WGL_CONTEXT_MAJOR_VERSION_ARB  0x2091
#define WGL_CONTEXT_MINOR_VERSION_ARB  0x2092
#define WGL_CONTEXT_LAYER_PLANE_ARB    0x2093
#define WGL_CONTEXT_FLAGS_ARB          0x2094
#define ERROR_INVALID_VERSION_ARB      0x2095
#endif

#ifndef WGL_ARB_create_context_profile
#define WGL_ARB_create_context_profile
#define WGL_CONTEXT_PROFILE_MASK_ARB   0x9126
#define WGL_CONTEXT_CORE_PROFILE_BIT_ARB 0x00000001
#define WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB 0x00000002
#define ERROR_INVALID_PROFILE_ARB      0x2096
#endif

#ifndef WGL_EXT_make_current_read
#define WGL_EXT_make_current_read
#define ERROR_INVALID_PIXEL_TYPE_EXT   0x2043
#endif

#ifndef WGL_EXT_pixel_format
#define WGL_EXT_pixel_format
#define WGL_NUMBER_PIXEL_FORMATS_EXT   0x2000
#define WGL_DRAW_TO_WINDOW_EXT         0x2001
#define WGL_DRAW_TO_BITMAP_EXT         0x2002
#define WGL_ACCELERATION_EXT           0x2003
#define WGL_NEED_PALETTE_EXT           0x2004
#define WGL_NEED_SYSTEM_PALETTE_EXT    0x2005
#define WGL_SWAP_LAYER_BUFFERS_EXT     0x2006
#define WGL_SWAP_METHOD_EXT            0x2007
#define WGL_NUMBER_OVERLAYS_EXT        0x2008
#define WGL_NUMBER_UNDERLAYS_EXT       0x2009
#define WGL_TRANSPARENT_EXT            0x200A
#define WGL_TRANSPARENT_VALUE_EXT      0x200B
#define WGL_SHARE_DEPTH_EXT            0x200C
#define WGL_SHARE_STENCIL_EXT          0x200D
#define WGL_SHARE_ACCUM_EXT            0x200E
#define WGL_SUPPORT_GDI_EXT            0x200F
#define WGL_SUPPORT_OPENGL_EXT         0x2010
#define WGL_DOUBLE_BUFFER_EXT          0x2011
#define WGL_STEREO_EXT                 0x2012
#define WGL_PIXEL_TYPE_EXT             0x2013
#define WGL_COLOR_BITS_EXT             0x2014
#define WGL_RED_BITS_EXT               0x2015
#define WGL_RED_SHIFT_EXT              0x2016
#define WGL_GREEN_BITS_EXT             0x2017
#define WGL_GREEN_SHIFT_EXT            0x2018
#define WGL_BLUE_BITS_EXT              0x2019
#define WGL_BLUE_SHIFT_EXT             0x201A
#define WGL_ALPHA_BITS_EXT             0x201B
#define WGL_ALPHA_SHIFT_EXT            0x201C
#define WGL_ACCUM_BITS_EXT             0x201D
#define WGL_ACCUM_RED_BITS_EXT         0x201E
#define WGL_ACCUM_GREEN_BITS_EXT       0x201F
#define WGL_ACCUM_BLUE_BITS_EXT        0x2020
#define WGL_ACCUM_ALPHA_BITS_EXT       0x2021
#define WGL_DEPTH_BITS_EXT             0x2022
#define WGL_STENCIL_BITS_EXT           0x2023
#define WGL_AUX_BUFFERS_EXT            0x2024
#define WGL_NO_ACCELERATION_EXT        0x2025
#define WGL_GENERIC_ACCELERATION_EXT   0x2026
#define WGL_FULL_ACCELERATION_EXT      0x2027
#define WGL_SWAP_EXCHANGE_EXT          0x2028
#define WGL_SWAP_COPY_EXT              0x2029
#define WGL_SWAP_UNDEFINED_EXT         0x202A
#define WGL_TYPE_RGBA_EXT              0x202B
#define WGL_TYPE_COLORINDEX_EXT        0x202C
#endif

#ifndef WGL_EXT_pbuffer
#define WGL_EXT_pbuffer
DECLARE_HANDLE(HPBUFFEREXT);
#define WGL_DRAW_TO_PBUFFER_EXT        0x202D
#define WGL_MAX_PBUFFER_PIXELS_EXT     0x202E
#define WGL_MAX_PBUFFER_WIDTH_EXT      0x202F
#define WGL_MAX_PBUFFER_HEIGHT_EXT     0x2030
#define WGL_OPTIMAL_PBUFFER_WIDTH_EXT  0x2031
#define WGL_OPTIMAL_PBUFFER_HEIGHT_EXT 0x2032
#define WGL_PBUFFER_LARGEST_EXT        0x2033
#define WGL_PBUFFER_WIDTH_EXT          0x2034
#define WGL_PBUFFER_HEIGHT_EXT         0x2035
#endif

#ifndef WGL_EXT_depth_float
#define WGL_EXT_depth_float
#define WGL_DEPTH_FLOAT_EXT            0x2040
#endif

#ifndef WGL_3DFX_multisample
#define WGL_3DFX_multisample
#define WGL_SAMPLE_BUFFERS_3DFX        0x2060
#define WGL_SAMPLES_3DFX               0x2061
#endif

#ifndef WGL_EXT_multisample
#define WGL_EXT_multisample
#define WGL_SAMPLE_BUFFERS_EXT         0x2041
#define WGL_SAMPLES_EXT                0x2042
#endif

#ifndef WGL_I3D_digital_video_control
#define WGL_I3D_digital_video_control
#define WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D 0x2050
#define WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D 0x2051
#define WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D 0x2052
#define WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D 0x2053
#endif

#ifndef WGL_I3D_gamma
#define WGL_I3D_gamma
#define WGL_GAMMA_TABLE_SIZE_I3D       0x204E
#define WGL_GAMMA_EXCLUDE_DESKTOP_I3D  0x204F
#endif

#ifndef WGL_I3D_genlock
#define WGL_I3D_genlock
#define WGL_GENLOCK_SOURCE_MULTIVIEW_I3D 0x2044
#define WGL_GENLOCK_SOURCE_EXTENAL_SYNC_I3D 0x2045
#define WGL_GENLOCK_SOURCE_EXTENAL_FIELD_I3D 0x2046
#define WGL_GENLOCK_SOURCE_EXTENAL_TTL_I3D 0x2047
#define WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D 0x2048
#define WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D 0x2049
#define WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D 0x204A
#define WGL_GENLOCK_SOURCE_EDGE_RISING_I3D 0x204B
#define WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D 0x204C
#endif

#ifndef WGL_I3D_image_buffer
#define WGL_I3D_image_buffer
#define WGL_IMAGE_BUFFER_MIN_ACCESS_I3D 0x00000001
#define WGL_IMAGE_BUFFER_LOCK_I3D      0x00000002
#endif

#ifndef WGL_NV_render_depth_texture
#define WGL_NV_render_depth_texture
#define WGL_BIND_TO_TEXTURE_DEPTH_NV   0x20A3
#define WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV 0x20A4
#define WGL_DEPTH_TEXTURE_FORMAT_NV    0x20A5
#define WGL_TEXTURE_DEPTH_COMPONENT_NV 0x20A6
#define WGL_DEPTH_COMPONENT_NV         0x20A7
#endif

#ifndef WGL_NV_render_texture_rectangle
#define WGL_NV_render_texture_rectangle
#define WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV 0x20A0
#define WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV 0x20A1
#define WGL_TEXTURE_RECTANGLE_NV       0x20A2
#endif

#ifndef WGL_NV_float_buffer
#define WGL_NV_float_buffer
#define WGL_FLOAT_COMPONENTS_NV        0x20B0
#define WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV 0x20B1
#define WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV 0x20B2
#define WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV 0x20B3
#define WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV 0x20B4
#define WGL_TEXTURE_FLOAT_R_NV         0x20B5
#define WGL_TEXTURE_FLOAT_RG_NV        0x20B6
#define WGL_TEXTURE_FLOAT_RGB_NV       0x20B7
#define WGL_TEXTURE_FLOAT_RGBA_NV      0x20B8
#endif

#ifndef WGL_3DL_stereo_control
#define WGL_3DL_stereo_control
#define WGL_STEREO_EMITTER_ENABLE_3DL  0x2055
#define WGL_STEREO_EMITTER_DISABLE_3DL 0x2056
#define WGL_STEREO_POLARITY_NORMAL_3DL 0x2057
#define WGL_STEREO_POLARITY_INVERT_3DL 0x2058
#endif

#ifndef WGL_EXT_framebuffer_sRGB
#define WGL_EXT_framebuffer_sRGB
#define WGL_FRAMEBUFFER_SRGB_CAPABLE_EXT 0x20A9
#endif

#ifndef WGL_EXT_pixel_format_packed_float
#define WGL_EXT_pixel_format_packed_float
#define WGL_TYPE_RGBA_UNSIGNED_FLOAT_EXT 0x20A8
#endif

#ifndef WGL_WIN_swap_hint
#define WGL_WIN_swap_hint
#endif

#ifndef WGL_NV_present_video
#define WGL_NV_present_video
DECLARE_HANDLE(HVIDEOOUTPUTDEVICENV);
#define WGL_NUM_VIDEO_SLOTS_NV         0x20F0
#endif

#ifndef WGL_NV_video_out
#define WGL_NV_video_out
DECLARE_HANDLE(HPVIDEODEV);
#define WGL_BIND_TO_VIDEO_RGB_NV       0x20C0
#define WGL_BIND_TO_VIDEO_RGBA_NV      0x20C1
#define WGL_BIND_TO_VIDEO_RGB_AND_DEPTH_NV 0x20C2
#define WGL_VIDEO_OUT_COLOR_NV         0x20C3
#define WGL_VIDEO_OUT_ALPHA_NV         0x20C4
#define WGL_VIDEO_OUT_DEPTH_NV         0x20C5
#define WGL_VIDEO_OUT_COLOR_AND_ALPHA_NV 0x20C6
#define WGL_VIDEO_OUT_COLOR_AND_DEPTH_NV 0x20C7
#define WGL_VIDEO_OUT_FRAME            0x20C8
#define WGL_VIDEO_OUT_FIELD_1          0x20C9
#define WGL_VIDEO_OUT_FIELD_2          0x20CA
#define WGL_VIDEO_OUT_STACKED_FIELDS_1_2 0x20CB
#define WGL_VIDEO_OUT_STACKED_FIELDS_2_1 0x20CC
#endif

#ifndef WGL_NV_swap_group
#define WGL_NV_swap_group
#endif

#ifndef WGL_NV_gpu_affinity
#define WGL_NV_gpu_affinity
DECLARE_HANDLE(HPGPUNV);
DECLARE_HANDLE(HGPUNV);

typedef struct _GPU_DEVICE {
    DWORD  cb;
    CHAR   DeviceName[32];
    CHAR   DeviceString[128];
    DWORD  Flags;
    RECT   rcVirtualScreen;
} GPU_DEVICE, *PGPU_DEVICE;
#define WGL_ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV 0x20D0
#define WGL_ERROR_MISSING_AFFINITY_MASK_NV 0x20D1
#endif

#ifndef WGL_AMD_gpu_association
#define WGL_AMD_gpu_association
#define WGL_GPU_VENDOR_AMD             0x1F00
#define WGL_GPU_RENDERER_STRING_AMD    0x1F01
#define WGL_GPU_OPENGL_VERSION_STRING_AMD 0x1F02
#define WGL_GPU_FASTEST_TARGET_GPUS_AMD 0x21A2
#define WGL_GPU_RAM_AMD                0x21A3
#define WGL_GPU_CLOCK_AMD              0x21A4
#define WGL_GPU_NUM_PIPES_AMD          0x21A5
#define WGL_GPU_NUM_SIMD_AMD           0x21A6
#define WGL_GPU_NUM_RB_AMD             0x21A7
#define WGL_GPU_NUM_SPI_AMD            0x21A8
#endif

#ifndef WGL_NV_video_capture
#define WGL_NV_video_capture
DECLARE_HANDLE(HVIDEOINPUTDEVICENV);
#define WGL_UNIQUE_ID_NV               0x20CE
#define WGL_NUM_VIDEO_CAPTURE_SLOTS_NV 0x20CF
#endif

#ifndef WGL_NV_copy_image
#define WGL_NV_copy_image
#endif
