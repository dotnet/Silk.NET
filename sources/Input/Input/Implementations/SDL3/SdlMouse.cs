// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input.SDL3;

internal class SdlMouse : IMouse
{
    public bool Equals(IInputDevice? other) => throw new NotImplementedException();

    public IntPtr Id => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    public MouseState State => throw new NotImplementedException();

    public ICursorConfiguration Cursor => throw new NotImplementedException();

    public bool TrySetPosition(Vector2 position) => throw new NotImplementedException();

    public IReadOnlyList<IPointerTarget> Targets => throw new NotImplementedException();
}
