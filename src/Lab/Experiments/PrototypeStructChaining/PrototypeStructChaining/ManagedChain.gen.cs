// ReSharper disable StaticMemberInGenericType
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.Net.Vulkan;

/// <summary>
///  Static class for creating Managed Chains.
/// </summary>
public abstract class ManagedChain : IReadOnlyList<IChainable>, IDisposable
{
    /// <inheritdoc />
    public abstract IEnumerator<IChainable> GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc />
    public abstract int Count { get; }
    
    /// <inheritdoc />
    public abstract IChainable this[int index] { get; }

    /// <inheritdoc />
    public abstract void Dispose();

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    public static ManagedChain<TChain> Create<TChain>(TChain head = default)
        where TChain : struct, IChainStart
    {
        return new(head);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    public static ManagedChain<TChain> Load<TChain>(out string errors, TChain chain)
        where TChain : struct, IChainStart
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    public static ManagedChain<TChain> Load<TChain>(TChain chain)
        where TChain : struct, IChainStart
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    public static ManagedChain<TChain, T1> Create<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
    {
        return new(head, item1);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    public static ManagedChain<TChain, T1> Load<TChain, T1>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    public static ManagedChain<TChain, T1> Load<TChain, T1>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    public static ManagedChain<TChain, T1, T2> Create<TChain, T1, T2>(TChain head = default, T1 item1 = default, T2 item2 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    public static ManagedChain<TChain, T1, T2> Load<TChain, T1, T2>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    public static ManagedChain<TChain, T1, T2> Load<TChain, T1, T2>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3> Create<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3> Load<TChain, T1, T2, T3>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3> Load<TChain, T1, T2, T3>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4> Create<TChain, T1, T2, T3, T4>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4> Load<TChain, T1, T2, T3, T4>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4> Load<TChain, T1, T2, T3, T4>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Create<TChain, T1, T2, T3, T4, T5>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Load<TChain, T1, T2, T3, T4, T5>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Load<TChain, T1, T2, T3, T4, T5>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Create<TChain, T1, T2, T3, T4, T5, T6>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Load<TChain, T1, T2, T3, T4, T5, T6>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Load<TChain, T1, T2, T3, T4, T5, T6>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Create<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Load<TChain, T1, T2, T3, T4, T5, T6, T7>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Load<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <typeparam name="T15">Type of Item 15.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
        where T15 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
        where T15 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
        where T15 : struct, IExtendsChain<TChain>
    {
        return new(out var _, chain);
    }

}

/// <summary>
/// A <see cref="ManagedChain{TChain}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
public unsafe class ManagedChain<TChain> : ManagedChain
    where TChain : struct, IChainStart
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = HeadSize;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    public ManagedChain(TChain head = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        HeadPtr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        errors = string.Empty;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        return new ManagedChain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="T1">Type of Item 1</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1> Append<T1>(T1 item1 = default)
        where T1: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1>(this, item1);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
    }

    /// <inheritdoc />
    public override int Count => 1;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    public void Deconstruct(out TChain head)
    {
            head = Head;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
public unsafe class ManagedChain<TChain, T1> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item1Offset + Item1Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public ManagedChain(TChain head = default, T1 item1 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        Item1Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 2");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 2");
                    existingPtr->PNext = null;
                }
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        return new ManagedChain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by appending 
    /// <paramref name="item1"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item1">Item 1.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain> previous, T1 item1 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item1Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 1
        item1.StructureType();        
        Marshal.StructureToPtr(item1, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain> Truncate(out T1 item1)
    {
        item1 = Item1;

        var newSize = MemorySize - Item1Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = null;
        return new ManagedChain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="T2">Type of Item 2</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2> Append<T2>(T2 item2 = default)
        where T2: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2>(this, item2);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
    }

    /// <inheritdoc />
    public override int Count => 2;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public void Deconstruct(out TChain head, out T1 item1)
    {
            head = Head;
            item1 = Item1;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item2Offset + Item2Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        Item2Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 3");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 3");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 3");
                    existingPtr->PNext = null;
                }
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        return new ManagedChain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by appending 
    /// <paramref name="item2"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item2">Item 2.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1> previous, T2 item2 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item2Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 2
        item2.StructureType();        
        Marshal.StructureToPtr(item2, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by removing 
    /// <paramref name="item2"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1> Truncate(out T2 item2)
    {
        item2 = Item2;

        var newSize = MemorySize - Item2Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = null; 
        return new ManagedChain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by appending <paramref name="item3"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item3">Item 3.</param>
    /// <typeparam name="T3">Type of Item 3</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3> Append<T3>(T3 item3 = default)
        where T3: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3>(this, item3);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
    }

    /// <inheritdoc />
    public override int Count => 3;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item3Offset + Item3Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        Item3Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 4");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 4");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 4");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 4");
                    existingPtr->PNext = null;
                }
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        return new ManagedChain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by appending 
    /// <paramref name="item3"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item3">Item 3.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2> previous, T3 item3 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item3Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 3
        item3.StructureType();        
        Marshal.StructureToPtr(item3, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by removing 
    /// <paramref name="item3"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2> Truncate(out T3 item3)
    {
        item3 = Item3;

        var newSize = MemorySize - Item3Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending <paramref name="item4"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item4">Item 4.</param>
    /// <typeparam name="T4">Type of Item 4</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4> Append<T4>(T4 item4 = default)
        where T4: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4>(this, item4);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
    }

    /// <inheritdoc />
    public override int Count => 4;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item4Offset + Item4Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        Item4Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 5");
                    existingPtr->PNext = null;
                }
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending 
    /// <paramref name="item4"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item4">Item 4.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3> previous, T4 item4 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item4Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 4
        item4.StructureType();        
        Marshal.StructureToPtr(item4, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by removing 
    /// <paramref name="item4"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3> Truncate(out T4 item4)
    {
        item4 = Item4;

        var newSize = MemorySize - Item4Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending <paramref name="item5"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item5">Item 5.</param>
    /// <typeparam name="T5">Type of Item 5</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5> Append<T5>(T5 item5 = default)
        where T5: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(this, item5);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
    }

    /// <inheritdoc />
    public override int Count => 5;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item5Offset + Item5Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        Item5Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 6");
                    existingPtr->PNext = null;
                }
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending 
    /// <paramref name="item5"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item5">Item 5.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4> previous, T5 item5 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item5Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 5
        item5.StructureType();        
        Marshal.StructureToPtr(item5, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing 
    /// <paramref name="item5"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4> Truncate(out T5 item5)
    {
        item5 = Item5;

        var newSize = MemorySize - Item5Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending <paramref name="item6"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item6">Item 6.</param>
    /// <typeparam name="T6">Type of Item 6</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Append<T6>(T6 item6 = default)
        where T6: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(this, item6);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
    }

    /// <inheritdoc />
    public override int Count => 6;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item6Offset + Item6Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        Item6Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 7");
                    existingPtr->PNext = null;
                }
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending 
    /// <paramref name="item6"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item6">Item 6.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5> previous, T6 item6 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item6Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 6
        item6.StructureType();        
        Marshal.StructureToPtr(item6, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing 
    /// <paramref name="item6"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5> Truncate(out T6 item6)
    {
        item6 = Item6;

        var newSize = MemorySize - Item6Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending <paramref name="item7"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item7">Item 7.</param>
    /// <typeparam name="T7">Type of Item 7</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Append<T7>(T7 item7 = default)
        where T7: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(this, item7);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
    }

    /// <inheritdoc />
    public override int Count => 7;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item7Offset + Item7Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        Item7Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 8");
                    existingPtr->PNext = null;
                }
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending 
    /// <paramref name="item7"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item7">Item 7.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6> previous, T7 item7 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item7Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 7
        item7.StructureType();        
        Marshal.StructureToPtr(item7, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing 
    /// <paramref name="item7"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Truncate(out T7 item7)
    {
        item7 = Item7;

        var newSize = MemorySize - Item7Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending <paramref name="item8"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item8">Item 8.</param>
    /// <typeparam name="T8">Type of Item 8</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Append<T8>(T8 item8 = default)
        where T8: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this, item8);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
    }

    /// <inheritdoc />
    public override int Count => 8;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item8Offset + Item8Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        Item8Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 9");
                    existingPtr->PNext = null;
                }
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending 
    /// <paramref name="item8"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item8">Item 8.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> previous, T8 item8 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item8Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 8
        item8.StructureType();        
        Marshal.StructureToPtr(item8, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing 
    /// <paramref name="item8"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Truncate(out T8 item8)
    {
        item8 = Item8;

        var newSize = MemorySize - Item8Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending <paramref name="item9"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item9">Item 9.</param>
    /// <typeparam name="T9">Type of Item 9</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Append<T9>(T9 item9 = default)
        where T9: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this, item9);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
    }

    /// <inheritdoc />
    public override int Count => 9;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item9Offset + Item9Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        Item9Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 10");
                    existingPtr->PNext = null;
                }
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending 
    /// <paramref name="item9"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item9">Item 9.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> previous, T9 item9 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item9Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 9
        item9.StructureType();        
        Marshal.StructureToPtr(item9, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing 
    /// <paramref name="item9"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Truncate(out T9 item9)
    {
        item9 = Item9;

        var newSize = MemorySize - Item9Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending <paramref name="item10"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item10">Item 10.</param>
    /// <typeparam name="T10">Type of Item 10</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Append<T10>(T10 item10 = default)
        where T10: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this, item10);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
    }

    /// <inheritdoc />
    public override int Count => 10;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = Marshal.SizeOf<T10>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item10Offset + Item10Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        Marshal.StructureToPtr(item10, (nint)itemPtr, false);
        Item9Ptr->PNext = itemPtr;
        Item10Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item10Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 11");
                    existingPtr->PNext = null;
                }
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item10, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending 
    /// <paramref name="item10"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item10">Item 10.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> previous, T10 item10 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item10Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 10
        item10.StructureType();        
        Marshal.StructureToPtr(item10, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + Item9Offset))->PNext = (BaseInStructure*) (_headPtr + Item10Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing 
    /// <paramref name="item10"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Truncate(out T10 item10)
    {
        item10 = Item10;

        var newSize = MemorySize - Item10Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending <paramref name="item11"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item11">Item 11.</param>
    /// <typeparam name="T11">Type of Item 11</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Append<T11>(T11 item11 = default)
        where T11: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this, item11);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
    }

    /// <inheritdoc />
    public override int Count => 11;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);
        Marshal.DestroyStructure<T10>(headPtr + Item10Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = Marshal.SizeOf<T10>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = Marshal.SizeOf<T11>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item11Offset + Item11Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        Marshal.StructureToPtr(item10, (nint)itemPtr, false);
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        Marshal.StructureToPtr(item11, (nint)itemPtr, false);
        Item10Ptr->PNext = itemPtr;
        Item11Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item10Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item10, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item11Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 12");
                    existingPtr->PNext = null;
                }
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item11, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending 
    /// <paramref name="item11"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item11">Item 11.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> previous, T11 item11 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item11Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 11
        item11.StructureType();        
        Marshal.StructureToPtr(item11, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + Item9Offset))->PNext = (BaseInStructure*) (_headPtr + Item10Offset); 
        ((BaseInStructure*)(_headPtr + Item10Offset))->PNext = (BaseInStructure*) (_headPtr + Item11Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing 
    /// <paramref name="item11"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Truncate(out T11 item11)
    {
        item11 = Item11;

        var newSize = MemorySize - Item11Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending <paramref name="item12"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item12">Item 12.</param>
    /// <typeparam name="T12">Type of Item 12</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Append<T12>(T12 item12 = default)
        where T12: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this, item12);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
    }

    /// <inheritdoc />
    public override int Count => 12;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);
        Marshal.DestroyStructure<T10>(headPtr + Item10Offset);
        Marshal.DestroyStructure<T11>(headPtr + Item11Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = Marshal.SizeOf<T10>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = Marshal.SizeOf<T11>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = Marshal.SizeOf<T12>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item12Offset + Item12Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        Marshal.StructureToPtr(item10, (nint)itemPtr, false);
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        Marshal.StructureToPtr(item11, (nint)itemPtr, false);
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        Marshal.StructureToPtr(item12, (nint)itemPtr, false);
        Item11Ptr->PNext = itemPtr;
        Item12Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item10Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item10, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item11Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item11, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item12Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 13");
                    existingPtr->PNext = null;
                }
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item12, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending 
    /// <paramref name="item12"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item12">Item 12.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> previous, T12 item12 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item12Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 12
        item12.StructureType();        
        Marshal.StructureToPtr(item12, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + Item9Offset))->PNext = (BaseInStructure*) (_headPtr + Item10Offset); 
        ((BaseInStructure*)(_headPtr + Item10Offset))->PNext = (BaseInStructure*) (_headPtr + Item11Offset); 
        ((BaseInStructure*)(_headPtr + Item11Offset))->PNext = (BaseInStructure*) (_headPtr + Item12Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing 
    /// <paramref name="item12"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Truncate(out T12 item12)
    {
        item12 = Item12;

        var newSize = MemorySize - Item12Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending <paramref name="item13"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item13">Item 13.</param>
    /// <typeparam name="T13">Type of Item 13</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Append<T13>(T13 item13 = default)
        where T13: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this, item13);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
    }

    /// <inheritdoc />
    public override int Count => 13;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);
        Marshal.DestroyStructure<T10>(headPtr + Item10Offset);
        Marshal.DestroyStructure<T11>(headPtr + Item11Offset);
        Marshal.DestroyStructure<T12>(headPtr + Item12Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
    where T13 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = Marshal.SizeOf<T10>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = Marshal.SizeOf<T11>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = Marshal.SizeOf<T12>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item13Offset = Item12Offset + Item12Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item13Size = Marshal.SizeOf<T13>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item13Offset + Item13Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item13Ptr => (BaseInStructure*) (_headPtr + Item13Offset);

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>(Item13Ptr);
        set
        {
            value.StructureType();
            var ptr = Item13Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        Marshal.StructureToPtr(item10, (nint)itemPtr, false);
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        Marshal.StructureToPtr(item11, (nint)itemPtr, false);
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        Marshal.StructureToPtr(item12, (nint)itemPtr, false);
        Item11Ptr->PNext = itemPtr;
        itemPtr = Item13Ptr;
        item13.StructureType();
        Marshal.StructureToPtr(item13, (nint)itemPtr, false);
        Item12Ptr->PNext = itemPtr;
        Item13Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item10Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item10, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item11Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item11, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item12Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item12, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item13Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 14");
                    existingPtr->PNext = null;
                }
                item13 = Unsafe.AsRef<T13>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item13, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending 
    /// <paramref name="item13"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item13">Item 13.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> previous, T13 item13 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item13Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 13
        item13.StructureType();        
        Marshal.StructureToPtr(item13, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + Item9Offset))->PNext = (BaseInStructure*) (_headPtr + Item10Offset); 
        ((BaseInStructure*)(_headPtr + Item10Offset))->PNext = (BaseInStructure*) (_headPtr + Item11Offset); 
        ((BaseInStructure*)(_headPtr + Item11Offset))->PNext = (BaseInStructure*) (_headPtr + Item12Offset); 
        ((BaseInStructure*)(_headPtr + Item12Offset))->PNext = (BaseInStructure*) (_headPtr + Item13Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing 
    /// <paramref name="item13"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Truncate(out T13 item13)
    {
        item13 = Item13;

        var newSize = MemorySize - Item13Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending <paramref name="item14"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item14">Item 14.</param>
    /// <typeparam name="T14">Type of Item 14</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Append<T14>(T14 item14 = default)
        where T14: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this, item14);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
        yield return Item13;
    }

    /// <inheritdoc />
    public override int Count => 14;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            13 => Item13,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
            item13 = Item13;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);
        Marshal.DestroyStructure<T10>(headPtr + Item10Offset);
        Marshal.DestroyStructure<T11>(headPtr + Item11Offset);
        Marshal.DestroyStructure<T12>(headPtr + Item12Offset);
        Marshal.DestroyStructure<T13>(headPtr + Item13Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
/// <typeparam name="T14">Type of Item 14.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
    where T13 : struct, IExtendsChain<TChain>
    where T14 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = Marshal.SizeOf<T10>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = Marshal.SizeOf<T11>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = Marshal.SizeOf<T12>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item13Offset = Item12Offset + Item12Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item13Size = Marshal.SizeOf<T13>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item14Offset = Item13Offset + Item13Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item14Size = Marshal.SizeOf<T14>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item14Offset + Item14Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item13Ptr => (BaseInStructure*) (_headPtr + Item13Offset);

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>(Item13Ptr);
        set
        {
            value.StructureType();
            var ptr = Item13Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item14Ptr => (BaseInStructure*) (_headPtr + Item14Offset);

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>(Item14Ptr);
        set
        {
            value.StructureType();
            var ptr = Item14Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        Marshal.StructureToPtr(item10, (nint)itemPtr, false);
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        Marshal.StructureToPtr(item11, (nint)itemPtr, false);
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        Marshal.StructureToPtr(item12, (nint)itemPtr, false);
        Item11Ptr->PNext = itemPtr;
        itemPtr = Item13Ptr;
        item13.StructureType();
        Marshal.StructureToPtr(item13, (nint)itemPtr, false);
        Item12Ptr->PNext = itemPtr;
        itemPtr = Item14Ptr;
        item14.StructureType();
        Marshal.StructureToPtr(item14, (nint)itemPtr, false);
        Item13Ptr->PNext = itemPtr;
        Item14Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item10Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item10, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item11Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item11, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item12Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item12, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item13Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item13 = Unsafe.AsRef<T13>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item13, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item14Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T14 item14 = default;
        expectedStructureType = item14.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 14, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 15; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 15");
                    existingPtr->PNext = null;
                }
                item14 = Unsafe.AsRef<T14>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item14, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending 
    /// <paramref name="item14"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item14">Item 14.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> previous, T14 item14 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item14Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 14
        item14.StructureType();        
        Marshal.StructureToPtr(item14, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + Item9Offset))->PNext = (BaseInStructure*) (_headPtr + Item10Offset); 
        ((BaseInStructure*)(_headPtr + Item10Offset))->PNext = (BaseInStructure*) (_headPtr + Item11Offset); 
        ((BaseInStructure*)(_headPtr + Item11Offset))->PNext = (BaseInStructure*) (_headPtr + Item12Offset); 
        ((BaseInStructure*)(_headPtr + Item12Offset))->PNext = (BaseInStructure*) (_headPtr + Item13Offset); 
        ((BaseInStructure*)(_headPtr + Item13Offset))->PNext = (BaseInStructure*) (_headPtr + Item14Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing 
    /// <paramref name="item14"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Truncate(out T14 item14)
    {
        item14 = Item14;

        var newSize = MemorySize - Item14Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending <paramref name="item15"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item15">Item 15.</param>
    /// <typeparam name="T15">Type of Item 15</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Append<T15>(T15 item15 = default)
        where T15: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this, item15);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
        yield return Item13;
        yield return Item14;
    }

    /// <inheritdoc />
    public override int Count => 15;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            13 => Item13,
            14 => Item14,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
            item13 = Item13;
            item14 = Item14;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);
        Marshal.DestroyStructure<T10>(headPtr + Item10Offset);
        Marshal.DestroyStructure<T11>(headPtr + Item11Offset);
        Marshal.DestroyStructure<T12>(headPtr + Item12Offset);
        Marshal.DestroyStructure<T13>(headPtr + Item13Offset);
        Marshal.DestroyStructure<T14>(headPtr + Item14Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
/// <typeparam name="T14">Type of Item 14.</typeparam>
/// <typeparam name="T15">Type of Item 15.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
    where T13 : struct, IExtendsChain<TChain>
    where T14 : struct, IExtendsChain<TChain>
    where T15 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = Marshal.SizeOf<T2>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = Marshal.SizeOf<T3>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = Marshal.SizeOf<T4>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = Marshal.SizeOf<T5>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = Marshal.SizeOf<T6>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = Marshal.SizeOf<T7>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = Marshal.SizeOf<T8>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = Marshal.SizeOf<T9>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = Marshal.SizeOf<T10>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = Marshal.SizeOf<T11>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = Marshal.SizeOf<T12>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item13Offset = Item12Offset + Item12Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item13Size = Marshal.SizeOf<T13>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item14Offset = Item13Offset + Item13Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item14Size = Marshal.SizeOf<T14>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item15Offset = Item14Offset + Item14Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item15Size = Marshal.SizeOf<T15>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item15Offset + Item15Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item13Ptr => (BaseInStructure*) (_headPtr + Item13Offset);

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>(Item13Ptr);
        set
        {
            value.StructureType();
            var ptr = Item13Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item14Ptr => (BaseInStructure*) (_headPtr + Item14Offset);

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>(Item14Ptr);
        set
        {
            value.StructureType();
            var ptr = Item14Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item15Ptr => (BaseInStructure*) (_headPtr + Item15Offset);

    /// <summary>
    /// Gets or sets item #15 in the chain.
    /// </summary>
    public T15 Item15
    {
        get => Unsafe.AsRef<T15>(Item15Ptr);
        set
        {
            value.StructureType();
            var ptr = Item15Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        BaseInStructure* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        Marshal.StructureToPtr(item3, (nint)itemPtr, false);
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        Marshal.StructureToPtr(item4, (nint)itemPtr, false);
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        Marshal.StructureToPtr(item5, (nint)itemPtr, false);
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        Marshal.StructureToPtr(item6, (nint)itemPtr, false);
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        Marshal.StructureToPtr(item7, (nint)itemPtr, false);
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        Marshal.StructureToPtr(item8, (nint)itemPtr, false);
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        Marshal.StructureToPtr(item9, (nint)itemPtr, false);
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        Marshal.StructureToPtr(item10, (nint)itemPtr, false);
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        Marshal.StructureToPtr(item11, (nint)itemPtr, false);
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        Marshal.StructureToPtr(item12, (nint)itemPtr, false);
        Item11Ptr->PNext = itemPtr;
        itemPtr = Item13Ptr;
        item13.StructureType();
        Marshal.StructureToPtr(item13, (nint)itemPtr, false);
        Item12Ptr->PNext = itemPtr;
        itemPtr = Item14Ptr;
        item14.StructureType();
        Marshal.StructureToPtr(item14, (nint)itemPtr, false);
        Item13Ptr->PNext = itemPtr;
        itemPtr = Item15Ptr;
        item15.StructureType();
        Marshal.StructureToPtr(item15, (nint)itemPtr, false);
        Item14Ptr->PNext = itemPtr;
        Item15Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) _headPtr;

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item1Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item2Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item2, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item3Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item3, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item4Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item4, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item5Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item5, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item6Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item6, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item7Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item7, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item8Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item8, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item9Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item9, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item10Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item10, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item11Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item11, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item12Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item12, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item13Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item13 = Unsafe.AsRef<T13>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item13, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item14Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T14 item14 = default;
        expectedStructureType = item14.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 14, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 15; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item14 = Unsafe.AsRef<T14>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item14, (nint) newPtr, false);

        existingPtr = (BaseInStructure*)existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*)(_headPtr + Item15Offset);
        newPtr = (BaseInStructure*)newPtr->PNext;

        T15 item15 = default;
        expectedStructureType = item15.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 15, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 16; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 16");
                    existingPtr->PNext = null;
                }
                item15 = Unsafe.AsRef<T15>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item15, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + Item14Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item15Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending 
    /// <paramref name="item15"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item15">Item 15.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> previous, T15 item15 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item15Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 15
        item15.StructureType();        
        Marshal.StructureToPtr(item15, _headPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)_headPtr)->PNext = (BaseInStructure*) (_headPtr + Item1Offset);
        ((BaseInStructure*)(_headPtr + Item1Offset))->PNext = (BaseInStructure*) (_headPtr + Item2Offset); 
        ((BaseInStructure*)(_headPtr + Item2Offset))->PNext = (BaseInStructure*) (_headPtr + Item3Offset); 
        ((BaseInStructure*)(_headPtr + Item3Offset))->PNext = (BaseInStructure*) (_headPtr + Item4Offset); 
        ((BaseInStructure*)(_headPtr + Item4Offset))->PNext = (BaseInStructure*) (_headPtr + Item5Offset); 
        ((BaseInStructure*)(_headPtr + Item5Offset))->PNext = (BaseInStructure*) (_headPtr + Item6Offset); 
        ((BaseInStructure*)(_headPtr + Item6Offset))->PNext = (BaseInStructure*) (_headPtr + Item7Offset); 
        ((BaseInStructure*)(_headPtr + Item7Offset))->PNext = (BaseInStructure*) (_headPtr + Item8Offset); 
        ((BaseInStructure*)(_headPtr + Item8Offset))->PNext = (BaseInStructure*) (_headPtr + Item9Offset); 
        ((BaseInStructure*)(_headPtr + Item9Offset))->PNext = (BaseInStructure*) (_headPtr + Item10Offset); 
        ((BaseInStructure*)(_headPtr + Item10Offset))->PNext = (BaseInStructure*) (_headPtr + Item11Offset); 
        ((BaseInStructure*)(_headPtr + Item11Offset))->PNext = (BaseInStructure*) (_headPtr + Item12Offset); 
        ((BaseInStructure*)(_headPtr + Item12Offset))->PNext = (BaseInStructure*) (_headPtr + Item13Offset); 
        ((BaseInStructure*)(_headPtr + Item13Offset))->PNext = (BaseInStructure*) (_headPtr + Item14Offset); 
        ((BaseInStructure*)(_headPtr + Item14Offset))->PNext = (BaseInStructure*) (_headPtr + Item15Offset); 
        ((BaseInStructure*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing 
    /// <paramref name="item15"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Truncate(out T15 item15)
    {
        item15 = Item15;

        var newSize = MemorySize - Item15Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + Item14Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
        yield return Item13;
        yield return Item14;
        yield return Item15;
    }

    /// <inheritdoc />
    public override int Count => 16;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            13 => Item13,
            14 => Item14,
            15 => Item15,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
            item13 = Item13;
            item14 = Item14;
            item15 = Item15;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);
        Marshal.DestroyStructure<T2>(headPtr + Item2Offset);
        Marshal.DestroyStructure<T3>(headPtr + Item3Offset);
        Marshal.DestroyStructure<T4>(headPtr + Item4Offset);
        Marshal.DestroyStructure<T5>(headPtr + Item5Offset);
        Marshal.DestroyStructure<T6>(headPtr + Item6Offset);
        Marshal.DestroyStructure<T7>(headPtr + Item7Offset);
        Marshal.DestroyStructure<T8>(headPtr + Item8Offset);
        Marshal.DestroyStructure<T9>(headPtr + Item9Offset);
        Marshal.DestroyStructure<T10>(headPtr + Item10Offset);
        Marshal.DestroyStructure<T11>(headPtr + Item11Offset);
        Marshal.DestroyStructure<T12>(headPtr + Item12Offset);
        Marshal.DestroyStructure<T13>(headPtr + Item13Offset);
        Marshal.DestroyStructure<T14>(headPtr + Item14Offset);
        Marshal.DestroyStructure<T15>(headPtr + Item15Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
