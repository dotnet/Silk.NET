// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input.SDL3;

internal class SdlKeyboard : SdlDevice, IKeyboard
{
    public SdlKeyboard(SdlInputBackend backend)
        : base(backend) { }

    public override nint Id => throw new NotImplementedException();

    public override string Name => throw new NotImplementedException();

    public KeyboardState State => throw new NotImplementedException();

    public string? ClipboardText
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name) =>
        throw new NotImplementedException();

    public void BeginInput() => throw new NotImplementedException();

    public string? EndInput() => throw new NotImplementedException();
}
