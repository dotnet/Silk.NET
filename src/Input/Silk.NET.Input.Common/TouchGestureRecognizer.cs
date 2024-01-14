// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel;
using System.Numerics;

namespace Silk.NET.Input
{
    /// <summary>
    /// Touch gesture tracking.
    /// </summary>
    public sealed class TouchGestureRecognizer : IDisposable
    {
        private readonly ITouchDevice _device;
        private long? _firstFingerIndex;
        private DateTime? _firstFingerLastMoveTime;
        private long? _secondFingerIndex;
        private DateTime? _firstTapTime;
        private Vector2? _firstTapPosition;
        private Vector2? _firstTapNormalizedPosition;
        private Vector2 _initialFingerDistance = Vector2.Zero;
        private float _initialFingerAngle = 0.0f;
        private bool _gestureHandled = false;

        internal TouchGestureRecognizer(ITouchDevice device)
        {
            _device = device;
            device.FingerDown += Device_FingerDown;
            device.FingerUp += Device_FingerUp;
            device.FingerMove += Device_FingerMove;
        }

        private void Device_FingerDown(ITouchDevice touchDevice, TouchFinger finger)
        {
            if (_firstFingerIndex is null)
            {
                _gestureHandled = false;
                _firstFingerIndex = finger.Index;
                _firstFingerLastMoveTime = DateTime.Now;
            }
            else if (_secondFingerIndex is null)
            {
                _secondFingerIndex = finger.Index;
                var firstFinger = _device.Fingers[_firstFingerIndex.Value];

                _initialFingerDistance = finger.NormalizedPosition - firstFinger.NormalizedPosition;
                _initialFingerAngle = (float)(Math.Atan2(finger.NormalizedPosition.Y - firstFinger.NormalizedPosition.Y,
                    finger.NormalizedPosition.X - firstFinger.NormalizedPosition.X) * 180.0 / Math.PI);
            }
        }

        private void Device_FingerUp(ITouchDevice touchDevice, TouchFinger finger)
        {
            if (_gestureHandled)
            {
                _firstFingerIndex = null;
                _secondFingerIndex = null;
                return;
            }

            if (finger.Index == _firstFingerIndex)
            {
                bool secondTap = _firstTapTime != null;
                // Double tap is considered if it is tracked, this is the second tap and it was in time.
                bool doubleTap = secondTap && DoubleTap != null && TrackedGestures.HasFlag(Gesture.DoubleTap) &&
                    (DateTime.Now - _firstTapTime!.Value).TotalMilliseconds <= DoubleTapTime;

                if (doubleTap && _firstTapNormalizedPosition != null &&
                    (Math.Abs(finger.NormalizedPosition.X - _firstTapNormalizedPosition.Value.X) > DoubleTapRange ||
                     Math.Abs(finger.NormalizedPosition.Y - _firstTapNormalizedPosition.Value.Y) > DoubleTapRange))
                {
                    // Second tap was out of range
                    doubleTap = false;
                }

                switch (DoubleTapBehavior)
                {
                    case DoubleTapBehavior.EmitFirstSingleTap:
                        if (doubleTap)
                        {
                            DoubleTap?.Invoke(finger.Position);
                        }
                        else if (TrackedGestures.HasFlag(Gesture.Tap))
                        {
                            Tap?.Invoke(finger.Position);
                        }
                        break;
                    case DoubleTapBehavior.EmitBothSingleTaps:
                        if (TrackedGestures.HasFlag(Gesture.Tap))
                        {
                            Tap?.Invoke(finger.Position);
                        }
                        if (doubleTap)
                        {
                            DoubleTap?.Invoke(finger.Position);
                        }
                        break;
                    case DoubleTapBehavior.WaitForDoubleTapTimeElapse:
                        if (doubleTap)
                        {
                            DoubleTap?.Invoke(finger.Position);
                        }
                        else if (secondTap && TrackedGestures.HasFlag(Gesture.Tap))
                        {
                            Tap?.Invoke(_firstTapPosition ?? finger.Position);
                            Tap?.Invoke(finger.Position);
                        }
                        break;
                }

                if (secondTap && (TrackedGestures & (Gesture.Tap | Gesture.DoubleTap)) != 0)
                    _gestureHandled = true;

                _firstTapTime = doubleTap ? null : DateTime.Now;
                _firstTapPosition = doubleTap ? null : finger.Position;
                _firstTapNormalizedPosition = doubleTap ? null : finger.NormalizedPosition;
                _firstFingerIndex = null;
                _secondFingerIndex = null;
                _initialFingerDistance = Vector2.Zero;
                _initialFingerAngle = 0.0f;
            }
            else if (finger.Index == _secondFingerIndex)
            {
                _secondFingerIndex = null;
                _initialFingerDistance = Vector2.Zero;
                _initialFingerAngle = 0.0f;
                _gestureHandled = true;
            }
        }

        private void Device_FingerMove(ITouchDevice touchDevice, TouchFinger finger, Vector2 delta)
        {
            if (finger.Index == _firstFingerIndex)
            {
                _firstFingerLastMoveTime = DateTime.Now;

                if (!_gestureHandled &&
                    TrackedGestures.HasFlag(Gesture.Swipe) &&
                    _secondFingerIndex is null &&
                    ((Math.Abs(finger.NormalizedSpeed.X) >= SwipeMinSpeed &&
                    Math.Abs(finger.NormalizedSpeed.X) <= SwipeMaxSpeed) ||
                    (Math.Abs(finger.NormalizedSpeed.Y) >= SwipeMinSpeed &&
                    Math.Abs(finger.NormalizedSpeed.Y) <= SwipeMaxSpeed)))
                {
                    _gestureHandled = true;
                    _firstFingerIndex = null;
                    Swipe?.Invoke(finger.NormalizedSpeed);
                    return;
                }

                if (_secondFingerIndex != null)
                {
                    CheckTwoFingerGestures();
                }
            }
            else
            {
                if (_firstFingerIndex != null && _secondFingerIndex is null)
                {
                    _secondFingerIndex = finger.Index;
                    var firstFinger = _device.Fingers[_firstFingerIndex.Value];

                    _initialFingerDistance = finger.NormalizedPosition - firstFinger.NormalizedPosition;
                    _initialFingerAngle = (float) (Math.Atan2(finger.NormalizedPosition.Y - firstFinger.NormalizedPosition.Y,
                        finger.NormalizedPosition.X - firstFinger.NormalizedPosition.X) * 180.0 / Math.PI);
                }

                CheckTwoFingerGestures();
            }
        }

        private void CheckTwoFingerGestures()
        {
            if (Zoom is null && Rotate is null)
                return; // Don't bother

            TouchFinger? firstFinger = _firstFingerIndex != null && _device.Fingers.TryGetValue(_firstFingerIndex.Value, out var finger) ? finger : null;
            TouchFinger? secondFinger = _secondFingerIndex != null && _device.Fingers.TryGetValue(_secondFingerIndex.Value, out finger) ? finger : null;

            if (firstFinger != null && secondFinger != null)
            {
                var multiGestureHandling = MultiGestureHandling;
                if (Rotate is null)
                    multiGestureHandling = MultiGestureHandling.PrioritizeZoomGesture;
                else if (Zoom is null)
                    multiGestureHandling = MultiGestureHandling.PrioritizeRotateGesture;
                Action? zoomInvoker = null;

                if (TrackedGestures.HasFlag(Gesture.Zoom))
                {
                    var fingerDistance = secondFinger.Value.NormalizedPosition - firstFinger.Value.NormalizedPosition;
                    var distance = fingerDistance - _initialFingerDistance;

                    if (Math.Abs(distance.X) >= ZoomDistanceThreshold || Math.Abs(distance.Y) >= ZoomDistanceThreshold)
                    {
                        zoomInvoker = () => Zoom?.Invoke(firstFinger.Value.Position, distance);

                        if (multiGestureHandling == MultiGestureHandling.PrioritizeZoomGesture)
                        {
                            _gestureHandled = true;
                            zoomInvoker();
                            return;
                        }
                    }
                }
                if (TrackedGestures.HasFlag(Gesture.Rotate))
                {
                    var firstFingerPosition = firstFinger.Value.NormalizedPosition;
                    var secondFingerPosition = secondFinger.Value.NormalizedPosition;
                    var fingerAngle = (float)(Math.Atan2(secondFingerPosition.Y - firstFingerPosition.Y,
                            secondFingerPosition.X - firstFingerPosition.X) * 180.0 / Math.PI);
                    var angle = CalculateAngleDifference(fingerAngle, _initialFingerAngle);

                    if (Math.Abs(angle) >= RotateAngleThreshold)
                    {
                        _gestureHandled = true;

                        if (zoomInvoker != null && multiGestureHandling == MultiGestureHandling.RecognizeBothGestures)
                            zoomInvoker();

                        Rotate?.Invoke(firstFinger.Value.Position, angle);
                    }
                }
            }
        }

        private static float CalculateAngleDifference(float angle1, float angle2)
        {
            // Ensure angles are in the range [0, 360)
            angle1 = (angle1 + 360.0f) % 360.0f;
            angle2 = (angle2 + 360.0f) % 360.0f;

            // Calculate the signed angle difference
            // This is always in the range (-360, 360)
            return angle2 - angle1;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _device.FingerDown -= Device_FingerDown;
            _device.FingerUp -= Device_FingerUp;
            _device.FingerMove -= Device_FingerMove;
        }

        /// <summary>
        /// General gesture recognition update for time-based recognition aspects.
        /// </summary>
        public void Update()
        {
            if (TrackedGestures.HasFlag(Gesture.Hold) &&
                _firstFingerIndex != null && _firstFingerLastMoveTime != null && _secondFingerIndex is null &&
                (DateTime.Now - _firstFingerLastMoveTime.Value).TotalMilliseconds >= HoldTime &&
                _device.Fingers.TryGetValue(_firstFingerIndex.Value, out var finger))
            {
                _gestureHandled = true;
                Hold?.Invoke(finger.Position);
                _firstFingerIndex = null;
            }
        }

        /// <summary>
        /// The tracked gestures.
        /// </summary>
        [DefaultValue(Gesture.All)]
        public Gesture TrackedGestures { get; set; } = Gesture.All;

        /// <summary>
        /// THe behavior to handle multiple two-finger gestures.
        /// </summary>
        [DefaultValue(MultiGestureHandling.RecognizeBothGestures)]
        public MultiGestureHandling MultiGestureHandling { get; set; } = MultiGestureHandling.RecognizeBothGestures;

        /// <summary>
        /// The behavior for tracking double taps.
        /// </summary>
        [DefaultValue(DoubleTapBehavior.EmitFirstSingleTap)]
        public DoubleTapBehavior DoubleTapBehavior { get; set; } = DoubleTapBehavior.EmitFirstSingleTap;

        /// <summary>
        /// The maximum time in milliseconds between two
        /// consecutive taps to count as a double tap.
        /// </summary>
        [DefaultValue(500)]
        public int DoubleTapTime { get; set; } = 500;

        /// <summary>
        /// The maximum distance in normalized distance (0..1) between two
        /// consecutive taps to count as a double tap.
        /// </summary>
        [DefaultValue(0.05f)]
        public float DoubleTapRange { get; set; } = 0.05f;

        /// <summary>
        /// The minimum finger speed in normalized distance (0..1) per second to count as a swipe gesture.
        /// </summary>
        [DefaultValue(0.15f)]
        public float SwipeMinSpeed { get; set; } = 0.15f;

        /// <summary>
        /// The maximum finger speed in normalized distance (0..1) per second to count as a swipe gesture.
        /// </summary>
        [DefaultValue(1000.0f)]
        public float SwipeMaxSpeed { get; set; } = 1000.0f;

        /// <summary>
        /// The minimum time in milliseconds a finger must be pressed on the surface to count as a hold gesture.
        /// </summary>
        [DefaultValue(1000)]
        public int HoldTime { get; set; } = 1000;

        /// <summary>
        /// Distance threshold as a normalized value (0..1) for zoom gesture tracking.
        /// </summary>
        [DefaultValue(0.15f)]
        public float ZoomDistanceThreshold { get; set; } = 0.15f;

        /// <summary>
        /// Angle threshold in degrees for rotate gesture tracking.
        /// </summary>
        [DefaultValue(9.0f)]
        public float RotateAngleThreshold { get; set; } = 9.0f;

        /// <summary>
        /// Tap gesture.
        /// </summary>
        /// <remarks>
        /// The event argument gives the finger position of the tap.
        /// </remarks>
        public event Action<Vector2>? Tap;

        /// <summary>
        /// Double tap gesture.
        /// </summary>
        /// <remarks>
        /// The event argument gives the finger position of the second tap.
        /// </remarks>
        public event Action<Vector2>? DoubleTap;

        /// <summary>
        /// Swipe gesture.
        /// </summary>
        /// <remarks>
        /// The event argument gives the swipe direction as a normalized 2D vector.
        /// </remarks>
        public event Action<Vector2>? Swipe;

        /// <summary>
        /// Long hold gesture.
        /// </summary>
        /// <remarks>
        /// The event argument gives the finger position at the end of the hold.
        /// </remarks>
        public event Action<Vector2>? Hold;

        /// <summary>
        /// Zoom gesture.
        /// </summary>
        /// <remarks>
        /// The first event argument gives the first finger position and the second
        /// event argument the delta of the distance of the two fingers in relation to the last zoom event.
        /// </remarks>
        public event Action<Vector2, Vector2>? Zoom;

        /// <summary>
        /// Rotate gesture.
        /// </summary>
        /// <remarks>
        /// The first event argument gives the first finger position and the second
        /// event argument gives the angle delta in degress in relation to the last rotate event.
        /// </remarks>
        public event Action<Vector2, float>? Rotate;
    }
}
