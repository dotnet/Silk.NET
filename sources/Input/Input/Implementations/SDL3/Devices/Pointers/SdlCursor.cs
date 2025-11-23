// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlCursor : ICursorConfiguration, IDisposable
{
    private readonly ISdl _sdl;
    private CursorHandle _handle;

    private static readonly FrozenDictionary<CursorStyles, SystemCursor> _cursorStyles =
        new Dictionary<CursorStyles, SystemCursor> {
            [CursorStyles.Arrow] = SystemCursor.Default,
            [CursorStyles.IBeam] = SystemCursor.Text,
            [CursorStyles.Crosshair] = SystemCursor.Crosshair,
            [CursorStyles.Hand] = SystemCursor.Pointer,
            [CursorStyles.HResize] = SystemCursor.EwResize,
            [CursorStyles.VResize] = SystemCursor.NsResize
        }.ToFrozenDictionary();


    public unsafe SdlCursor(ISdl sdl)
    {
        _sdl = sdl;
        Mode = CursorModes.Normal;
        SupportedStyles = TestCursorCompatibility(sdl);

        SetCursorStyle(CursorStyles.Arrow);
    }

    private bool SetCursorStyle(CursorStyles style)
    {
        FreeCurrentCursor();
        if (style == CursorStyles.Custom)
        {
            // to be set by the Image property, so we just return
            if (_customCursorImage != null)
            {
                ApplyCustomCursor();
            }
            return true;
        }

        _handle = _sdl.CreateSystemCursor(_cursorStyles[style]);
        if (_handle == default)
        {
            SdlLog.Error("Failed to create system cursor");
            return false;
        }

        if (_sdl.SetCursor(_handle))
        {
            Style = CursorStyles.Arrow;
            return true;
        }

        return false;
    }

    private void ApplyCustomCursor()
    {
        if (_customCursorImage == null)
        {
            // presumably this was set by the Styles property, and we're still waiting on the image
            return;
        }

        var image = _customCursorImage;
        var width = _customCursorWidth;
        var height = _customCursorHeight;
        var minSize = width * height * 4;

        if (image.Length < minSize)
        {
            throw new ArgumentException($"Custom cursor image of size ({width}, {height}) must be at least {minSize} " +
                                        $"bytes long, got {image.Length} bytes instead");
        }
    }

    public void Dispose()
    {
        FreeCurrentCursor();
    }

    private void FreeCurrentCursor()
    {
        if (_handle != default)
        {
            _sdl.DestroyCursor(_handle);
            _handle = default;
        }
    }

    private static unsafe CursorStyles TestCursorCompatibility(ISdl sdl)
    {
        // check cursor style availability
        ReadOnlySpan<CursorStyles> mainStyles = [
            CursorStyles.Arrow, CursorStyles.IBeam, CursorStyles.Crosshair, CursorStyles.Hand, CursorStyles.HResize,
            CursorStyles.VResize
        ];

        // todo: is it necessary to check for the Default style? can some platforms just not support any cursor?
        // if so, the result of this evaluation will still report that "Default" is available..
        // lest we make it nullable... nah i'll leave it to the Sdl gods for now
        var successfulStyles = CursorStyles.Default;
        for (var i = 0; i < _cursorStyles.Count; i++)
        {
            var cursorStyle = mainStyles[i];
            var sdlStyle = _cursorStyles[cursorStyle];
            var cursor = sdl.CreateSystemCursor(sdlStyle);
            if (cursor.Handle == null)
            {
                SdlLog.Debug($"System cursor style {sdlStyle} unavailable");
            }
            else
            {
                successfulStyles |= cursorStyle;
                sdl.Free(cursor.Handle);
            }
        }

        return successfulStyles;
    }

    public CursorModes SupportedModes =>
        CursorModes.Normal | CursorModes.Confined | CursorModes.Unbounded;

    public CursorModes Mode { get; set; }

    public CursorStyles SupportedStyles { get; }

    public CursorStyles Style
    {
        get;
        set
        {
            if (value == field)
            {
                return;
            }

            if (value == CursorStyles.Hidden)
            {
                if (!_sdl.HideCursor())
                {
                    SdlLog.Error("Failed to hide cursor");
                    return;
                }
            }
            else if(field == CursorStyles.Hidden)
            {
                // reveal the cursor
                if (!_sdl.ShowCursor())
                {
                    SdlLog.Error("Failed to show cursor");
                }
            }

            SetCursorStyle(value);
            field = value;
        }
    }

    public CustomCursor Image
    {
        get
        {
            var byteCount = _customCursorWidth * _customCursorHeight * 4;
            var myBytes = _customCursorImage.AsSpan(..byteCount);
            var asInts = MemoryMarshal.Cast<byte, int>(myBytes);
            return new CustomCursor { Width = _customCursorWidth, Height = _customCursorHeight, Data = asInts };
        }
        set
        {
            var val = value;
            var necessaryLength = val.Width * val.Height;
            if(val.Data.Length < necessaryLength)
            {
                throw new ArgumentException($"Custom cursor image of size ({val.Width}, {val.Height}) " +
                                         $"must be at least {val.Width * val.Height * 4} bytes long, " +
                                         $"got {val.Data.Length} bytes instead");
            }

            _customCursorHeight = val.Height;
            _customCursorWidth = val.Width;
            var byteCount = necessaryLength * 4;
            if (_customCursorImage is null || _customCursorImage.Length < byteCount)
            {
                _customCursorImage = new byte[byteCount];
            }

            var myBytes = _customCursorImage.AsSpan(..byteCount);
            var bytesAsInts = MemoryMarshal.Cast<byte, int>(myBytes);
            value.Data[..necessaryLength].CopyTo(bytesAsInts);

            // todo - actually apply to sdl
        }
    }

    private int _customCursorHeight, _customCursorWidth;
    private byte[]? _customCursorImage;

}
