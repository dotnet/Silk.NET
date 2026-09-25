// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.Numerics;
using System.Reflection.Metadata;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal unsafe partial class SdlCursor : ICursorConfiguration, IDisposable
{
    private readonly ISdl _sdl;

    private CursorHandle _systemCursorHandle;

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
        SupportedStyles = TestCursorCompatibility(sdl, _cursorStyles);
        Mode = CursorModes.Normal;
        Style = CursorStyles.Arrow;
        _customCursorSdl = new CustomCursorSdl();

        return;

        static CursorStyles TestCursorCompatibility(ISdl sdl, FrozenDictionary<CursorStyles, SystemCursor> styles)
        {
            // check cursor style availability
            ReadOnlySpan<CursorStyles> mainStyles = [
                CursorStyles.Arrow, CursorStyles.IBeam, CursorStyles.Crosshair, CursorStyles.Hand, CursorStyles.HResize,
                CursorStyles.VResize
            ];

            // QUESTION: is it necessary to check for the Default style? can some platforms just not support any cursor?
            // if so, the result of this evaluation will still report that "Default" is available..
            // lest we make it nullable... nah i'll leave it to the Sdl gods for now
            var supportedStyles = CursorStyles.Default | CursorStyles.Hidden;

#if WebAssembly || ANDROID || IOS || MACCATALYST
#else
            supportedStyles |= CursorStyles.Custom;
#endif

            for (var i = 0; i < mainStyles.Length; i++)
            {
                var cursorStyle = mainStyles[i];
                var sdlStyle = styles[cursorStyle];
                var cursor = sdl.CreateSystemCursor(sdlStyle);
                if (cursor.Handle == null)
                {
                    SdlLog.Debug($"System cursor style {sdlStyle} unavailable");
                }
                else
                {
                    supportedStyles |= cursorStyle;
                    sdl.DestroyCursor(cursor);
                }
            }

            return supportedStyles;
        }
    }

    public void Dispose()
    {
        // frees the cursor
        _customCursorSdl.Free(_sdl);
        if (_systemCursorHandle != default)
        {
            _sdl.DestroyCursor(_systemCursorHandle);
            _systemCursorHandle = default;
        }
    }

    private static void DisposeCursor(ref CursorHandle cursorHandle, ISdl sdl)
    {
        if (cursorHandle != default)
        {
            sdl.DestroyCursor(cursorHandle);
            cursorHandle = default;
        }
    }


    public event EventHandler<CursorModes>? ModeChanged;

    public CursorStyles SupportedStyles { get; }

    // TODO we can't query support for these cursor modes, but should we try-it-and-see to be accurate?
    // TODO if you're using one input context for all windows, there is no way to specify a window for
    //  grabbed cursor mode
    public CursorModes SupportedModes => CursorModes.Normal | CursorModes.Confined | CursorModes.Unbounded;

    public CursorModes Mode
    {
        get;
        set
        {
            if (value == default)
            {
                throw new Exception("Unnamed cursor mode not supported");
            }

            if ((SupportedModes & value) != value)
            {
                throw new PlatformNotSupportedException("The provided mode is not supported on this platform");
            }

            if (BitOperations.PopCount(*(uint*)&value) > 1)
            {
                throw new InvalidOperationException("Multi-bit modes are not supported");
            }

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

    public CursorStyles Style
    {
        get;
        set
        {
            if (value == field && value != CursorStyles.Custom)
            {
                return;
            }

            if ((SupportedStyles & value) != value)
            {
                throw new PlatformNotSupportedException("The provided style is not supported on this platform");
            }

            if (BitOperations.PopCount(*(uint*)&value) > 1)
            {
                throw new InvalidOperationException("Multi-bit styles are not supported");
            }


            var wasHidden = field == CursorStyles.Hidden;
            if (value == CursorStyles.Hidden)
            {
                if (!wasHidden)
                {
                    SetCursorVisibility(false);
                }

                field = value;
                return;
            }

            if (value == CursorStyles.Custom)
            {
                var handle = _customCursorSdl.CursorHandle;
                if (handle == default)
                {
                    throw new InvalidOperationException("Custom cursors must be set via the Image property");
                }

                if (!_sdl.SetCursor(_customCursorSdl.CursorHandle))
                {
                    SdlLog.Error("Failed to set cursor");
                    return;
                }
            }
            else
            {
                // force-clear the custom cursor if necessary
                _customCursorSdl.Free(_sdl);

                var handle = _sdl.CreateSystemCursor(_cursorStyles[value]);
                if (_sdl.SetCursor(handle))
                {
                    if(_systemCursorHandle != default)
                    {
                        _sdl.DestroyCursor(_systemCursorHandle);
                    }

                    _systemCursorHandle = handle;
                }
                else
                {
                    SdlLog.Error("Failed to set cursor");
                    _sdl.DestroyCursor(handle);
                    return;
                }
            }

            if (wasHidden)
            {
                SetCursorVisibility(true);
            }

            field = value;

            return;

            void SetCursorVisibility(bool visible)
            {
                if (visible ? _sdl.ShowCursor() : _sdl.HideCursor())
                {
                    return;
                }

                SdlLog.Error("Failed to change cursor visibility");
            }
        }
    }


    public CustomCursor Image
    {
        get
        {
            if (!_customCursorSdl.Exists)
            {
                // todo: should this throw?
                return default;
            }

            return new CustomCursor
            {
                Width = _customCursorSdl.Width,
                Height = _customCursorSdl.Height,
                Data = _customCursorSdl.ImageData
            };
        }
        set
        {
            if ((SupportedStyles & CursorStyles.Custom) != CursorStyles.Custom)
            {
                throw new PlatformNotSupportedException("Custom cursors are not supported on this platform");
            }

            if (value == default)
            {
                // revert the style to default if our custom cursor was active
                if (Style == CursorStyles.Custom)
                {
                    Style = CursorStyles.Default;
                }

                _customCursorSdl.Free(_sdl);
                return;
            }

            if (_customCursorSdl.PrepareCursorWith(in value, _sdl))
            {
                Style = CursorStyles.Custom;
            }
        }
    }

    private CustomCursorSdl _customCursorSdl;
}
