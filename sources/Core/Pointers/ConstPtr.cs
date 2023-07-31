using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// Represents a constant pointer.
/// </summary>
/// <typeparam name="T">The pointee type.</typeparam>
public readonly unsafe ref struct ConstPtr<T> where T: unmanaged
{
    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref T Ref;

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
            return new ConstPtr<T> {Ref = Unsafe.As<char, T>(ref Unsafe.AsRef(in str.GetPinnableReference()))};
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            return new ConstPtr<T> {Ref = Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str)))};
        }

        if (typeof(T) == typeof(uint) || typeof(T) == typeof(int))
        {
            return new ConstPtr<T> {Ref = Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str, 4)))};
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
    public static implicit operator ConstPtr<T>(Span<T> span) => new(){Ref = span.GetPinnableReference()};

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from a span.
    /// </summary>
    /// <param name="span">The span.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(ReadOnlySpan<T> span) => new(){Ref = span.GetPinnableReference()};

    /// <summary>
    /// Creates a <see cref="ConstPtr{T}"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(T* raw) => new(){Ref = *raw};

    /// <summary>
    /// Creates a null <see cref="ConstPtr{T}"/>.
    /// </summary>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>A null pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr<T>(NullPtr _) => new(){Ref = Unsafe.NullRef<T>()};
}
