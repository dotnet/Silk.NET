// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;

using Xunit;

namespace Silk.NET.SPIRV.Reflect.Tests;

public class ShaderModuleTests
{
    [Fact]
    public unsafe void InputVariables()
    {
        var reflect = Reflect.GetApi();

        var moduleBytes = File.ReadAllBytes("shader.frag.spv");

        fixed(void* ptr = moduleBytes) 
        {
            var module = new ReflectShaderModule();

            var result = reflect.CreateShaderModule((nuint)moduleBytes.Length, ptr, &module);

            if(result != Result.Success) 
            {
                throw new Exception($"Failed to create shader module res:{result}");
            }

            uint varCount = 0;
            result = reflect.EnumerateInputVariables(&module, &varCount, null);

            if(result != Result.Success) 
            {
                throw new Exception($"Failed to get count of input variables res:{result}");
            }

            var variables = stackalloc InterfaceVariable*[(int) varCount]; // don't do this in real code!
            result = reflect.EnumerateInputVariables(&module, &varCount, &variables[0]);
            
            if(result != Result.Success) 
            {
                throw new Exception($"Failed to get input variables res:{result}");
            }
            
            Assert.Equal("fragColor", SilkMarshal.PtrToString((IntPtr) variables[0]->Name));
            Assert.Equal(Format.R32G32B32Sfloat, variables[0]->Format);
        }
    }
}
