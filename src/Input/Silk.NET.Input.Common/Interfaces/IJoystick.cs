// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents a joystick device with a set amount of axes, buttons, and hats.
    /// </summary>
    public interface IJoystick : IInputDevice
    {
        /// <summary>
        /// A list of all axes reported by this joystick.
        /// </summary>
        IReadOnlyList<Axis> Axes { get; }

        /// <summary>
        /// A list of all buttons reported by this joystick.
        /// </summary>
        IReadOnlyList<Button> Buttons { get; }

        /// <summary>
        /// A list of all hats reported by this joystick.
        /// </summary>
        IReadOnlyList<Hat> Hats { get; }

        /// <summary>
        /// The deadzone to use for this joystick's axes.
        /// </summary>
        Deadzone Deadzone { get; set; }

        /// <summary>
        /// Called when a button on this joystick is pressed.
        /// </summary>
        /// <remarks>
        /// This event is only called when the button is first pressed, and not every frame where the button is still pressed.
        /// </remarks>
<<<<<<< HEAD
        event Action<IJoystick, Button>? ButtonDown;
=======
        event Action<IJoystick, Button> ButtonDown;
>>>>>>> master

        /// <summary>
        /// Called when a button on this joystick is released.
        /// </summary>
        /// <remarks>
        /// This event is only called when the button is first released, and not every frame where the button is still released.
        /// </remarks>
<<<<<<< HEAD
        event Action<IJoystick, Button>? ButtonUp;
=======
        event Action<IJoystick, Button> ButtonUp;
>>>>>>> master

        /// <summary>
        /// Called when an axis on this joystick is moved.
        /// </summary>
<<<<<<< HEAD
        event Action<IJoystick, Axis>? AxisMoved;
=======
        event Action<IJoystick, Axis> AxisMoved;
>>>>>>> master

        /// <summary>
        /// Called when a hat on this joystick is moved.
        /// </summary>
        event Action<IJoystick, Hat>? HatMoved;
    }
}
