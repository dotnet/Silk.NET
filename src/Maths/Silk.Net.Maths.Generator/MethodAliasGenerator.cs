#region

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

#endregion

namespace Silk.Net.Maths.Generator
{
    [Generator]
    public class ReferenceFunctionGenerator : ISourceGenerator
    {
        private const string library = @"using System;
namespace Silk.NET.Maths.Generator {
    [AttributeUsage(AttributeTargets.Struct)]
    internal class GenerateMethodAliasesAttribute : Attribute
    { }
}";

        public void Initialize
            (InitializationContext context)
            => context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());

        public void Execute(SourceGeneratorContext context)
        {
            context.AddSource("silk.net.maths.generator.shared.gen.cs", SourceText.From(library, Encoding.UTF8));

            if (!(context.SyntaxReceiver is SyntaxReceiver syntaxReceiver))
            {
                return;
            }

            if (!(context.Compilation is CSharpCompilation cSharpCompilation))
            {
                return;
            }

            var options = cSharpCompilation.SyntaxTrees[0].Options as CSharpParseOptions;
            var compilation = context.Compilation.AddSyntaxTrees
                (CSharpSyntaxTree.ParseText(SourceText.From(library, Encoding.UTF8), options));
            var att = compilation.GetTypeByMetadataName("Silk.NET.Maths.Generator.GenerateMethodAliasesAttribute");

            var structSymbols = (from s in syntaxReceiver.StructDeclarations
                    let semanticModel = compilation.GetSemanticModel(s.SyntaxTree)
                    select (INamedTypeSymbol) semanticModel.GetDeclaredSymbol(s)
                    into symbol
                    where !(symbol is null)
                    where symbol.GetAttributes().Any(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, att))
                    select symbol).Distinct()
                .ToArray();

            var methodGroups = structSymbols.Where
                    (s => s.ContainingSymbol.Equals(s.ContainingNamespace, SymbolEqualityComparer.Default))
                .SelectMany(s => s.GetMembers(), (s, member) => new {s, member})
                .Where(t => !(t.member is null))
                .Where(t => t.member is IMethodSymbol)
                .Select(t => t.member as IMethodSymbol)
                .Where(method => method.IsStatic)
                .GroupBy(method => method.ContainingType)
                .Select(g => g)
                .ToArray();

            foreach (var group in methodGroups)
            {
                var s = ProcessClass_GenerateRefFunctions(group.Key, group.ToList());

                if (s is null)
                {
                    continue;
                }

                var name = $"{group.Key.Name}.ReferenceFunctions.gen.cs";
                context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                // File.WriteAllText($"./{name}.gen", s);
            }

            foreach (var group in methodGroups)
            {
                var s = ProcessClass_GenerateProperties(group.Key, group.ToList());

                if (s is null)
                {
                    continue;
                }

                var name = $"{group.Key.Name}.Properties.gen.cs";
                context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                // File.WriteAllText($"./{name}.gen", s);
            }

            foreach (var group in methodGroups)
            {
                var s = ProcessClass_GenerateOperators(group.Key, group.ToList());

                if (s is null)
                {
                    continue;
                }

                var name = $"{group.Key.Name}.Operators.gen.cs";
                context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                // File.WriteAllText($"./{name}.gen", s);
            }
        }

        private string? ProcessClass_GenerateOperators(INamedTypeSymbol structSymbol, List<IMethodSymbol> methods)
        {
            var namespaceName = structSymbol.ContainingNamespace.ToDisplayString();

            var source = new StringBuilder
            (
                $@"
using System.Runtime.CompilerServices;

namespace {namespaceName}
{{
    public"
            );

            if (structSymbol.IsReadOnly)
            {
                source.Append(" readonly");
            }

            source.Append($@" partial struct {structSymbol.Name}");
            if (structSymbol.IsGenericType)
            {
                source.Append("<");
                for (var index = 0; index < structSymbol.TypeParameters.Length; index++)
                {
                    var structSymbolTypeParameter = structSymbol.TypeParameters[index];
                    source.Append(structSymbolTypeParameter.Name);
                    if (index + 1 < structSymbol.TypeParameters.Length)
                    {
                        source.Append(",");
                    }
                }

                source.Append(">");
            }

            source.Append("   {");

            foreach (var method in methods)
            {
                if (method.MethodKind != MethodKind.Ordinary)
                {
                    continue;
                }

                // special case for "Negate"
                if (method.Parameters.Length == 1 && method.Name == "Negate" && SymbolEqualityComparer.Default.Equals
                        (method.Parameters[0].Type, method.Parameters[0].ContainingType) &&
                    method.Parameters[0].RefKind == RefKind.None)
                {
                    source.Append
                    (
                        "[MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)512)]" +
                        $"public static {method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} operator " +
                        $"-({method.Parameters[0].Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {method.Parameters[0].Name})" +
                        $" => {method.Name}({method.Parameters[0].Name});"
                    );
                    continue;
                }

                // ignore non-binary
                // ignore methods without `this` parameter
                // ignore ref/in/out parameters
                if (method.Parameters.Length != 2 ||
                    !method.Parameters.Any(x => SymbolEqualityComparer.Default.Equals(x.Type, x.ContainingType)) ||
                    method.Parameters.Any(x => x.RefKind != RefKind.None))
                {
                    continue;
                }

                var o = method.Name switch
                {
                    "Add" => "+",
                    "Subtract" => "-",
                    "Divide" => "/",
                    "Multiply" => "*",
                    _ => null
                };

                if (o is null)
                {
                    continue;
                }

                // public static Vector4<T> operator /(Vector4<T> vec, T scale) => Divide(vec, scale);
                source.Append
                (
                    "[MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)512)]" +
                    $"public static {method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} operator " +
                    $"{o}({method.Parameters[0].Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {method.Parameters[0].Name}," +
                    $" {method.Parameters[1].Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {method.Parameters[1].Name})" +
                    $"=> {method.Name}({method.Parameters[0].Name}, {method.Parameters[1].Name});"
                );
            }

            source.Append("}}");

            return source.ToString();
        }

        private string? ProcessClass_GenerateProperties(INamedTypeSymbol structSymbol, List<IMethodSymbol> methods)
        {
            var namespaceName = structSymbol.ContainingNamespace.ToDisplayString();

            var source = new StringBuilder
            (
                $@"
using System.Runtime.CompilerServices;

namespace {namespaceName}
{{
    public"
            );

            if (structSymbol.IsReadOnly)
            {
                source.Append(" readonly");
            }

            source.Append($@" partial struct {structSymbol.Name}");
            if (structSymbol.IsGenericType)
            {
                source.Append("<");
                for (var index = 0; index < structSymbol.TypeParameters.Length; index++)
                {
                    var structSymbolTypeParameter = structSymbol.TypeParameters[index];
                    source.Append(structSymbolTypeParameter.Name);
                    if (index + 1 < structSymbol.TypeParameters.Length)
                    {
                        source.Append(",");
                    }
                }

                source.Append(">");
            }

            source.Append("   {");

            foreach (var method in methods)
            {
                if (method.MethodKind != MethodKind.Ordinary)
                {
                    continue;
                }

                // ignore methods that don't have themselves as first and only parameter (this)
                if (method.Parameters.Length != 1 ||
                    !method.Parameters[0].Type.Equals(method.ContainingType, SymbolEqualityComparer.Default) ||
                    !method.Name.StartsWith("Get"))
                {
                    continue;
                }

                // ignore ref/in/out first parameters
                if (method.Parameters[0].RefKind != RefKind.None)
                {
                    continue;
                }

                source.Append
                (
                    $"public readonly {method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {method.Name.Substring(3)} " +
                    " { " + "[MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)512)]" +
                    $"get => {method.Name}(this);" + " }"
                );
            }

            source.Append("}}");

            return source.ToString();
        }

        private string ProcessClass_GenerateRefFunctions(INamedTypeSymbol structSymbol, List<IMethodSymbol> methods)
        {
            var namespaceName = structSymbol.ContainingNamespace.ToDisplayString();

            var source = new StringBuilder
            (
                $@"
using System.Runtime.CompilerServices;

namespace {namespaceName}
{{
    public"
            );

            if (structSymbol.IsReadOnly)
            {
                source.Append(" readonly");
            }

            source.Append($@" partial struct {structSymbol.Name}");
            if (structSymbol.IsGenericType)
            {
                source.Append("<");
                for (var index = 0; index < structSymbol.TypeParameters.Length; index++)
                {
                    var structSymbolTypeParameter = structSymbol.TypeParameters[index];
                    source.Append(structSymbolTypeParameter.Name);
                    if (index + 1 < structSymbol.TypeParameters.Length)
                    {
                        source.Append(",");
                    }
                }

                source.Append(">");
            }

            source.Append("   {");

            foreach (var method in methods)
            {
                if (method.MethodKind != MethodKind.Ordinary)
                {
                    continue;
                }

                if (method.ReturnsVoid)
                {
                    continue;
                }

                source.Append("[MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)512)]");
                source.Append("public");
                if (method.IsStatic)
                {
                    source.Append(" static");
                }

                source.Append($" void {method.Name}(");

                foreach (var parameter in method.Parameters)
                {
                    if (SymbolEqualityComparer.Default.Equals
                        (parameter.Type.ContainingSymbol, parameter.Type.ContainingNamespace))
                    {
                        if (parameter.Type is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsUnmanagedType)
                        {
                            if (namedTypeSymbol.IsGenericType)
                            {
                                source.Append("ref ");
                            }
                            else
                            {
                                var i = 0;
                                var subType = new Queue<INamedTypeSymbol>();
                                subType.Enqueue(namedTypeSymbol);

                                while (subType.Count > 0)
                                {
                                    var v = subType.Dequeue();
                                    if (!v.IsUnmanagedType)
                                    {
                                        break;
                                    }

                                    if (v.IsGenericType)
                                    {
                                        if (i > 16)
                                        {
                                            // it's fair to assume the generic type will be large enough
                                            source.Append("ref ");
                                        }

                                        // don't handle
                                        // TODO: add diagnostic
                                        /*
                                         * Here something like Matrix4X4<Vector4<T>> would fail
                                         * 
                                         */
                                        break;
                                    }

                                    if (v.EnumUnderlyingType != null)
                                    {
                                        subType.Enqueue(v.EnumUnderlyingType);
                                    }
                                    else if (v.BaseType != null)
                                    {
                                        subType.Enqueue(v.BaseType);
                                    }
                                    else
                                    {
                                        var s = v.SpecialType switch
                                        {
                                            SpecialType.System_Boolean => sizeof(bool),
                                            SpecialType.System_Byte => sizeof(byte),
                                            SpecialType.System_Char => sizeof(char),
                                            SpecialType.System_Decimal => sizeof(decimal),
                                            SpecialType.System_Double => sizeof(double),
                                            SpecialType.System_Int16 => sizeof(short),
                                            SpecialType.System_Int32 => sizeof(int),
                                            SpecialType.System_Int64 => sizeof(long),
                                            SpecialType.System_Single => sizeof(float),
                                            SpecialType.System_IntPtr => sizeof(long), // assuming large
                                            SpecialType.System_SByte => sizeof(sbyte),
                                            SpecialType.System_UInt16 => sizeof(ushort),
                                            SpecialType.System_UInt32 => sizeof(uint),
                                            SpecialType.System_UInt64 => sizeof(ulong),
                                            SpecialType.System_UIntPtr => sizeof(ulong), // assuming large
                                            _ => int
                                                .MinValue // shouldn't be possible, I believe, because unmanaged constraint?
                                        };

                                        if (s < 0)
                                        {
                                            foreach (var member in v.GetMembers())
                                            {
                                                if (member is INamedTypeSymbol t)
                                                {
                                                    subType.Enqueue(t);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            i += s;
                                        }
                                    }

                                    if (i > 32)
                                    {
                                        source.Append("ref ");
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    source.Append
                    (
                        $"{parameter.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {parameter.Name}"
                    );
                    source.Append(',');
                }

                source.Append
                (
                    $"out {method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} result) => result = {method.Name}("
                );

                for (var index = 0; index < method.Parameters.Length; index++)
                {
                    var parameter = method.Parameters[index];
                    source.Append(parameter.Name);
                    if (index + 1 < method.Parameters.Length)
                    {
                        source.Append(',');
                    }
                }

                source.Append(");");
            }

            source.Append("} }");

            return source.ToString();
        }

        private class SyntaxReceiver : ISyntaxReceiver
        {
            public readonly List<StructDeclarationSyntax> StructDeclarations = new List<StructDeclarationSyntax>();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is StructDeclarationSyntax sds)
                {
                    StructDeclarations.Add(sds);
                }
            }
        }
    }
}
