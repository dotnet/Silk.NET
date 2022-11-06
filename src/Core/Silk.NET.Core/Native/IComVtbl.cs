// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Native;

/// <summary>
/// Represents a type that can be represented as a pointer to a COM V-Table. (i.e. a pointer to a pointer to the first
/// function pointer) 
/// </summary>
public interface IComVtbl
{
    /// <summary>
    /// Gets the V-Table pointer.
    /// </summary>
    /// <returns></returns>
    unsafe void*** AsVtblPtr();
}
