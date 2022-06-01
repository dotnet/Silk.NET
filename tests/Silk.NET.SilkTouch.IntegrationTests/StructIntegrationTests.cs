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
        var result = TestHelper.GetCSharpOutputFromCPP(@"
#include <stdint.h>

typedef struct {
    int32_t f1;
    int32_t f2;
} Test;");
        return Verifier.Verify(result);
    }
}
