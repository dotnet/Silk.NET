using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.Core.Pointers
{
    /// <summary>
    /// Class containing extension methods for pointer types
    /// </summary>
    public unsafe static class PointerExtensions
    {
        #region ReadToString Extensions
        #region MUT Extensions
        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<byte> @this)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<byte> @this, int length) => Encoding.UTF8.GetString(@this.AsSpan(length));

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<sbyte> @this)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<sbyte> @this, int length) => Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<ushort> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<ushort> @this, int length) => new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<short> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<short> @this, int length) => new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<char> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<char> @this, int length) => new string(@this.AsSpan(length));

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<uint> @this)
        {
            fixed (void* raw = @this)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<uint> @this, int length)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF32.GetString((byte*)raw, length * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<int> @this)
        {
            fixed (void* raw = @this)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Mut{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Mut<int> @this, int length)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF32.GetString((byte*)raw, length * 4);
            }
        }
        #endregion

        #region PTR Extensions
        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<byte> @this)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<byte> @this, int length) => Encoding.UTF8.GetString(@this.AsSpan(length));

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<sbyte> @this)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<sbyte> @this, int length) => Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<ushort> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<ushort> @this, int length) => new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<short> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<short> @this, int length) => new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<char> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<char> @this, int length) => new string(@this.AsSpan(length));

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<uint> @this)
        {
            fixed (void* raw = @this)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<uint> @this, int length)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF32.GetString((byte*)raw, length * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<int> @this)
        {
            fixed (void* raw = @this)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<int> @this, int length)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF32.GetString((byte*)raw, length * 4);
            }
        }
        #endregion
        #endregion

        #region ReadToStringArray Extensions
        #region 2D Extensions
        #region MutMut Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<byte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<sbyte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<ushort> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<short> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<char> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<uint> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutMut<int> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(int)
            );
        }
        #endregion

        #region MutPtr Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<byte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<sbyte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<ushort> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<short> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<char> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<uint> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this MutPtr<int> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(int)
            );
        }
        #endregion

        #region PtrMut Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<byte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<sbyte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<ushort> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<short> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<char> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<uint> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrMut<int> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(int)
            );
        }
        #endregion

        #region PtrPtr Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<byte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<sbyte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<ushort> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<short> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<char> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<uint> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this PtrPtr<int> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                sizeof(int)
            );
        }
        #endregion
        #endregion

        #region 3DExtensions
        #region MutMutMut Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutMut<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region MutMutPtr Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutMutPtr<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region MutPtrMut Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrMut<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region MutPtrPtr Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this MutPtrPtr<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region PtrMutMut Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutMut<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region PtrMutPtr Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrMutPtr<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region PtrPtrMut Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrMut<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion

        #region PtrPtrPtr Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<byte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<sbyte> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<ushort> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<short> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<char> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<uint> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(this PtrPtrPtr<int> @this, int length, int[] lengths)
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths, sizeof(int)
            );
        }
        #endregion
        #endregion
        #endregion
    }
}
