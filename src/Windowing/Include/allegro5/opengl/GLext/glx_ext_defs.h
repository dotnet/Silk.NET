/* HACK: Prevent both Mesa and SGI's broken headers from screwing us */
#define __glxext_h_
#define __glx_glxext_h_
#include <GL/glx.h>
#undef __glxext_h_
#undef __glx_glxext_h_

#ifndef GLX_VERSION_1_3
#define _ALLEGRO_GLX_VERSION_1_3
#define GLX_VERSION_1_3
#define GLX_WINDOW_BIT                     0x00000001
#define GLX_PIXMAP_BIT                     0x00000002
#define GLX_PBUFFER_BIT                    0x00000004
#define GLX_RGBA_BIT                       0x00000001
#define GLX_COLOR_INDEX_BIT                0x00000002
#define GLX_PBUFFER_CLOBBER_MASK           0x08000000
#define GLX_FRONT_LEFT_BUFFER_BIT          0x00000001
#define GLX_FRONT_RIGHT_BUFFER_BIT         0x00000002
#define GLX_BACK_LEFT_BUFFER_BIT           0x00000004
#define GLX_BACK_RIGHT_BUFFER_BIT          0x00000008
#define GLX_AUX_BUFFERS_BIT                0x00000010
#define GLX_DEPTH_BUFFER_BIT               0x00000020
#define GLX_STENCIL_BUFFER_BIT             0x00000040
#define GLX_ACCUM_BUFFER_BIT               0x00000080
#define GLX_CONFIG_CAVEAT                  0x20
#define GLX_X_VISUAL_TYPE                  0x22
#define GLX_TRANSPARENT_TYPE               0x23
#define GLX_TRANSPARENT_INDEX_VALUE        0x24
#define GLX_TRANSPARENT_RED_VALUE          0x25
#define GLX_TRANSPARENT_GREEN_VALUE        0x26
#define GLX_TRANSPARENT_BLUE_VALUE         0x27
#define GLX_TRANSPARENT_ALPHA_VALUE        0x28
#define GLX_DONT_CARE                      0xFFFFFFFF
#define GLX_NONE                           0x8000
#define GLX_SLOW_CONFIG                    0x8001
#define GLX_TRUE_COLOR                     0x8002
#define GLX_DIRECT_COLOR                   0x8003
#define GLX_PSEUDO_COLOR                   0x8004
#define GLX_STATIC_COLOR                   0x8005
#define GLX_GRAY_SCALE                     0x8006
#define GLX_STATIC_GRAY                    0x8007
#define GLX_TRANSPARENT_RGB                0x8008
#define GLX_TRANSPARENT_INDEX              0x8009
#define GLX_VISUAL_ID                      0x800B
#define GLX_SCREEN                         0x800C
#define GLX_NON_CONFORMANT_CONFIG          0x800D
#define GLX_DRAWABLE_TYPE                  0x8010
#define GLX_RENDER_TYPE                    0x8011
#define GLX_X_RENDERABLE                   0x8012
#define GLX_FBCONFIG_ID                    0x8013
#define GLX_RGBA_TYPE                      0x8014
#define GLX_COLOR_INDEX_TYPE               0x8015
#define GLX_MAX_PBUFFER_WIDTH              0x8016
#define GLX_MAX_PBUFFER_HEIGHT             0x8017
#define GLX_MAX_PBUFFER_PIXELS             0x8018
#define GLX_PRESERVED_CONTENTS             0x801B
#define GLX_LARGEST_PBUFFER                0x801C
#define GLX_WIDTH                          0x801D
#define GLX_HEIGHT                         0x801E
#define GLX_EVENT_MASK                     0x801F
#define GLX_DAMAGED                        0x8020
#define GLX_SAVED                          0x8021
#define GLX_WINDOW                         0x8022
#define GLX_PBUFFER                        0x8023
#define GLX_PBUFFER_HEIGHT                 0x8040
#define GLX_PBUFFER_WIDTH                  0x8041
#endif

#ifndef GLX_VERSION_1_4
#define _ALLEGRO_GLX_VERSION_1_4
#define GLX_VERSION_1_4
#define GLX_SAMPLE_BUFFERS                 100000
#define GLX_SAMPLES                        100001
#endif

#ifndef GLX_ARB_get_proc_address
#define _ALLEGRO_GLX_ARB_get_proc_address
#define GLX_ARB_get_proc_address
typedef void (*__GLXextFuncPtr)(void);
#endif

#ifndef GLX_ARB_multisample
#define _ALLEGRO_GLX_ARB_multisample
#define GLX_ARB_multisample
#define GLX_SAMPLE_BUFFERS_ARB             100000
#define GLX_SAMPLES_ARB                    100001
#endif

#ifndef GLX_ARB_vertex_buffer_object
#define GLX_ARB_vertex_buffer_object
#define _ALLEGRO_GLX_ARB_vertex_buffer_object
#define GLX_CONTEXT_ALLOW_BUFFER_BYTE_ORDER_MISMATCH_ARB 0x2095
#endif

#ifndef GLX_ARB_fbconfig_float
#define GLX_ARB_fbconfig_float
#define _ALLEGRO_GLX_ARB_fbconfig_float
#define GLX_RGBA_FLOAT_TYPE_ARB            0x20B9
#define GLX_RGBA_FLOAT_BIT_ARB             0x00000004
#endif

#ifndef GLX_ARB_create_context
#define GLX_ARB_create_context
#define _ALLEGRO_GLX_ARB_create_context
#define GLX_CONTEXT_DEBUG_BIT_ARB          0x00000001
#define GLX_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB 0x00000002
#define GLX_CONTEXT_MAJOR_VERSION_ARB      0x2091
#define GLX_CONTEXT_MINOR_VERSION_ARB      0x2092
#define GLX_CONTEXT_FLAGS_ARB              0x2094
#endif

#ifndef GLX_ARB_create_context_profile
#define GLX_ARB_create_context_profile
#define _ALLEGRO_GLX_ARB_create_context_profile
#define GLX_CONTEXT_CORE_PROFILE_BIT_ARB   0x00000001
#define GLX_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB 0x00000002
#define GLX_CONTEXT_PROFILE_MASK_ARB       0x9126
#endif

#ifndef GLX_SGIS_multisample
#define _ALLEGRO_GLX_SGIS_multisample
#define GLX_SGIS_multisample
#define GLX_SAMPLE_BUFFERS_SGIS            100000
#define GLX_SAMPLES_SGIS                   100001
#endif

/* Fix for system headers that define GLX_VERSION_1_4 but do not define
 * GLX_SAMPLES and GLX_SAMPLE_BUFFERS. */
#ifndef GLX_SAMPLES
#define GLX_SAMPLE_BUFFERS                 100000
#define GLX_SAMPLES                        100001
#endif

#ifndef GLX_EXT_visual_info
#define _ALLEGRO_GLX_EXT_visual_info
#define GLX_EXT_visual_info
#define GLX_X_VISUAL_TYPE_EXT              0x22
#define GLX_TRANSPARENT_TYPE_EXT           0x23
#define GLX_TRANSPARENT_INDEX_VALUE_EXT    0x24
#define GLX_TRANSPARENT_RED_VALUE_EXT      0x25
#define GLX_TRANSPARENT_GREEN_VALUE_EXT    0x26
#define GLX_TRANSPARENT_BLUE_VALUE_EXT     0x27
#define GLX_TRANSPARENT_ALPHA_VALUE_EXT    0x28
#define GLX_NONE_EXT                       0x8000
#define GLX_TRUE_COLOR_EXT                 0x8002
#define GLX_DIRECT_COLOR_EXT               0x8003
#define GLX_PSEUDO_COLOR_EXT               0x8004
#define GLX_STATIC_COLOR_EXT               0x8005
#define GLX_GRAY_SCALE_EXT                 0x8006
#define GLX_STATIC_GRAY_EXT                0x8007
#define GLX_TRANSPARENT_RGB_EXT            0x8008
#define GLX_TRANSPARENT_INDEX_EXT          0x8009
#endif

#ifndef GLX_EXT_visual_rating
#define _ALLEGRO_GLX_EXT_visual_rating
#define GLX_EXT_visual_rating
#define GLX_VISUAL_CAVEAT_EXT              0x20
#define GLX_SLOW_VISUAL_EXT                0x8001
#define GLX_NON_CONFORMANT_VISUAL_EXT      0x800D
/* GLX_NONE_EXT */
#endif

#ifndef GLX_EXT_import_context
#define _ALLEGRO_GLX_EXT_import_context
#define GLX_EXT_import_context
#define GLX_SHARE_CONTEXT_EXT              0x800A
#define GLX_VISUAL_ID_EXT                  0x800B
#define GLX_SCREEN_EXT                     0x800C
#endif

#ifndef GLX_SGIX_fbconfig
#define _ALLEGRO_GLX_SGIX_fbconfig
#define GLX_SGIX_fbconfig
typedef XID GLXFBConfigIDSGIX;
typedef struct __GLXFBConfigRec *GLXFBConfigSGIX;
#define GLX_WINDOW_BIT_SGIX                0x00000001
#define GLX_PIXMAP_BIT_SGIX                0x00000002
#define GLX_RGBA_BIT_SGIX                  0x00000001
#define GLX_COLOR_INDEX_BIT_SGIX           0x00000002
#define GLX_DRAWABLE_TYPE_SGIX             0x8010
#define GLX_RENDER_TYPE_SGIX               0x8011
#define GLX_X_RENDERABLE_SGIX              0x8012
#define GLX_FBCONFIG_ID_SGIX               0x8013
#define GLX_RGBA_TYPE_SGIX                 0x8014
#define GLX_COLOR_INDEX_TYPE_SGIX          0x8015
/* GLX_SCREEN_EXT */
#endif

#ifndef GLX_SGIX_pbuffer
#define _ALLEGRO_GLX_SGIX_pbuffer
#define GLX_SGIX_pbuffer
typedef XID GLXPbufferSGIX;
typedef struct {
    int type;
    unsigned long serial;  /* # of last request processed by server */
    Bool send_event;       /* true if this came for SendEvent request */
    Display *display;      /* display the event was read from */
    GLXDrawable drawable;  /* i.d. of Drawable */
    int event_type;        /* GLX_DAMAGED_SGIX or GLX_SAVED_SGIX */
    int draw_type;         /* GLX_WINDOW_SGIX or GLX_PBUFFER_SGIX */
    unsigned int mask;     /* mask indicating which buffers are affected*/
    int x, y;
    int width, height;
    int count;             /* if nonzero, at least this many more */
} GLXBufferClobberEventSGIX;
#define GLX_PBUFFER_BIT_SGIX               0x00000004
#define GLX_BUFFER_CLOBBER_MASK_SGIX       0x08000000
#define GLX_FRONT_LEFT_BUFFER_BIT_SGIX     0x00000001
#define GLX_FRONT_RIGHT_BUFFER_BIT_SGIX    0x00000002
#define GLX_BACK_LEFT_BUFFER_BIT_SGIX      0x00000004
#define GLX_BACK_RIGHT_BUFFER_BIT_SGIX     0x00000008
#define GLX_AUX_BUFFERS_BIT_SGIX           0x00000010
#define GLX_DEPTH_BUFFER_BIT_SGIX          0x00000020
#define GLX_STENCIL_BUFFER_BIT_SGIX        0x00000040
#define GLX_ACCUM_BUFFER_BIT_SGIX          0x00000080
#define GLX_SAMPLE_BUFFERS_BIT_SGIX        0x00000100
#define GLX_MAX_PBUFFER_WIDTH_SGIX         0x8016
#define GLX_MAX_PBUFFER_HEIGHT_SGIX        0x8017
#define GLX_MAX_PBUFFER_PIXELS_SGIX        0x8018
#define GLX_OPTIMAL_PBUFFER_WIDTH_SGIX     0x8019
#define GLX_OPTIMAL_PBUFFER_HEIGHT_SGIX    0x801A
#define GLX_PRESERVED_CONTENTS_SGIX        0x801B
#define GLX_LARGEST_PBUFFER_SGIX           0x801C
#define GLX_WIDTH_SGIX                     0x801D
#define GLX_HEIGHT_SGIX                    0x801E
#define GLX_EVENT_MASK_SGIX                0x801F
#define GLX_DAMAGED_SGIX                   0x8020
#define GLX_SAVED_SGIX                     0x8021
#define GLX_WINDOW_SGIX                    0x8022
#define GLX_PBUFFER_SGIX                   0x8023
#endif

#ifndef GLX_SGIX_video_resize
#define _ALLEGRO_GLX_SGIX_video_resize
#define GLX_SGIX_video_resize
#define GLX_SYNC_FRAME_SGIX                0x00000000
#define GLX_SYNC_SWAP_SGIX                 0x00000001
#endif

#ifndef GLX_SGIX_dmbuffer
#define _ALLEGRO_GLX_SGIX_dmbuffer
#define GLX_SGIX_dmbuffer
#define GLX_DIGITAL_MEDIA_PBUFFER_SGIX     0x8024
#endif

#ifndef GLX_SGIS_blended_overlay
#define _ALLEGRO_GLX_SGIS_blended_overlay
#define GLX_SGIS_blended_overlay
#define GLX_BLENDED_RGBA_SGIS              0x8025
#endif

#ifndef GLX_SGIS_shared_multisample
#define _ALLEGRO_GLX_SGIS_shared_multisample
#define GLX_SGIS_shared_multisample
#define GLX_MULTISAMPLE_SUB_RECT_WIDTH_SGIS 0x8026
#define GLX_MULTISAMPLE_SUB_RECT_HEIGHT_SGIS 0x8027
#endif

#ifndef GLX_3DFX_multisample
#define _ALLEGRO_GLX_3DFX_multisample
#define GLX_3DFX_multisample
#define GLX_SAMPLE_BUFFERS_3DFX            0x8050
#define GLX_SAMPLES_3DFX                   0x8051
#endif

#ifndef GLX_MESA_set_3dfx_mode
#define _ALLEGRO_GLX_MESA_set_3dfx_mode
#define GLX_MESA_set_3dfx_mode
#define GLX_3DFX_WINDOW_MODE_MESA          0x1
#define GLX_3DFX_FULLSCREEN_MODE_MESA      0x2
#endif

#ifndef GLX_SGIX_visual_select_group
#define _ALLEGRO_GLX_SGIX_visual_select_group
#define GLX_SGIX_visual_select_group
#define GLX_VISUAL_SELECT_GROUP_SGIX       0x8028
#endif

#ifndef GLX_OML_swap_method
#define _ALLEGRO_GLX_OML_swap_method
#define GLX_OML_swap_method
#define GLX_SWAP_METHOD_OML                0x8060
#define GLX_SWAP_EXCHANGE_OML              0x8061
#define GLX_SWAP_COPY_OML                  0x8062
#define GLX_SWAP_UNDEFINED_OML             0x8063
#endif

#ifndef GLX_SGIX_video_source
#define _ALLEGRO_GLX_SGIX_video_source
#define GLX_SGIX_video_source
typedef XID GLXVideoSourceSGIX;
#endif

#ifndef GLX_SGI_video_sync
#define GLX_SGI_video_sync
#define _ALLEGRO_GLX_SGI_video_sync
#endif

#ifndef GLX_SGI_swap_control
#define GLX_SGI_swap_control
#define _ALLEGRO_GLX_SGI_swap_control
#endif

#ifndef GLX_SGI_make_current_read
#define GLX_SGI_make_current_read
#define _ALLEGRO_GLX_SGI_make_current_read
#endif

#ifndef GLX_SGI_cushion
#define GLX_SGI_cushion
#define _ALLEGRO_GLX_SGI_cushion
#endif

#ifndef GLX_SGIX_swap_group
#define GLX_SGIX_swap_group
#define _ALLEGRO_GLX_SGIX_swap_group
#endif

#ifndef GLX_SGIX_swap_barrier
#define GLX_SGIX_swap_barrier
#define _ALLEGRO_GLX_SGIX_swap_barrier
#endif

#ifndef GLX_SUN_get_transparent_index
#define GLX_SUN_get_transparent_index
#define _ALLEGRO_GLX_SUN_get_transparent_index
#endif

#ifndef GLX_MESA_copy_sub_buffer
#define GLX_MESA_copy_sub_buffer
#define _ALLEGRO_GLX_MESA_copy_sub_buffer
#endif

#ifndef GLX_MESA_pixmap_colormap
#define GLX_MESA_pixmap_colormap
#define _ALLEGRO_GLX_MESA_pixmap_colormap
#endif

#ifndef GLX_MESA_release_buffers
#define GLX_MESA_release_buffers
#define _ALLEGRO_GLX_MESA_release_buffers
#endif

#ifndef GLX_OML_sync_control
#define GLX_OML_sync_control
#define _ALLEGRO_GLX_OML_sync_control
#endif

#ifndef GLX_SGIX_hyperpipe
#define GLX_SGIX_hyperpipe
#define _ALLEGRO_GLX_SGIX_hyperpipe
#define GLX_HYPERPIPE_ID_SGIX              0x8030
#define GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX 80
#define GLX_HYPERPIPE_DISPLAY_PIPE_SGIX    0x00000001
#define GLX_HYPERPIPE_RENDER_PIPE_SGIX     0x00000002
#define GLX_PIPE_RECT_SGIX                 0x00000001
#define GLX_PIPE_RECT_LIMITS_SGIX          0x00000002
#define GLX_HYPERPIPE_STEREO_SGIX          0x00000003
#define GLX_HYPERPIPE_PIXEL_AVERAGE_SGIX   0x00000004
#define GLX_BAD_HYPERPIPE_CONFIG_SGIX      91
#define GLX_BAD_HYPERPIPE_SGIX             92

typedef struct {
	char  pipeName[GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX];
	int  networkId;
} GLXHyperpipeNetworkSGIX;

typedef struct {
	char pipeName[GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX];
	int channel;
	unsigned int participationType;
	int timeSlice;
} GLXHyperpipeConfigSGIX;

typedef struct {
	char pipeName[GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX];
	int srcXOrigin;
	int srcYOrigin;
	int srcWidth;
	int srcHeight;
	int destXOrigin;
	int destYOrigin;
	int destWidth;
	int destHeight;
} GLXPipeRect;

typedef struct {
	char pipeName[GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX];
	int XOrigin;
	int YOrigin;
	int maxHeight;
	int maxWidth;
} GLXPipeRectLimits;
#endif


#ifndef GLX_MESA_agp_offset
#define GLX_MESA_agp_offset
#define _ALLEGRO_GLX_MESA_agp_offset
#endif

#ifndef GLX_EXT_framebuffer_sRGB
#define GLX_EXT_framebuffer_sRGB
#define _ALLEGRO_GLX_EXT_framebuffer_sRGB
#define GLX_FRAMEBUFFER_SRGB_CAPABLE_EXT   0x20B2
#endif

#ifndef GLX_EXT_fbconfig_packed_float
#define GLX_EXT_fbconfig_packed_float
#define _ALLEGRO_GLX_EXT_fbconfig_packed_float
#define GLX_RGBA_UNSIGNED_FLOAT_TYPE_EXT 0x20B1
#define GLX_RGBA_UNSIGNED_FLOAT_BIT_EXT  0x00000008
#endif

#ifndef GLX_EXT_texture_from_pixmap
#define GLX_EXT_texture_from_pixmap
#define _ALLEGRO_GLX_EXT_texture_from_pixmap
#define GLX_BIND_TO_TEXTURE_RGB_EXT      0x20D0
#define GLX_BIND_TO_TEXTURE_RGBA_EXT     0x20D1
#define GLX_BIND_TO_MIPMAP_TEXTURE_EXT   0x20D2
#define GLX_BIND_TO_TEXTURE_TARGETS_EXT  0x20D3
#define GLX_Y_INVERTED_EXT               0x20D4
#define GLX_TEXTURE_FORMAT_EXT           0x20D5
#define GLX_TEXTURE_TARGET_EXT           0x20D6
#define GLX_MIPMAP_TEXTURE_EXT           0x20D7
#define GLX_TEXTURE_FORMAT_NONE_EXT      0x20D8
#define GLX_TEXTURE_FORMAT_RGB_EXT       0x20D9
#define GLX_TEXTURE_FORMAT_RGBA_EXT      0x20DA
#define GLX_TEXTURE_1D_BIT_EXT           0x00000001
#define GLX_TEXTURE_2D_BIT_EXT           0x00000002
#define GLX_TEXTURE_RECTANGLE_BIT_EXT    0x00000004
#define GLX_TEXTURE_1D_EXT               0x20DB
#define GLX_TEXTURE_2D_EXT               0x20DC
#define GLX_TEXTURE_RECTANGLE_EXT        0x20DD
#define GLX_FRONT_LEFT_EXT               0x20DE
#define GLX_FRONT_RIGHT_EXT              0x20DF
#define GLX_BACK_LEFT_EXT                0x20E0
#define GLX_BACK_RIGHT_EXT               0x20E1
#define GLX_FRONT_EXT                    GLX_FRONT_LEFT_EXT
#define GLX_BACK_EXT                     GLX_BACK_LEFT_EXT
#define GLX_AUX0_EXT                     0x20E2
#define GLX_AUX1_EXT                     0x20E3
#define GLX_AUX2_EXT                     0x20E4
#define GLX_AUX3_EXT                     0x20E5
#define GLX_AUX4_EXT                     0x20E6
#define GLX_AUX5_EXT                     0x20E7
#define GLX_AUX6_EXT                     0x20E8
#define GLX_AUX7_EXT                     0x20E9
#define GLX_AUX8_EXT                     0x20EA
#define GLX_AUX9_EXT                     0x20EB
#endif

#ifndef GLX_NV_present_video
#define GLX_NV_present_video
#define _ALLEGRO_GLX_NV_present_video
#define GLX_GLX_NUM_VIDEO_SLOTS_NV         0x20F0
#endif

#ifndef GLX_NV_video_output
#define GLX_NV_video_output
#define _ALLEGRO_GLX_NV_video_output
#define GLX_VIDEO_OUT_COLOR_NV           0x20C3
#define GLX_VIDEO_OUT_ALPHA_NV           0x20C4
#define GLX_VIDEO_OUT_DEPTH_NV           0x20C5
#define GLX_VIDEO_OUT_COLOR_AND_ALPHA_NV 0x20C6
#define GLX_VIDEO_OUT_COLOR_AND_DEPTH_NV 0x20C7
#define GLX_VIDEO_OUT_FRAME_NV           0x20C8
#define GLX_VIDEO_OUT_FIELD_1_NV         0x20C9
#define GLX_VIDEO_OUT_FIELD_2_NV         0x20CA
typedef unsigned int GLXVideoDeviceNV;
#endif

#ifndef GLX_NV_swap_group
#define GLX_NV_swap_group
#define _ALLEGRO_GLX_NV_swap_group
#endif

#ifndef GLX_NV_video_capture
#define GLX_NV_video_capture
#define _ALLEGRO_GLX_NV_video_capture
#define GLX_DEVICE_ID_NV                   0x20CD
#define GLX_UNIQUE_ID_NV                   0x20CE
#define GLX_NUM_VIDEO_CAPTURE_SLOTS_NV     0x20CF
typedef XID GLXVideoCaptureDeviceNV;
#endif

#ifndef GLX_EXT_swap_control
#define GLX_EXT_swap_control
#define _ALLEGRO_GLX_EXT_swap_control
#define GLX_SWAP_INTERVAL_EXT              0x20F1
#define GLX_MAX_SWAP_INTERVAL_EXT          0x20F2
#endif

#ifndef GLX_NV_copy_image
#define GLX_NV_copy_image
#define _ALLEGRO_GLX_NV_copy_image
#endif

#ifndef GLX_INTEL_swap_event
#define GLX_INTEL_swap_event
#define _ALLEGRO_GLX_INTEL_swap_event
#define GLX_BUFFER_SWAP_COMPLETE_INTEL_MASK 0x04000000
#define GLX_EXCHANGE_COMPLETE_INTEL        0x8180
#define GLX_COPY_COMPLETE_INTEL            0x8181
#define GLX_FLIP_COMPLETE_INTEL            0x8182
#endif

#ifndef GLX_EXT_create_context_es_profile
#define GLX_EXT_create_context_es_profile
#define GLX_EXT_create_context_es2_profile
#define _ALLEGRO_GLX_EXT_create_context_es_profile
#define GLX_CONTEXT_ES_PROFILE_BIT_EXT		0x00000004
#define GLX_CONTEXT_ES2_PROFILE_BIT_EXT		0x00000004
#endif
