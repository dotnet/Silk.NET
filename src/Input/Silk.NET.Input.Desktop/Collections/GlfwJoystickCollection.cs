// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    /// <summary>
    /// A collection of GLFW-based joysticks.
    /// </summary>
    internal class GlfwJoystickCollection : IReadOnlyList<IJoystick>
    {
        private readonly GlfwInputContext _glfwInputContext;

        internal GlfwJoystickCollection(GlfwInputContext glfwInputContext)
        {
            _glfwInputContext = glfwInputContext;
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        /// <inheritdoc />
        IEnumerator<IJoystick> IEnumerable<IJoystick>.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that loops over this collection.</returns>
        public IEnumerator<IJoystick> GetEnumerator()
        {
            return _glfwInputContext._joysticks.GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => 16;

        /// <inheritdoc />
        public IJoystick this[int index] => _glfwInputContext._joysticks[index];
    }
}
