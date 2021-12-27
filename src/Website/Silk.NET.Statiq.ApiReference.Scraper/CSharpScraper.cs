// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using Ultz.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Statiq.ApiReference.Scraper;

public class CSharpScraper : CSharpSyntaxWalker
{
    private static readonly Regex _advTrimRegex = new("^\\s+|\\s+$", RegexOptions.Compiled);
    record struct Context
    (
        string? Namespace = null,
        string? Type = null,
        Category? TypeCategory = null,
        FieldDeclarationSyntax? FieldMemberContext = null,
        string? Member = null,
        Category? MemberCategory = null,
        bool ParamListStarted = false
    );

    private ConcurrentDictionary<string, WipDocumentation> _namespaces = new();
    private ThreadLocal<Context> _context = new();

    public CSharpScraper()
        : base(SyntaxWalkerDepth.StructuredTrivia)
    {
    }

    public async ValueTask HandleProjectAsync(MSBuildWorkspace workspace, Project project)
    {
        var comp = await project.GetCompilationAsync();
        if (comp is null)
        {
            Log.Error("Failed to get compilation!");
            return;
        }

        foreach (var compilationSyntaxTree in comp.SyntaxTrees)
        {
            Visit(await compilationSyntaxTree.GetRootAsync());
        }
    }

    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////// //

    private string? EnterNamespace(string ns)
    {
        var old = _context.Value.Namespace;
        var @new = (old + '.' + ns).Trim('.');
        _context.Value = _context.Value with
        {
            Namespace = @new,
            Type = null,
            TypeCategory = null,
            FieldMemberContext = null,
            Member = null,
            MemberCategory = null,
            ParamListStarted = false
        };
        return old;
    }

    private void ExitNamespace(string? nsBefore) => _context.Value = _context.Value with
    {
        Namespace = nsBefore,
        Type = null,
        TypeCategory = null,
        FieldMemberContext = null,
        Member = null,
        MemberCategory = null,
        ParamListStarted = false
    };

    private (string?, Category?) EnterType(string type, Category category)
    {
        var old = _context.Value.Type;
        var oldCat = _context.Value.TypeCategory;
        var @new = (old + '.' + type).Trim('.');
        _context.Value = _context.Value with
        {
            Type = @new,
            TypeCategory = category,
            FieldMemberContext = null,
            Member = null,
            MemberCategory = null,
            ParamListStarted = false
        };
        return (old, oldCat);
    }

    private void ExitType((string?, Category?) typeBefore) => _context.Value = _context.Value with
    {
        Type = typeBefore.Item1,
        TypeCategory = typeBefore.Item2,
        FieldMemberContext = null,
        Member = null,
        MemberCategory = null,
        ParamListStarted = false
    };

    private void EnterMember(string member, Category category)
        => _context.Value = _context.Value with
        {
            Member = member,
            MemberCategory = category,
            ParamListStarted = false
        };

    private void ExitMember()
        => _context.Value = _context.Value with { Member = null, MemberCategory = null, ParamListStarted = false };

    private WipDocumentation? CurrentDocumentation
    {
        get
        {
            if (_context.Value.Namespace is null)
            {
                return null;
            }

            var current = _namespaces.GetOrAdd(_context.Value.Namespace, _ => new(Category.Namespace, new(), new()));
            if (_context.Value.Type is null || _context.Value.TypeCategory is null)
            {
                return current;
            }

            current = current.Children
                .GetOrAdd(_context.Value.Type, _ => new(_context.Value.TypeCategory.Value, new(), new()));
            if (_context.Value.Member is null || _context.Value.MemberCategory is null)
            {
                return current;
            }

            return current.Children
                .GetOrAdd(_context.Value.Member, _ => new(_context.Value.MemberCategory.Value, new(), new()));
        }
    }

    private string Preview(MemberDeclarationSyntax member) => member.NormalizeWhitespace().ToFullString();

    private string BodilessPreview(TypeDeclarationSyntax type)
        => Preview(type.WithMembers(List<MemberDeclarationSyntax>()));

    private bool ShouldVisit(MemberDeclarationSyntax member)
        => member.Modifiers.Any(x => x.IsKind(SyntaxKind.PublicKeyword)) ||
           member.Modifiers.Any(x => x.IsKind(SyntaxKind.ProtectedKeyword)) &&
           !member.Modifiers.Any(x => x.IsKind(SyntaxKind.PrivateKeyword)) &&
           !member.Modifiers.Any(x => x.IsKind(SyntaxKind.InternalKeyword));

    private bool ShouldVisit(MethodDeclarationSyntax method)
        => (!method.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)) || method.Body is null) &&
           ShouldVisit((MemberDeclarationSyntax) method);

    private void HandleElementStart(XmlNameSyntax? name)
    {
        if (name is null)
        {
            return;
        }

        var mkdwn = CurrentDocumentation?.Markdown;
        switch (name.ToString())
        {
            case "br":
            {
                mkdwn?.AppendLine("\n");
                break;
            }
            case "remarks":
            {
                mkdwn?.AppendLine("\n## Remarks");
                break;
            }
            case "param":
            {
                if (!_context.Value.ParamListStarted)
                {
                    mkdwn?.AppendLine("\n## Parameters");
                }

                mkdwn?.AppendLine();
                break;
            }
            case "returns":
            {
                mkdwn?.AppendLine("\n## Returns");
                break;
            }
        }
    }

    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////// //

    public override void VisitFileScopedNamespaceDeclaration(FileScopedNamespaceDeclarationSyntax node)
    {
        EnterNamespace(node.Name.ToString());
        base.VisitFileScopedNamespaceDeclaration(node);
    }

    public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
    {
        var before = EnterNamespace(node.Name.ToString());
        base.VisitNamespaceDeclaration(node);
        ExitNamespace(before);
    }
    
    private (string?, Category?) EnterType(TypeDeclarationSyntax node, Category category)
    {
        var before = EnterType(node.Identifier.ToString(), category);
        var markdown = CurrentDocumentation!.Markdown;
        if (markdown.Length == 0)
        {
            // new type
            markdown.AppendLine($"# {node.Identifier}");
            markdown.AppendLine("```cs");
            markdown.AppendLine(BodilessPreview(node));
            markdown.AppendLine("```");
            markdown.AppendLine();
        }
        // else just a new partial for a type we've already seen

        return before;
    }

    public override void VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }

        var before = EnterType(node, Category.Class);
        base.VisitClassDeclaration(node);
        ExitType(before);
    }

    public override void VisitStructDeclaration(StructDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }

        var before = EnterType(node, Category.Struct);
        base.VisitStructDeclaration(node);
        ExitType(before);
    }

    public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }

        var before = EnterType(node, Category.Record);
        base.VisitRecordDeclaration(node);
        ExitType(before);
    }

    public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }

        var before = EnterType(node.Identifier.ToString(), Category.Enum);
        var markdown = CurrentDocumentation!.Markdown;
        if (markdown.Length == 0)
        {
            // new enum
            markdown.AppendLine($"# {node.Identifier}");
            markdown.AppendLine("```cs");
            markdown.AppendLine(Preview(node.WithMembers(SeparatedList<EnumMemberDeclarationSyntax>())));
            markdown.AppendLine("```");
            markdown.AppendLine();
        }
        // else just a new partial for an enum we've already seen

        base.VisitEnumDeclaration(node);
        ExitType(before);
    }

    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////// //

    private void EnterMethod(BaseMethodDeclarationSyntax node, string ident, Category cat)
    {
        EnterMember(ident, cat);
        var markdown = CurrentDocumentation!.Markdown;
        if (markdown.Length == 0)
        {
            // new function
            markdown.AppendLine($"# {ident}");
        }
        else
        {
            // overload
            markdown.AppendLine();
            markdown.AppendLine("---");
            markdown.AppendLine();
        }

        markdown.AppendLine("```cs");
        markdown.AppendLine(Preview(node.WithBody(Block())));
        markdown.AppendLine("```");
        markdown.AppendLine();
    }

    public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }
        
        EnterMethod(node, node.Identifier.ToString(), Category.Method);
        base.VisitMethodDeclaration(node);
        ExitMember();
    }

    public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }
        
        EnterMethod(node, "Constructor", Category.Constructor);
        base.VisitConstructorDeclaration(node);
        ExitMember();
    }

    public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }

        EnterMember(node.Identifier.ToString(), Category.Property);
        var markdown = CurrentDocumentation!.Markdown;
        if (markdown.Length == 0)
        {
            // new function
            markdown.AppendLine($"# {node.Identifier}");
        }
        else
        {
            // overload
            markdown.AppendLine();
            markdown.AppendLine("---");
            markdown.AppendLine();
        }

        markdown.AppendLine("```cs");
        var previewNode = node;
        if (previewNode.ExpressionBody is not null)
        {
            previewNode = previewNode.WithExpressionBody(null)
                .WithAccessorList
                (
                    AccessorList
                    (
                        List
                        (
                            new[]
                            {
                                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            }
                        )
                    )
                );
        }
        else if (previewNode.AccessorList is not null)
        {
            previewNode = previewNode.WithAccessorList
            (
                previewNode.AccessorList.WithAccessors
                (
                    List
                    (
                        previewNode.AccessorList.Accessors.Select
                            (x => x.WithBody(null).WithSemicolonToken(Token(SyntaxKind.SemicolonToken)))
                    )
                )
            );
        }

        markdown.AppendLine(Preview(previewNode));
        markdown.AppendLine("```");
        markdown.AppendLine();
        base.VisitPropertyDeclaration(node);
    }

    public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
    {
        if (!ShouldVisit(node))
        {
            return;
        }

        _context.Value = _context.Value with { FieldMemberContext = node };
        base.VisitFieldDeclaration(node);
        _context.Value = _context.Value with { FieldMemberContext = null };
    }

    public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        var field = _context.Value.FieldMemberContext;
        if (field is null)
        {
            return;
        }

        base.VisitVariableDeclarator(node);
    }

    public override void VisitEventDeclaration(EventDeclarationSyntax node)
    {
        base.VisitEventDeclaration(node);
    }

    public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
    {
        base.VisitEventFieldDeclaration(node);
    }

    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////// //

    public override void VisitXmlElement(XmlElementSyntax node)
    {
        base.VisitXmlElement(node);
    }

    public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
    {
        HandleElementStart(node.Name);
        base.VisitXmlElementStartTag(node);
    }

    public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
    {
        base.VisitXmlElementEndTag(node);
    }

    public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
    {
        HandleElementStart(node.Name);
        base.VisitXmlEmptyElement(node);
    }

    public override void VisitXmlName(XmlNameSyntax node)
    {
        base.VisitXmlName(node);
    }

    public override void VisitXmlPrefix(XmlPrefixSyntax node)
    {
        base.VisitXmlPrefix(node);
    }

    public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node)
    {
        base.VisitXmlTextAttribute(node);
    }

    public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
    {
        base.VisitXmlCrefAttribute(node);
    }

    public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node)
    {
        base.VisitXmlNameAttribute(node);
    }

    public override void VisitXmlText(XmlTextSyntax node)
    {
        var text = _advTrimRegex.Replace(string.Join(string.Empty, node.TextTokens), string.Empty);
        CurrentDocumentation?.Markdown.AppendLine(text);
        base.VisitXmlText(node);
    }

    public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
    {
        base.VisitXmlCDataSection(node);
    }

    public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
    {
        base.VisitXmlProcessingInstruction(node);
    }

    public override void VisitXmlComment(XmlCommentSyntax node)
    {
        base.VisitXmlComment(node);
    }

    public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
    {
        Debug.WriteLine("DocTrivia");
        base.VisitDocumentationCommentTrivia(node);
    }
}
