using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Applies Vulkan-specific transformations.
/// </summary>
public class TransformVulkan : IMod
{
    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var proj = ctx.SourceProject;
        if (proj == null)
        {
            return;
        }

        var compilation = await proj.GetCompilationAsync(ct);
        if (compilation == null)
        {
            return;
        }

        var rewriter = new Rewriter();
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            var doc = proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        private const string MethodClassName = "Vk";

        private const string InstanceTypeName = "InstanceHandle";
        private const string InstanceNativeTypeName = "VkInstance";
        private const string InstanceFieldName = "_currentInstance";
        private const string InstancePropertyName = "CurrentInstance";

        private const string DeviceTypeName = "DeviceHandle";
        private const string DeviceNativeTypeName = "VkDevice";
        private const string DeviceFieldName = "_currentDevice";
        private const string DevicePropertyName = "CurrentDevice";

        private const string VkCreateInstanceNativeName = "vkCreateInstance";
        private const string VkCreateDeviceNativeName = "vkCreateDevice";

        private const string VkResultName = "Result";
        private const string VkResultSuccessName = "Success";

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (node.Identifier.ValueText != MethodClassName)
            {
                return base.VisitClassDeclaration(node);
            }

            var instanceField = FieldDeclaration(
                VariableDeclaration(NullableType(IdentifierName(InstanceTypeName)))
                    .AddVariables(VariableDeclarator(InstanceFieldName))
            ).AddModifiers(Token(SyntaxKind.PrivateKeyword));


            var deviceField = FieldDeclaration(
                VariableDeclaration(NullableType(IdentifierName(DeviceTypeName)))
                    .AddVariables(VariableDeclarator(DeviceFieldName))
            ).AddModifiers(Token(SyntaxKind.PrivateKeyword));

            var instanceProperty = CreateProperty(InstanceTypeName, InstancePropertyName, InstanceFieldName);

            var deviceProperty = CreateProperty(DeviceTypeName, DevicePropertyName, DeviceFieldName);

            node = node.WithMembers([
                instanceField,
                deviceField,
                instanceProperty,
                deviceProperty,
                ..node.Members.SelectMany(RewriteMember)
            ]);

            return base.VisitClassDeclaration(node);
        }

        private IEnumerable<MemberDeclarationSyntax> RewriteMember(MemberDeclarationSyntax member)
        {
            if (member is not MethodDeclarationSyntax method)
            {
                yield return member;
                yield break;
            }

            if (!method.AttributeLists.GetNativeFunctionInfo(out _, out var entryPoint, out _) || entryPoint == null)
            {
                yield return member;
                yield break;
            }

            if (!method.Modifiers.Any(modifier => modifier.IsKind(SyntaxKind.ExternKeyword)))
            {
                yield return member;
                yield break;
            }

            if (entryPoint != VkCreateInstanceNativeName && entryPoint != VkCreateDeviceNativeName)
            {
                yield return member;
                yield break;
            }

            var methodName = method.Identifier.ValueText;
            var privateMethodName = $"{methodName}Internal";

            // Output the original method, but private
            yield return method
                .WithIdentifier(Identifier(privateMethodName))
                .WithModifiers([
                    Token(SyntaxKind.PrivateKeyword),
                    ..member.Modifiers.Where(modifier =>
                        !SyntaxFacts.IsAccessibilityModifier(modifier.Kind()))
                ]);

            var handlePropertyName = entryPoint == VkCreateInstanceNativeName ? InstancePropertyName : DevicePropertyName;
            var handleNativeTypeName = entryPoint == VkCreateInstanceNativeName ? InstanceNativeTypeName : DeviceNativeTypeName;
            var handleParameterName = method.ParameterList.Parameters
                .FirstOrDefault(parameter => parameter.AttributeLists.GetNativeElementTypeName(out _) == handleNativeTypeName)?.Identifier.ValueText
                ?? throw new InvalidOperationException($"Failed to determine the parameter that contains the created handle type: {handleNativeTypeName}");

            // Add a new public method that stores the VkInstance or VkDevice
            var resultName = "result";
            yield return method
                .WithAttributeLists([
                    ..method.AttributeLists
                        .Select(list =>
                            AttributeList([
                                ..list.Attributes.Where(attribute =>
                                    !attribute.IsAttribute("System.Runtime.InteropServices.DllImport"))
                            ]))
                        .Where(list => list.Attributes.Count != 0)
                ])
                .WithModifiers([
                    ..member.Modifiers.Where(modifier => !modifier.IsKind(SyntaxKind.ExternKeyword))
                ])
                .WithSemicolonToken(Token(SyntaxKind.None))
                .WithBody(
                    Block(
                        LocalDeclarationStatement(
                            VariableDeclaration(IdentifierName(VkResultName))
                                .AddVariables(
                                    VariableDeclarator(resultName)
                                        .WithInitializer(
                                            EqualsValueClause(
                                                InvocationExpression(IdentifierName(privateMethodName))
                                                    .WithArgumentList(ArgumentList([..method.ParameterList.Parameters.Select(parameter => Argument(IdentifierName(parameter.Identifier.ValueText)))])))))),
                        IfStatement(
                            BinaryExpression(
                                SyntaxKind.EqualsExpression,
                                IdentifierName(resultName),
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName(VkResultName),
                                    IdentifierName(VkResultSuccessName)
                                )
                            ),
                            Block(
                                ExpressionStatement(
                                    AssignmentExpression(
                                        SyntaxKind.SimpleAssignmentExpression,
                                        IdentifierName(handlePropertyName),
                                        PrefixUnaryExpression(
                                            SyntaxKind.PointerIndirectionExpression,
                                            IdentifierName(handleParameterName)))))
                        ),
                        ReturnStatement(IdentifierName(resultName))));
        }

        /// <summary>
        /// This generates the VkInstance and VkDevice properties.
        /// </summary>>
        private static PropertyDeclarationSyntax CreateProperty(string typeName, string propertyName, string fieldName)
        {
            return PropertyDeclaration(NullableType(IdentifierName(typeName)), propertyName)
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddAccessorListAccessors(
                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithExpressionBody(ArrowExpressionClause(IdentifierName(fieldName)))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                    AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                        .WithBody(
                            Block(
                                IfStatement(
                                    BinaryExpression(
                                        SyntaxKind.LogicalAndExpression,
                                        BinaryExpression(
                                            SyntaxKind.NotEqualsExpression,
                                            IdentifierName(fieldName),
                                            LiteralExpression(SyntaxKind.NullLiteralExpression)
                                        ),
                                        BinaryExpression(
                                            SyntaxKind.NotEqualsExpression,
                                            IdentifierName(fieldName),
                                            IdentifierName("value")
                                        )
                                    ),
                                    ThrowStatement(
                                        ObjectCreationExpression(
                                                IdentifierName("InvalidOperationException")
                                            )
                                            .WithArgumentList(
                                                ArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(
                                                            LiteralExpression(
                                                                SyntaxKind.StringLiteralExpression,
                                                                Literal(
                                                                    $"{propertyName} has already been set. Please create a new API instance so that the loaded function pointers can be kept separate.")
                                                            )
                                                        )
                                                    )
                                                )
                                            )
                                    )
                                ),
                                ExpressionStatement(
                                    AssignmentExpression(
                                        SyntaxKind.SimpleAssignmentExpression,
                                        IdentifierName(fieldName),
                                        IdentifierName("value")
                                    )
                                ))));
        }
    }
}