// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.LocationTransformation;

public class LocationTransformationTests
{
    [Test]
    public async Task RenamesIdentifiers()
    {
        // This test declares a variety of identifiers and references to them
        // The goal is to ensure the renamer can properly rename everything by adding the -Out suffix to each name
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                public struct Data { }

                /// <summary>
                /// Holds <see cref="Data"/>.
                /// </summary>
                public struct Struct
                {
                    public Data Field;
                    public Data Property => Field;

                    public Data Method(Data a) => new Data();

                    public void Method2()
                    {
                        Data data = new Data();
                    }
                }

                [NameAffix("", "", nameof(Struct))]
                [NameAffix("", "", nameof(Struct.Method))]
                public class Class
                {
                    public Data Field;
                    public Data Property => Field;

                    public Data Method(Data a) => new Data();
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };
        var compilation = await project.GetCompilationAsync();
        Assert.NotNull(compilation);

        var dataSymbol = compilation.GetTypeByMetadataName("Data")!;
        var structSymbol = compilation.GetTypeByMetadataName("Struct")!;
        var classSymbol = compilation.GetTypeByMetadataName("Class")!;

        var structField = structSymbol.GetMembers("Field").Single();
        var structProperty = structSymbol.GetMembers("Property").Single();
        var structMethod = structSymbol.GetMembers("Method").Single();
        var structMethod2 = structSymbol.GetMembers("Method2").Single();

        var classField = classSymbol.GetMembers("Field").Single();
        var classProperty = classSymbol.GetMembers("Property").Single();
        var classMethod = classSymbol.GetMembers("Method").Single();

        await NameUtils.RenameAllAsync(
            context,
            [
                (dataSymbol, "DataOut"),
                (structSymbol, "StructOut"),
                (classSymbol, "ClassOut"),
                (structField, "FieldOut"),
                (structProperty, "PropertyOut"),
                (structMethod, "MethodOut"),
                (structMethod2, "Method2Out"),
                (classField, "FieldOut"),
                (classProperty, "PropertyOut"),
                (classMethod, "MethodOut"),
            ]
        );

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
