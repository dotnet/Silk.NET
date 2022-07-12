// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace Silk.NET.SilkTouch.IntegrationTests;

[UsesVerify]
public class GLFWIntegrationTests
{
    /*
     * This holds integration tests that are taken from https://www.glfw.org/docs/3.3/glfw3_8h_source.html
     * Each integration test only defines the minimum necessary things to test the definition tested (defined last).
     * This is also "tested" by our GLFW bindings, but is intended to 
     */
    
    
    [Fact,
     Trait("Category",        "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature",         "Fields"),
     Trait("Feature", "Static Methods"),
     Trait("Feature", "Classes")]
    public Task GlfwInit()
    {
        var result = TestHelper.GetCSharpOutputFromCpp
        (
            @"
/* GLFWAPI is used to declare public API functions for export
 * from the DLL / shared library / dynamic library.
 */
#if defined(_WIN32) && defined(_GLFW_BUILD_DLL)
 /* We are building GLFW as a Win32 DLL */
 #define GLFWAPI __declspec(dllexport)
#elif defined(_WIN32) && defined(GLFW_DLL)
 /* We are calling GLFW as a Win32 DLL */
 #define GLFWAPI __declspec(dllimport)
#elif defined(__GNUC__) && defined(_GLFW_BUILD_DLL)
 /* We are building GLFW as a shared / dynamic library */
 #define GLFWAPI __attribute__((visibility(""default"")))
#else
        /* We are building or calling GLFW as a static library */
#define GLFWAPI
#endif

GLFWAPI int glfwInit(void);",
            definedMacros: new string[] { "_WIN32", "GLFW_DLL" }
        );
        return Verifier.Verify(result);
    }
    
    [Fact,
     Trait("Category",        "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature",         "Fields"),
     Trait("Feature",         "Static Methods"),
     Trait("Feature",         "Classes")]
    public Task GlfwSetErrorCallback()
    {
        var result = TestHelper.GetCSharpOutputFromCpp
        (
            @"
/* GLFWAPI is used to declare public API functions for export
 * from the DLL / shared library / dynamic library.
 */
#if defined(_WIN32) && defined(_GLFW_BUILD_DLL)
 /* We are building GLFW as a Win32 DLL */
 #define GLFWAPI __declspec(dllexport)
#elif defined(_WIN32) && defined(GLFW_DLL)
 /* We are calling GLFW as a Win32 DLL */
 #define GLFWAPI __declspec(dllimport)
#elif defined(__GNUC__) && defined(_GLFW_BUILD_DLL)
 /* We are building GLFW as a shared / dynamic library */
 #define GLFWAPI __attribute__((visibility(""default"")))
#else
        /* We are building or calling GLFW as a static library */
#define GLFWAPI
#endif

typedef void (* GLFWerrorfun)(int error_code, const char* description);

GLFWAPI GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun callback);",
            definedMacros: new string[] { "_WIN32", "GLFW_DLL" }
        );
        return Verifier.Verify(result);
    }
    
    [Fact,
     Trait("Category",        "Integration"),
     Trait("Source Language", "C++"),
     Trait("Target Language", "C#"),
     Trait("Feature",         "Structs"),
     Trait("Feature",         "Fields"),
     Trait("Feature",         "Static Methods"),
     Trait("Feature",         "Classes")]
    public Task GlfwGetVideoModes()
    {
        var result = TestHelper.GetCSharpOutputFromCpp
        (
            @"
/* GLFWAPI is used to declare public API functions for export
 * from the DLL / shared library / dynamic library.
 */
#if defined(_WIN32) && defined(_GLFW_BUILD_DLL)
 /* We are building GLFW as a Win32 DLL */
 #define GLFWAPI __declspec(dllexport)
#elif defined(_WIN32) && defined(GLFW_DLL)
 /* We are calling GLFW as a Win32 DLL */
 #define GLFWAPI __declspec(dllimport)
#elif defined(__GNUC__) && defined(_GLFW_BUILD_DLL)
 /* We are building GLFW as a shared / dynamic library */
 #define GLFWAPI __attribute__((visibility(""default"")))
#else
        /* We are building or calling GLFW as a static library */
#define GLFWAPI
#endif


typedef struct GLFWvidmode
{
    int width;
    int height;
    int redBits;
    int greenBits;
    int blueBits;
    int refreshRate;
} GLFWvidmode;

typedef struct GLFWmonitor GLFWmonitor;

GLFWAPI const GLFWvidmode* glfwGetVideoModes(GLFWmonitor* monitor, int* count);",
            definedMacros: new string[] { "_WIN32", "GLFW_DLL" }
        );
        return Verifier.Verify(result);
    }
}
