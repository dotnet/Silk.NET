// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public struct Button
    {
        public ButtonName Name { get; }
        public int Index { get; }
        public bool Pressed { get; }

        public Button(ButtonName name, int index, bool pressed)
        {
            Name = name;
            Index = index;
            Pressed = pressed;
        }
    }
}