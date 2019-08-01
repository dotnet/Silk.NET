// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    public class GlfwJoystickCollection : IReadOnlyList<IJoystick>
    {
        private readonly GlfwInputContext _glfwInputContext;

        public GlfwJoystickCollection(GlfwInputContext glfwInputContext)
        {
            _glfwInputContext = glfwInputContext;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator<IJoystick> IEnumerable<IJoystick>.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<IJoystick> GetEnumerator()
        {
            return _glfwInputContext._joysticks.GetEnumerator();
        }

        public int Count => 16;

        public IJoystick this[int index] => _glfwInputContext._joysticks[index];
    }
}
