// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A representation of the full SyntaxTree used to better provide bindings
/// </summary>
public class SyntaxContext
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="diagnostics"></param>
    /// <param name="files"></param>
    public SyntaxContext(Dictionary<string, SyntaxNode> files, IReadOnlyList<ClangSharp.Diagnostic> diagnostics)
    {
        Diagnostics = diagnostics;
        //Build initial per file tree
        foreach ((var fName, var node) in files)
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

        MergeCommonTypes();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="syntax"></param>
    public SyntaxContext(GeneratedSyntax syntax)
    {
        Diagnostics = syntax.Diagnostics;
        //Build initial per file tree
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

        MergeCommonTypes();
    }

    /// <summary>
    /// Syntax Context data for each file
    /// </summary>
    internal Dictionary<string, CompilationContext> Files = [];

    Dictionary<string, List<TypeContextContainer>> TypeDefinitionContainers = [];

    IReadOnlyList<ClangSharp.Diagnostic> Diagnostics;

    /// <summary>
    /// Creates a new <see cref="GeneratedSyntax"/> based on the current state of this Context
    /// </summary>
    /// <returns></returns>
    public GeneratedSyntax ToGeneratedSyntax()
    {
        return new(Files.Select(file => new KeyValuePair<string, SyntaxNode>(file.Key, file.Value.ToCompletedNode())).ToDictionary(), Diagnostics);
    }

    /// <summary>
    /// Visits each node in this context with the provided visitor
    /// </summary>
    /// <param name="visitor"></param>
    public void Visit(ContextCSharpSyntaxVisitor visitor)
    {
        visitor.Context = this;

        foreach ((var fName, var context) in Files)
        {
            context.Visit(visitor);
        }
    }

    /// <summary>
    /// Apply Syntax Rewriter on all objects in this Context
    /// </summary>
    /// <param name="rewriter"></param>
    public void Rewrite(ContextCSharpSyntaxRewriter rewriter)
    {
        rewriter.Context = this;

        List<string> Removals = [];

        foreach ((var fName, var context) in Files)
        {
            if (!context.Rewrite(rewriter, fName))
            {
                Removals.Add(fName);
            }
        }

        foreach (string rem in Removals)
        {
            Files.Remove(rem);
        }

        MergeCommonTypes();
    }

    /// <summary>
    /// Renames any file matching the old path regex based on the new path regex
    /// </summary>
    /// <param name="oldPathRegex"></param>
    /// <param name="newPathRegex"></param>
    public void RenameFile(string oldPathRegex, string newPathRegex)
    {
        Files = Files.ToDictionary(kvp => Regex.Replace(kvp.Key, oldPathRegex, newPathRegex), kvp => kvp.Value);
    }

    /// <summary>
    /// Removes any file that matches the pathRegex
    /// </summary>
    /// <param name="pathRegex"></param>
    public void RemoveFile(string pathRegex)
    {
        List<string> Removals = Files.Keys.Where(key => Regex.IsMatch(key, pathRegex)).ToList();

        foreach (string rem in Removals)
        {
            Files.Remove(rem);
        }
    }

    /// <summary>
    /// Adds a new file into the SyntaxContext
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="compUnit"></param>
    public void AddFile(string filePath, CompilationUnitSyntax compUnit)
    {
        if (Files.ContainsKey(filePath))
        {
            Files[filePath] = new CompilationContext(filePath, compUnit, this);
        }
        else
        {
            Files.Add(filePath, new CompilationContext(filePath, compUnit, this));
        }

        MergeCommonTypes();
    }

    private void MergeCommonTypes()
    {
        //Merge common types into single types
        foreach (var typeDef in TypeDefinitionContainers)
        {
            if (typeDef.Value.Count <= 1)
            {
                continue;
            }

            for (int i = 0; i < typeDef.Value.Count; i++)
            {
                if (typeDef.Value[i].IsNull)
                {
                    typeDef.Value.RemoveAt(i);
                    i--;
                    continue;
                }
                List<TypeContextContainer> typesToMerge = [];
                TypeContextContainer main = typeDef.Value[i];
                string mainFile = typeDef.Value.Where(t => t.Type?.FileName.Length > 0).First().Type!.FileName;
                List<string> files = [mainFile];

                //find all types that are the same as our current main type
                //this includes same generic arguments with the same constraints
                //We also keep track of all file paths along the way
                for (int j = 1; j < typeDef.Value.Count; j++)
                {
                    if (main.Namespace != typeDef.Value[j].Namespace ||
                        !TypeVarCheck(main, typeDef.Value[j]))
                    {
                        continue;
                    }

                    string file = typeDef.Value[j].Type?.FileName ?? string.Empty;
                    if (file.Length > 0 && !files.Contains(file))
                    {
                        files.Add(file);
                    }

                    typesToMerge.Add(typeDef.Value[j]);
                    typeDef.Value.RemoveAt(j);
                    j--;
                }

                if (typesToMerge.Count == 0)
                {
                    continue;
                }

                //Merge all types into main
                MergeTypeContainers(main, typesToMerge);

                //get new path which is placed at the common root of all the paths
                mainFile = Path.Combine(FindCommonRoot(files), Path.GetFileName(mainFile)).Replace(".Manual.cs", ".gen.cs");

                int fileIndex = 1;

                //check that our new path doesn't already exist (unless it is our first file anyways)
                while (Files.ContainsKey(mainFile) && !(files[0] == mainFile))
                {
                    mainFile = mainFile.Replace($"{(fileIndex > 1 ? fileIndex.ToString() : "")}.gen.cs", $"{fileIndex + 1}.gen.cs");
                    fileIndex++;
                }

                //if our file isn't the same as our old one add the new path and remove the original
                if (files[0] != mainFile)
                {
                    Files.Add(mainFile, Files[files[0]]);
                    Files.Remove(files[0]);
                }

                //remove the first file path to avoid confusion
                files.RemoveAt(0);

                NamespaceContext ns = Files[mainFile].GetNamespace(main.Namespace);

                //make sure our type actually is in our namespace (can happen if first type in declarations was an UnknownTypeContext which shouldn't happen)
                if (!ns.Types.TryGetValue(typeDef.Key, out var list))
                {
                    list = [main];
                    ns.Types.Add(typeDef.Key, list);
                }
                else if (!list.Contains(main))
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (main.Namespace != list[j].Namespace ||
                        !TypeVarCheck(main, list[j]))
                        {
                            continue;
                        }
                        list.RemoveAt(j);
                        j--;
                    }

                    list.Add(main);
                }

                //finally check all files have types still and either delete them or clean them of bad types
                foreach (var file in files)
                {
                    if (Files.TryGetValue(file, out var comp) && comp.DefinedTypeCount == 0)
                    {
                        Files.Remove(file);
                    }
                    else if (comp is not null)
                    {
                        comp.Clean(this);
                    }
                }
            }
        }
    }

    private TypeContainer? CreateTypeContextFromNode(BaseTypeDeclarationSyntax type, string ns, string file, List<string> usings, IBaseTypeContext? parent = null)
    {
        if (type is EnumDeclarationSyntax e)
        {
            return new(Enum:new EnumContext(file, e, parent));

        }
        else if (type is TypeDeclarationSyntax t)
        {
            return new(new TypeContext(ns, file, t, this, usings, parent));
        }
        return null;
    }

    private string FindCommonRoot(List<string> paths)
    {
        if (paths == null || paths.Count == 0)
            return string.Empty;

        if (paths.Count == 1)
            return paths[0];

        string[][] separatedPaths = paths
            .Select(path => path.Split(Path.DirectorySeparatorChar))
            .ToArray();

        string commonPath = string.Join(Path.DirectorySeparatorChar.ToString(),
            separatedPaths.First().TakeWhile((part, index) =>
                separatedPaths.All(path => path.Length > index && path[index] == part)));

        return commonPath;
    }

    private bool TypeVarCheck(TypeContextContainer t1,  TypeContextContainer t2)
    {
        if (t1.Type is EnumContext || t2.Type is EnumContext ||
            t1.Type is not TypeContext ty1 || t2.Type is not TypeContext ty2)
        {
            return true;
        }

        if (ty1.Node.TypeParameterList is not null && ty2.Node.TypeParameterList is not null &&
            ty1.Node.TypeParameterList.Parameters.Count != ty2.Node.TypeParameterList.Parameters.Count ||
            (ty1.Node.ParameterList is null ^ ty2.Node.ParameterList is null))
        {
            return false;
        }

        return true;
    }

    private bool TypeVarCheck(TypeContextContainer type, TypeSyntax syntax)
    {
        if (syntax is not GenericNameSyntax generic)
        {
            if (type.Type is EnumContext || (type.Type is TypeContext ty &&
                (ty.Node.TypeParameterList is null || ty.Node.TypeParameterList.Parameters.Count == 0)) ||
                (type.Type is UnknownTypeContext && type.Type.Syntax is not GenericNameSyntax))
            {
                return true;
            }
            return false;
        }
        if (type.Type is EnumContext)
        {
            return false;
        }

        if (type.Type is TypeContext ty1)
        {
            if ((ty1.Node.TypeParameterList is not null &&
                ty1.Node.TypeParameterList.Parameters.Count != generic.TypeArgumentList.Arguments.Count) ||
                ty1.Node.ParameterList is null)
            {
                return false;
            }

            return true;
        }
        else if (type.Type is UnknownTypeContext && type.Type.Syntax is GenericNameSyntax generic2)
        {
            return generic.TypeArgumentList.Arguments.Count == generic2.TypeArgumentList.Arguments.Count;
        }

        return false;

    }

    private void MergeTypeContainers(TypeContextContainer main, List<TypeContextContainer> typesToMerge)
    {
        while (main.Type is UnknownTypeContext u)
        {
            main.Type = typesToMerge[0].Type;
            main.Visibility = typesToMerge[0].Visibility;
            typesToMerge.RemoveAt(0);
        }

        SyntaxKind visibility = main.IsPublic ? SyntaxKind.PublicKeyword : SyntaxKind.PrivateKeyword;
        bool isStatic = true;

        if (main.Type is EnumContext e)
        {
            if (!e.Node.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword)))
            {
                isStatic = false;
            }

            bool emptyBaseType = e.Node.BaseList is null || e.Node.BaseList.Types.Count == 0;

            foreach (var merge in typesToMerge)
            {
                if (visibility != SyntaxKind.PublicKeyword)
                {
                    if (merge.IsPublic)
                    {
                        visibility = SyntaxKind.PublicKeyword;
                    }
                    else if (visibility != SyntaxKind.ProtectedKeyword && merge.Visibility == SyntaxKind.ProtectedKeyword)
                    {
                        visibility = SyntaxKind.ProtectedKeyword;
                    }
                }

                if (merge.Type is EnumContext en)
                {
                    if (isStatic && !en.Node.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword)))
                    {
                        isStatic = false;
                    }

                    foreach (var member in en.Members)
                    {
                        if (e.Members.ContainsKey(member.Key))
                        {
                            e.Members[member.Key] = member.Value;
                        }
                        e.Members.Add(member.Key, member.Value);
                    }

                    e.Node = e.Node.AddModifiers(en.Node.Modifiers.Where(mod => !mod.IsKind(SyntaxKind.PrivateKeyword) &&
                                                                                !mod.IsKind(SyntaxKind.ProtectedKeyword) &&
                                                                                !mod.IsKind(SyntaxKind.PublicKeyword) &&
                                                                                !e.Node.Modifiers.Any(eMod => mod.IsKind(eMod.Kind()))).ToArray())
                                    .AddAttributeLists(en.Node.AttributeLists.Select(al =>
                                                                AttributeList(SeparatedList(al.Attributes.Where(at => !e.Node.AttributeLists
                                                                    .Any(eAl => eAl.Attributes
                                                                        .Any(eAt => at.ToString() != eAt.ToString())))))).ToArray());

                    if (emptyBaseType)
                    {
                        e.Node = e.Node.WithBaseList(en.Node.BaseList);
                        emptyBaseType = false;
                    }
                }
                else if(merge.Type is not UnknownTypeContext)
                {
                    throw new Exception($"{main.Namespace}.{e.Node.Identifier.Text} is defined multiple times as both an enum and another type");
                }
                merge.Type = null;
            }
        }
        else if (main.Type is TypeContext t)
        {
            if (!t.Node.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword)))
            {
                isStatic = false;
            }

            bool hasBaseClass = !IsInterface(t.BaseTypes.Values.First());

            foreach (var merge in typesToMerge)
            {
                if (visibility != SyntaxKind.PublicKeyword)
                {
                    if (merge.IsPublic)
                    {
                        visibility = SyntaxKind.PublicKeyword;
                    }
                    else if (visibility != SyntaxKind.ProtectedKeyword && merge.Visibility == SyntaxKind.ProtectedKeyword)
                    {
                        visibility = SyntaxKind.ProtectedKeyword;
                    }
                }

                if (merge.Type is TypeContext ty)
                {
                    if (isStatic && !ty.Node.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword)))
                    {
                        isStatic = false;
                    }

                    foreach (var member in ty.Methods)
                    {
                        if (!t.Methods.TryGetValue(member.Key, out var list))
                        {
                            t.Methods.Add(member.Key, member.Value);
                            continue;
                        }

                        foreach (var method in member.Value)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                var mem = list[i];
                                if (list.Any(mem => method == mem))
                                {
                                    list[i] = mem;
                                    continue;
                                }
                            }
                            

                            list.Add(method);
                        }
                    }

                    bool first = true;
                    foreach (var bType in ty.BaseTypes)
                    {
                        bool isInterface = IsInterface(bType.Value);
                        if (t.BaseTypes.ContainsKey(bType.Key) && ((first && !hasBaseClass) || isInterface))
                        {
                            first = false;
                            continue;
                        }

                        first = false;
                        if (isInterface)
                        {
                            t.BaseTypes.Add(bType.Key, bType.Value);
                            continue;
                        }

                        t.BaseTypes = new Dictionary<string, TypeContextContainer> { [bType.Key] = bType.Value }.Concat(t.BaseTypes).ToDictionary();
                    }

                    t.Node = t.Node.WithBaseList(BaseList(SeparatedList(t.BaseTypes.Select(bType => (BaseTypeSyntax)SimpleBaseType(bType.Value.Type!.Syntax)))));

                    foreach(var member in ty.Fields)
                    {
                        if (t.Fields.ContainsKey(member.Key))
                        {
                            t.Fields[member.Key] = member.Value;
                        }
                        t.Fields.Add(member.Key, member.Value);
                    }

                    foreach (var member in ty.Properties)
                    {
                        if (t.Properties.ContainsKey(member.Key))
                        {
                            t.Properties[member.Key] = member.Value;
                        }
                        t.Properties.Add(member.Key, member.Value);
                    }

                    foreach (var member in ty.SubTypes)
                    {
                        if (!t.SubTypes.TryGetValue(member.Key, out var list))
                        {
                            t.SubTypes.Add(member.Key, member.Value);
                            continue;
                        }

                        for (int i = 0; i < list.Count; i++)
                        {
                            List<TypeContextContainer> typesToMerge2 = [];
                            for (int j = 1; j < member.Value.Count; j++)
                            {
                                if (list[i].Namespace != member.Value[j].Namespace ||
                                    !TypeVarCheck(list[i], member.Value[j]))
                                {
                                    continue;
                                }
                                typesToMerge2.Add(member.Value[j]);
                                member.Value.RemoveAt(j);
                                j--;
                            }

                            if (typesToMerge2.Count == 0)
                            {
                                continue;
                            }

                            MergeTypeContainers(list[i], typesToMerge2);
                        }
                    }


                    t.Node = t.Node.AddModifiers(ty.Node.Modifiers.Where(mod => !mod.IsKind(SyntaxKind.PrivateKeyword) &&
                                                                                !mod.IsKind(SyntaxKind.ProtectedKeyword) &&
                                                                                !mod.IsKind(SyntaxKind.PublicKeyword) &&
                                                                                !t.Node.Modifiers.Any(tMod => mod.IsKind(tMod.Kind()))).ToArray())
                                    .AddAttributeLists(ty.Node.AttributeLists.Select(al =>
                                                                AttributeList(SeparatedList(al.Attributes.Where(at => !t.Node.AttributeLists
                                                                    .Any(tAl => tAl.Attributes
                                                                        .Any(tAt => at.ToString() != tAt.ToString())))))).ToArray());
                    
                }
                else if (merge.Type is not UnknownTypeContext)
                {
                    throw new Exception($"{main.Namespace}.{t.Node.Identifier.Text} is defined multiple times as both an type and an enum");
                }
                merge.Type = null;
            }
        }
        
    }

    private bool IsInterface(TypeContextContainer container)
    {
        if (container.Type is not TypeContext t)
        {
            return false;
        }

        return t.Node.IsKind(SyntaxKind.InterfaceDeclaration);
    }

    private TypeContextContainer GetTypeContainer(TypeSyntax syn, string ns, List<string> usings, TypeContext? currentType, out int pDepth, string parentName = "")
    {
        pDepth = 0;
        while (syn is PointerTypeSyntax pointer)
        {
            pDepth++;
            syn = pointer.ElementType;
        }

        string name = $"{(parentName.Length > 0 ? $"{parentName}." : "")}{currentType?.Node.Identifier.Text ?? string.Empty}";

        TypeContextContainer? type = null;
        List<TypeContextContainer>? list;
        if (TypeDefinitionContainers.TryGetValue(syn.ToString(), out list))
        {

            foreach (var decl in list)
            {
                if ((NamespaceMatch(ns, decl.Namespace) || (usings.Contains(decl.Namespace) && decl.IsPublic)) && TypeVarCheck(decl, syn))
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
                if (ns == decl.Namespace && TypeVarCheck(decl, syn))
                {
                    type = decl;
                    break;
                }
            }
        }

        if (type is null)
        {
            type = new(string.Empty, new UnknownTypeContext(syn), SyntaxKind.PublicKeyword);
            if (!TypeDefinitionContainers.TryGetValue(syn.ToString(), out list))
            {
                list = [];
                TypeDefinitionContainers.Add(syn.ToString(), list);
            }
            list.Add(type);
        }

        return type;
    }

    private void AddTypeContextContainer(TypeContextContainer container)
    {
        if (!TypeDefinitionContainers.TryGetValue(container.Type!.Name, out var list))
        {
            list = [];
            TypeDefinitionContainers.Add(container.Type!.Name, list);
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Type is UnknownTypeContext unknown &&
                ((unknown.Syntax is not GenericNameSyntax && container.Type!.GenericParameterCount == 0) ||
                (unknown.Syntax is GenericNameSyntax generic && generic.TypeArgumentList.Arguments.Count == container.Type!.GenericParameterCount)))
            {
                list[i].Type = container.Type;
                list[i].Visibility = container.Visibility;
                list[i].Namespace = container.Namespace;
                container = list[i];
                return;
            }
        }

        list.Add(container);
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

            foreach (var ch in child.Value)
            {
                if (GetChildContainer(syn, ch.Type as TypeContext, out list, name, false))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void RenameType(TypeContextContainer container, string oldName)
    {
        if (TypeDefinitionContainers.TryGetValue(oldName, out var list))
        {
            list.RemoveAt(list.IndexOf(container));

            if (list.Count == 0)
            {
                TypeDefinitionContainers.Remove(oldName);
            }
        }

        AddTypeContextContainer(container);
    }

    internal class CompilationContext
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

        public NamespaceContext GetNamespace(string ns)
        {
            int firstIndex = ns.IndexOf('.');
            if (firstIndex == -1)
            {
                firstIndex = ns.Length - 1;
            }

            string name = ns.Substring(0, firstIndex);
            if (!Namespaces.TryGetValue(name, out NamespaceContext? nameSpace))
            {
                nameSpace = new NamespaceContext(NamespaceDeclaration(IdentifierName(name)));
                Namespaces.Add(name, nameSpace);
            }
            return nameSpace.GetNamespace(ns.Substring(firstIndex + 1));
        }

        public int DefinedTypeCount => Namespaces.Select(n => n.Value.DefinedTypeCount).Aggregate((a, b) => a + b);

        public void Clean(SyntaxContext context)
        {
            List<string> usings = Node.Usings.Select(u => u.Name!.ToString()).ToList();
            List<string> removals = [];

            foreach (var ns in Namespaces)
            {
                if (ns.Value.DefinedTypeCount == 0)
                {
                    removals.Add(ns.Key);
                }
                else
                {
                    ns.Value.Clean("", context, usings);
                }
            }

            foreach (var rem in removals)
            {
                Namespaces.Remove(rem);
            }
        }

        public void Visit(ContextCSharpSyntaxVisitor visitor)
        {
            List<string> usings = Node.Usings.Select(u => u.Name!.ToString()).ToList();
            visitor.Usings = usings;
            visitor.Visit(Node);

            foreach (var nameSp in Namespaces)
            {
                nameSp.Value.Visit(visitor, usings);
            }
        }

        public bool Rewrite(ContextCSharpSyntaxRewriter rewriter, string file)
        {
            List<string> usings = Node.Usings.Select(u => u.Name!.ToString()).ToList();
            rewriter.Usings = usings;
            var node = rewriter.Visit(Node) as CompilationUnitSyntax;

            if (node is null)
            {
                return false;
            }

            usings = Node.Usings.Select(u => u.Name!.ToString()).ToList();
            foreach (var member in node.Members)
            {
                if (member is BaseNamespaceDeclarationSyntax ns)
                {
                    var nsContext = new NamespaceContext(string.Empty, ns, rewriter.Context!, rewriter.Usings, file);
                    Namespaces.Add(nsContext.Node.Name.ToString(), nsContext);
                }
                else
                {
                    throw new Exception($"CompilationUnit for {file} contains a member of type ({member.GetType()}) which isn't supported");
                }
            }
            Node = node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));

            List<string> removals = [];
            foreach (var nameSp in Namespaces)
            {
                var output = nameSp.Value.Rewrite(rewriter, "", file);
                if (output.Item1 is null)
                {
                    removals.Add(nameSp.Key);
                }

                if (output.Item2 is not null)
                {
                    throw new Exception("Type Declarations not allowed in the global namespace");
                }
            }

            foreach (string rem in removals)
            {
                Namespaces.Remove(rem);
            }

            Namespaces = Namespaces.ToDictionary(kvp => kvp.Value.Node.Name.ToString(), kvp => kvp.Value);

            return Namespaces.Count > 0;
        }
    }

    internal class NamespaceContext
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
                else if (member is BaseTypeDeclarationSyntax bT)
                {
                    var ty = new TypeContextContainer(namesp, context.CreateTypeContextFromNode(bT, namesp, file, usings), bT.Modifiers
                            .Where(token => token.IsKind(SyntaxKind.PublicKeyword) || token.IsKind(SyntaxKind.ProtectedKeyword) || token.IsKind(SyntaxKind.PrivateKeyword))
                            .Select(token => token.Kind())
                            .FirstOrDefault(SyntaxKind.PrivateKeyword));

                    context.AddTypeContextContainer(ty);

                    if (!Types.TryGetValue(bT.Identifier.Text, out var list))
                    {
                        list = [];
                        Types.Add(bT.Identifier.Text, list);
                    }
                    list.Add(ty);
                }
                else
                {
                    throw new Exception($"Namespace {node.Name}{(file != "" ? " in file " + file : "")} contains a member of type ({member.GetType()}) which isn't supported");
                }
            }

            Node = node.WithName(IdentifierName(names[0])).WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));
        }

        public NamespaceContext(BaseNamespaceDeclarationSyntax node)
        {
            Node = node;
        }

        public BaseNamespaceDeclarationSyntax Node;
        public Dictionary<string, NamespaceContext> Namespaces = [];
        public Dictionary<string, List<TypeContextContainer>> Types = [];

        public BaseNamespaceDeclarationSyntax ToCompletedNode()
        {
            List<MemberDeclarationSyntax> members = [];
            members.AddRange(Namespaces.Select(n => n.Value.ToCompletedNode()));
            foreach (var types in Types)
            {
                members.AddRange(types.Value.Where(t => t.Type is not null).Select(t => t.Type!.ToCompletedNode()!));
            }
            return Node.WithMembers(List(members));
        }

        public NamespaceContext GetNamespace(string ns)
        {
            if (ns.Length == 0)
            {
                return this;
            }

            int firstIndex = ns.IndexOf('.');
            if (firstIndex == -1)
            {
                firstIndex = ns.Length - 1;
            }

            string name = ns.Substring(0, firstIndex);
            if (!Namespaces.TryGetValue(name, out NamespaceContext? nameSpace))
            {
                nameSpace = new NamespaceContext(NamespaceDeclaration(IdentifierName(name)));
                Namespaces.Add(name, nameSpace);
            }
            return nameSpace.GetNamespace(ns.Substring(firstIndex + 1));
        }

        public void Visit(ContextCSharpSyntaxVisitor visitor, List<string> usings, string ns = "")
        {
            ns = $"{(ns.Length > 0 ? $"{ns}." : "")}{Node.Name}";
            visitor.CurrentNamespace = ns;
            visitor.Visit(Node);


            foreach (var name in Namespaces)
            {
                name.Value.Visit(visitor, usings, ns);
                visitor.CurrentNamespace = ns;
            }

            visitor.CurrentNamespace = ns;
            foreach (var types in Types)
            {
                foreach (var type in types.Value)
                {
                    type.Type?.Visit(visitor);
                }
            }
        }

        public (BaseNamespaceDeclarationSyntax?, TypeContextContainer?) Rewrite(ContextCSharpSyntaxRewriter rewriter, string ns, string file)
        {
            var node = rewriter.Visit(Node);

            (BaseNamespaceDeclarationSyntax?, TypeContextContainer?) ret;

            string names = $"{(ns.Length > 0 ? $"{ns}." : "")}{Node.Name}";

            if (node is BaseNamespaceDeclarationSyntax nameSp)
            {
                Node = nameSp;
                ret = (Node, null);

                names = $"{(ns.Length > 0 ? $"{ns}." : "")}{Node.Name}";
                foreach (var member in Node.Members)
                {
                    if (member is BaseNamespaceDeclarationSyntax subns)
                    {
                        var nsContext = new NamespaceContext(names, subns, rewriter.Context!, rewriter.Usings, file);
                        Namespaces.Add(nsContext.Node.Name.ToString(), nsContext);
                    }
                    else if (member is BaseTypeDeclarationSyntax bT)
                    {
                        var ty = new TypeContextContainer(names, rewriter.Context!.CreateTypeContextFromNode(bT, names, file, rewriter.Usings), bT.Modifiers
                                .Where(token => token.IsKind(SyntaxKind.PublicKeyword) || token.IsKind(SyntaxKind.ProtectedKeyword) || token.IsKind(SyntaxKind.PrivateKeyword))
                                .Select(token => token.Kind())
                                .FirstOrDefault(SyntaxKind.PrivateKeyword));

                        rewriter.Context.AddTypeContextContainer(ty);

                        if (!Types.TryGetValue(bT.Identifier.Text, out var list))
                        {
                            list = [];
                            Types.Add(bT.Identifier.Text, list);
                        }
                        list.Add(ty);
                    }
                    else
                    {
                        throw new Exception($"Namespace {Node.Name}{(file != "" ? " in file " + file : "")} contains a member of type ({member.GetType()}) which isn't supported");
                    }
                }

            }
            else if (node is TypeDeclarationSyntax type)
            {
                names = ns;
                var cont = rewriter.Context!.CreateTypeContextFromNode(type, ns, file, rewriter.Usings, null);

                var ty = new TypeContextContainer(ns, cont, type.Modifiers
                            .Where(token => token.IsKind(SyntaxKind.PublicKeyword) || token.IsKind(SyntaxKind.ProtectedKeyword) || token.IsKind(SyntaxKind.PrivateKeyword))
                            .Select(token => token.Kind())
                            .FirstOrDefault(SyntaxKind.PrivateKeyword));


                rewriter.Context!.AddTypeContextContainer(ty);

                Types = Types.ToDictionary(kvp => $"{ty.Name}." + kvp.Key, kvp => {
                    foreach (var val in kvp.Value)
                    {
                        val.SetParent(cont!.Value.Type, rewriter.Context);
                    }
                    return kvp.Value;
                });

                ret = (null, ty);

                if (cont?.Type is TypeContext tyCont)
                {
                    foreach (var subTypes in Types)
                    {
                        if (tyCont!.SubTypes.TryGetValue(subTypes.Key, out var list))
                        {
                            foreach (var sType in subTypes.Value)
                            {
                                if (!list.Any(lType => lType.Type?.GenericParameterCount == sType.Type?.GenericParameterCount))
                                {
                                    list.Add(sType);
                                }
                            }
                        }
                        else
                        {
                            tyCont!.SubTypes.Add(subTypes.Key, subTypes.Value);
                        }
                    }
                    Types = tyCont!.SubTypes;
                }
                else
                {
                    foreach (var subTypes in Types)
                    {
                        foreach (var sType in subTypes.Value)
                        {
                            sType.Delete();
                        }
                    }

                    return ret;
                }
            }
            else
            {
                return (null, null);
            }

            List<string> removals = [];
            foreach (var name in Namespaces)
            {
                var output = name.Value.Rewrite(rewriter, names, file);
                if (output.Item1 is null)
                {
                    removals.Add(name.Key);
                }

                if (output.Item2 is not null)
                {
                    
                    if (!Types.TryGetValue(output.Item2.Type!.Name, out var list))
                    {
                        list = [];
                        Types.Add(output.Item2.Type!.Name, list);
                    }

                    list.Add(output.Item2);
                }
            }

            foreach (var rem in removals)
            {
                Namespaces.Remove(rem);
            }

            Namespaces = Namespaces.ToDictionary(kvp => kvp.Value.Node.Name.ToString(), kvp => kvp.Value);

            removals.Clear();
            Dictionary<string, List<TypeContextContainer>> newTypes = [];
            foreach (var types in Types)
            {
                for (var i = 0; i < types.Value.Count; i++)
                {
                    var type = types.Value[i];
                    if (type.Type is null)
                    {
                        types.Value.RemoveAt(i);
                        i--;
                        continue;
                    }
                    type.ConvertContainer(type.Type.Rewrite(rewriter, names, file));

                    string name = type.Type!.Name;
                    if (name != types.Key)
                    {
                        if (!Types.TryGetValue(name, out var list) && !newTypes.TryGetValue(name, out list))
                        {
                            list = [];
                            newTypes.Add(name, list);
                        }
                        list.Add(type);

                        rewriter.Context!.RenameType(type, types.Key);
                    }
                }

                if (types.Value.Count == 0)
                {
                    removals.Add(types.Key);
                }
            }

            foreach (var rem in removals)
            {
                Types.Remove(rem);
            }

            foreach (var kvp in newTypes)
            {
                Types.Add(kvp.Key, kvp.Value);
            }

            return Namespaces.Count > 0 || Types.Count > 0 ? ret : (null, null);
        }

        public void Clean(string ns, SyntaxContext context, List<string> usings)
        {
            ns = $"{(ns.Length > 0 ? $"{ns}." : "")}{Node.Name}";
            List<string> removals = [];

            foreach (var nameSp in Namespaces)
            {
                if (nameSp.Value.DefinedTypeCount == 0)
                {
                    removals.Add(nameSp.Key);
                }
                else
                {
                    nameSp.Value.Clean(ns, context, usings);
                }                
            }

            foreach (var rem in removals)
            {
                Namespaces.Remove(rem);
            }

            removals.Clear();
            foreach (var types in Types)
            {
                for (int i = 0; i < types.Value.Count; i++)
                {
                    if (types.Value[i].IsNull)
                    {
                        types.Value.RemoveAt(i);
                        i--;
                    }
                    else if (types.Value[i].Type is TypeContext ty)
                    {
                        ty.Clean(ns, context, usings);
                    }
                }

                if (types.Value.Count == 0)
                {
                    removals.Add(types.Key);
                }
            }

            foreach (var rem in removals)
            {
                Types.Remove(rem);
            }
        }

        public int DefinedTypeCount => Types.Select(t => t.Value.Where(ty => ty.Type is not null).Select(ty => ty.Type is TypeContext type ? type.DefinedTypeCount : 1).Aggregate((a, b) => a + b)).Aggregate((a, b) => a + b) + Namespaces.Select(n => n.Value.DefinedTypeCount).Aggregate((a, b) => a + b);
    }

    private class TypeContext : IBaseTypeContext
    {
        public TypeContext(string ns, string file, TypeDeclarationSyntax node, SyntaxContext context, List<string> usings, IBaseTypeContext? parent = null)
        {
            ParentType = parent;
            File = file;
            Node = node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>()));

            string parentName = parent is null ? string.Empty : parent.Name;

            foreach (var member in node.Members)
            {
                if (member is BaseTypeDeclarationSyntax bT)
                {
                    var ty = new TypeContextContainer(ns, context.CreateTypeContextFromNode(bT, ns, file, usings, this)!, bT.Modifiers
                            .Where(token => token.IsKind(SyntaxKind.PublicKeyword) || token.IsKind(SyntaxKind.ProtectedKeyword) || token.IsKind(SyntaxKind.PrivateKeyword))
                            .Select(token => token.Kind())
                            .FirstOrDefault(SyntaxKind.PrivateKeyword));

                    context.AddTypeContextContainer(ty);

                    if (!SubTypes.TryGetValue(bT.Identifier.Text, out var list))
                    {
                        list = [];
                        SubTypes.Add(bT.Identifier.Text, list);
                    }
                    list.Add(ty);
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
                else if (member is BaseFieldDeclarationSyntax f)
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

            if (node.BaseList is not null)
            {
                foreach (var baseType in node.BaseList.Types)
                {
                    BaseTypes.Add(baseType.Type.ToString(), context.GetTypeContainer(baseType.Type, ns, usings, this, out int _));
                }
            }
        }


        public string File;
        public TypeDeclarationSyntax Node;
        public Dictionary<string, TypeContextContainer> BaseTypes = [];
        public Dictionary<string, List<TypeContextContainer>> SubTypes = [];
        public Dictionary<string, List<MethodContext>> Methods = [];
        public Dictionary<string, FieldContext> Fields = [];
        public Dictionary<string, PropertyContext> Properties = [];
        public IBaseTypeContext? ParentType;

        BaseTypeDeclarationSyntax? IBaseTypeContext.Node => Node;

        IEnumerable<(string, BaseTypeSyntax, IBaseTypeContext)> IBaseTypeContext.BaseTypes => BaseTypes.Where(bT => bT.Value.Type is not null).Select(bT => (bT.Key, (BaseTypeSyntax)SimpleBaseType(bT.Value.Type!.Syntax), bT.Value.Type!));

        IEnumerable<(string, IEnumerable<IBaseTypeContext.SubType>)> IBaseTypeContext.SubTypes => SubTypes.Select(types => (types.Key, types.Value.Select(type => new IBaseTypeContext.SubType(type.Type?.Node, type.Type))));

        IEnumerable<(string, IBaseTypeContext.Field)> IBaseTypeContext.Fields => Fields.Select(field => (field.Key, new IBaseTypeContext.Field(field.Value.Node, field.Value.Container.ToTypeContainer(), field.Value.PointerDepth)));

        IEnumerable<(string, IBaseTypeContext.Property)> IBaseTypeContext.Properties => Properties.Select(property => (property.Key, new IBaseTypeContext.Property(property.Value.Node, property.Value.Container.ToTypeContainer(), property.Value.PointerDepth)));

        IEnumerable<(string, IEnumerable<IBaseTypeContext.Method>)> IBaseTypeContext.Methods => Methods.Select(methods => (methods.Key,
            methods.Value.Select(method => new IBaseTypeContext.Method(method.Node, method.ReturnType.Item1?.ToTypeContainer(), method.ReturnType.Item2,
                method.Parameters.Select(par => (par.Key, new IBaseTypeContext.MethodParameter(par.Value.Node, par.Value.Type.ToTypeContainer(), par.Value.PointerDepth)))))));

        public string Name => $"{(Parent is null ? string.Empty : $"{Parent.Name}.")}{Node.Identifier.Text}";

        public IBaseTypeContext? Parent => ParentType;

        public TypeSyntax Syntax => IdentifierName(Node.Identifier.Text);

        public string FileName => File;

        public MemberDeclarationSyntax? ToCompletedNode()
        {
            List<MemberDeclarationSyntax> members = [];
            foreach (string type in SubTypes.Keys)
            {
                members.AddRange(SubTypes[type].Where(t => t.Type is not null).Select(t => t.Type!.ToCompletedNode()!));
            }
            foreach (string method in Methods.Keys)
            {
                members.AddRange(Methods[method].Select(m => m.Node));
            }
            members.AddRange(Fields.Select(f => f.Value.ToCompletedNode()));
            members.AddRange(Properties.Select(p => p.Value.ToCompletedNode()));
            return Node.WithMembers(List(members))
                .WithBaseList(
                    BaseList(
                        SeparatedList(BaseTypes.Select(bType => (BaseTypeSyntax)SimpleBaseType(bType.Value.Type!.Syntax)))));
        }

        public int DefinedTypeCount => SubTypes.Select(t => t.Value.Where(ty => ty.Type is not null).Select(ty => ty.Type is TypeContext type ? type.DefinedTypeCount : 1).Aggregate((a, b) => a + b)).Aggregate((a, b) => a + b) + 1;

        public int GenericParameterCount => Node.TypeParameterList is null ? 0 : Node.TypeParameterList.Parameters.Count;

        public void Clean(string ns, SyntaxContext context, List<string> usings)
        {
            List<string> removals = [];
            foreach (var types in SubTypes)
            {
                for (int i = 0; i < types.Value.Count; i++)
                {
                    if (types.Value[i].IsNull)
                    {
                        types.Value.RemoveAt(i);
                        i--;
                    }
                    else if (types.Value[i].Type is TypeContext ty)
                    {
                        ty.Clean(ns, context, usings);
                    }
                    else if (types.Value[i].Delegate is DelegateContext del)
                    {
                        del.RefreshTypeLinks(ns, context, usings, this);
                    }
                }

                if (types.Value.Count == 0)
                {
                    removals.Add(types.Key);
                }
            }

            foreach (var field in Fields)
            {
                field.Value.RefreshTypeLinks(ns, context, usings, this);
            }

            foreach (var prop in Properties)
            {
                prop.Value.RefreshTypeLinks(ns, context, usings, this);
            }

            foreach (var methods in Methods)
            {
                foreach (var method in methods.Value)
                {
                    method.RefreshTypeLinks(ns, context, usings, this);
                }
            }

            foreach (var rem in removals)
            {
                SubTypes.Remove(rem);
            }
        }

        public bool TryGetSubType(string typeName, out IBaseTypeContext.SubType subType, int genericParameterCount = 0)
        {
            if (!SubTypes.TryGetValue(typeName, out var value))
            {
                subType = new();
                return false;
            }

            foreach (var container in value)
            {
                if (container.Type is not null && container.Type.GenericParameterCount == genericParameterCount)
                {
                    subType = new(container.Type.Node, container.Type);
                    return true;
                }
            }

            subType = new();
            return false;
        }

        public bool TryGetField(string fieldName, out IBaseTypeContext.Field field)
        {
            if (!Fields.TryGetValue(fieldName, out var context))
            {
                field = new();
                return false;
            }

            field = new(context.Node, context.Container.ToTypeContainer(), context.PointerDepth);
            return true;
        }

        public bool TryGetProperty(string propertyName, out IBaseTypeContext.Property property)
        {
            if (!Properties.TryGetValue(propertyName, out var context))
            {
                property = new();
                return false;
            }

            property = new(context.Node, context.Container.ToTypeContainer(), context.PointerDepth);
            return true;
        }

        public bool HasBaseType(string baseType)
        {
            return BaseTypes.ContainsKey(baseType);
        }

        public void Visit(ContextCSharpSyntaxVisitor visitor)
        {
            var oldContext = visitor.CurrentContext;

            visitor.CurrentContext = this;
            visitor.Visit(Node);

            foreach (var subTypes in SubTypes)
            {
                foreach (var subType in subTypes.Value)
                {
                    subType.Type?.Visit(visitor);
                }
            }

            foreach (var field in Fields)
            {
                visitor.Visit(field.Value.Node);
            }

            foreach (var property in Properties)
            {
                visitor.Visit(property.Value.Node);
            }

            foreach (var methods in Methods)
            {
                foreach (var method in methods.Value)
                {
                    visitor.Visit(method.Node);
                }
            }

            visitor.CurrentContext = oldContext;
        }

        public TypeContainer? Rewrite(ContextCSharpSyntaxRewriter rewriter, string ns, string file)
        {
            var oldContext = rewriter.CurrentContext;
            var oldNamespace = rewriter.CurrentNamespace;

            rewriter.CurrentContext = new(this);
            rewriter.CurrentNamespace = ns;

            var newNode = rewriter.Visit(Node);

            if (newNode is null)
            {
                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                return null;
            }

            if (newNode is EnumDeclarationSyntax en)
            {
                var newContext = new TypeContainer(Enum:new EnumContext(file, en, Parent));

                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                return newContext;
            }
            else if (newNode is TypeDeclarationSyntax ty)
            {
                Node = ty;

                List<string> removals = [];
                Dictionary<string, List<TypeContextContainer>> newTypes = [];
                foreach (var members in SubTypes)
                {
                    for (int i = 0; i < members.Value.Count; i++)
                    {
                        var member = members.Value[i];
                        if (member.Type is null)
                        {
                            continue;
                        }
                        member.ConvertContainer(member.Type.Rewrite(rewriter, ns, file));

                        if (member.IsNull)
                        {
                            members.Value.RemoveAt(i);
                            i--;
                            continue;
                        }

                        if (members.Key != member.Name)
                        {
                            members.Value.RemoveAt(i);
                            i--;

                            if (SubTypes.TryGetValue(member.Name, out var list2))
                            {
                                list2.Add(member);
                            }
                            else
                            {
                                newTypes.Add(member.Name, [member]);
                            }

                            rewriter.Context!.RenameType(member, members.Key);
                        }
                    }

                    if (members.Value.Count == 0)
                    {
                        removals.Add(members.Key);
                        continue;
                    }
                }

                foreach (var rem in removals)
                {
                    SubTypes.Remove(rem);
                }

                foreach (var newMember in newTypes)
                {
                    SubTypes.Add(newMember.Key, newMember.Value);
                }

                List<MemberDeclarationSyntax> newMembers = new List<MemberDeclarationSyntax>();
                foreach (var field in Fields)
                {
                    var newMember = rewriter.Visit(field.Value.Node);

                    if (newMember is MemberDeclarationSyntax member)
                    {
                        newMembers.Add(member);
                    }
                }

                foreach (var property in Properties)
                {
                    var newMember = rewriter.Visit(property.Value.Node);

                    if (newMember is MemberDeclarationSyntax member)
                    {
                        newMembers.Add(member);
                    }
                }

                foreach (var methods in Methods)
                {
                    foreach (var method in methods.Value)
                    {
                        var newMember = rewriter.Visit(method.Node);

                        if (newMember is MemberDeclarationSyntax member)
                        {
                            newMembers.Add(member);
                        }
                    }
                }

                Methods.Clear();
                Fields.Clear();
                Properties.Clear();

                foreach (var member in newMembers)
                {
                    ProcessMember(member, ns, file, rewriter.Context!, rewriter.Usings);
                }

                foreach (var member in Node.Members)
                {
                    ProcessMember(member, ns, file, rewriter.Context!, rewriter.Usings);
                }

                if (Node.BaseList is not null)
                {
                    foreach (var baseType in Node.BaseList.Types)
                    {
                        TryAddBaseType(baseType, rewriter.Context!, rewriter);
                    }
                }

                Node = Node.WithMembers(List(Array.Empty<MemberDeclarationSyntax>())).WithBaseList(BaseList(SeparatedList(Array.Empty<BaseTypeSyntax>())));
            }
            else if (newNode is DelegateDeclarationSyntax del)
            {
                var newContext = new TypeContainer(Delegate: new DelegateContext(del, rewriter.CurrentNamespace, rewriter.Context!, rewriter.Usings, Parent));

                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                return newContext;
            }
            else
            {
                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                throw new Exception("Type Declarations cannot be replaced with non type declarations");
            }

            rewriter.CurrentContext = oldContext;
            rewriter.CurrentNamespace = oldNamespace;
            return new(this);
        }

        private void ProcessMember(MemberDeclarationSyntax member, string ns, string file, SyntaxContext context, List<string> usings)
        {
            string parentName = Parent is null ? string.Empty : Parent.Name;
            if (member is BaseTypeDeclarationSyntax bT)
            {
                var ty = new TypeContextContainer(ns, context.CreateTypeContextFromNode(bT, ns, file, usings, this)!, bT.Modifiers
                        .Where(token => token.IsKind(SyntaxKind.PublicKeyword) || token.IsKind(SyntaxKind.ProtectedKeyword) || token.IsKind(SyntaxKind.PrivateKeyword))
                        .Select(token => token.Kind())
                        .FirstOrDefault(SyntaxKind.PrivateKeyword));

                context.AddTypeContextContainer(ty);

                if (!SubTypes.TryGetValue(bT.Identifier.Text, out var list))
                {
                    list = [];
                    SubTypes.Add(bT.Identifier.Text, list);
                }
                list.Add(ty);
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
            else if (member is BaseFieldDeclarationSyntax f)
            {
                TypeContextContainer type = context.GetTypeContainer(f.Declaration.Type, ns, usings, this, out int pDepth, parentName);

                foreach (var dec in f.Declaration.Variables)
                {
                    Fields.Add(dec.Identifier.Text, new(type, pDepth, f.WithDeclaration(f.Declaration.WithVariables(SeparatedList(new[] { dec })))));
                }
            }
            else if (member is BasePropertyDeclarationSyntax p)
            {
                TypeContextContainer type = context.GetTypeContainer(p.Type, ns, usings, this, out int pDepth, parentName);

                string propName = "[]";
                if (member is PropertyDeclarationSyntax prop)
                {
                    propName = prop.Identifier.Text;
                }
                else if (member is EventDeclarationSyntax even)
                {
                    propName = even.Identifier.Text;
                }
                Properties.Add(propName, new(type, pDepth, p));
            }
        }

        public bool TryAddBaseType(BaseTypeSyntax baseType, SyntaxContext context, ContextCSharpSyntaxRewriter rewriter)
        {
            if (BaseTypes.ContainsKey(baseType.Type.ToString()))
            {
                BaseTypes[baseType.Type.ToString()] = context.GetTypeContainer(baseType.Type, rewriter.CurrentNamespace, rewriter.Usings, this, out int _);
            }
            else
            {
                BaseTypes.Add(baseType.Type.ToString(), context.GetTypeContainer(baseType.Type, rewriter.CurrentNamespace, rewriter.Usings, this, out int _));
            }
            return true;
        }

        public void RemoveBaseType(BaseTypeSyntax baseType)
        {
            BaseTypes.Remove(baseType.Type.ToString());
        }

        public bool TryAddSubType(BaseTypeDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter)
        {
            ProcessMember(node, rewriter.CurrentNamespace, File, rewriter.Context!, rewriter.Usings);
            return true;
        }
        public void RemoveSubType(string name, int genericParameterCount = 0)
        {
            if (SubTypes.TryGetValue(name, out var list))
            {
                for (int i = 0; i <  list.Count; i++)
                {
                    if (list[i].Type?.GenericParameterCount == genericParameterCount)
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }

                if (list.Count == 0)
                {
                    SubTypes.Remove(name);
                }
            }
        }

        public void RemoveSubTypes(string name)
        {
            SubTypes.Remove(name);
        }
        public bool TryAddField(BaseFieldDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter)
        {
            ProcessMember(node, rewriter.CurrentNamespace, File, rewriter.Context!, rewriter.Usings);
            return true;
        }
        public void RemoveField(string name)
        {
            Fields.Remove(name);
        }
        public bool TryAddProperty(BasePropertyDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter)
        {
            ProcessMember(node, rewriter.CurrentNamespace, File, rewriter.Context!, rewriter.Usings);
            return true;
        }
        public void RemoveProperty(string name)
        {
            Properties.Remove(name);
        }
        public bool HasBaseType(BaseTypeSyntax baseType) => BaseTypes.Any(bT => bT.Value.Type?.Syntax == baseType.Type);
        public void RemoveBaseType(string baseType)
        {
            BaseTypes.Remove(baseType);
        }
        public bool TryGetMethods(string name, out IEnumerable<IBaseTypeContext.Method> methodInfo)
        {
            if (!Methods.TryGetValue(name, out var methods))
            {
                methodInfo = Array.Empty<IBaseTypeContext.Method>();
                return false;
            }
            methodInfo = methods.Select(method => new IBaseTypeContext.Method(method.Node, method.ReturnType.Item1?.ToTypeContainer(), method.ReturnType.Item2,
                method.Parameters.Select(par => (par.Key, new IBaseTypeContext.MethodParameter(par.Value.Node, par.Value.Type.ToTypeContainer(), par.Value.PointerDepth)))));
            return true;
        }
        public bool TryAddMethod(MethodDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter)
        {
            ProcessMember(node, rewriter.CurrentNamespace, File, rewriter.Context!, rewriter.Usings);
            return true;
        }
        public void RemoveMethod(string name, params TypeSyntax[] parameters)
        {
            if (Methods.TryGetValue(name, out var list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Parameters.Select(par => par.Value.Node.Type).SequenceEqual(parameters))
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }

                if (list.Count == 0)
                {
                    Methods.Remove(name);
                }
            }
        }
        public void RemoveMethods(string name)
        {
            Methods.Remove(name);
        }

        public void SetParent(IBaseTypeContext? parent) => ParentType = parent;
        public void Delete()
        {
            foreach (var subTypes in SubTypes)
            {
                foreach (var subType in subTypes.Value)
                {
                    subType.Delete();
                }
            }
        }
    }

    private class EnumContext : IEnumTypeContext
    {
        public EnumContext(string file, EnumDeclarationSyntax node, IBaseTypeContext? parent)
        {
            ParentType = parent;
            File = file;
            Node = node.WithMembers(SeparatedList(Array.Empty<EnumMemberDeclarationSyntax>()));

            foreach (var member in node.Members)
            {
                Members.Add(member.Identifier.Text, new(member));
            }
        }

        public EnumDeclarationSyntax Node;

        public string File;
        public IBaseTypeContext? ParentType;
        public TypeSyntax Syntax => IdentifierName(Node.Identifier.Text);

        public Dictionary<string, EnumMemberContext> Members = [];

        EnumDeclarationSyntax? IEnumTypeContext.Node => Node;

        public IEnumerable<(string, EnumMemberDeclarationSyntax)> EnumMembers => Members.Select(em => (em.Key, em.Value.Node));
        public IEnumerable<(string, BaseTypeSyntax, IBaseTypeContext)> BaseTypes => Node.BaseList is null ? Array.Empty<(string, BaseTypeSyntax, IBaseTypeContext)>() : Node.BaseList.Types.Select(type => (type.Type.ToString(), type, (IBaseTypeContext)new UnknownTypeContext(type.Type)));

        public string FileName => File;

        public string Name => $"{(Parent is null ? string.Empty : $"{Parent.Name}.")}{Node.Identifier.Text}";

        public IBaseTypeContext? Parent => ParentType;

        public bool IsEnum => true;

        public int GenericParameterCount => 0;

        public void Visit(ContextCSharpSyntaxVisitor visitor)
        {
            visitor.Visit(Node);

            foreach (var member in Members)
            {
                visitor.Visit(member.Value.Node);
            }
        }

        public TypeContainer? Rewrite(ContextCSharpSyntaxRewriter rewriter, string ns, string file)
        {
            var oldContext = rewriter.CurrentContext;
            var oldNamespace = rewriter.CurrentNamespace;

            rewriter.CurrentContext = new(Enum:this);
            rewriter.CurrentNamespace = ns;

            var newNode = rewriter.Visit(Node);

            if (newNode is null)
            {
                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                return null;
            }

            if (newNode is EnumDeclarationSyntax en)
            {
                Node = en;

                List<string> removals = [];
                foreach(var member in Members)
                {
                    var node = rewriter.Visit(member.Value.Node);

                    if (node is not EnumMemberDeclarationSyntax em)
                    {
                        removals.Add(member.Key);
                        continue;
                    }

                    member.Value.Node = em;
                }

                foreach(var rem in removals)
                {
                    Members.Remove(rem);
                }

                Members = Members.ToDictionary(kvp => kvp.Value.Node.Identifier.Text, kvp => kvp.Value);


                foreach (var member in Node.Members)
                {
                    if (Members.ContainsKey(member.Identifier.Text))
                    {
                        Members[member.Identifier.Text] = new(member);
                    }
                    else
                    {
                        Members.Add(member.Identifier.Text, new(member));
                    }
                }

                Node = Node.WithMembers(SeparatedList(Array.Empty<EnumMemberDeclarationSyntax>()));
            }
            else if (newNode is TypeDeclarationSyntax ty)
            {
                var newContext = new TypeContext(ns, file, ty, rewriter.Context!, rewriter.Usings, ParentType);

                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                return new(newContext);
            }
            else if (newNode is DelegateDeclarationSyntax del)
            {
                var newContext = new TypeContainer(Delegate: new DelegateContext(del, rewriter.CurrentNamespace, rewriter.Context!, rewriter.Usings, ParentType));

                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;
                return newContext;
            }
            else
            {
                throw new Exception("Type Declarations cannot be replaced with non type declarations");
            }

            var originalContext = rewriter.CurrentContext;
            rewriter.CurrentContext = oldContext;
            rewriter.CurrentNamespace = oldNamespace;
            return originalContext;
        }

        public MemberDeclarationSyntax? ToCompletedNode() => Node.WithMembers(SeparatedList(Members.Select(em => em.Value.Node)));

        public bool TryGetEnumMember(string memberName, out EnumMemberDeclarationSyntax? member)
        {
            if (!Members.TryGetValue(memberName, out var context))
            {
                member = null;
                return false;
            }

            member = context.Node;
            return true;
        }

        public bool HasBaseType(string baseType)
        {
            return Node.BaseList is not null && Node.BaseList.Types.Any(type => type.Type.ToString() == baseType);
        }
        public bool HasBaseType(BaseTypeSyntax baseType)
        {
            return Node.BaseList is not null && Node.BaseList.Types.Any(type => type == baseType);
        }

        public bool TryAddEnumMember(EnumMemberDeclarationSyntax node)
        {
            if (Members.ContainsKey(node.Identifier.Text))
            {
                Members[node.Identifier.Text] = new(node);
            }
            else
            {
                Members.Add(node.Identifier.Text, new(node));
            }
            return true;
        }
        public void RemoveEnumMember(string name)
        {
            Members.Remove(name);
        }

        public void SetParent(IBaseTypeContext? parent) => ParentType = parent;
    }

    private class UnknownTypeContext : IBaseTypeContext
    {
        public UnknownTypeContext(TypeSyntax type)
        {
            Type = type;
        }
        TypeSyntax Type;

        public TypeSyntax Syntax => Type;

        public string FileName => string.Empty;

        public string Name => Type.ToString();

        public IBaseTypeContext? Parent => null;

        public BaseTypeDeclarationSyntax? Node => null;

        public int GenericParameterCount => Type is GenericNameSyntax generic ? generic.TypeArgumentList.Arguments.Count : 0;

        public IEnumerable<(string, BaseTypeSyntax, IBaseTypeContext)> BaseTypes => Array.Empty<(string, BaseTypeSyntax, IBaseTypeContext)>();

        public IEnumerable<(string, IEnumerable<IBaseTypeContext.SubType>)> SubTypes => Array.Empty<(string, IEnumerable<IBaseTypeContext.SubType>)>();

        public IEnumerable<(string, IBaseTypeContext.Field)> Fields => Array.Empty<(string, IBaseTypeContext.Field)>();

        public IEnumerable<(string, IBaseTypeContext.Property)> Properties => Array.Empty<(string, IBaseTypeContext.Property)>();

        public IEnumerable<(string, IEnumerable<IBaseTypeContext.Method>)> Methods => Array.Empty<(string, IEnumerable<IBaseTypeContext.Method>)>();

        public MemberDeclarationSyntax? ToCompletedNode()
        {
            return null;
        }

        public void Visit(ContextCSharpSyntaxVisitor visitor)
        {
            visitor.Visit(Node);
        }

        public TypeContainer? Rewrite(ContextCSharpSyntaxRewriter rewriter, string ns, string file)
        {
            var oldContext = rewriter.CurrentContext;
            var oldNamespace = rewriter.CurrentNamespace;

            rewriter.CurrentContext = new(this);
            rewriter.CurrentNamespace = ns;

            var type = rewriter.Visit(Type) as TypeSyntax;

            if (type is not null)
            {
                rewriter.CurrentContext = oldContext;
                rewriter.CurrentNamespace = oldNamespace;

                return new(new UnknownTypeContext(type));
            }

            rewriter.CurrentContext = oldContext;
            rewriter.CurrentNamespace = oldNamespace;
            return null;
        }

        public bool TryGetSubType(string typeName, out IBaseTypeContext.SubType subType, int genericParameterCount = 0)
        {
            subType = new();
            return false;
        }
        public bool TryAddSubType(BaseTypeDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter) => false;
        public void RemoveSubType(string name, int genericParameterCount = 0) { }
        public void RemoveSubTypes(string name) { }
        public bool TryGetField(string fieldName, out IBaseTypeContext.Field field)
        {
            field = new();
            return false;
        }

        public bool TryAddField(BaseFieldDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter) => false;
        public void RemoveField(string name) { }
        public bool TryGetProperty(string propertyName, out IBaseTypeContext.Property property)
        {
            property = new();
            return false;
        }
        public bool TryAddProperty(BasePropertyDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter) => false;
        public void RemoveProperty(string name) { }
        public bool HasBaseType(string baseType) => false;
        public bool HasBaseType(BaseTypeSyntax baseType) => false;
        public bool TryAddBaseType(BaseTypeSyntax baseType, SyntaxContext context, ContextCSharpSyntaxRewriter rewriter) => false;
        public void RemoveBaseType(string baseType) { }
        public bool TryGetMethods(string name, out IEnumerable<IBaseTypeContext.Method> methodInfo)
        {
            methodInfo = Array.Empty<IBaseTypeContext.Method>();
            return false;
        }
        public bool TryAddMethod(MethodDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter) => false;
        public void RemoveMethod(string name, params TypeSyntax[] parameters) { }
        public void RemoveMethods(string name) { }

        public void SetParent(IBaseTypeContext? parent) { }

        public void Delete() { }

        public enum TypeLocation
        {
            BaseList,
            Field,
            Property
        }
    }

    private class DelegateContext : LeafNodeContext<DelegateDeclarationSyntax>, IDelegateContext
    {
        public DelegateContext(DelegateDeclarationSyntax node, string ns, SyntaxContext context, List<string> usings, IBaseTypeContext? parent) : base(node)
        {
            ParentType = parent;

            int pDepth;
            foreach (var para in node.ParameterList.Parameters)
            {
                Parameters.Add(para.Identifier.Text, new(para, ns, context, usings, parent?.Name ?? string.Empty, ParentType as TypeContext));
            }

            ReturnType = (context.GetTypeContainer(node.ReturnType, ns, usings, parent as TypeContext, out pDepth, parent?.Name ?? string.Empty), pDepth);
        }

        public void RefreshTypeLinks(string ns, SyntaxContext context, List<string> usings, IBaseTypeContext? parent)
        {
            int pDepth;
            Parameters.Clear();
            foreach (var para in Node.ParameterList.Parameters)
            {
                Parameters.Add(para.Identifier.Text, new(para, ns, context, usings, parent?.Name ?? string.Empty, ParentType as TypeContext));
            }

            ReturnType = (context.GetTypeContainer(Node.ReturnType, ns, usings, parent as TypeContext, out pDepth, parent?.Name ?? string.Empty), pDepth);
        }

        public Dictionary<string, MethodParameterContext> Parameters = [];
        public (TypeContextContainer?, int) ReturnType;
        public IBaseTypeContext? ParentType;

        public IBaseTypeContext? Parent => ParentType;

        public string Name => $"{(ParentType is null ? "" : $"{ParentType.Name}.")}{Node.Identifier.Text}";

        DelegateDeclarationSyntax? IDelegateContext.Node => throw new NotImplementedException();

        IEnumerable<(string, IBaseTypeContext.MethodParameter)> IDelegateContext.Parameters => Parameters.Select(par => (par.Key, new IBaseTypeContext.MethodParameter(par.Value.Node, par.Value.Type.ToTypeContainer(), par.Value.PointerDepth)));

        public static bool operator ==(DelegateContext left, DelegateContext right)
        {
            return left.Name == right.Name &&
                left.Parameters.Values.SequenceEqual(right.Parameters.Values);
        }

        public static bool operator !=(DelegateContext left, DelegateContext right)
        {
            return left.Name != right.Name ||
                !left.Parameters.Values.SequenceEqual(right.Parameters.Values);
        }

        public override bool Equals(object? obj) => base.Equals(obj);

        public override int GetHashCode() => ToString().GetHashCode();

        public override string ToString()
        {
            return $"{Node.Identifier.Text}({string.Join(',', Parameters.Select(par => $"{par.Value} {par.Key}"))})";
        }

        public static DelegateContext? ToDelegateContext(IDelegateContext context)
        {
            return context as DelegateContext;
        }

        public TypeContainer? Rewrite(ContextCSharpSyntaxRewriter rewriter, string ns, string file)
        {
            var node = rewriter.Visit(Node);

            if (node is DelegateDeclarationSyntax del)
            {
                Node = del;
                RefreshTypeLinks(ns, rewriter.Context!, rewriter.Usings, Parent);
            }
            else if (node is EnumDeclarationSyntax en)
            {
                var newContext = new TypeContainer(Enum: new EnumContext(file, en, Parent));

                return newContext;
            }
            else if (node is TypeDeclarationSyntax ty)
            {
                var newContext = new TypeContext(ns, file, ty, rewriter.Context!, rewriter.Usings, ParentType);
                return new(newContext);
            }
            else if (node is not null)
            {
                throw new Exception("Delegates cannot be replaced by non-type declarations (enum, class, delegate, etc.)");
            }

            return null;
        }

        public void Visit(ContextCSharpSyntaxVisitor visitor)
        {
            visitor.Visit(Node);
        }
    }

    internal class TypeContextContainer
    {
        public TypeContextContainer(string ns, IBaseTypeContext? ty, IEnumTypeContext? en, IDelegateContext? del, SyntaxKind visibility)
        {
            Namespace = ns;
            Type = ty;
            Visibility = visibility;
            Delegate = del;
            Enum = en;
        }

        public TypeContextContainer(string ns, TypeContainer? container, SyntaxKind visibility)
        {
            Namespace = ns;
            Type = container?.Type;
            Delegate = container?.Delegate;
            Enum = container?.Enum;
            Visibility = visibility;
        }

        public TypeContextContainer(string ns, IBaseTypeContext? ty, SyntaxKind visibility)
        {
            Namespace = ns;
            Type = ty;
            Visibility = visibility;
            Delegate = null;
            Enum = null;
        }

        public TypeContextContainer(string ns, IEnumTypeContext? en, SyntaxKind visibility)
        {
            Namespace = ns;
            Type = null;
            Visibility = visibility;
            Delegate = null;
            Enum = en;
        }

        public TypeContextContainer(string ns, IDelegateContext? del, SyntaxKind visibility)
        {
            Namespace = ns;
            Type = null;
            Visibility = visibility;
            Delegate = del;
            Enum = null;
        }

        public string Namespace;
        public SyntaxKind Visibility;
        public IBaseTypeContext? Type;
        public IEnumTypeContext? Enum;
        public IDelegateContext? Delegate;

        public string Name => Type is not null ? Type.Name : (Enum is not null ? Enum.Name : (Delegate is not null ? Delegate.Name : string.Empty));

        public void SetParent(IBaseTypeContext? parent, SyntaxContext context)
        {
            if (Type is not null)
            {
                string name = Type.Name;
                Type.SetParent(parent);

                context.RenameType(this, name);
            }
        }

        public bool IsPublic => Visibility == SyntaxKind.PublicKeyword;

        public bool IsNull => Type is null && Enum is null && Delegate is null;

        public override string ToString()
        {
            return Type?.Syntax.ToString() ?? string.Empty;
        }

        public TypeContainer ToTypeContainer()
        {
            return new(Type, Enum, Delegate);
        }

        public void ConvertContainer(TypeContainer? container)
        {
            Type = container?.Type;
            Enum = container?.Enum;
            Delegate = container?.Delegate;
        }

        public void Delete()
        {
            Type?.Delete();
            Type = null;
            Enum = null;
            Delegate = null;
        }
    }

    private class EnumMemberContext : LeafNodeContext<EnumMemberDeclarationSyntax>
    {
        public EnumMemberContext(EnumMemberDeclarationSyntax node) : base(node) { }
    }

    private class MethodContext : LeafNodeContext<MethodDeclarationSyntax>
    {
        public MethodContext(string ns, MethodDeclarationSyntax node, SyntaxContext context, List<string> usings, string parentName, TypeContext type) : base(node)
        {
            int pDepth;
            foreach (var para in node.ParameterList.Parameters)
            {
                Parameters.Add(para.Identifier.Text, new(para, ns, context, usings, parentName, type));
            }

            ReturnType = (context.GetTypeContainer(node.ReturnType, ns, usings, type, out pDepth, parentName), pDepth);
        }

        public void RefreshTypeLinks(string ns, SyntaxContext context, List<string> usings, IBaseTypeContext? parent)
        {
            if (parent is not TypeContext ty)
            {
                return;
            }
            int pDepth;
            Parameters.Clear();
            foreach (var para in Node.ParameterList.Parameters)
            {
                Parameters.Add(para.Identifier.Text, new(para, ns, context, usings, parent?.Name ?? string.Empty, ty));
            }

            ReturnType = (context.GetTypeContainer(Node.ReturnType, ns, usings, ty, out pDepth, parent?.Name ?? string.Empty), pDepth);
        }

        public Dictionary<string, MethodParameterContext> Parameters = [];
        public (TypeContextContainer?, int) ReturnType;

        public override string ToString()
        {
            return $"{Node.Identifier.Text}({string.Join(',', Parameters.Select(par => $"{par.Value} {par.Key}"))})";
        }

        public static bool operator ==(MethodContext left, MethodContext right)
        {
            return left.Node.Identifier.Text == right.Node.Identifier.Text &&
                left.Parameters.Values.SequenceEqual(right.Parameters.Values);
        }

        public static bool operator !=(MethodContext left, MethodContext right)
        {
            return left.Node.Identifier.Text != right.Node.Identifier.Text ||
                !left.Parameters.Values.SequenceEqual(right.Parameters.Values);
        }

        public override bool Equals(object? obj) => base.Equals(obj);

        public override int GetHashCode() => ToString().GetHashCode();
    }

    private class MethodParameterContext : LeafNodeContext<ParameterSyntax>
    {
        public MethodParameterContext(ParameterSyntax node, string ns, SyntaxContext context, List<string> usings, string parentName, TypeContext? type) : base(node)
        {
            Type = context.GetTypeContainer(node.Type!, ns, usings, type, out PointerDepth, parentName);
        }

        public TypeContextContainer Type;
        public int PointerDepth;
    }

    private class FieldContext : VariableNodes<BaseFieldDeclarationSyntax>
    {
        public FieldContext(TypeContextContainer container, int pointerDepth, BaseFieldDeclarationSyntax node) : base(container, node) { PointerDepth = pointerDepth; }

        public void RefreshTypeLinks(string ns, SyntaxContext context, List<string> usings, IBaseTypeContext? parent)
        {
            Container = context.GetTypeContainer(Node.Declaration.Type, ns, usings, parent as TypeContext, out PointerDepth, parent?.Name ?? string.Empty);
        }

        public int PointerDepth;

        public BaseFieldDeclarationSyntax ToCompletedNode()
        {
            var type = Container.Type!.Syntax;

            int pDepth = PointerDepth;
            while (pDepth > 0)
            {
                type = PointerType(type);
                pDepth--;
            }

            return Node.WithDeclaration(Node.Declaration.WithType(type));
        }
    }

    private class PropertyContext : VariableNodes<BasePropertyDeclarationSyntax>
    {
        public PropertyContext(TypeContextContainer container, int pointerDepth, BasePropertyDeclarationSyntax node) : base(container, node) { PointerDepth = pointerDepth; }

        public void RefreshTypeLinks(string ns, SyntaxContext context, List<string> usings, IBaseTypeContext? parent)
        {
            Container = context.GetTypeContainer(Node.Type, ns, usings, parent as TypeContext, out PointerDepth, parent?.Name ?? string.Empty);
        }

        public int PointerDepth;

        public BasePropertyDeclarationSyntax ToCompletedNode()
        {
            var type = Container.Type!.Syntax;

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
        where TNodeType : SyntaxNode
    {
        public VariableNodes(TypeContextContainer container, TNodeType node) : base(node) { Container = container; }

        public TypeContextContainer Container;
    }

    private class LeafNodeContext<TNodeType>(TNodeType node)
        where TNodeType: SyntaxNode
    {
        public TNodeType Node = node;

        public SyntaxNode? Rewrite(CSharpSyntaxRewriter rewriter) => rewriter.Visit(Node);
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
