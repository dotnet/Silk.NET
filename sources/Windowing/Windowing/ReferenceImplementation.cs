// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;
using Silk.NET.SDL;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents the reference implementation for <see cref="Surface"/>. This currently uses SDL.
/// </summary>
[HluRegisteredComponent<IPlatformInfo, SdlNativeWindow>(Override = true)]
public partial class ReferenceImplementation;
