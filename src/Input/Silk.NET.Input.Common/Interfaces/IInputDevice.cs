// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Input.Common
{
    public interface IInputDevice
    {
        string Name { get; }
        int Index { get; }
        bool IsConnected { get; }
        event Action<IInputDevice, bool> ConnectionChanged;
    }
}