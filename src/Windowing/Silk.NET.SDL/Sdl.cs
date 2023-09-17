using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    // TODO for Silk.NET 3.0:
    // ideally we'd only use override 1 on android, but we can't really do that until it's better supported in .net 6
    // (we'd need a preprocessor directive which is only available in xamarin)
    [PInvokeOverride(1, "libSDL2.so")]
    [PInvokeOverride(0, "__Internal")]
    public partial class Sdl
    {
        public const uint InitEverything = InitTimer | InitAudio | InitVideo |
                                           InitEvents | InitJoystick | InitHaptic |
                                           InitGamecontroller | InitSensor;

        /// <remarks>Only available in SDL 2.0.2 or higher.</remarks>
        public const string HintCtrlClickEmulateRightClick =
            "SDL_CTRL_CLICK_EMULATE_RIGHT_CLICK";

        public const string HintAndroidSeparateMouseAndTouch =
            "SDL_ANDROID_SEPARATE_MOUSE_AND_TOUCH";

        public const string HintVideoX11NetWmPing =
            "SDL_VIDEO_X11_NET_WM_PING";

        public const string HintAppleTvRemoteAllowRotation =
            "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION";

        [Obsolete("Use HintIosHideHomeIndicator instead.")]
        public const string HintIOSHideHomeIndicator = HintIosHideHomeIndicator;

        public const string HintTvRemoteAsJoystick =
            "SDL_TV_REMOTE_AS_JOYSTICK";

        [Obsolete("Use HintJoystickHidapiPS4 instead.")]
        public const string HintJoystickHidapiPs4 = HintJoystickHidapiPS4;

        [Obsolete("Use HintJoystickHidapiPS4Rumble instead.")]
        public const string HintJoystickHidapiPs4Rumble = HintJoystickHidapiPS4Rumble;

        [Obsolete("Use HintVideoX11WindowVisualid instead.")]
        public const string HintVidoX11WindowVisualid = HintVideoX11WindowVisualid;

        [Obsolete("Use HintVideoX11ForceEGL instead.")]
        public const string HintVideoX11ForceEGL = HintVideoX11ForceEgl;

        public static readonly int Compiledversion = Versionnum
        (
            MajorVersion,
            MinorVersion,
            Patchlevel
        );

        public const int WindowposUndefined = 0x1FFF0000;
        public const int WindowposCentered = 0x2FFF0000;

        public static int Versionnum(int x, int y, int z)
        {
            return x * 1000 + y * 100 + z;
        }

        public static int WindowposUndefinedDisplay(int x)
        {
            return (int) (WindowposUndefinedMask | x);
        }

        public static bool WindowposIsUndefined(int x)
        {
            return (x & 0xFFFF0000) == WindowposUndefinedMask;
        }

        public static int WindowposCenteredDisplay(int x)
        {
            return (int) (WindowposCenteredMask | x);
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


        /* HapticRunEffect */
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

        public const uint AudioAllowAnyChange = AudioAllowFrequencyChange |
                                                AudioAllowFormatChange |
                                                AudioAllowChannelsChange |
                                                AudioAllowSamplesChange;

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

        public static Sdl GetApi() => new Sdl(CreateDefaultContext(new SDLLibraryNameContainer().GetLibraryNames()));
        public override bool IsExtensionPresent(string extension) => GLExtensionSupported(extension) == SdlBool.True;
    }
}
