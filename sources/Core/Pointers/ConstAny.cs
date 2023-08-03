using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Core;

/// <summary>
/// Represents an untyped constant pointer.
/// </summary>
public readonly unsafe ref struct ConstAny
{
    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref readonly byte Ref;

    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="ref">The underlying ref.</param>
    public ConstAny(ref byte @ref) => Ref = ref @ref;

    /// <summary>
    /// Creates an untyped pointer from a typed reference.
    /// </summary>
    /// <param name="ref">The </param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static ConstAny Create<T>(in T @ref) => new ConstAny(ref Unsafe.As<T, byte>(ref Unsafe.AsRef(in @ref)));

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="ConstAny"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref readonly byte GetPinnableReference() => ref Ref;

    /// <summary>
    /// Creates a span with the given length from this pointer.
    /// </summary>
    /// <param name="len">The span length.</param>
    /// <returns>The span.</returns>
    public ReadOnlySpan<T> AsSpan<T>(int len) =>
        MemoryMarshal.CreateReadOnlySpan(ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in Ref)), len);

    // TODO strings?

    /// <summary>
    /// Creates a <see cref="ConstAny"/> from an array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstAny(Array array) => new(ref MemoryMarshal.GetArrayDataReference(array));

    // TODO spans?

    /// <summary>
    /// Creates a <see cref="ConstAny"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstAny(void* raw) => new(ref *(byte*)raw);

    /// <summary>
    /// Creates a null <see cref="ConstAny"/>.
    /// </summary>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>A null pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstAny(NullPtr _) => new(ref Unsafe.NullRef<byte>());

    /// <summary>
    /// Unsafely gets the pointer to the underlying reference of this <see cref="ConstAny"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(ConstAny ptr) => Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.Ref));

    // TODO strings?

    /// <inheritdoc />
    public override bool Equals(object? obj) => false;

    /// <summary>
    /// Determines whether the given pointer points to the same location as this pointer.
    /// </summary>
    /// <param name="other">The other pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(ConstAny other) => Unsafe.AreSame(ref Unsafe.AsRef(in Ref), ref Unsafe.AsRef(in other.Ref));

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
    public static bool operator ==(ConstAny left, ConstAny right) => left.Equals(right);

    /// <summary>
    /// Determines whether the given pointers point do not to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are not equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ConstAny left, ConstAny right) => !left.Equals(right);

    /// <summary>
    /// Determines whether the given pointer is not null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is not null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ConstAny left, NullPtr _) => !(left == _);

    /// <summary>
    /// Determines whether the given pointer is null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ConstAny left, NullPtr _) => Unsafe.IsNullRef(ref Unsafe.AsRef(in left.Ref));
}
