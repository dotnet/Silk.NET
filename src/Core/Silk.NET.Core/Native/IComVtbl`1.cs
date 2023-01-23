// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Native;

/// <summary>
/// A marker interface declaring this type to have a V-table for the given COM type. 
/// </summary>
/// <typeparam name="T">The COM type this type contains a V-table to.</typeparam>
public interface IComVtbl<T>: IComVtbl where T: IComVtbl
{
    
}
