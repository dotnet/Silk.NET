// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// A base class for SDL input devices that operate in terms of a window's or DWMs bounds.
/// </summary>
internal abstract class SdlPointerDevice : SdlDevice, IPointerDevice
{
    protected SdlPointerDevice(SdlInputBackend backend, nint silkId,
        ulong sdlDeviceId, IPointerTarget unboundedPointerTarget) : base(backend, silkId, sdlDeviceId)
    {
        _unboundedPointerTarget = unboundedPointerTarget;
        _unboundedTargetList = [unboundedPointerTarget];
        _allTargets.AddRange(_unboundedTargetList);
        for (var i = 0; i < EnumInfo<PointerButton>.UniqueValues.Count; i++)
        {
            var button = EnumInfo<PointerButton>.UniqueValues[i];
            _buttons.Add(new Button<PointerButton>(button, false, 0f));
        }
    }

    protected void AddButtonEvent(PointerButton button, ulong sdlTimestamp, bool isDown, float? pressure = null)
    {
        pressure ??= isDown ? 1.0f : 0.0f;
        var idx = EnumInfo<PointerButton>.ValueIndexOfUnnamed(button);

        while (idx >= _buttons.Count)
        {
            _buttons.Add(_unknownButton);
        }

        var buttonSpan = CollectionsMarshal.AsSpan(_buttons);
        ref var myButton = ref buttonSpan[idx];
        var original = myButton;
        myButton = new Button<PointerButton>(button, isDown, pressure.Value);

        if (myButton != original)
        {
            _buttonEvents.Enqueue(new ButtonChangedEvent<PointerButton>(this, (long)sdlTimestamp, myButton, original));
        }
    }

    private static readonly Button<PointerButton> _unknownButton = new(PointerButton.Unknown, false, 0f);

    public override void FinalizeUpdate(SdlInputBackend.SilkEventQueues silkEvents)
    {
        while (_scrollEvents.TryDequeue(out var evt))
        {
            silkEvents.MouseScrollEvents.Enqueue(evt);
        }

        while (_pointEvents.TryDequeue(out var evt))
        {
            silkEvents.PointChangedEvents.Enqueue(evt);
        }

        while (_clickEvents.TryDequeue(out var evt))
        {
            silkEvents.PointerClickEvents.Enqueue(evt);
        }

        while (_gripEvents.TryDequeue(out var evt))
        {
            silkEvents.PointerGripChangedEvents.Enqueue(evt);
        }

        while (_targetEvents.TryDequeue(out var evt))
        {
            silkEvents.PointerTargetChangedEvents.Enqueue(evt);
        }
    }

    private ref Button<PointerButton> GetButtonRef(PointerButton button)
    {
        var index = EnumInfo<PointerButton>.ValueIndexOfUnnamed(button);
        _buttons.EnsureCapacity(index + 1);
        var span = CollectionsMarshal.AsSpan(_buttons);
        return ref span[index];
    }


    private readonly List<Button<PointerButton>> _buttons = new(EnumInfo<PointerButton>.UniqueValues.Count);
    protected ButtonReadOnlyList<PointerButton> Buttons => new(_buttons);
    protected InputReadOnlyList<TargetPoint> Points => new(_points);
    private readonly List<TargetPoint> _points = [];

    public abstract PointerState State { get; }

    public IReadOnlyList<IPointerTarget> Targets => _allTargets;

    /// <summary>
    /// True if the device only supports one point - e.g., a mouse.<br/>
    /// False otherwise - e.g., a multitouch screen.
    /// </summary>
    protected abstract bool OnePointOnly { get; }

    private unsafe ref TargetPoint CreateOrUpdateTargetPoint(IPointerTarget? target, uint touchId, in Vector3? positionOnTarget,
        Ray3D<float>? ray, float? pressure, out TargetPoint? oldPoint)
    {
        if (touchId != 0 && OnePointOnly)
        {
            throw new InvalidOperationException(
                "A single-point device cannot have multiple points per-target, so the " +
                "provided touchId must be 0.");
        }

        target ??= _unboundedPointerTarget;

        int? pointIndex = null;
        int? defaultIndex = null;

        for (var i = 0; i < _points.Count; i++)
        {
            var candidatePoint = GetPointRef(i);
            if (candidatePoint.Target == target && candidatePoint.Id == touchId)
            {
                pointIndex = i;
                break;
            }

            if (defaultIndex is null && candidatePoint == default)
            {
                defaultIndex = i;
            }
        }

        bool isNewPoint;
        if (pointIndex == null)
        {
            pointIndex = defaultIndex ?? _points.Count;
            isNewPoint = true;
        }
        else
        {
            isNewPoint = false;
        }

        ref var point = ref GetPointRef(pointIndex.Value);

        // note: a null oldPoint means this is a new point
        // see PointChangedEvent for more info
        oldPoint = isNewPoint ? null : point;

        point = ToTargetPoint(
            windowTarget: target,
            touchId: *(int*)&touchId,
            posOnTarget: positionOnTarget ?? point.Position,
            pressure: pressure ?? point.Pressure,

            // if a ray is provided, use it. otherwise, if it's a new point, use the default ray.
            // if it's a pre-existing point, use the existing ray.
            ray: ray ?? (isNewPoint
                ? new Ray3D<float>(origin: Vector3D<float>.Zero, direction: Vector3D<float>.UnitZ)
                : point.Pointer));

        return ref point;
    }

    private void RepopulateActiveTargets()
    {
        // todo - optimize target collection population
        _activeTargets.Clear();
        foreach (var point in _points)
        {
            if (!_activeTargets.Contains(point.Target!))
            {
                _activeTargets.Add(point.Target!);
                if (!_allTargets.Contains(point.Target!))
                {
                    _allTargets.Add(point.Target!);
                }
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Ray3D<float> ConstructRay(in Vector3 origin, Vector3? direction = null) =>
        ConstructRay(origin.ToGeneric(), direction?.ToGeneric());

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Ray3D<float> ConstructRay(in Vector3D<float> origin, Vector3D<float>? direction = null) =>
        new(origin, direction ?? Vector3D<float>.UnitZ);

    /// <summary>
    /// Adds or updates a point.
    /// </summary>
    /// <param name="touchId">Touch id. Must be null for single-point-only devices (e.g. a mouse)</param>
    /// <param name="windowId">The window id the touch applies to</param>
    /// <param name="pos">The touch position. Set null if it has not changed</param>
    /// <param name="pressure">The pressure, set null if it has not changed</param>
    /// <param name="isDown">"Down" status. Set null if has not changed</param>
    /// <param name="ray">The ray - set null if has not changed or is simply computed in 2D without extra calculation</param>
    /// <param name="isPositionInWindowSpace">True if the provided position (if present) is relative to the given window id</param>
    /// <exception cref="InvalidOperationException"></exception>
    protected void AddOrUpdatePoint(uint? touchId, uint? windowId, in Vector3? pos, float? pressure, bool? isDown,
        Ray3D<float>? ray, bool isPositionInWindowSpace)
    {
        if (pos == null && pressure == null && isDown == null && ray == null)
        {
            throw new InvalidOperationException("At least one parameter must have a value");
        }

        GetPointIdentifiers(ref touchId, windowId ?? _previousWindowId, out var windowTarget);

        if (pos != null)
        {
            if (windowId == null && isPositionInWindowSpace)
            {
                throw new InvalidOperationException("WindowId must be specified if position is in window space");
            }

            if (!isPositionInWindowSpace)
            {
                throw new NotImplementedException("Non-window space positions are not yet supported.");
            }
        }

        ref var point = ref CreateOrUpdateTargetPoint(windowTarget, touchId.Value, pos, ray, pressure, out var oldPoint);

        _pointEvents.Enqueue(new PointChangedEvent(this, Stopwatch.GetTimestamp(), OldPoint: oldPoint,
            NewPoint: point));

        if (isDown is false)
        {
            // point was actually removed - after that point changed event, we should remove it
            // note - a null newPoint means the point was removed
            var previous = point;
            for (int i = 0; i < _points.Count; i++)
            {
                ref var candidatePoint = ref GetPointRef(i);
                if (candidatePoint.Id == previous.Id)
                {
                    candidatePoint = default;
                }
            }
            _pointEvents.Enqueue(new PointChangedEvent(this, Stopwatch.GetTimestamp(), OldPoint: previous,
                NewPoint: point));
        }

        if (windowId != null && windowId.Value != _previousWindowId)
        {
#if DEBUG
            if (_previousWindowId != windowId)
            {
                InputLog.Warn($"Pointer window changed from {_previousWindowId} to {windowId}");
            }
#endif
            _previousWindowId = windowId.Value;
        }
    }

    private void GetPointIdentifiers([NotNull] ref uint? touchId, [DisallowNull] uint? windowId,
        out IPointerTarget? windowTarget)
    {
        touchId = ValidateTouchId(touchId);
        _ = Backend.TryGetPointerTargetForWindow(windowId.Value, out windowTarget);

        return;

        uint ValidateTouchId(uint? touchId)
        {
            if (OnePointOnly)
            {
                return touchId != null
                    ? throw new InvalidOperationException(
                        "A single-point device cannot have a touchId - it must be null.")
                    : 0;
            }

            return touchId ?? throw new ArgumentNullException($"TouchId cannot be null for device {this}.");
        }
    }


    /// <summary>
    /// Creates a target point
    /// </summary>
    /// <param name="posOnTarget">Position projected to target-space</param>
    /// <param name="pressure">Touch/etc point pressure</param>
    /// <param name="windowTarget">If null, will be considered unbounded</param>
    /// <param name="touchId">The unique ID of the touch/pointer point, persisting through its lifetime</param>
    /// <param name="ray">A ray that determines the final point on the target</param>
    private TargetPoint ToTargetPoint(in Vector3 posOnTarget, float pressure, IPointerTarget? windowTarget, int touchId,
        Ray3D<float> ray)
    {
        var hasTarget = windowTarget is not null;
        var flags = hasTarget ? TargetPointFlags.PointingAtTarget : TargetPointFlags.NotPointingAtTarget;

        Vector3 normalizedPositionOnTarget;

        if (hasTarget && windowTarget != _unboundedPointerTarget)
        {
            var bounds = windowTarget!.Bounds;
            var min = bounds.Min.ToSystem();
            normalizedPositionOnTarget = (posOnTarget - min) / (bounds.Max.ToSystem() - min);
        }
        else
        {
            normalizedPositionOnTarget = default;
        }

        return new TargetPoint(touchId,
            Flags: flags,
            Position: posOnTarget,
            NormalizedPosition: normalizedPositionOnTarget,
            Pointer: ray,
            Pressure: pressure,
            Target: windowTarget
        );
    }

    protected void AddMouseScrollEvent(Vector2 scrollWheelPosition, uint? windowId, Vector3? position, bool isMouseRelative)
    {
        if (this is not IMouse mouse)
        {
            throw new InvalidOperationException("This device does not support scrolling.");
        }

        uint? touchId = null;
        GetPointIdentifiers(ref touchId, windowId ?? _previousWindowId, out var windowTarget);

        ref var point = ref CreateOrUpdateTargetPoint(windowTarget, touchId.Value, null, null, null, out _);

        var previousScroll = _previousScrollWheelPosition ?? Vector2.Zero;

        _scrollEvents.Enqueue(new MouseScrollEvent(
            Mouse: mouse,
            Timestamp: Stopwatch.GetTimestamp(),
            Point: point,
            WheelPosition: scrollWheelPosition,
            Delta: scrollWheelPosition - previousScroll));

        _previousScrollWheelPosition = scrollWheelPosition;
    }

    private Vector2? _previousScrollWheelPosition;

    protected void UpdatePointRay(uint? touchId, float? xTilt, float? yTilt, float? zTwist, float? distance)
    {
        if (xTilt == null && yTilt == null && zTwist == null && distance == null)
        {
            throw new InvalidOperationException("At least one parameter must have a value");
        }

        GetPointIdentifiers(ref touchId, _previousWindowId, out var windowTarget);

        ref var point = ref CreateOrUpdateTargetPoint(windowTarget, touchId.Value, null, null, null, out var oldPoint);
        var ray = point.Pointer;
        xTilt ??= ray.Direction.X;
        yTilt ??= ray.Direction.Y;
        zTwist ??= ray.Direction.Z;
        distance ??= ray.Origin.Z;

        point = point with {
            Pointer = new Ray3D<float>(
                origin: ray.Origin with { Z = distance.Value },
                direction: new Vector3D<float>(xTilt.Value, yTilt.Value, zTwist.Value))
        };

        _pointEvents.Enqueue(new PointChangedEvent(this, Stopwatch.GetTimestamp(), OldPoint: oldPoint,
            NewPoint: point));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected void SetGripPressure(float pressure)
    {
        _gripEvents.Enqueue(new PointerGripChangedEvent(this, Stopwatch.GetTimestamp(), pressure,
            pressure - State.GripPressure));
        State.GripPressure = pressure;
    }


    private ref TargetPoint GetPointRef(int index)
    {
        _points.EnsureCapacity(index + 1);
        while (index >= _points.Count)
        {
            _points.Add(default);
        }

        var span = CollectionsMarshal.AsSpan(_points);
        return ref span[index];
    }

    private uint _previousWindowId;
    private readonly List<IPointerTarget> _activeTargets = [];
    private readonly List<IPointerTarget> _allTargets = [];
    private readonly IPointerTarget _unboundedPointerTarget;
    private readonly IReadOnlyList<IPointerTarget> _unboundedTargetList;

    private readonly Queue<MouseScrollEvent> _scrollEvents = new();
    private readonly Queue<PointChangedEvent> _pointEvents = new();
    private readonly Queue<PointerClickEvent> _clickEvents = new();
    private readonly Queue<ButtonChangedEvent<PointerButton>> _buttonEvents = new();
    private readonly Queue<PointerGripChangedEvent> _gripEvents = new();
    private readonly Queue<PointerTargetChangedEvent> _targetEvents = new();
}
