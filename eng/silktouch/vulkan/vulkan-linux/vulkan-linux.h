#include <vk_video/vulkan_video_codec_av1std.h>
#include <vk_video/vulkan_video_codec_av1std_decode.h>
#include <vk_video/vulkan_video_codec_av1std_encode.h>
#include <vk_video/vulkan_video_codec_h264std.h>
#include <vk_video/vulkan_video_codec_h264std_decode.h>
#include <vk_video/vulkan_video_codec_h264std_encode.h>
#include <vk_video/vulkan_video_codec_h265std.h>
#include <vk_video/vulkan_video_codec_h265std_decode.h>
#include <vk_video/vulkan_video_codec_h265std_encode.h>
#include <vk_video/vulkan_video_codec_vp9std.h>
#include <vk_video/vulkan_video_codec_vp9std_decode.h>
#include <vk_video/vulkan_video_codecs_common.h>

#include <vulkan/vulkan.h>
#include <vulkan/vulkan_core.h>

#include <vulkan/vk_icd.h>
#include <vulkan/vk_layer.h>

#include <vulkan/vulkan_android.h>
#include <vulkan/vulkan_ohos.h>
#include <vulkan/vulkan_screen.h>
#include <vulkan/vulkan_vi.h>
#include <vulkan/vulkan_wayland.h>
#include <vulkan/vulkan_xcb.h>
#include <vulkan/vulkan_xlib.h>
#include <vulkan/vulkan_xlib_xrandr.h>

// zx_handle_t is from https://fuchsia.googlesource.com/fuchsia/+/master/zircon/system/public/zircon/types.h#35
typedef uint32_t zx_handle_t;
#include <vulkan/vulkan_fuchsia.h>

// Google Gaming Platform and Stadia are dead
// #include <vulkan/vulkan_ggp.h>
