// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    public class GlfwGamepad : IGamepad
    {
        private List<Button> _cachedButtons = new List<Button>();
        private List<Thumbstick> _cachedThumbsticks = new List<Thumbstick>();
        private List<Trigger> _cachedTriggers = new List<Trigger>();
        public GlfwGamepad(int i)
        {
            Index = i;
        }

        public string Name => Util.Do(() => Util.Glfw.GetGamepadName(Index));
        public int Index { get; }
        public bool IsConnected => Util.Do(() => Util.Glfw.JoystickIsGamepad(Index) && Util.Glfw.JoystickIsGamepad(Index));
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Thumbstick> Thumbsticks { get; }
        public IReadOnlyList<Trigger> Triggers { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IGamepad, Button> ButtonDown;
        public event Action<IGamepad, Button> ButtonUp;
        public event Action<IGamepad, Thumbstick> ThumbstickMoved;
        public event Action<IGamepad, Trigger> TriggerMoved;

        public void Update()
        {
            if (Util.Glfw.JoystickIsGamepad(Index))
            {
                return;
            }

            IReadOnlyList<Button> buttons = Buttons;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (!buttons[i].Equals(_cachedButtons.Count > i ? _cachedButtons[i] : buttons[i]))
                {
                    _cachedButtons[i] = buttons[i];
                    (buttons[i].Pressed ? ButtonDown : ButtonUp)?.Invoke(this, buttons[i]);
                }
            }
            IReadOnlyList<Thumbstick> thumbsticks = Thumbsticks;
            for (int i = 0; i < thumbsticks.Count; i++)
            {
                if (!thumbsticks[i].Equals(_cachedThumbsticks.Count > i ? _cachedThumbsticks[i] : thumbsticks[i]))
                {
                    _cachedThumbsticks[i] = thumbsticks[i];
                    ThumbstickMoved?.Invoke(this, thumbsticks[i]);
                }
            }
            IReadOnlyList<Trigger> triggers = Triggers;
            for (int i = 0; i < triggers.Count; i++)
            {
                if (!triggers[i].Equals(_cachedTriggers.Count > i ? _cachedTriggers[i] : triggers[i]))
                {
                    _cachedTriggers[i] = triggers[i];
                    TriggerMoved?.Invoke(this, triggers[i]);
                }
            }
        }
    }
}