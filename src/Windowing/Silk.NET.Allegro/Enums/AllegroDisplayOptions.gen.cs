// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_DISPLAY_OPTIONS")]
    public enum AllegroDisplayOptions
    {
        [NativeName("Name", "ALLEGRO_RED_SIZE")]
        AllegroRedSize = 0x0,
        [NativeName("Name", "ALLEGRO_GREEN_SIZE")]
        AllegroGreenSize = 0x1,
        [NativeName("Name", "ALLEGRO_BLUE_SIZE")]
        AllegroBlueSize = 0x2,
        [NativeName("Name", "ALLEGRO_ALPHA_SIZE")]
        AllegroAlphaSize = 0x3,
        [NativeName("Name", "ALLEGRO_RED_SHIFT")]
        AllegroRedShift = 0x4,
        [NativeName("Name", "ALLEGRO_GREEN_SHIFT")]
        AllegroGreenShift = 0x5,
        [NativeName("Name", "ALLEGRO_BLUE_SHIFT")]
        AllegroBlueShift = 0x6,
        [NativeName("Name", "ALLEGRO_ALPHA_SHIFT")]
        AllegroAlphaShift = 0x7,
        [NativeName("Name", "ALLEGRO_ACC_RED_SIZE")]
        AllegroAccRedSize = 0x8,
        [NativeName("Name", "ALLEGRO_ACC_GREEN_SIZE")]
        AllegroAccGreenSize = 0x9,
        [NativeName("Name", "ALLEGRO_ACC_BLUE_SIZE")]
        AllegroAccBlueSize = 0xA,
        [NativeName("Name", "ALLEGRO_ACC_ALPHA_SIZE")]
        AllegroAccAlphaSize = 0xB,
        [NativeName("Name", "ALLEGRO_STEREO")]
        AllegroStereo = 0xC,
        [NativeName("Name", "ALLEGRO_AUX_BUFFERS")]
        AllegroAuxBuffers = 0xD,
        [NativeName("Name", "ALLEGRO_COLOR_SIZE")]
        AllegroColorSize = 0xE,
        [NativeName("Name", "ALLEGRO_DEPTH_SIZE")]
        AllegroDepthSize = 0xF,
        [NativeName("Name", "ALLEGRO_STENCIL_SIZE")]
        AllegroStencilSize = 0x10,
        [NativeName("Name", "ALLEGRO_SAMPLE_BUFFERS")]
        AllegroSampleBuffers = 0x11,
        [NativeName("Name", "ALLEGRO_SAMPLES")]
        AllegroSamples = 0x12,
        [NativeName("Name", "ALLEGRO_RENDER_METHOD")]
        AllegroRenderMethod = 0x13,
        [NativeName("Name", "ALLEGRO_FLOAT_COLOR")]
        AllegroFloatColor = 0x14,
        [NativeName("Name", "ALLEGRO_FLOAT_DEPTH")]
        AllegroFloatDepth = 0x15,
        [NativeName("Name", "ALLEGRO_SINGLE_BUFFER")]
        AllegroSingleBuffer = 0x16,
        [NativeName("Name", "ALLEGRO_SWAP_METHOD")]
        AllegroSwapMethod = 0x17,
        [NativeName("Name", "ALLEGRO_COMPATIBLE_DISPLAY")]
        AllegroCompatibleDisplay = 0x18,
        [NativeName("Name", "ALLEGRO_UPDATE_DISPLAY_REGION")]
        AllegroUpdateDisplayRegion = 0x19,
        [NativeName("Name", "ALLEGRO_VSYNC")]
        AllegroVsync = 0x1A,
        [NativeName("Name", "ALLEGRO_MAX_BITMAP_SIZE")]
        AllegroMaxBitmapSize = 0x1B,
        [NativeName("Name", "ALLEGRO_SUPPORT_NPOT_BITMAP")]
        AllegroSupportNpotBitmap = 0x1C,
        [NativeName("Name", "ALLEGRO_CAN_DRAW_INTO_BITMAP")]
        AllegroCanDrawIntoBitmap = 0x1D,
        [NativeName("Name", "ALLEGRO_SUPPORT_SEPARATE_ALPHA")]
        AllegroSupportSeparateAlpha = 0x1E,
        [NativeName("Name", "ALLEGRO_AUTO_CONVERT_BITMAPS")]
        AllegroAutoConvertBitmaps = 0x1F,
        [NativeName("Name", "ALLEGRO_SUPPORTED_ORIENTATIONS")]
        AllegroSupportedOrientations = 0x20,
        [NativeName("Name", "ALLEGRO_OPENGL_MAJOR_VERSION")]
        AllegroOpenglMajorVersion = 0x21,
        [NativeName("Name", "ALLEGRO_OPENGL_MINOR_VERSION")]
        AllegroOpenglMinorVersion = 0x22,
        [NativeName("Name", "ALLEGRO_DISPLAY_OPTIONS_COUNT")]
        AllegroDisplayOptionsCount = 0x23,
    }
}
