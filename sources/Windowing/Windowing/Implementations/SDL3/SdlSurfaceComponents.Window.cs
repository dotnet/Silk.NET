// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceWindow
{
    public Rectangle<float> Bounds
    {
        get
        {
            var ca = ClientArea;
            if (!IsSurfaceInitialized)
            {
                return ca;
            }

            var top = 0;
            var left = 0;
            var bottom = 0;
            var right = 0;
            if (
                !Sdl.GetWindowBordersSize(
                    Handle,
                    top.AsRef(),
                    left.AsRef(),
                    bottom.AsRef(),
                    right.AsRef()
                )
            )
            {
                Sdl.ThrowError();
            }

            return new Rectangle<float>(
                ca.Origin.X - left,
                ca.Origin.Y + top,
                ca.Size.X + left + right,
                ca.Size.Y + top + bottom
            );
        }
        set
        {
            var top = 0;
            var left = 0;
            var bottom = 0;
            var right = 0;
            if (
                IsSurfaceInitialized
                && !Sdl.GetWindowBordersSize(
                    Handle,
                    top.AsRef(),
                    left.AsRef(),
                    bottom.AsRef(),
                    right.AsRef()
                )
            )
            {
                Sdl.ThrowError();
            }

            ClientArea = new Rectangle<float>(
                value.Origin.X + left,
                value.Origin.Y - top,
                value.Size.X - left - right,
                value.Size.Y - top - bottom
            );
        }
    }

    public Rectangle<float> ClientArea
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
            }

            var x = 0;
            var y = 0;
            var width = 0;
            var height = 0;
            if (!Sdl.GetWindowPosition(Handle, x.AsRef(), y.AsRef()))
            {
                Sdl.ThrowError();
            }

            if (!Sdl.GetWindowSize(Handle, width.AsRef(), height.AsRef()))
            {
                Sdl.ThrowError();
            }

            return field = new Rectangle<float>(x, y, width, height);
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if (field == value)
            {
                return;
            }

            if (
                field.Origin != value.Origin
                && !Sdl.SetWindowPosition(Handle, (int)value.Origin.X, (int)value.Origin.Y)
            )
            {
                Sdl.ThrowError();
            }

            if (
                field.Size != value.Size
                && !Sdl.SetWindowSize(Handle, (int)value.Size.X, (int)value.Size.Y)
            )
            {
                Sdl.ThrowError();
            }

            field = value;
        }
    } = new(-1, -1, 640, 480);

    public event Action<WindowCoordinatesEvent>? CoordinatesChanged;

    public bool IsCloseRequested
    {
        get;
        set
        {
            var prev = field;
            field = value;
            if (!prev && value)
            {
                CloseRequested?.Invoke(new WindowToggleEvent(surface, true));
            }
        }
    }

    public bool IsVisible
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowToggleEvent>? CloseRequested;

    public bool IsFocused
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowToggleEvent>? FocusChanged;

    public string Title
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
            }

            var title = Sdl.GetWindowTitle(Handle);
            if (title == nullptr)
            {
                Sdl.ThrowError();
            }

            return field = title.ReadToString();
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if (!Sdl.SetWindowTitle(Handle, value))
            {
                Sdl.ThrowError();
            }

            field = value;
        }
    } = Assembly.GetEntryAssembly()?.GetName().Name ?? "Silk.NET Application";

    public WindowState State
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowStateEvent>? StateChanged;

    public WindowBorder Border
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool IsTopMost
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowFileEvent>? FileDrop;

    public bool TrySetIcon(WindowIconVariants icon) => throw new NotImplementedException();

    private void InitializeWindow(uint props)
    {
        if (
            !Sdl.SetStringProperty(props, Sdl.PropWindowCreateTitleString, Title)
            || !Sdl.SetNumberProperty(
                props,
                Sdl.PropWindowCreateWidthNumber,
                (long)ClientArea.Size.X
            )
            || !Sdl.SetNumberProperty(
                props,
                Sdl.PropWindowCreateHeightNumber,
                (long)ClientArea.Size.Y
            )
        )
        {
            Sdl.ThrowError();
        }

        // TODO borders
        if (
            !Sdl.SetNumberProperty(
                props,
                Sdl.PropWindowCreateFlagsNumber,
                Sdl.GetNumberProperty(props, Sdl.PropWindowCreateFlagsNumber, 0)
                    | (long)Sdl.WindowResizable
            )
        )
        {
            Sdl.ThrowError();
        }

        if (!IsWindowEnabled)
        {
            return;
        }
    }
}
