// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    public abstract unsafe partial class Allegro : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_MEMORY_BITMAP")]
        public const int AllegroMemoryBitmap = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "_ALLEGRO_KEEP_BITMAP_FORMAT")]
        public const int AllegroKeepBitmapFormat = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_FORCE_LOCKING")]
        public const int AllegroForceLocking = 0x4;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_NO_PRESERVE_TEXTURE")]
        public const int AllegroNoPreserveTexture = 0x8;
        [NativeName("Type", "int")]
        [NativeName("Name", "_ALLEGRO_ALPHA_TEST")]
        public const int AllegroAlphaTest = 0x10;
        [NativeName("Type", "int")]
        [NativeName("Name", "_ALLEGRO_INTERNAL_OPENGL")]
        public const int AllegroInternalOpengl = 0x20;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_MIN_LINEAR")]
        public const int AllegroMinLinear = 0x40;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_MAG_LINEAR")]
        public const int AllegroMagLinear = 0x80;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_MIPMAP")]
        public const int AllegroMipmap = 0x100;
        [NativeName("Type", "int")]
        [NativeName("Name", "_ALLEGRO_NO_PREMULTIPLIED_ALPHA")]
        public const int AllegroNoPremultipliedAlpha = 0x200;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_VIDEO_BITMAP")]
        public const int AllegroVideoBitmap = 0x400;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_CONVERT_BITMAP")]
        public const int AllegroConvertBitmap = 0x1000;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_FLIP_HORIZONTAL")]
        public const int AllegroFlipHorizontal = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_FLIP_VERTICAL")]
        public const int AllegroFlipVertical = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_KEEP_INDEX")]
        public const int AllegroKeepIndex = 0x800;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_LOCK_READWRITE")]
        public const int AllegroLockReadwrite = 0x0;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_LOCK_READONLY")]
        public const int AllegroLockReadonly = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_LOCK_WRITEONLY")]
        public const int AllegroLockWriteonly = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_AXIS")]
        public const int AllegroEventJoystickAxis = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_BUTTON_DOWN")]
        public const int AllegroEventJoystickButtonDown = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_BUTTON_UP")]
        public const int AllegroEventJoystickButtonUp = 0x3;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_CONFIGURATION")]
        public const int AllegroEventJoystickConfiguration = 0x4;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_KEY_DOWN")]
        public const int AllegroEventKeyDown = 0xA;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_KEY_CHAR")]
        public const int AllegroEventKeyChar = 0xB;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_KEY_UP")]
        public const int AllegroEventKeyUp = 0xC;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_AXES")]
        public const int AllegroEventMouseAxes = 0x14;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_BUTTON_DOWN")]
        public const int AllegroEventMouseButtonDown = 0x15;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_BUTTON_UP")]
        public const int AllegroEventMouseButtonUp = 0x16;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_ENTER_DISPLAY")]
        public const int AllegroEventMouseEnterDisplay = 0x17;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_LEAVE_DISPLAY")]
        public const int AllegroEventMouseLeaveDisplay = 0x18;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_WARPED")]
        public const int AllegroEventMouseWarped = 0x19;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_TIMER")]
        public const int AllegroEventTimer = 0x1E;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_EXPOSE")]
        public const int AllegroEventDisplayExpose = 0x28;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_RESIZE")]
        public const int AllegroEventDisplayResize = 0x29;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_CLOSE")]
        public const int AllegroEventDisplayClose = 0x2A;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_LOST")]
        public const int AllegroEventDisplayLost = 0x2B;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_FOUND")]
        public const int AllegroEventDisplayFound = 0x2C;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_SWITCH_IN")]
        public const int AllegroEventDisplaySwitchIn = 0x2D;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_SWITCH_OUT")]
        public const int AllegroEventDisplaySwitchOut = 0x2E;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_ORIENTATION")]
        public const int AllegroEventDisplayOrientation = 0x2F;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_HALT_DRAWING")]
        public const int AllegroEventDisplayHaltDrawing = 0x30;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_RESUME_DRAWING")]
        public const int AllegroEventDisplayResumeDrawing = 0x31;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_BEGIN")]
        public const int AllegroEventTouchBegin = 0x32;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_END")]
        public const int AllegroEventTouchEnd = 0x33;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_MOVE")]
        public const int AllegroEventTouchMove = 0x34;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_CANCEL")]
        public const int AllegroEventTouchCancel = 0x35;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_CONNECTED")]
        public const int AllegroEventDisplayConnected = 0x3C;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_DISCONNECTED")]
        public const int AllegroEventDisplayDisconnected = 0x3D;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_WINDOWED")]
        public const int AllegroWindowed = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_FULLSCREEN")]
        public const int AllegroFullscreen = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_OPENGL")]
        public const int AllegroOpengl = 0x4;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_DIRECT3D_INTERNAL")]
        public const int AllegroDirect3DInternal = 0x8;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_RESIZABLE")]
        public const int AllegroResizable = 0x10;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_FRAMELESS")]
        public const int AllegroFrameless = 0x20;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_NOFRAME")]
        public const int AllegroNoframe = 0x20;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_GENERATE_EXPOSE_EVENTS")]
        public const int AllegroGenerateExposeEvents = 0x40;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_OPENGL_3_0")]
        public const int AllegroOpengl30 = 0x80;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_OPENGL_FORWARD_COMPATIBLE")]
        public const int AllegroOpenglForwardCompatible = 0x100;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_FULLSCREEN_WINDOW")]
        public const int AllegroFullscreenWindow = 0x200;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_MINIMIZED")]
        public const int AllegroMinimized = 0x400;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_PROGRAMMABLE_PIPELINE")]
        public const int AllegroProgrammablePipeline = 0x800;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_GTK_TOPLEVEL_INTERNAL")]
        public const int AllegroGtkToplevelInternal = 0x1000;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_MAXIMIZED")]
        public const int AllegroMaximized = 0x2000;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_OPENGL_ES_PROFILE")]
        public const int AllegroOpenglESProfile = 0x4000;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_DONTCARE")]
        public const int AllegroDontcare = 0x0;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_REQUIRE")]
        public const int AllegroRequire = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_SUGGEST")]
        public const int AllegroSuggest = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "_ALLEGRO_PRIM_MAX_USER_ATTR")]
        public const int AllegroPrimMaxUserAttr = 0xA;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_DEFAULT_DISPLAY_ADAPTER")]
        public const int AllegroDefaultDisplayAdapter = unchecked((int)0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_RESOURCES_PATH")]
        public const int AllegroResourcesPath = 0x0;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_TEMP_PATH")]
        public const int AllegroTempPath = 0x1;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_USER_DATA_PATH")]
        public const int AllegroUserDataPath = 0x2;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_USER_HOME_PATH")]
        public const int AllegroUserHomePath = 0x3;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_USER_SETTINGS_PATH")]
        public const int AllegroUserSettingsPath = 0x4;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_USER_DOCUMENTS_PATH")]
        public const int AllegroUserDocumentsPath = 0x5;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_EXENAME_PATH")]
        public const int AllegroExenamePath = 0x6;
        [NativeName("Type", "int")]
        [NativeName("Name", "ALLEGRO_LAST_PATH")]
        public const int AllegroLastPath = 0x7;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_allegro_version")]
        public abstract uint GetAllegroVersion();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_run_main")]
        public abstract unsafe int RunMain(int argc, byte** argv, void* arg2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_run_main")]
        public abstract unsafe int RunMain<T0>(int argc, byte** argv, Span<T0> arg2) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_time")]
        public abstract double GetTime();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_rest")]
        public abstract void Rest(double seconds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_init_timeout")]
        public abstract unsafe void InitTimeout(AllegroTimeout* timeout, double seconds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_init_timeout")]
        public abstract void InitTimeout(Span<AllegroTimeout> timeout, double seconds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_map_rgb")]
        public abstract AllegroColor MapRgb(byte r, byte g, byte b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_map_rgba")]
        public abstract AllegroColor MapRgba(byte r, byte g, byte b, byte a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_map_rgb_f")]
        public abstract AllegroColor MapRgbF(float r, float g, float b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_map_rgba_f")]
        public abstract AllegroColor MapRgbaF(float r, float g, float b, float a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_premul_rgba")]
        public abstract AllegroColor PremulRgba(byte r, byte g, byte b, byte a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_premul_rgba_f")]
        public abstract AllegroColor PremulRgbaF(float r, float g, float b, float a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgb")]
        public abstract unsafe void UnmapRgb(AllegroColor color, byte* r, byte* g, byte* b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgb")]
        public abstract void UnmapRgb(AllegroColor color, Span<byte> r, Span<byte> g, Span<byte> b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgba")]
        public abstract unsafe void UnmapRgba(AllegroColor color, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgba")]
        public abstract void UnmapRgba(AllegroColor color, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgb_f")]
        public abstract unsafe void UnmapRgbF(AllegroColor color, float* r, float* g, float* b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgb_f")]
        public abstract void UnmapRgbF(AllegroColor color, Span<float> r, Span<float> g, Span<float> b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgba_f")]
        public abstract unsafe void UnmapRgbaF(AllegroColor color, float* r, float* g, float* b, float* a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgba_f")]
        public abstract void UnmapRgbaF(AllegroColor color, Span<float> r, Span<float> g, Span<float> b, Span<float> a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel_size")]
        public abstract int GetPixelSize(int format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel_format_bits")]
        public abstract int GetPixelFormatBits(int format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel_block_size")]
        public abstract int GetPixelBlockSize(int format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel_block_width")]
        public abstract int GetPixelBlockWidth(int format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel_block_height")]
        public abstract int GetPixelBlockHeight(int format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_bitmap_format")]
        public abstract void SetNewBitmapFormat(int format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_bitmap_flags")]
        public abstract void SetNewBitmapFlags(int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_bitmap_format")]
        public abstract int GetNewBitmapFormat();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_bitmap_flags")]
        public abstract int GetNewBitmapFlags();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_new_bitmap_flag")]
        public abstract void AddNewBitmapFlag(int flag);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_width")]
        public abstract unsafe int GetBitmapWidth(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_width")]
        public abstract int GetBitmapWidth(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_height")]
        public abstract unsafe int GetBitmapHeight(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_height")]
        public abstract int GetBitmapHeight(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_format")]
        public abstract unsafe int GetBitmapFormat(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_format")]
        public abstract int GetBitmapFormat(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_flags")]
        public abstract unsafe int GetBitmapFlags(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_flags")]
        public abstract int GetBitmapFlags(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_bitmap")]
        public abstract unsafe AllegroBitmap* CreateBitmap(int w, int h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_bitmap")]
        public abstract unsafe void DestroyBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_bitmap")]
        public abstract void DestroyBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_put_pixel")]
        public abstract void PutPixel(int x, int y, AllegroColor color);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_put_blended_pixel")]
        public abstract void PutBlendedPixel(int x, int y, AllegroColor color);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel")]
        public abstract unsafe AllegroColor GetPixel(AllegroBitmap* bitmap, int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_pixel")]
        public abstract AllegroColor GetPixel(Span<AllegroBitmap> bitmap, int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_convert_mask_to_alpha")]
        public abstract unsafe void ConvertMaskToAlpha(AllegroBitmap* bitmap, AllegroColor mask_color);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_convert_mask_to_alpha")]
        public abstract void ConvertMaskToAlpha(Span<AllegroBitmap> bitmap, AllegroColor mask_color);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_clipping_rectangle")]
        public abstract void SetClippingRectangle(int x, int y, int width, int height);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_reset_clipping_rectangle")]
        public abstract void ResetClippingRectangle();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_clipping_rectangle")]
        public abstract unsafe void GetClippingRectangle(int* x, int* y, int* w, int* h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_clipping_rectangle")]
        public abstract void GetClippingRectangle(Span<int> x, Span<int> y, Span<int> w, Span<int> h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_sub_bitmap")]
        public abstract unsafe AllegroBitmap* CreateSubBitmap(AllegroBitmap* parent, int x, int y, int w, int h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_sub_bitmap")]
        public abstract unsafe AllegroBitmap* CreateSubBitmap(Span<AllegroBitmap> parent, int x, int y, int w, int h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_sub_bitmap")]
        public abstract unsafe bool IsSubBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_sub_bitmap")]
        public abstract bool IsSubBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_parent_bitmap")]
        public abstract unsafe AllegroBitmap* GetParentBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_parent_bitmap")]
        public abstract unsafe AllegroBitmap* GetParentBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_x")]
        public abstract unsafe int GetBitmapX(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_x")]
        public abstract int GetBitmapX(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_y")]
        public abstract unsafe int GetBitmapY(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_bitmap_y")]
        public abstract int GetBitmapY(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_reparent_bitmap")]
        public abstract unsafe void ReparentBitmap(AllegroBitmap* bitmap, AllegroBitmap* parent, int x, int y, int w, int h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_reparent_bitmap")]
        public abstract void ReparentBitmap(Span<AllegroBitmap> bitmap, Span<AllegroBitmap> parent, int x, int y, int w, int h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_clone_bitmap")]
        public abstract unsafe AllegroBitmap* CloneBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_clone_bitmap")]
        public abstract unsafe AllegroBitmap* CloneBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_convert_bitmap")]
        public abstract unsafe void ConvertBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_convert_bitmap")]
        public abstract void ConvertBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_convert_memory_bitmaps")]
        public abstract void ConvertMemoryBitmaps();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_bitmap")]
        public abstract unsafe void DrawBitmap(AllegroBitmap* bitmap, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_bitmap")]
        public abstract void DrawBitmap(Span<AllegroBitmap> bitmap, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_bitmap_region")]
        public abstract unsafe void DrawBitmapRegion(AllegroBitmap* bitmap, float sx, float sy, float sw, float sh, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_bitmap_region")]
        public abstract void DrawBitmapRegion(Span<AllegroBitmap> bitmap, float sx, float sy, float sw, float sh, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_scaled_bitmap")]
        public abstract unsafe void DrawScaledBitmap(AllegroBitmap* bitmap, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_scaled_bitmap")]
        public abstract void DrawScaledBitmap(Span<AllegroBitmap> bitmap, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_rotated_bitmap")]
        public abstract unsafe void DrawRotatedBitmap(AllegroBitmap* bitmap, float cx, float cy, float dx, float dy, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_rotated_bitmap")]
        public abstract void DrawRotatedBitmap(Span<AllegroBitmap> bitmap, float cx, float cy, float dx, float dy, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_scaled_rotated_bitmap")]
        public abstract unsafe void DrawScaledRotatedBitmap(AllegroBitmap* bitmap, float cx, float cy, float dx, float dy, float xscale, float yscale, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_scaled_rotated_bitmap")]
        public abstract void DrawScaledRotatedBitmap(Span<AllegroBitmap> bitmap, float cx, float cy, float dx, float dy, float xscale, float yscale, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_bitmap")]
        public abstract unsafe void DrawTintedBitmap(AllegroBitmap* bitmap, AllegroColor tint, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_bitmap")]
        public abstract void DrawTintedBitmap(Span<AllegroBitmap> bitmap, AllegroColor tint, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_bitmap_region")]
        public abstract unsafe void DrawTintedBitmapRegion(AllegroBitmap* bitmap, AllegroColor tint, float sx, float sy, float sw, float sh, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_bitmap_region")]
        public abstract void DrawTintedBitmapRegion(Span<AllegroBitmap> bitmap, AllegroColor tint, float sx, float sy, float sw, float sh, float dx, float dy, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_scaled_bitmap")]
        public abstract unsafe void DrawTintedScaledBitmap(AllegroBitmap* bitmap, AllegroColor tint, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_scaled_bitmap")]
        public abstract void DrawTintedScaledBitmap(Span<AllegroBitmap> bitmap, AllegroColor tint, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_rotated_bitmap")]
        public abstract unsafe void DrawTintedRotatedBitmap(AllegroBitmap* bitmap, AllegroColor tint, float cx, float cy, float dx, float dy, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_rotated_bitmap")]
        public abstract void DrawTintedRotatedBitmap(Span<AllegroBitmap> bitmap, AllegroColor tint, float cx, float cy, float dx, float dy, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_scaled_rotated_bitmap")]
        public abstract unsafe void DrawTintedScaledRotatedBitmap(AllegroBitmap* bitmap, AllegroColor tint, float cx, float cy, float dx, float dy, float xscale, float yscale, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_scaled_rotated_bitmap")]
        public abstract void DrawTintedScaledRotatedBitmap(Span<AllegroBitmap> bitmap, AllegroColor tint, float cx, float cy, float dx, float dy, float xscale, float yscale, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_scaled_rotated_bitmap_region")]
        public abstract unsafe void DrawTintedScaledRotatedBitmapRegion(AllegroBitmap* bitmap, float sx, float sy, float sw, float sh, AllegroColor tint, float cx, float cy, float dx, float dy, float xscale, float yscale, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_draw_tinted_scaled_rotated_bitmap_region")]
        public abstract void DrawTintedScaledRotatedBitmapRegion(Span<AllegroBitmap> bitmap, float sx, float sy, float sw, float sh, AllegroColor tint, float cx, float cy, float dx, float dy, float xscale, float yscale, float angle, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new")]
        public abstract unsafe AllegroString* UstrNew(byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new")]
        public abstract unsafe AllegroString* UstrNew(Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new_from_buffer")]
        public abstract unsafe AllegroString* UstrNewFromBuffer(byte* s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new_from_buffer")]
        public abstract unsafe AllegroString* UstrNewFromBuffer(Span<byte> s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_newf")]
        public abstract unsafe AllegroString* UstrNewf(byte* fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_newf")]
        public abstract unsafe AllegroString* UstrNewf(Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_free")]
        public abstract unsafe void UstrFree(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_free")]
        public abstract void UstrFree(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr")]
        public abstract unsafe byte* Cstr(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr")]
        public abstract unsafe byte* Cstr(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_to_buffer")]
        public abstract unsafe void UstrToBuffer(AllegroString* us, byte* buffer, int size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_to_buffer")]
        public abstract void UstrToBuffer(Span<AllegroString> us, Span<byte> buffer, int size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr_dup")]
        public abstract unsafe byte* CstrDup(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr_dup")]
        public abstract unsafe byte* CstrDup(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_dup")]
        public abstract unsafe AllegroString* UstrDup(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_dup")]
        public abstract unsafe AllegroString* UstrDup(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_dup_substr")]
        public abstract unsafe AllegroString* UstrDupSubstr(AllegroString* us, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_dup_substr")]
        public abstract unsafe AllegroString* UstrDupSubstr(Span<AllegroString> us, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_empty_string")]
        public abstract unsafe AllegroString* UstrEmptyString();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_cstr")]
        public abstract unsafe AllegroString* RefCstr(AllegroString* info, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_cstr")]
        public abstract unsafe AllegroString* RefCstr(Span<AllegroString> info, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_buffer")]
        public abstract unsafe AllegroString* RefBuffer(AllegroString* info, byte* s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_buffer")]
        public abstract unsafe AllegroString* RefBuffer(Span<AllegroString> info, Span<byte> s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_ustr")]
        public abstract unsafe AllegroString* RefUstr(AllegroString* info, AllegroString* us, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_ustr")]
        public abstract unsafe AllegroString* RefUstr(Span<AllegroString> info, Span<AllegroString> us, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_size")]
        public abstract unsafe uint UstrSize(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_size")]
        public abstract uint UstrSize(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_length")]
        public abstract unsafe uint UstrLength(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_length")]
        public abstract uint UstrLength(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_offset")]
        public abstract unsafe int UstrOffset(AllegroString* us, int index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_offset")]
        public abstract int UstrOffset(Span<AllegroString> us, int index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_next")]
        public abstract unsafe bool UstrNext(AllegroString* us, int* pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_next")]
        public abstract bool UstrNext(Span<AllegroString> us, Span<int> pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_prev")]
        public abstract unsafe bool UstrPrev(AllegroString* us, int* pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_prev")]
        public abstract bool UstrPrev(Span<AllegroString> us, Span<int> pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_get")]
        public abstract unsafe int UstrGet(AllegroString* us, int pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_get")]
        public abstract int UstrGet(Span<AllegroString> us, int pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_get_next")]
        public abstract unsafe int UstrGetNext(AllegroString* us, int* pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_get_next")]
        public abstract int UstrGetNext(Span<AllegroString> us, Span<int> pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_prev_get")]
        public abstract unsafe int UstrPrevGet(AllegroString* us, int* pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_prev_get")]
        public abstract int UstrPrevGet(Span<AllegroString> us, Span<int> pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert")]
        public abstract unsafe bool UstrInsert(AllegroString* us1, int pos, AllegroString* us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert")]
        public abstract bool UstrInsert(Span<AllegroString> us1, int pos, Span<AllegroString> us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert_cstr")]
        public abstract unsafe bool UstrInsertCstr(AllegroString* us, int pos, byte* us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert_cstr")]
        public abstract bool UstrInsertCstr(Span<AllegroString> us, int pos, Span<byte> us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert_chr")]
        public abstract unsafe uint UstrInsertChr(AllegroString* us, int pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert_chr")]
        public abstract uint UstrInsertChr(Span<AllegroString> us, int pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append")]
        public abstract unsafe bool UstrAppend(AllegroString* us1, AllegroString* us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append")]
        public abstract bool UstrAppend(Span<AllegroString> us1, Span<AllegroString> us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append_cstr")]
        public abstract unsafe bool UstrAppendCstr(AllegroString* us, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append_cstr")]
        public abstract bool UstrAppendCstr(Span<AllegroString> us, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append_chr")]
        public abstract unsafe uint UstrAppendChr(AllegroString* us, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append_chr")]
        public abstract uint UstrAppendChr(Span<AllegroString> us, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_appendf")]
        public abstract unsafe bool UstrAppendf(AllegroString* us, byte* fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_appendf")]
        public abstract bool UstrAppendf(Span<AllegroString> us, Span<byte> fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_vappendf")]
        public abstract unsafe bool UstrVappendf(AllegroString* us, byte* fmt, byte* ap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_vappendf")]
        public abstract bool UstrVappendf(Span<AllegroString> us, Span<byte> fmt, Span<byte> ap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_remove_chr")]
        public abstract unsafe bool UstrRemoveChr(AllegroString* us, int pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_remove_chr")]
        public abstract bool UstrRemoveChr(Span<AllegroString> us, int pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_remove_range")]
        public abstract unsafe bool UstrRemoveRange(AllegroString* us, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_remove_range")]
        public abstract bool UstrRemoveRange(Span<AllegroString> us, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_truncate")]
        public abstract unsafe bool UstrTruncate(AllegroString* us, int start_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_truncate")]
        public abstract bool UstrTruncate(Span<AllegroString> us, int start_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_ltrim_ws")]
        public abstract unsafe bool UstrLtrimWs(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_ltrim_ws")]
        public abstract bool UstrLtrimWs(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rtrim_ws")]
        public abstract unsafe bool UstrRtrimWs(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rtrim_ws")]
        public abstract bool UstrRtrimWs(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_trim_ws")]
        public abstract unsafe bool UstrTrimWs(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_trim_ws")]
        public abstract bool UstrTrimWs(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign")]
        public abstract unsafe bool UstrAssign(AllegroString* us1, AllegroString* us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign")]
        public abstract bool UstrAssign(Span<AllegroString> us1, Span<AllegroString> us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign_substr")]
        public abstract unsafe bool UstrAssignSubstr(AllegroString* us1, AllegroString* us2, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign_substr")]
        public abstract bool UstrAssignSubstr(Span<AllegroString> us1, Span<AllegroString> us2, int start_pos, int end_pos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign_cstr")]
        public abstract unsafe bool UstrAssignCstr(AllegroString* us1, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign_cstr")]
        public abstract bool UstrAssignCstr(Span<AllegroString> us1, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_set_chr")]
        public abstract unsafe uint UstrSetChr(AllegroString* us, int pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_set_chr")]
        public abstract uint UstrSetChr(Span<AllegroString> us, int pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_replace_range")]
        public abstract unsafe bool UstrReplaceRange(AllegroString* us1, int start_pos1, int end_pos1, AllegroString* us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_replace_range")]
        public abstract bool UstrReplaceRange(Span<AllegroString> us1, int start_pos1, int end_pos1, Span<AllegroString> us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_chr")]
        public abstract unsafe int UstrFindChr(AllegroString* us, int start_pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_chr")]
        public abstract int UstrFindChr(Span<AllegroString> us, int start_pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_chr")]
        public abstract unsafe int UstrRfindChr(AllegroString* us, int start_pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_chr")]
        public abstract int UstrRfindChr(Span<AllegroString> us, int start_pos, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_set")]
        public abstract unsafe int UstrFindSet(AllegroString* us, int start_pos, AllegroString* accept);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_set")]
        public abstract int UstrFindSet(Span<AllegroString> us, int start_pos, Span<AllegroString> accept);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_set_cstr")]
        public abstract unsafe int UstrFindSetCstr(AllegroString* us, int start_pos, byte* accept);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_set_cstr")]
        public abstract int UstrFindSetCstr(Span<AllegroString> us, int start_pos, Span<byte> accept);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cset")]
        public abstract unsafe int UstrFindCset(AllegroString* us, int start_pos, AllegroString* reject);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cset")]
        public abstract int UstrFindCset(Span<AllegroString> us, int start_pos, Span<AllegroString> reject);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cset_cstr")]
        public abstract unsafe int UstrFindCsetCstr(AllegroString* us, int start_pos, byte* reject);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cset_cstr")]
        public abstract int UstrFindCsetCstr(Span<AllegroString> us, int start_pos, Span<byte> reject);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_str")]
        public abstract unsafe int UstrFindStr(AllegroString* haystack, int start_pos, AllegroString* needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_str")]
        public abstract int UstrFindStr(Span<AllegroString> haystack, int start_pos, Span<AllegroString> needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cstr")]
        public abstract unsafe int UstrFindCstr(AllegroString* haystack, int start_pos, byte* needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cstr")]
        public abstract int UstrFindCstr(Span<AllegroString> haystack, int start_pos, Span<byte> needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_str")]
        public abstract unsafe int UstrRfindStr(AllegroString* haystack, int start_pos, AllegroString* needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_str")]
        public abstract int UstrRfindStr(Span<AllegroString> haystack, int start_pos, Span<AllegroString> needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_cstr")]
        public abstract unsafe int UstrRfindCstr(AllegroString* haystack, int start_pos, byte* needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_cstr")]
        public abstract int UstrRfindCstr(Span<AllegroString> haystack, int start_pos, Span<byte> needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_replace")]
        public abstract unsafe bool UstrFindReplace(AllegroString* us, int start_pos, AllegroString* find, AllegroString* replace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_replace")]
        public abstract bool UstrFindReplace(Span<AllegroString> us, int start_pos, Span<AllegroString> find, Span<AllegroString> replace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_replace_cstr")]
        public abstract unsafe bool UstrFindReplaceCstr(AllegroString* us, int start_pos, byte* find, byte* replace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_replace_cstr")]
        public abstract bool UstrFindReplaceCstr(Span<AllegroString> us, int start_pos, Span<byte> find, Span<byte> replace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_equal")]
        public abstract unsafe bool UstrEqual(AllegroString* us1, AllegroString* us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_equal")]
        public abstract bool UstrEqual(Span<AllegroString> us1, Span<AllegroString> us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_compare")]
        public abstract unsafe int UstrCompare(AllegroString* u, AllegroString* v);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_compare")]
        public abstract int UstrCompare(Span<AllegroString> u, Span<AllegroString> v);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_ncompare")]
        public abstract unsafe int UstrNcompare(AllegroString* us1, AllegroString* us2, int n);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_ncompare")]
        public abstract int UstrNcompare(Span<AllegroString> us1, Span<AllegroString> us2, int n);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_prefix")]
        public abstract unsafe bool UstrHasPrefix(AllegroString* u, AllegroString* v);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_prefix")]
        public abstract bool UstrHasPrefix(Span<AllegroString> u, Span<AllegroString> v);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_prefix_cstr")]
        public abstract unsafe bool UstrHasPrefixCstr(AllegroString* u, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_prefix_cstr")]
        public abstract bool UstrHasPrefixCstr(Span<AllegroString> u, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_suffix")]
        public abstract unsafe bool UstrHasSuffix(AllegroString* u, AllegroString* v);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_suffix")]
        public abstract bool UstrHasSuffix(Span<AllegroString> u, Span<AllegroString> v);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_suffix_cstr")]
        public abstract unsafe bool UstrHasSuffixCstr(AllegroString* us1, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_suffix_cstr")]
        public abstract bool UstrHasSuffixCstr(Span<AllegroString> us1, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf8_width")]
        public abstract uint Utf8Width(int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf8_encode")]
        public abstract unsafe uint Utf8Encode(byte* s, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf8_encode")]
        public abstract uint Utf8Encode(Span<byte> s, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new_from_utf16")]
        public abstract unsafe AllegroString* UstrNewFromUtf16(ushort* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new_from_utf16")]
        public abstract unsafe AllegroString* UstrNewFromUtf16(Span<ushort> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_size_utf16")]
        public abstract unsafe uint UstrSizeUtf16(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_size_utf16")]
        public abstract uint UstrSizeUtf16(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_encode_utf16")]
        public abstract unsafe uint UstrEncodeUtf16(AllegroString* us, ushort* s, uint n);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_encode_utf16")]
        public abstract uint UstrEncodeUtf16(Span<AllegroString> us, Span<ushort> s, uint n);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf16_width")]
        public abstract uint Utf16Width(int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf16_encode")]
        public abstract unsafe uint Utf16Encode(ushort* s, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf16_encode")]
        public abstract uint Utf16Encode(Span<ushort> s, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_path")]
        public abstract unsafe AllegroPath* CreatePath(byte* str);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_path")]
        public abstract unsafe AllegroPath* CreatePath(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_path_for_directory")]
        public abstract unsafe AllegroPath* CreatePathForDirectory(byte* str);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_path_for_directory")]
        public abstract unsafe AllegroPath* CreatePathForDirectory(Span<byte> str);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_clone_path")]
        public abstract unsafe AllegroPath* ClonePath(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_clone_path")]
        public abstract unsafe AllegroPath* ClonePath(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_num_components")]
        public abstract unsafe int GetPathNumComponents(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_num_components")]
        public abstract int GetPathNumComponents(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_component")]
        public abstract unsafe byte* GetPathComponent(AllegroPath* path, int i);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_component")]
        public abstract unsafe byte* GetPathComponent(Span<AllegroPath> path, int i);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_replace_path_component")]
        public abstract unsafe void ReplacePathComponent(AllegroPath* path, int i, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_replace_path_component")]
        public abstract void ReplacePathComponent(Span<AllegroPath> path, int i, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_path_component")]
        public abstract unsafe void RemovePathComponent(AllegroPath* path, int i);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_path_component")]
        public abstract void RemovePathComponent(Span<AllegroPath> path, int i);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_insert_path_component")]
        public abstract unsafe void InsertPathComponent(AllegroPath* path, int i, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_insert_path_component")]
        public abstract void InsertPathComponent(Span<AllegroPath> path, int i, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_tail")]
        public abstract unsafe byte* GetPathTail(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_tail")]
        public abstract unsafe byte* GetPathTail(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_drop_path_tail")]
        public abstract unsafe void DropPathTail(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_drop_path_tail")]
        public abstract void DropPathTail(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_append_path_component")]
        public abstract unsafe void AppendPathComponent(AllegroPath* path, byte* s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_append_path_component")]
        public abstract void AppendPathComponent(Span<AllegroPath> path, Span<byte> s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_join_paths")]
        public abstract unsafe bool JoinPaths(AllegroPath* path, AllegroPath* tail);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_join_paths")]
        public abstract bool JoinPaths(Span<AllegroPath> path, Span<AllegroPath> tail);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_rebase_path")]
        public abstract unsafe bool RebasePath(AllegroPath* head, AllegroPath* tail);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_rebase_path")]
        public abstract bool RebasePath(Span<AllegroPath> head, Span<AllegroPath> tail);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_path_cstr")]
        public abstract unsafe byte* PathCstr(AllegroPath* path, byte delim);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_path_cstr")]
        public abstract unsafe byte* PathCstr(Span<AllegroPath> path, byte delim);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_path_ustr")]
        public abstract unsafe AllegroString* PathUstr(AllegroPath* path, byte delim);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_path_ustr")]
        public abstract unsafe AllegroString* PathUstr(Span<AllegroPath> path, byte delim);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_path")]
        public abstract unsafe void DestroyPath(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_path")]
        public abstract void DestroyPath(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_drive")]
        public abstract unsafe void SetPathDrive(AllegroPath* path, byte* drive);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_drive")]
        public abstract void SetPathDrive(Span<AllegroPath> path, Span<byte> drive);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_drive")]
        public abstract unsafe byte* GetPathDrive(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_drive")]
        public abstract unsafe byte* GetPathDrive(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_filename")]
        public abstract unsafe void SetPathFilename(AllegroPath* path, byte* filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_filename")]
        public abstract void SetPathFilename(Span<AllegroPath> path, Span<byte> filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_filename")]
        public abstract unsafe byte* GetPathFilename(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_filename")]
        public abstract unsafe byte* GetPathFilename(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_extension")]
        public abstract unsafe byte* GetPathExtension(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_extension")]
        public abstract unsafe byte* GetPathExtension(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_extension")]
        public abstract unsafe bool SetPathExtension(AllegroPath* path, byte* extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_extension")]
        public abstract bool SetPathExtension(Span<AllegroPath> path, Span<byte> extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_basename")]
        public abstract unsafe byte* GetPathBasename(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_basename")]
        public abstract unsafe byte* GetPathBasename(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_make_path_canonical")]
        public abstract unsafe bool MakePathCanonical(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_make_path_canonical")]
        public abstract bool MakePathCanonical(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen")]
        public abstract unsafe AllegroFile* Fopen(byte* path, byte* mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen")]
        public abstract unsafe AllegroFile* Fopen(Span<byte> path, Span<byte> mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_interface")]
        public abstract unsafe AllegroFile* FopenInterface(AllegroFileInterface* vt, byte* path, byte* mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_interface")]
        public abstract unsafe AllegroFile* FopenInterface(Span<AllegroFileInterface> vt, Span<byte> path, Span<byte> mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_file_handle")]
        public abstract unsafe AllegroFile* CreateFileHandle(AllegroFileInterface* vt, void* userdata);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_file_handle")]
        public abstract unsafe AllegroFile* CreateFileHandle<T0>(Span<AllegroFileInterface> vt, Span<T0> userdata) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fclose")]
        public abstract unsafe bool Fclose(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fclose")]
        public abstract bool Fclose(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread")]
        public abstract unsafe uint Fread(AllegroFile* f, void* ptr, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread")]
        public abstract uint Fread<T0>(Span<AllegroFile> f, Span<T0> ptr, uint size) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite")]
        public abstract unsafe uint Fwrite(AllegroFile* f, void* ptr, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite")]
        public abstract uint Fwrite<T0>(Span<AllegroFile> f, Span<T0> ptr, uint size) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fflush")]
        public abstract unsafe bool Fflush(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fflush")]
        public abstract bool Fflush(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ftell")]
        public abstract unsafe long Ftell(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ftell")]
        public abstract long Ftell(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fseek")]
        public abstract unsafe bool Fseek(AllegroFile* f, long offset, int whence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fseek")]
        public abstract bool Fseek(Span<AllegroFile> f, long offset, int whence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_feof")]
        public abstract unsafe bool Feof(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_feof")]
        public abstract bool Feof(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ferror")]
        public abstract unsafe int Ferror(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ferror")]
        public abstract int Ferror(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ferrmsg")]
        public abstract unsafe byte* Ferrmsg(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ferrmsg")]
        public abstract unsafe byte* Ferrmsg(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fclearerr")]
        public abstract unsafe void Fclearerr(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fclearerr")]
        public abstract void Fclearerr(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fungetc")]
        public abstract unsafe int Fungetc(AllegroFile* f, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fungetc")]
        public abstract int Fungetc(Span<AllegroFile> f, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fsize")]
        public abstract unsafe long Fsize(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fsize")]
        public abstract long Fsize(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fgetc")]
        public abstract unsafe int Fgetc(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fgetc")]
        public abstract int Fgetc(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fputc")]
        public abstract unsafe int Fputc(AllegroFile* f, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fputc")]
        public abstract int Fputc(Span<AllegroFile> f, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread16le")]
        public abstract unsafe short Fread16le(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread16le")]
        public abstract short Fread16le(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread16be")]
        public abstract unsafe short Fread16be(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread16be")]
        public abstract short Fread16be(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite16le")]
        public abstract unsafe uint Fwrite16le(AllegroFile* f, short w);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite16le")]
        public abstract uint Fwrite16le(Span<AllegroFile> f, short w);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite16be")]
        public abstract unsafe uint Fwrite16be(AllegroFile* f, short w);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite16be")]
        public abstract uint Fwrite16be(Span<AllegroFile> f, short w);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread32le")]
        public abstract unsafe int Fread32le(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread32le")]
        public abstract int Fread32le(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread32be")]
        public abstract unsafe int Fread32be(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fread32be")]
        public abstract int Fread32be(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite32le")]
        public abstract unsafe uint Fwrite32le(AllegroFile* f, int l);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite32le")]
        public abstract uint Fwrite32le(Span<AllegroFile> f, int l);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite32be")]
        public abstract unsafe uint Fwrite32be(AllegroFile* f, int l);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fwrite32be")]
        public abstract uint Fwrite32be(Span<AllegroFile> f, int l);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fgets")]
        public abstract unsafe byte* Fgets(AllegroFile* f, byte* p, uint max);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fgets")]
        public abstract unsafe byte* Fgets(Span<AllegroFile> f, Span<byte> p, uint max);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fget_ustr")]
        public abstract unsafe AllegroString* FgetUstr(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fget_ustr")]
        public abstract unsafe AllegroString* FgetUstr(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fputs")]
        public abstract unsafe int Fputs(AllegroFile* f, byte* p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fputs")]
        public abstract int Fputs(Span<AllegroFile> f, Span<byte> p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fprintf")]
        public abstract unsafe int Fprintf(AllegroFile* f, byte* format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fprintf")]
        public abstract int Fprintf(Span<AllegroFile> f, Span<byte> format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_vfprintf")]
        public abstract unsafe int Vfprintf(AllegroFile* f, byte* format, byte* args);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_vfprintf")]
        public abstract int Vfprintf(Span<AllegroFile> f, Span<byte> format, Span<byte> args);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_fd")]
        public abstract unsafe AllegroFile* FopenFd(int fd, byte* mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_fd")]
        public abstract unsafe AllegroFile* FopenFd(int fd, Span<byte> mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_make_temp_file")]
        public abstract unsafe AllegroFile* MakeTempFile(byte* tmpl, AllegroPath** ret_path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_make_temp_file")]
        public abstract unsafe AllegroFile* MakeTempFile(Span<byte> tmpl, AllegroPath** ret_path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_slice")]
        public abstract unsafe AllegroFile* FopenSlice(AllegroFile* fp, uint initial_size, byte* mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_slice")]
        public abstract unsafe AllegroFile* FopenSlice(Span<AllegroFile> fp, uint initial_size, Span<byte> mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_file_interface")]
        public abstract unsafe AllegroFileInterface* GetNewFileInterface();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_file_interface")]
        public abstract unsafe void SetNewFileInterface(AllegroFileInterface* file_interface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_file_interface")]
        public abstract void SetNewFileInterface(Span<AllegroFileInterface> file_interface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_standard_file_interface")]
        public abstract void SetStandardFileInterface();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_file_userdata")]
        public abstract unsafe void* GetFileUserdata(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_file_userdata")]
        public abstract unsafe void* GetFileUserdata(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader")]
        public abstract unsafe bool RegisterBitmapLoader(byte* ext, void* loader);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader")]
        public abstract bool RegisterBitmapLoader<T0>(Span<byte> ext, Span<T0> loader) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver")]
        public abstract unsafe bool RegisterBitmapSaver(byte* ext, void* saver);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver")]
        public abstract bool RegisterBitmapSaver<T0>(Span<byte> ext, Span<T0> saver) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader_f")]
        public abstract unsafe bool RegisterBitmapLoaderF(byte* ext, void* fs_loader);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader_f")]
        public abstract bool RegisterBitmapLoaderF<T0>(Span<byte> ext, Span<T0> fs_loader) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver_f")]
        public abstract unsafe bool RegisterBitmapSaverF(byte* ext, void* fs_saver);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver_f")]
        public abstract bool RegisterBitmapSaverF<T0>(Span<byte> ext, Span<T0> fs_saver) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_identifier")]
        public abstract unsafe bool RegisterBitmapIdentifier(byte* ext, void* identifier);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_identifier")]
        public abstract bool RegisterBitmapIdentifier<T0>(Span<byte> ext, Span<T0> identifier) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap")]
        public abstract unsafe AllegroBitmap* LoadBitmap(byte* filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap")]
        public abstract unsafe AllegroBitmap* LoadBitmap(Span<byte> filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlags(byte* filename, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlags(Span<byte> filename, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapF(AllegroFile* fp, byte* ident);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapF(Span<AllegroFile> fp, Span<byte> ident);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlagsF(AllegroFile* fp, byte* ident, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlagsF(Span<AllegroFile> fp, Span<byte> ident, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap")]
        public abstract unsafe bool SaveBitmap(byte* filename, AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap")]
        public abstract bool SaveBitmap(Span<byte> filename, Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap_f")]
        public abstract unsafe bool SaveBitmapF(AllegroFile* fp, byte* ident, AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap_f")]
        public abstract bool SaveBitmapF(Span<AllegroFile> fp, Span<byte> ident, Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap_f")]
        public abstract unsafe byte* IdentifyBitmapF(AllegroFile* fp);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap_f")]
        public abstract unsafe byte* IdentifyBitmapF(Span<AllegroFile> fp);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap")]
        public abstract unsafe byte* IdentifyBitmap(byte* filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap")]
        public abstract unsafe byte* IdentifyBitmap(Span<byte> filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap")]
        public abstract unsafe AllegroLockedRegion* LockBitmap(AllegroBitmap* bitmap, int format, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap")]
        public abstract unsafe AllegroLockedRegion* LockBitmap(Span<AllegroBitmap> bitmap, int format, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap_region")]
        public abstract unsafe AllegroLockedRegion* LockBitmapRegion(AllegroBitmap* bitmap, int x, int y, int width, int height, int format, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap_region")]
        public abstract unsafe AllegroLockedRegion* LockBitmapRegion(Span<AllegroBitmap> bitmap, int x, int y, int width, int height, int format, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap_blocked")]
        public abstract unsafe AllegroLockedRegion* LockBitmapBlocked(AllegroBitmap* bitmap, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap_blocked")]
        public abstract unsafe AllegroLockedRegion* LockBitmapBlocked(Span<AllegroBitmap> bitmap, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap_region_blocked")]
        public abstract unsafe AllegroLockedRegion* LockBitmapRegionBlocked(AllegroBitmap* bitmap, int x_block, int y_block, int width_block, int height_block, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_lock_bitmap_region_blocked")]
        public abstract unsafe AllegroLockedRegion* LockBitmapRegionBlocked(Span<AllegroBitmap> bitmap, int x_block, int y_block, int width_block, int height_block, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unlock_bitmap")]
        public abstract unsafe void UnlockBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unlock_bitmap")]
        public abstract void UnlockBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_bitmap_locked")]
        public abstract unsafe bool IsBitmapLocked(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_bitmap_locked")]
        public abstract bool IsBitmapLocked(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_blender")]
        public abstract void SetBlender(int op, int source, int dest);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_blend_color")]
        public abstract void SetBlendColor(AllegroColor color);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_blender")]
        public abstract unsafe void GetBlender(int* op, int* source, int* dest);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_blender")]
        public abstract void GetBlender(Span<int> op, Span<int> source, Span<int> dest);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_blend_color")]
        public abstract AllegroColor GetBlendColor();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_separate_blender")]
        public abstract void SetSeparateBlender(int op, int source, int dest, int alpha_op, int alpha_source, int alpha_dest);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_separate_blender")]
        public abstract unsafe void GetSeparateBlender(int* op, int* source, int* dest, int* alpha_op, int* alpha_src, int* alpha_dest);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_separate_blender")]
        public abstract void GetSeparateBlender(Span<int> op, Span<int> source, Span<int> dest, Span<int> alpha_op, Span<int> alpha_src, Span<int> alpha_dest);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_init_user_event_source")]
        public abstract unsafe void InitUserEventSource(AllegroEventSource* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_init_user_event_source")]
        public abstract void InitUserEventSource(Span<AllegroEventSource> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_user_event_source")]
        public abstract unsafe void DestroyUserEventSource(AllegroEventSource* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_user_event_source")]
        public abstract void DestroyUserEventSource(Span<AllegroEventSource> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_emit_user_event")]
        public abstract unsafe bool EmitUserEvent(AllegroEventSource* arg0, AllegroEvent* arg1, void* dtor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_emit_user_event")]
        public abstract bool EmitUserEvent<T0>(Span<AllegroEventSource> arg0, Span<AllegroEvent> arg1, Span<T0> dtor) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unref_user_event")]
        public abstract unsafe void UnrefUserEvent(AllegroUserEvent* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unref_user_event")]
        public abstract void UnrefUserEvent(Span<AllegroUserEvent> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_event_source_data")]
        public abstract unsafe void SetEventSourceData(AllegroEventSource* arg0, int data);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_event_source_data")]
        public abstract void SetEventSourceData(Span<AllegroEventSource> arg0, int data);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_event_source_data")]
        public abstract unsafe int GetEventSourceData(AllegroEventSource* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_event_source_data")]
        public abstract int GetEventSourceData(Span<AllegroEventSource> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_event_queue")]
        public abstract unsafe AllegroEventQueue* CreateEventQueue();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_event_queue")]
        public abstract unsafe void DestroyEventQueue(AllegroEventQueue* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_event_queue")]
        public abstract void DestroyEventQueue(Span<AllegroEventQueue> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_event_source_registered")]
        public abstract unsafe bool IsEventSourceRegistered(AllegroEventQueue* arg0, AllegroEventSource* arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_event_source_registered")]
        public abstract bool IsEventSourceRegistered(Span<AllegroEventQueue> arg0, Span<AllegroEventSource> arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_event_source")]
        public abstract unsafe void RegisterEventSource(AllegroEventQueue* arg0, AllegroEventSource* arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_event_source")]
        public abstract void RegisterEventSource(Span<AllegroEventQueue> arg0, Span<AllegroEventSource> arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unregister_event_source")]
        public abstract unsafe void UnregisterEventSource(AllegroEventQueue* arg0, AllegroEventSource* arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unregister_event_source")]
        public abstract void UnregisterEventSource(Span<AllegroEventQueue> arg0, Span<AllegroEventSource> arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_pause_event_queue")]
        public abstract unsafe void PauseEventQueue(AllegroEventQueue* arg0, bool arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_pause_event_queue")]
        public abstract void PauseEventQueue(Span<AllegroEventQueue> arg0, bool arg1);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_event_queue_paused")]
        public abstract unsafe bool IsEventQueuePaused(AllegroEventQueue* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_event_queue_paused")]
        public abstract bool IsEventQueuePaused(Span<AllegroEventQueue> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_event_queue_empty")]
        public abstract unsafe bool IsEventQueueEmpty(AllegroEventQueue* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_event_queue_empty")]
        public abstract bool IsEventQueueEmpty(Span<AllegroEventQueue> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_next_event")]
        public abstract unsafe bool GetNextEvent(AllegroEventQueue* arg0, AllegroEvent* ret_event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_next_event")]
        public abstract bool GetNextEvent(Span<AllegroEventQueue> arg0, Span<AllegroEvent> ret_event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_peek_next_event")]
        public abstract unsafe bool PeekNextEvent(AllegroEventQueue* arg0, AllegroEvent* ret_event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_peek_next_event")]
        public abstract bool PeekNextEvent(Span<AllegroEventQueue> arg0, Span<AllegroEvent> ret_event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_drop_next_event")]
        public abstract unsafe bool DropNextEvent(AllegroEventQueue* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_drop_next_event")]
        public abstract bool DropNextEvent(Span<AllegroEventQueue> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_flush_event_queue")]
        public abstract unsafe void FlushEventQueue(AllegroEventQueue* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_flush_event_queue")]
        public abstract void FlushEventQueue(Span<AllegroEventQueue> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_event")]
        public abstract unsafe void WaitForEvent(AllegroEventQueue* arg0, AllegroEvent* ret_event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_event")]
        public abstract void WaitForEvent(Span<AllegroEventQueue> arg0, Span<AllegroEvent> ret_event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_event_timed")]
        public abstract unsafe bool WaitForEventTimed(AllegroEventQueue* arg0, AllegroEvent* ret_event, float secs);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_event_timed")]
        public abstract bool WaitForEventTimed(Span<AllegroEventQueue> arg0, Span<AllegroEvent> ret_event, float secs);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_event_until")]
        public abstract unsafe bool WaitForEventUntil(AllegroEventQueue* queue, AllegroEvent* ret_event, AllegroTimeout* timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_event_until")]
        public abstract bool WaitForEventUntil(Span<AllegroEventQueue> queue, Span<AllegroEvent> ret_event, Span<AllegroTimeout> timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_display_refresh_rate")]
        public abstract void SetNewDisplayRefreshRate(int refresh_rate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_display_flags")]
        public abstract void SetNewDisplayFlags(int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_display_refresh_rate")]
        public abstract int GetNewDisplayRefreshRate();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_display_flags")]
        public abstract int GetNewDisplayFlags();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_window_title")]
        public abstract unsafe void SetNewWindowTitle(byte* title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_window_title")]
        public abstract void SetNewWindowTitle(Span<byte> title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_window_title")]
        public abstract unsafe byte* GetNewWindowTitle();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_width")]
        public abstract unsafe int GetDisplayWidth(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_width")]
        public abstract int GetDisplayWidth(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_height")]
        public abstract unsafe int GetDisplayHeight(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_height")]
        public abstract int GetDisplayHeight(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_format")]
        public abstract unsafe int GetDisplayFormat(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_format")]
        public abstract int GetDisplayFormat(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_refresh_rate")]
        public abstract unsafe int GetDisplayRefreshRate(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_refresh_rate")]
        public abstract int GetDisplayRefreshRate(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_flags")]
        public abstract unsafe int GetDisplayFlags(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_flags")]
        public abstract int GetDisplayFlags(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_orientation")]
        public abstract unsafe int GetDisplayOrientation(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_orientation")]
        public abstract int GetDisplayOrientation(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_flag")]
        public abstract unsafe bool SetDisplayFlag(AllegroDisplay* display, int flag, bool onoff);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_flag")]
        public abstract bool SetDisplayFlag(Span<AllegroDisplay> display, int flag, bool onoff);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_display")]
        public abstract unsafe AllegroDisplay* CreateDisplay(int w, int h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_display")]
        public abstract unsafe void DestroyDisplay(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_display")]
        public abstract void DestroyDisplay(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_current_display")]
        public abstract unsafe AllegroDisplay* GetCurrentDisplay();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_target_bitmap")]
        public abstract unsafe void SetTargetBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_target_bitmap")]
        public abstract void SetTargetBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_target_backbuffer")]
        public abstract unsafe void SetTargetBackbuffer(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_target_backbuffer")]
        public abstract void SetTargetBackbuffer(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_backbuffer")]
        public abstract unsafe AllegroBitmap* GetBackbuffer(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_backbuffer")]
        public abstract unsafe AllegroBitmap* GetBackbuffer(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_target_bitmap")]
        public abstract unsafe AllegroBitmap* GetTargetBitmap();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_acknowledge_resize")]
        public abstract unsafe bool AcknowledgeResize(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_acknowledge_resize")]
        public abstract bool AcknowledgeResize(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_resize_display")]
        public abstract unsafe bool ResizeDisplay(AllegroDisplay* display, int width, int height);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_resize_display")]
        public abstract bool ResizeDisplay(Span<AllegroDisplay> display, int width, int height);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_flip_display")]
        public abstract void FlipDisplay();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_update_display_region")]
        public abstract void UpdateDisplayRegion(int x, int y, int width, int height);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_compatible_bitmap")]
        public abstract unsafe bool IsCompatibleBitmap(AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_compatible_bitmap")]
        public abstract bool IsCompatibleBitmap(Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_wait_for_vsync")]
        public abstract bool WaitForVsync();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_event_source")]
        public abstract unsafe AllegroEventSource* GetDisplayEventSource(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_event_source")]
        public abstract unsafe AllegroEventSource* GetDisplayEventSource(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_icon")]
        public abstract unsafe void SetDisplayIcon(AllegroDisplay* display, AllegroBitmap* icon);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_icon")]
        public abstract void SetDisplayIcon(Span<AllegroDisplay> display, Span<AllegroBitmap> icon);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_icons")]
        public abstract unsafe void SetDisplayIcons(AllegroDisplay* display, int num_icons, AllegroBitmap** icons);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_icons")]
        public abstract unsafe void SetDisplayIcons(Span<AllegroDisplay> display, int num_icons, AllegroBitmap** icons);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_display_adapter")]
        public abstract int GetNewDisplayAdapter();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_display_adapter")]
        public abstract void SetNewDisplayAdapter(int adapter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_window_position")]
        public abstract void SetNewWindowPosition(int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_window_position")]
        public abstract unsafe void GetNewWindowPosition(int* x, int* y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_window_position")]
        public abstract void GetNewWindowPosition(Span<int> x, Span<int> y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_position")]
        public abstract unsafe void SetWindowPosition(AllegroDisplay* display, int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_position")]
        public abstract void SetWindowPosition(Span<AllegroDisplay> display, int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_window_position")]
        public abstract unsafe void GetWindowPosition(AllegroDisplay* display, int* x, int* y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_window_position")]
        public abstract void GetWindowPosition(Span<AllegroDisplay> display, Span<int> x, Span<int> y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_constraints")]
        public abstract unsafe bool SetWindowConstraints(AllegroDisplay* display, int min_w, int min_h, int max_w, int max_h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_constraints")]
        public abstract bool SetWindowConstraints(Span<AllegroDisplay> display, int min_w, int min_h, int max_w, int max_h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_window_constraints")]
        public abstract unsafe bool GetWindowConstraints(AllegroDisplay* display, int* min_w, int* min_h, int* max_w, int* max_h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_window_constraints")]
        public abstract bool GetWindowConstraints(Span<AllegroDisplay> display, Span<int> min_w, Span<int> min_h, Span<int> max_w, Span<int> max_h);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_apply_window_constraints")]
        public abstract unsafe void ApplyWindowConstraints(AllegroDisplay* display, bool onoff);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_apply_window_constraints")]
        public abstract void ApplyWindowConstraints(Span<AllegroDisplay> display, bool onoff);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_title")]
        public abstract unsafe void SetWindowTitle(AllegroDisplay* display, byte* title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_title")]
        public abstract void SetWindowTitle(Span<AllegroDisplay> display, Span<byte> title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_display_option")]
        public abstract void SetNewDisplayOption(int option, int value, int importance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_display_option")]
        public abstract unsafe int GetNewDisplayOption(int option, int* importance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_display_option")]
        public abstract int GetNewDisplayOption(int option, Span<int> importance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_reset_new_display_options")]
        public abstract void ResetNewDisplayOptions();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_option")]
        public abstract unsafe void SetDisplayOption(AllegroDisplay* display, int option, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_display_option")]
        public abstract void SetDisplayOption(Span<AllegroDisplay> display, int option, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_option")]
        public abstract unsafe int GetDisplayOption(AllegroDisplay* display, int option);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_option")]
        public abstract int GetDisplayOption(Span<AllegroDisplay> display, int option);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_hold_bitmap_drawing")]
        public abstract void HoldBitmapDrawing(bool hold);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_bitmap_drawing_held")]
        public abstract bool IsBitmapDrawingHeld();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_acknowledge_drawing_halt")]
        public abstract unsafe void AcknowledgeDrawingHalt(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_acknowledge_drawing_halt")]
        public abstract void AcknowledgeDrawingHalt(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_acknowledge_drawing_resume")]
        public abstract unsafe void AcknowledgeDrawingResume(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_acknowledge_drawing_resume")]
        public abstract void AcknowledgeDrawingResume(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_clipboard_text")]
        public abstract unsafe byte* GetClipboardText(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_clipboard_text")]
        public abstract unsafe byte* GetClipboardText(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_clipboard_text")]
        public abstract unsafe bool SetClipboardText(AllegroDisplay* display, byte* text);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_clipboard_text")]
        public abstract bool SetClipboardText(Span<AllegroDisplay> display, Span<byte> text);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_clipboard_has_text")]
        public abstract unsafe bool ClipboardHasText(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_clipboard_has_text")]
        public abstract bool ClipboardHasText(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_config")]
        public abstract unsafe AllegroConfig* CreateConfig();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_section")]
        public abstract unsafe void AddConfigSection(AllegroConfig* config, byte* name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_section")]
        public abstract void AddConfigSection(Span<AllegroConfig> config, Span<byte> name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_config_value")]
        public abstract unsafe void SetConfigValue(AllegroConfig* config, byte* section, byte* key, byte* value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_config_value")]
        public abstract void SetConfigValue(Span<AllegroConfig> config, Span<byte> section, Span<byte> key, Span<byte> value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_comment")]
        public abstract unsafe void AddConfigComment(AllegroConfig* config, byte* section, byte* comment);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_comment")]
        public abstract void AddConfigComment(Span<AllegroConfig> config, Span<byte> section, Span<byte> comment);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_config_value")]
        public abstract unsafe byte* GetConfigValue(AllegroConfig* config, byte* section, byte* key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_config_value")]
        public abstract unsafe byte* GetConfigValue(Span<AllegroConfig> config, Span<byte> section, Span<byte> key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_config_file")]
        public abstract unsafe AllegroConfig* LoadConfigFile(byte* filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_config_file")]
        public abstract unsafe AllegroConfig* LoadConfigFile(Span<byte> filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_config_file_f")]
        public abstract unsafe AllegroConfig* LoadConfigFileF(AllegroFile* filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_config_file_f")]
        public abstract unsafe AllegroConfig* LoadConfigFileF(Span<AllegroFile> filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_config_file")]
        public abstract unsafe bool SaveConfigFile(byte* filename, AllegroConfig* config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_config_file")]
        public abstract bool SaveConfigFile(Span<byte> filename, Span<AllegroConfig> config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_config_file_f")]
        public abstract unsafe bool SaveConfigFileF(AllegroFile* file, AllegroConfig* config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_config_file_f")]
        public abstract bool SaveConfigFileF(Span<AllegroFile> file, Span<AllegroConfig> config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_merge_config_into")]
        public abstract unsafe void MergeConfigInto(AllegroConfig* master, AllegroConfig* add);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_merge_config_into")]
        public abstract void MergeConfigInto(Span<AllegroConfig> master, Span<AllegroConfig> add);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_merge_config")]
        public abstract unsafe AllegroConfig* MergeConfig(AllegroConfig* cfg1, AllegroConfig* cfg2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_merge_config")]
        public abstract unsafe AllegroConfig* MergeConfig(Span<AllegroConfig> cfg1, Span<AllegroConfig> cfg2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_config")]
        public abstract unsafe void DestroyConfig(AllegroConfig* config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_config")]
        public abstract void DestroyConfig(Span<AllegroConfig> config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_section")]
        public abstract unsafe bool RemoveConfigSection(AllegroConfig* config, byte* section);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_section")]
        public abstract bool RemoveConfigSection(Span<AllegroConfig> config, Span<byte> section);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_key")]
        public abstract unsafe bool RemoveConfigKey(AllegroConfig* config, byte* section, byte* key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_key")]
        public abstract bool RemoveConfigKey(Span<AllegroConfig> config, Span<byte> section, Span<byte> key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_section")]
        public abstract unsafe byte* GetFirstConfigSection(AllegroConfig* config, AllegroConfigSection** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_section")]
        public abstract unsafe byte* GetFirstConfigSection(Span<AllegroConfig> config, AllegroConfigSection** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_next_config_section")]
        public abstract unsafe byte* GetNextConfigSection(AllegroConfigSection** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_entry")]
        public abstract unsafe byte* GetFirstConfigEntry(AllegroConfig* config, byte* section, AllegroConfigEntry** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_entry")]
        public abstract unsafe byte* GetFirstConfigEntry(Span<AllegroConfig> config, Span<byte> section, AllegroConfigEntry** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_next_config_entry")]
        public abstract unsafe byte* GetNextConfigEntry(AllegroConfigEntry** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_cpu_count")]
        public abstract int GetCpuCount();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_ram_size")]
        public abstract int GetRamSize();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "_al_trace_prefix")]
        public abstract unsafe bool alTracePrefix(byte* channel, int level, byte* file, int line, byte* function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "_al_trace_prefix")]
        public abstract bool alTracePrefix(Span<byte> channel, int level, Span<byte> file, int line, Span<byte> function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "_al_trace_suffix")]
        public abstract unsafe void alTraceSuffix(byte* msg);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "_al_trace_suffix")]
        public abstract void alTraceSuffix(Span<byte> msg);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_assert_handler")]
        public abstract unsafe void RegisterAssertHandler(void* handler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_assert_handler")]
        public abstract void RegisterAssertHandler<T0>(Span<T0> handler) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_trace_handler")]
        public abstract unsafe void RegisterTraceHandler(void* handler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_trace_handler")]
        public abstract void RegisterTraceHandler<T0>(Span<T0> handler) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_errno")]
        public abstract int GetErrno();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_errno")]
        public abstract void SetErrno(int errnum);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_num_display_modes")]
        public abstract int GetNumDisplayModes();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_mode")]
        public abstract unsafe AllegroDisplayMode* GetDisplayMode(int index, AllegroDisplayMode* mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_display_mode")]
        public abstract unsafe AllegroDisplayMode* GetDisplayMode(int index, Span<AllegroDisplayMode> mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_install_joystick")]
        public abstract bool InstallJoystick();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_uninstall_joystick")]
        public abstract void UninstallJoystick();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_joystick_installed")]
        public abstract bool IsJoystickInstalled();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_reconfigure_joysticks")]
        public abstract bool ReconfigureJoysticks();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_num_joysticks")]
        public abstract int GetNumJoysticks();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick")]
        public abstract unsafe AllegroJoystick* GetJoystick(int joyn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_release_joystick")]
        public abstract unsafe void ReleaseJoystick(AllegroJoystick* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_release_joystick")]
        public abstract void ReleaseJoystick(Span<AllegroJoystick> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_active")]
        public abstract unsafe bool GetJoystickActive(AllegroJoystick* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_active")]
        public abstract bool GetJoystickActive(Span<AllegroJoystick> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_name")]
        public abstract unsafe byte* GetJoystickName(AllegroJoystick* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_name")]
        public abstract unsafe byte* GetJoystickName(Span<AllegroJoystick> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_num_sticks")]
        public abstract unsafe int GetJoystickNumSticks(AllegroJoystick* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_num_sticks")]
        public abstract int GetJoystickNumSticks(Span<AllegroJoystick> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_stick_flags")]
        public abstract unsafe int GetJoystickStickFlags(AllegroJoystick* arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_stick_flags")]
        public abstract int GetJoystickStickFlags(Span<AllegroJoystick> arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_stick_name")]
        public abstract unsafe byte* GetJoystickStickName(AllegroJoystick* arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_stick_name")]
        public abstract unsafe byte* GetJoystickStickName(Span<AllegroJoystick> arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_num_axes")]
        public abstract unsafe int GetJoystickNumAxes(AllegroJoystick* arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_num_axes")]
        public abstract int GetJoystickNumAxes(Span<AllegroJoystick> arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_axis_name")]
        public abstract unsafe byte* GetJoystickAxisName(AllegroJoystick* arg0, int stick, int axis);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_axis_name")]
        public abstract unsafe byte* GetJoystickAxisName(Span<AllegroJoystick> arg0, int stick, int axis);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_num_buttons")]
        public abstract unsafe int GetJoystickNumButtons(AllegroJoystick* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_num_buttons")]
        public abstract int GetJoystickNumButtons(Span<AllegroJoystick> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_button_name")]
        public abstract unsafe byte* GetJoystickButtonName(AllegroJoystick* arg0, int buttonn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_button_name")]
        public abstract unsafe byte* GetJoystickButtonName(Span<AllegroJoystick> arg0, int buttonn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_state")]
        public abstract unsafe void GetJoystickState(AllegroJoystick* arg0, AllegroJoystickState* ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_state")]
        public abstract void GetJoystickState(Span<AllegroJoystick> arg0, Span<AllegroJoystickState> ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_event_source")]
        public abstract unsafe AllegroEventSource* GetJoystickEventSource();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_keyboard_installed")]
        public abstract bool IsKeyboardInstalled();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_install_keyboard")]
        public abstract bool InstallKeyboard();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_uninstall_keyboard")]
        public abstract void UninstallKeyboard();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_keyboard_leds")]
        public abstract bool SetKeyboardLeds(int leds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_keycode_to_name")]
        public abstract unsafe byte* KeycodeToName(int keycode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_keyboard_state")]
        public abstract unsafe void GetKeyboardState(AllegroKeyboardState* ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_keyboard_state")]
        public abstract void GetKeyboardState(Span<AllegroKeyboardState> ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_key_down")]
        public abstract unsafe bool KeyDown(AllegroKeyboardState* arg0, int keycode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_key_down")]
        public abstract bool KeyDown(Span<AllegroKeyboardState> arg0, int keycode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_keyboard_event_source")]
        public abstract unsafe AllegroEventSource* GetKeyboardEventSource();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_mouse_installed")]
        public abstract bool IsMouseInstalled();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_install_mouse")]
        public abstract bool InstallMouse();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_uninstall_mouse")]
        public abstract void UninstallMouse();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_num_buttons")]
        public abstract uint GetMouseNumButtons();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_num_axes")]
        public abstract uint GetMouseNumAxes();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_xy")]
        public abstract unsafe bool SetMouseXy(AllegroDisplay* display, int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_xy")]
        public abstract bool SetMouseXy(Span<AllegroDisplay> display, int x, int y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_z")]
        public abstract bool SetMouseZ(int z);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_w")]
        public abstract bool SetMouseW(int w);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_axis")]
        public abstract bool SetMouseAxis(int axis, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_state")]
        public abstract unsafe void GetMouseState(AllegroMouseState* ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_state")]
        public abstract void GetMouseState(Span<AllegroMouseState> ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_mouse_button_down")]
        public abstract unsafe bool MouseButtonDown(AllegroMouseState* state, int button);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_mouse_button_down")]
        public abstract bool MouseButtonDown(Span<AllegroMouseState> state, int button);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_state_axis")]
        public abstract unsafe int GetMouseStateAxis(AllegroMouseState* state, int axis);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_state_axis")]
        public abstract int GetMouseStateAxis(Span<AllegroMouseState> state, int axis);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_cursor_position")]
        public abstract unsafe bool GetMouseCursorPosition(int* ret_x, int* ret_y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_cursor_position")]
        public abstract bool GetMouseCursorPosition(Span<int> ret_x, Span<int> ret_y);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_grab_mouse")]
        public abstract unsafe bool GrabMouse(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_grab_mouse")]
        public abstract bool GrabMouse(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ungrab_mouse")]
        public abstract bool UngrabMouse();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_wheel_precision")]
        public abstract void SetMouseWheelPrecision(int precision);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_wheel_precision")]
        public abstract int GetMouseWheelPrecision();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_mouse_event_source")]
        public abstract unsafe AllegroEventSource* GetMouseEventSource();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_touch_input_installed")]
        public abstract bool IsTouchInputInstalled();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_install_touch_input")]
        public abstract bool InstallTouchInput();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_uninstall_touch_input")]
        public abstract void UninstallTouchInput();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_touch_input_state")]
        public abstract unsafe void GetTouchInputState(AllegroTouchInputState* ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_touch_input_state")]
        public abstract void GetTouchInputState(Span<AllegroTouchInputState> ret_state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_touch_input_event_source")]
        public abstract unsafe AllegroEventSource* GetTouchInputEventSource();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_memory_interface")]
        public abstract unsafe void SetMemoryInterface(AllegroMemoryInterface* iface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_memory_interface")]
        public abstract void SetMemoryInterface(Span<AllegroMemoryInterface> iface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_malloc_with_context")]
        public abstract unsafe void* MallocWithContext(uint n, int line, byte* file, byte* func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_malloc_with_context")]
        public abstract unsafe void* MallocWithContext(uint n, int line, Span<byte> file, Span<byte> func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_free_with_context")]
        public abstract unsafe void FreeWithContext(void* ptr, int line, byte* file, byte* func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_free_with_context")]
        public abstract void FreeWithContext<T0>(Span<T0> ptr, int line, Span<byte> file, Span<byte> func) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_realloc_with_context")]
        public abstract unsafe void* ReallocWithContext(void* ptr, uint n, int line, byte* file, byte* func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_realloc_with_context")]
        public abstract unsafe void* ReallocWithContext<T0>(Span<T0> ptr, uint n, int line, Span<byte> file, Span<byte> func) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_calloc_with_context")]
        public abstract unsafe void* CallocWithContext(uint count, uint n, int line, byte* file, byte* func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_calloc_with_context")]
        public abstract unsafe void* CallocWithContext(uint count, uint n, int line, Span<byte> file, Span<byte> func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_num_video_adapters")]
        public abstract int GetNumVideoAdapters();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_monitor_info")]
        public abstract unsafe bool GetMonitorInfo(int adapter, AllegroMonitorInfo* info);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_monitor_info")]
        public abstract bool GetMonitorInfo(int adapter, Span<AllegroMonitorInfo> info);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_monitor_dpi")]
        public abstract int GetMonitorDpi(int adapter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_mouse_cursor")]
        public abstract unsafe AllegroMouseCursor* CreateMouseCursor(AllegroBitmap* sprite, int xfocus, int yfocus);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_mouse_cursor")]
        public abstract unsafe AllegroMouseCursor* CreateMouseCursor(Span<AllegroBitmap> sprite, int xfocus, int yfocus);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_mouse_cursor")]
        public abstract unsafe void DestroyMouseCursor(AllegroMouseCursor* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_mouse_cursor")]
        public abstract void DestroyMouseCursor(Span<AllegroMouseCursor> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_cursor")]
        public abstract unsafe bool SetMouseCursor(AllegroDisplay* display, AllegroMouseCursor* cursor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_mouse_cursor")]
        public abstract bool SetMouseCursor(Span<AllegroDisplay> display, Span<AllegroMouseCursor> cursor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_system_mouse_cursor")]
        public abstract unsafe bool SetSystemMouseCursor(AllegroDisplay* display, AllegroSystemMouseCursor cursor_id);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_system_mouse_cursor")]
        public abstract bool SetSystemMouseCursor(Span<AllegroDisplay> display, AllegroSystemMouseCursor cursor_id);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_show_mouse_cursor")]
        public abstract unsafe bool ShowMouseCursor(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_show_mouse_cursor")]
        public abstract bool ShowMouseCursor(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_hide_mouse_cursor")]
        public abstract unsafe bool HideMouseCursor(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_hide_mouse_cursor")]
        public abstract bool HideMouseCursor(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_install_system")]
        public abstract unsafe bool InstallSystem(int version, void* atexit_ptr);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_install_system")]
        public abstract bool InstallSystem<T0>(int version, Span<T0> atexit_ptr) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_uninstall_system")]
        public abstract void UninstallSystem();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_is_system_installed")]
        public abstract bool IsSystemInstalled();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_system_driver")]
        public abstract unsafe AllegroSystem* GetSystemDriver();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_system_config")]
        public abstract unsafe AllegroConfig* GetSystemConfig();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_system_id")]
        public abstract AllegroSystemID GetSystemId();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_standard_path")]
        public abstract unsafe AllegroPath* GetStandardPath(int id);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_exe_name")]
        public abstract unsafe void SetExeName(byte* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_exe_name")]
        public abstract void SetExeName(Span<byte> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_org_name")]
        public abstract unsafe void SetOrgName(byte* org_name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_org_name")]
        public abstract void SetOrgName(Span<byte> org_name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_app_name")]
        public abstract unsafe void SetAppName(byte* app_name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_app_name")]
        public abstract void SetAppName(Span<byte> app_name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_org_name")]
        public abstract unsafe byte* GetOrgName();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_app_name")]
        public abstract unsafe byte* GetAppName();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_inhibit_screensaver")]
        public abstract bool InhibitScreensaver(bool inhibit);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_timer")]
        public abstract unsafe AllegroTimer* CreateTimer(double speed_secs);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_timer")]
        public abstract unsafe void DestroyTimer(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_destroy_timer")]
        public abstract void DestroyTimer(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_start_timer")]
        public abstract unsafe void StartTimer(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_start_timer")]
        public abstract void StartTimer(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_stop_timer")]
        public abstract unsafe void StopTimer(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_stop_timer")]
        public abstract void StopTimer(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_resume_timer")]
        public abstract unsafe void ResumeTimer(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_resume_timer")]
        public abstract void ResumeTimer(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_started")]
        public abstract unsafe bool GetTimerStarted(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_started")]
        public abstract bool GetTimerStarted(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_speed")]
        public abstract unsafe double GetTimerSpeed(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_speed")]
        public abstract double GetTimerSpeed(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_timer_speed")]
        public abstract unsafe void SetTimerSpeed(AllegroTimer* timer, double speed_secs);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_timer_speed")]
        public abstract void SetTimerSpeed(Span<AllegroTimer> timer, double speed_secs);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_count")]
        public abstract unsafe long GetTimerCount(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_count")]
        public abstract long GetTimerCount(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_timer_count")]
        public abstract unsafe void SetTimerCount(AllegroTimer* timer, long count);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_timer_count")]
        public abstract void SetTimerCount(Span<AllegroTimer> timer, long count);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_timer_count")]
        public abstract unsafe void AddTimerCount(AllegroTimer* timer, long diff);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_timer_count")]
        public abstract void AddTimerCount(Span<AllegroTimer> timer, long diff);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_event_source")]
        public abstract unsafe AllegroEventSource* GetTimerEventSource(AllegroTimer* timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_timer_event_source")]
        public abstract unsafe AllegroEventSource* GetTimerEventSource(Span<AllegroTimer> timer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_store_state")]
        public abstract unsafe void StoreState(AllegroState* state, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_store_state")]
        public abstract void StoreState(Span<AllegroState> state, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_restore_state")]
        public abstract unsafe void RestoreState(AllegroState* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_restore_state")]
        public abstract void RestoreState(Span<AllegroState> state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgb")]
        public abstract void UnmapRgb(AllegroColor color, string r, string g, string b);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_unmap_rgba")]
        public abstract void UnmapRgba(AllegroColor color, string r, string g, string b, string a);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new")]
        public abstract unsafe AllegroString* UstrNew(string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_new_from_buffer")]
        public abstract unsafe AllegroString* UstrNewFromBuffer(string s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_newf")]
        public abstract unsafe AllegroString* UstrNewf(string fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr")]
        public abstract unsafe string CstrS(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr")]
        public abstract string CstrS(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_to_buffer")]
        public abstract unsafe void UstrToBuffer(AllegroString* us, string buffer, int size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_to_buffer")]
        public abstract void UstrToBuffer(Span<AllegroString> us, string buffer, int size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr_dup")]
        public abstract unsafe string CstrDupS(AllegroString* us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_cstr_dup")]
        public abstract string CstrDupS(Span<AllegroString> us);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_cstr")]
        public abstract unsafe AllegroString* RefCstr(AllegroString* info, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_cstr")]
        public abstract unsafe AllegroString* RefCstr(Span<AllegroString> info, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_buffer")]
        public abstract unsafe AllegroString* RefBuffer(AllegroString* info, string s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ref_buffer")]
        public abstract unsafe AllegroString* RefBuffer(Span<AllegroString> info, string s, uint size);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert_cstr")]
        public abstract unsafe bool UstrInsertCstr(AllegroString* us, int pos, string us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_insert_cstr")]
        public abstract bool UstrInsertCstr(Span<AllegroString> us, int pos, string us2);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append_cstr")]
        public abstract unsafe bool UstrAppendCstr(AllegroString* us, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_append_cstr")]
        public abstract bool UstrAppendCstr(Span<AllegroString> us, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_appendf")]
        public abstract unsafe bool UstrAppendf(AllegroString* us, string fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_appendf")]
        public abstract bool UstrAppendf(Span<AllegroString> us, string fmt);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_vappendf")]
        public abstract unsafe bool UstrVappendf(AllegroString* us, string fmt, string ap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_vappendf")]
        public abstract bool UstrVappendf(Span<AllegroString> us, string fmt, string ap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign_cstr")]
        public abstract unsafe bool UstrAssignCstr(AllegroString* us1, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_assign_cstr")]
        public abstract bool UstrAssignCstr(Span<AllegroString> us1, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_set_cstr")]
        public abstract unsafe int UstrFindSetCstr(AllegroString* us, int start_pos, string accept);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_set_cstr")]
        public abstract int UstrFindSetCstr(Span<AllegroString> us, int start_pos, string accept);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cset_cstr")]
        public abstract unsafe int UstrFindCsetCstr(AllegroString* us, int start_pos, string reject);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cset_cstr")]
        public abstract int UstrFindCsetCstr(Span<AllegroString> us, int start_pos, string reject);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cstr")]
        public abstract unsafe int UstrFindCstr(AllegroString* haystack, int start_pos, string needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_cstr")]
        public abstract int UstrFindCstr(Span<AllegroString> haystack, int start_pos, string needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_cstr")]
        public abstract unsafe int UstrRfindCstr(AllegroString* haystack, int start_pos, string needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_rfind_cstr")]
        public abstract int UstrRfindCstr(Span<AllegroString> haystack, int start_pos, string needle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_replace_cstr")]
        public abstract unsafe bool UstrFindReplaceCstr(AllegroString* us, int start_pos, string find, string replace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_find_replace_cstr")]
        public abstract bool UstrFindReplaceCstr(Span<AllegroString> us, int start_pos, string find, string replace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_prefix_cstr")]
        public abstract unsafe bool UstrHasPrefixCstr(AllegroString* u, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_prefix_cstr")]
        public abstract bool UstrHasPrefixCstr(Span<AllegroString> u, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_suffix_cstr")]
        public abstract unsafe bool UstrHasSuffixCstr(AllegroString* us1, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ustr_has_suffix_cstr")]
        public abstract bool UstrHasSuffixCstr(Span<AllegroString> us1, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_utf8_encode")]
        public abstract uint Utf8Encode(string s, int c);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_path")]
        public abstract unsafe AllegroPath* CreatePath(string str);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_create_path_for_directory")]
        public abstract unsafe AllegroPath* CreatePathForDirectory(string str);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_component")]
        public abstract unsafe string GetPathComponentS(AllegroPath* path, int i);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_component")]
        public abstract string GetPathComponentS(Span<AllegroPath> path, int i);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_replace_path_component")]
        public abstract unsafe void ReplacePathComponent(AllegroPath* path, int i, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_replace_path_component")]
        public abstract void ReplacePathComponent(Span<AllegroPath> path, int i, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_insert_path_component")]
        public abstract unsafe void InsertPathComponent(AllegroPath* path, int i, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_insert_path_component")]
        public abstract void InsertPathComponent(Span<AllegroPath> path, int i, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_tail")]
        public abstract unsafe string GetPathTailS(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_tail")]
        public abstract string GetPathTailS(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_append_path_component")]
        public abstract unsafe void AppendPathComponent(AllegroPath* path, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_append_path_component")]
        public abstract void AppendPathComponent(Span<AllegroPath> path, string s);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_path_cstr")]
        public abstract unsafe string PathCstrS(AllegroPath* path, byte delim);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_path_cstr")]
        public abstract string PathCstrS(Span<AllegroPath> path, byte delim);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_drive")]
        public abstract unsafe void SetPathDrive(AllegroPath* path, string drive);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_drive")]
        public abstract void SetPathDrive(Span<AllegroPath> path, string drive);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_drive")]
        public abstract unsafe string GetPathDriveS(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_drive")]
        public abstract string GetPathDriveS(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_filename")]
        public abstract unsafe void SetPathFilename(AllegroPath* path, string filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_filename")]
        public abstract void SetPathFilename(Span<AllegroPath> path, string filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_filename")]
        public abstract unsafe string GetPathFilenameS(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_filename")]
        public abstract string GetPathFilenameS(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_extension")]
        public abstract unsafe string GetPathExtensionS(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_extension")]
        public abstract string GetPathExtensionS(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_extension")]
        public abstract unsafe bool SetPathExtension(AllegroPath* path, string extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_path_extension")]
        public abstract bool SetPathExtension(Span<AllegroPath> path, string extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_basename")]
        public abstract unsafe string GetPathBasenameS(AllegroPath* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_path_basename")]
        public abstract string GetPathBasenameS(Span<AllegroPath> path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen")]
        public abstract unsafe AllegroFile* Fopen(string path, string mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_interface")]
        public abstract unsafe AllegroFile* FopenInterface(AllegroFileInterface* vt, string path, string mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_interface")]
        public abstract unsafe AllegroFile* FopenInterface(Span<AllegroFileInterface> vt, string path, string mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ferrmsg")]
        public abstract unsafe string FerrmsgS(AllegroFile* f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_ferrmsg")]
        public abstract string FerrmsgS(Span<AllegroFile> f);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fgets")]
        public abstract unsafe string Fgets(AllegroFile* f, string p, uint max);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fgets")]
        public abstract string Fgets(Span<AllegroFile> f, string p, uint max);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fputs")]
        public abstract unsafe int Fputs(AllegroFile* f, string p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fputs")]
        public abstract int Fputs(Span<AllegroFile> f, string p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fprintf")]
        public abstract unsafe int Fprintf(AllegroFile* f, string format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fprintf")]
        public abstract int Fprintf(Span<AllegroFile> f, string format);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_vfprintf")]
        public abstract unsafe int Vfprintf(AllegroFile* f, string format, string args);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_vfprintf")]
        public abstract int Vfprintf(Span<AllegroFile> f, string format, string args);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_fd")]
        public abstract unsafe AllegroFile* FopenFd(int fd, string mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_make_temp_file")]
        public abstract unsafe AllegroFile* MakeTempFile(string tmpl, AllegroPath** ret_path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_slice")]
        public abstract unsafe AllegroFile* FopenSlice(AllegroFile* fp, uint initial_size, string mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_fopen_slice")]
        public abstract unsafe AllegroFile* FopenSlice(Span<AllegroFile> fp, uint initial_size, string mode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader")]
        public abstract unsafe bool RegisterBitmapLoader(string ext, void* loader);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader")]
        public abstract bool RegisterBitmapLoader<T0>(string ext, Span<T0> loader) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver")]
        public abstract unsafe bool RegisterBitmapSaver(string ext, void* saver);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver")]
        public abstract bool RegisterBitmapSaver<T0>(string ext, Span<T0> saver) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader_f")]
        public abstract unsafe bool RegisterBitmapLoaderF(string ext, void* fs_loader);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_loader_f")]
        public abstract bool RegisterBitmapLoaderF<T0>(string ext, Span<T0> fs_loader) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver_f")]
        public abstract unsafe bool RegisterBitmapSaverF(string ext, void* fs_saver);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_saver_f")]
        public abstract bool RegisterBitmapSaverF<T0>(string ext, Span<T0> fs_saver) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_identifier")]
        public abstract unsafe bool RegisterBitmapIdentifier(string ext, void* identifier);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_register_bitmap_identifier")]
        public abstract bool RegisterBitmapIdentifier<T0>(string ext, Span<T0> identifier) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap")]
        public abstract unsafe AllegroBitmap* LoadBitmap(string filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlags(string filename, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapF(AllegroFile* fp, string ident);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapF(Span<AllegroFile> fp, string ident);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlagsF(AllegroFile* fp, string ident, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_bitmap_flags_f")]
        public abstract unsafe AllegroBitmap* LoadBitmapFlagsF(Span<AllegroFile> fp, string ident, int flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap")]
        public abstract unsafe bool SaveBitmap(string filename, AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap")]
        public abstract bool SaveBitmap(string filename, Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap_f")]
        public abstract unsafe bool SaveBitmapF(AllegroFile* fp, string ident, AllegroBitmap* bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_bitmap_f")]
        public abstract bool SaveBitmapF(Span<AllegroFile> fp, string ident, Span<AllegroBitmap> bitmap);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap_f")]
        public abstract unsafe string IdentifyBitmapFS(AllegroFile* fp);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap_f")]
        public abstract string IdentifyBitmapFS(Span<AllegroFile> fp);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_identify_bitmap")]
        public abstract string IdentifyBitmap(string filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_new_window_title")]
        public abstract void SetNewWindowTitle(string title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_new_window_title")]
        public abstract string GetNewWindowTitleS();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_title")]
        public abstract unsafe void SetWindowTitle(AllegroDisplay* display, string title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_window_title")]
        public abstract void SetWindowTitle(Span<AllegroDisplay> display, string title);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_clipboard_text")]
        public abstract unsafe string GetClipboardTextS(AllegroDisplay* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_clipboard_text")]
        public abstract string GetClipboardTextS(Span<AllegroDisplay> display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_clipboard_text")]
        public abstract unsafe bool SetClipboardText(AllegroDisplay* display, string text);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_clipboard_text")]
        public abstract bool SetClipboardText(Span<AllegroDisplay> display, string text);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_section")]
        public abstract unsafe void AddConfigSection(AllegroConfig* config, string name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_section")]
        public abstract void AddConfigSection(Span<AllegroConfig> config, string name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_config_value")]
        public abstract unsafe void SetConfigValue(AllegroConfig* config, string section, string key, string value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_config_value")]
        public abstract void SetConfigValue(Span<AllegroConfig> config, string section, string key, string value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_comment")]
        public abstract unsafe void AddConfigComment(AllegroConfig* config, string section, string comment);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_add_config_comment")]
        public abstract void AddConfigComment(Span<AllegroConfig> config, string section, string comment);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_config_value")]
        public abstract unsafe string GetConfigValue(AllegroConfig* config, string section, string key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_config_value")]
        public abstract string GetConfigValue(Span<AllegroConfig> config, string section, string key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_load_config_file")]
        public abstract unsafe AllegroConfig* LoadConfigFile(string filename);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_config_file")]
        public abstract unsafe bool SaveConfigFile(string filename, AllegroConfig* config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_save_config_file")]
        public abstract bool SaveConfigFile(string filename, Span<AllegroConfig> config);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_section")]
        public abstract unsafe bool RemoveConfigSection(AllegroConfig* config, string section);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_section")]
        public abstract bool RemoveConfigSection(Span<AllegroConfig> config, string section);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_key")]
        public abstract unsafe bool RemoveConfigKey(AllegroConfig* config, string section, string key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_remove_config_key")]
        public abstract bool RemoveConfigKey(Span<AllegroConfig> config, string section, string key);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_section")]
        public abstract unsafe string GetFirstConfigSectionS(AllegroConfig* config, AllegroConfigSection** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_section")]
        public abstract unsafe string GetFirstConfigSectionS(Span<AllegroConfig> config, AllegroConfigSection** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_next_config_section")]
        public abstract unsafe string GetNextConfigSectionS(AllegroConfigSection** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_entry")]
        public abstract unsafe string GetFirstConfigEntry(AllegroConfig* config, string section, AllegroConfigEntry** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_first_config_entry")]
        public abstract unsafe string GetFirstConfigEntry(Span<AllegroConfig> config, string section, AllegroConfigEntry** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_next_config_entry")]
        public abstract unsafe string GetNextConfigEntryS(AllegroConfigEntry** iterator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "_al_trace_prefix")]
        public abstract bool alTracePrefix(string channel, int level, string file, int line, string function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "_al_trace_suffix")]
        public abstract void alTraceSuffix(string msg);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_name")]
        public abstract unsafe string GetJoystickNameS(AllegroJoystick* arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_name")]
        public abstract string GetJoystickNameS(Span<AllegroJoystick> arg0);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_stick_name")]
        public abstract unsafe string GetJoystickStickNameS(AllegroJoystick* arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_stick_name")]
        public abstract string GetJoystickStickNameS(Span<AllegroJoystick> arg0, int stick);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_axis_name")]
        public abstract unsafe string GetJoystickAxisNameS(AllegroJoystick* arg0, int stick, int axis);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_axis_name")]
        public abstract string GetJoystickAxisNameS(Span<AllegroJoystick> arg0, int stick, int axis);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_button_name")]
        public abstract unsafe string GetJoystickButtonNameS(AllegroJoystick* arg0, int buttonn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_joystick_button_name")]
        public abstract string GetJoystickButtonNameS(Span<AllegroJoystick> arg0, int buttonn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_keycode_to_name")]
        public abstract string KeycodeToNameS(int keycode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_malloc_with_context")]
        public abstract unsafe void* MallocWithContext(uint n, int line, string file, string func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_free_with_context")]
        public abstract unsafe void FreeWithContext(void* ptr, int line, string file, string func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_free_with_context")]
        public abstract void FreeWithContext<T0>(Span<T0> ptr, int line, string file, string func) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_realloc_with_context")]
        public abstract unsafe void* ReallocWithContext(void* ptr, uint n, int line, string file, string func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_realloc_with_context")]
        public abstract unsafe void* ReallocWithContext<T0>(Span<T0> ptr, uint n, int line, string file, string func) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_calloc_with_context")]
        public abstract unsafe void* CallocWithContext(uint count, uint n, int line, string file, string func);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_exe_name")]
        public abstract void SetExeName(string path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_org_name")]
        public abstract void SetOrgName(string org_name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_set_app_name")]
        public abstract void SetAppName(string app_name);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_org_name")]
        public abstract string GetOrgNameS();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "al_get_app_name")]
        public abstract string GetAppNameS();

        /// <summary>To be added.</summary>
        public unsafe int RunMain(int argc, string[] argvSa, void* arg2)
        {
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.MarshalStringArrayToPtr(argvSa);
            var ret = RunMain(argc, argv, arg2);
            SilkMarshal.CopyPtrToStringArray((IntPtr) argv, argvSa);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe int RunMain<T0>(int argc, string[] argvSa, Span<T0> arg2) where T0 : unmanaged
        {
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.MarshalStringArrayToPtr(argvSa);
            var ret = RunMain(argc, argv, arg2);
            SilkMarshal.CopyPtrToStringArray((IntPtr) argv, argvSa);
            return ret;
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new AllegroLibraryNameContainer();

        public Allegro(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

