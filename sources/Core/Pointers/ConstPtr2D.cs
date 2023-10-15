using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// Represents a constant pointer.
/// </summary>
/// <typeparam name="T">The pointee type.</typeparam>
public readonly unsafe ref struct ConstPtr2D<T>
    where T : unmanaged
{
#pragma warning disable CS0649
    private readonly ref byte InteriorRef;
#pragma warning restore CS0649

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> pointing at the given <see cref="ConstPtr{T}"/>.
    /// </summary>
    /// <param name="ref">The reference to the pointee <see cref="ConstPtr{T}"/>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ConstPtr2D(ref ConstPtr<T> @ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private ConstPtr2D(ref byte interior) => InteriorRef = ref interior;

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public ref readonly ConstPtr<T> Ref
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get
        {
            // Would use the delegate* trick but this isn't optimised in JIT yet or necessarily safe
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                    nameof(InteriorRef)
                )
            );
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref readonly ConstPtr<T> this[nuint index]
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                    nameof(InteriorRef)
                )
            );
            IL.Emit.Ldarg_1();
            IL.Emit.Sizeof<nuint>();
            IL.Emit.Mul();
            IL.Emit.Add();
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// Reads this pointer as a string span.
    /// </summary>
    /// <param name="length">The number of strings contained in this string span.</param>
    /// <returns>The string span.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public ReadOnlySpan<string?> ToStringSpan(int length)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new ArrayTypeMismatchException(
                "Must be a ConstPtr2D<T> where T is byte, sbyte, char, short, ushort, int, or uint."
            );
        }
        return SilkMarshal.NativeToStringArray(
            MemoryMarshal.CreateReadOnlySpan(
                ref Unsafe.As<byte, nint>(ref Unsafe.AsRef(in InteriorRef)),
                length
            ),
            sizeof(T)
        );
    }

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="ConstPtr{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref readonly T* GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(T** raw)
    {
        IL.DeclareLocals(
            new LocalVar("ret", TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))))
        );
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Initobj(TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))));
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Ldarg_0();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ldloc_S("ret");
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from a jagged array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(T[][] array) =>
        SilkMarshal.JaggedArrayToPointerArray<T>(array);

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from a string array.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(string[] array)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new ConstPtr2D<T>(ref SilkMarshal.StringArrayToNative(array, sizeof(T)));
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from a string span.
    /// </summary>
    /// <param name="span">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(ReadOnlySpan<string> span)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new ConstPtr2D<T>(ref SilkMarshal.StringArrayToNative(span, sizeof(T)));
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from a string span.
    /// </summary>
    /// <param name="span">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(Span<string> span)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new ConstPtr2D<T>(ref SilkMarshal.StringArrayToNative(span, sizeof(T)));
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from an array of pointers.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [SuppressMessage("ReSharper", "EntityNameCapturedOnly.Local")]
    public static implicit operator ConstPtr2D<T>(T*[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(T).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                TypeRef.Type(typeof(ConstPtr<>).MakeGenericType(typeof(T)).MakeByRefType())
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a null <see cref="ConstPtr2D{T}"/>.
    /// </summary>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>A null pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(NullPtr _)
    {
        IL.DeclareLocals(
            new LocalVar("ret", TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))))
        );
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Initobj(TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))));
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Ldc_I4_0();
        IL.Emit.Conv_U();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ldloc_S("ret");
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Unsafely gets a raw pointer from a <see cref="ConstPtr2D{T}"/>.
    /// </summary>
    /// <param name="ptr">The <see cref="ConstPtr2D{T}"/>.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void**(ConstPtr2D<T> ptr)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Unsafely gets a raw pointer from a <see cref="ConstPtr2D{T}"/>.
    /// </summary>
    /// <param name="ptr">The <see cref="ConstPtr2D{T}"/>.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator T**(ConstPtr2D<T> ptr) => (T**)(void**)ptr;

    /// <inheritdoc />
    public override bool Equals(object? obj) => false;

    /// <summary>
    /// Determines whether the given pointer points to the same location as this pointer.
    /// </summary>
    /// <param name="other">The other pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(ConstPtr2D<T> other) =>
        Unsafe.AreSame(ref Unsafe.AsRef(in InteriorRef), ref Unsafe.AsRef(in other.InteriorRef));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() =>
        HashCode.Combine((nint)Unsafe.AsPointer(ref Unsafe.AsRef(in InteriorRef)));

    /// <summary>
    /// Determines whether the given pointers point to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ConstPtr2D<T> left, ConstPtr2D<T> right) => left.Equals(right);

    /// <summary>
    /// Determines whether the given pointers point do not to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are not equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ConstPtr2D<T> left, ConstPtr2D<T> right) => !left.Equals(right);

    /// <summary>
    /// Determines whether the given pointer is not null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is not null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(ConstPtr2D<T> left, NullPtr _) => !(left == _);

    /// <summary>
    /// Determines whether the given pointer is null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(ConstPtr2D<T> left, NullPtr _) =>
        Unsafe.IsNullRef(ref Unsafe.AsRef(in left.InteriorRef));
}
