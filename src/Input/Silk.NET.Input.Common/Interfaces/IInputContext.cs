// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// An interface representing the input context.
    /// </summary>
    public interface IInputContext
    {
        /// <summary>
        /// A handle to the underlying window.
        /// </summary>
        IntPtr Handle { get; }
        
        /// <summary>
        /// A list of all available gamepads.
        /// </summary>
        IReadOnlyCollection<IGamepad> Gamepads { get; }
        
        /// <summary>
        /// A list of all available joysticks.
        /// </summary>
        IReadOnlyCollection<IJoystick> Joysticks { get; }
        
        /// <summary>
        /// A list of all available keyboards.
        /// </summary>
        IReadOnlyCollection<IKeyboard> Keyboards { get; }
        
        /// <summary>
        /// A list of all available mice.
        /// </summary>
        IReadOnlyCollection<IMouse> Mice { get; }
        
        /// <summary>
        /// A list of all other available input devices.
        /// </summary>
        IReadOnlyCollection<IInputDevice> OtherDevices { get; }
    }
}