// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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

    private unsafe ref TargetPoint CreateOrUpdateTargetPoint(IPointerTarget target, long timestamp, uint touchId,
        in Vector3? positionOnTarget, Ray3D<float>? ray, float? pressure, out TargetPoint? oldPoint)
    {
        if (touchId != 0 && OnePointOnly)
        {
            throw new InvalidOperationException(
                "A single-point device cannot have multiple points per-target, so the " +
                "provided touchId must be 0.");
        }

        // handle new pointer target:

        // first check if we have it already
        var exists = false;
        for (var i = 0; i < _myPointerTargets.Count; ++i)
        {
            if (ReferenceEquals(_myPointerTargets[i], target))
            {
                exists = true;
                break;
            }
        }

        // if we don't have it already, that's an EZ target changed event
        if (!exists)
        {
            _myPointerTargets.Add(target);
            var bounds = target.Bounds;
            TargetEvents.Enqueue(
                item: new PointerTargetChangedEvent(Pointer: this,
                    Timestamp: timestamp,
                    Target: target,
                    IsAdded: true,
                    OldBounds: default,
                    NewBounds: bounds));
        }

        // now handle the point:

        // first we check to see if we have this point already
        int? pointIndex = null; // the index of our point
        int? defaultIndex = null; // the index of an empty slot we could put a new point

        var actualPointsSpan = CollectionsMarshal.AsSpan(_actualPoints);
        for (var i = 0; i < actualPointsSpan.Length; i++)
        {
            ref readonly var candidatePoint = ref actualPointsSpan[i];
            // A single-point device (e.g. a mouse) only ever has one point, even across targets: when its mode changes
            // it is handed a different target, and that target's point *replaces* the existing one rather than being
            // added alongside it. For multi-point devices, points are keyed by (target, id) as usual.
            if (Matches(in candidatePoint, touchId, target))
            {
                pointIndex = i;
                break;
            }

            // check for a free spot while we're here to avoid re-searching the list later if necessary
            if (defaultIndex is null && candidatePoint == default)
            {
                defaultIndex = i;
            }
        }

        bool isNewPoint;
        if (pointIndex == null)
        {
            isNewPoint = true;
            if (defaultIndex == null)
            {
                // we need to expand the list
                pointIndex = _actualPoints.Count;
                _actualPoints.Add(default);
                actualPointsSpan = CollectionsMarshal.AsSpan(_actualPoints);
            }
            else
            {
                // we can fill an old spot
                pointIndex = defaultIndex;
            }
        }
        else
        {
            isNewPoint = false;
        }

        // we got our slot
        ref var point = ref actualPointsSpan[pointIndex.Value];

        // note: a null oldPoint means this is a new point
        // see PointChangedEvent for more info
        if (isNewPoint)
        {
            oldPoint = null;
            point = point with { Pressure = 1.0f };
        }
        else
        {
            oldPoint = point;
        }

        // replace the point with a newly calculated point based on the inputs
        var pos = positionOnTarget ?? (isNewPoint ? Vector3.Zero : point.Position);

        Ray3D<float> effectiveRay;
        if (ray.HasValue)
        {
            effectiveRay = ray.Value;
        }
        else if (isNewPoint)
        {
            var worldPos = GetWorldPosition(target, pos);
            effectiveRay = new Ray3D<float>(
                origin: new Vector3D<float>(worldPos.X, worldPos.Y, worldPos.Z),
                direction: new Vector3D<float>(0, 0, 1));
        }
        else
        {
            var oldWorldPos = GetWorldPosition(target, point.Position);
            var newWorldPos = GetWorldPosition(target, pos);
            var zOffset = point.Pointer.Origin.Z - oldWorldPos.Z;
            effectiveRay = new Ray3D<float>(
                origin: new Vector3D<float>(newWorldPos.X, newWorldPos.Y, newWorldPos.Z + zOffset),
                direction: point.Pointer.Direction);
        }

        point = new TargetPoint(*(int*)&touchId,
            Flags: TargetPointFlags.PointingAtTarget,
            Position: pos,
            NormalizedPosition: NormalizeOnTarget(pos, target.Bounds),
            Pointer: effectiveRay,
            Pressure: pressure ?? point.Pressure,
            Target: target
        );

        return ref point;
    }

    private bool Matches(ref readonly TargetPoint candidatePoint, uint touchId, IPointerTarget target) =>
        OnePointOnly
            ? candidatePoint.Id == touchId
            : candidatePoint.Target == target && candidatePoint.Id == touchId;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vector3 GetWorldPosition(IPointerTarget target, in Vector3 posOnTarget)
    {
        var min = target.Bounds.Min.ToSystem();
        min &= Vector3.IsFinite(min); // returns vector whose elements are all-bits-set or zero
        return posOnTarget + min;
    }

    /// <summary>
    /// Normalizes a position expressed in its target space (i.e. relative to
    /// <see cref="IPointerTarget.Bounds"/>'s Min) to the range [0, 1].
    /// This is the only method a position should be normalized by.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Vector3 NormalizeOnTarget(in Vector3 posOnTarget, in Box3D<float> bounds)
    {
        var min = bounds.Min.ToSystem();
        var max = bounds.Max.ToSystem();
        var size = max - min;

        // Per-axis validity: IsFinite yields an all-bits-set mask per valid component.
        // then we mask-select non-zero sizes.
        var valid = Vector3.IsFinite(min) & Vector3.IsFinite(max) & ~Vector3.Equals(size, Vector3.Zero);

        // Substitute 1.0 on invalid axes so the divide never produces NaN
        var divisor = Vector3.ConditionalSelect(valid, size, Vector3.One);

        return (posOnTarget / divisor) & valid;
    }

    protected void SetPointLookAtTarget(uint? touchId, IPointerTarget target, bool lookAt, long timestamp)
    {
        touchId = ValidateTouchId(touchId);
        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
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
    /// <param name="timestamp"></param>
    /// <exception cref="InvalidOperationException"></exception>
    protected TargetPoint AddOrUpdatePoint(uint? touchId, IPointerTarget target, in Vector3? pos,
        float? pressure, bool? isDown, Ray3D<float>? ray, long timestamp)
    {
        if (pos == null && pressure == null && isDown == null && ray == null)
        {
            throw new InvalidOperationException("At least one parameter must have a value");
        }

        var id = ValidateTouchId(touchId);

        ref readonly var updatedPoint = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            touchId: id,
            positionOnTarget: pos,
            ray: ray,
            pressure: pressure,
            oldPoint: out var oldPoint);

        PointEvents.Enqueue(new PointChangedEvent(this, timestamp, OldPoint: oldPoint, NewPoint: updatedPoint));

        if (isDown is false)
        {
            PointEvents.Enqueue(
                item: new PointChangedEvent(
                    Pointer: this,
                    Timestamp: timestamp,
                    OldPoint: updatedPoint,
                    NewPoint: null)); // null NewPoint indicates removal

            var actualPoints = CollectionsMarshal.AsSpan(_actualPoints);
            for (var i = 0; i < actualPoints.Length; i++)
            {
                ref var candidatePoint = ref actualPoints[i];
                if (Matches(in candidatePoint, id, target))
                {
                    candidatePoint = default;
                }
            }
        }

        return updatedPoint;
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
        float? distance, long timestamp)
    {
        if (xTilt == null && yTilt == null && zTwist == null && distance == null)
        {
            throw new InvalidOperationException("At least one parameter must have a value");
        }

        touchId = ValidateTouchId(touchId);

        ref var point = ref CreateOrUpdateTargetPoint(
            target: target,
            timestamp: timestamp,
            touchId: touchId.Value,
            positionOnTarget: null,
            ray: null,
            pressure: null,
            oldPoint: out var oldPoint);

        var ray = point.Pointer;
        xTilt ??= ray.Direction.X;
        yTilt ??= ray.Direction.Y;
        zTwist ??= ray.Direction.Z;

        var worldPos = GetWorldPosition(target, point.Position);
        var zDistance = distance ?? (ray.Origin.Z - worldPos.Z);

        point = point with {
            Pointer = new Ray3D<float>(
                origin: new Vector3D<float>(worldPos.X, worldPos.Y, worldPos.Z + zDistance),
                direction: new Vector3D<float>(xTilt.Value, yTilt.Value, zTwist.Value))
        };

        PointEvents.Enqueue(new PointChangedEvent(this, timestamp, OldPoint: oldPoint,
            NewPoint: point));
    }

    public void TargetDestroyed(IPointerTarget target, long timestamp)
    {
        if (_myPointerTargets.Remove(target))
        {
            var bounds = target.Bounds;
            TargetEvents.Enqueue(new PointerTargetChangedEvent(this, timestamp, target, false, bounds, bounds));
        }
    }


    public void TargetChanged(SdlWindowTarget target, long timestamp, in Box3D<float> oldBounds)
    {
        if (_myPointerTargets.Contains(target))
        {
            TargetEvents.Enqueue(new PointerTargetChangedEvent(
                    Pointer: this,
                    Timestamp: timestamp,
                    Target: target,
                    IsAdded: null,
                    OldBounds: oldBounds,
                    NewBounds: target.Bounds));
        }
    }

}
