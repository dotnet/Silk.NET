// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
        UnboundedTargetList = [unboundedPointerTarget];
        _allTargets.AddRange(UnboundedTargetList);
        for (var i = 0; i < EnumInfo<PointerButton>.UniqueValues.Count; i++)
        {
            var button = EnumInfo<PointerButton>.UniqueValues[i];
            _buttons.Add(new Button<PointerButton>(button, false, 0f));
        }
    }

    protected ref Button<PointerButton> GetButtonRef(PointerButton button)
    {
        var index = EnumInfo<PointerButton>.ValueIndexOfUnnamed(button);
        _buttons.EnsureCapacity(index + 1);

        while (index >= _buttons.Count)
        {
            _buttons.Add(new Button<PointerButton>(button, false, 0f));
        }

        var span = CollectionsMarshal.AsSpan(_buttons);
        return ref span[index];
    }


    private readonly List<Button<PointerButton>> _buttons = [];
    protected ButtonReadOnlyList<PointerButton> Buttons => new(_buttons);
    protected InputReadOnlyList<TargetPoint> Points => new(_points);
    private readonly List<TargetPoint> _points = [];
    protected void ClearPoints() => _points.Clear();

    public abstract PointerState State { get; }

    public IReadOnlyList<IPointerTarget> Targets => _allTargets;

    /// <summary>
    /// True if the device only supports one point - e.g., a mouse.<br/>
    /// False otherwise - e.g., a multitouch screen.
    /// </summary>
    protected abstract bool OnePointOnly { get; }

    protected bool TryGetPointIndexForTarget(IPointerTarget? target, out int index, int? touchId = null)
    {
        if (touchId != null && !OnePointOnly)
        {
            throw new InvalidOperationException("Cannot get single point index for target " +
                                                "when device supports multiple points per-target");
        }

        target ??= _unboundedPointerTarget;
        touchId ??= 0;

        for (var i = 0; i < _points.Count; i++)
        {
            var point = GetPointRef(i);
            if (point.Target == target && point.Id == touchId.Value)
            {
                index = i;
                return true;
            }
        }

        index = -1;
        return false;
    }

    protected void AddPoint(in TargetPoint point)
    {
        if (OnePointOnly)
        {
            ClearPoints();
        }

        _points.Add(point);
        RepopulateActiveTargets();
    }

    protected void RemovePoint(int index)
    {
        _points.RemoveAt(index);
        RepopulateActiveTargets();
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
    private static Ray3D<float> ConstructRay(in Vector3 pos, Vector3D<float>? direction = null)
    {
        return new Ray3D<float>(pos.ToGeneric(), direction ?? Vector3D<float>.UnitZ);
    }

    protected void SetTargetPoint(uint? windowId, in Vector3 pos, float pressure, int? touchId = null, Ray3D<float>? ray = null)
    {
        windowId ??= _previousWindowId;
        _ = Backend.TryGetPointerTargetForWindow(windowId.Value, out var windowTarget);

        if (TryGetPointIndexForTarget(windowTarget, out var index, touchId))
        {
            ref var point = ref GetPointRef(index);
            UpdateTargetPointPosition(ref point, pos, windowTarget);
            if (ray != null)
            {
                UpdateTargetPointRay(ref point, ray.Value, windowTarget);
            }

        }
        else
        {
            AddPoint(ToTargetPoint(pos, pressure, windowTarget, touchId ?? 0, ray));
        }

#if DEBUG
        if (_previousWindowId != windowId)
        {
            InputLog.Warn($"Mouse window changed from {_previousWindowId} to {windowId}");
        }
#endif

        _previousWindowId = windowId.Value;
    }
    private uint _previousWindowId;

    /// <summary>
    ///
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="pressure"></param>
    /// <param name="windowTarget">If null, will be considered unbounded</param>
    /// <param name="touchId">The unique ID of the touch/pointer point, persisting through its lifetime</param>
    /// <param name="ray">The point in pre-translated 3d space the pointer is pointing from. e.g. pen orientation and position</param>
    /// <param name="direction"></param>
    /// <returns></returns>
    protected TargetPoint ToTargetPoint(in Vector3 pos, float pressure, IPointerTarget? windowTarget, int touchId, in Ray3D<float>? ray = null, in Vector3D<float>? direction = null)
    {
        if (windowTarget is null || windowTarget == _unboundedPointerTarget)
        {
            return new TargetPoint(touchId,
                Flags: TargetPointFlags.NotPointingAtTarget,
                Position: pos,
                NormalizedPosition: default,
                Pointer: ray ?? ConstructRay(pos, direction),
                Pressure: pressure,
                Target: _unboundedPointerTarget
            );
        }

        var bounds = windowTarget.Bounds;
        var min = bounds.Min.ToSystem();
        var max = bounds.Max.ToSystem();

        return new TargetPoint(
            Id: 0, // todo - use a unique id
            Flags: TargetPointFlags.PointingAtTarget,
            Position: pos,
            NormalizedPosition: (pos - min) / (max - min),
            Pointer: ray ?? ConstructRay(pos, direction),
            Pressure: pressure,
            Target: windowTarget
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void UpdateTargetPointPosition(ref TargetPoint point, in Vector3 pos, IPointerTarget? windowTarget)
    {
        point = ToTargetPoint(pos, point.Pressure, windowTarget, point.Id, point.Pointer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void UpdateTargetPointRay(ref TargetPoint point, Ray3D<float> ray, IPointerTarget? windowTarget)
    {
        point = ToTargetPoint(point.Position, point.Pressure, windowTarget, point.Id, ray);
    }

    protected void SetPointPressure(int index, float pressure)
    {
        ref var point = ref GetPointRef(index);
        point = point with { Pressure = pressure };
    }

    protected float GetPointPressure(int index) => GetPointRef(index).Pressure;

    protected void SetPointXTilt(int index, float xTilt)
    {
        ref var point = ref GetPointRef(index);
        point = point with { Pointer = point.Pointer with { Direction = point.Pointer.Direction with { X = xTilt } } };
    }

    protected void SetPointYTilt(int index, float yTilt)
    {
        ref var point = ref GetPointRef(index);
        point = point with { Pointer = point.Pointer with { Direction = point.Pointer.Direction with { Y = yTilt } } };
    }

    protected void SetPointTwist(int index, float twist)
    {
        ref var point = ref GetPointRef(index);
        point = point with { Pointer = point.Pointer with { Direction = point.Pointer.Direction with { Z = twist} } };
    }

    protected void SetPointDistance(int index, float distance01)
    {
        ref var point = ref GetPointRef(index);
        point = point with {
            Pointer = point.Pointer with { Origin = point.Pointer.Origin with { Z = distance01 } }
        };
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

    protected void SetGripPressure(float pressure) => State.GripPressure = pressure;

    protected void SetAllPointsPressure(float pressure)
    {
        for (var i = 0; i < _points.Count; i++)
        {
            SetPointPressure(i, pressure);
        }
    }

    protected void AddButtonEvent(PointerButton button, bool isDown, float? pressure = null)
    {
        pressure ??= isDown ? 1.0f : 0.0f;
        var idx = EnumInfo<PointerButton>.ValueIndexOfUnnamed(button);
        _buttons[idx] = new Button<PointerButton>(button, isDown, pressure.Value);
    }

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

    protected IReadOnlyList<IPointerTarget> ActiveTargets => _activeTargets;
    private readonly List<IPointerTarget> _activeTargets = [];
    private readonly List<IPointerTarget> _allTargets = [];
    private readonly IPointerTarget _unboundedPointerTarget;
    protected IReadOnlyList<IPointerTarget> UnboundedTargetList { get; }

    private readonly Queue<MouseScrollEvent> _scrollEvents = new();
    private readonly Queue<PointChangedEvent> _pointEvents = new();
    private readonly Queue<PointerClickEvent> _clickEvents = new();
    private readonly Queue<PointerGripChangedEvent> _gripEvents = new();
    private readonly Queue<PointerTargetChangedEvent> _targetEvents = new();
}
