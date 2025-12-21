using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IPointerDevice"/>s from which input events can be received.
/// </summary>
public sealed class Pointers
    : InputContextDeviceList<IPointerDevice>,
        IMouseInputHandler,
        IPointerInputHandler
{
    private long _doubleClickTime;
    private float _doubleClickRange;
    private List<ClickData>? _clicks;

    internal Pointers(InputContext ctx)
        : base(ctx) => ClickConfiguration = PointerClickConfiguration.Default;

    /// <summary>
    /// Gets or sets the configuration that denotes the behaviour of <see cref="Click"/>/<see cref="DoubleClick"/>.
    /// </summary>
    public PointerClickConfiguration ClickConfiguration
    {
        get => new((int)((double)_doubleClickTime / Stopwatch.Frequency * 1000), _doubleClickRange);
        set =>
            (_doubleClickTime, _doubleClickRange) = (
                (long)((double)value.DoubleClickTime / 1000 * Stopwatch.Frequency),
                value.DoubleClickRange
            );
    }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the pointer device changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<PointerButton>>? ButtonChanged;

    /// <summary>
    /// Raised when one or more <see cref="ButtonChanged"/> events indicate a single click as defined by the
    /// <see cref="ClickConfiguration"/>.
    /// </summary>
    public event Action<PointerClickEvent>? Click;

    /// <summary>
    /// Raised when one or more <see cref="ButtonChanged"/> events indicate a double click as defined by the
    /// <see cref="ClickConfiguration"/>.
    /// </summary>
    public event Action<PointerClickEvent>? DoubleClick;

    /// <summary>
    /// Raised when a <see cref="TargetPoint"/>'s state changes (e.g. mouse move).
    /// </summary>
    public event Action<PointChangedEvent>? PointChanged;

    /// <summary>
    /// Raised when a user scrolls using a pointer device's mouse wheel.
    /// </summary>
    public event Action<MouseScrollEvent>? MouseScroll;

    /// <summary>
    /// Raised when a "target" at which the user can point using a pointer device changes.
    /// </summary>
    public event Action<PointerTargetChangedEvent>? TargetChanged;

    /// <summary>
    /// Raised when the user adjusts their grip on the pointer device.
    /// </summary>
    public event Action<PointerGripChangedEvent>? GripChanged;

    void IButtonInputHandler<PointerButton>.HandleButtonChanged(
        ButtonChangedEvent<PointerButton> @event
    ) => HandleButtonChanged(@event);

    internal void HandleButtonChanged(ButtonChangedEvent<PointerButton> @event)
    {
        if (@event.Device is not IPointerDevice device)
        {
            return;
        }

        ButtonChanged?.Invoke(@event);
        if (@event.Previous.IsDown || !@event.Button.IsDown)
        {
            return;
        }

        foreach (var target in device.Targets)
        {
            var pointCnt = target.GetPointCount(device);
            for (var i = 0; i < pointCnt; i++)
            {
                HandlePointerDown(
                    device,
                    target.GetPoint(device, i),
                    @event.Button.Name,
                    @event.Timestamp
                );
            }
        }
    }

    void IMouseInputHandler.HandleScroll(MouseScrollEvent @event) => HandleScroll(@event);

    internal void HandleScroll(MouseScrollEvent @event) => MouseScroll?.Invoke(@event);

    void IPointerInputHandler.HandleTargetChanged(PointerTargetChangedEvent @event) =>
        HandleTargetChanged(@event);

    internal void HandleTargetChanged(PointerTargetChangedEvent @event)
    {
        TargetChanged?.Invoke(@event);
        if (_clicks is null || @event.IsAdded is not false)
        {
            return;
        }

        var clicks = CollectionsMarshal.AsSpan(_clicks);
        for (var i = 0; i < clicks.Length; i++)
        {
            ref var click = ref clicks[i];
            if (click.FirstClickPosition.Target != @event.Target)
            {
                continue;
            }

            // Raise a click event for posterity.
            HandleDoubleClickExceedsParameters(ref click);
            _clicks.RemoveAt(i--);

            // SAFETY: We have to replace the span now as the RemoveAt could've in theory reallocated.
            clicks = CollectionsMarshal.AsSpan(_clicks);
        }
    }

    void IPointerInputHandler.HandlePointChanged(PointChangedEvent @event) =>
        HandlePointChanged(@event);

    internal void HandlePointChanged(PointChangedEvent @event)
    {
        PointChanged?.Invoke(@event);
        if (_clicks is null || @event is not { OldPoint: not null, NewPoint: { } @new })
        {
            return;
        }

        var span = CollectionsMarshal.AsSpan(_clicks);
        for (var i = 0; i < _clicks.Count; i++)
        {
            ref var click = ref span[i];
            if (!click.IsMatch(@event.Pointer, in @new))
            {
                continue;
            }

            if (!click.HasMovedTooFar(_doubleClickRange, @new.Position))
            {
                return;
            }

            HandleDoubleClickExceedsParameters(ref click);
            _clicks.RemoveAt(i);
            return;
        }
    }

    void IPointerInputHandler.HandleGripChanged(PointerGripChangedEvent @event) =>
        HandleGripChanged(@event);

    internal void HandleGripChanged(PointerGripChangedEvent @event) => GripChanged?.Invoke(@event);

    private record struct ClickData(
        IPointerDevice Device,
        PointerButton? FirstClickButton,
        TargetPoint FirstClickPosition,
        long? FirstClickTime,
        bool IsFirstClick
    )
    {
        public bool IsMatch(IPointerDevice device, ref readonly TargetPoint point) =>
            point.Id == FirstClickPosition.Id
            && Device == device
            && point.Target == FirstClickPosition.Target;

        public bool HasMovedTooFar(float range, Vector3 position)
        {
            var fcp = FirstClickPosition.Position;
            return MathF.Abs(position.X - fcp.X) >= range
                && MathF.Abs(position.Y - fcp.Y) >= range
                && MathF.Abs(position.Z - fcp.Z) >= range;
        }
    }

    [MemberNotNull(nameof(_clicks))]
    private ref ClickData GetClickData(
        IPointerDevice device,
        ref readonly TargetPoint point,
        out int idx
    )
    {
        idx = 0;
        foreach (ref var ret in CollectionsMarshal.AsSpan(_clicks ??= []))
        {
            if (ret.IsMatch(device, in point))
            {
                return ref ret;
            }

            idx++;
        }

        _clicks.Add(
            new ClickData(
                device,
                null,
                default(TargetPoint) with
                {
                    Target = point.Target,
                    Id = point.Id,
                },
                null,
                true
            )
        );
        return ref CollectionsMarshal.AsSpan(_clicks)[idx];
    }

    private void HandlePointerDown(
        IPointerDevice device,
        TargetPoint point,
        PointerButton button,
        long timestamp
    )
    {
        if ((_clicks is null && DoubleClick is null && Click is null) || point.Target is null)
        {
            return;
        }

        ref var click = ref GetClickData(device, in point, out var idx);
        if (click.IsFirstClick || (click.FirstClickButton is { } firstBtn && firstBtn != button))
        {
            // This is the first click with the given mouse button.
            var time = click.FirstClickTime;
            click.FirstClickTime = null;

            if (
                click is { IsFirstClick: false, FirstClickButton: { } prevBtn }
                && time is { } clickTime
            )
            {
                // Only the mouse buttons differ so treat last click as a single click.
                Click?.Invoke(
                    new PointerClickEvent(device, clickTime, click.FirstClickPosition, prevBtn)
                );
            }
        }
        else
        {
            // This is the second click with the same mouse button.
            if (click.FirstClickTime is { } fct && timestamp - fct <= _doubleClickTime)
            {
                // Within the maximum double click time.
                click.FirstClickTime = null;
                if (!click.HasMovedTooFar(_doubleClickRange, point.Position))
                {
                    // Second click was in time and in range -> double click.
                    DoubleClick?.Invoke(new PointerClickEvent(device, timestamp, point, button));

                    // SAFETY: Must not use the click ref from now on! Returning instantly.
                    _clicks.RemoveAt(idx);
                    return;
                }

                // Second click was in time but outside range -> single click.
                // The second click is another "first click".
                Click?.Invoke(new PointerClickEvent(device, timestamp, point, button));
            }
            else
            {
                // The double click time elapsed.

                // If Update() would have detected the time elapse before,
                // it would have set _firstClick back to true and we won't be here.
                // Therefore Update() has not detected time elapse here and we have
                // to handle it.
                HandleDoubleClickExceedsParameters(ref click);
            }
        }

        // Process the first click. We process the second click as another "first click" if:
        // - the double click time elapsed
        // - the pointer moved too much before doing the second click
        ProcessFirstClick(ref click, button, point, timestamp);
    }

    private static void ProcessFirstClick(
        ref ClickData click,
        PointerButton button,
        TargetPoint point,
        long timestamp
    )
    {
        click.IsFirstClick = false; // for next time...
        click.FirstClickButton = button;
        click.FirstClickPosition = point;
        click.FirstClickTime = timestamp;
    }

    private void HandleDoubleClickExceedsParameters(ref ClickData click)
    {
        click.FirstClickTime = null;
        click.IsFirstClick = true;
        if (click is { FirstClickButton: { } fcb, FirstClickTime: { } fct })
        {
            Click?.Invoke(new PointerClickEvent(click.Device, fct, click.FirstClickPosition, fcb));
        }
    }

    internal void HandleUpdate()
    {
        if (_clicks is null)
        {
            return;
        }

        var updateTime = Stopwatch.GetTimestamp();
        var clicks = CollectionsMarshal.AsSpan(_clicks);
        for (var i = 0; i < clicks.Length; i++)
        {
            ref var click = ref clicks[i];
            if (click.FirstClickTime is not { } fct || updateTime - fct <= _doubleClickTime)
            {
                continue;
            }

            // No second click in maximum double click time.
            HandleDoubleClickExceedsParameters(ref click);
            _clicks.RemoveAt(i--);

            // SAFETY: We have to replace the span now as the RemoveAt could've in theory reallocated.
            clicks = CollectionsMarshal.AsSpan(_clicks);
        }
    }

    /// <inheritdoc />
    protected internal override void HandleDeviceConnectionChanged(ConnectionEvent @event)
    {
        base.HandleDeviceConnectionChanged(@event);
        if (_clicks is null || @event.IsConnected || @event.Device is not IPointerDevice)
        {
            return;
        }

        for (var i = 0; i < _clicks.Count; i++)
        {
            if (_clicks[i].Device != @event.Device)
            {
                continue;
            }

            _clicks.RemoveAt(i--);
        }
    }
}
