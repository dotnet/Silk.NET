using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
#if __ANDROID__
    [PInvokeOverride(1, "libSDL2.so")]
#endif
    [PInvokeOverride(0, "__Internal")]
    public partial class Sdl
    {
        public const uint InitTimer = 0x00000001;
        public const uint InitAudio = 0x00000010;
        public const uint InitVideo = 0x00000020;
        public const uint InitJoystick = 0x00000200;
        public const uint InitHaptic = 0x00001000;
        public const uint InitGamecontroller = 0x00002000;
        public const uint InitEvents = 0x00004000;
        public const uint InitSensor = 0x00008000;
        public const uint InitNoparachute = 0x00100000;

        public const uint InitEverything = InitTimer | InitAudio | InitVideo |
                                           InitEvents | InitJoystick | InitHaptic |
                                           InitGamecontroller | InitSensor;

        public const string HintFramebufferAcceleration =
            "SDL_FRAMEBUFFER_ACCELERATION";

        public const string HintRenderDriver =
            "SDL_RENDER_DRIVER";

        public const string HintRenderOpenglShaders =
            "SDL_RENDER_OPENGL_SHADERS";

        public const string HintRenderDirect3DThreadsafe =
            "SDL_RENDER_DIRECT3D_THREADSAFE";

        public const string HintRenderVsync =
            "SDL_RENDER_VSYNC";

        public const string HintVideoX11Xvidmode =
            "SDL_VIDEO_X11_XVIDMODE";

        public const string HintVideoX11Xinerama =
            "SDL_VIDEO_X11_XINERAMA";

        public const string HintVideoX11Xrandr =
            "SDL_VIDEO_X11_XRANDR";

        public const string HintGrabKeyboard =
            "SDL_GRAB_KEYBOARD";

        public const string HintVideoMinimizeOnFocusLoss =
            "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS";

        public const string HintIdleTimerDisabled =
            "SDL_IOS_IDLE_TIMER_DISABLED";

        public const string HintOrientations =
            "SDL_IOS_ORIENTATIONS";

        public const string HintXinputEnabled =
            "SDL_XINPUT_ENABLED";

        public const string HintGamecontrollerconfig =
            "SDL_GAMECONTROLLERCONFIG";

        public const string HintJoystickAllowBackgroundEvents =
            "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS";

        public const string HintAllowTopmost =
            "SDL_ALLOW_TOPMOST";

        public const string HintTimerResolution =
            "SDL_TIMER_RESOLUTION";

        public const string HintRenderScaleQuality =
            "SDL_RENDER_SCALE_QUALITY";

        /// <remarks>Only available in SDL 2.0.1 or higher.</remarks>
        public const string HintVideoHighdpiDisabled =
            "SDL_VIDEO_HIGHDPI_DISABLED";

        /// <remarks>Only available in SDL 2.0.2 or higher.</remarks>
        public const string HintCtrlClickEmulateRightClick =
            "SDL_CTRL_CLICK_EMULATE_RIGHT_CLICK";

        public const string HintVideoWinD3Dcompiler =
            "SDL_VIDEO_WIN_D3DCOMPILER";

        public const string HintMouseRelativeModeWarp =
            "SDL_MOUSE_RELATIVE_MODE_WARP";

        public const string HintVideoWindowSharePixelFormat =
            "SDL_VIDEO_WINDOW_SHARE_PIXEL_FORMAT";

        public const string HintVideoAllowScreensaver =
            "SDL_VIDEO_ALLOW_SCREENSAVER";

        public const string HintAccelerometerAsJoystick =
            "SDL_ACCELEROMETER_AS_JOYSTICK";

        public const string HintVideoMacFullscreenSpaces =
            "SDL_VIDEO_MAC_FULLSCREEN_SPACES";

        /// <remarks>Only available in SDL 2.0.3 or higher.</remarks>
        public const string HintWinrtPrivacyPolicyUrl =
            "SDL_WINRT_PRIVACY_POLICY_URL";

        public const string HintWinrtPrivacyPolicyLabel =
            "SDL_WINRT_PRIVACY_POLICY_LABEL";

        public const string HintWinrtHandleBackButton =
            "SDL_WINRT_HANDLE_BACK_BUTTON";

        /// <remarks>Only available in SDL 2.0.4 or higher.</remarks>
        public const string HintNoSignalHandlers =
            "SDL_NO_SIGNAL_HANDLERS";

        public const string HintImeInternalEditing =
            "SDL_IME_INTERNAL_EDITING";

        public const string HintAndroidSeparateMouseAndTouch =
            "SDL_ANDROID_SEPARATE_MOUSE_AND_TOUCH";

        public const string HintEmscriptenKeyboardElement =
            "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT";

        public const string HintThreadStackSize =
            "SDL_THREAD_STACK_SIZE";

        public const string HintWindowFrameUsableWhileCursorHidden =
            "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN";

        public const string HintWindowsEnableMessageloop =
            "SDL_WINDOWS_ENABLE_MESSAGELOOP";

        public const string HintWindowsNoCloseOnAltF4 =
            "SDL_WINDOWS_NO_CLOSE_ON_ALT_F4";

        public const string HintXinputUseOldJoystickMapping =
            "SDL_XINPUT_USE_OLD_JOYSTICK_MAPPING";

        public const string HintMacBackgroundApp =
            "SDL_MAC_BACKGROUND_APP";

        public const string HintVideoX11NetWmPing =
            "SDL_VIDEO_X11_NET_WM_PING";

        public const string HintAndroidApkExpansionMainFileVersion =
            "SDL_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION";

        public const string HintAndroidApkExpansionPatchFileVersion =
            "SDL_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION";

        /// <remarks>Only available in 2.0.5 or higher.</remarks>
        public const string HintMouseFocusClickthrough =
            "SDL_MOUSE_FOCUS_CLICKTHROUGH";

        public const string HintBmpSaveLegacyFormat =
            "SDL_BMP_SAVE_LEGACY_FORMAT";

        public const string HintWindowsDisableThreadNaming =
            "SDL_WINDOWS_DISABLE_THREAD_NAMING";

        public const string HintAppleTvRemoteAllowRotation =
            "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION";

        /// <remarks>Only available in 2.0.6 or higher.</remarks>
        public const string HintAudioResamplingMode =
            "SDL_AUDIO_RESAMPLING_MODE";

        public const string HintRenderLogicalSizeMode =
            "SDL_RENDER_LOGICAL_SIZE_MODE";

        public const string HintMouseNormalSpeedScale =
            "SDL_MOUSE_NORMAL_SPEED_SCALE";

        public const string HintMouseRelativeSpeedScale =
            "SDL_MOUSE_RELATIVE_SPEED_SCALE";

        public const string HintTouchMouseEvents =
            "SDL_TOUCH_MOUSE_EVENTS";

        public const string HintWindowsIntresourceIcon =
            "SDL_WINDOWS_INTRESOURCE_ICON";

        public const string HintWindowsIntresourceIconSmall =
            "SDL_WINDOWS_INTRESOURCE_ICON_SMALL";

        /// <remarks>Only available in 2.0.8 or higher.</remarks>
        public const string HintIOSHideHomeIndicator =
            "SDL_IOS_HIDE_HOME_INDICATOR";

        public const string HintTvRemoteAsJoystick =
            "SDL_TV_REMOTE_AS_JOYSTICK";

        /// <remarks>Only available in 2.0.9 or higher.</remarks>
        public const string HintMouseDoubleClickTime =
            "SDL_MOUSE_DOUBLE_CLICK_TIME";

        public const string HintMouseDoubleClickRadius =
            "SDL_MOUSE_DOUBLE_CLICK_RADIUS";

        public const string HintJoystickHidapi =
            "SDL_JOYSTICK_HIDAPI";

        public const string HintJoystickHidapiPs4 =
            "SDL_JOYSTICK_HIDAPI_PS4";

        public const string HintJoystickHidapiPs4Rumble =
            "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE";

        public const string HintJoystickHidapiSteam =
            "SDL_JOYSTICK_HIDAPI_STEAM";

        public const string HintJoystickHidapiSwitch =
            "SDL_JOYSTICK_HIDAPI_SWITCH";

        public const string HintJoystickHidapiXbox =
            "SDL_JOYSTICK_HIDAPI_XBOX";

        public const string HintEnableSteamControllers =
            "SDL_ENABLE_STEAM_CONTROLLERS";

        public const string HintAndroidTrapBackButton =
            "SDL_ANDROID_TRAP_BACK_BUTTON";

        /// <remarks>Only available in 2.0.10 or higher.</remarks>
        public const string HintMouseTouchEvents =
            "SDL_MOUSE_TOUCH_EVENTS";

        public const string HintGamecontrollerconfigFile =
            "SDL_GAMECONTROLLERCONFIG_FILE";

        public const string HintAndroidBlockOnPause =
            "SDL_ANDROID_BLOCK_ON_PAUSE";

        public const string HintRenderBatching =
            "SDL_RENDER_BATCHING";

        public const string HintEventLogging =
            "SDL_EVENT_LOGGING";

        public const string HintWaveRiffChunkSize =
            "SDL_WAVE_RIFF_CHUNK_SIZE";

        public const string HintWaveTruncation =
            "SDL_WAVE_TRUNCATION";

        public const string HintWaveFactChunk =
            "SDL_WAVE_FACT_CHUNK";

        /// <remarks>Only available in 2.0.11 or higher.</remarks>
        public const string HintVidoX11WindowVisualid =
            "SDL_VIDEO_X11_WINDOW_VISUALID";

        public const string HintGamecontrollerUseButtonLabels =
            "SDL_GAMECONTROLLER_USE_BUTTON_LABELS";

        public const string HintVideoExternalContext =
            "SDL_VIDEO_EXTERNAL_CONTEXT";

        public const string HintJoystickHidapiGamecube =
            "SDL_JOYSTICK_HIDAPI_GAMECUBE";

        public const string HintDisplayUsableBounds =
            "SDL_DISPLAY_USABLE_BOUNDS";

        public const string HintVideoX11ForceEGL =
            "SDL_VIDEO_X11_FORCE_EGL";

        public const string HintGamecontrollertype =
            "SDL_GAMECONTROLLERTYPE";

        public const int MajorVersion = 2;
        public const int MinorVersion = 0;
        public const int Patchlevel = 12;

        public static readonly int Compiledversion = Versionnum
        (
            MajorVersion,
            MinorVersion,
            Patchlevel
        );

        public const int WindowposUndefinedMask = 0x1FFF0000;
        public const int WindowposCenteredMask = 0x2FFF0000;
        public const int WindowposUndefined = 0x1FFF0000;
        public const int WindowposCentered = 0x2FFF0000;

        public static int Versionnum(int x, int y, int z)
        {
            return x * 1000 + y * 100 + z;
        }

        public static int WindowposUndefinedDisplay(int x)
        {
            return WindowposUndefinedMask | x;
        }

        public static bool WindowposIsUndefined(int x)
        {
            return (x & 0xFFFF0000) == WindowposUndefinedMask;
        }

        public static int WindowposCenteredDisplay(int x)
        {
            return WindowposCenteredMask | x;
        }

        public static bool WindowposIsCentered(int x)
        {
            return (x & 0xFFFF0000) == WindowposCenteredMask;
        }

        public static uint DefinePixelfourcc(byte a, byte b, byte c, byte d)
        {
            return Fourcc(a, b, c, d);
        }

        public static uint Fourcc(byte a, byte b, byte c, byte d)
        {
            return (uint) (a | (b << 8) | (c << 16) | (d << 24));
        }

        public static uint DefinePixelformat
        (
            PixelType type,
            uint order,
            PackedLayout layout,
            byte bits,
            byte bytes
        )
        {
            return (uint) (
                (1 << 28) |
                ((byte) type << 24) |
                ((byte) order << 20) |
                ((byte) layout << 16) |
                (bits << 8) |
                bytes
            );
        }

        public static byte Pixelflag(uint x)
        {
            return (byte) ((x >> 28) & 0x0F);
        }

        public static byte Pixeltype(uint x)
        {
            return (byte) ((x >> 24) & 0x0F);
        }

        public static byte Pixelorder(uint x)
        {
            return (byte) ((x >> 20) & 0x0F);
        }

        public static byte Pixellayout(uint x)
        {
            return (byte) ((x >> 16) & 0x0F);
        }

        public static byte Bitsperpixel(uint x)
        {
            return (byte) ((x >> 8) & 0xFF);
        }

        public static byte Bytesperpixel(uint x)
        {
            if (IspixelformatFourcc(x))
            {
                if (x == PixelformatYuy2 ||
                    x == PixelformatUyvy ||
                    x == PixelformatYvyu)
                {
                    return 2;
                }

                return 1;
            }

            return (byte) (x & 0xFF);
        }

        public static bool IspixelformatIndexed(uint format)
        {
            if (IspixelformatFourcc(format))
            {
                return false;
            }

            PixelType pType =
                (PixelType) Pixeltype(format);
            return pType == PixelType.PixeltypeIndex1 ||
                   pType == PixelType.PixeltypeIndex4 ||
                   pType == PixelType.PixeltypeIndex8;
        }

        public static bool IspixelformatPacked(uint format)
        {
            if (IspixelformatFourcc(format))
            {
                return false;
            }

            PixelType pType =
                (PixelType) Pixeltype(format);
            return pType == PixelType.PixeltypePacked8 ||
                   pType == PixelType.PixeltypePacked16 ||
                   pType == PixelType.PixeltypePacked32;
        }

        public static bool IspixelformatArray(uint format)
        {
            if (IspixelformatFourcc(format))
            {
                return false;
            }

            PixelType pType =
                (PixelType) Pixeltype(format);
            return pType == PixelType.PixeltypeArrayu8 ||
                   pType == PixelType.PixeltypeArrayu16 ||
                   pType == PixelType.PixeltypeArrayu32 ||
                   pType == PixelType.PixeltypeArrayf16 ||
                   pType == PixelType.PixeltypeArrayf32;
        }

        public static bool IspixelformatAlpha(uint format)
        {
            if (IspixelformatPacked(format))
            {
                PackedOrder pOrder =
                    (PackedOrder) Pixelorder(format);
                return pOrder == PackedOrder.PackedorderArgb ||
                       pOrder == PackedOrder.PackedorderRgba ||
                       pOrder == PackedOrder.PackedorderAbgr ||
                       pOrder == PackedOrder.PackedorderBgra;
            }
            else if (IspixelformatArray(format))
            {
                ArrayOrder aOrder =
                    (ArrayOrder) Pixelorder(format);
                return aOrder == ArrayOrder.ArrayorderArgb ||
                       aOrder == ArrayOrder.ArrayorderRgba ||
                       aOrder == ArrayOrder.ArrayorderAbgr ||
                       aOrder == ArrayOrder.ArrayorderBgra;
            }

            return false;
        }

        public static bool IspixelformatFourcc(uint format)
        {
            return format == 0 && Pixelflag(format) != 1;
        }

        public static readonly uint PixelformatUnknown = 0;

        public static readonly uint PixelformatIndex1Lsb =
            DefinePixelformat
            (
                PixelType.PixeltypeIndex1,
                (uint) BitmapOrder.Bitmaporder4321,
                0,
                1, 0
            );

        public static readonly uint PixelformatIndex1Msb =
            DefinePixelformat
            (
                PixelType.PixeltypeIndex1,
                (uint) BitmapOrder.Bitmaporder1234,
                0,
                1, 0
            );

        public static readonly uint PixelformatIndex4Lsb =
            DefinePixelformat
            (
                PixelType.PixeltypeIndex4,
                (uint) BitmapOrder.Bitmaporder4321,
                0,
                4, 0
            );

        public static readonly uint PixelformatIndex4Msb =
            DefinePixelformat
            (
                PixelType.PixeltypeIndex4,
                (uint) BitmapOrder.Bitmaporder1234,
                0,
                4, 0
            );

        public static readonly uint PixelformatIndex8 =
            DefinePixelformat
            (
                PixelType.PixeltypeIndex8,
                0,
                0,
                8, 1
            );

        public static readonly uint PixelformatRgb332 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked8,
                (uint) PackedOrder.PackedorderXrgb,
                PackedLayout.Packedlayout332,
                8, 1
            );

        public static readonly uint PixelformatRgb444 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderXrgb,
                PackedLayout.Packedlayout4444,
                12, 2
            );

        public static readonly uint PixelformatBgr444 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderXbgr,
                PackedLayout.Packedlayout4444,
                12, 2
            );

        public static readonly uint PixelformatRgb555 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderXrgb,
                PackedLayout.Packedlayout1555,
                15, 2
            );

        public static readonly uint PixelformatBgr555 =
            DefinePixelformat
            (
                PixelType.PixeltypeIndex1,
                (uint) BitmapOrder.Bitmaporder4321,
                PackedLayout.Packedlayout1555,
                15, 2
            );

        public static readonly uint PixelformatArgb4444 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderArgb,
                PackedLayout.Packedlayout4444,
                16, 2
            );

        public static readonly uint PixelformatRgba4444 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderRgba,
                PackedLayout.Packedlayout4444,
                16, 2
            );

        public static readonly uint PixelformatAbgr4444 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderAbgr,
                PackedLayout.Packedlayout4444,
                16, 2
            );

        public static readonly uint PixelformatBgra4444 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderBgra,
                PackedLayout.Packedlayout4444,
                16, 2
            );

        public static readonly uint PixelformatArgb1555 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderArgb,
                PackedLayout.Packedlayout1555,
                16, 2
            );

        public static readonly uint PixelformatRgba5551 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderRgba,
                PackedLayout.Packedlayout5551,
                16, 2
            );

        public static readonly uint PixelformatAbgr1555 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderAbgr,
                PackedLayout.Packedlayout1555,
                16, 2
            );

        public static readonly uint PixelformatBgra5551 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderBgra,
                PackedLayout.Packedlayout5551,
                16, 2
            );

        public static readonly uint PixelformatRgb565 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderXrgb,
                PackedLayout.Packedlayout565,
                16, 2
            );

        public static readonly uint PixelformatBgr565 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked16,
                (uint) PackedOrder.PackedorderXbgr,
                PackedLayout.Packedlayout565,
                16, 2
            );

        public static readonly uint PixelformatRgb24 =
            DefinePixelformat
            (
                PixelType.PixeltypeArrayu8,
                (uint) ArrayOrder.ArrayorderRgb,
                0,
                24, 3
            );

        public static readonly uint PixelformatBgr24 =
            DefinePixelformat
            (
                PixelType.PixeltypeArrayu8,
                (uint) ArrayOrder.ArrayorderBgr,
                0,
                24, 3
            );

        public static readonly uint PixelformatRgb888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderXrgb,
                PackedLayout.Packedlayout8888,
                24, 4
            );

        public static readonly uint PixelformatRgbx8888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderRgbx,
                PackedLayout.Packedlayout8888,
                24, 4
            );

        public static readonly uint PixelformatBgr888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderXbgr,
                PackedLayout.Packedlayout8888,
                24, 4
            );

        public static readonly uint PixelformatBgrx8888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderBgrx,
                PackedLayout.Packedlayout8888,
                24, 4
            );

        public static readonly uint PixelformatArgb8888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderArgb,
                PackedLayout.Packedlayout8888,
                32, 4
            );

        public static readonly uint PixelformatRgba8888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderRgba,
                PackedLayout.Packedlayout8888,
                32, 4
            );

        public static readonly uint PixelformatAbgr8888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderAbgr,
                PackedLayout.Packedlayout8888,
                32, 4
            );

        public static readonly uint PixelformatBgra8888 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderBgra,
                PackedLayout.Packedlayout8888,
                32, 4
            );

        public static readonly uint PixelformatArgb2101010 =
            DefinePixelformat
            (
                PixelType.PixeltypePacked32,
                (uint) PackedOrder.PackedorderArgb,
                PackedLayout.Packedlayout2101010,
                32, 4
            );

        public static readonly uint PixelformatYv12 =
            DefinePixelfourcc
            (
                (byte) 'Y', (byte) 'V', (byte) '1', (byte) '2'
            );

        public static readonly uint PixelformatIyuv =
            DefinePixelfourcc
            (
                (byte) 'I', (byte) 'Y', (byte) 'U', (byte) 'V'
            );

        public static readonly uint PixelformatYuy2 =
            DefinePixelfourcc
            (
                (byte) 'Y', (byte) 'U', (byte) 'Y', (byte) '2'
            );

        public static readonly uint PixelformatUyvy =
            DefinePixelfourcc
            (
                (byte) 'U', (byte) 'Y', (byte) 'V', (byte) 'Y'
            );

        public static readonly uint PixelformatYvyu =
            DefinePixelfourcc
            (
                (byte) 'Y', (byte) 'V', (byte) 'Y', (byte) 'U'
            );

        /* General keyboard/mouse state definitions. */
        public const byte Pressed = 1;
        public const byte Released = 0;

        /* Default size is according to SDL2 default. */
        public const int TexteditingeventTextSize = 32;
        public const int TextinputeventTextSize = 32;

        public const byte HatCentered = 0x00;
        public const byte HatUp = 0x01;
        public const byte HatRight = 0x02;
        public const byte HatDown = 0x04;
        public const byte HatLeft = 0x08;
        public const byte HatRightup = HatRight | HatUp;
        public const byte HatRightdown = HatRight | HatDown;
        public const byte HatLeftup = HatLeft | HatUp;
        public const byte HatLeftdown = HatLeft | HatDown;
        public const ushort HapticConstant = 1 << 0;
        public const ushort HapticSine = 1 << 1;
        public const ushort HapticLeftright = 1 << 2;
        public const ushort HapticTriangle = 1 << 3;
        public const ushort HapticSawtoothup = 1 << 4;
        public const ushort HapticSawtoothdown = 1 << 5;
        public const ushort HapticSpring = 1 << 7;
        public const ushort HapticDamper = 1 << 8;
        public const ushort HapticInertia = 1 << 9;
        public const ushort HapticFriction = 1 << 10;
        public const ushort HapticCustom = 1 << 11;
        public const ushort HapticGain = 1 << 12;
        public const ushort HapticAutocenter = 1 << 13;

        public const ushort HapticStatus = 1 << 14;
        //public const ushort HapticPause =		(1 << 15);

        /* HapticDirection type */
        public const byte HapticPolar = 0;
        public const byte HapticCartesian = 1;
        public const byte HapticSpherical = 2;

        /* HapticRunEffect */
        public const uint HapticInfinity = 4294967295U;
        public const ushort AudioMaskBitsize = 0xFF;
        public const ushort AudioMaskDatatype = 1 << 8;
        public const ushort AudioMaskEndian = 1 << 12;
        public const ushort AudioMaskSigned = 1 << 15;

        public static ushort AudioBitsize(ushort x)
        {
            return (ushort) (x & AudioMaskBitsize);
        }

        public static bool AudioIsfloat(ushort x)
        {
            return (x & AudioMaskDatatype) != 0;
        }

        public static bool AudioIsbigendian(ushort x)
        {
            return (x & AudioMaskEndian) != 0;
        }

        public static bool AudioIssigned(ushort x)
        {
            return (x & AudioMaskSigned) != 0;
        }

        public static bool AudioIsint(ushort x)
        {
            return (x & AudioMaskDatatype) == 0;
        }

        public static bool AudioIslittleendian(ushort x)
        {
            return (x & AudioMaskEndian) == 0;
        }

        public static bool AudioIsunsigned(ushort x)
        {
            return (x & AudioMaskSigned) == 0;
        }

        public const ushort AudioU8 = 0x0008;
        public const ushort AudioS8 = 0x8008;
        public const ushort AudioU16Lsb = 0x0010;
        public const ushort AudioS16Lsb = 0x8010;
        public const ushort AudioU16Msb = 0x1010;
        public const ushort AudioS16Msb = 0x9010;
        public const ushort AudioU16 = AudioU16Lsb;
        public const ushort AudioS16 = AudioS16Lsb;
        public const ushort AudioS32Lsb = 0x8020;
        public const ushort AudioS32Msb = 0x9020;
        public const ushort AudioS32 = AudioS32Lsb;
        public const ushort AudioF32Lsb = 0x8120;
        public const ushort AudioF32Msb = 0x9120;
        public const ushort AudioF32 = AudioF32Lsb;

        public static readonly ushort AudioU16Sys =
            BitConverter.IsLittleEndian ? AudioU16Lsb : AudioU16Msb;

        public static readonly ushort AudioS16Sys =
            BitConverter.IsLittleEndian ? AudioS16Lsb : AudioS16Msb;

        public static readonly ushort AudioS32Sys =
            BitConverter.IsLittleEndian ? AudioS32Lsb : AudioS32Msb;

        public static readonly ushort AudioF32Sys =
            BitConverter.IsLittleEndian ? AudioF32Lsb : AudioF32Msb;

        public const uint AudioAllowFrequencyChange = 0x00000001;
        public const uint AudioAllowFormatChange = 0x00000002;
        public const uint AudioAllowChannelsChange = 0x00000004;
        public const uint AudioAllowSamplesChange = 0x00000008;

        public const uint AudioAllowAnyChange = AudioAllowFrequencyChange |
                                                AudioAllowFormatChange |
                                                AudioAllowChannelsChange |
                                                AudioAllowSamplesChange;

        public const int MixMaxvolume = 128;

        public void ThrowError()
        {
            var ex = GetErrorAsException();
            if (!(ex is null))
            {
                throw ex;
            }
        }

        public SdlException? GetErrorAsException()
        {
            var str = GetErrorS();
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            ClearError();
            return new SdlException(str);
        }

        public static Sdl GetApi()
        {
            var libName = new SDLLibraryNameContainer().GetLibraryName();
#if !__ANDROID__
            var ctx = CreateDefaultContext(libName);
#else
            var ctx = new OVERRIDE_1();
#endif
            return new Sdl(ctx);
        }

        public override bool IsExtensionPresent(string extension) => GLExtensionSupported(extension) == SdlBool.True;
    }
}
