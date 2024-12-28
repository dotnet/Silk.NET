// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal class SdlDisplay : IDisplay
{
    private Rectangle<float> _bounds;
    private Rectangle<float> _workArea;

    public SdlDisplay(SdlSurface surface, uint id)
    {
        Surface = surface;
        Id = id;
        _bounds = Bounds;
        _workArea = WorkArea;
    }

    public uint Id { get; }
    public SdlSurface Surface { get; }

    public Rectangle<float> Bounds
    {
        get
        {
            Rect rect = default;
            if (!Sdl.GetDisplayBounds(Id, rect.AsRef()))
            {
                Sdl.ThrowError();
            }

            return new Rectangle<float>(rect.X, rect.Y, rect.W, rect.H);
        }
    }

    public Rectangle<float> WorkArea
    {
        get
        {
            Rect rect = default;
            if (!Sdl.GetDisplayUsableBounds(Id, rect.AsRef()))
            {
                Sdl.ThrowError();
            }

            return new Rectangle<float>(rect.X, rect.Y, rect.W, rect.H);
        }
    }

    private VideoMode[]? _silkModes;

    public IReadOnlyList<VideoMode>? KnownVideoModes
    {
        get
        {
            if (_silkModes is not null)
            {
                return _silkModes;
            }

            UpdateDisplayModes();
            var ret = new VideoMode[_displayModes.Length + 1];
            ret[0] = default; // This is to change back to non-fullscreen.
            for (nuint i = 0; (int)i < _displayModes.Length; i++)
            {
                ref var videoMode = ref _displayModes[i].Handle;
                ret[i + 1] = new VideoMode(
                    (int)(i + 1),
                    new Vector2(videoMode.W, videoMode.H),
                    videoMode.RefreshRate
                );
            }

            return _silkModes = ret;
        }
    }

    private Ptr<DisplayMode>[]? _displayModes;

    internal Ptr<DisplayMode>[] DisplayModes
    {
        get
        {
            if (_displayModes is not null)
            {
                return _displayModes;
            }

            UpdateDisplayModes();
            return _displayModes;
        }
    }

    [MemberNotNull(nameof(_displayModes))]
    private bool UpdateDisplayModes()
    {
        DebugPrint();
        var count = 0;
        var videoModes = Sdl.GetFullscreenDisplayModes(Id, count.AsRef());
        if (videoModes == nullptr)
        {
            Sdl.ThrowError();
        }

        var span = videoModes.AsSpan(count);
        if (_displayModes?.Length == count && span.SequenceEqual(_displayModes))
        {
            return false;
        }

        var wasNull = _displayModes is null;
        _displayModes = new Ptr<DisplayMode>[count];
        videoModes.AsSpan(count).CopyTo(_displayModes);
        Sdl.Free((Ref)videoModes);
        _silkModes = null;
        if (!wasNull)
        {
            DebugPrint("Raising KnownVideoModesChanged");
            _knownVideoModesChanged?.Invoke(new DisplayVideoModeAvailabilityChangeEvent());
        }

        return !wasNull;
    }

    public bool IsPrimary => Sdl.GetPrimaryDisplay() == Id;

    public string Name => Sdl.GetDisplayName(Id).ReadToString();

    public event Action<DisplayCoordinatesEvent>? CoordinatesChanged;
    private Action<DisplayVideoModeAvailabilityChangeEvent>? _knownVideoModesChanged;

    public event Action<DisplayVideoModeAvailabilityChangeEvent>? KnownVideoModesChanged
    {
        add
        {
            if (value is null)
            {
                return;
            }

            if (_displayModes is null)
            {
                UpdateDisplayModes();
            }

            _knownVideoModesChanged += value;
        }
        remove => _knownVideoModesChanged -= value;
    }

    private bool Equals(SdlDisplay other) => Id == other.Id;

    public bool Equals(IDisplay? display) => Equals((object?)display);

    public override bool Equals(object? obj) =>
        obj is not null
        && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((SdlDisplay)obj)));

    public override int GetHashCode() => (int)Id;

    public void OnCoordinatesChanged()
    {
        DebugPrint("Raising CoordinatesChanged...");
        CoordinatesChanged?.Invoke(
            new DisplayCoordinatesEvent(Surface, this, _bounds, Bounds, _workArea, WorkArea)
        );
    }

    // If _displayModes is null, user doesn't care.
    public bool OnModeChanged() => _displayModes is not null && UpdateDisplayModes();
}
