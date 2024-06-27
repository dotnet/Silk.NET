using System;
using System.Collections.Generic;
using Silk.NET.Core;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal class SdlCursor : ICursor
    {
        private readonly SdlMouse _mouse;
        private readonly SdlInputContext _ctx;

        private static readonly Dictionary<StandardCursor, SystemCursor> _cursorShapes =
            new Dictionary<StandardCursor, SystemCursor>
            {
                {StandardCursor.Arrow, SystemCursor.SystemCursorArrow},
                {StandardCursor.IBeam, SystemCursor.SystemCursorIbeam},
                {StandardCursor.Crosshair, SystemCursor.SystemCursorCrosshair},
                {StandardCursor.Hand, SystemCursor.SystemCursorHand},
                {StandardCursor.HResize, SystemCursor.SystemCursorSizewe},
                {StandardCursor.VResize, SystemCursor.SystemCursorSizens},
                {StandardCursor.NwseResize, SystemCursor.SystemCursorSizenwse},
                {StandardCursor.NeswResize, SystemCursor.SystemCursorSizenesw},
                {StandardCursor.ResizeAll, SystemCursor.SystemCursorSizeall},
                {StandardCursor.NotAllowed, SystemCursor.SystemCursorNo},
                {StandardCursor.Wait, SystemCursor.SystemCursorWait},
                {StandardCursor.WaitArrow, SystemCursor.SystemCursorWaitarrow}
            };

        private const int BytesPerCursorPixel = 4;

        private unsafe Cursor* _cursor = null;
        private unsafe Surface* _cursorSurface = null;
        private CursorType _cursorType = CursorType.Standard;
        private StandardCursor _standardCursor = StandardCursor.Default;
        private int _hotspotX = 0;
        private int _hotspotY = 0;
        private RawImage _image;

        internal unsafe SdlCursor(SdlMouse mouse, SdlInputContext ctx)
        {
            _mouse = mouse;
            _ctx = ctx;
        }

        /// <inheritdoc />
        public unsafe CursorType Type
        {
            get => _cursorType;
            set
            {
                if (_cursorType != value)
                {
                    _cursorType = value;

                    Surface* surface = null;
                    var c = _cursorType switch
                    {
                        CursorType.Standard => CreateStandardCursor(),
                        CursorType.Custom => CreateCustomCursor(out surface),
                        _ => throw new InvalidOperationException("SDL does not support the given cursor type.")
                    };

                    _ctx.Sdl.SetCursor(c);
                    if (_cursor != null)
                    {
                        // destroy the old custom cursor
                        _ctx.Sdl.FreeCursor(_cursor);
                        _cursor = null;
                    }

                    if (_cursorSurface != null)
                    {
                        _ctx.Sdl.FreeSurface(_cursorSurface);
                        _cursorSurface = null;
                    }

                    _cursor = c;
                    _cursorSurface = surface;
                }
            }
        }

        /// <inheritdoc />
        public StandardCursor StandardCursor
        {
            get => _standardCursor;
            set
            {
                if (_standardCursor != value)
                {
                    _standardCursor = value;
                    UpdateStandardCursor();
                }
            }
        }

        /// <inheritdoc />
        public unsafe CursorMode CursorMode
        {
            get => _ctx.Sdl.GetRelativeMouseMode() == SdlBool.True ? CursorMode.Raw :
                _ctx.Sdl.ShowCursor(-1) == 1 ? CursorMode.Normal : CursorMode.Hidden;
            set
            {
                switch (value)
                {
                    case CursorMode.Normal:
                    {
                        _mouse.IsRaw = false;
                        _ctx.Sdl.SetRelativeMouseMode(SdlBool.False);
                        _ctx.Sdl.ShowCursor(1);
                        break;
                    }
                    case CursorMode.Hidden:
                    {
                        _mouse.IsRaw = false;
                        _ctx.Sdl.SetRelativeMouseMode(SdlBool.False);
                        _ctx.Sdl.ShowCursor(0);
                        break;
                    }
                    case CursorMode.Disabled:
                    {
                        throw new PlatformNotSupportedException("CursorMode.Disabled is not supported by SDL.");
                    }
                    case CursorMode.Raw:
                    {
                        _mouse.IsRaw = true;
                        _mouse.AggregatePoint = default;
                        _ctx.Sdl.SetRelativeMouseMode(SdlBool.True);
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
            }
        }

        public unsafe bool IsConfined
        {
            get => _ctx.Sdl.GetWindowGrab((Window*) _ctx.Handle) == SdlBool.True;
            set => _ctx.Sdl.SetWindowGrab((Window*) _ctx.Handle, value ? SdlBool.True : SdlBool.False);
        }

        /// <inheritdoc />
        public int HotspotX
        {
            get => _hotspotX;
            set
            {
                if (_hotspotX != value)
                {
                    _hotspotX = value;
                    UpdateCustomCursor();
                }
            }
        }

        /// <inheritdoc />
        public int HotspotY
        {
            get => _hotspotY;
            set
            {
                if (_hotspotY != value)
                {
                    _hotspotY = value;
                    UpdateCustomCursor();
                }
            }
        }

        /// <inheritdoc />
        public RawImage Image
        {
            get => _image;
            set
            {
                if (_image != value)
                {
                    _image = value;
                    UpdateCustomCursor();
                }
            }
        }

        /// <inheritdoc />
        public bool IsSupported(CursorMode mode)
        {
            return mode switch
            {
                CursorMode.Normal => true,
                CursorMode.Hidden => true,
                CursorMode.Disabled => false, // TODO maybe in the future we can implement this manually?
                CursorMode.Raw => true,
                _ => false
            };
        }

        /// <inheritdoc />
        public bool IsSupported(StandardCursor standardCursor)
        {
            return standardCursor switch
            {
                StandardCursor.Default => true,
                StandardCursor.Arrow => true,
                StandardCursor.IBeam => true,
                StandardCursor.Crosshair => true,
                StandardCursor.Hand => true,
                StandardCursor.HResize => true,
                StandardCursor.VResize => true,
                _ => false
            };
        }

        public unsafe void Dispose()
        {
            if (_cursor != null)
            {
                _ctx.Sdl.FreeCursor(_cursor);
            }

            if (_cursorSurface != null)
            {
                _ctx.Sdl.FreeSurface(_cursorSurface);
            }

            _cursor = null;
            _cursorSurface = null;
            _standardCursor = StandardCursor.Default;
            _cursorType = CursorType.Standard;
            _ctx.Sdl.SetCursor((Cursor*) 0);
            _ctx.Sdl.ClearError();
        }

        private unsafe Cursor* CreateStandardCursor()
        {
            if (_standardCursor == StandardCursor.Default)
                return null;
            else
            {
                if (!_cursorShapes.ContainsKey(_standardCursor))
                    throw new InvalidOperationException("Sdl does not support the given standard cursor.");

                return _ctx.Sdl.CreateSystemCursor(_cursorShapes[_standardCursor]);
            }
        }

        private unsafe Cursor* CreateCustomCursor(out Surface* surface)
        {
            surface = null;
            if (_image.Pixels.IsEmpty || _image.Width <= 0 || _image.Height <= 0)
                return null;

            if (_image.Pixels.Length % BytesPerCursorPixel != 0)
                throw new ArgumentOutOfRangeException
                    ($"Pixel data must provide a multiple of {BytesPerCursorPixel} bytes.");

            // the user might setup the values step-by-step, so use the
            // default cursor as long as the custom cursor state is not valid
            if (_image.Width * _image.Height * BytesPerCursorPixel != _image.Pixels.Length)
                return null;

            surface = _ctx.Sdl.CreateRGBSurfaceFrom
            (
                _image.Pixels.Span, _image.Width, _image.Height, 32, _image.Width * 4, 0xff000000, 0x00ff0000,
                0x0000ff00,
                0x000000ff
            );

            return _ctx.Sdl.CreateColorCursor(surface, 0, 0);
        }

        private unsafe void UpdateStandardCursor()
        {
            var c = CreateStandardCursor();
            _ctx.Sdl.SetCursor(c);
            if (_cursor != null)
            {
                _ctx.Sdl.FreeCursor(_cursor);
            }

            if (_cursorSurface != null)
            {
                _ctx.Sdl.FreeSurface(_cursorSurface);
            }

            _cursor = c;
            _cursorSurface = null;
        }

        private unsafe void UpdateCustomCursor()
        {
            if (_cursorType == CursorType.Custom)
            {
                var c = CreateCustomCursor(out var surface);
                _ctx.Sdl.SetCursor(c);
                if (_cursor != null)
                {
                    _ctx.Sdl.FreeCursor(_cursor);
                }

                if (_cursorSurface != null)
                {
                    _ctx.Sdl.FreeSurface(_cursorSurface);
                }

                _cursor = c;
                _cursorSurface = surface;
            }
        }
    }
}
