using System;
using System.Collections.Generic;

namespace Vk.Generator
{
    public class TypeNameMappings
    {
        private readonly Dictionary<string, string> _nameMappings = new Dictionary<string, string>()
        {
            { "uint8_t", "byte" },
            { "uint32_t", "uint" },
            { "uint64_t", "ulong" },
            { "int32_t", "int" },
            { "int64_t", "long" },
            { "int64_t*", "long*" },
            { "char", "byte" },
            { "size_t", "UIntPtr" },
            { "DWORD", "uint" },

            { "ANativeWindow", "Android.ANativeWindow" },

            { "MirConnection", "Mir.MirConnection" },
            { "MirSurface", "Mir.MirSurface" },

            { "wl_display", "Wayland.wl_display" },
            { "wl_surface", "Wayland.wl_surface" },

            { "Display", "Xlib.Display" },
            { "Window", "Xlib.Window" },
            { "VisualID", "Xlib.VisualID" },
            { "RROutput", "IntPtr" },

            { "HINSTANCE", "Win32.HINSTANCE" },
            { "HWND", "Win32.HWND" },
            { "HANDLE", "Win32.HANDLE" },
            { "SECURITY_ATTRIBUTES", "Win32.SECURITY_ATTRIBUTES" },
            { "LPCWSTR", "IntPtr" },

            { "xcb_connection_t", "Xcb.xcb_connection_t" },
            { "xcb_window_t", "Xcb.xcb_window_t" },
            { "xcb_visualid_t", "Xcb.xcb_visualid_t" },
        };

        internal IEnumerable<KeyValuePair<string, string>> GetAllMappings()
        {
            return _nameMappings;
        }

        public void AddMapping(string originalName, string newName)
        {
            _nameMappings.Add(originalName, newName);
        }

        public string GetMappedName(string name)
        {
            if (_nameMappings.TryGetValue(name, out string mappedName))
            {
                return GetMappedName(mappedName);
            }
            else if (name.StartsWith("PFN"))
            {
                return "IntPtr";
            }
            else
            {
                return name;
            }
        }
    }
}
