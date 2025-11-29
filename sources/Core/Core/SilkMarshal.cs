using System.Buffers;
using System.Numerics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// Contains marshalling utilities.
/// </summary>
public static unsafe class SilkMarshal
{
    private record GCHandleSentinel(GCHandle Handle)
    {
        public DependentHandle? DependentHandle { get; set; }

        ~GCHandleSentinel()
        {
            DependentHandle?.Dispose();
            Handle.Free();
        }
    }

    /// <summary>
    /// Converts a string into its native representation such that the returned ref can be passed to native.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <param name="charSize">Character size. Must be 1, 2, or 4.</param>
    /// <returns>A reference to the converted bytes.</returns>
    /// <exception cref="ArgumentException">
    /// Either:
    /// <list type="bullet">
    /// <item><description>The character size was not 1, 2 or 4.</description></item>
    /// <item><description><see cref="Utf8.FromUtf16"/> failed.</description></item>
    /// </list>
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly byte StringToNative(ReadOnlySpan<char> str, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in str.GetPinnableReference())))
        {
            return ref Unsafe.NullRef<byte>();
        }

        switch (charSize)
        {
            case 2:
            {
                return ref Unsafe.As<char, byte>(ref Unsafe.AsRef(in str.GetPinnableReference()));
            }
            default:
            {
                return ref StringToArray(str, charSize)![0];
            }
        }
    }

    /// <summary>
    /// Converts a string into its native representation such that the returned array can be passed to native.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <param name="charSize">Character size. Must be 1, 2, or 4.</param>
    /// <returns>The converted bytes.</returns>
    /// <exception cref="ArgumentException">
    /// Either:
    /// <list type="bullet">
    /// <item><description>The character size was not 1, 2 or 4.</description></item>
    /// <item><description><see cref="Utf8.FromUtf16"/> failed.</description></item>
    /// </list>
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[]? StringToArray(ReadOnlySpan<char> str, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in str.GetPinnableReference())))
        {
            return null;
        }

        switch (charSize)
        {
            case 1:
            {
                var maxCharCount = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
                byte[]? arr = null;
                try
                {
                    var utf8 =
                        maxCharCount > 256
                            ? arr = ArrayPool<byte>.Shared.Rent(maxCharCount)
                            : stackalloc byte[maxCharCount];
                    if (
                        Utf8.FromUtf16(str, utf8, out _, out var bytesWritten)
                        != OperationStatus.Done
                    )
                    {
                        throw new ArgumentException("Failed to convert to UTF8", nameof(str));
                    }

                    utf8 = utf8[..(bytesWritten + 1)];
                    utf8[bytesWritten] = 0;
                    var ret = new byte[utf8.Length];
                    utf8.CopyTo(ret);

                    return ret;
                }
                finally
                {
                    if (arr is not null)
                    {
                        ArrayPool<byte>.Shared.Return(arr);
                    }
                }
            }
            case 2:
            {
                var utf16 = new byte[(str.Length + 1) * 2];
                MemoryMarshal
                    .CreateReadOnlySpan(ref Unsafe.AsRef(in str[0]), str.Length + 1)
                    .CopyTo(MemoryMarshal.Cast<byte, char>(utf16.AsSpan()));
                return utf16;
            }
            case 4:
            {
                var maxCharCount = Encoding.UTF32.GetMaxByteCount(str.Length) + 4;
                byte[]? arr = null;
                try
                {
                    var utf32 =
                        maxCharCount > 256
                            ? arr = ArrayPool<byte>.Shared.Rent(maxCharCount)
                            : stackalloc byte[maxCharCount];
                    var bytesWritten = Encoding.UTF32.GetBytes(str, utf32);
                    utf32 = utf32[..(bytesWritten + 4)];
                    Unsafe.As<byte, int>(ref utf32[bytesWritten]) = 0;
                    var ret = new byte[utf32.Length];
                    utf32.CopyTo(ret);

                    return ret;
                }
                finally
                {
                    if (arr is not null)
                    {
                        ArrayPool<byte>.Shared.Return(arr);
                    }
                }
            }
            default:
            {
                throw new ArgumentException(
                    "Invalid char size, must be 1, 2, or 4",
                    nameof(charSize)
                );
            }
        }
    }

#pragma warning disable RS0026 // 'Do not add multiple overloads with optional parameters' - Parameters differ only by span generic type, this is intended.
    /// <summary>
    /// Creates an array containing the native representation of the given string array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static byte[]? StringArrayToArray(ReadOnlySpan<string?> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret.AsSpan());
        for (var i = 0; i < strs.Length; i++)
        {
            var native = StringToArray(strs[i], charSize);
            var handle = GCHandle.Alloc(native, GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            span[i] = handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates a reference to memory containing the native representation of the given string array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns>The reference.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static ref byte StringArrayToNative(ReadOnlySpan<string?> strs, nint charSize = 1)
    {
        var ret = StringArrayToArray(strs, charSize);
        if (ret is null)
        {
            return ref Unsafe.NullRef<byte>();
        }

        return ref ret[0];
    }

    /// <summary>
    /// Creates a reference to memory containing the native representation of the given string 2d jagged array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns>The reference.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    // TODO analyzer to clarify that this only works if the inner array is const.
    public static ref byte StringArrayToNative(ReadOnlySpan<string?[]> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret.AsSpan());
        for (var i = 0; i < strs.Length; i++)
        {
            ref var native = ref StringArrayToNative(strs[i], charSize);
            span[i] = (nint)Unsafe.AsPointer(ref native);
        }

        return ref ret[0];
    }

    /// <summary>
    /// Creates a reference to memory containing the native representation of the given string 3d jagged array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns>The reference.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    // TODO analyzer to clarify that this only works if the inner array is const.
    public static ref byte StringArrayToNative(ReadOnlySpan<string[][]> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret.AsSpan());
        for (var i = 0; i < strs.Length; i++)
        {
            ref var native = ref StringArrayToNative(strs[i], charSize);
            span[i] = (nint)Unsafe.AsPointer(ref native);
        }

        return ref ret[0];
    }

    /// <summary>
    /// Creates an array of pointers from an array of arrays.
    /// </summary>
    /// <param name="array">The span/array.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The created array.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    // TODO analyzer to clarify that this only works if the inner array is const.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T*[] JaggedArrayToPointerArray<T>(ReadOnlySpan<T[]> array)
        where T : unmanaged
    {
        var ret = new T*[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var handle = GCHandle.Alloc(array[i], GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            ret[i] = (T*)handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates an array of pointers from a 3D JaggedArray.
    /// </summary>
    /// <param name="array">The span/array.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The created array.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    // TODO analyzer to clarify that this only works if the inner array is const.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T**[] JaggedArrayToPointerArray<T>(ReadOnlySpan<T[][]> array)
        where T : unmanaged
    {
        var ret = new T**[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var temp = JaggedArrayToPointerArray<T>(array[i]);

            var handle = GCHandle.Alloc(temp, GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            ret[i] = (T**)handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates an array of pointers from a 4D JaggedArray.
    /// </summary>
    /// <param name="array">The span/array.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The created array.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    // TODO analyzer to clarify that this only works if the inner array is const.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T***[] JaggedArrayToPointerArray<T>(ReadOnlySpan<T[][][]> array)
        where T : unmanaged
    {
        var ret = new T***[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var temp = JaggedArrayToPointerArray<T>(array[i]);

            var handle = GCHandle.Alloc(temp, GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            ret[i] = (T***)handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Converts a span of string pointers to a string array.
    /// </summary>
    /// <param name="native">The pointer span.</param>
    /// <param name="charSize">The character size.</param>
    /// <returns>The read string array.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[]? NativeToStringArray(ReadOnlySpan<nint> native, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in native.GetPinnableReference())))
        {
            return null;
        }
        var ret = new string?[native.Length];
        for (var i = 0; i < native.Length; i++)
        {
            ret[i] = NativeToString(ref *(byte*)native[i], charSize);
        }

        return ret;
    }

    /// <summary>
    /// Converts a span of string pointers to an array of string array.
    /// </summary>
    /// <param name="native">The pointer span.</param>
    /// <param name="charSize">The character size.</param>
    /// <param name="lengths">length of the first-level arrays</param>
    /// <returns>The read string array.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[]?[]? NativeToStringArray(
        ReadOnlySpan<nint> native,
        int[] lengths,
        nint charSize = 1
    )
    {
        if (native.IsEmpty || native.Length != lengths.Length)
        {
            return null;
        }

        string?[]?[]? strings = new string[native.Length][];
        for (int i = 0; i < native.Length; i++)
        {
            strings[i] = NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef<byte>((byte*)native[i])),
                    lengths[i]
                ),
                charSize
            );
        }

        return strings;
    }

    /// <summary>
    /// Converts a span of string pointers to an array of string array.
    /// </summary>
    /// <param name="native">The pointer span.</param>
    /// <param name="charSize">The character size.</param>
    /// <param name="lengths0">length of the first-level arrays</param>
    /// <param name="lengths1">length of the second-level arrays</param>
    /// <returns>The read string array.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[]?[]?[]? NativeToStringArray(
        ReadOnlySpan<nint> native,
        int[] lengths0,
        int[] lengths1,
        nint charSize = 1
    )
    {
        if (native.IsEmpty || native.Length != lengths0.Length)
        {
            return null;
        }

        string?[]?[]?[]? strings = new string[native.Length][][];
        for (int i = 0; i < native.Length; i++)
        {
            strings[i] = NativeToStringArray(
                MemoryMarshal.CreateReadOnlySpan(
                    ref Unsafe.As<byte, nint>(ref Unsafe.AsRef<byte>((byte*)native[i])),
                    lengths0[i]
                ),
                lengths1,
                charSize
            );
        }

        return strings;
    }
#pragma warning restore RS0026

    /// <summary>
    /// Converts a byte reference to a string.
    /// </summary>
    /// <param name="native">A reference to the string's native representation.</param>
    /// <param name="charSize">The character size of the native representation.</param>
    /// <returns>The string.</returns>
    /// <exception cref="ArgumentException"><paramref name="native"/> must be 1, 2, or 4.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? NativeToString(ref byte native, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref native))
        {
            return null;
        }
        switch (charSize)
        {
            case 1:
            {
                fixed (byte* ptr = &native)
                {
                    return Encoding.UTF8.GetString(
                        MemoryMarshal.CreateReadOnlySpanFromNullTerminated(ptr)
                    );
                }
            }
            case 2:
            {
                fixed (void* ptr = &native)
                {
                    return new string((char*)ptr);
                }
            }
            case 4:
            {
                fixed (byte* ptr = &native)
                {
                    int words;
                    for (words = 0; ((uint*)ptr)[words] != 0; words++)
                    {
                        // do nothing
                    }

                    return Encoding.UTF32.GetString(ptr, words * 4);
                }
            }
            default:
            {
                throw new ArgumentException("Char size must be 1, 2, or 4", nameof(charSize));
            }
        }
    }

    /// <summary>
    /// Creates a reference from a managed reference.
    /// </summary>
    /// <param name="ref">A reference to a <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static Ref<T> AsRef<T>(ref this T @ref)
        where T : unmanaged => new(ref @ref);

    /// <summary>
    /// Creates a reference from a span.
    /// </summary>
    /// <param name="ref">A span of <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given span's elements.</returns>
    public static Ref<T> AsRef<T>(this Span<T> @ref)
        where T : unmanaged => new(ref @ref.GetPinnableReference());

    /// <summary>
    /// Creates a reference from a readonly span.
    /// </summary>
    /// <param name="ref">A span of <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given span's elements.</returns>
    public static Ref<T> AsRef<T>(this ReadOnlySpan<T> @ref)
        where T : unmanaged => @ref;

    /// <summary>
    /// Creates a 2D Ref from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="Ptr{T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static Ref2D<T> AsRef2D<T>(ref this Ref<T> @ref)
        where T : unmanaged => new(ref @ref);

    /// <summary>
    /// Creates a 2D Ref from a reference to a span.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="Ptr{T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static Ref2D<T> AsRef2D<T>(ref this Span<T> @ref)
        where T : unmanaged
    {
#pragma warning disable IL3050 // Problematic code removed at build time by Fody.
        IL.Emit.Ldarg_0();
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(Ref2D<>).MakeGenericType(typeof(T))),
                TypeRef.Type(typeof(Ref<>).MakeGenericType(typeof(T)).MakeByRefType())
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
#pragma warning restore IL3050
    }

    /// <summary>
    /// Creates a 2D Ref from a reference to a readonly span.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="Ptr{T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static Ref2D<T> AsRef2D<T>(ref this ReadOnlySpan<T> @ref)
        where T : unmanaged
    {
#pragma warning disable IL3050 // Problematic code removed at build time by Fody.
        IL.Emit.Ldarg_0();
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(Ref2D<>).MakeGenericType(typeof(T))),
                TypeRef.Type(typeof(Ref<>).MakeGenericType(typeof(T)).MakeByRefType())
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
#pragma warning restore IL3050
    }

    /// <summary>
    /// Converts a span of ptrs to a 2D jagged array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="span"></param>
    /// <param name="lengths">length of each array in the span</param>
    /// <returns></returns>
    public static T[][] NativeToArray<T>(Span<nint> span, int[] lengths)
        where T : unmanaged
    {
        T[][] ret = new T[span.Length][];
        for (int i = 0; i < span.Length; i++)
        {
            T* ptr = (T*)span[0];

            if (ptr != null)
            {
                ret[i] = new Span<T>(ptr, lengths[i]).ToArray();
            }
        }
        return ret;
    }

    /// <summary>
    /// Converts a span of ptrs to a 3D jagged array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="span"></param>
    /// <param name="lengths0">length of each array in the span</param>
    /// <param name="lengths1">length of each array in the arrays in the span</param>
    /// <returns></returns>
    public static T[][][] NativeToArray<T>(Span<nint> span, int[] lengths0, int[][] lengths1)
        where T : unmanaged
    {
        T[][][] ret = new T[span.Length][][];
        for (int i = 0; i < span.Length; i++)
        {
            T* ptr = (T*)span[0];

            if (ptr != null)
            {
                ret[i] = NativeToArray<T>(new(ptr, lengths0[i]), lengths1[i]);
            }
        }
        return ret;
    }

    /// <summary>
    /// Represents an unsafe constant cast wherein:
    /// <list type="bullet">
    /// <item>
    /// <term>Casts to smaller types truncate the most significant bits.</term>
    /// <description>
    /// The return value is obtained by reinterpreting and dereferencing a pointer to <typeparamref name="TFrom"/> as a
    /// <typeparamref name="TTo"/>, which on a little-endian machine is offset by the absolute byte difference between
    /// the size of <typeparamref name="TFrom"/> and <typeparamref name="TTo"/> to ensure that only the least
    /// significant bits are taken; or an equivalent, more optimised methodology for smaller types.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Casts to larger types fill the most significant bits with zeroes.</term>
    /// <description>
    /// Assignment occurs through reinterpretation of a pointer to a zeroed-out <typeparamref name="TTo"/> to a
    /// <typeparamref name="TFrom"/>, which on a little-endian machine is offset by the absolute byte difference
    /// between the size of <typeparamref name="TFrom"/> and <typeparamref name="TTo"/>, to obtain the return value;
    /// or an equivalent, more optimised methodology for smaller types.
    /// </description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// This is optimised to a <see cref="Unsafe.BitCast{TFrom, TTo}"/> where possible. Namely, where the size of types
    /// are the same or where <typeparamref name="TFrom"/> and <typeparamref name="TTo"/> both have the same size as a
    /// primitive type. This often results in a single CPU instruction (on x64) being emitted when inlined.
    /// </remarks>
    /// <param name="value">The value to cast.</param>
    /// <typeparam name="TFrom">The type to cast from.</typeparam>
    /// <typeparam name="TTo">The type to cast to.</typeparam>
    /// <returns>The casted constant.</returns>
    /// <exception cref="NotImplementedException">
    /// Currently, neither signed numbers that are not primitive-sized nor floating point numbers are supported
    /// <typeparamref name="TTo"/> types.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static TTo ConstCast<TFrom, TTo>(TFrom value)
        where TFrom : unmanaged
        where TTo : unmanaged
    {
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        static TTo UnsignedFallback(TFrom value)
        {
            if (sizeof(TFrom) > sizeof(TTo))
            {
                var valcop = value; // <-- codegen dies otherwise, presumably some pessimism?
                return *(
                    (TTo*)&valcop + (BitConverter.IsLittleEndian ? sizeof(TFrom) - sizeof(TTo) : 0)
                );
            }

            TTo val = default;
            *(TFrom*)(&val + (BitConverter.IsLittleEndian ? sizeof(TTo) - sizeof(TFrom) : 0)) =
                value;
            return val;
        }

        // Sadly switch expression codegen is not optimal so we have the below abominations.
        // I can't wait for the alternatives to Silk.NET to point this out to prospective users and say that this code
        // is disgusting therefore the entire library is disgusting. Yes, I know it's disgusting. The point is we do
        // this for perf so you don't have to!
        //
        // Oh here's the codegen on x64:
        // IntEnum -> int: mov eax, ecx; ret        ShortEnum -> int: movzx eax, cx; ret
        // IntEnum -> uint: mov eax, ecx; ret       ShortEnum -> uint: movzx eax, cx; ret
        // IntEnum -> long: mov eax, ecx; ret       ShortEnum -> long: movzx eax, cx; ret
        // IntEnum -> ulong: mov eax, ecx; ret      ShortEnum -> ulong: movzx eax, cx; ret
        // IntEnum -> short: movsx rax, cx; ret     ShortEnum -> short: movsx rax, cx; ret
        // IntEnum -> ushort: movzx eax, cx; ret    ShortEnum -> ushort: movzx eax, cx; ret
        // IntEnum -> byte: movzx eax, cl; ret      ShortEnum -> byte: movzx eax, cl; ret
        // IntEnum -> sbyte: movsx rax, cl; ret     ShortEnum -> sbyte: movsx rax, cl; ret
        // UIntEnum -> int: mov eax, ecx; ret       UShortEnum -> int: movzx eax, cx; ret
        // UIntEnum -> uint: mov eax, ecx; ret      UShortEnum -> uint: movzx eax, cx; ret
        // UIntEnum -> long: mov eax, ecx; ret      UShortEnum -> long: movzx eax, cx; ret
        // UIntEnum -> ulong: mov eax, ecx; ret     UShortEnum -> ulong: movzx eax, cx; ret
        // UIntEnum -> short: movsx rax, cx; ret    UShortEnum -> short: movsx rax, cx; ret
        // UIntEnum -> ushort: movzx eax, cx; ret   UShortEnum -> ushort: movzx eax, cx; ret
        // UIntEnum -> byte: movzx eax, cl; ret     UShortEnum -> byte: movzx eax, cl; ret
        // UIntEnum -> sbyte: movsx rax, cl; ret    UShortEnum -> sbyte: movsx rax, cl; ret
        // LongEnum -> int: mov eax, ecx; ret       ByteEnum -> int: movzx eax, cl; ret
        // LongEnum -> uint: mov eax, ecx; ret      ByteEnum -> uint: movzx eax, cl; ret
        // LongEnum -> long: mov rax, rcx; ret      ByteEnum -> long: movzx eax, cl; ret
        // LongEnum -> ulong: mov rax, rcx; ret     ByteEnum -> ulong: movzx eax, cl; ret
        // LongEnum -> short: movsx rax, cx; ret    ByteEnum -> short: movzx eax, cl; ret
        // LongEnum -> ushort: movzx eax, cx; ret   ByteEnum -> ushort: movzx eax, cl; ret
        // LongEnum -> byte: movzx eax, cl; ret     ByteEnum -> byte: movzx eax, cl; ret
        // LongEnum -> sbyte: movsx rax, cl; ret    ByteEnum -> sbyte: movsx rax, cl; ret
        // ULongEnum -> int: mov eax, ecx; ret      SByteEnum -> int: movzx eax, cl; ret
        // ULongEnum -> uint: mov eax, ecx; ret     SByteEnum -> uint: movzx eax, cl; ret
        // ULongEnum -> long: mov rax, rcx; ret     SByteEnum -> long: movzx eax, cl; ret
        // ULongEnum -> ulong: mov rax, rcx; ret    SByteEnum -> ulong: movzx eax, cl; ret
        // ULongEnum -> short: movsx rax, cx; ret   SByteEnum -> short: movzx eax, cl; ret
        // ULongEnum -> ushort: movzx eax, cx; ret  SByteEnum -> ushort: movzx eax, cl; ret
        // ULongEnum -> byte: movzx eax, cl; ret    SByteEnum -> byte: movzx eax, cl; ret
        // ULongEnum -> sbyte: movsx rax, cl; ret   SByteEnum -> sbyte: movsx rax, cl; ret

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        static TTo UnsignedCast(TFrom value) =>
            sizeof(TTo) == sizeof(TFrom) ? Unsafe.BitCast<TFrom, TTo>(value)
            : sizeof(TTo) == 1 && sizeof(TFrom) == 2
                ? Unsafe.BitCast<byte, TTo>((byte)Unsafe.BitCast<TFrom, ushort>(value))
            : sizeof(TTo) == 1 && sizeof(TFrom) == 4
                ? Unsafe.BitCast<byte, TTo>((byte)Unsafe.BitCast<TFrom, uint>(value))
            : sizeof(TTo) == 1 && sizeof(TFrom) == 8
                ? Unsafe.BitCast<byte, TTo>((byte)Unsafe.BitCast<TFrom, ulong>(value))
            : sizeof(TTo) == 2 && sizeof(TFrom) == 1
                ? Unsafe.BitCast<ushort, TTo>(Unsafe.BitCast<TFrom, byte>(value))
            : sizeof(TTo) == 2 && sizeof(TFrom) == 4
                ? Unsafe.BitCast<ushort, TTo>((ushort)Unsafe.BitCast<TFrom, uint>(value))
            : sizeof(TTo) == 2 && sizeof(TFrom) == 8
                ? Unsafe.BitCast<ushort, TTo>((ushort)Unsafe.BitCast<TFrom, ulong>(value))
            : sizeof(TTo) == 4 && sizeof(TFrom) == 1
                ? Unsafe.BitCast<uint, TTo>(Unsafe.BitCast<TFrom, byte>(value))
            : sizeof(TTo) == 4 && sizeof(TFrom) == 2
                ? Unsafe.BitCast<uint, TTo>(Unsafe.BitCast<TFrom, ushort>(value))
            : sizeof(TTo) == 4 && sizeof(TFrom) == 8
                ? Unsafe.BitCast<uint, TTo>((uint)Unsafe.BitCast<TFrom, ulong>(value))
            : sizeof(TTo) == 8 && sizeof(TFrom) == 1
                ? Unsafe.BitCast<ulong, TTo>(Unsafe.BitCast<TFrom, byte>(value))
            : sizeof(TTo) == 8 && sizeof(TFrom) == 2
                ? Unsafe.BitCast<ulong, TTo>(Unsafe.BitCast<TFrom, ushort>(value))
            : sizeof(TTo) == 8 && sizeof(TFrom) == 4
                ? Unsafe.BitCast<ulong, TTo>(Unsafe.BitCast<TFrom, uint>(value))
            : UnsignedFallback(value);

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        static TTo SignedFallback(TFrom _) =>
            throw new NotImplementedException(
                "Non-primitive signed numbers are not supported at this time."
            );

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        static TTo SignedCast(TFrom value) =>
            sizeof(TTo) == sizeof(TFrom) ? Unsafe.BitCast<TFrom, TTo>(value)
            : sizeof(TTo) == 1 && sizeof(TFrom) == 2
                ? Unsafe.BitCast<sbyte, TTo>((sbyte)Unsafe.BitCast<TFrom, short>(value))
            : sizeof(TTo) == 1 && sizeof(TFrom) == 4
                ? Unsafe.BitCast<sbyte, TTo>((sbyte)Unsafe.BitCast<TFrom, int>(value))
            : sizeof(TTo) == 1 && sizeof(TFrom) == 8
                ? Unsafe.BitCast<sbyte, TTo>((sbyte)Unsafe.BitCast<TFrom, long>(value))
            : sizeof(TTo) == 2 && sizeof(TFrom) == 1
                ? Unsafe.BitCast<short, TTo>(Unsafe.BitCast<TFrom, sbyte>(value))
            : sizeof(TTo) == 2 && sizeof(TFrom) == 4
                ? Unsafe.BitCast<short, TTo>((short)Unsafe.BitCast<TFrom, int>(value))
            : sizeof(TTo) == 2 && sizeof(TFrom) == 8
                ? Unsafe.BitCast<short, TTo>((short)Unsafe.BitCast<TFrom, long>(value))
            : sizeof(TTo) == 4 && sizeof(TFrom) == 1
                ? Unsafe.BitCast<int, TTo>(Unsafe.BitCast<TFrom, sbyte>(value))
            : sizeof(TTo) == 4 && sizeof(TFrom) == 2
                ? Unsafe.BitCast<int, TTo>(Unsafe.BitCast<TFrom, short>(value))
            : sizeof(TTo) == 4 && sizeof(TFrom) == 8
                ? Unsafe.BitCast<int, TTo>((int)Unsafe.BitCast<TFrom, long>(value))
            : sizeof(TTo) == 8 && sizeof(TFrom) == 1
                ? Unsafe.BitCast<long, TTo>(Unsafe.BitCast<TFrom, sbyte>(value))
            : sizeof(TTo) == 8 && sizeof(TFrom) == 2
                ? Unsafe.BitCast<long, TTo>(Unsafe.BitCast<TFrom, short>(value))
            : sizeof(TTo) == 8 && sizeof(TFrom) == 4
                ? Unsafe.BitCast<long, TTo>(Unsafe.BitCast<TFrom, int>(value))
            : SignedFallback(value);

        return typeof(TTo).IsAssignableTo(typeof(IFloatingPoint<>))
                ? throw new NotImplementedException(
                    "Floating points are not supported at this time."
                )
            : typeof(TTo).IsAssignableTo(typeof(ISignedNumber<>)) ? SignedCast(value)
            : UnsignedCast(value);
    }

    /// <summary>
    /// Holds <see cref="GCHandle"/>s for delegates passed to <see cref="DelegateToPtr{T}"/> to prevent
    /// <see cref="ExecutionEngineException"/>s as a result of the delegate being garbage collected.
    /// </summary>
    private static readonly Dictionary<nint, GCHandle> _delegateGCHandles = new();

    /// <summary>
    /// Gets a function pointer for the given delegate.
    /// </summary>
    /// <param name="delegate">The delegate.</param>
    /// <typeparam name="T">The type of the delegate.</typeparam>
    /// <returns>The function pointer.</returns>
    /// <remarks>
    /// The returned pointer must be freed using <see cref="Free"/> once it is no longer in use.
    /// </remarks>
    public static Ptr DelegateToPtr<T>(T @delegate)
        where T : Delegate
    {
        var gch = GCHandle.Alloc(@delegate);
        var ptr = Marshal.GetFunctionPointerForDelegate(@delegate);
        _delegateGCHandles[ptr] = gch;
        return (void*)ptr;
    }

    /// <summary>
    /// Frees a pointer previously allocated from:
    /// <list type="bullet">
    /// <item><description><see cref="DelegateToPtr{T}"/></description></item>
    /// </list>
    /// </summary>
    /// <param name="ptr">The pointer to free.</param>
    /// <remarks>
    /// Generally this function must be used for any <see cref="SilkMarshal"/> function returning
    /// </remarks>
    public static void Free(Ptr ptr)
    {
        if (_delegateGCHandles.Remove((nint)ptr.Native, out var gch))
        {
            gch.Free();
        }
    }
}
