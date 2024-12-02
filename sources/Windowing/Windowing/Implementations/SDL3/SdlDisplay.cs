// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal class SdlDisplay(uint id) : IDisplay
{
    public uint Id { get; } = id;
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

            var videoModes = DisplayModes;
            var ret = new VideoMode[videoModes.Length + 1];
            ret[0] = default; // This is to change back to non-fullscreen.
            for (nuint i = 0; (int)i < videoModes.Length; i++)
            {
                ref var videoMode = ref videoModes[i].Handle;
                ret[i + 1] = new VideoMode(
                    (int)i,
                    new Vector2(videoMode.W, videoMode.H),
                    videoMode.RefreshRate
                );
            }

            return _silkModes = ret;
        }
    }

    [field: AllowNull, MaybeNull]
    internal Ptr<DisplayMode>[] DisplayModes
    {
        get
        {
            if (field is not null)
            {
                return field;
            }

            var count = 0;
            var videoModes = Sdl.GetFullscreenDisplayModes(Id, count.AsRef());
            if (videoModes == nullptr)
            {
                Sdl.ThrowError();
            }

            field = new Ptr<DisplayMode>[count];
            videoModes.AsSpan(count).CopyTo(field);
            // TODO SDL_free
            return field;
        }
    }

    public bool IsPrimary => Sdl.GetPrimaryDisplay() == Id;

    public string Name => Sdl.GetDisplayName(Id).ReadToString();

    public event Action<DisplayCoordinatesEvent>? CoordinatesChanged;
    public event Action<DisplayVideoModeAvailabilityChangeEvent>? KnownVideoModesChanged;

    private bool Equals(SdlDisplay other) => Id == other.Id;

    public bool Equals(IDisplay? display) => Equals((object?)display);

    public override bool Equals(object? obj) =>
        obj is not null
        && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((SdlDisplay)obj)));

    public override int GetHashCode() => (int)Id;
}
