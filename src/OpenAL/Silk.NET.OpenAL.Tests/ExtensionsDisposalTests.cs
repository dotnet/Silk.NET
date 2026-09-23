// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.OpenAL.Extensions.Enumeration;
using Xunit;

namespace Silk.NET.OpenAL.Tests;

public class ExtensionsDisposalTests
{
    private static nint GetProcAddress(ALContext alc) =>
        alc.Context.GetProcAddress("alcIsExtensionPresent");
    
    [Fact]
    public unsafe void TestALContextExtensionDispose()
    {
        var alc = ALContext.GetApi();
        alc.TryGetExtension<Enumeration>(null, out var ext);

        // Disposing the same object multiple times should not throw
        ext.Dispose();
        alc.Dispose();

        alc.Dispose();
        ext.Dispose();
    }

    [Fact]
    public unsafe void TestALContextExtensionDisposeState()
    {
        using var alc = ALContext.GetApi();
        alc.TryGetExtension<Enumeration>(null, out var ext);
        
        var address = GetProcAddress(alc);
        Assert.NotEqual(0, address);
        
        ext.Dispose();
        
        // Disposing the extension should not affect the parent context
        address = GetProcAddress(alc);
        Assert.NotEqual(0, address);
    }
}
