// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    public interface IKeyboard : IInputDevice
    {
        IReadOnlyCollection<Key> SupportedKeys { get; }
        bool IsKeyPressed(Key key);
        bool IsKeyPressed(uint scancode);
        event Action<IKeyboard, Key> KeyDown;
        event Action<IKeyboard, Key> KeyUp;
    }
}