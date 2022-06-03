// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace Silk.NET.SilkTouch.IntegrationTests;

[UsesVerify]
public class StructIntegrationTests
{
    [Fact]
    public Task Test1()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#include <stdint.h>

typedef struct {
    int32_t f1;
    int32_t f2;
} Test;");
        return Verifier.Verify(result);
    }

    [Fact]
    public Task Test2()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
struct vec2 { float x, y; };
struct vec3 : vec2 { float z; };
struct vec4 : vec3 { float w; };");
        return Verifier.Verify(result);
    }
}
