// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    class X
    {
        public void Y()
        {
            Vector2<float> blah = default;
            Vector4<float> blahblah = new Vector4<float>(blah, blah);
        }
    }
    public struct Vector2<T> where T : unmanaged
    {
        public T X { get; set; }
        public T Y { get; set; }
    }
    public struct Vector3<T> where T : unmanaged
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
    }
    public struct Vector4<T> where T : unmanaged
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
        public T W { get; set; }

        public Vector4(Vector2<T> xyzw) : this(xyzw, xyzw) {}
        public unsafe Vector4(Vector2<T> xy, Vector2<T> zw)
        {
            fixed (Vector4<T>* ptr = &this)
            {
                ((Vector2<T>*)ptr)[0] = xy;
                ((Vector2<T>*)ptr)[1] = zw;
            }
        }
        public unsafe Vector4(Vector2<T> xy, T z, T w)
        {
            fixed (Vector4<T>* ptr = &this)
            {
                ((Vector2<T>*)ptr)[0] = xy;
                ptr->Z = z;
                ptr->W = w;
            }
        }

        public unsafe Vector4(Vector3<T> xyz, T w = default)
        {
            fixed (Vector4<T>* ptr = &this)
            {
                ((Vector3<T>*)ptr)[0] = xyz;
                ptr->W = w;
            }
        }

        public Vector4(T x, T y, T z, T w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        
        public unsafe Vector4(ReadOnlySpan<T> xyzw)
        {
            fixed (Vector4<T>* ptr = &this)
            {
                fixed (T* inPtr = xyzw)
                {
                    switch (xyzw.Length)
                    {
                        case 4:
                            ptr[0] = *(Vector4<T>*) inPtr;
                            break;
                        case 3:
                            ((Vector3<T>*)ptr)[0] = *(Vector3<T>*) inPtr;
                            break;
                        case 2:
                            ((Vector2<T>*)ptr)[0] = *(Vector2<T>*) inPtr;
                            break;
                        case 1:
                            ((T*)ptr)[0] = *inPtr;
                            break;
                    }
                }
            }
        }
    }
}
