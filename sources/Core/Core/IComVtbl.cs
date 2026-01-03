// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core
{
    /// <summary>
    /// Represents a type that can be represented as a pointer to a COM V-Table. (i.e. a pointer to a pointer to the first
    /// function pointer) 
    /// </summary>
    public interface IComVtbl : INativeGuid
    {
        /// <summary>
        /// Gets the address of the pointer to the V-Table as a given interface.
        /// </summary>
        /// <typeparam name="TNativeInterface">The native interface object type</typeparam>
        /// <returns>the pointer to the V-Table as a given interface</returns>
        Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>()
            where TNativeInterface : unmanaged;

        /// <summary>
        /// Gets the address of the pointer to the V-Table.
        /// </summary>
        /// <returns> pointer to the V-Table</returns>
        Ptr2D GetAddressOf();
    }
}
