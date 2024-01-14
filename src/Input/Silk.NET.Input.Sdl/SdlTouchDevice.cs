using System;
using System.Collections.Generic;
using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal class SdlTouchDevice : ITouchDevice, ISdlDevice, IDisposable
    {
        private readonly SdlInputContext _ctx;
        private readonly Dictionary<long, TouchFinger> _fingers = new Dictionary<long, TouchFinger>();
        private readonly Dictionary<long, DateTime> _fingerEventTimes = new Dictionary<long, DateTime>();

        /// <summary>
        /// Id of the touch device.
        /// </summary>
        public long TouchId { get; }

        /// <summary>
        /// Type of the touch device.
        /// </summary>
        public TouchDeviceType TouchDeviceType { get; }

        public SdlTouchDevice(SdlInputContext ctx, long touchId, TouchDeviceType touchDeviceType, int index)
        {
            _ctx = ctx;
            TouchId = touchId;
            TouchDeviceType = touchDeviceType;
            Index = index;
            GestureRecognizer = new TouchGestureRecognizer(this);
        }

        public string Name => GetTouchDeviceName();
        public int Index { get; }
        public bool IsConnected { get; set; } = false;

        public IReadOnlyDictionary<long, TouchFinger> Fingers => _fingers;

        public TouchGestureRecognizer GestureRecognizer { get; }

        public bool IsFingerDown(long index) => _fingers.TryGetValue(index, out var finger) && finger.Down;
        public event Action<ITouchDevice, TouchFinger>? FingerDown;
        public event Action<ITouchDevice, TouchFinger>? FingerUp;
        public event Action<ITouchDevice, TouchFinger, Vector2>? FingerMove;

        public void Update()
        {
            GestureRecognizer.Update();
        }

        public unsafe void DoEvent(Event @event)
        {
            var window = _ctx.Sdl.GetWindowFromID(@event.Tfinger.WindowID);
            int windowWidth = 1;
            int windowHeight = 1;
            _ctx.Sdl.GetWindowSize(window, ref windowWidth, ref windowHeight);
            Vector2 windowSize = new Vector2(windowWidth, windowHeight);
            var normalizedPosition = new Vector2(@event.Tfinger.X, @event.Tfinger.Y);
            var position = normalizedPosition * windowSize;

            switch ((EventType) @event.Type)
            {
                case EventType.Fingerdown:
                {
                    var finger = new TouchFinger(@event.Tfinger.FingerId,
                        position, normalizedPosition, Vector2.Zero, Vector2.Zero, true);
                    FingerDown?.Invoke(this, finger);
                    _fingers[finger.Index] = finger;
                    _fingerEventTimes[finger.Index] = DateTime.Now;
                    break;
                }
                case EventType.Fingerup:
                {
                    var finger = new TouchFinger(@event.Tfinger.FingerId,
                        position, normalizedPosition, Vector2.Zero, Vector2.Zero, false);
                    FingerUp?.Invoke(this, finger);
                    _fingers.Remove(finger.Index);
                    _fingerEventTimes.Remove(finger.Index);
                    break;
                }
                case EventType.Fingermotion:
                {
                    var distance = new Vector2(@event.Tfinger.Dx, @event.Tfinger.Dy);
                    var time = (DateTime.Now - _fingerEventTimes[@event.Tfinger.FingerId]).TotalSeconds;
                    var normalizedSpeed = distance / (float) (time == 0.0 ? double.Epsilon : time);
                    var speed = normalizedSpeed * windowSize;
                    var finger = new TouchFinger(@event.Tfinger.FingerId,
                        position, normalizedPosition, speed, normalizedSpeed,
                        false);
                    FingerMove?.Invoke(this, finger, distance);
                    _fingers[finger.Index] = finger;
                    _fingerEventTimes[finger.Index] = DateTime.Now;
                    break;
                }
            }
        }

        public void Dispose()
        {
            GestureRecognizer.Dispose();
        }

        private string GetTouchDeviceName()
        {
            try
            {
                return _ctx.Sdl.GetTouchNameS(Index);
            }
            catch
            {
                return "Silk.NET Touch Device (via SDL)";
            }
        }
    }
}
