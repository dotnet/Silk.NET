// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    internal interface IGlfwDevice : IInputDevice
    {
        bool IsConnected { get; }
    }
}
