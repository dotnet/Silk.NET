using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// Represents an untyped constant pointer.
/// </summary>
public readonly unsafe ref struct Any2D
{
#pragma warning disable CS0649
    private readonly ref byte InteriorRef;
#pragma warning restore CS0649

    /// <summary>
    /// Creates a <see cref="Any"/> pointing at the given <see cref="ConstPtr{T}"/>.
    /// </summary>
    /// <param name="ref">The reference to the pointee <see cref="ConstPtr{T}"/>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Any2D(ref Any @ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(FieldRef.Field(TypeRef.Type(typeof(Any2D)), nameof(InteriorRef)));
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Any2D(ref byte interior) => InteriorRef = ref interior;

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public ref Any Ref
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            // Would use the delegate* trick but this isn't optimised in JIT yet or necessarily safe
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Any2D)),
                nameof(InteriorRef)));
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref Any this[nuint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Any2D)),
                nameof(InteriorRef)));
            IL.Emit.Ldarg_1();
            IL.Emit.Sizeof<nuint>();
            IL.Emit.Mul();
            IL.Emit.Add();
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    // TODO strings?

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="ConstPtr{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref void* GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Any2D)),
            nameof(InteriorRef)));
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a <see cref="Any2D"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Any2D(void** raw)
    {
        IL.DeclareLocals(new LocalVar("ret", TypeRef.Type(typeof(Any2D))));
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Initobj(TypeRef.Type(typeof(Any2D)));
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Ldarg_0();
        IL.Emit.Stfld(
            FieldRef.Field(TypeRef.Type(typeof(Any2D)), nameof(InteriorRef)));
        IL.Emit.Ldloc_S("ret");
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    // TODO arrays?

    // TODO strings?

    /// <summary>
    /// Creates a <see cref="Any2D"/> from an array of pointers.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [SuppressMessage("ReSharper", "EntityNameCapturedOnly.Local")]
    public static implicit operator Any2D(void*[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(void).MakePointerType()));
        IL.Emit.Newobj(MethodRef.Constructor(TypeRef.Type(typeof(Any2D)),
            TypeRef.Type(typeof(Any).MakeByRefType())));
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a null <see cref="Any2D"/>.
    /// </summary>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>A null pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Any2D(NullPtr _)
    {
        IL.DeclareLocals(new LocalVar("ret", TypeRef.Type(typeof(Any2D))));
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Initobj(TypeRef.Type(typeof(Any2D)));
        IL.Emit.Ldloca_S("ret");
        IL.Emit.Ldc_I4_0();
        IL.Emit.Conv_U();
        IL.Emit.Stfld(
            FieldRef.Field(TypeRef.Type(typeof(Any2D)), nameof(InteriorRef)));
        IL.Emit.Ldloc_S("ret");
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Unsafely gets a raw pointer from a <see cref="Any2D"/>.
    /// </summary>
    /// <param name="ptr">The <see cref="Any2D"/>.</param>
    /// <returns>The raw pointer.</returns>
    /// <remarks>
    /// This is unsafe if the reference is a managed reference. You should prefer pinning using <c>fixed</c> instead.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void**(Any2D ptr)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(TypeRef.Type(typeof(Any2D)), nameof(InteriorRef)));
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <inheritdoc />
    public override bool Equals(object? obj) => false;

    /// <summary>
    /// Determines whether the given pointer points to the same location as this pointer.
    /// </summary>
    /// <param name="other">The other pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public bool Equals(Any2D other) =>
        Unsafe.AreSame(ref Unsafe.AsRef(in InteriorRef), ref Unsafe.AsRef(in other.InteriorRef));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => HashCode.Combine((nint)Unsafe.AsPointer(ref Unsafe.AsRef(in InteriorRef)));

    /// <summary>
    /// Determines whether the given pointers point to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Any2D left, Any2D right) => left.Equals(right);

    /// <summary>
    /// Determines whether the given pointers point do not to the same location.
    /// </summary>
    /// <param name="left">The first pointer.</param>
    /// <param name="right">The second pointer.</param>
    /// <returns>Whether the pointers are not equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Any2D left, Any2D right) => !left.Equals(right);

    /// <summary>
    /// Determines whether the given pointer is not null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is not null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Any2D left, NullPtr _) => !(left == _);

    /// <summary>
    /// Determines whether the given pointer is null.
    /// </summary>
    /// <param name="left">The pointer.</param>
    /// <param name="_"><see cref="DSL.nullptr"/></param>
    /// <returns>Whether the pointer is null.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Any2D left, NullPtr _) =>
        Unsafe.IsNullRef(ref Unsafe.AsRef(in left.InteriorRef));
}
