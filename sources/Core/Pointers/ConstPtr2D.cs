using System.Runtime.CompilerServices;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// Represents a constant pointer.
/// </summary>
/// <typeparam name="T">The pointee type.</typeparam>
public readonly unsafe ref struct ConstPtr2D<T> where T: unmanaged
{
    private readonly ref byte InteriorRef;

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public ref readonly ConstPtr<T> Ref
    {
        get
        {
            // Would use the delegate* trick but this isn't optimised in JIT yet or necessarily safe
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(ConstPtr2D<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)));
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// Creates a <see cref="ConstPtr2D{T}"/> from a raw pointer.
    /// </summary>
    /// <param name="raw">The raw pointer.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator ConstPtr2D<T>(T** raw) => new(){InteriorRef = *(byte*)raw};
}
