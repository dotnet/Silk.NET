// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// A helper class that marshals between native and managed types.
    /// </summary>
    public static class SilkMarshal
    {
        /// <summary>
        /// Allocate a new BStr pointer.
        /// </summary>
        /// <param name="length">The length of the string pointer, in bytes.</param>
        /// <returns>A pointer to the created string.</returns>
        public static IntPtr AllocBStr(int length) => Marshal.StringToBSTR(new string('\0', length));

        // Store the GlobalMemory instances so that on .NET 5 the pinned object heap isn't prematurely garbage collected
        // This means that the GlobalMemory is only freed when the user calls Free.
        private static readonly ConcurrentDictionary<IntPtr, GlobalMemory> _marshalledMemory =
            new ConcurrentDictionary<IntPtr, GlobalMemory>();

        // In addition, we should keep track of the memory we allocate dedicated to string arrays. If we don't, we won't
        // know to free the individual strings allocated within memory.
        private static readonly ConcurrentDictionary<GlobalMemory, int> _stringArrays
            = new ConcurrentDictionary<GlobalMemory, int>();

        private static IntPtr RegisterMemory(GlobalMemory memory) => (_marshalledMemory[memory.Handle] = memory).Handle;
        
        /// <summary>
        /// Allocates a block of global memory of the given size.
        /// </summary>
        /// <remarks>
        /// The allocated memory must be manually freed using <see cref="Free"/>.
        /// </remarks>
        /// <param name="length">The number of bytes to allocate.</param>
        /// <returns>The allocated bytes.</returns>
        public static IntPtr Allocate(int length) => RegisterMemory(GlobalMemory.Allocate(length));

        /// <summary>
        /// Frees the specific region of global memory.
        /// </summary>
        /// <param name="memory">The memory to free.</param>
        /// <returns>
        /// Whether the operation was successful or not. If false, the memory likely wasn't allocated with
        /// <see cref="Allocate" />.
        /// </returns>
        public static bool Free(IntPtr memory)
        {
            var ret = _marshalledMemory.TryRemove(memory, out var val);
            if (val is null)
            {
                return ret;
            }

            if (_stringArrays.TryRemove(val, out var numStrings))
            {
                var span = val.AsSpan<IntPtr>();
                for (var i = 0; i < numStrings; i++)
                {
                    Free(span[i]);
                }
            }

            val.Dispose();
            return ret;
        }

        /// <summary>
        /// Gets a <see cref="GlobalMemory"/> object containing a copy of the input string marshalled per the specified
        /// native string encoding.
        /// </summary>
        /// <param name="input">The string to marshal.</param>
        /// <param name="encoding">The target native string encoding.</param>
        /// <returns>The <see cref="GlobalMemory"/> object containing the marshalled string array.</returns>
        public static GlobalMemory StringToMemory
        (
            string input,
            NativeStringEncoding encoding = NativeStringEncoding.Ansi
        )
        {
            return encoding switch
            {
                NativeStringEncoding.BStr => BStrToMemory(Marshal.StringToBSTR(input), input.Length),
                NativeStringEncoding.LPStr => AnsiToMemory(input),
                NativeStringEncoding.LPTStr => Utf8ToMemory(input),
                NativeStringEncoding.LPUTF8Str => Utf8ToMemory(input),
                NativeStringEncoding.LPWStr => WideToMemory(input),
                _ => throw new ArgumentOutOfRangeException(nameof(encoding))
            };

            static unsafe GlobalMemory Utf8ToMemory(string input)
            {
                var memory = GlobalMemory.Allocate(Encoding.UTF8.GetMaxByteCount(input.Length) + 1);
                int convertedBytes;
                fixed (char* firstChar = input)
                {
                    fixed (byte* bytes = memory)
                    {
                        convertedBytes = Encoding.UTF8.GetBytes(firstChar, input.Length, bytes, memory.Length - 1);
                    }
                }

                memory[convertedBytes] = 0;
                return memory;
            }

            static unsafe GlobalMemory AnsiToMemory(string input)
            {
                var memory = GlobalMemory.Allocate((input.Length + 1) * Marshal.SystemMaxDBCSCharSize);
                int convertedBytes;

                fixed (char* firstChar = input)
                {
                    fixed (byte* bytes = memory)
                    {
                        convertedBytes = Encoding.UTF8.GetBytes(firstChar, input.Length, bytes, memory.Length);
                    }
                }

                memory[convertedBytes] = 0;
                return memory;
            }

            static unsafe GlobalMemory WideToMemory(string input)
            {
                var memory = GlobalMemory.Allocate((input.Length + 1) * 2);
                fixed (char* firstChar = input)
                {
                    Buffer.MemoryCopy(firstChar, (void*) memory.Handle, memory.Length, input.Length + 1);
                }

                return memory;
            }
        }

        /// <summary>
        /// Gets a pointer to memory containing a copy of the input string marshalled per the specified
        /// native string encoding.
        /// </summary>
        /// <remarks>
        /// The allocated memory must be manually freed using <see cref="Free"/>.
        /// </remarks>
        /// <param name="input">The string to marshal.</param>
        /// <param name="encoding">The target native string encoding.</param>
        /// <returns>A pointer to the memory containing the marshalled string array.</returns>
        public static IntPtr StringToPtr(string input, NativeStringEncoding encoding = NativeStringEncoding.Ansi)
            => RegisterMemory(StringToMemory(input, encoding));

        /// <summary>
        /// Reads a null-terminated string from unmanaged memory, with the given native encoding.
        /// </summary>
        /// <param name="input">A pointer to memory containing a null-terminated string.</param>
        /// <param name="encoding">The encoding of the string in memory.</param>
        /// <returns>The string read from memory.</returns>
        public static string PtrToString(IntPtr input, NativeStringEncoding encoding = NativeStringEncoding.Ansi)
            => encoding switch
            {
                NativeStringEncoding.BStr => Marshal.PtrToStringBSTR(input),
                NativeStringEncoding.LPStr => Marshal.PtrToStringAnsi(input),
                NativeStringEncoding.LPTStr => Marshal.PtrToStringAuto(input),
                NativeStringEncoding.LPUTF8Str => Utf8PtrToString(input),
                NativeStringEncoding.LPWStr => Marshal.PtrToStringUni(input),
                _ => throw new ArgumentOutOfRangeException(nameof(encoding))
            };

        /// <summary>
        /// Reads a null-terminated string from global memory, with the given native encoding.
        /// </summary>
        /// <param name="input">Global memory containing a null-terminated string.</param>
        /// <param name="e">The encoding of the string in memory.</param>
        /// <returns>The string read from memory.</returns>
        public static string MemoryToString(GlobalMemory input, NativeStringEncoding e = NativeStringEncoding.Ansi)
            => PtrToString(input.Handle, e);

        /// <summary>
        /// Returns a copy of the given string array in global memory, marshalled using the specified encoding.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="e">The encoding of the resultant string array.</param>
        /// <returns>Global memory containing the marshalled string array.</returns>
        public static GlobalMemory StringArrayToMemory
        (
            IReadOnlyList<string> input,
            NativeStringEncoding e = NativeStringEncoding.Ansi
        )
        {
            var memory = GlobalMemory.Allocate(input.Count * IntPtr.Size);
            var span = memory.AsSpan<IntPtr>();
            for (var i = 0; i < input.Count; i++)
            {
                span[i] = StringToPtr(input[i], e);
            }

            return memory;
        }

        /// <summary>
        /// Returns a copy of the given string array in global memory, marshalled using the specified custom marshaller.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="customStringMarshaller">The custom string-to-pointer marshaller to use.</param>
        /// <returns>Global memory containing the marshalled string array.</returns>
        public static GlobalMemory StringArrayToMemory
        (
            IReadOnlyList<string> input,
            Func<string, IntPtr> customStringMarshaller
        )
        {
            var memory = GlobalMemory.Allocate(input.Count * IntPtr.Size);
            var span = memory.AsSpan<IntPtr>();
            for (var i = 0; i < input.Count; i++)
            {
                span[i] = customStringMarshaller(input[i]);
            }

            return memory;
        }

        /// <summary>
        /// Returns a copy of the given string array in memory, marshalled using the specified encoding.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="encoding">The encoding of the resultant string array.</param>
        /// <returns>A pointer to memory containing the marshalled string array.</returns>
        public static IntPtr StringArrayToPtr
        (
            IReadOnlyList<string> input,
            NativeStringEncoding encoding = NativeStringEncoding.Ansi
        )
        {
            var memory = StringArrayToMemory(input, encoding);
            _stringArrays.TryAdd(memory, input.Count);
            return RegisterMemory(memory);
        }

        /// <summary>
        /// Returns a copy of the given string array in memory, marshalled using the given custom string marshaller.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="customStringMarshaller">The marshaller to use for the individual strings in the array.</param>
        /// <returns>A pointer to memory containing the marshalled string array.</returns>
        public static IntPtr StringArrayToPtr
        (
            IReadOnlyList<string> input,
            Func<string, IntPtr> customStringMarshaller
        )
        {
            var memory = StringArrayToMemory(input, customStringMarshaller);
            _stringArrays.TryAdd(memory, input.Count);
            return RegisterMemory(memory);
        }

        /// <summary>
        /// Reads an array null-terminated string from unmanaged memory, with the given native encoding.
        /// </summary>
        /// <param name="input">A pointer to unmanaged memory containing a string array.</param>
        /// <param name="numStrings">The number of strings contained within the string array.</param>
        /// <param name="encoding">The encoding of the strings in memory.</param>
        /// <returns>The read string array.</returns>
        public static unsafe string[] PtrToStringArray
        (
            IntPtr input,
            int numStrings,
            NativeStringEncoding encoding = NativeStringEncoding.Ansi
        )
        {
            var ret = new string[numStrings];
            var ptrs = (IntPtr*) input;
            for (var i = 0; i < numStrings; i++)
            {
                ret[i] = PtrToString(ptrs![i]);
            }

            return ret;
        }
        
        /// <summary>
        /// Reads an array null-terminated string from unmanaged memory, with the given custom pointer-to-string
        /// marshaller.
        /// </summary>
        /// <param name="input">A pointer to unmanaged memory containing a string array.</param>
        /// <param name="numStrings">The number of strings contained within the string array.</param>
        /// <param name="customUnmarshaller">The pointer-to-string marshaller to use.</param>
        /// <returns>The read string array.</returns>
        public static unsafe string[] PtrToStringArray
        (
            IntPtr input,
            int numStrings,
            Func<IntPtr, string> customUnmarshaller
        )
        {
            var ret = new string[numStrings];
            var ptrs = (IntPtr*) input;
            for (var i = 0; i < numStrings; i++)
            {
                ret[i] = customUnmarshaller(ptrs![i]);
            }

            return ret;
        }

        /// <summary>
        /// Reads an array null-terminated string from global memory, with the given native encoding.
        /// </summary>
        /// <param name="input">Global memory containing a string array.</param>
        /// <param name="encoding">The encoding of the strings in memory.</param>
        /// <returns>The read string array.</returns>
        public static string[] MemoryToStringArray
        (
            GlobalMemory input,
            NativeStringEncoding encoding = NativeStringEncoding.Ansi
        ) => PtrToStringArray(input, input.Length / IntPtr.Size, encoding);


        /// <summary>
        /// Reads an array null-terminated string from global memory, with the given pointer-to-string marshaller.
        /// </summary>
        /// <param name="input">Global memory containing a string array.</param>
        /// <param name="customUnmarshaller">The pointer-to-string marshaller to use.</param>
        /// <returns>The read string array.</returns>
        public static string[] MemoryToStringArray
        (
            GlobalMemory input,
            Func<IntPtr, string> customUnmarshaller
        ) => PtrToStringArray(input, input.Length / IntPtr.Size, customUnmarshaller);

        private static unsafe string Utf8PtrToString(IntPtr ptr)
        {
#if NETCOREAPP3_1 || NET5_0
            return Marshal.PtrToStringUTF8(ptr);
#else
            var span = new Span<byte>((void*) ptr, int.MaxValue);
            span = span.Slice(0, span.IndexOf(default(byte)));
            fixed (byte* bytes = span)
            {
                return Encoding.UTF8.GetString(bytes, span.Length);
            }
#endif
        }

        // "Unsafe" methods
        /// <summary>
        /// Gets a <see cref="GlobalMemory"/> object representing this HGlobal.
        /// </summary>
        /// <param name="hGlobal">The HGlobal to wrap.</param>
        /// <param name="length">The length of this HGlobal in bytes.</param>
        /// <returns>An object representing this HGlobal.</returns>
        public static GlobalMemory HGlobalToMemory(IntPtr hGlobal, int length)
            => GlobalMemory.FromHGlobal(hGlobal, length);

        /// <summary>
        /// Gets a <see cref="GlobalMemory"/> object representing this BStr.
        /// </summary>
        /// <param name="bStr">The BStr to wrap.</param>
        /// <param name="length">The length of this BStr in bytes.</param>
        /// <returns>An object representing this BStr.</returns>
        public static GlobalMemory BStrToMemory(IntPtr bStr, int length)
            => GlobalMemory.FromHGlobal(bStr, length);

        /// <summary>
        /// Gets a <see cref="GlobalMemory"/> object representing this pointer.
        /// </summary>
        /// <param name="ptr">The pointer to wrap.</param>
        /// <param name="length">The length of this pointer in bytes.</param>
        /// <returns>An object representing this pointer.</returns>
        /// <remarks>
        /// This is not recommended for use as it may be implied that freeing occurs when this object goes out of scope,
        /// even though this is not the case. If the pointer is a HGlobal or a BStr, use one of the other methods;
        /// otherwise, this method should only be used for accessing <see cref="GlobalMemory"/>'s rich set of APIs and
        /// not to manage lifetime.
        /// </remarks>
        public static GlobalMemory PtrToMemory(IntPtr ptr, int length)
            => GlobalMemory.FromHGlobal(ptr, length);

        // TODO !!!!!!!!!!!!!!! LEGACY METHODS START HERE, DELETE THEM ONCE SILK HAS STOPPED USING THEM !!!!!!!!!!!!!!!

        /// <summary>
        /// Converts a C# string to an ANSI string pointer.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>A pointer to a native ANSI string.</returns>
        [Obsolete]
        public static IntPtr MarshalStringToPtr(string str)
        {
            return Marshal.StringToHGlobalAnsi(str);
        }

        /// <summary>
        /// Converts an ANSI string pointer to a C# string.
        /// </summary>
        /// <param name="str">A pointer to the ANSI string to convert.</param>
        /// <returns>A C# string.</returns>
        [Obsolete]
        public static string MarshalPtrToString(IntPtr str)
        {
            return Marshal.PtrToStringAnsi(str);
        }

        /// <summary>
        /// Free a string pointer.
        /// </summary>
        /// <param name="ptr">The pointer to free.</param>
        [Obsolete]
        public static void FreeStringPtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Allocate a new string pointer.
        /// </summary>
        /// <param name="length">The length of the string pointer, in bytes.</param>
        /// <returns>A pointer to the created string.</returns>
        [Obsolete]
        public static IntPtr NewStringPtr(int length)
        {
            return Marshal.AllocHGlobal(length);
        }

        /// <summary>
        /// Allocate a new string pointer.
        /// </summary>
        /// <param name="length">The length of the string pointer, in bytes.</param>
        /// <returns>A pointer to the created string.</returns>
        [Obsolete]
        public static IntPtr NewStringPtr(uint length)
        {
            return Marshal.AllocHGlobal((int) length);
        }

        /// <summary>
        /// Convert an array of strings into a pointer.
        /// </summary>
        /// <param name="array">The array of strings to convert.</param>
        /// <returns>The new pointer.</returns>
        /// <exception cref="OutOfMemoryException">Thrown if enough memory cannot be allocated.</exception>
        [Obsolete]
        public static IntPtr MarshalStringArrayToPtr(IReadOnlyList<string> array)
        {
            var ptr = IntPtr.Zero;
            if (array != null && array.Count != 0)
            {
                ptr = Marshal.AllocHGlobal(array.Count * IntPtr.Size);
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                var i = 0;
                try
                {
                    for (i = 0; i < array.Count; i++)
                    {
                        var str = MarshalStringToPtr(array[i]);
                        Marshal.WriteIntPtr(ptr, i * IntPtr.Size, str);
                    }
                }
                catch (OutOfMemoryException)
                {
                    for (i -= 1; i >= 0; --i)
                    {
                        Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
                    }

                    Marshal.FreeHGlobal(ptr);

                    throw;
                }
            }

            return ptr;
        }

        /// <summary>
        /// Convert a pointer to a string array.
        /// </summary>
        /// <param name="ptr">The pointer to convert.</param>
        /// <param name="length">The number of strings in the pointer.</param>
        /// <returns>An array of strings.</returns>
        [Obsolete]
        public static string[] MarshalPtrToStringArray(IntPtr ptr, int length)
        {
            var ret = new string[length];
            CopyPtrToStringArray(ptr, ret);
            return ret;
        }

        // TODO: Verify that this works without the array being an out parameter.
        /// <summary>
        /// Convert a pointer to an array of strings.
        /// </summary>
        /// <param name="ptr">The pointer to convert.</param>
        /// <param name="arr">The array to fill with strings.</param>
        [Obsolete]
        public static void CopyPtrToStringArray(IntPtr ptr, string[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }
        }

        /// <summary>
        /// Free an array of strings.
        /// </summary>
        /// <param name="ptr">The pointer to free.</param>
        /// <param name="length">The number of strings in the pointer.</param>
        [Obsolete]
        public static void FreeStringArrayPtr(IntPtr ptr, int length)
        {
            for (var i = 0; i < length; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }

            Marshal.FreeHGlobal(ptr);
        }
    }
}
