// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;
using Xunit;

namespace Silk.NET.Core.Tests;

public class TestSilkMarshal
{
    private readonly List<NativeStringEncoding> encodings = new()
    {
        NativeStringEncoding.BStr,
        NativeStringEncoding.LPStr,
        NativeStringEncoding.LPTStr,
        NativeStringEncoding.LPUTF8Str,
        NativeStringEncoding.LPWStr,
    };

    [Fact]
    public unsafe void TestEncodingToLPWStr()
    {
        var input = "Hello world";
        
        // LPWStr is 2 bytes on Windows, 4 bytes elsewhere (usually)
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var pointer = SilkMarshal.StringToPtr(input, NativeStringEncoding.LPWStr);
            
            Assert.Equal(input.Length, (int)SilkMarshal.StringLength(pointer, NativeStringEncoding.LPWStr));
            
            // Use short for comparison
            Assert.Equal(new short[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x00 }, new Span<short>((void*)pointer, input.Length + 1));
        }
        else
        {
            var pointer = SilkMarshal.StringToPtr(input, NativeStringEncoding.LPWStr);
            
            Assert.Equal(input.Length, (int)SilkMarshal.StringLength(pointer, NativeStringEncoding.LPWStr));
            
            // Use int for comparison
            Assert.Equal(new int[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x00 }, new Span<int>((void*)pointer, input.Length + 1));
        }
    }
    
    [Fact]
    public unsafe void TestEncodingFromLPWStr()
    {
        var expected = "Hello world";
        
        // LPWStr is 2 bytes on Windows, 4 bytes elsewhere (usually)
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var characters = new short[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64 };
            fixed (short* pCharacters = characters)
            {
                var output = SilkMarshal.PtrToString((nint)pCharacters, NativeStringEncoding.LPWStr);
                Assert.Equal(expected, output);
            }
        }
        else
        {
            var characters = new int[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64 };
            fixed (int* pCharacters = characters)
            {
                var output = SilkMarshal.PtrToString((nint)pCharacters, NativeStringEncoding.LPWStr);
                Assert.Equal(expected, output);
            }
        }
    }
    
    [Fact]
    public void TestEncodingString()
    {
        var input = "Hello world";
        foreach (var encoding in encodings)
        {
            var pointer = SilkMarshal.StringToPtr(input, encoding);
            var roundTrip = SilkMarshal.PtrToString(pointer, encoding);
            Assert.Equal(input, roundTrip);
        }
    }
    
    [Fact]
    public void TestEncodingStringArray()
    {
        var inputs = new List<string>()
        {
            "Hello world",
            "Foo",
            "Bar",
            "123",
        };
        
        foreach (var encoding in encodings)
        {
            var pointer = SilkMarshal.StringArrayToPtr(inputs, encoding);
            var roundTrip = SilkMarshal.PtrToStringArray(pointer, inputs.Count, encoding);
            for (var i = 0; i < roundTrip.Length; i++)
            {
                Assert.Equal(inputs[i], roundTrip[i]);
            }
        }
    }
}
