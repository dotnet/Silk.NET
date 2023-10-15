using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// Represents a constant pointer.
/// </summary>
/// <typeparam name="T">The pointee type.</typeparam>
public readonly unsafe ref struct ConstPtr<T>
    where T : unmanaged
{
    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref readonly T Ref;

    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="ref">The underlying ref.</param>
    public ConstPtr(ref T @ref) => Ref = ref @ref;

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="ConstPtr{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref readonly T GetPinnableReference() => ref Ref;

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref readonly T this[nuint index]
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get => ref Unsafe.Add(ref Unsafe.AsRef(in Ref), index);
    }

    /// <summary>
    /// Creates a span with the given length from this pointer.
    /// </summary>
    /// <param name="len">The span length.</param>
    /// <returns>The span.</returns>
    public ReadOnlySpan<T> AsSpan(int len) =>
        MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in Ref), len);

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from a <see cref="string"/>. This implicitly marshals the string.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns></returns>
    /// <exception cref="InvalidCastException">
    /// <typeparamref name="T"/> was not <see cref="char"/>, <see cref="ushort"/>, <see cref="short"/>,
    /// <see cref="byte"/>, <see cref="sbyte"/>, <see cref="uint"/>, or <see cref="int"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(string str)
    {
        if (typeof(T) == typeof(char) || typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
        {
            return new ConstPtr<T>(
                ref Unsafe.As<char, T>(ref Unsafe.AsRef(in str.GetPinnableReference()))
            );
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            return new ConstPtr<T>(
                ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str)))
            );
        }

        if (typeof(T) == typeof(uint) || typeof(T) == typeof(int))
        {
            return new ConstPtr<T>(
                ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str, 4)))
            );
        }

        static void Throw() => throw new InvalidCastException();
        Throw();
        return default;
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from an array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(T[] array) => array.AsSpan();

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from a span.
    /// </summary>
    /// <param name="span">The span.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(Span<T> span) =>
        new(ref span.GetPinnableReference());

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from a span.
    /// </summary>
    /// <param name="span">The span.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(ReadOnlySpan<T> span) =>
        new(ref Unsafe.AsRef(in span.GetPinnableReference()));

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(T* raw) => new(ref *raw);

    /// <summary>
    /// Creates a null <see cref="ConstPtr{T}"/>.
    /// </summary>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>A null pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(NullPtr _) => new(ref Unsafe.NullRef<T>());

    /// <summary>
    /// Unsafely gets the pointer to the underlying reference of this <see cref="ConstPtr{T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator T*(ConstPtr<T> ptr) =>
        (T*)Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.Ref));

    /// <summary>
    /// Unsafely gets the pointer to the underlying reference of this <see cref="ConstPtr{T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(ConstPtr<T> ptr) =>
        Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.Ref));

    /// <summary>
    /// Converts this pointer to a string.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The string.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator string(ConstPtr<T> ptr)
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
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
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
    public bool Equals(ConstPtr<T> other) =>
        Unsafe.AreSame(ref Unsafe.AsRef(in Ref), ref Unsafe.AsRef(in other.Ref));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() =>
        HashCode.Combine((nint)Unsafe.AsPointer(ref Unsafe.AsRef(in Ref)));

    /// <summary>
    /// Determines whether the given pointers point to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ConstPtr<T> left, ConstPtr<T> right) => left.Equals(right);

    /// <summary>
    /// Determines whether the given pointers point do not to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are not equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ConstPtr<T> left, ConstPtr<T> right) => !left.Equals(right);

    /// <summary>
    /// Determines whether the given pointer is not null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is not null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ConstPtr<T> left, NullPtr _) => !(left == _);

    /// <summary>
    /// Determines whether the given pointer is null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ConstPtr<T> left, NullPtr _) =>
        Unsafe.IsNullRef(ref Unsafe.AsRef(in left.Ref));
}
