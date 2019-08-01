// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    public class GlfwGamepadCollection : IReadOnlyList<IGamepad>
    {
        private GlfwInputContext _ctx;

        public GlfwGamepadCollection(GlfwInputContext ctx)
        {
            _ctx = ctx;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator<IGamepad> IEnumerable<IGamepad>.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<IGamepad> GetEnumerator()
        {
            return _ctx._gamepads.GetEnumerator();
        }

        public int Count => 16;

        public IGamepad this[int i] => _ctx._gamepads[i];
    }
}
