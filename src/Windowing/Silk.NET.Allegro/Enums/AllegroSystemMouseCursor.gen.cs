// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR")]
    public enum AllegroSystemMouseCursor
    {
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_NONE")]
        AllegroSystemMouseCursorNone = 0x0,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_DEFAULT")]
        AllegroSystemMouseCursorDefault = 0x1,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_ARROW")]
        AllegroSystemMouseCursorArrow = 0x2,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_BUSY")]
        AllegroSystemMouseCursorBusy = 0x3,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_QUESTION")]
        AllegroSystemMouseCursorQuestion = 0x4,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_EDIT")]
        AllegroSystemMouseCursorEdit = 0x5,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_MOVE")]
        AllegroSystemMouseCursorMove = 0x6,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_N")]
        AllegroSystemMouseCursorResizeN = 0x7,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_W")]
        AllegroSystemMouseCursorResizeW = 0x8,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_S")]
        AllegroSystemMouseCursorResizeS = 0x9,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_E")]
        AllegroSystemMouseCursorResizeE = 0xA,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_NW")]
        AllegroSystemMouseCursorResizeNW = 0xB,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_SW")]
        AllegroSystemMouseCursorResizeSW = 0xC,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_SE")]
        AllegroSystemMouseCursorResizeSE = 0xD,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_RESIZE_NE")]
        AllegroSystemMouseCursorResizeNE = 0xE,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_PROGRESS")]
        AllegroSystemMouseCursorProgress = 0xF,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_PRECISION")]
        AllegroSystemMouseCursorPrecision = 0x10,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_LINK")]
        AllegroSystemMouseCursorLink = 0x11,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_ALT_SELECT")]
        AllegroSystemMouseCursorAltSelect = 0x12,
        [NativeName("Name", "ALLEGRO_SYSTEM_MOUSE_CURSOR_UNAVAILABLE")]
        AllegroSystemMouseCursorUnavailable = 0x13,
        [NativeName("Name", "ALLEGRO_NUM_SYSTEM_MOUSE_CURSORS")]
        AllegroNumSystemMouseCursors = 0x14,
    }
}
