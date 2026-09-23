// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal abstract partial class SdlPointerDevice
{
    private ISimulatedPointerTarget? _falseTarget;
    private readonly List<IPointerTarget> _myPointerTargets = new();

    private unsafe ref TargetPoint CreateOrUpdateTargetPoint(IPointerTarget target, long timestamp, ulong sdlTimestamp,
        uint touchId,
        in Vector3? positionOnTarget, Ray3D<float>? ray, float? pressure, out TargetPoint? oldPoint)
    {
        if (touchId != 0 && OnePointOnly)
        {
            throw new InvalidOperationException(
                "A single-point device cannot have multiple points per-target, so the " +
                "provided touchId must be 0.");
        }

        AddPointerTargetIfNew();

        int? pointIndex = null;
        int? defaultIndex = null;

        var actualPointsSpan = CollectionsMarshal.AsSpan(_actualPoints);
        for (var i = 0; i < actualPointsSpan.Length; i++)
        {
            ref readonly var candidatePoint = ref actualPointsSpan[i];
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
            pointIndex = defaultIndex ?? _actualPoints.Count;
            EnsurePointsListCapacity(pointIndex.Value, _actualPoints);
            actualPointsSpan = CollectionsMarshal.AsSpan(_actualPoints);
            isNewPoint = true;
        }
        else
        {
            isNewPoint = false;
        }

        ref var point = ref actualPointsSpan[pointIndex.Value];

        // note: a null oldPoint means this is a new point
        // see PointChangedEvent for more info
        oldPoint = isNewPoint ? null : point;

        point = ToTargetPoint(
            target: target,
            touchId: *(int*)&touchId,
            posOnTarget: positionOnTarget ?? point.Position,
            pressure: pressure ?? point.Pressure,

            // if a ray is provided, use it. otherwise, if it's a new point, use the default ray.
            // if it's a pre-existing point, use the existing ray.
            ray: ray ?? (isNewPoint
                ? new Ray3D<float>(origin: Vector3D<float>.Zero, direction: new Vector3D<float>(0, 0, 1))
                : point.Pointer));

        return ref point;

        void AddPointerTargetIfNew()
        {
            for (var i = 0; i < _myPointerTargets.Count; ++i)
            {
                if (ReferenceEquals(_myPointerTargets[i], target))
                {
                    return;
                }
            }

            _myPointerTargets.Add(target);
            var bounds = target.Bounds;
            TargetEvents.Enqueue(
                item: new PointerTargetChangedEvent(Pointer: this,
                    Timestamp: timestamp,
                    Target: target,
                    IsAdded: true,
                    OldBounds: default,
                    NewBounds: bounds),
                sdlTimestamp: sdlTimestamp);
        }
    }

    /// <summary>
    /// Creates a target point
    /// </summary>
    /// <param name="posOnTarget">Position projected to target-space</param>
    /// <param name="pressure">Touch/etc point pressure</param>
    /// <param name="target">The target being pointed at</param>
    /// <param name="touchId">The unique ID of the touch/pointer point, persisting through its lifetime</param>
    /// <param name="ray">A ray that determines the final point on the target</param>
    private static TargetPoint ToTargetPoint(in Vector3 posOnTarget, float pressure, IPointerTarget target, int touchId,
        Ray3D<float> ray)
    {
        var bounds = target.Bounds;
        var min = bounds.Min.ToSystem();
        var max = bounds.Max.ToSystem();
        var diff3 = max - min;
        var normalizedPosition = (posOnTarget - min) / diff3;

        if (!float.IsFinite(normalizedPosition.X))
        {
            normalizedPosition.X = 0;
        }

        if (!float.IsFinite(normalizedPosition.Y))
        {
            normalizedPosition.Y = 0;
        }

        if (!float.IsFinite(normalizedPosition.Z))
        {
            normalizedPosition.Z = 0;
        }

        return new TargetPoint(touchId,
            Flags: TargetPointFlags.PointingAtTarget,
            Position: posOnTarget,
            NormalizedPosition: normalizedPosition,
            Pointer: ray,
            Pressure: pressure,
            Target: target
        );
    }

    protected void SetPointLookAtTarget(uint? touchId, IPointerTarget target, bool lookAt, ulong sdlTimestamp,
        long timestamp)
    {
        touchId = ValidateTouchId(touchId);
        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            sdlTimestamp: sdlTimestamp,
            touchId: touchId.Value,
            positionOnTarget: null,
            ray: null,
            pressure: null,
            oldPoint: out _);
        point = point with {
            Flags = lookAt ? TargetPointFlags.PointingAtTarget : TargetPointFlags.NotPointingAtTarget
        };
    }

    /// <summary>
    /// Adds or updates a point.
    /// </summary>
    /// <param name="touchId">Touch id. Must be null for single-point-only devices (e.g. a mouse)</param>
    /// <param name="target">The target the touch applies to</param>
    /// <param name="pos">The touch position. Set null if it has not changed</param>
    /// <param name="pressure">The pressure, set null if it has not changed</param>
    /// <param name="isDown">"Down" status. Set null if has not changed</param>
    /// <param name="ray">The ray - set null if has not changed or is simply computed in 2D without extra calculation</param>
    /// <param name="sdlTimestamp"></param>
    /// <param name="timestamp"></param>
    /// <exception cref="InvalidOperationException"></exception>
    protected void AddOrUpdatePoint(uint? touchId, IPointerTarget target, in Vector3? pos, float? pressure,
        bool? isDown,
        Ray3D<float>? ray, ulong sdlTimestamp, long timestamp)
    {
        if (pos == null && pressure == null && isDown == null && ray == null)
        {
            throw new InvalidOperationException("At least one parameter must have a value");
        }

        touchId = ValidateTouchId(touchId);

        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            sdlTimestamp: sdlTimestamp,
            touchId: touchId.Value,
            positionOnTarget: pos,
            ray: ray,
            pressure: pressure,
            oldPoint: out var oldPoint);

        PointEvents.Enqueue(new PointChangedEvent(this, timestamp, OldPoint: oldPoint,
            NewPoint: point), sdlTimestamp);

        if (isDown is false)
        {
            // point was actually removed - after that point changed event, we should remove it
            // note - a null newPoint means the point was removed
            var previous = point;
            var actualPoints = CollectionsMarshal.AsSpan(_actualPoints);
            for (var i = 0; i < actualPoints.Length; i++)
            {
                ref var candidatePoint = ref actualPoints[i];
                if (candidatePoint.Id == previous.Id)
                {
                    candidatePoint = default;
                }
            }

            PointEvents.Enqueue(
                item: new PointChangedEvent(
                    Pointer: this,
                    Timestamp: timestamp,
                    OldPoint: previous,
                    NewPoint: point),
                sdlTimestamp: sdlTimestamp);
        }
    }

    private uint ValidateTouchId(uint? touchId)
    {
        if (OnePointOnly)
        {
            return touchId != null
                ? throw new InvalidOperationException(
                    "A single-point device cannot have a touchId - it must be null.")
                : 0u;
        }

        return touchId ?? throw new ArgumentNullException($"TouchId cannot be null for device {this}.");
    }

    protected void UpdatePointRay(uint? touchId, IPointerTarget target, float? xTilt, float? yTilt, float? zTwist,
        float? distance,
        ulong sdlTimestamp, long timestamp)
    {
        if (xTilt == null && yTilt == null && zTwist == null && distance == null)
        {
            throw new InvalidOperationException("At least one parameter must have a value");
        }

        touchId = ValidateTouchId(touchId);

        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            sdlTimestamp: sdlTimestamp,
            touchId: touchId.Value,
            positionOnTarget: null,
            ray: null,
            pressure: null,
            oldPoint: out var oldPoint);

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

        PointEvents.Enqueue(new PointChangedEvent(this, timestamp, OldPoint: oldPoint,
            NewPoint: point), sdlTimestamp);
    }

    private static void EnsurePointsListCapacity(int index, List<TargetPoint> actualPoints)
    {
        actualPoints.EnsureCapacity(index + 1);
        while (index >= actualPoints.Count)
        {
            actualPoints.Add(default);
        }
    }

    public void TargetDestroyed(IPointerTarget target, long timestamp, ulong sdlTimestamp)
    {
        if (_myPointerTargets.Remove(target))
        {
            var bounds = target.Bounds;
            TargetEvents.Enqueue(new PointerTargetChangedEvent(this, timestamp, target, false, bounds, bounds),
                sdlTimestamp);
        }
    }


    public void TargetChanged(SdlWindowTarget target, long timestamp, ulong sdlTimestamp, in Box3D<float> oldBounds)
    {
        if (_myPointerTargets.Contains(target))
        {
            TargetEvents.Enqueue(new PointerTargetChangedEvent(
                    Pointer: this,
                    Timestamp: timestamp,
                    Target: target,
                    IsAdded: null,
                    OldBounds: oldBounds,
                    NewBounds: target.Bounds),
                sdlTimestamp);
        }
    }

    // remaps the given point to the given pointer target
    private static TargetPoint TranslatePoint(ref readonly TargetPoint pt, IPointerTarget target)
    {
        Debug.Assert(pt.Target != target);
        var oldBounds = pt.Target.Bounds;
        var newBounds = target.Bounds;

        var oldBoundsMin = Unsafe.As<Vector3D<float>, Vector3>(ref oldBounds.Min);
        oldBoundsMin &= Vector3.IsFinite(oldBoundsMin);

        var newBoundsMin = Unsafe.As<Vector3D<float>, Vector3>(ref newBounds.Min);
        newBoundsMin &= Vector3.IsFinite(newBoundsMin);

        // both bounds exist in the same coordinate space - the new position needs to be translated to be relative
        // to the new target
        var rawPtPosition = pt.Position + oldBoundsMin;
        var newPtPosition = rawPtPosition - newBoundsMin;

        var newBoundsMax = Unsafe.As<Vector3D<float>, Vector3>(ref newBounds.Max);
        newBoundsMax &= Vector3.IsFinite(newBoundsMax);

        // normalized pos = newPos / newBoundsSize
        var newNormalizedPos = newPtPosition / (newBoundsMax - newBoundsMin);
        newNormalizedPos &= Vector3.IsFinite(newNormalizedPos);

        return new TargetPoint(
            Id: pt.Id,
            Flags: TargetPointFlags.NotPointingAtTarget, // todo - should this be actually measured?
            Position: newPtPosition,
            NormalizedPosition: newNormalizedPos,
            Pointer: pt.Pointer,
            Pressure: pt.Pressure,
            Target: target);
    }
}
