// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// A three-dimensional managed reference wrapper class
/// </summary>
public unsafe readonly ref struct Ref3D
{
    /// <summary>
    /// Creates a reference with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public Ref3D(ref Ref2D @Ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(FieldRef.Field(TypeRef.Type(typeof(Ref3D)), nameof(InteriorRef)));
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
    public readonly ref Ref2D Ref
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get
        {
            // Would use the delegate* trick but this isn't optimised in JIT yet or necessarily safe
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Ref3D)), nameof(InteriorRef)));
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
    public ref Ref2D this[nuint index]
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Ref3D)), nameof(InteriorRef)));
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
    /// This function allows a <see cref="Ref3D"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref void** GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Ref3D)), nameof(InteriorRef)));
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Determines if this <see cref="Ref3D"/> equals another object
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
    /// Determines if two <see cref="Ref3D"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ref3D lh, Ref3D rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="Ref3D"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ref3D lh, Ref3D rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="Ref3D"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe implicit operator Ref3D(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="Ref3D"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Ref3D"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ref3D lh, NullPtr rh) => lh == (Ref3D)rh;

    /// <summary>
    /// Determines whether a <see cref="Ref3D"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Ref3D"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ref3D lh, NullPtr rh) => lh != (Ref3D)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Ref3D"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Ref3D"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, Ref3D rh) => (Ref3D)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Ref3D"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Ref3D"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, Ref3D rh) => (Ref3D)lh != rh;

    /// <summary>
    /// Creates a <see cref="Ref3D"/> from a void reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref3D(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a void reference from a <see cref="Ref3D"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(Ref3D ptr) =>
        Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// Creates a <see cref="Ref3D"/> from a reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref3D(byte*** ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a reference from a <see cref="Ref3D"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator byte***(Ref3D ptr) =>
        (byte***)Unsafe.AsRef(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// creates a <see cref="Ref3D"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref3D(byte[][][] array) =>
        SilkMarshal.JaggedArrayToPointerArray<byte>(array);

    /// <summary>
    /// creates a <see cref="Ref3D"/> from a reference array
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ref3D(byte**[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(byte).MakeByRefType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(Ref3D)),
                TypeRef.Type(typeof(Ref2D)).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a <see cref="Ref3D"/> from a string array.
    /// </summary>
    /// <param name="array">The string array.</param>
    /// <returns>The <see cref="Ref3D{T}"/></returns>
    public static implicit operator Ref3D(string[][] array) =>
        new(ref SilkMarshal.StringArrayToNative(array));
}
