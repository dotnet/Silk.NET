using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Reflection;
using Xunit.Abstractions;

namespace Silk.NET.Assimp.Tests;

public unsafe class CustomFileIOTests
{
    private readonly ITestOutputHelper _out;
    
    public CustomFileIOTests(ITestOutputHelper @out)
    {
        _out = @out;
    }
    
    [Fact]
    [SuppressMessage("ReSharper", "AccessToDisposedClosure")]
    public void ImportTest()
    {
        using var modelFile = Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(CustomFileIOTests), "Model.zip");
        Assert.NotEqual(modelFile, null);
        using var modelArch = new ZipArchive(modelFile!, ZipArchiveMode.Read);
        using var assimp = Assimp.GetApi();
        using var io = new CustomFileIO
        (
            (file, access, mode) =>
            {
                _out.WriteLine($"Opening file: {file} - {access}/{mode}");
                Assert.Equal((int) (access & FileAccess.Write), 0);
                Assert.Equal(mode, FileMode.Open);
                using var compressed = modelArch.GetEntry(file.ToString())?.Open();
                if (compressed is null)
                {
                    return null;
                }
                
                var ms = new MemoryStream();
                compressed.CopyTo(ms);
                ms.Seek(0, SeekOrigin.Begin);
                return ms;
            }
        );
        var scene = assimp.ImportFileEx("M1 Garand.obj", (uint) PostProcessSteps.Triangulate, ref io.FileIO);
        if (scene == null || scene->MFlags == Assimp.SceneFlagsIncomplete || scene->MRootNode == null)
        {
            _out.WriteLine($"Assimp returned error: {assimp.GetErrorStringS()}");
        }
        
        Assert.NotEqual((nint)scene, 0);
        Assert.NotEqual(scene->MFlags, (uint)Assimp.SceneFlagsIncomplete);
        Assert.NotEqual((nint)scene->MRootNode, 0);
    }
}
