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
                Files.Add(fName, new CompilationContext(fName, comp, TypeDefinitionContainers));
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

    private class CompilationContext
    {
        public CompilationContext(string file, CompilationUnitSyntax node, Dictionary<string, List<TypeContextContainer>> TypeDefinitionContainers)
        {
            List<string> usings = node.Usings.Select(u => u.Name!.ToString()).ToList();
            foreach (var member in node.Members)
            {
                if (member is BaseNamespaceDeclarationSyntax ns)
                {
                    var nsContext = new NamespaceContext(string.Empty, ns, TypeDefinitionContainers, usings, file);
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
        public NamespaceContext(string namesp, BaseNamespaceDeclarationSyntax node, Dictionary<string, List<TypeContextContainer>> TypeDefinitionContainers, List<string> usings, string file = "")
        {
            string[] names = node.Name.ToString().Split('.');

            namesp += $"{(namesp.Length > 0 ? "." : "")}{node.Name}";
            if (names.Length != 1)
            {
                NamespaceContext child = new NamespaceContext(namesp, node.WithName(IdentifierName(names[names.Length - 1])), TypeDefinitionContainers, usings, file);
                namesp = namesp.Remove(namesp.Length - (names.Last().Length + 1));
                node = node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));

                for (int i = names.Length - 2; i >= 1; i--)
                {
                    NamespaceContext current = new NamespaceContext(namesp, node.WithName(IdentifierName(names[i])), TypeDefinitionContainers, usings, file);
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
                    var nsContext = new NamespaceContext(namesp, ns, TypeDefinitionContainers, usings, file);
                    Namespaces.Add(nsContext.Node.Name.ToString(), nsContext);
                }
                else if (member is EnumDeclarationSyntax e)
                {
                    var en = new TypeContextContainer(namesp, new EnumContext(file, e));
                    if (e.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)))
                    {
                        if (!TypeDefinitionContainers.TryGetValue(e.Identifier.Text, out var list))
                        {
                            list = [];
                            TypeDefinitionContainers.Add(e.Identifier.Text, list);
                        }
                        if (list.Count == 1 && list[0].Type is UnknownTypeContext)
                        {
                            list[0].Type = en.Type;
                            list[0].Namespace = en.Namespace;
                            en = list[0];
                        }
                        else
                        {
                            list.Add(en);
                        }
                    }
                    Types.Add(e.Identifier.Text, en);
                }
                else if (member is TypeDeclarationSyntax t)
                {
                    var ty = new TypeContextContainer(namesp, new TypeContext(namesp, file, t, TypeDefinitionContainers, usings));
                    if (t.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)))
                    {
                        if (!TypeDefinitionContainers.TryGetValue(t.Identifier.Text, out var list))
                        {
                            list = [];
                            TypeDefinitionContainers.Add(t.Identifier.Text, list);
                        }
                        if (list.Count == 1 && list[0].Type is UnknownTypeContext)
                        {
                            list[0].Type = ty.Type;
                            list[0].Namespace = ty.Namespace;
                            ty = list[0];
                        }
                        else
                        {
                            list.Add(ty);
                        }
                    }
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
        public TypeContext(string ns, string file, TypeDeclarationSyntax node, Dictionary<string, List<TypeContextContainer>> TypeDefinitionContainers, List<string> usings)
        {
            File = file;

            foreach (var member in node.Members)
            {
                if (member is EnumDeclarationSyntax e)
                {
                    var en = new TypeContextContainer(ns, new EnumContext(file, e));
                    if (e.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)))
                    {
                        if (!TypeDefinitionContainers.TryGetValue(e.Identifier.Text, out var list))
                        {
                            list = [];
                            TypeDefinitionContainers.Add(e.Identifier.Text, list);
                        }
                        if (list.Count == 1 && list[0].Type is UnknownTypeContext)
                        {
                            list[0].Type = en.Type;
                            list[0].Namespace = en.Namespace;
                            en = list[0];
                        }
                        else
                        {
                            list.Add(en);
                        }
                    }
                    SubTypes.Add(e.Identifier.Text, en);
                }
                else if (member is TypeDeclarationSyntax t)
                {
                    var ty = new TypeContextContainer(ns, new TypeContext(ns, file, t, TypeDefinitionContainers, usings));
                    if (t.Modifiers.Any(token => token.IsKind(SyntaxKind.PublicKeyword)))
                    {
                        if (!TypeDefinitionContainers.TryGetValue(t.Identifier.Text, out var list))
                        {
                            list = [];
                            TypeDefinitionContainers.Add(t.Identifier.Text, list);
                        }
                        if (list.Count == 1 && list[0].Type is UnknownTypeContext)
                        {
                            list[0].Type = ty.Type;
                            list[0].Namespace = ty.Namespace;
                            ty = list[0];
                        }
                        else
                        {
                            list.Add(ty);
                        }
                    }
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
                    methods.Add(new(m));
                }
                else if (member is FieldDeclarationSyntax f)
                {
                    TypeSyntax syn = f.Declaration.Type;
                    int pDepth = 0;
                    while (syn is PointerTypeSyntax pointer)
                    {
                        pDepth++;
                        syn = pointer.ElementType;
                    }

                    TypeContextContainer type;
                    if (TypeDefinitionContainers.TryGetValue(syn.ToString(), out var list))
                    {
                        type = list.First();

                        foreach(var decl in list)
                        {
                            if (NamespaceMatch(ns, decl.Namespace) || usings.Contains(decl.Namespace))
                            {
                                type = decl;
                                break;
                            }
                        }
                    }
                    else
                    {
                        type = new(string.Empty, new UnknownTypeContext(syn));
                        TypeDefinitionContainers.Add(syn.ToString(), new() { type });
                    }
                    
                    foreach (var dec in f.Declaration.Variables)
                    {
                        Fields.Add(dec.Identifier.Text, new(type, pDepth, f.WithDeclaration(f.Declaration.WithVariables(SeparatedList(new[] { dec })))));
                    }
                }
                else if (member is PropertyDeclarationSyntax p)
                {
                    TypeSyntax syn = p.Type;
                    int pDepth = 0;
                    while (syn is PointerTypeSyntax pointer)
                    {
                        pDepth++;
                        syn = pointer.ElementType;
                    }

                    TypeContextContainer type;
                    if (TypeDefinitionContainers.TryGetValue(syn.ToString(), out var list))
                    {
                        type = list.First();

                        foreach (var decl in list)
                        {
                            if (NamespaceMatch(ns, decl.Namespace) || usings.Contains(decl.Namespace))
                            {
                                type = decl;
                                break;
                            }
                        }
                    }
                    else
                    {
                        type = new(string.Empty, new UnknownTypeContext(syn));
                        TypeDefinitionContainers.Add(syn.ToString(), new() { type });
                    }

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
        public TypeContextContainer(string ns, IBaseTypeContext ty)
        {
            Namespace = ns;
            Type = ty;
        }

        public string Namespace;
        public IBaseTypeContext Type;
    }

    private class MethodContext : LeafNodeContext<MethodDeclarationSyntax>
    {
        public MethodContext(MethodDeclarationSyntax node) : base(node) { }
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
