
using Silk.NET.Core.Native;
using Silk.NET.SPIRV.Reflect;
using Silk.NET.SPIRV.Cross;
using Result = Silk.NET.SPIRV.Reflect.Result;

unsafe
{
    var reflect = Reflect.GetApi();
    var cross = Cross.GetApi();

    uint major = 0, minor = 0, patch = 0;
    cross.GetVersion(ref major, ref minor, ref patch);

    Console.WriteLine($"Version {major}.{minor}.{patch}");

    byte[] shader = File.ReadAllBytes("../../../../ImGuiVulkan/shader.vert.spv");
    fixed (byte* ptr = shader)
    {
        ReflectShaderModule module;
        var result = reflect.CreateShaderModule2(0, (nuint) shader.Length, ptr, &module);
        if (result != Result.Success)
            throw new Exception($"failed to create shader module {result.ToString()}");
        
        Console.WriteLine($"Parsed module, source language: {module.SourceLanguage.ToString()}");
        
        reflect.DestroyShaderModule(&module);
    }

    fixed (byte* ptr = shader)
    {
        Context* context = null;
        var result = cross.ContextCreate(&context);
        if (result != Silk.NET.SPIRV.Cross.Result.Success)
            throw new Exception($"failed to create context {result.ToString()}");

        ParsedIr* parsedIr = null;
        result = cross.ContextParseSpirv(context, (uint*) ptr, (nuint)(shader.LongLength / 4), &parsedIr);
        if(result != Silk.NET.SPIRV.Cross.Result.Success)
            throw new Exception($"failed to parse spirv {result.ToString()}");
        
        Console.WriteLine($"Parsed IR");

        Compiler* compiler = null;
        result = cross.ContextCreateCompiler(context, Backend.Glsl, parsedIr, CaptureMode.Copy, &compiler);
        if(result != Silk.NET.SPIRV.Cross.Result.Success)
            throw new Exception($"failed to create compiler {result.ToString()}");

        byte* source = null;
        result = cross.CompilerCompile(compiler, &source);
        if(result != Silk.NET.SPIRV.Cross.Result.Success)
            throw new Exception($"failed to compile {result.ToString()}");

        string? str = SilkMarshal.PtrToString((nint)source, NativeStringEncoding.UTF8);
        Console.WriteLine($"Compiled int {str}");
        
        cross.ContextDestroy(context);
    }
}
