// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL;
using Silk.NET.OpenAL.Extensions.Creative;
using Silk.NET.OpenAL.Extensions.Enumeration;
using Silk.NET.OpenAL.Extensions.EXT;
using Silk.NET.OpenAL.Extensions.Soft;
using Xunit;
using Xunit.Abstractions;

namespace Silk.NET.OpenAL.Tests;

public class ExtensionLoadingTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ExtensionLoadingTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
    public static unsafe int AlwaysOne(byte* name) => 1;

    [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
    public static unsafe int AlwaysZero(byte* name) => 0;

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static unsafe Context* GetCurrentContext() => null;

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static unsafe Device* GetContextsDevice(Context* ctx) => null;

    public unsafe delegate nint LoaderDelegate(byte* name);
    public unsafe delegate nint ContextLoaderDelegate(void* device, byte* name);
    
    public static unsafe Func<string, nint> GetLoader(bool alwaysPresent, out nint loaderPtr, out nint ctxLoaderPtr)
    {
        var wrapper = new nint[2];
        var theDelegate = (LoaderDelegate) Loader;

        // The wrapper array is so the delegates can use eachothers resources without having to worry about
        // modifications outside of the delegate's scope.
        wrapper[0] = loaderPtr = SilkMarshal.DelegateToPtr(theDelegate);
        wrapper[1] = ctxLoaderPtr = SilkMarshal.DelegateToPtr((ContextLoaderDelegate) ((_, x) => theDelegate(x)));

        return x => theDelegate((byte*) SilkMarshal.StringToPtr(x));

        nint Loader(byte* x) => SilkMarshal.PtrToString((nint) x) switch
        {
            "alcIsExtensionPresent" or "alIsExtensionPresent" => alwaysPresent
                ? (nint) (delegate* unmanaged[Cdecl]<byte*, int>) &AlwaysOne
                : (nint) (delegate* unmanaged[Cdecl]<byte*, int>) &AlwaysZero,
            "alcGetCurrentContext" => (nint) (delegate* unmanaged[Cdecl]<Context*>) &GetCurrentContext,
            "alcGetContextsDevice" => (nint) (delegate* unmanaged[Cdecl]<Context*, Device*>) &GetContextsDevice,
            "alGetProcAddress" => wrapper[0],
            "alcGetProcAddress" => wrapper[1],
            "alGetEnumValue" => (nint) (delegate* unmanaged[Cdecl]<byte*, int>) &AlwaysZero,
            _ => 0
        };
    }

    [Theory]
    [InlineData(true), InlineData(false)]
    public unsafe void TestALContextTryGetExtension(bool isPresent)
    {
        // never do anything demonstrated in this test
        using var loader = new LamdaNativeContext(GetLoader(isPresent, out var loaderPtr, out var ctxLoaderPtr));
        using var alc = new ALContext(loader);

        void Test<T>() where T:NativeExtension<ALContext>
        {
            _testOutputHelper.WriteLine(typeof(T).ToString());
            Assert.Equal(alc.TryGetExtension(null, out T ext), isPresent);
            Assert.Equal(ext is not null, isPresent);
        }

        Test<Capture>();
        Test<Enumeration>();
        Test<EnumerateAll>();
        Test<CaptureEnumerationEnumeration>();
        Test<EffectExtensionContext>();
        Test<Disconnect>();
        Test<ReopenDevices>();

        SilkMarshal.Free(loaderPtr);
        SilkMarshal.Free(ctxLoaderPtr);
    }

    [Theory]
    [InlineData(true), InlineData(false)]
    public unsafe void TestALTryGetExtension(bool isPresent)
    {
        // never do anything demonstrated in this test
        using var loader = new LamdaNativeContext(GetLoader(isPresent, out var loaderPtr, out var ctxLoaderPtr));
        using var al = new AL(loader);

        void Test<T>() where T:NativeExtension<AL>
        {
            _testOutputHelper.WriteLine(typeof(T).ToString());
            Assert.Equal(al.TryGetExtension(out T ext), isPresent);
            Assert.Equal(ext is not null, isPresent);
        }

        Test<SoftGainClamp>();
        Test<SoftEvents>();
        Test<SoftSourceResampler>();
        Test<EffectExtension>();
        Test<XRam>();
        Test<DeferredUpdates>();
        Test<SoftEffectTarget>();

        SilkMarshal.Free(loaderPtr);
        SilkMarshal.Free(ctxLoaderPtr);
    }
}
