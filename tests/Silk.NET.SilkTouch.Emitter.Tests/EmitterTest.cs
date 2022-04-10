// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Emitter.Tests;

public abstract class EmitterTest
{
    protected CSharpEmitter CreateEmitter()
    {
        return new CSharpEmitter();
    }
}
