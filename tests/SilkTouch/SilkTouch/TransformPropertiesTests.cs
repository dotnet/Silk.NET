// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class TransformPropertiesTests
{
    static TransformPropertiesTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task Transforms_Utf8String_StaticConstProperties()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                public struct Test
                {
                    public static ReadOnlySpan<byte> Text => "Hello world!"u8;
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformProperties = new TransformProperties(
            new DummyOptions<TransformProperties.Configuration>(
                new TransformProperties.Configuration() { BoolTypes = { { "TestBool32", null } } }
            )
        );

        await transformProperties.ExecuteAsync(context);

        // Test.Text should be transformed to use the Utf8String type
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task Transforms_MaybeBool_FieldsAndProperties()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                public struct Transform
                {
                    [NativeTypeName("TestBool32")]
                    public uint OptionField;

                    [NativeTypeName("TestBool32")]
                    public uint OptionProperty => OptionField;

                    [NativeTypeName("TestBool32")]
                    public uint OptionAutoProperty { get; set; }
                }

                public struct NoTransform
                {
                    [NativeTypeName("TestBool")]
                    public uint OptionField;

                    [NativeTypeName("TestBool")]
                    public uint OptionProperty => OptionField;

                    [NativeTypeName("TestBool")]
                    public uint OptionAutoProperty { get; set; }

                    [NativeTypeName("TestBool32 : 1")]
                    public uint OptionAutoProperty { get; set; }
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformProperties = new TransformProperties(
            new DummyOptions<TransformProperties.Configuration>(
                new TransformProperties.Configuration() { BoolTypes = { { "TestBool32", null } } }
            )
        );

        await transformProperties.ExecuteAsync(context);

        // Only members with exactly [NativeTypeName("TestBool32")] should be transformed
        //
        // Note: [NativeTypeName("TestBool32 : 1")] can be found in bitfield structs
        // This is currently not handled since this is an unlikely case
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
