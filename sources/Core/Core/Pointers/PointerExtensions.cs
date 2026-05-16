using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core
{
    /// <summary>
    /// Class containing extension methods for pointer types
    /// </summary>
    public unsafe static class PointerExtensions
    {
        #region ReadToString Extensions
        #region Ref Extensions
        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<byte> @this)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<byte> @this, int length) =>
            Encoding.UTF8.GetString(@this.AsSpan(length));

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<sbyte> @this)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<sbyte> @this, int length) =>
            Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<ushort> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<ushort> @this, int length) =>
            new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<short> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<short> @this, int length) =>
            new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<char> @this)
        {
            fixed (void* raw = @this)
            {
                return new string((char*)raw);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<char> @this, int length) =>
            new string(@this.AsSpan(length));

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<uint> @this)
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
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<uint> @this, int length)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF32.GetString((byte*)raw, length * 4);
            }
        }

        /// <summary>
        /// Creates a string from this <see cref="Ref{T}"/> as a c-style string
        /// </summary>
        /// <param name="this"></param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<int> @this)
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
        /// Creates a string from this <see cref="Ref{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ref<int> @this, int length)
        {
            fixed (void* raw = @this)
            {
                return Encoding.UTF32.GetString((byte*)raw, length * 4);
            }
        }
        #endregion

        #region Ptr Extensions
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
        public static string ReadToString(this Ptr<byte> @this, int length) =>
            Encoding.UTF8.GetString(@this.AsSpan(length));

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
        /// Populates the given span with the characters of this <see cref="Ptr{T}"/> as a c-style string.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="span">The span to populate characters into</param>
        /// <returns>True if the given span is of sufficient length and can be filled - false otherwise, in which case
        /// no data has been modified in the given span</returns>
        public static bool TryReadToSpan(this Ptr<sbyte> @this, ref Span<char> span)
        {
            fixed (void* raw = @this)
            {
                var bytes = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw);
                var count = Encoding.UTF8.GetCharCount(bytes);
                if (span.Length < count)
                {
                    return false;
                }

                #if DEBUG
                // This if-def is here to prevent this constant string from taking up space in extremely constrained
                // release environments.
                const string assertionLog = $"{nameof(Encoding)}.{nameof(Encoding.UTF8)}." +
                                            $"{nameof(Encoding.UTF8.GetChars)}) returned an unexpected number of " +
                                            $"characters";

                var charCount = Encoding.UTF8.GetChars(bytes, span);
                Debug.Assert(charCount == count, assertionLog);;
                #else
                Encoding.UTF8.GetChars(bytes, span);
                #endif

                span = span[..count];
                return true;
            }
        }


        /// <summary>
        /// Creates a string from this <see cref="Ptr{T}"/> with the given length
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">length of the string</param>
        /// <returns>the string</returns>
        public static string ReadToString(this Ptr<sbyte> @this, int length) =>
            Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

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
        public static string ReadToString(this Ptr<ushort> @this, int length) =>
            new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

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
        public static string ReadToString(this Ptr<short> @this, int length) =>
            new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

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
        public static string ReadToString(this Ptr<char> @this, int length) =>
            new string(@this.AsSpan(length));

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
        #region Ref2D Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ref2D<byte> @this, int length)
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
        public static string?[]? ReadToStringArray(this Ref2D<sbyte> @this, int length)
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
        public static string?[]? ReadToStringArray(this Ref2D<ushort> @this, int length)
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
        public static string?[]? ReadToStringArray(this Ref2D<short> @this, int length)
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
        public static string?[]? ReadToStringArray(this Ref2D<char> @this, int length)
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
        public static string?[]? ReadToStringArray(this Ref2D<uint> @this, int length)
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
        public static string?[]? ReadToStringArray(this Ref2D<int> @this, int length)
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

        #region Ptr2D Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<byte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<sbyte> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<ushort> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<short> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<char> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<uint> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of strings contained in the string array.</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]? ReadToStringArray(this Ptr2D<int> @this, int length)
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                sizeof(int)
            );
        }
        #endregion
        #endregion

        #region 3DExtensions
        #region Ref3D Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<byte> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<sbyte> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<ushort> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<short> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<char> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<uint> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ref3D<int> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in @this.GetInteriorRef())),
                    length
                ),
                lengths,
                sizeof(int)
            );
        }
        #endregion

        #region Ptr3D Extensions
        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<byte> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(byte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<sbyte> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(sbyte)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<ushort> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(ushort)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<short> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(short)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<char> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(char)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<uint> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(uint)
            );
        }

        /// <summary>
        /// Reads this pointer as a string array.
        /// </summary>
        /// <param name="length">The number of arrays contained in the top-level array.</param>
        /// <param name="lengths">The number of strings in the array</param>
        /// <param name="this"></param>
        /// <returns>The string array.</returns>
        public static string?[]?[]? ReadToStringArray(
            this Ptr3D<int> @this,
            int length,
            int[] lengths
        )
        {
            return SilkMarshal.NativeToStringArray(
                new ReadOnlySpan<nint>(@this.Native, length),
                lengths,
                sizeof(int)
            );
        }
        #endregion
        #endregion
        #endregion
    }
}
