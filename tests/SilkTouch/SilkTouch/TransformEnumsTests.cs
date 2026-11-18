// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class TransformEnumsTests
{
    static TransformEnumsTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task Sort()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public enum Access
                {
                    Write = 2,
                    None = 0,
                    Read = 1,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration() { SortMembers = true },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task Rewrite()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public enum Access
                {
                    None = 0,
                    Read = 1,
                    Write = 1 + 1,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration() { RewriteMemberValues = true },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task Rewrite_Flags()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                [Flags]
                public enum Access
                {
                    None = 0,
                    Read = 1,
                    Write = 1 + 1,
                    All = Read | Write,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration() { RewriteMemberValues = true },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task FlagsOverrides_True()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public enum Access
                {
                    None = 0,
                    Read = 1,
                    Write = 2,
                    All = Read | Write,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration()
            {
                FlagsOverrides = new Dictionary<string, bool>() { { "Access", true } },
            },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task FlagsOverrides_True_NativeName()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                [NativeName("NativeAccess")]
                public enum Access
                {
                    None = 0,
                    Read = 1,
                    Write = 2,
                    All = Read | Write,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration()
            {
                FlagsOverrides = new Dictionary<string, bool>() { { "NativeAccess", true } },
            },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task FlagsOverrides_False()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public enum Access
                {
                    None = 0,
                    Read = 1,
                    Write = 2,
                    All = Read | Write,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration()
            {
                FlagsOverrides = new Dictionary<string, bool>() { { "Access", false } },
            },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task FlagsOverrides_False_AlreadyAttributed()
    {
        var inputDocName = "Access.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                [Flags]
                public enum Access
                {
                    None = 0,
                    Read = 1,
                    Write = 2,
                    All = Read | Write,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformEnums = new TransformEnums(
            new TransformEnums.Configuration()
            {
                FlagsOverrides = new Dictionary<string, bool>() { { "Access", false } },
            },
            NullLogger<TransformEnums>.Instance
        );

        await transformEnums.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
