using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public static class Chain
{
    /// <summary>
    /// Replaces a structure in the chain (if present, and <paramref name="alwaysAdd"/> is false), or adds it to the end.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="value">A reference to the structure to update</param>
    /// <param name="alwaysAdd">Always adds to the end of the chain, even if an equivalent structure is present.</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>A reference to the value value in the chain</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the supplied value will have their `SType` correctly set.  Further,
    /// the supplied structure's <see cref="IChainable.PNext"/> will be overwritten.</para>
    /// <para>To use</para>
    /// <code>
    /// var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    /// {
    ///     ShaderInputAttachmentArrayDynamicIndexing = true
    /// };
    /// var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKhr
    /// {
    ///     AccelerationStructure = true
    /// };
    /// 
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .SetNext(ref indexingFeatures)
    ///     .SetNext(ref accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TChain SetNext<TChain, TNext>
    (
        this ref TChain chain,
        ref TNext value,
        bool alwaysAdd = false
    )
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => ref SetNextAny(ref chain, ref value, alwaysAdd);

    /// <summary>
    /// Replaces a structure in the chain (if present, and <paramref name="alwaysAdd"/> is false), or adds it to the end.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="value">A reference to the structure to update</param>
    /// <param name="alwaysAdd">Always adds to the end of the chain, even if an equivalent structure is present.</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>A reference to the value value in the chain</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the supplied value will have their `SType` correctly set.  Further,
    /// the supplied structure's <see cref="IChainable.PNext"/> will be overwritten.</para>
    /// <para>To use</para>
    /// <code>
    /// var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    /// {
    ///     ShaderInputAttachmentArrayDynamicIndexing = true
    /// };
    /// var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKhr
    /// {
    ///     AccelerationStructure = true
    /// };
    /// 
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .SetNext(ref indexingFeatures)
    ///     .SetNext(ref accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    public static unsafe ref TChain SetNextAny<TChain, TNext>
    (
        this ref TChain chain,
        ref TNext value,
        bool alwaysAdd = false
    )
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {
        // Ensure structure type of chain and value are set.
        chain.StructureType();
        var structureType = value.StructureType();

        // Find end of chain
        var previousPtr = (BaseInStructure*) null;
        var currentPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var valuePtr = (BaseInStructure*) Unsafe.AsPointer(ref value);
        do
        {
            var nextPtr = currentPtr->PNext;
            if (!alwaysAdd && currentPtr->SType == structureType)
            {
                // We have an existing structure, replace it.
                if (previousPtr is not null)
                {
                    previousPtr->PNext = valuePtr;
                }

                valuePtr->PNext = nextPtr;

                return ref chain;
            }

            previousPtr = currentPtr;
            currentPtr = nextPtr;
        } while (currentPtr is not null);

        // Add value to end of chain
        previousPtr->PNext = valuePtr;
        valuePtr->PNext = null;

        return ref chain;
    }

    /// <summary>
    /// Adds a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    ///     .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKhr accelerationStructureFeaturesKhr);
    /// </code>
    /// <para>Note, the value is always added, even if an equivalent value is added in the chain already.  Use
    /// <see cref="TryAddNext{TChain,TNext}"/> to only add if not already present.</para>
    /// </remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TChain AddNext<TChain, TNext>(this ref TChain chain, out TNext next)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => ref AddNextAny(ref chain, out next);

    /// <summary>
    /// Adds a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    ///     .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKhr accelerationStructureFeaturesKhr);
    /// </code>
    /// <para>Note, the value is always added, even if an equivalent value is added in the chain already.  Use
    /// <see cref="TryAddNext{TChain,TNext}"/> to only add if not already present.</para>
    /// </remarks>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    public static unsafe ref TChain AddNextAny<TChain, TNext>(this ref TChain chain, out TNext next)
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {
        // Ensure structure type of chain is set.
        chain.StructureType();

        // Find end of chain
        var currentPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        while (currentPtr->PNext is not null)
        {
            currentPtr = currentPtr->PNext;
        }

        // Create new entry and set it's structure type
        next = default;
        next.StructureType();
        currentPtr->PNext = (BaseInStructure*) Unsafe.AsPointer(ref next);
        return ref chain;
    }

    /// <summary>
    /// Tries to add a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <param name="added">Whether the structure was actually added</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures, out var added);
    /// </code>
    /// </remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TChain TryAddNext<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => ref TryAddNextAny(ref chain, out next, out added);

    /// <summary>
    /// Tries to add a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <param name="added">Whether the structure was actually added</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures, out var added);
    /// </code>
    /// </remarks>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    public static unsafe ref TChain TryAddNextAny<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {
        // Ensure structure type of chain is set.
        chain.StructureType();

        // Create new entry and get it's structure type
        next = default;
        var structureType = next.StructureType();

        // Follow chain
        var currentPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        do
        {
            if (currentPtr->SType == structureType)
            {
                added = false;
                return ref chain;
            }

            var nextPtr = currentPtr->PNext;
            if (nextPtr is null)
            {
                break;
            }

            currentPtr = nextPtr;
        } while (true);

        currentPtr->PNext = (BaseInStructure*) Unsafe.AsPointer(ref next);
        added = true;
        return ref chain;
    }

    /// <summary>
    /// Returns the index of the <paramref name="value"/> in the <paramref name="chain"/>, if present.
    /// </summary>
    /// <param name="chain">The chain</param>
    /// <param name="value">The structure value</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>The zero-indexed index if found; otherwise -1.</returns>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IndexOf<TChain, TNext>(this ref TChain chain, ref TNext value)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => IndexOfAny(ref chain, ref value);

    /// <summary>
    /// Returns the index of the <paramref name="value"/> in the <paramref name="chain"/>, if present.
    /// </summary>
    /// <param name="chain">The chain</param>
    /// <param name="value">The structure value</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>The zero-indexed index if found; otherwise -1.</returns>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    public static unsafe int IndexOfAny<TChain, TNext>(this ref TChain chain, ref TNext value)
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {
        // Ensure structure type of chain is set.
        chain.StructureType();

        var index = 0;
        var currentPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var valuePtr = (BaseInStructure*) Unsafe.AsPointer(ref value);
        // Follow chain
        do
        {
            if (currentPtr == valuePtr)
            {
                return index;
            }

            currentPtr = currentPtr->PNext;
            index++;
        } while (currentPtr is not null);

        return -1;
    }

    /// <summary>
    /// Provides a set of all the <see cref="StructureType"/>s that can be extended by a <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, IReadOnlyCollection<StructureType>> Extensions =
        new Dictionary<StructureType, IReadOnlyCollection<StructureType>>
        {
            [Vulkan.StructureType.PhysicalDeviceFeatures2] = new HashSet<StructureType>
            {
                Vulkan.StructureType.DeviceCreateInfo
            },
            [Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceFeatures2,
                Vulkan.StructureType.DeviceCreateInfo
            },
            [Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceFeatures2,
                Vulkan.StructureType.DeviceCreateInfo
            }
        };

    /// <summary>
    /// Provides a set of all the <see cref="StructureType"/>s that can extend a <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, IReadOnlyCollection<StructureType>> Extenders =
        new Dictionary<StructureType, IReadOnlyCollection<StructureType>>
        {
            [Vulkan.StructureType.DeviceCreateInfo] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceFeatures2,
                Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures,
                Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            },
            [Vulkan.StructureType.PhysicalDeviceFeatures2] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures,
                Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            }
        };

    /// <summary>
    /// Provides a mapping from the <see cref="StructureType"/> to the corresponding <see cref="Type"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, Type> ClrTypes =
        new Dictionary<StructureType, Type>
        {
            [Vulkan.StructureType.DeviceCreateInfo] = typeof(DeviceCreateInfo),
            [Vulkan.StructureType.PhysicalDeviceFeatures2] = typeof(PhysicalDeviceFeatures2),
            [Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures] =
                typeof(PhysicalDeviceDescriptorIndexingFeatures),
            [Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] =
                typeof(PhysicalDeviceAccelerationStructureFeaturesKhr)
        };

    /// <summary>
    /// Provides a mapping from the <see cref="Type"/> to the corresponding <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<Type, StructureType> StructureTypes =
        new Dictionary<Type, StructureType>
        {
            [typeof(DeviceCreateInfo)] = Vulkan.StructureType.DeviceCreateInfo,
            [typeof(PhysicalDeviceFeatures2)] = Vulkan.StructureType.PhysicalDeviceFeatures2,
            [typeof(PhysicalDeviceDescriptorIndexingFeatures)] =
                Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures,
            [typeof(PhysicalDeviceAccelerationStructureFeaturesKhr)] =
                Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
        };

    /// <summary>
    /// Gets the corresponding <see cref="StructureType"/> for a <see cref="Type"/>, if any.
    /// </summary>
    /// <param name="structureType">The structure type.</param>
    /// <returns> The corresponding <see cref="StructureType"/> for <paramref name="structureType"/>, if any; otherwise,
    /// <see langword="null"/>.</returns>
    public static Type ClrType(this StructureType structureType)
    {
        return ClrTypes[structureType];
    }

    /// <summary>
    /// Gets the corresponding <see cref="StructureType"/> for a <see cref="Type"/>, if any.
    /// </summary>
    /// <param name="type">The CLR type.</param>
    /// <returns>The corresponding <see cref="StructureType"/> for <paramref name="type"/>, if any; otherwise,
    /// <see langword="null"/>.</returns>
    public static StructureType? StructureType(this Type type)
    {
        return StructureTypes.TryGetValue(type, out var structureType) ? structureType : null;
    }

    /// <summary>
    /// Whether the <see cref="StructureType"/> can start a chain.
    /// </summary>
    /// <param name="type">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainStart(this StructureType type)
    {
        return Extenders.ContainsKey(type);
    }

    /// <summary>
    /// Whether the <see cref="Type"/> can start a chain.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainStart(this Type type)
    {
        return StructureTypes.TryGetValue(type, out var structureType) &&
               Extenders.ContainsKey(structureType);
    }

    /// <summary>
    /// Whether the <see cref="StructureType"/> is chainable.
    /// </summary>
    /// <param name="type">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainable(this StructureType type)
    {
        return Extenders.ContainsKey(type) ||
               Extensions.ContainsKey(type);
    }

    /// <summary>
    /// Whether the <see cref="Type"/> is chainable.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainable(this Type type)
    {
        return StructureTypes.TryGetValue(type, out var structureType) &&
               (Extenders.ContainsKey(structureType) || Extensions.ContainsKey(structureType));
    }

    /// <summary>
    /// Whether the current <see cref="StructureType"/> can extend the <paramref name="chain"/>.
    /// </summary>
    /// <param name="next">The <see cref="StructureType"/> to test.</param>
    /// <param name="chain">The <see cref="StructureType"/> of the chain.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanBeExtendedBy(Silk.Net.Vulkan.StructureType,Silk.Net.Vulkan.StructureType)"/>
    public static bool CanExtend(this StructureType next, StructureType chain)
    {
        return Extensions.TryGetValue(next, out var extensions) && extensions.Contains(chain);
    }

    /// <summary>
    /// Whether the current <see cref="Type"/> can extend the <paramref name="chain"/>.
    /// </summary>
    /// <param name="next">The <see cref="Type"/> to test.</param>
    /// <param name="chain">The <see cref="Type"/> of the chain.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanBeExtendedBy(System.Type,System.Type)"/>
    public static bool CanExtend(this Type next, Type chain)
    {
        return
            StructureTypes.TryGetValue(next, out var nextType) &&
            StructureTypes.TryGetValue(chain, out var chainType) &&
            Extensions.TryGetValue(nextType, out var extensions) &&
            extensions.Contains(chainType);
    }

    /// <summary>
    /// Whether the current <paramref name="chain"/> can be extended by the <paramref name="next"/> <see cref="StructureType"/>.
    /// </summary>
    /// <param name="chain">The <see cref="StructureType"/> of the chain.</param>
    /// <param name="next">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <paramref name="chain"/> can be extended the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanExtend(Silk.Net.Vulkan.StructureType,Silk.Net.Vulkan.StructureType)"/>
    public static bool CanBeExtendedBy(this StructureType chain, StructureType next)
    {
        return Extenders.TryGetValue(chain, out var extenders) && extenders.Contains(next);
    }

    /// <summary>
    /// Whether the current <paramref name="chain"/> can be extended by the <paramref name="next"/> <see cref="Type"/>.
    /// </summary>
    /// <param name="chain">The <see cref="Type"/> of the chain.</param>
    /// <param name="next">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanExtend(Type, Type)"/>
    public static bool CanBeExtendedBy(this Type chain, Type next)
    {
        return
            StructureTypes.TryGetValue(next, out var nextType) &&
            StructureTypes.TryGetValue(chain, out var chainType) &&
            Extenders.TryGetValue(chainType, out var extenders) &&
            extenders.Contains(nextType);
    }
}
