using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.Net.Vulkan;

/// <summary>
///  Static class for creating Managed Chains.
/// </summary>
public static class ManagedChain
{
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
        return new ManagedChain<TChain, T1>(head, item1);
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
    public static ManagedChain<TChain, T1, T2> Create<TChain, T1, T2>(TChain head = default, T1 item1 = default,
        T2 item2 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2>(head, item1, item2);
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
    public static ManagedChain<TChain, T1, T2, T3> Create<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default,
        T2 item2 = default, T3 item3 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3>(head, item1, item2, item3);
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
    public static ManagedChain<TChain, T1, T2, T3, T4> Create<TChain, T1, T2, T3, T4>(TChain head = default,
        T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4>(head, item1, item2, item3, item4);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Create<TChain, T1, T2, T3, T4, T5>(TChain head = default,
        T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(head, item1, item2, item3, item4, item5);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Create<TChain, T1, T2, T3, T4, T5, T6>(
        TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default,
        T5 item5 = default, T6 item6 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(head, item1, item2, item3, item4, item5, item6);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Create<TChain, T1, T2, T3, T4, T5, T6, T7>(
        TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default,
        T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(head, item1, item2, item3, item4, item5, item6,
            item7);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(
        TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default,
        T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(head, item1, item2, item3, item4, item5, item6,
            item7, item8);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain head = default, T1 item1 = default,
            T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default,
            T7 item7 = default, T8 item8 = default, T9 item9 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(head, item1, item2, item3, item4, item5,
            item6, item7, item8, item9);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain head = default, T1 item1 = default,
            T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default,
            T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(head, item1, item2, item3, item4,
            item5, item6, item7, item8, item9, item10);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain head = default, T1 item1 = default,
            T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default,
            T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(head, item1, item2, item3, item4,
            item5, item6, item7, item8, item9, item10, item11);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain head = default, T1 item1 = default,
            T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default,
            T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default,
            T12 item12 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(head, item1, item2, item3,
            item4, item5, item6, item7, item8, item9, item10, item11, item12);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain head = default,
            T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default,
            T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default,
            T11 item11 = default, T12 item12 = default, T13 item13 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(head, item1, item2,
            item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain head = default,
            T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default,
            T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default,
            T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(head, item1, item2,
            item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);
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
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain head = default,
            T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default,
            T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default,
            T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default,
            T15 item15 = default)
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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(head, item1,
            item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);
    }
}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
public unsafe class ManagedChain<TChain, T1> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public ManagedChain(TChain head = default, T1 item1 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 2");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="T2">Type of Item 2</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2> Append<T2>(T2 item2 = default)
        where T2 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2>(this, item2);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 3");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 3");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item2">Item 2.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1> previous, T2 item2 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();

        var originalSize = headSize + item1Size;
        var newSize = originalSize + item2Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        // Append the last structure
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by appending <paramref name="item3"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item3">Item 3.</param>
    /// <typeparam name="T3">Type of Item 3</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3> Append<T3>(T3 item3 = default)
        where T3 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3>(this, item3);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 4");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 4");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 4");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item3">Item 3.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2> previous, T3 item3 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();

        var originalSize = headSize + item1Size + item2Size;
        var newSize = originalSize + item3Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        // Append the last structure
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending <paramref name="item4"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item4">Item 4.</param>
    /// <typeparam name="T4">Type of Item 4</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4> Append<T4>(T4 item4 = default)
        where T4 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4>(this, item4);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 5");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 5");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 5");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 5");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item4">Item 4.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3> previous, T4 item4 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();

        var originalSize = headSize + item1Size + item2Size + item3Size;
        var newSize = originalSize + item4Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        // Append the last structure
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending <paramref name="item5"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item5">Item 5.</param>
    /// <typeparam name="T5">Type of Item 5</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5> Append<T5>(T5 item5 = default)
        where T5 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(this, item5);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 6");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 6");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 6");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 6");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 6");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item5">Item 5.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4> previous, T5 item5 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size;
        var newSize = originalSize + item5Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        // Append the last structure
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending <paramref name="item6"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item6">Item 6.</param>
    /// <typeparam name="T6">Type of Item 6</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Append<T6>(T6 item6 = default)
        where T6 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(this, item6);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();

        _headPtr = Marshal.AllocHGlobal(
            headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 7");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 7");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 7");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 7");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 7");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 7");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(
            headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item6">Item 6.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5> previous, T6 item6 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size;
        var newSize = originalSize + item6Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        // Append the last structure
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending <paramref name="item7"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item7">Item 7.</param>
    /// <typeparam name="T7">Type of Item 7</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Append<T7>(T7 item7 = default)
        where T7 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(this, item7);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 8");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 8");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 8");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 8");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 8");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 8");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 8");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item7">Item 7.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6> previous, T7 item7 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size;
        var newSize = originalSize + item7Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        // Append the last structure
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending <paramref name="item8"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item8">Item 8.</param>
    /// <typeparam name="T8">Type of Item 8</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Append<T8>(T8 item8 = default)
        where T8 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this, item8);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 9");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 9");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 9");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 9");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 9");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 9");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 9");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 9");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item8">Item 8.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> previous, T8 item8 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size;
        var newSize = originalSize + item8Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        // Append the last structure
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending <paramref name="item9"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item9">Item 9.</param>
    /// <typeparam name="T9">Type of Item 9</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Append<T9>(T9 item9 = default)
        where T9 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this, item9);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 10");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 10");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 10");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 10");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 10");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 10");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 10");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 10");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 10");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item9">Item 9.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> previous, T9 item9 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size;
        var newSize = originalSize + item9Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        // Append the last structure
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending <paramref name="item10"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item10">Item 10.</param>
    /// <typeparam name="T10">Type of Item 10</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Append<T10>(T10 item10 = default)
        where T10 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this, item10);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default, T10 item10 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 11");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 11");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 11");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 11");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 11");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 11");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 11");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 11");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 11");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();

        currentPtr = currentPtr->PNext;
        T10 item10 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 11");
        else
        {
            expectedStructureType = item10.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item10 = Unsafe.AsRef<T10>(currentPtr);
        }

        var item10Size = Marshal.SizeOf<T10>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item10">Item 10.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> previous, T10 item10 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size + item9Size;
        var newSize = originalSize + item10Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        // Append the last structure
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending <paramref name="item11"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item11">Item 11.</param>
    /// <typeparam name="T11">Type of Item 11</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Append<T11>(T11 item11 = default)
        where T11 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this, item11);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default, T10 item10 = default, T11 item11 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 12");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 12");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 12");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 12");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 12");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 12");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 12");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 12");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 12");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();

        currentPtr = currentPtr->PNext;
        T10 item10 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 12");
        else
        {
            expectedStructureType = item10.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item10 = Unsafe.AsRef<T10>(currentPtr);
        }

        var item10Size = Marshal.SizeOf<T10>();

        currentPtr = currentPtr->PNext;
        T11 item11 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 12");
        else
        {
            expectedStructureType = item11.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item11 = Unsafe.AsRef<T11>(currentPtr);
        }

        var item11Size = Marshal.SizeOf<T11>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item11">Item 11.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> previous, T11 item11 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size + item9Size + item10Size;
        var newSize = originalSize + item11Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        // Append the last structure
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending <paramref name="item12"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item12">Item 12.</param>
    /// <typeparam name="T12">Type of Item 12</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Append<T12>(T12 item12 = default)
        where T12 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this, item12);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 13");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 13");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 13");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 13");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 13");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 13");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 13");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 13");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 13");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();

        currentPtr = currentPtr->PNext;
        T10 item10 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 13");
        else
        {
            expectedStructureType = item10.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item10 = Unsafe.AsRef<T10>(currentPtr);
        }

        var item10Size = Marshal.SizeOf<T10>();

        currentPtr = currentPtr->PNext;
        T11 item11 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 13");
        else
        {
            expectedStructureType = item11.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item11 = Unsafe.AsRef<T11>(currentPtr);
        }

        var item11Size = Marshal.SizeOf<T11>();

        currentPtr = currentPtr->PNext;
        T12 item12 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 13");
        else
        {
            expectedStructureType = item12.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item12 = Unsafe.AsRef<T12>(currentPtr);
        }

        var item12Size = Marshal.SizeOf<T12>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item12">Item 12.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> previous,
        T12 item12 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size + item9Size + item10Size + item11Size;
        var newSize = originalSize + item12Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        // Append the last structure
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending <paramref name="item13"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item13">Item 13.</param>
    /// <typeparam name="T13">Type of Item 13</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Append<T13>(
        T13 item13 = default)
        where T13 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this, item13);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item13Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item13Ptr => (Chain*) _item13Ptr;

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>((Chain*) _item13Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item13Ptr)->PNext;
            Marshal.StructureToPtr(value, _item13Ptr, true);
            ((Chain*) _item13Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size + item13Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 14");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 14");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 14");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 14");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 14");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 14");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 14");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 14");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 14");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();

        currentPtr = currentPtr->PNext;
        T10 item10 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 14");
        else
        {
            expectedStructureType = item10.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item10 = Unsafe.AsRef<T10>(currentPtr);
        }

        var item10Size = Marshal.SizeOf<T10>();

        currentPtr = currentPtr->PNext;
        T11 item11 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 14");
        else
        {
            expectedStructureType = item11.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item11 = Unsafe.AsRef<T11>(currentPtr);
        }

        var item11Size = Marshal.SizeOf<T11>();

        currentPtr = currentPtr->PNext;
        T12 item12 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 14");
        else
        {
            expectedStructureType = item12.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item12 = Unsafe.AsRef<T12>(currentPtr);
        }

        var item12Size = Marshal.SizeOf<T12>();

        currentPtr = currentPtr->PNext;
        T13 item13 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 14");
        else
        {
            expectedStructureType = item13.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item13 = Unsafe.AsRef<T13>(currentPtr);
        }

        var item13Size = Marshal.SizeOf<T13>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size + item13Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item13">Item 13.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> previous,
        T13 item13 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size + item9Size + item10Size + item11Size + item12Size;
        var newSize = originalSize + item13Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        // Append the last structure
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending <paramref name="item14"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item14">Item 14.</param>
    /// <typeparam name="T14">Type of Item 14</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Append<T14>(
        T14 item14 = default)
        where T14 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this, item14);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);
        var item13Ptr = Interlocked.Exchange(ref _item13Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item13Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item13Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item13Ptr => (Chain*) _item13Ptr;

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>((Chain*) _item13Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item13Ptr)->PNext;
            Marshal.StructureToPtr(value, _item13Ptr, true);
            ((Chain*) _item13Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item14Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item14Ptr => (Chain*) _item14Ptr;

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>((Chain*) _item14Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item14Ptr)->PNext;
            Marshal.StructureToPtr(value, _item14Ptr, true);
            ((Chain*) _item14Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default,
        T14 item14 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();
        var item14Size = Marshal.SizeOf<T14>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size + item13Size + item14Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        item14.StructureType();
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 15");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 15");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 15");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 15");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 15");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 15");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 15");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 15");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 15");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();

        currentPtr = currentPtr->PNext;
        T10 item10 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 15");
        else
        {
            expectedStructureType = item10.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item10 = Unsafe.AsRef<T10>(currentPtr);
        }

        var item10Size = Marshal.SizeOf<T10>();

        currentPtr = currentPtr->PNext;
        T11 item11 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 15");
        else
        {
            expectedStructureType = item11.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item11 = Unsafe.AsRef<T11>(currentPtr);
        }

        var item11Size = Marshal.SizeOf<T11>();

        currentPtr = currentPtr->PNext;
        T12 item12 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 15");
        else
        {
            expectedStructureType = item12.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item12 = Unsafe.AsRef<T12>(currentPtr);
        }

        var item12Size = Marshal.SizeOf<T12>();

        currentPtr = currentPtr->PNext;
        T13 item13 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 15");
        else
        {
            expectedStructureType = item13.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item13 = Unsafe.AsRef<T13>(currentPtr);
        }

        var item13Size = Marshal.SizeOf<T13>();

        currentPtr = currentPtr->PNext;
        T14 item14 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 14, expected length 15");
        else
        {
            expectedStructureType = item14.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 15; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item14 = Unsafe.AsRef<T14>(currentPtr);
        }

        var item14Size = Marshal.SizeOf<T14>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size + item13Size + item14Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item14">Item 14.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> previous,
        T14 item14 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();
        var item14Size = Marshal.SizeOf<T14>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size + item9Size + item10Size + item11Size + item12Size + item13Size;
        var newSize = originalSize + item14Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        // Append the last structure
        item14.StructureType();
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending <paramref name="item15"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item15">Item 15.</param>
    /// <typeparam name="T15">Type of Item 15</typeparam>
    /// <remarks>
    /// Do not forget to dispose this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Append<T15>(
        T15 item15 = default)
        where T15 : struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this, item15);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);
        var item13Ptr = Interlocked.Exchange(ref _item13Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item13Ptr);
        var item14Ptr = Interlocked.Exchange(ref _item14Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item14Ptr);

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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IDisposable
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
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item13Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item13Ptr => (Chain*) _item13Ptr;

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>((Chain*) _item13Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item13Ptr)->PNext;
            Marshal.StructureToPtr(value, _item13Ptr, true);
            ((Chain*) _item13Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item14Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item14Ptr => (Chain*) _item14Ptr;

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>((Chain*) _item14Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item14Ptr)->PNext;
            Marshal.StructureToPtr(value, _item14Ptr, true);
            ((Chain*) _item14Ptr)->PNext = nextPtr;
        }
    }

    private IntPtr _item15Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item15Ptr => (Chain*) _item15Ptr;

    /// <summary>
    /// Gets or sets item #15 in the chain.
    /// </summary>
    public T15 Item15
    {
        get => Unsafe.AsRef<T15>((Chain*) _item15Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item15Ptr)->PNext;
            Marshal.StructureToPtr(value, _item15Ptr, true);
            ((Chain*) _item15Ptr)->PNext = nextPtr;
        }
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default,
        T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default,
        T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default,
        T14 item14 = default, T15 item15 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();
        var item14Size = Marshal.SizeOf<T14>();
        var item15Size = Marshal.SizeOf<T15>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size + item13Size + item14Size + item15Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        item14.StructureType();
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;

        _item15Ptr = _item14Ptr + item14Size;
        item15.StructureType();
        Marshal.StructureToPtr(item15, _item15Ptr, false);
        ((Chain*) _item14Ptr)->PNext = (Chain*) _item15Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <param name="errors">Any errors loading the chain.</param>
    public ManagedChain(TChain chain, out string errors)
    {
        // Load existing chain first, so any errors occur before we allocate memory
        var head = chain;
        var headSize = Marshal.SizeOf<TChain>();
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        StructureType expectedStructureType;
        var errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 16");
        else
        {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }

        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 16");
        else
        {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }

        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 16");
        else
        {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }

        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 16");
        else
        {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item4 = Unsafe.AsRef<T4>(currentPtr);
        }

        var item4Size = Marshal.SizeOf<T4>();

        currentPtr = currentPtr->PNext;
        T5 item5 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 16");
        else
        {
            expectedStructureType = item5.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item5 = Unsafe.AsRef<T5>(currentPtr);
        }

        var item5Size = Marshal.SizeOf<T5>();

        currentPtr = currentPtr->PNext;
        T6 item6 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 16");
        else
        {
            expectedStructureType = item6.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item6 = Unsafe.AsRef<T6>(currentPtr);
        }

        var item6Size = Marshal.SizeOf<T6>();

        currentPtr = currentPtr->PNext;
        T7 item7 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 16");
        else
        {
            expectedStructureType = item7.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item7 = Unsafe.AsRef<T7>(currentPtr);
        }

        var item7Size = Marshal.SizeOf<T7>();

        currentPtr = currentPtr->PNext;
        T8 item8 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 16");
        else
        {
            expectedStructureType = item8.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item8 = Unsafe.AsRef<T8>(currentPtr);
        }

        var item8Size = Marshal.SizeOf<T8>();

        currentPtr = currentPtr->PNext;
        T9 item9 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 16");
        else
        {
            expectedStructureType = item9.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item9 = Unsafe.AsRef<T9>(currentPtr);
        }

        var item9Size = Marshal.SizeOf<T9>();

        currentPtr = currentPtr->PNext;
        T10 item10 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 16");
        else
        {
            expectedStructureType = item10.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item10 = Unsafe.AsRef<T10>(currentPtr);
        }

        var item10Size = Marshal.SizeOf<T10>();

        currentPtr = currentPtr->PNext;
        T11 item11 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 16");
        else
        {
            expectedStructureType = item11.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item11 = Unsafe.AsRef<T11>(currentPtr);
        }

        var item11Size = Marshal.SizeOf<T11>();

        currentPtr = currentPtr->PNext;
        T12 item12 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 16");
        else
        {
            expectedStructureType = item12.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item12 = Unsafe.AsRef<T12>(currentPtr);
        }

        var item12Size = Marshal.SizeOf<T12>();

        currentPtr = currentPtr->PNext;
        T13 item13 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 16");
        else
        {
            expectedStructureType = item13.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item13 = Unsafe.AsRef<T13>(currentPtr);
        }

        var item13Size = Marshal.SizeOf<T13>();

        currentPtr = currentPtr->PNext;
        T14 item14 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 14, expected length 16");
        else
        {
            expectedStructureType = item14.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 15; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item14 = Unsafe.AsRef<T14>(currentPtr);
        }

        var item14Size = Marshal.SizeOf<T14>();

        currentPtr = currentPtr->PNext;
        T15 item15 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 15, expected length 16");
        else
        {
            expectedStructureType = item15.StructureType();
            if (currentPtr->SType != expectedStructureType)
            {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 16; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            }
            else
                item15 = Unsafe.AsRef<T15>(currentPtr);
        }

        var item15Size = Marshal.SizeOf<T15>();


        // Create string of errors
        errors = errorBuilder.ToString().Trim();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size +
                                        item6Size + item7Size + item8Size + item9Size + item10Size + item11Size +
                                        item12Size + item13Size + item14Size + item15Size);
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;

        _item15Ptr = _item14Ptr + item14Size;
        Marshal.StructureToPtr(item15, _item15Ptr, false);
        ((Chain*) _item14Ptr)->PNext = (Chain*) _item15Ptr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item15">Item 15.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> previous,
        T15 item15 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();
        var item14Size = Marshal.SizeOf<T14>();
        var item15Size = Marshal.SizeOf<T15>();

        var originalSize = headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size +
                           item7Size + item8Size + item9Size + item10Size + item11Size + item12Size + item13Size +
                           item14Size;
        var newSize = originalSize + item15Size;

        _headPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*) _headPtr, originalSize, originalSize);

        _item1Ptr = _headPtr + headSize;
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;

        _item15Ptr = _item14Ptr + item14Size;
        // Append the last structure
        item15.StructureType();
        Marshal.StructureToPtr(item15, _item15Ptr, false);
        ((Chain*) _item14Ptr)->PNext = (Chain*) _item15Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);
        var item13Ptr = Interlocked.Exchange(ref _item13Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item13Ptr);
        var item14Ptr = Interlocked.Exchange(ref _item14Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item14Ptr);
        var item15Ptr = Interlocked.Exchange(ref _item15Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item15Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}