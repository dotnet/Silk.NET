using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenerateMatrixMath
{
    internal static class RoslynExtensions
    {
        public static string ToCSharpString(this Type type, string[] usingNamespaces = null, Assembly[] usingAssemblies = null, SymbolDisplayFormat symbolDisplayFormat = null)
        {
            var compilationUnit = SyntaxFactory.CompilationUnit();
            if (usingNamespaces != null)
            {
                compilationUnit = compilationUnit.AddUsings(
                    Array.ConvertAll(usingNamespaces, n => SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(n))));
            }
            else
            {
                compilationUnit = compilationUnit.AddUsings(
                    SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System")));
            }

            MetadataReference[] metadataReferences;
            if (usingAssemblies != null)
            {
                metadataReferences = Array.ConvertAll(usingAssemblies, u => MetadataReference.CreateFromFile(u.Location));
            }
            else
            {
                metadataReferences = new[]
                {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(type.Assembly.Location)
            };
            }

            var typeName = SyntaxFactory.ParseTypeName(type.ToFullyQualifiedName());

            var field = SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(typeName).WithVariables(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.VariableDeclarator(
                            SyntaxFactory.Identifier("field")))));
            compilationUnit = compilationUnit.AddMembers(
                SyntaxFactory.ClassDeclaration("MyClass").AddMembers(
                    field))
                .NormalizeWhitespace();

            var tree = compilationUnit.SyntaxTree;
            var compilation = CSharpCompilation.Create("MyAssembly", [tree], metadataReferences);
            var semanticModel = compilation.GetSemanticModel(tree);
            var root = tree.GetRoot();

            var typeSymbol = semanticModel.GetTypeInfo(compilationUnit
                .DescendantNodes().OfType<ClassDeclarationSyntax>().Single()
                .Members.OfType<FieldDeclarationSyntax>().Single()
                .Declaration.Type);

            return typeSymbol.Type.ToDisplayString(symbolDisplayFormat ?? new SymbolDisplayFormat(
                typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypes,
                genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters,
                miscellaneousOptions: SymbolDisplayMiscellaneousOptions.UseSpecialTypes));
        }

        public static string ToFullyQualifiedName(this Type type)
        {
            switch (type)
            {
                case { IsGenericParameter: true }: return type.Name;
                case { IsArray: true }: return type.GetElementType().ToFullyQualifiedName() + "[]";
                case { IsPointer: true }: return type.GetElementType().ToFullyQualifiedName() + "*";
                case { IsByRef: true }: return type.GetElementType().ToFullyQualifiedName() + "&";
                case { IsGenericType: false }: return string.IsNullOrEmpty(type.FullName) ? type.Name : type.FullName.Replace('+', '.');
                default:
                    var fullName = type.GetGenericTypeDefinition().FullName;
                    var backTickIndex = fullName.IndexOf('`');
                    if (backTickIndex > 0)
                    {
                        fullName = fullName.Substring(0, backTickIndex);
                    }

                    return fullName.Replace('+', '.') + "<" + string.Join(", ", type.GetGenericArguments().Select(ToFullyQualifiedName)) + ">";
            }
            ;
        }
    }
}
