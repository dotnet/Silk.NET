using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Sdl
{
    internal class SdlKeyboard : IKeyboard
    {
        public SdlKeyboard(SdlInputContext sdlInputContext)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public IReadOnlyList<Key> SupportedKeys { get; }
        public bool IsKeyPressed(Key key)
        {
            throw new NotImplementedException();
        }

        public event Action<IKeyboard, Key, int>? KeyDown;
        public event Action<IKeyboard, Key, int>? KeyUp;
        public event Action<IKeyboard, char>? KeyChar;
    }
}