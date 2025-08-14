// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
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
    
    private readonly Encoding lpwStrEncoding = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
        ? Encoding.Unicode
        : Encoding.UTF32;

    private readonly int lpwStrCharacterWidth = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? 2 : 4;

    [Fact]
    public unsafe void TestEncodingToLPWStr()
    {
        var input = "Hello world 🧵";
        
        var expectedByteCount = lpwStrEncoding.GetByteCount(input);
        var expected = new byte[expectedByteCount + lpwStrCharacterWidth];
        lpwStrEncoding.GetBytes(input, expected);
        
        var pointer = SilkMarshal.StringToPtr(input, NativeStringEncoding.LPWStr);
        var pointerByteCount = lpwStrCharacterWidth * (int) SilkMarshal.StringLength(pointer, NativeStringEncoding.LPWStr);
        
        Assert.Equal(expected, new Span<byte>((void*)pointer, pointerByteCount + lpwStrCharacterWidth));
    }
 
    [Fact]
    public unsafe void TestEncodingFromLPWStr()
    {
        var expected = "Hello world 🧵";
        
        var inputByteCount = lpwStrEncoding.GetByteCount(expected);
        var input = new byte[inputByteCount + lpwStrCharacterWidth];
        lpwStrEncoding.GetBytes(expected, input);

        fixed (byte* pInput = input)
        {
            var output = SilkMarshal.PtrToString((nint)pInput, NativeStringEncoding.LPWStr);
            
            Assert.Equal(expected, output);
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
