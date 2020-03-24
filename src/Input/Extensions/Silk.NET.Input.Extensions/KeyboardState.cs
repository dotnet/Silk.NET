// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Extensions
{
    public sealed class KeyboardState : IDisposable
    {
        private readonly int _keyCount;
        private readonly unsafe Key* _keys;
        private readonly int _pressedKeyCount;
        private readonly unsafe Key* _pressedKeys;

        internal unsafe KeyboardState(IKeyboard keyboard)
        {
            Name = keyboard.Name;
            Index = keyboard.Index;
            IsConnected = keyboard.IsConnected;
            var keys = keyboard.SupportedKeys;
            _keyCount = _pressedKeyCount = keys.Count;
            _keys = (Key*) Marshal.AllocHGlobal(_keyCount * sizeof(Key));
            _pressedKeys = (Key*) Marshal.AllocHGlobal(_keyCount * sizeof(Key));
            _pressedKeyCount = 0;
            for (var i = 0; i < _keyCount; i++)
            {
                _keys[i] = keys[i];
                if (keyboard.IsKeyPressed(keys[i]))
                {
                    _pressedKeys[_pressedKeyCount++] = keys[i];
                }
            }

            _keys = (Key*) Marshal.ReAllocHGlobal((IntPtr) _pressedKeys, (IntPtr) (_pressedKeyCount * sizeof(Key)));
        }

        public string Name { get; }

        public int Index { get; }

        public bool IsConnected { get; }

        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        public unsafe bool IsKeyPressed(Key key)
        {
            for (var i = 0; i < _pressedKeyCount; i++)
            {
                if (_pressedKeys[i] == key)
                {
                    return true;
                }
            }

            return false;
        }

        public unsafe Span<Key> GetSupportedKeys()
        {
            return new Span<Key>(_keys, _keyCount);
        }

        public unsafe Span<Key> GetPressedKeys()
        {
            return new Span<Key>(_pressedKeys, _keyCount);
        }

        private unsafe void Free()
        {
            Marshal.FreeHGlobal((IntPtr) _keys);
            Marshal.FreeHGlobal((IntPtr) _pressedKeys);
        }

        ~KeyboardState()
        {
            Free();
        }
    }
}
