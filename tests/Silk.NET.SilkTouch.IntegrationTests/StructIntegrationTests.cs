// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace Silk.NET.SilkTouch.IntegrationTests;

[UsesVerify]
public class StructIntegrationTests
{
    [Fact,
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
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

    [Fact(Skip = "TODO: Reenable after proper type support"),
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields"),
     Trait("Feature", "Inheritance")]
    public Task Test2()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
struct vec2 { float x, y; };
struct vec3 : vec2 { float z; };
struct vec4 : vec3 { float w; };");
        return Verifier.Verify(result);
    }

    [Fact(Skip = "TODO: Reenable after proper type support"),
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields"),
     Trait("Feature", "Unions"),
     Trait("Feature", "Nested Types")]
    public Task Test3()
    {
        // from https://en.cppreference.com/w/c/language/struct
        var result = TestHelper.GetCSharpOutputFromCpp(@"
struct v {
   union { // anonymous union
      struct { int i, j; }; // anonymous structure
      struct { long k, l; } w;
   };
   int m;
} v1;");
        return Verifier.Verify(result);
    }

    [Fact,
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public Task Test4()
    {
        // from https://en.cppreference.com/w/c/language/struct
        var result = TestHelper.GetCSharpOutputFromCpp(@"
struct y;
struct x { struct y *p; /* ... */ };
struct y { struct x *q; /* ... */ };");
        return Verifier.Verify(result);
    }

    [Fact(Skip = "TODO: Reenable after proper type support"),
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Fields"),
     Trait("Feature", "Unions"),
     Trait("Feature", "Fixed-Size Arrays")]
    public Task Test5()
    {
        // from https://en.cppreference.com/w/cpp/language/union
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#include <iostream>
#include <cstdint>
union S
{
    std::int32_t n;     // occupies 4 bytes
    std::uint16_t s[2]; // occupies 4 bytes
    std::uint8_t c;     // occupies 1 byte
};   ");
        return Verifier.Verify(result);
    }

    [Fact(Skip = "TODO: Reenable after proper type support"),
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Fields"),
     Trait("Feature", "Unions")]
    public Task Test6()
    {
        // from https://en.cppreference.com/w/cpp/language/union
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#include <iostream>
#include <string>
#include <vector>
 
union S
{
    std::string str;
    std::vector<int> vec;
    ~S() {} // needs to know which member is active, only possible in union-like class 
};          // the whole union occupies max(sizeof(string), sizeof(vector<int>))");
        return Verifier.Verify(result);
    }


    [Fact(Skip = "TODO: Reenable after proper type support"),
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Fields"),
     Trait("Feature", "Unions"),
     Trait("Feature", "Enums")]
    public Task Test7()
    {
        // from https://en.cppreference.com/w/cpp/language/union
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#include <iostream>
 
// S has one non-static data member (tag), three enumerator members (CHAR, INT, DOUBLE), 
// and three variant members (c, i, d)
struct S
{
    enum{CHAR, INT, DOUBLE} tag;
    union
    {
        char c;
        int i;
        double d;
    };
};");
        return Verifier.Verify(result);
    }

    [Fact(Skip = "Nested Types?!"),
     Trait("Category",        "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature",         "Structs"),
     Trait("Feature",         "Fields")]
    public Task Test8()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
struct a {
    struct x { struct a *p; /* ... */ };

    struct x *p;
};");
        return Verifier.Verify(result);
    }

    [Fact(Skip = "__declspec is windows only"),
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Functions")]
    public Task Test9()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#define GLFWAPI __declspec(dllexport)
GLFWAPI int test(int* pointer);
");
        return Verifier.Verify(result);
    }
    
    [Fact,
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Functions")]
    public Task Test10()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#define GLFWAPI __attribute__((visibility(""default"")))
GLFWAPI int test(int* pointer);
");
        return Verifier.Verify(result);
    }
    
    [Fact,
     Trait("Category", "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public Task Test11()
    {
        var result = TestHelper.GetCSharpOutputFromCpp(@"
#include <stdint.h>

typedef struct {
    int32_t*** f1;
} Test;");
        return Verifier.Verify(result);
    }
}
