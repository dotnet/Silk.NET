using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.Core.Native;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Parameter = Silk.NET.BuildTools.Common.Functions.Parameter;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.Generators.Interop
{
    [Generator]
    public class SilkNativeSourceGenerator : PredicatedTypeGenerator
    {
        protected override bool Predicate(SourceGeneratorContext context, IMethodSymbol decl, INamedTypeSymbol declParent)
        {
            return GoAhead(decl) || GoAhead(declParent);
            bool GoAhead(ISymbol sym)
            {
                var goAhead = false;
                foreach (var attribute in sym.GetAttributes())
                {
                    if (attribute.AttributeClass?.Name == nameof(NativeApiAttribute) &&
                        (attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Native" ||
                         attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Attributes"))
                    {
                        goAhead = true;
                    }
                    
                    if (attribute.AttributeClass?.Name == nameof(NotNativeApiAttribute) &&
                        (attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Native" ||
                         attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Attributes"))
                    {
                        return false;
                    }
                }
                return goAhead;
            }
        }

        protected override void Generate
            (SourceGeneratorContext context, IMethodSymbol decl, INamedTypeSymbol declParent, out object? o)
        {
            o = null;
            AttributeData? parent = null;
            foreach (var attribute in declParent.GetAttributes())
            {
                if (attribute.AttributeClass?.Name == nameof(NativeApiAttribute) &&
                    (attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Native" ||
                     attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Attributes"))
                {
                    parent = attribute;
                }
            }
            
            foreach (var attribute in decl.GetAttributes())
            {
                if (attribute.AttributeClass?.Name == nameof(NativeApiAttribute) &&
                    (attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Native" ||
                    attribute.AttributeClass.ContainingNamespace.Name == "Silk.NET.Core.Attributes"))
                {
                    o = GetRet(attribute, parent);
                    return;
                }
            }

            if (!(parent is null))
            {
                o = GetRet(null, parent);
            }

            object GetRet(AttributeData? attribute, AttributeData? parent)
            {
                var attribVal = CreateInstance(attribute);
                var parentVal = CreateInstance(parent);
                var function = new Function
                {
                    GenericTypeParameters = decl.TypeParameters.Select
                        (
                            x => new GenericTypeParameter
                            {
                                Name = x.Name,
                                Constraints = x.ConstraintTypes.Select
                                        (y => y.Name)
                                    .Concat(GetOtherConstraints(x))
                                    .ToList()
                            }
                        )
                        .ToList(),
                    Name = decl.Name,
                    NativeName = NativeApiAttribute.GetEntryPoint(attribVal, parentVal, decl.Name),
                    Attributes = GetAttributes(decl),
                    Convention = NativeApiAttribute.GetCallingConvention(attribVal, parentVal),
                    Parameters = decl.Parameters.Select
                        (
                            x => new Parameter
                                {Attributes = GetAttributes(x), Name = x.Name, Type = GetType(x.Type, (int) x.RefKind)}
                        )
                        .ToList(),
                    ReturnType = GetType(decl.ReturnType, decl.ReturnsByRef || decl.ReturnsByRefReadonly ? 1 : 0)
                };

                return (declParent.ContainingNamespace.Name, decl.Name, NativeGenerator.GetImplementation(function));
            }

            Type GetType(ITypeSymbol symbol, int refKind) => new Type
            {
                ArrayDimensions = symbol is IArrayTypeSymbol a ? a.Rank : 0,
                GenericTypes = symbol is INamedTypeSymbol n && n.TypeArguments.Length != 0 ? n.TypeArguments.Select(GetType).ToList() : new List<Type>(),
                IndirectionLevels = GetIndirectionLevel(symbol),
                IsByRef = refKind == 1,
                IsIn = refKind == 3,
                IsOut = refKind == 2,
                Name = symbol.ContainingNamespace.Name + "." + symbol.Name
            };

            int GetIndirectionLevel(ITypeSymbol? s)
            {
                if (s is null)
                {
                    return 0;
                }
                
                if (s is IPointerTypeSymbol p)
                {
                    return GetIndirectionLevel(p.PointedAtType) + 1;
                }

                return 0;
            }

            List<Attribute> GetAttributes(ISymbol symbol) => symbol.GetAttributes()
                .Select
                (
                    x => new Attribute
                    {
                        Name = x.AttributeClass!.Name,
                        Arguments = x.ConstructorArguments.Select
                                (y => GetVal(y))
                            .Concat(x.NamedArguments.Select(y => y.Key + " = " + GetVal(y.Value)))
                            .ToList()
                    }
                )
                .ToList();

            string GetVal(TypedConstant val)
            {
                if (!val.Values.IsDefaultOrEmpty)
                {
                    return "new []{" + string.Join(", ", val.Values.Select(GetVal)) + "}";
                }
                
                if (val.Value is null)
                {
                    return "null";
                }

                if (val.Value is string s)
                {
                    return $"\"{s}\"";
                }

                return val.ToString();
            }
            
            NativeApiAttribute? CreateInstance(AttributeData? attributeData)
            {
                if (attributeData is null) return null;
                
                var val = new NativeApiAttribute();
                foreach (var namedArgument in attributeData.NamedArguments)
                {
                    foreach (var fieldInfo in val.GetType().GetFields())
                    {
                        if (fieldInfo.Name == namedArgument.Key)
                        {
                            fieldInfo.SetValue(val, namedArgument.Value.Value);
                            break;
                        }
                    }
                    
                    foreach (var propertyInfo in val.GetType().GetProperties())
                    {
                        if (propertyInfo.Name == namedArgument.Key)
                        {
                            propertyInfo.SetValue(val, namedArgument.Value.Value);
                            break;
                        }
                    }
                }

                return val;
            }

            IEnumerable<string> GetOtherConstraints(ITypeParameterSymbol symbol)
            {
                if (symbol.HasConstructorConstraint)
                {
                    yield return "new()";
                }

                if (symbol.HasReferenceTypeConstraint)
                {
                    yield return "class";
                }

                if (symbol.HasUnmanagedTypeConstraint)
                {
                    yield return "unmanaged";
                }

                if (symbol.HasValueTypeConstraint)
                {
                    yield return "struct";
                }
            }
        }

        protected override void Output(SourceGeneratorContext ctx, List<object> inputs)
        {
            var outputDictionary = new Dictionary<(string Namespace, string Name), List<ImplementedFunction>>();
            
            foreach ((string, string, ImplementedFunction) input in inputs)
            {
                if (outputDictionary.TryGetValue((input.Item1, input.Item2), out var val))
                {
                    val.Add(input.Item3);
                }
                else
                {
                    outputDictionary.Add((input.Item1, input.Item2), new List<ImplementedFunction>{input.Item3});
                }
            }
            
            foreach (var kvp in outputDictionary)
            {
                var sw = new StringWriter();
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using Silk.NET.Core.Native;");
                sw.WriteLine("using Silk.NET.Core.Contexts;");
                sw.WriteLine("using Silk.NET.Core.Attributes;");
                sw.WriteLine("using Silk.NET.Core.Loader;");
                sw.WriteLine();
                sw.WriteLine($"namespace {kvp.Key.Item1}");
                sw.WriteLine("{");
                sw.WriteLine($"    unsafe partial class {kvp.Key.Item2}");
                sw.WriteLine("    {");
                sw.WriteLine("         private IntPtr[] _addresses;");
                var slot = 0;
                foreach (var function in kvp.Value)
                {
                    sw.WriteLine($"        private {function.Signature}");
                    sw.WriteLine("        {");
                    foreach (var line in function.Body)
                    {
                        sw.WriteLine($"            {line.Replace("$SLOT$", slot++.ToString())}");
                    }
                    
                    sw.WriteLine("        }");
                    sw.WriteLine();
                }
                
                sw.WriteLine("        private void InitializeNative()");
                sw.WriteLine("        {");
                sw.WriteLine($"            _addresses = new IntPtr[{slot}]");
                sw.WriteLine("        }");
                sw.WriteLine("    }");
                sw.WriteLine("}");
                sw.WriteLine();
            }
        }
    }


    public abstract class PredicatedTypeGenerator : ISourceGenerator
    {
        public void Execute(SourceGeneratorContext context)
        {
            // if you wanna debug this method, uncomment this
            // ugly but works. blame roslyn devs not me
            //Debugger.Launch();

            var receiver = (SyntaxTypeReceiver<MethodDeclarationSyntax, ClassDeclarationSyntax>)context.SyntaxReceiver!;

            var nodes = receiver.SyntaxNodes;
            var comp = context.Compilation;

            OnExecute(context);

            // this handles partial types, which have multiple type declaration nodes
            var visited = new HashSet<string>();
            var outputs = new List<object>();
            foreach (var (tree, node, nodeParent) in nodes)
            {
                var semantics = comp.GetSemanticModel(tree);
                var method = (semantics.GetDeclaredSymbol(node) as IMethodSymbol)!;
                var type = method.ContainingType;

                if (!Predicate(context, method, type) || visited.Contains(type.Name))
                {
                    continue;
                }

                Generate(context, method, type, out var o);
                outputs.Add(o);
                visited.Add(type.Name);
            }
            
            Output(context, outputs);
        }

        protected virtual void OnExecute(SourceGeneratorContext context) { }

        protected abstract bool Predicate
            (SourceGeneratorContext context, IMethodSymbol decl, INamedTypeSymbol declParent);

        protected abstract void Generate
            (SourceGeneratorContext context, IMethodSymbol decl, INamedTypeSymbol declParent, out object? o);

        protected abstract void Output(SourceGeneratorContext ctx, List<object> inputs);

        public void Initialize(InitializationContext context)
            => context.RegisterForSyntaxNotifications(() => new SyntaxTypeReceiver<MethodDeclarationSyntax, ClassDeclarationSyntax>());
    }

    internal sealed class SyntaxTypeReceiver<TNode, TParent> : ISyntaxReceiver
        where TNode : SyntaxNode
        where TParent : SyntaxNode
    {
        public SyntaxTypeReceiver(Func<TNode, bool>? predicate = null)
        {
            _predicate = predicate;
        }

        private Func<TNode, bool>? _predicate;

        public List<(SyntaxTree Tree, TNode Node, TParent? NodeParent)> SyntaxNodes =
            new List<(SyntaxTree Tree, TNode Node, TParent? NodeParent)>();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is TNode decl && (_predicate?.Invoke(decl) ?? true))
            {
                SyntaxNodes.Add((decl.SyntaxTree, decl, decl.Parent as TParent));
            }
        }
    }
}
