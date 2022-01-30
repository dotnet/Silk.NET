using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IReadOnlyList<Key> SupportedKeys { get; } =
            _keyMap.Values.Where(static x => x != Key.Unknown).Distinct().ToArray();
        public string ClipboardText
        {
            get => _ctx.Sdl.GetClipboardTextS();
            set => _ctx.Sdl.SetClipboardText(value);
        }
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
                    if (KeyChar is not null)
                    {
                        var chars = stackalloc char[32];
                        Encoding.UTF8.GetChars(&@event.Text.Text[0], 32, chars, 32);
                            
                        // run the KeyChar event until we get a null terminator or run out of buffer
                        for (int i = 0; i < 32 && chars[i] != '\0'; i++)
                        {
                            KeyChar.Invoke(this, chars[i]);
                        }
                    }

                    break;
                }
                case EventType.Keymapchanged:
                    break;
            }
        }
    }
}
