// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SDL;

/// <summary>
/// The SDL platform-specific handles.
/// </summary>
/// <param name="Window"><see cref="WindowHandle"/>.</param>
/// <param name="Sdl">The SDL API interface. If <c>null</c>, use <see cref="Sdl.Instance"/>.</param>
public readonly record struct SdlPlatformInfo(WindowHandle Window, ISdl? Sdl = null);
