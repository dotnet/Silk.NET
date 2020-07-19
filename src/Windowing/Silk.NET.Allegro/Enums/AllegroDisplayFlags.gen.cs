// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_display_L13_C1")]
    public enum AllegroDisplayFlags
    {
        [NativeName("Name", "ALLEGRO_WINDOWED")]
        AllegroWindowed = 0x1,
        [NativeName("Name", "ALLEGRO_FULLSCREEN")]
        AllegroFullscreen = 0x2,
        [NativeName("Name", "ALLEGRO_OPENGL")]
        AllegroOpengl = 0x4,
        [NativeName("Name", "ALLEGRO_DIRECT3D_INTERNAL")]
        AllegroDirect3DInternal = 0x8,
        [NativeName("Name", "ALLEGRO_RESIZABLE")]
        AllegroResizable = 0x10,
        [NativeName("Name", "ALLEGRO_FRAMELESS")]
        AllegroFrameless = 0x20,
        [NativeName("Name", "ALLEGRO_NOFRAME")]
        AllegroNoframe = 0x20,
        [NativeName("Name", "ALLEGRO_GENERATE_EXPOSE_EVENTS")]
        AllegroGenerateExposeEvents = 0x40,
        [NativeName("Name", "ALLEGRO_OPENGL_3_0")]
        AllegroOpengl30 = 0x80,
        [NativeName("Name", "ALLEGRO_OPENGL_FORWARD_COMPATIBLE")]
        AllegroOpenglForwardCompatible = 0x100,
        [NativeName("Name", "ALLEGRO_FULLSCREEN_WINDOW")]
        AllegroFullscreenWindow = 0x200,
        [NativeName("Name", "ALLEGRO_MINIMIZED")]
        AllegroMinimized = 0x400,
        [NativeName("Name", "ALLEGRO_PROGRAMMABLE_PIPELINE")]
        AllegroProgrammablePipeline = 0x800,
        [NativeName("Name", "ALLEGRO_GTK_TOPLEVEL_INTERNAL")]
        AllegroGtkToplevelInternal = 0x1000,
        [NativeName("Name", "ALLEGRO_MAXIMIZED")]
        AllegroMaximized = 0x2000,
        [NativeName("Name", "ALLEGRO_OPENGL_ES_PROFILE")]
        AllegroOpenglESProfile = 0x4000,
    }
}
