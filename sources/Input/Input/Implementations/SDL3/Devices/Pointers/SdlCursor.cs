// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.Runtime.InteropServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal unsafe class SdlCursor : ICursorConfiguration, IDisposable
{
    private readonly ISdl _sdl;

    private CursorHandle _handle;

    /// <summary>
    /// Internal style of the current cursor handle - may differ from the <see cref="Style"/> property,
    /// </summary>
    private CursorStyles _handleStyle = _noStyle;
    private const CursorStyles _noStyle = (CursorStyles)(-1);

    private static readonly FrozenDictionary<CursorStyles, SystemCursor> _cursorStyles =
        new Dictionary<CursorStyles, SystemCursor> {
            [CursorStyles.Default] = SystemCursor.Default,
            [CursorStyles.Arrow] = SystemCursor.Default,
            [CursorStyles.IBeam] = SystemCursor.Text,
            [CursorStyles.Crosshair] = SystemCursor.Crosshair,
            [CursorStyles.Hand] = SystemCursor.Pointer,
            [CursorStyles.HResize] = SystemCursor.EwResize,
            [CursorStyles.VResize] = SystemCursor.NsResize
        }.ToFrozenDictionary();


    public SdlCursor(ISdl sdl)
    {
        _sdl = sdl;
        Mode = CursorModes.Normal;
        SupportedStyles = TestCursorCompatibility(sdl);
        Style = CursorStyles.Arrow;
    }

    private bool SetCursorStyle(CursorStyles style)
    {
        CursorHandle handle;
        if (style == CursorStyles.Custom)
        {
            if (_customCursorImage == null || _customCursorSurface == null)
            {
                return false;
            }

            var canReuseCurrentCursorHandle = _handleStyle == CursorStyles.Custom; // todo - compare cursor hotspot
            if (canReuseCurrentCursorHandle)
            {
                return true;
            }

            // todo: cursor hotspot, not supported by sdl?
            handle = _sdl.CreateColorCursor(_customCursorSurface, 0, 0);
        }
        else if (style == _handleStyle)
        {
            return true;
        }
        else
        {
            handle = _sdl.CreateSystemCursor(_cursorStyles[style]);
        }

        if (handle.Handle == null)
        {
            SdlLog.Error("Failed to create cursor");
            return false;
        }

        if (_handle != handle)
        {
            FreeCurrentCursor();
        }

        _handle = handle;
        _handleStyle = style;

        if (_sdl.SetCursor(_handle))
        {
            return true;
        }

        SdlLog.Error("Failed to set cursor");
        return false;
    }

    public void Dispose()
    {
        FreeCurrentCursor();
        DisposeCursorSurface(ref _customCursorSurface);
    }

    private void FreeCurrentCursor()
    {
        if (_handle == default)
        {
            return;
        }

        _sdl.DestroyCursor(_handle);
        _handle = default;

        if (_handleStyle == CursorStyles.Custom)
        {
            DisposeCursorSurface(ref _customCursorSurface);
        }

        _handleStyle = _noStyle;
    }

    private void DisposeCursorSurface(ref Surface* surface)
    {
        if(surface != null)
        {
            _sdl.DestroySurface(surface);
            _customCursorSurface = null;
        }
    }

    private static CursorStyles TestCursorCompatibility(ISdl sdl)
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

    public CursorModes Mode
    {
        get;
        set
        {
            field = value;
            try
            {
                ModeChanged?.Invoke(this, value);
            }
            catch (Exception e)
            {
                InputLog.Error(e.ToString());
            }
        }
    }

    public event EventHandler<CursorModes>? ModeChanged;

    public CursorStyles SupportedStyles { get; }

    public CursorStyles Style
    {
        get;
        set
        {
            if (value == CursorStyles.Hidden && field != CursorStyles.Hidden)
            {
                SetCursorVisibility(false);
                return;
            }

            SetCursorStyle(value);
            if(field == CursorStyles.Hidden)
            {
                SetCursorVisibility(true);
            }

            field = value;
        }
    }

    private void SetCursorVisibility(bool visible)
    {
        if (_handle == default)
        {
            return;
        }

        if (visible ? _sdl.HideCursor() : _sdl.ShowCursor())
        {
            return;
        }

        SdlLog.Error("Failed to hide cursor");
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
            var necessaryLength = value.Width * value.Height;
            if(value.Data.Length < necessaryLength)
            {
                throw new ArgumentException($"Custom cursor image of size ({value.Width}, {value.Height}) " +
                                         $"must be at least {value.Width * value.Height * 4} bytes long, " +
                                         $"got {value.Data.Length} bytes instead");
            }

            // ensure we have a fixed byte array to work with so updates would automatically apply to sdl
            _customCursorHeight = value.Height;
            _customCursorWidth = value.Width;
            var byteCount = necessaryLength * 4;
            if (_customCursorImage is null || _customCursorImage.Length < byteCount)
            {
                _customCursorImage = GC.AllocateUninitializedArray<byte>(byteCount, pinned: true);
            }

            // copy the user data to our fixed array
            var myBytes = _customCursorImage.AsSpan(..byteCount);
            var providedBytes = MemoryMarshal.Cast<int, byte>(value.Data);
            providedBytes.CopyTo(myBytes);

            ApplyToCursorSurface(ref _customCursorSurface, value);

            if (Style == CursorStyles.Custom && _handleStyle != CursorStyles.Custom)
            {
                SetCursorStyle(CursorStyles.Custom);
            }

            return;

            void ApplyToCursorSurface(ref Surface* customCursorSurface, in CustomCursor val)
            {
                // create a new sdl surface if necessary
                if(customCursorSurface != null)
                {
                    if (customCursorSurface->H != val.Height || customCursorSurface->W != val.Width)
                    {
                        DisposeCursorSurface(ref customCursorSurface);
                        customCursorSurface = CreateSurface(val);
                    }
                }
                else
                {
                    customCursorSurface = _sdl.CreateSurface(val.Width, val.Height, PixelFormat.Argb8888);
                }

                // ensure the surface's pixel data is our fixed array
                fixed (byte* ptr = _customCursorImage)
                {
                    customCursorSurface->Pixels = ptr;
                }

                return;

                Ptr<Surface> CreateSurface(CustomCursor customCursor)
                {
                    return _sdl.CreateSurface(customCursor.Width, customCursor.Height, PixelFormat.Argb8888);
                }
            }
        }
    }

    private Surface* _customCursorSurface;
    private int _customCursorHeight, _customCursorWidth;
    private byte[]? _customCursorImage;

}
