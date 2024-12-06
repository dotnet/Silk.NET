using System.Collections.Generic;
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
