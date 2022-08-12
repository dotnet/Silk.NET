// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Native;

public static unsafe class ComPtr
{
    public static ComPtr<TTo> Downcast<TFrom, TTo>(ComPtr<TFrom> og)
        where TFrom : unmanaged, IComVtbl<TFrom>, IComVtbl<TTo>
        where TTo : unmanaged, IComVtbl<TTo>
        => new((TTo*) og.Handle);
}
