// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// 
/// </summary>
public class SyntaxContext
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="syntax"></param>
    public SyntaxContext(GeneratedSyntax syntax)
    {
        foreach ((var fName, var node) in syntax.Files)
        {
            if (node is CompilationUnitSyntax comp)
            {
                Files.Add(fName, new CompilationContext(fName, comp, this));
            }
            else
            {
                throw new Exception("CompilationUnitSyntax missing");
            }
        }
    }

    Dictionary<string, CompilationContext> Files = [];

    Dictionary<string, NamespaceContext> Namespaces = [];

    Dictionary<string, List<TypeContextContainer>> TypeDefinitionContainers = [];

    private TypeContextContainer GetTypeContainer(TypeSyntax syn, string ns, List<string> usings, TypeContext? currentType, out int pDepth, string parentName = "")
    {
        pDepth = 0;
        while (syn is PointerTypeSyntax pointer)
        {
            pDepth++;
            syn = pointer.ElementType;
        }

        string name = $"{(parentName.Length > 0 ? $"{parentName}." : "")}{currentType?.Node.Identifier.Text ?? string.Empty}";

        TypeContextContainer type;
        if (TypeDefinitionContainers.TryGetValue(syn.ToString(), out var list))
        {
            type = list.First();

            foreach (var decl in list)
            {
                if (NamespaceMatch(ns, decl.Namespace) || usings.Contains(decl.Namespace) && (decl.IsPublic))
                {
                    type = decl;
                    break;
                }
            }
        }
        else if (GetChildContainer(syn, currentType, out list, name) && list is not null)
        {
            type = list.First();

            foreach (var decl in list)
            {
                if (ns == decl.Namespace)
                {
                    type = decl;
                    break;
                }
            }
        }
        else
        {
            type = new(string.Empty, new UnknownTypeContext(syn), true);
            TypeDefinitionContainers.Add(syn.ToString(), new() { type });
        }

        return type;
    }

    private void AddTypeContextContainer(ref TypeContextContainer container, string name)
    {
        if (!TypeDefinitionContainers.TryGetValue(name, out var list))
        {
            list = [];
            TypeDefinitionContainers.Add(name, list);
        }
        if (list.Count == 1 && list[0].Type is UnknownTypeContext)
        {
            list[0].Type = container.Type;
            list[0].Namespace = container.Namespace;
            container = list[0];
        }
        else
        {
            list.Add(container);
        }
    }

    private bool GetChildContainer(TypeSyntax syn, TypeContext? currentType, out List<TypeContextContainer>? list, string parentName, bool topLevel = true)
    {
        list = null;
        if (currentType is null)
        {
            return false;
        }

        foreach(var child in currentType.SubTypes)
        {
            string name = $"{(parentName.Length > 0 ? $"{parentName}." : "")}{child.Key}";
            if (TypeDefinitionContainers.TryGetValue(name, out list))
            {
                return true;
            }

            if (GetChildContainer(syn, child.Value.Type as TypeContext, out list, name, false))
            {
                return true;
            }
        }
        return false;
    }

    private class CompilationContext
    {
        public CompilationContext(string file, CompilationUnitSyntax node, SyntaxContext context)
        {
            List<string> usings = node.Usings.Select(u => u.Name!.ToString()).ToList();
            foreach (var member in node.Members)
            {
                if (member is BaseNamespaceDeclarationSyntax ns)
                {
                    var nsContext = new NamespaceContext(string.Empty, ns, context, usings, file);
                    Namespaces.Add(nsContext.Node.Name.ToString(), nsContext);
                }
                else
                {
                    throw new Exception($"CompilationUnit for {file} contains a member of type ({member.GetType()}) which isn't supported");
                }
            }
            Node = node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));
        }

        public CompilationUnitSyntax Node;
        public Dictionary<string, NamespaceContext> Namespaces = [];

        public CompilationUnitSyntax ToCompletedNode()
        {
            return Node.WithMembers(List(Namespaces.Select(n => (MemberDeclarationSyntax)n.Value.ToCompletedNode())));
        }
    }

    private class NamespaceContext
    {
        public NamespaceContext(string namesp, BaseNamespaceDeclarationSyntax node, SyntaxContext context, List<string> usings, string file = "")
        {
            string[] names = node.Name.ToString().Split('.');

            namesp += $"{(namesp.Length > 0 ? "." : "")}{node.Name}";
            if (names.Length != 1)
            {
                NamespaceContext child = new NamespaceContext(namesp, node.WithName(IdentifierName(names[names.Length - 1])), context, usings, file);
                namesp = namesp.Remove(namesp.Length - (names.Last().Length + 1));
                node = node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));

                for (int i = names.Length - 2; i >= 1; i--)
                {
                    NamespaceContext current = new NamespaceContext(namesp, node.WithName(IdentifierName(names[i])), context, usings, file);
                    namesp = namesp.Remove(namesp.Length - (names[i].Length + 1));
                    current.Namespaces.Add(names[i + 1], child);
                    child = current;
                }

                Namespaces.Add(names[1], child);
                Node = node.WithName(IdentifierName(names[0]));
                return;
            }

            foreach(var member in node.Members)
            {
                if (member is BaseNamespaceDeclarationSyntax ns)
                {
                    var nsContext = new NamespaceContext(namesp, ns, context, usings, file);
                    Namespaces.Add(nsContext.Node.Name.ToString(), nsContext);
                }
                else if (member is EnumDeclarationSyntax e)
                {
                    var en = new TypeContextContainer(namesp, new EnumContext(file, e), e.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)));
                    context.AddTypeContextContainer(ref en, e.Identifier.Text);
                    Types.Add(e.Identifier.Text, en);
                }
                else if (member is TypeDeclarationSyntax t)
                {
                    var ty = new TypeContextContainer(namesp, new TypeContext(namesp, file, t, context, usings), t.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)));
                    context.AddTypeContextContainer(ref ty, t.Identifier.Text);
                    Types.Add(t.Identifier.Text, ty);
                }
                else
                {
                    throw new Exception($"Namespace {node.Name}{(file != "" ? " in file " + file : "")} contains a member of type ({member.GetType()}) which isn't supported");
                }
            }

            Node = node.WithName(IdentifierName(names[0]));
        }

        public BaseNamespaceDeclarationSyntax Node;
        public Dictionary<string, NamespaceContext> Namespaces = [];
        public Dictionary<string, TypeContextContainer> Types = [];

        public BaseNamespaceDeclarationSyntax ToCompletedNode()
        {
            List<MemberDeclarationSyntax> members = [];
            members.AddRange(Namespaces.Select(n => n.Value.ToCompletedNode()));
            members.AddRange(Types.Select(t => t.Value.Type.ToCompletedNode()!));
            return Node.WithMembers(List(members));
        }
    }

    private class TypeContext : IBaseTypeContext
    {
        public TypeContext(string ns, string file, TypeDeclarationSyntax node, SyntaxContext context, List<string> usings, string parentName = "")
        {
            File = file;

            foreach (var member in node.Members)
            {
                if (member is EnumDeclarationSyntax e)
                {
                    string name = $"{(parentName.Length > 0 ? $"{parentName}." : "")}{e.Identifier.Text}";
                    var en = new TypeContextContainer(ns, new EnumContext(file, e), e.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)));
                    context.AddTypeContextContainer(ref en, name);
                    SubTypes.Add(e.Identifier.Text, en);
                }
                else if (member is TypeDeclarationSyntax t)
                {
                    string name = $"{(parentName.Length > 0 ? $"{parentName}." : "")}{t.Identifier.Text}";
                    var ty = new TypeContextContainer(ns, new TypeContext(ns, file, t, context, usings, name), t.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)));
                    context.AddTypeContextContainer(ref ty, name);
                    SubTypes.Add(t.Identifier.Text, ty);
                }
                else if (member is MethodDeclarationSyntax m)
                {
                    string name = m.Identifier.Text;
                    if (!Methods.TryGetValue(name, out var methods))
                    {
                        methods = new();
                        Methods.Add(name, methods);
                    }
                    methods.Add(new(ns, m, context, usings, parentName, this));
                }
                else if (member is FieldDeclarationSyntax f)
                {
                    TypeContextContainer type = context.GetTypeContainer(f.Declaration.Type, ns, usings, this, out int pDepth, parentName);

                    foreach (var dec in f.Declaration.Variables)
                    {
                        Fields.Add(dec.Identifier.Text, new(type, pDepth, f.WithDeclaration(f.Declaration.WithVariables(SeparatedList(new[] { dec })))));
                    }
                }
                else if (member is PropertyDeclarationSyntax p)
                {
                    TypeContextContainer type = context.GetTypeContainer(p.Type, ns, usings, this, out int pDepth, parentName);

                    Properties.Add(p.Identifier.Text, new(type, pDepth, p));
                }
            }

            Node = node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));
        }

        public string File;
        public TypeDeclarationSyntax Node;
        public Dictionary<string, TypeContextContainer> SubTypes = [];
        public Dictionary<string, List<MethodContext>> Methods = [];
        public Dictionary<string, FieldContext> Fields = [];
        public Dictionary<string, PropertyContext> Properties = [];

        public TypeSyntax Syntax => IdentifierName(Node.Identifier.Text);

        public MemberDeclarationSyntax? ToCompletedNode()
        {
            List<MemberDeclarationSyntax> members = [];
            members.AddRange(SubTypes.Select(t => t.Value.Type.ToCompletedNode()!));
            foreach (string method in Methods.Keys)
            {
                members.AddRange(Methods[method].Select(m => m.Node));
            }
            members.AddRange(Fields.Select(f => f.Value.ToCompletedNode()));
            members.AddRange(Properties.Select(p => p.Value.ToCompletedNode()));
            return Node.WithMembers(List(members));
        }
    }

    private class EnumContext : LeafNodeContext<EnumDeclarationSyntax>, IBaseTypeContext
    {
        public EnumContext(string file, EnumDeclarationSyntax node) : base(node) { File = file; }

        public string File;
        public TypeSyntax Syntax => IdentifierName(Node.Identifier.Text);

        public MemberDeclarationSyntax? ToCompletedNode()
        {
            return Node;
        }
    }

    private interface IBaseTypeContext
    {
        TypeSyntax Syntax { get; }

        MemberDeclarationSyntax? ToCompletedNode();
    }

    private class UnknownTypeContext : IBaseTypeContext
    {
        public UnknownTypeContext(TypeSyntax type) { Type = type; }
        TypeSyntax Type;

        public TypeSyntax Syntax => Type;

        public MemberDeclarationSyntax? ToCompletedNode()
        {
            return null;
        }
    }

    private class TypeContextContainer
    {
        public TypeContextContainer(string ns, IBaseTypeContext ty, bool isPublic)
        {
            Namespace = ns;
            Type = ty;
            IsPublic = isPublic;
        }

        public string Namespace;
        public bool IsPublic;
        public IBaseTypeContext Type;
    }

    private class MethodContext : LeafNodeContext<MethodDeclarationSyntax>
    {
        public MethodContext(string ns, MethodDeclarationSyntax node, SyntaxContext context, List<string> usings, string parentName, TypeContext type) : base(node)
        {
            foreach (var para in node.ParameterList.Parameters)
            {
                TypeContextContainer pType = context.GetTypeContainer(para.Type!, ns, usings, type, out int pDepth, parentName);

                Parameters.Add(para.Identifier.Text, pType);
            }
        }

        public Dictionary<string, TypeContextContainer> Parameters = [];
    }

    private class FieldContext : VariableNodes<FieldDeclarationSyntax>
    {
        public FieldContext(TypeContextContainer container, int pointerDepth, FieldDeclarationSyntax node) : base(container, node) { PointerDepth = pointerDepth; }

        public int PointerDepth;

        public FieldDeclarationSyntax ToCompletedNode()
        {
            var type = Container.Type.Syntax;

            int pDepth = PointerDepth;
            while (pDepth > 0)
            {
                type = PointerType(type);
                pDepth--;
            }

            return Node.WithDeclaration(Node.Declaration.WithType(type));
        }
    }

    private class PropertyContext : VariableNodes<PropertyDeclarationSyntax>
    {
        public PropertyContext(TypeContextContainer container, int pointerDepth, PropertyDeclarationSyntax node) : base(container, node) { PointerDepth = pointerDepth; }

        public int PointerDepth;

        public PropertyDeclarationSyntax ToCompletedNode()
        {
            var type = Container.Type.Syntax;

            int pDepth = PointerDepth;
            while (pDepth > 0)
            {
                type = PointerType(type);
                pDepth--;
            }

            return Node.WithType(type);
        }
    }

    private class VariableNodes<TNodeType> : LeafNodeContext<TNodeType>
    {
        public VariableNodes(TypeContextContainer container, TNodeType node) : base(node) { Container = container; }

        public TypeContextContainer Container;
    }

    private class LeafNodeContext<TNodeType>(TNodeType node)
    {
        public TNodeType Node = node;
    }

    /// <summary>
    /// checks if ns1 is a child namespace of ns2
    /// </summary>
    /// <param name="ns1"></param>
    /// <param name="ns2"></param>
    /// <returns></returns>
    private static bool NamespaceMatch(string ns1, string ns2)
    {
        for (int i = 0; i < ns2.Length; i++)
        {
            if (ns2[i] != ns1[i])
                return false;
        }
        return true;
    }
}
