// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.Core;
using Silk.NET.GLFW;

namespace Silk.NET.Input.Glfw
{
    /// <summary>
    /// A GLFW-based mouse cursor.
    /// </summary>
    internal class GlfwCursor : ICursor, IDisposable
    {
        private static readonly Dictionary<StandardCursor, CursorShape> _cursorShapes =
            new Dictionary<StandardCursor, CursorShape>
            {
                {StandardCursor.Arrow, CursorShape.Arrow},
                {StandardCursor.IBeam, CursorShape.IBeam},
                {StandardCursor.Crosshair, CursorShape.Crosshair},
                {StandardCursor.Hand, CursorShape.Hand},
                {StandardCursor.HResize, CursorShape.HResize},
                {StandardCursor.VResize, CursorShape.VResize},
                {StandardCursor.ResizeAll, CursorShape.AllResize},
                {StandardCursor.NeswResize, CursorShape.NeswResize},
                {StandardCursor.NwseResize, CursorShape.NwseResize},
                {StandardCursor.NotAllowed, CursorShape.NotAllowed}
            };

        private const int BytesPerCursorPixel = 4;

        private readonly unsafe WindowHandle* _handle;
        private unsafe Cursor* _cursor = null;
        private CursorType _cursorType = CursorType.Standard;
        private StandardCursor _standardCursor = StandardCursor.Default;
        private int _hotspotX = 0;
        private int _hotspotY = 0;
        private RawImage _image;

        internal unsafe GlfwCursor(WindowHandle* handle)
        {
            _handle = handle;
        }

        /// <inheritdoc />
        public unsafe CursorType Type
        {
            get => _cursorType;
            set
            {
                if (_cursorType != value)
                {
                    if (_cursorType == CursorType.Custom && _cursor != null)
                    {
                        // destroy the old custom cursor
                        GlfwProvider.GLFW.Value.DestroyCursor(_cursor);
                        _cursor = null;
                    }

                    _cursorType = value;

                    _cursor = _cursorType switch
                    {
                        CursorType.Standard => GetStandardCursor(),
                        CursorType.Custom => CreateCustomCursor(),
                        _ => throw new InvalidOperationException("Glfw does not support the given cursor type.")
                    };

                    GlfwProvider.GLFW.Value.SetCursor(_handle, _cursor);
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
            get => GetCursorMode
            (
                (CursorModeValue) GlfwProvider.GLFW.Value.GetInputMode(_handle, CursorStateAttribute.Cursor),
                GlfwProvider.GLFW.Value.GetInputMode(_handle, CursorStateAttribute.RawMouseMotion) != 0
            );
            set
            {
                GlfwProvider.GLFW.Value.SetInputMode
                    (_handle, CursorStateAttribute.Cursor, GetCursorMode(value, out bool raw));
                GlfwProvider.GLFW.Value.SetInputMode(_handle, CursorStateAttribute.RawMouseMotion, raw);
            }
        }

        public bool IsConfined
        {
            get => false;
            set { }
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
                CursorMode.Disabled => true,
                CursorMode.Raw => GlfwProvider.GLFW.Value.RawMouseMotionSupported(),
                _ => false
            };
        }

        /// <inheritdoc />
        public bool IsSupported(StandardCursor standardCursor)
        {
            GlfwProvider.GLFW.Value.GetVersion(out var major, out var minor, out _);
            var is34OrLater = major > 3 || major == 3 && minor >= 4;
            return standardCursor switch
            {
                StandardCursor.Default => true,
                StandardCursor.Arrow => true,
                StandardCursor.IBeam => true,
                StandardCursor.Crosshair => true,
                StandardCursor.Hand => true,
                StandardCursor.HResize => true,
                StandardCursor.VResize => true,
                StandardCursor.NeswResize when is34OrLater => true,
                StandardCursor.NwseResize when is34OrLater => true,
                StandardCursor.ResizeAll when is34OrLater => true,
                StandardCursor.NotAllowed when is34OrLater => true,
                _ => false
            };
        }

        public unsafe void Dispose()
        {
            if (_cursorType == CursorType.Custom && _cursor != null)
            {
                try
                {
                    GlfwProvider.GLFW.Value.DestroyCursor(_cursor);
                }
                catch
                {
                    // ignore as GlfwProvider.GLFW.Value.Terminate
                    // will destroy all custom cursors anyway
                }
            }

            _cursor = null;
            _standardCursor = StandardCursor.Default;
            _cursorType = CursorType.Standard;

            try
            {
                GlfwProvider.GLFW.Value.SetCursor(_handle, null);
            }
            catch
            {
                // ignore as the window may be closing already
            }
        }

        private unsafe Cursor* GetStandardCursor()
        {
            if (_standardCursor == StandardCursor.Default)
                return null;
            else
            {
                if (!_cursorShapes.ContainsKey(_standardCursor))
                    throw new InvalidOperationException("Glfw does not support the given standard cursor.");

                return GlfwProvider.GLFW.Value.CreateStandardCursor(_cursorShapes[_standardCursor]);
            }
        }

        private unsafe Cursor* CreateCustomCursor()
        {
            if (_image.Pixels.IsEmpty || _image.Width <= 0 || _image.Height <= 0)
                return null;

            if (_image.Pixels.Length % BytesPerCursorPixel != 0)
                throw new ArgumentOutOfRangeException
                    ($"Pixel data must provide a multiple of {BytesPerCursorPixel} bytes.");

            // the user might setup the values step-by-step, so use the
            // default cursor as long as the custom cursor state is not valid
            if (_image.Width * _image.Height * BytesPerCursorPixel != _image.Pixels.Length)
                return null;

            fixed (byte* ptr = _image.Pixels.Span)
            {
                var image = new Image
                {
                    Width = _image.Width,
                    Height = _image.Height,
                    Pixels = ptr
                };

                return GlfwProvider.GLFW.Value.CreateCursor(&image, HotspotX, HotspotY);
            }
        }

        private unsafe void UpdateStandardCursor()
        {
            if (_cursorType == CursorType.Standard)
            {
                _cursor = GetStandardCursor();
                GlfwProvider.GLFW.Value.SetCursor(_handle, _cursor);
            }
        }

        private unsafe void UpdateCustomCursor()
        {
            if (_cursorType == CursorType.Custom)
            {
                _cursor = CreateCustomCursor();
                GlfwProvider.GLFW.Value.SetCursor(_handle, _cursor);
            }
        }

        private static CursorModeValue GetCursorMode(CursorMode cursorMode, out bool raw)
        {
            raw = cursorMode == CursorMode.Raw;
            return cursorMode switch
            {
                CursorMode.Normal => CursorModeValue.CursorNormal,
                CursorMode.Hidden => CursorModeValue.CursorHidden,
                CursorMode.Disabled => CursorModeValue.CursorDisabled,
                CursorMode.Raw => CursorModeValue.CursorDisabled,
                _ => throw new ArgumentException("Invalid cursor mode", nameof(cursorMode))
            };
        }

        private static CursorMode GetCursorMode(CursorModeValue cursorMode, bool raw) => cursorMode switch
        {
            CursorModeValue.CursorNormal => CursorMode.Normal,
            CursorModeValue.CursorHidden => CursorMode.Hidden,
            CursorModeValue.CursorDisabled => raw ? CursorMode.Raw : CursorMode.Disabled,
            _ => throw new ArgumentException("Invalid cursor mode", nameof(cursorMode))
        };
    }
}
