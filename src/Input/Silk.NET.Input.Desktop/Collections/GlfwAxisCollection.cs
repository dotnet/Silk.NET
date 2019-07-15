// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop.Collections
{
    public unsafe class GlfwAxisCollection : IReadOnlyList<Axis>
    {
        private float* _floats;
        private int _count;
        private readonly GlfwJoystick _joystick;

        public GlfwAxisCollection(float* floats, int count, GlfwJoystick joystick)
        {
            _floats = floats;
            _count = count;
            _joystick = joystick;
        }
        public IEnumerator<Axis> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _count;

        public Axis this[int index] => index < _count
            ? new Axis(index, Get(_floats, index))
            : throw new ArgumentOutOfRangeException();

        public static float Get(float* floats, int index)
        {
            return (float) Marshal.PtrToStructure
            (
                Marshal.ReadIntPtr((IntPtr) floats, index * IntPtr.Size),
                typeof(float)
            );
        }
        
        private struct Enumerator : IEnumerator<Axis>
        {
            private GlfwAxisCollection _col;
            private int _current;

            public Enumerator(GlfwAxisCollection col)
            {
                _col = col;
                _current = 0;
            }
            
            public bool MoveNext()
            {
                if (_current == _col._count)
                {
                    Current = default;
                    return false;
                }

                Current = new Axis(_current, Get(_col._floats, _current));
                _current++;
                return true;
            }

            public void Reset()
            {
                Current = default;
                _current = 0;
            }

            public Axis Current { get; set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
