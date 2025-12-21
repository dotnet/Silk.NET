// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// A base class for SDL input devices that operate in terms of a window's or DWMs bounds.
/// </summary>
internal abstract class SdlPointerDevice : SdlDevice, IPointerDevice
{
    protected SdlPointerDevice(SdlInputBackend backend, nint silkId,
        uint sdlDeviceId, IPointerTarget unboundedPointerTarget) : base(backend, silkId, sdlDeviceId)
    {
        _unboundedPointerTarget = unboundedPointerTarget;
        UnboundedTargetList = [unboundedPointerTarget];
        _allTargets.AddRange(UnboundedTargetList);
        for (var i = 0; i < EnumInfo<PointerButton>.UniqueValues.Count; i++)
        {
            var button = EnumInfo<PointerButton>.UniqueValues[i];
            var pressed = IsPointerButtonPressedSdl(button, GetButtonMaskSdl());
            _buttons.Add(new Button<PointerButton>(button, pressed, pressed ? 1.0f : 0.0f));
        }


    }

    protected abstract uint GetButtonMaskSdl();

    private readonly List<Button<PointerButton>> _buttons = [];
    protected ButtonReadOnlyList<PointerButton> Buttons => new(_buttons);
    protected InputReadOnlyList<TargetPoint> Points => new(_points);
    private readonly List<TargetPoint> _points = new();
    protected void ClearPoints() => _points.Clear();

    public abstract PointerState State { get; }

    public IReadOnlyList<IPointerTarget> Targets => _allTargets;

    /// <summary>
    /// True if the device only supports one point - e.g., a mouse.<br/>
    /// False otherwise - e.g., a multitouch screen.
    /// </summary>
    protected abstract bool OnePointOnly { get; }


    protected static bool IsPointerButtonPressedSdl(PointerButton button, uint state)
    {
        var index = EnumInfo<PointerButton>.ValueIndexOf(button);
        if (index is < 0 or >= 32)
        {
            return false;
        }

        return (state & (1 << index)) != 0;
    }

    protected bool TryGetPointIndexForTarget(IPointerTarget? target, out int index)
    {
        if (!OnePointOnly)
        {
            throw new InvalidOperationException("Cannot get single point index for target " +
                                                "when device supports multiple points per-target");
        }

        target ??= _unboundedPointerTarget;

        for (var i = 0; i < _points.Count; i++)
        {
            if (_points[i].Target == target)
            {
                index = i;
                return true;
            }
        }

        index = -1;
        return false;
    }


    protected void UpdatePoint(in TargetPoint point, int index)
    {
        // todo - optimize using ref and array
        var existing = _points[index];
        if (existing != default && existing.Target != point.Target)
        {
            throw new InvalidOperationException("Cannot update point with a different target");
        }

        _points[index] = point;
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

    /// <summary>
    ///
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="pressure"></param>
    /// <param name="windowTarget">If null, will be considered unbounded</param>
    /// <returns></returns>
    protected TargetPoint ToTargetPoint(Vector3 pos, float pressure, IPointerTarget? windowTarget)
    {
        if (windowTarget is null || windowTarget == _unboundedPointerTarget)
        {
            return new TargetPoint(0, // todo: use a unique id
                Flags: TargetPointFlags.NotPointingAtTarget,
                Position: pos,
                NormalizedPosition: default,
                Pointer: default, // todo - standardize this pointer as a proper ray
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
            Pointer: default, // todo- standardize this pointer as a proper ray
            Pressure: pressure,
            Target: windowTarget
        );
    }

    protected void SetPointPressure(int index, float pressure) => _points[index] = _points[index] with { Pressure = pressure };

    protected void SetAllPointsPressure(float pressure)
    {
        for (var i = 0; i < _points.Count; i++)
        {
            SetPointPressure(i, pressure);
        }
    }


    protected void AddButtonEvent(PointerButton button, bool isDown, float? pressure = null)
    {
        pressure ??= isDown ? 1.0f : 0.0f;;
        var idx = EnumInfo<PointerButton>.ValueIndexOfUnnamed(button);
        _buttons[idx] = new Button<PointerButton>(button, isDown, pressure.Value);

    }

    protected IReadOnlyList<IPointerTarget> ActiveTargets => _activeTargets;
    private readonly List<IPointerTarget> _activeTargets = [];
    private readonly List<IPointerTarget> _allTargets = [];

    private readonly IPointerTarget _unboundedPointerTarget;
    protected IReadOnlyList<IPointerTarget> UnboundedTargetList { get; }
}
