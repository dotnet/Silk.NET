using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// Represents a constant that optionally can be represented as an enum. This allows both constant integers and
/// enumerated members to be used by the same parameter without a cast.
/// </summary>
/// <param name="Value">The underlying value.</param>
/// <typeparam name="TUnderlying">The underlying value type.</typeparam>
/// <typeparam name="TEnum1">
/// An enum that can be used in place of a <typeparamref name="TUnderlying"/> constant.
/// </typeparam>
/// <typeparam name="TEnum2">
/// Another enum that can be used in place of a <typeparamref name="TUnderlying"/> constant.
/// </typeparam>
public readonly record struct Constant<TUnderlying, TEnum1, TEnum2>(TUnderlying Value)
    where TUnderlying : unmanaged
    where TEnum1 : unmanaged
    where TEnum2 : unmanaged
{
    /// <summary>
    /// Creates a <see cref="Constant{TUnderlying,TEnum1,TEnum2}"/> from its underlying value.
    /// </summary>
    /// <param name="value">The underlying value.</param>
    /// <returns>The constant.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Constant<TUnderlying, TEnum1, TEnum2>(TUnderlying value) =>
        new(value);

    /// <summary>
    /// Creates a <see cref="Constant{TUnderlying,TEnum1,TEnum2}"/> from the given <typeparamref name="TEnum1"/>.
    /// </summary>
    /// <param name="value">The enum.</param>
    /// <returns>The value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Constant<TUnderlying, TEnum1, TEnum2>(TEnum1 value) =>
        SilkMarshal.ConstCast<TEnum1, TUnderlying>(value);

    /// <summary>
    /// Creates a <see cref="Constant{TUnderlying,TEnum1,TEnum2}"/> from the given <typeparamref name="TEnum2"/>.
    /// </summary>
    /// <param name="value">The enum.</param>
    /// <returns>The value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Constant<TUnderlying, TEnum1, TEnum2>(TEnum2 value) =>
        SilkMarshal.ConstCast<TEnum2, TUnderlying>(value);

    /// <summary>
    /// Gets the underlying value.
    /// </summary>
    /// <param name="value">The constant.</param>
    /// <returns>The underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator TUnderlying(Constant<TUnderlying, TEnum1, TEnum2> value) =>
        value.Value;

    /// <summary>
    /// Gets the underlying value as a <typeparamref name="TEnum1"/>.
    /// </summary>
    /// <param name="value">The constant.</param>
    /// <returns>The value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator TEnum1(Constant<TUnderlying, TEnum1, TEnum2> value) =>
        SilkMarshal.ConstCast<TUnderlying, TEnum1>(value);

    /// <summary>
    /// Gets the underlying value as a <typeparamref name="TEnum2"/>.
    /// </summary>
    /// <param name="value">The constant.</param>
    /// <returns>The value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator TEnum2(Constant<TUnderlying, TEnum1, TEnum2> value) =>
        SilkMarshal.ConstCast<TUnderlying, TEnum2>(value);
}
