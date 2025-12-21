// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal static class PointerTargetExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AppliesTo(this IPointerDevice device, IPointerTarget target) => device.Targets.Contains(target);

    extension(IPointerTarget target)
    {
        /// <summary>
        /// Normalizes a 2D position to the range [0, 1] in both dimensions.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 SimpleNormalizedPosition(in Vector3 input) =>
            SimpleRelativePosition(target, input) / target.Bounds.Size.ToSystem();

        public Vector3 SimpleRelativePosition(in Vector3 input)
        {
            var bounds = target.Bounds;
            if (Scalar.IsInfinity(bounds.Min) || Scalar.IsInfinity(bounds.Max))
            {
                throw new InvalidOperationException("Target bounds are infinite.");
            }

            return input - bounds.Min.ToSystem();
        }

        /// <summary>
        /// A default implementation of <see cref="IPointerTarget.GetPointCount(IPointerDevice)"/>
        /// that iterates over all points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetPointCount(IPointerDevice pointer)
        {
            var points = pointer.State.Points;
            var count = 0;
            var pointerPointsCount = points.Count;
            for (var i = 0; i < pointerPointsCount; i++)
            {
                if (points[i].Target == target)
                {
                    ++count;
                }
            }

            return count;
        }

        /// <summary>
        /// A default implementation of <see cref="IPointerTarget.GetPoint(IPointerDevice, int)"/>
        /// that iterates over all points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TargetPoint GetPoint(IPointerDevice pointer, int point)
        {
            var points = pointer.State.Points;
            var pointerPointsCount = points.Count;
            for (var i = 0; i < pointerPointsCount; i++)
            {
                var targetPoint = points[i];
                if (targetPoint.Target == target && point-- == 0)
                {
                    return targetPoint;
                }
            }

            return default;
        }
    }
}
