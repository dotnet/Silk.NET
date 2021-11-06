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
        StringBuilder errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 2");
        else {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
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
            0 => Head,            1 => Item1,
            _ => throw new IndexOutOfRangeException()
        };

    /// <inheritdoc />
    public override void Dispose()
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
public unsafe class ManagedChain<TChain, T1, T2> : ManagedChain
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
        StringBuilder errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 3");
        else {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }
        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 3");
        else {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
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
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, originalSize, originalSize);

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
            0 => Head,            1 => Item1,
            2 => Item2,
            _ => throw new IndexOutOfRangeException()
        };

    /// <inheritdoc />
    public override void Dispose()
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
public unsafe class ManagedChain<TChain, T1, T2, T3> : ManagedChain
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
        StringBuilder errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 4");
        else {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }
        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 4");
        else {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }
        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 4");
        else {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
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
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, originalSize, originalSize);

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
            0 => Head,            1 => Item1,
            2 => Item2,
            3 => Item3,
            _ => throw new IndexOutOfRangeException()
        };

    /// <inheritdoc />
    public override void Dispose()
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
public unsafe class ManagedChain<TChain, T1, T2, T3, T4> : ManagedChain
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
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
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
        StringBuilder errorBuilder = new StringBuilder();

        currentPtr = currentPtr->PNext;
        T1 item1 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 5");
        else {
            expectedStructureType = item1.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
                item1 = Unsafe.AsRef<T1>(currentPtr);
        }
        var item1Size = Marshal.SizeOf<T1>();

        currentPtr = currentPtr->PNext;
        T2 item2 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 5");
        else {
            expectedStructureType = item2.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
                item2 = Unsafe.AsRef<T2>(currentPtr);
        }
        var item2Size = Marshal.SizeOf<T2>();

        currentPtr = currentPtr->PNext;
        T3 item3 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 5");
        else {
            expectedStructureType = item3.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
                item3 = Unsafe.AsRef<T3>(currentPtr);
        }
        var item3Size = Marshal.SizeOf<T3>();

        currentPtr = currentPtr->PNext;
        T4 item4 = default;
        if (currentPtr is null)
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 5");
        else {
            expectedStructureType = item4.StructureType();
            if (currentPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(currentPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else
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
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, originalSize, originalSize);

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
            0 => Head,            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            _ => throw new IndexOutOfRangeException()
        };

    /// <inheritdoc />
    public override void Dispose()
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
