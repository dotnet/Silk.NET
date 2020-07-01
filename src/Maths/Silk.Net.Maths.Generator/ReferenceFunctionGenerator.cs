using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Silk.Net.Maths.Generator
{
    [Generator]
    public class ReferenceFunctionGenerator : ISourceGenerator
    {
        // note that attributes are global. Yes this isn't ideal, but the IDE experience is at least acceptable like this
        private const string library = @"using System;
    [AttributeUsage(AttributeTargets.Method)]
    public class GenerateReferenceFunctionAttribute : Attribute
    { }";
        
        public void Initialize(InitializationContext context)
        {
            // Register a factory that can create our custom syntax receiver
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(SourceGeneratorContext context)
        {
            context.AddSource("silk.net.maths.generator.shared.gen.cs", SourceText.From(library, Encoding.UTF8));
            if (!(context.SyntaxReceiver is SyntaxReceiver syntaxReceiver))
                return;

            var options = (context.Compilation as CSharpCompilation).SyntaxTrees[0].Options as CSharpParseOptions;
            var compilation = context.Compilation.AddSyntaxTrees
                (CSharpSyntaxTree.ParseText(SourceText.From(library, Encoding.UTF8), options));
            var grfattribute = compilation.GetTypeByMetadataName
                ("GenerateReferenceFunctionAttribute");

            var methodSymbols = (from method in syntaxReceiver.MethodDeclarations
                let semanticModel = compilation.GetSemanticModel(method.SyntaxTree)
                select (IMethodSymbol)semanticModel.GetDeclaredSymbol(method)!
                into symbol
                where !(symbol is null)
                where symbol!.GetAttributes()
                    .Any(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, grfattribute))
                group symbol by symbol.ContainingType into g
                select g);

            foreach (var group in methodSymbols)
            {
                var s = ProcessClass(group.Key, group.ToList(), context);
                
                if (s is null)
                    continue;

                var name = $"{@group.Key.Name}.ReferenceFunctions.gen.cs";
                context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                // File.WriteAllText($"./{name}.gen", s);
            }
        }

        private string? ProcessClass(INamedTypeSymbol structSymbol, List<IMethodSymbol> methods, SourceGeneratorContext 
        context)
        {
            if (!structSymbol.ContainingSymbol.Equals(structSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
                return null;
            
            string namespaceName = structSymbol.ContainingNamespace.ToDisplayString();

            StringBuilder source = new StringBuilder
            (
                $@"
namespace {namespaceName}
{{
    public"
            );

            if (structSymbol.IsReadOnly)
                source.Append(" readonly");
            
            source.Append($@" partial struct {structSymbol.Name}");
            if (structSymbol.IsGenericType)
            {
                source.Append("<");
                for (var index = 0; index < structSymbol.TypeParameters.Length; index++)
                {
                    var structSymbolTypeParameter = structSymbol.TypeParameters[index];
                    source.Append(structSymbolTypeParameter.Name);
                    if (index + 1 < structSymbol.TypeParameters.Length)
                        source.Append(",");
                }

                source.Append(">");
            }
            source.Append("   {");

            foreach (var method in methods)
            {
                source.Append($"public");
                if (method.IsStatic)
                    source.Append(" static");
                source.Append($" void {method.Name}(");

                foreach (var parameter in method.Parameters)
                {
                    if (SymbolEqualityComparer.Default.Equals(parameter.Type.ContainingSymbol, parameter.Type.ContainingNamespace))
                    {
                        if (parameter.Type is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsUnmanagedType)
                        {
                            if (namedTypeSymbol.IsGenericType)
                            {
                                source.Append("ref ");
                            }
                            else
                            {
                                int i = 0;
                                Queue<INamedTypeSymbol> subType = new Queue<INamedTypeSymbol>();
                                subType.Enqueue(namedTypeSymbol);

                                while (subType.Count > 0)
                                {
                                    var v = subType.Dequeue();
                                    if (!v.IsUnmanagedType)
                                        break;

                                    if (v.IsGenericType)
                                    {
                                        if (i > 16)
                                        {
                                            // it's fair to assume the generic type will be large enough
                                            source.Append("ref ");
                                            break;
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
                                        var s =  v.SpecialType switch
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
                                            _ => int.MinValue // shouldn't be possible, I believe, because unmanaged constraint?
                                        };

                                        if (s < 0)
                                        {
                                            foreach (var member in v.GetMembers())
                                            {
                                                if (member is INamedTypeSymbol t)
                                                    subType.Enqueue(t);
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
                    source.Append($"{parameter.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} {parameter.Name}");
                    source.Append(',');
                }
                
                source.Append
                    ($"out {method.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)} result) => result = {method.Name}(");

                for (var index = 0; index < method.Parameters.Length; index++)
                {
                    var parameter = method.Parameters[index];
                    source.Append(parameter.Name);
                    if (index + 1 < method.Parameters.Length)
                        source.Append(',');
                }

                source.Append(");");
            }

            source.Append("}}");

            return source.ToString();
        }

        class SyntaxReceiver : ISyntaxReceiver
        {
            public List<MethodDeclarationSyntax> MethodDeclarations = new List<MethodDeclarationSyntax>();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is MethodDeclarationSyntax mds)
                {
                    MethodDeclarations.Add(mds);
                }
            }
        }
    }
}
