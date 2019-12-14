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
    /// A collection of GLFW-based gamepads.
    /// </summary>
    internal class GlfwGamepadCollection : IReadOnlyList<IGamepad>
    {
        private readonly GlfwInputContext _ctx;

        internal GlfwGamepadCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        /// <inheritdoc />
        IEnumerator<IGamepad> IEnumerable<IGamepad>.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that loops over this collection.</returns>
        public IEnumerator<IGamepad> GetEnumerator()
        {
            return _ctx._gamepads.GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => 16;

        /// <inheritdoc />
        public IGamepad this[int i] => _ctx._gamepads[i];
    }
}
