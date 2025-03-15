// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable CheckNamespace
namespace Silk.NET.Input;

/// <summary>
/// Contains extensions for creating input backends and contexts from <see cref="INativeWindow"/>s.
/// </summary>
public static partial class InputWindowExtensions
{
    public static partial IInputBackend CreateInputBackend(this INativeWindow window)
    {
        throw new NotImplementedException();
    }
}
