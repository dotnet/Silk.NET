// ReSharper disable StaticMemberInGenericType
#pragma warning disable CS0659, CS0660, CS0661
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Vulkan;

/// <summary>
/// Base class for all <see cref="ManagedChain{T}">Managed Chains</see>.
/// </summary>
public abstract unsafe class ManagedChain : IReadOnlyList<IChainable>, IDisposable
{
    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public abstract BaseInStructure* HeadPtr { get; }

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public abstract int Size { get; }

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public override bool Equals(object obj)
    {
        return !ReferenceEquals(null, obj) && 
               (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && MemoryEquals((ManagedChain) obj));
    }

    /// <summary>
    /// Compares the supplied memory block with this one.
    /// </summary>  
    protected abstract bool MemoryEquals(ManagedChain other);

    /// <inheritdoc />
    public abstract void Dispose();

    /// <summary>
    /// Combines a hashcode with the contents of a slice.
    /// </summary>
    /// <param name="hashCode"></param>
    /// <param name="slice"></param>
    /// <returns></returns>
    protected static void CombineHash(ref int hashCode, ReadOnlySpan<byte> slice)
    {
        if (slice.Length >= 8)
        {
            // Process slice in 8 byte chunks
            var s8 = MemoryMarshal.Cast<byte, ulong>(slice);
            foreach (var l in s8)
            {
                hashCode = HashCode.Combine(hashCode, l);
            }
            
            slice = slice.Slice(s8.Length*8);
        }
        
        // Process remainder of slice
        if (slice.Length >= 4)
        {
            var s4 = MemoryMarshal.Cast<byte, uint>(slice);
            hashCode = HashCode.Combine(hashCode, s4[0]);
            slice = slice.Slice(s4.Length*4);
        }

        if (slice.Length >= 2)
        {
            var s2 = MemoryMarshal.Cast<byte, ushort>(slice);
            hashCode = HashCode.Combine(hashCode, s2[0]);
            slice = slice.Slice(s2.Length*2);
        }

        if (slice.Length > 0)
        {
            hashCode = HashCode.Combine(hashCode, slice[0]);
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    /// <seealso cref="CreateAny{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> Create<TChain>(TChain head = default)
        where TChain : struct, IChainStart
        => new(head);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> CreateAny<TChain>(TChain head = default)
        where TChain : struct, IChainable
        => new(head);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    /// <seealso cref="LoadAny{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> Load<TChain>(TChain chain)
        where TChain : struct, IChainStart
        => LoadAny<TChain>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> LoadAny<TChain>(TChain chain)
        where TChain : struct, IChainable
        => LoadAny<TChain>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    /// <seealso cref="LoadAny{TChain}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> Load<TChain>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        => LoadAny<TChain>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain}"/> with 1 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain}"/> with 1 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> LoadAny<TChain>(out string errors, TChain chain)
        where TChain : struct, IChainable
    {
        var size = ManagedChain<TChain>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        errors = string.Empty;
        return new ManagedChain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1}(TChain, T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> Create<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => new(head, item1);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1}(TChain, T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> CreateAny<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        => new(head, item1);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> Load<TChain, T1>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> LoadAny<TChain, T1>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        => LoadAny<TChain, T1>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> Load<TChain, T1>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> LoadAny<TChain, T1>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1>.Item1Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2}(TChain, T1, T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> Create<TChain, T1, T2>(TChain head = default, T1 item1 = default, T2 item2 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => new(head, item1, item2);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2}(TChain, T1, T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> CreateAny<TChain, T1, T2>(TChain head = default, T1 item1 = default, T2 item2 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        => new(head, item1, item2);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> Load<TChain, T1, T2>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> LoadAny<TChain, T1, T2>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        => LoadAny<TChain, T1, T2>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> Load<TChain, T1, T2>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> LoadAny<TChain, T1, T2>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item2Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3}(TChain, T1, T2, T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> Create<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => new(head, item1, item2, item3);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3}(TChain, T1, T2, T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> CreateAny<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        => new(head, item1, item2, item3);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> Load<TChain, T1, T2, T3>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> LoadAny<TChain, T1, T2, T3>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> Load<TChain, T1, T2, T3>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> LoadAny<TChain, T1, T2, T3>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item3Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4}(TChain, T1, T2, T3, T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> Create<TChain, T1, T2, T3, T4>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4}(TChain, T1, T2, T3, T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> CreateAny<TChain, T1, T2, T3, T4>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        => new(head, item1, item2, item3, item4);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> Load<TChain, T1, T2, T3, T4>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> LoadAny<TChain, T1, T2, T3, T4>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> Load<TChain, T1, T2, T3, T4>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> LoadAny<TChain, T1, T2, T3, T4>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item4Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5}(TChain, T1, T2, T3, T4, T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Create<TChain, T1, T2, T3, T4, T5>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5}(TChain, T1, T2, T3, T4, T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> CreateAny<TChain, T1, T2, T3, T4, T5>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Load<TChain, T1, T2, T3, T4, T5>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> LoadAny<TChain, T1, T2, T3, T4, T5>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Load<TChain, T1, T2, T3, T4, T5>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> LoadAny<TChain, T1, T2, T3, T4, T5>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item5Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6}(TChain, T1, T2, T3, T4, T5, T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Create<TChain, T1, T2, T3, T4, T5, T6>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6}(TChain, T1, T2, T3, T4, T5, T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> CreateAny<TChain, T1, T2, T3, T4, T5, T6>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Load<TChain, T1, T2, T3, T4, T5, T6>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> LoadAny<TChain, T1, T2, T3, T4, T5, T6>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Load<TChain, T1, T2, T3, T4, T5, T6>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> LoadAny<TChain, T1, T2, T3, T4, T5, T6>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item6Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain, T1, T2, T3, T4, T5, T6, T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Create<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain, T1, T2, T3, T4, T5, T6, T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Load<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Load<TChain, T1, T2, T3, T4, T5, T6, T7>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain, T1, T2, T3, T4, T5, T6, T7, T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain, T1, T2, T3, T4, T5, T6, T7, T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
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
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);

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
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset);
        newPtr = newPtr->PNext;

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

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Offset);
        newPtr = newPtr->PNext;

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
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

}

/// <summary>
///  Static class providing extension methods for manipulating <see cref="ManagedChain">managed chains</see>.
/// </summary>
/// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
/// useful for situations where the specification does not indicate required chain constraints. You should generally
/// try to use the none `Any` version in preference.</para></remarks>
public static unsafe class ManagedChainExtensions
{
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain}(ManagedChain{TChain})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> Duplicate<TChain>(this ManagedChain<TChain> chain)
        where TChain : struct, IChainStart
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain}(ManagedChain{TChain})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> DuplicateAny<TChain>(this ManagedChain<TChain> chain)
        where TChain : struct, IChainable
    {
        var size = ManagedChain<TChain>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        return new ManagedChain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1}(ManagedChain{TChain}, T1)" />
    public static ManagedChain<TChain, T1> Add<TChain, T1>(this ManagedChain<TChain> chain, T1 item1 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.AddAny(item1);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1}(ManagedChain{TChain}, T1)" />
    public static ManagedChain<TChain, T1> AddAny<TChain, T1>(this ManagedChain<TChain> chain, T1 item1 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain>.MemorySize;
        var newSize = ManagedChain<TChain, T1>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 0
        item1.StructureType();        
        Marshal.StructureToPtr(item1, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1}(ManagedChain{TChain, T1})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> Duplicate<TChain, T1>(this ManagedChain<TChain, T1> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1}(ManagedChain{TChain, T1})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> DuplicateAny<TChain, T1>(this ManagedChain<TChain, T1> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1>.Item1Offset); 
        return new ManagedChain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1}(ManagedChain{TChain, T1})" />
    /// <seealso cref="Truncate{TChain, T1}(ManagedChain{TChain, T1}, out T1)" />
    /// <seealso cref="TruncateAny{TChain, T1}(ManagedChain{TChain, T1}, out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> Truncate<TChain, T1>(this ManagedChain<TChain, T1> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1}(ManagedChain{TChain, T1})" />
    /// <seealso cref="Truncate{TChain, T1}(ManagedChain{TChain, T1}, out T1)" />
    /// <seealso cref="TruncateAny{TChain, T1}(ManagedChain{TChain, T1}, out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> TruncateAny<TChain, T1>(this ManagedChain<TChain, T1> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1}(ManagedChain{TChain, T1})" />
    /// <seealso cref="TruncateAny{TChain, T1}(ManagedChain{TChain, T1})" />
    /// <seealso cref="TruncateAny{TChain, T1}(ManagedChain{TChain, T1}, out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain> Truncate<TChain, T1>(this ManagedChain<TChain, T1> chain, out T1 item1)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item1);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1}(ManagedChain{TChain, T1})" />
    /// <seealso cref="TruncateAny{TChain, T1}(ManagedChain{TChain, T1})" />
    /// <seealso cref="Truncate{TChain, T1}(ManagedChain{TChain, T1}, out T1)" />
    public static ManagedChain<TChain> TruncateAny<TChain, T1>(this ManagedChain<TChain, T1> chain, out T1 item1)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        // Retrieve last item.
        item1 = chain.Item1;

        var newSize = ManagedChain<TChain, T1>.MemorySize - ManagedChain<TChain, T1>.Item1Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = null;
        return new ManagedChain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item2">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2}(ManagedChain{TChain, T1}, T2)" />
    public static ManagedChain<TChain, T1, T2> Add<TChain, T1, T2>(this ManagedChain<TChain, T1> chain, T2 item2 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => chain.AddAny(item2);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item2">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2}(ManagedChain{TChain, T1}, T2)" />
    public static ManagedChain<TChain, T1, T2> AddAny<TChain, T1, T2>(this ManagedChain<TChain, T1> chain, T2 item2 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 1
        item2.StructureType();        
        Marshal.StructureToPtr(item2, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> Duplicate<TChain, T1, T2>(this ManagedChain<TChain, T1, T2> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> DuplicateAny<TChain, T1, T2>(this ManagedChain<TChain, T1, T2> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item2Offset); 
        return new ManagedChain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    /// <seealso cref="Truncate{TChain, T1, T2}(ManagedChain{TChain, T1, T2}, out T2)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2}, out T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> Truncate<TChain, T1, T2>(this ManagedChain<TChain, T1, T2> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    /// <seealso cref="Truncate{TChain, T1, T2}(ManagedChain{TChain, T1, T2}, out T2)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2}, out T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> TruncateAny<TChain, T1, T2>(this ManagedChain<TChain, T1, T2> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 2 items, by removing 
    /// <paramref name="item2"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item2">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2}, out T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1> Truncate<TChain, T1, T2>(this ManagedChain<TChain, T1, T2> chain, out T2 item2)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item2);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by removing 
    /// <paramref name="item2"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item2">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2}(ManagedChain{TChain, T1, T2})" />
    /// <seealso cref="Truncate{TChain, T1, T2}(ManagedChain{TChain, T1, T2}, out T2)" />
    public static ManagedChain<TChain, T1> TruncateAny<TChain, T1, T2>(this ManagedChain<TChain, T1, T2> chain, out T2 item2)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
    {
        // Retrieve last item.
        item2 = chain.Item2;

        var newSize = ManagedChain<TChain, T1, T2>.MemorySize - ManagedChain<TChain, T1, T2>.Item2Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2>.Item1Offset))->PNext = null; 
        return new ManagedChain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by appending <paramref name="item3"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item3">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2}, T3)" />
    public static ManagedChain<TChain, T1, T2, T3> Add<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2> chain, T3 item3 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => chain.AddAny(item3);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by appending <paramref name="item3"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item3">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2}, T3)" />
    public static ManagedChain<TChain, T1, T2, T3> AddAny<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2> chain, T3 item3 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 2
        item3.StructureType();        
        Marshal.StructureToPtr(item3, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> Duplicate<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2, T3> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> DuplicateAny<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2, T3> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item3Offset); 
        return new ManagedChain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3}, out T3)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3}, out T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> Truncate<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2, T3> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3}, out T3)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3}, out T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> TruncateAny<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2, T3> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 3 items, by removing 
    /// <paramref name="item3"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item3">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3}, out T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2> Truncate<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2, T3> chain, out T3 item3)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item3);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by removing 
    /// <paramref name="item3"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item3">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3}(ManagedChain{TChain, T1, T2, T3}, out T3)" />
    public static ManagedChain<TChain, T1, T2> TruncateAny<TChain, T1, T2, T3>(this ManagedChain<TChain, T1, T2, T3> chain, out T3 item3)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
    {
        // Retrieve last item.
        item3 = chain.Item3;

        var newSize = ManagedChain<TChain, T1, T2, T3>.MemorySize - ManagedChain<TChain, T1, T2, T3>.Item3Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3>.Item2Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending <paramref name="item4"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item4">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3}, T4)" />
    public static ManagedChain<TChain, T1, T2, T3, T4> Add<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3> chain, T4 item4 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => chain.AddAny(item4);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending <paramref name="item4"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item4">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3}, T4)" />
    public static ManagedChain<TChain, T1, T2, T3, T4> AddAny<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3> chain, T4 item4 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 3
        item4.StructureType();        
        Marshal.StructureToPtr(item4, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> Duplicate<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3, T4> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> DuplicateAny<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3, T4> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item4Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4}, out T4)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4}, out T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> Truncate<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3, T4> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4}, out T4)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4}, out T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> TruncateAny<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3, T4> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 4 items, by removing 
    /// <paramref name="item4"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item4">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4}, out T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3> Truncate<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3, T4> chain, out T4 item4)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item4);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items, by removing 
    /// <paramref name="item4"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item4">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4}(ManagedChain{TChain, T1, T2, T3, T4}, out T4)" />
    public static ManagedChain<TChain, T1, T2, T3> TruncateAny<TChain, T1, T2, T3, T4>(this ManagedChain<TChain, T1, T2, T3, T4> chain, out T4 item4)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
    {
        // Retrieve last item.
        item4 = chain.Item4;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4>.Item4Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4>.Item3Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending <paramref name="item5"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item5">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4}, T5)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Add<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4> chain, T5 item5 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => chain.AddAny(item5);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending <paramref name="item5"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item5">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4}, T5)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> AddAny<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4> chain, T5 item5 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 4
        item5.StructureType();        
        Marshal.StructureToPtr(item5, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Duplicate<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> DuplicateAny<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item5Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5}, out T5)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5}, out T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> Truncate<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5}, out T5)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5}, out T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> TruncateAny<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 5 items, by removing 
    /// <paramref name="item5"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item5">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5}, out T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4> Truncate<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain, out T5 item5)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item5);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing 
    /// <paramref name="item5"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item5">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5}(ManagedChain{TChain, T1, T2, T3, T4, T5}, out T5)" />
    public static ManagedChain<TChain, T1, T2, T3, T4> TruncateAny<TChain, T1, T2, T3, T4, T5>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain, out T5 item5)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
    {
        // Retrieve last item.
        item5 = chain.Item5;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5>.Item5Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5>.Item4Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending <paramref name="item6"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item6">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5}, T6)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Add<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain, T6 item6 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => chain.AddAny(item6);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending <paramref name="item6"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item6">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5}, T6)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> AddAny<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5> chain, T6 item6 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 5
        item6.StructureType();        
        Marshal.StructureToPtr(item6, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Duplicate<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item6Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, out T6)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, out T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Truncate<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, out T6)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, out T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> TruncateAny<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 6 items, by removing 
    /// <paramref name="item6"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item6">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, out T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Truncate<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain, out T6 item6)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item6);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing 
    /// <paramref name="item6"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item6">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, out T6)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> TruncateAny<TChain, T1, T2, T3, T4, T5, T6>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain, out T6 item6)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
    {
        // Retrieve last item.
        item6 = chain.Item6;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item6Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending <paramref name="item7"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item7">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, T7)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Add<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain, T7 item7 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => chain.AddAny(item7);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending <paramref name="item7"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item7">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6}, T7)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6> chain, T7 item7 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 6
        item7.StructureType();        
        Marshal.StructureToPtr(item7, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, out T7)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, out T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, out T7)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, out T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 7 items, by removing 
    /// <paramref name="item7"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item7">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, out T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain, out T7 item7)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item7);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing 
    /// <paramref name="item7"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item7">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, out T7)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain, out T7 item7)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
    {
        // Retrieve last item.
        item7 = chain.Item7;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending <paramref name="item8"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item8">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, T8)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain, T8 item8 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        => chain.AddAny(item8);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending <paramref name="item8"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item8">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}, T8)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> chain, T8 item8 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 7
        item8.StructureType();        
        Marshal.StructureToPtr(item8, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, out T8)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, out T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, out T8)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, out T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 8 items, by removing 
    /// <paramref name="item8"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item8">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, out T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain, out T8 item8)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item8);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing 
    /// <paramref name="item8"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item8">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, out T8)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain, out T8 item8)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
    {
        // Retrieve last item.
        item8 = chain.Item8;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending <paramref name="item9"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item9">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, T9)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain, T9 item9 = default)
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
        => chain.AddAny(item9);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending <paramref name="item9"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item9">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}, T9)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain, T9 item9 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 8
        item9.StructureType();        
        Marshal.StructureToPtr(item9, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, out T9)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, out T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, out T9)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, out T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 9 items, by removing 
    /// <paramref name="item9"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item9">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, out T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain, out T9 item9)
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
        => chain.TruncateAny(out item9);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing 
    /// <paramref name="item9"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item9">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, out T9)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain, out T9 item9)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
    {
        // Retrieve last item.
        item9 = chain.Item9;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending <paramref name="item10"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item10">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, T10)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain, T10 item10 = default)
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
        => chain.AddAny(item10);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending <paramref name="item10"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item10">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}, T10)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain, T10 item10 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 9
        item10.StructureType();        
        Marshal.StructureToPtr(item10, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, out T10)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, out T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, out T10)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, out T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 10 items, by removing 
    /// <paramref name="item10"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item10">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, out T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain, out T10 item10)
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
        => chain.TruncateAny(out item10);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing 
    /// <paramref name="item10"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item10">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, out T10)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain, out T10 item10)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
    {
        // Retrieve last item.
        item10 = chain.Item10;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending <paramref name="item11"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item11">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, T11)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain, T11 item11 = default)
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
        => chain.AddAny(item11);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending <paramref name="item11"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item11">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}, T11)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain, T11 item11 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 10
        item11.StructureType();        
        Marshal.StructureToPtr(item11, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, out T11)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, out T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, out T11)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, out T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 11 items, by removing 
    /// <paramref name="item11"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item11">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, out T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain, out T11 item11)
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
        => chain.TruncateAny(out item11);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing 
    /// <paramref name="item11"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item11">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, out T11)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain, out T11 item11)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
    {
        // Retrieve last item.
        item11 = chain.Item11;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending <paramref name="item12"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item12">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, T12)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain, T12 item12 = default)
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
        => chain.AddAny(item12);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending <paramref name="item12"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item12">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}, T12)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain, T12 item12 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 11
        item12.StructureType();        
        Marshal.StructureToPtr(item12, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, out T12)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, out T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, out T12)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, out T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 12 items, by removing 
    /// <paramref name="item12"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item12">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, out T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain, out T12 item12)
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
        => chain.TruncateAny(out item12);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing 
    /// <paramref name="item12"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item12">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, out T12)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain, out T12 item12)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
    {
        // Retrieve last item.
        item12 = chain.Item12;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending <paramref name="item13"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item13">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, T13)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain, T13 item13 = default)
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
        => chain.AddAny(item13);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending <paramref name="item13"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item13">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}, T13)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain, T13 item13 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 12
        item13.StructureType();        
        Marshal.StructureToPtr(item13, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, out T13)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, out T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, out T13)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, out T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 13 items, by removing 
    /// <paramref name="item13"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item13">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, out T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain, out T13 item13)
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
        => chain.TruncateAny(out item13);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing 
    /// <paramref name="item13"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item13">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, out T13)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain, out T13 item13)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
    {
        // Retrieve last item.
        item13 = chain.Item13;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending <paramref name="item14"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item14">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, T14)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain, T14 item14 = default)
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
        => chain.AddAny(item14);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending <paramref name="item14"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item14">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}, T14)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain, T14 item14 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 13
        item14.StructureType();        
        Marshal.StructureToPtr(item14, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, out T14)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, out T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, out T14)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, out T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 14 items, by removing 
    /// <paramref name="item14"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item14">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, out T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain, out T14 item14)
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
        => chain.TruncateAny(out item14);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing 
    /// <paramref name="item14"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item14">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, out T14)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain, out T14 item14)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
    {
        // Retrieve last item.
        item14 = chain.Item14;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending <paramref name="item15"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item15">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, T15)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Add<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain, T15 item15 = default)
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
        => chain.AddAny(item15);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending <paramref name="item15"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item15">The item to append.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}, T15)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> AddAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain, T15 item15 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
    {
        var previousSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Append item 14
        item15.StructureType();        
        Marshal.StructureToPtr(item15, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Duplicate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain)
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
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> DuplicateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
    {
        var size = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Offset); 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}, out T15)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}, out T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain)
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
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}, out T15)" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}, out T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 15 items, by removing 
    /// <paramref name="item15"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item15">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}, out T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Truncate<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain, out T15 item15)
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
        => chain.TruncateAny(out item15);

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing 
    /// <paramref name="item15"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item15">The item removed from the <paramref name="chain"/>.</param>
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
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    /// <seealso cref="TruncateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15})" />
    /// <seealso cref="Truncate{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}, out T15)" />
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> TruncateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain, out T15 item15)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        where T2 : struct, IChainable
        where T3 : struct, IChainable
        where T4 : struct, IChainable
        where T5 : struct, IChainable
        where T6 : struct, IChainable
        where T7 : struct, IChainable
        where T8 : struct, IChainable
        where T9 : struct, IChainable
        where T10 : struct, IChainable
        where T11 : struct, IChainable
        where T12 : struct, IChainable
        where T13 : struct, IChainable
        where T14 : struct, IChainable
        where T15 : struct, IChainable
    {
        // Retrieve last item.
        item15 = chain.Item15;

        var newSize = ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize - ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset))->PNext = null; 
        return new ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

}

/// <summary>
/// A <see cref="ManagedChain{TChain}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
public unsafe sealed class ManagedChain<TChain> : ManagedChain, IEquatable<ManagedChain<TChain>>
    where TChain : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = HeadSize;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        HeadPtr->PNext = null;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain> left, ManagedChain<TChain> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain> left, ManagedChain<TChain> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1> : ManagedChain, IEquatable<ManagedChain<TChain, T1>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        Item1Ptr->PNext = null;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1> left, ManagedChain<TChain, T1> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1> left, ManagedChain<TChain, T1> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        Marshal.StructureToPtr(item2, (nint)itemPtr, false);
        Item1Ptr->PNext = itemPtr;
        Item2Ptr->PNext = null;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2> left, ManagedChain<TChain, T1, T2> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2> left, ManagedChain<TChain, T1, T2> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3> left, ManagedChain<TChain, T1, T2, T3> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3> left, ManagedChain<TChain, T1, T2, T3> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4> left, ManagedChain<TChain, T1, T2, T3, T4> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4> left, ManagedChain<TChain, T1, T2, T3, T4> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5> left, ManagedChain<TChain, T1, T2, T3, T4, T5> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5> left, ManagedChain<TChain, T1, T2, T3, T4, T5> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
    where T10 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
    where T10 : struct, IChainable
    where T11 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
    where T10 : struct, IChainable
    where T11 : struct, IChainable
    where T12 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
    where T10 : struct, IChainable
    where T11 : struct, IChainable
    where T12 : struct, IChainable
    where T13 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(", ");
        sb.Append((object) Item13);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
    where T10 : struct, IChainable
    where T11 : struct, IChainable
    where T12 : struct, IChainable
    where T13 : struct, IChainable
    where T14 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(", ");
        sb.Append((object) Item13);
        sb.Append(", ");
        sb.Append((object) Item14);
        sb.Append(")");
        return sb.ToString();
    }

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
public unsafe sealed class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ManagedChain, IEquatable<ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
    where T2 : struct, IChainable
    where T3 : struct, IChainable
    where T4 : struct, IChainable
    where T5 : struct, IChainable
    where T6 : struct, IChainable
    where T7 : struct, IChainable
    where T8 : struct, IChainable
    where T9 : struct, IChainable
    where T10 : struct, IChainable
    where T11 : struct, IChainable
    where T12 : struct, IChainable
    where T13 : struct, IChainable
    where T14 : struct, IChainable
    where T15 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

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
    /// <param name="headPtr">The pointer to the head of the chain.</param>
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
    internal ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(ManagedChain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item15Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item15Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(", ");
        sb.Append((object) Item13);
        sb.Append(", ");
        sb.Append((object) Item14);
        sb.Append(", ");
        sb.Append((object) Item15);
        sb.Append(")");
        return sb.ToString();
    }

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
