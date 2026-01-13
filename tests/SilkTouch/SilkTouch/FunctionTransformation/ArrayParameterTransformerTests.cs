// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Mods.Metadata;
using Silk.NET.SilkTouch.Mods.Transformation;

namespace Silk.NET.SilkTouch.UnitTests.FunctionTransformation;

public class ArrayParameterTransformerTests
{
    [Test]
    public async Task SingularizeAffixedName_ShouldSingularizeBaseName()
    {
        var method = (MethodDeclarationSyntax)
            SyntaxFactory.ParseMemberDeclaration(
                """
                [NameAffix("Suffix", "KhronosNonVendor", "Direct")]
                [NativeFunction("opengl", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
                public static void alDeleteAuxiliaryEffectSlotsDirect(
                    ALCcontext context,
                    [NativeTypeName("ALsizei")] int n,
                    [NativeTypeName("const ALuint *")] uint* effectslots)
                {
                }
                """
            )!;

        var transformer = new ArrayParameterTransformer();
        var context = new DummyTransformationContext()
        {
            Transformers =
            [
                new SingularizeAffixedName_ShouldSingularizeBaseName_MetadataProvider(),
            ],
        };

        var results = new List<MethodDeclarationSyntax>();
        transformer.Transform(
            method,
            context,
            result =>
            {
                results.Add(result);
            }
        );

        // "Slots" should be pluralized as "Slot"
        await Verify(string.Join("\n\n", results.Select(result => result.NormalizeWhitespace())));
    }

    private class SingularizeAffixedName_ShouldSingularizeBaseName_MetadataProvider
        : IApiMetadataProvider<SymbolConstraints>,
            IFunctionTransformer
    {
        public bool TryGetChildSymbolMetadata(
            string? jobKey,
            string nativeName,
            string childNativeName,
            [NotNullWhen(true)] out SymbolConstraints? metadata
        )
        {
            if (childNativeName == "effectslots")
            {
                metadata = MetadataUtils.CreateBasicSymbolConstraints(
                    ["n"],
                    [true, false],
                    false,
                    false,
                    0
                );
                return true;
            }

            metadata = null;
            return false;
        }

        public void Transform(
            MethodDeclarationSyntax current,
            ITransformationContext ctx,
            Action<MethodDeclarationSyntax> next
        ) => next(current);
    }

    [Test]
    public async Task SingularizeAffixedName_ShouldNotAffectAffix()
    {
        var method = (MethodDeclarationSyntax)
            SyntaxFactory.ParseMemberDeclaration(
                """
                [NameAffix("Suffix", "KhronosVendor", "OES")]
                [NativeFunction("opengl", EntryPoint = "glFeedbackBufferxOES")]
                public static void glFeedbackBufferxOES(
                    [NativeTypeName("GLsizei")] uint n,
                    [NativeTypeName("GLenum")] uint type,
                    [NativeTypeName("const GLfixed *")] int* buffer)
                {
                }
                """
            )!;

        var transformer = new ArrayParameterTransformer();
        var context = new DummyTransformationContext()
        {
            Transformers = [new SingularizeAffixedName_ShouldNotAffectAffix_MetadataProvider()],
        };

        var results = new List<MethodDeclarationSyntax>();
        transformer.Transform(
            method,
            context,
            result =>
            {
                results.Add(result);
            }
        );

        // The "OES" suffix should not be singularized as "O"
        await Verify(string.Join("\n\n", results.Select(result => result.NormalizeWhitespace())));
    }

    private class SingularizeAffixedName_ShouldNotAffectAffix_MetadataProvider
        : IApiMetadataProvider<SymbolConstraints>,
            IFunctionTransformer
    {
        public bool TryGetChildSymbolMetadata(
            string? jobKey,
            string nativeName,
            string childNativeName,
            [NotNullWhen(true)] out SymbolConstraints? metadata
        )
        {
            if (childNativeName == "buffer")
            {
                metadata = MetadataUtils.CreateBasicSymbolConstraints(
                    ["n"],
                    [true, false],
                    false,
                    false,
                    0
                );
                return true;
            }

            metadata = null;
            return false;
        }

        public void Transform(
            MethodDeclarationSyntax current,
            ITransformationContext ctx,
            Action<MethodDeclarationSyntax> next
        ) => next(current);
    }
}
