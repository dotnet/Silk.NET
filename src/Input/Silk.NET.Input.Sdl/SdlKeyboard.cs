using System;
using System.Collections.Generic;
using Silk.NET.Input.Internals;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal partial class SdlKeyboard : IKeyboard, ISdlDevice
    {
        private readonly SdlInputContext _ctx;
        private List<Key> _keysDown = new List<Key>();

        public SdlKeyboard(SdlInputContext ctx)
        {
            _ctx = ctx;
        }

        public string Name { get; } = "Silk.NET Keyboard (via SDL)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<Key> SupportedKeys { get; } = new ReadOnlyCollectionListAdapter<Key>(_keyMap.Values);
        public bool IsKeyPressed(Key key) => _keysDown.Contains(key);
        public event Action<IKeyboard, Key, int>? KeyDown;
        public event Action<IKeyboard, Key, int>? KeyUp;
        public event Action<IKeyboard, char>? KeyChar;
        public void BeginInput() => _ctx.Sdl.StartTextInput();
        public void EndInput() => _ctx.Sdl.StopTextInput();

        public unsafe void DoEvent(Event @event)
        {
            switch ((EventType) @event.Type)
            {
                case EventType.Keydown:
                {
                    if (@event.Key.Repeat != 1 && _keyMap.TryGetValue((KeyCode) @event.Key.Keysym.Sym, out var key))
                    {
                        _keysDown.Add(key);
                        KeyDown?.Invoke(this, key, (int) @event.Key.Keysym.Scancode);
                    }

                    break;
                }
                case EventType.Keyup:
                {
                    if (@event.Key.Repeat != 1 && _keyMap.TryGetValue((KeyCode) @event.Key.Keysym.Sym, out var key))
                    {
                        _keysDown.Remove(key);
                        KeyUp?.Invoke(this, key, (int) @event.Key.Keysym.Scancode);
                    }

                    break;
                }
                case EventType.Textediting:
                {
                    break;
                }
                case EventType.Textinput:
                {
                    for (int i = 0; i < 32; i++)
                    {
                        var @char = @event.Text.Text[i];
                        if (@char == 0)
                        {
                            break;
                        }

                        KeyChar?.Invoke(this, (char) @char);
                    }

                    break;
                }
                case EventType.Keymapchanged:
                    break;
            }
        }
    }
}
