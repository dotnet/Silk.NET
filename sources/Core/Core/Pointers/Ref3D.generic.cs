// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// A three-dimensional  managed reference wrapper class
/// </summary>
public unsafe readonly ref struct Ref3D<T>
    where T : unmanaged
{
    /// <summary>
    /// Creates a reference with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public Ref3D(ref Ref2D<T> @Ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(Ref3D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a reference with the given underlying ref.
    /// </summary>
    /// <param name="InteriorRef">The underlying ref.</param>
    internal Ref3D(ref byte @InteriorRef)
    {
        this.InteriorRef = ref @InteriorRef;
    }

    /// <summary>
    /// The underlying reference
    /// </summary>
    public readonly ref Ref2D<T> Ref
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
                    TypeRef.Type(typeof(Ref3D<>).MakeGenericType(typeof(T))),
                    nameof(InteriorRef)
                )
            );
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// The underlying generic reference
    /// </summary>
    public readonly ref readonly byte GetInteriorRef() => ref InteriorRef;

    private readonly ref byte InteriorRef;

    /// <summary>
    /// Gets the item at the given offset from this reference.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref Ref2D<T> this[nuint index]
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(Ref3D<>).MakeGenericType(typeof(T))),
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
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="Ref3D{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref T** GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(Ref3D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Determines if this <see cref="Ref3D{T}"/> equals another object
    /// Always returns false as ref structs cannot be passed in, so it will never be true
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Whether this object is the same as </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals([NotNullWhen(true)] object? obj) => false;

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => InteriorRef.GetHashCode();

    /// <summary>
    /// Determines if two <see cref="Ref3D{T}"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ref3D<T> lh, Ref3D<T> rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="Ref3D{T}"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ref3D<T> lh, Ref3D<T> rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="Ref3D{T}"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe implicit operator Ref3D<T>(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="Ref3D{T}"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Ref3D{T}"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ref3D<T> lh, NullPtr rh) => lh == (Ref3D<T>)rh;

    /// <summary>
    /// Determines whether a <see cref="Ref3D{T}"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Ref3D{T}"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ref3D<T> lh, NullPtr rh) => lh != (Ref3D<T>)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Ref3D{T}"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Ref3D{T}"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, Ref3D<T> rh) => (Ref3D<T>)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Ref3D{T}"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Ref3D{T}"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, Ref3D<T> rh) => (Ref3D<T>)lh != rh;

    /// <summary>
    /// Creates a <see cref="Ref3D{T}"/> from a void reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref3D<T>(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a void reference from a <see cref="Ref3D{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(Ref3D<T> ptr) =>
        Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// Creates a <see cref="Ref3D{T}"/> from a reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref3D<T>(T*** ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a reference from a <see cref="Ref3D{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator T***(Ref3D<T> ptr) =>
        (T***)Unsafe.AsPointer(ref ptr.InteriorRef);

    /// <summary>
    /// creates a <see cref="Ref3D{T}"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref3D<T>(T[][][] array) =>
        SilkMarshal.JaggedArrayToPointerArray<T>(array);

    /// <summary>
    /// Expresses this <see cref="Ref3D{T}" /> as a <see cref="Ref"/>. Note that this does not index the
    /// <see cref="Ref3D{T}"/>'s dimensions, and is effectively equivalent to converting a <c>void***</c> to a
    /// <c>void*</c>.
    /// </summary>
    /// <param name="ptr">The <see cref="Ref3D{T}"/>.</param>
    /// <returns>The <see cref="Ref"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref(Ref3D<T> ptr) => new(ref ptr.InteriorRef);

    /// <summary>
    /// creates a <see cref="Ref3D{T}"/> from a reference array
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ref3D<T>(T**[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(T).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(Ref3D<>).MakeGenericType(typeof(T))),
                TypeRef.Type(typeof(Ref2D<>).MakeGenericType(typeof(T))).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Create a non-generic version of <see cref="Ref3D{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ref3D(Ref3D<T> ptr) => new(ref ptr.InteriorRef);

    /// <summary>
    /// Creates a <see cref="Ref3D"/> from a string array.
    /// </summary>
    /// <param name="array">The string array.</param>
    /// <returns>The <see cref="Ref3D{T}"/></returns>
    public static implicit operator Ref3D<T>(string?[][] array) =>
        new(ref SilkMarshal.StringArrayToNative(array, sizeof(T)));
}
