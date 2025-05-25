// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Maths;

namespace Silk.NET.Input;

/// <summary>
/// Contains extensions for creating input backends and contexts from <see cref="INativeWindow"/>s.
/// </summary>
public static partial class InputWindowExtensions
{
    /// <summary>
    /// Creates an instance of the "reference implementation" of <see cref="IInputBackend"/> for the given
    /// <see cref="INativeWindow"/>, provided that this was also sourced from the "reference implementation" of the
    /// windowing API. The returned backend will capture input for the <see cref="INativeWindow"/> provided and all
    /// descendants of that <see cref="INativeWindow"/> i.e. spawned children do not need their own backend.
    /// </summary>
    /// <remarks>
    /// Regarding the threading rules documented on <see cref="IInputBackend"/>, <see cref="IInputBackend.Update"/>
    /// must only be called on the "main thread," i.e. the same thread that windowing operates on.
    /// </remarks>
    /// <param name="window">The window to create an input backend from.</param>
    /// <returns>The input backend.</returns>
    /// <exception cref="NotSupportedException">
    /// If the given <see cref="INativeWindow"/> is not compatible with the reference implementation for this platform.
    /// </exception>
    public static partial IInputBackend CreateInputBackend(this INativeWindow window);

    /// <summary>
    /// Creates an <see cref="InputContext"/> that uses the "reference implementation" of <see cref="IInputBackend"/>
    /// for the given <see cref="INativeWindow"/> as its only backend, provided that the <see cref="INativeWindow"/> was
    /// also sourced from the "reference implementation" of the windowing API. The returned backend will capture input
    /// for the <see cref="INativeWindow"/> provided and all descendants of that <see cref="INativeWindow"/> i.e.
    /// spawned children do not need their own backend.
    /// </summary>
    /// <remarks>
    /// Regarding the threading rules documented on <see cref="InputContext"/>, <see cref="InputContext.Update"/>
    /// must only be called on the "main thread," i.e. the same thread that windowing operates on.
    /// </remarks>
    /// <param name="window">The window to create an input backend from.</param>
    /// <returns>
    /// The <see cref="InputContext"/> created with the instantiated input backend as its only backend.
    /// </returns>
    /// <exception cref="NotSupportedException">
    /// If the given <see cref="INativeWindow"/> is not compatible with the reference implementation for this platform.
    /// </exception>
    public static InputContext CreateInput(this INativeWindow window)
    {
        var ret = new InputContext();
        ret.Backends.Add(window.CreateInputBackend());
        return ret;
    }
}
