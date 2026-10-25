// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Bakery;

namespace Silk.NET.SilkTouch.UnitTests;

public class BakeSourceSetsTests
{
    static BakeSourceSetsTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task MergesEquivalent()
    {
        var source = """
            public class Class
            {
                public int A, B, C;
                public int Data;
                public static int StaticData;

                public Class()
                {
                    A = 1;
                    B = 2;
                    C = 3;
                }

                ~Class()
                {
                    Method();
                }

                public int this[int value] => value;

                public int Number => 123;
                public static int StaticNumber => 123;

                public int Value { get; set; } = 234;
                public static int StaticValue { get; set; } = 234;

                public event Action? Occurred;
                public static event Action? StaticOccurred;

                [Obsolete]
                public void Method() { }

                public static void StaticMethod() { }

                public struct Nested { }
            }

            public struct Struct
            {
                public int A, B, C;
                public int Data;
                public static int StaticData;

                public Struct()
                {
                    A = 1;
                    B = 2;
                    C = 3;
                }

                public int this[int value] => value;

                public int Number => 123;
                public static int StaticNumber => 123;

                public int Value { get; set; } = 234;
                public static int StaticValue { get; set; } = 234;

                public event Action? Occurred;
                public static event Action? StaticOccurred;

                [Obsolete]
                public void Method() { }

                public static void StaticMethod() { }

                public static explicit operator int(Struct value) => value.Value;

                public static int operator +(Struct a, Struct b) => a.Value + b.Value;

                public struct Nested { }
            }

            public enum Enum
            {
                None = 0,
                First,
                Second,
                Third,
                One = First,
                Two = Second,
                Three = Third,
            }

            public delegate int Delegate(int value);

            public record Record { }

            public record class RecordClass { }

            public record struct RecordStruct { }

            public interface IInterface { }
            """;

        var project = TestUtils
            .CreateTestProject()
            .AddDocument("Api.gen.cs", source, filePath: "a/Api.gen.cs")
            .Project.AddDocument("Api.gen.cs", source, filePath: "b/Api.gen.cs")
            .Project;

        var context = new DummyModContext() { SourceProject = project };
        var documentFactory = new DocumentFactory();

        var bakeSourceSets = new BakeSourceSets(
            documentFactory,
            NullLogger<BakeSourceSets>.Instance,
            new BakeSourceSets.Configuration()
            {
                SourceSets = new() { ["a"] = "merged", ["b"] = "merged" },
            },
            [new DefaultBakeStrategy(NullLogger<DefaultBakeStrategy>.Instance)]
        );

        await bakeSourceSets.ExecuteAsync(context);

        // The output should be the same as the inputs, but split into one document per type under the `merged` folder
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task ThrowForStructMismatch()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Api.gen.cs",
                """
                public struct Struct
                {
                    public int A, B;
                }
                """,
                filePath: "a/Api.gen.cs"
            )
            .Project.AddDocument(
                "Api.gen.cs",
                """
                public struct Struct
                {
                    public int A, B, C;
                }
                """,
                filePath: "b/Api.gen.cs"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };
        var documentFactory = new DocumentFactory();

        var bakeSourceSets = new BakeSourceSets(
            documentFactory,
            NullLogger<BakeSourceSets>.Instance,
            new BakeSourceSets.Configuration()
            {
                SourceSets = new() { ["a"] = "merged", ["b"] = "merged" },
            },
            [new DefaultBakeStrategy(NullLogger<DefaultBakeStrategy>.Instance)]
        );

        Assert.ThrowsAsync<InvalidOperationException>(async () =>
        {
            await bakeSourceSets.ExecuteAsync(context);
        });
    }

    [Test]
    public async Task ThrowForStructMismatch2()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Api.gen.cs",
                """
                public struct Struct
                {
                    public int A, B, C;
                }
                """,
                filePath: "b/Api.gen.cs"
            )
            .Project.AddDocument(
                "Api.gen.cs",
                """
                public struct Struct
                {
                    public int A, B;
                }
                """,
                filePath: "a/Api.gen.cs"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };
        var documentFactory = new DocumentFactory();

        var bakeSourceSets = new BakeSourceSets(
            documentFactory,
            NullLogger<BakeSourceSets>.Instance,
            new BakeSourceSets.Configuration()
            {
                SourceSets = new() { ["a"] = "merged", ["b"] = "merged" },
            },
            [new DefaultBakeStrategy(NullLogger<DefaultBakeStrategy>.Instance)]
        );

        Assert.ThrowsAsync<InvalidOperationException>(async () =>
        {
            await bakeSourceSets.ExecuteAsync(context);
        });
    }
}
