using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// Represents a pointer.
/// </summary>
/// <typeparam name="T">The pointee type.</typeparam>
public readonly unsafe ref struct Ptr<T> where T: unmanaged
{
    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref T Ref;

    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="ref">The underlying ref.</param>
    public Ptr(ref T @ref) => Ref = ref @ref;

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="Ptr{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref T GetPinnableReference() => ref Ref;

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref T this[nuint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get => ref Unsafe.Add(ref Ref, index);
    }

    /// <summary>
    /// Creates a span with the given length from this pointer.
    /// </summary>
    /// <param name="len">The span length.</param>
    /// <returns>The span.</returns>
    public Span<T> AsSpan(int len) => MemoryMarshal.CreateSpan(ref Ref, len);

    /// <summary>
    /// Creates a <see cref="Ptr{T}"/> from a <see cref="string"/>. This implicitly marshals the string.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns></returns>
    /// <exception cref="InvalidCastException">
    /// <typeparamref name="T"/> was not <see cref="char"/>, <see cref="ushort"/>, <see cref="short"/>,
    /// <see cref="byte"/>, <see cref="sbyte"/>, <see cref="uint"/>, or <see cref="int"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ptr<T>(string str)
    {
        if (typeof(T) != typeof(byte) && typeof(T) != typeof(sbyte) && typeof(T) != typeof(char) &&
            typeof(T) != typeof(short) && typeof(T) != typeof(ushort) && typeof(T) != typeof(int) &&
            typeof(T) != typeof(uint))
        {
            throw new InvalidCastException();
        }

        // Don't use StringToNative as that intentionally returns an immutable ref (so we can take a reference directly
        // to the string in the UTF-16 case)
        var ret = SilkMarshal.StringToArray(str, sizeof(T));
        return ret is null ? default : new Ptr<T>(ref Unsafe.As<byte, T>(ref ret[0]));
    }

    /// <summary>
    /// Creates a <see cref="Ptr{T}"/> from an array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ptr<T>(T[] array) => array.AsSpan();

    /// <summary>
    /// Creates a <see cref="Ptr{T}"/> from a span.
    /// </summary>
    /// <param name="span">The span.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ptr<T>(Span<T> span) => new(ref span.GetPinnableReference());

    /// <summary>
    /// Creates a <see cref="Ptr{T}"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ptr<T>(T* raw) => new(ref *raw);

    /// <summary>
    /// Creates a null <see cref="Ptr{T}"/>.
    /// </summary>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>A null pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ptr<T>(NullPtr _) => new(ref Unsafe.NullRef<T>());

    /// <summary>
    /// Unsafely gets the pointer to the underlying reference of this <see cref="Ptr{T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator T*(Ptr<T> ptr) => (T*) Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.Ref));

    /// <summary>
    /// Unsafely gets the pointer to the underlying reference of this <see cref="Ptr{T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(Ptr<T> ptr) => Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.Ref));

    /// <summary>
    /// Converts this pointer to a string.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The string.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator string(Ptr<T> ptr)
    {
        if (typeof(T) == typeof(char) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
        {
            fixed (void* raw = ptr)
            {
                return new string((char*)raw);
            }
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            fixed (void* raw = ptr)
            {
                return Encoding.UTF8.GetString(MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw));
            }
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(uint))
        {
            fixed (void* raw = ptr)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        throw new InvalidCastException();
    }

    /// <inheritdoc />
    public override bool Equals(object? obj) => false;

    /// <summary>
    /// Determines whether the given pointer points to the same location as this pointer.
    /// </summary>
    /// <param name="other">The other pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Ptr<T> other) => Unsafe.AreSame(ref Unsafe.AsRef(in Ref), ref Unsafe.AsRef(in other.Ref));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine((nint)Unsafe.AsPointer(ref Unsafe.AsRef(in Ref)));

    /// <summary>
    /// Determines whether the given pointers point to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ptr<T> left, Ptr<T> right) => left.Equals(right);

    /// <summary>
    /// Determines whether the given pointers point do not to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are not equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ptr<T> left, Ptr<T> right) => !left.Equals(right);

    /// <summary>
    /// Determines whether the given pointer is not null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is not null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ptr<T> left, NullPtr _) => !(left == _);

    /// <summary>
    /// Determines whether the given pointer is null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ptr<T> left, NullPtr _) => Unsafe.IsNullRef(ref Unsafe.AsRef(in left.Ref));
}
