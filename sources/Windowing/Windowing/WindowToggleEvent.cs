// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a boolean window property being toggled.
/// </summary>
/// <param name="Value">The new value.</param>
public readonly record struct WindowToggleEvent(Surface Surface, bool Value);
