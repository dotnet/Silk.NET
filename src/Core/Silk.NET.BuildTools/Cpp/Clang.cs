// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using CppAst;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Cpp
{
    public static class Clang
    {
        public static unsafe Profile GenerateProfile(string fileName, Stream input, BindTask task)
        {
            var profile = new Profile
            {
                Name = Path.GetFileNameWithoutExtension(fileName)
            };

            Console.WriteLine("Loading input header...");
            using var ms = new MemoryStream();
            input.CopyTo(ms);
            var arr = ms.ToArray();
            string str;
            fixed (byte* arrPtr = arr)
            {
                str = new string((sbyte*)arrPtr, 0, arr.Length);
            }

            Console.WriteLine("Parsing header...");
            var opts = new CppParserOptions();
            opts.AdditionalArguments.AddRange(task.ClangOpts.ClangArgs);
            var parsed = CppParser.Parse(str, opts, fileName);
            
            Console.WriteLine("Parsing complete" + (parsed.Diagnostics.HasErrors ? " with errors" : null) + "!");
            foreach (var diagnostic in parsed.Diagnostics.Messages)
            {
                Console.WriteLine($"[{diagnostic.Type}] {diagnostic.Location}: {diagnostic.Text}");
            }

            if (parsed.Diagnostics.HasErrors)
            {
                throw new InvalidOperationException("Halting due to parsing errors (see above)");
            }

            Console.WriteLine("Preparing to convert Clang AST to Binder JSON...");
            var destInfo = task.ClangOpts.ClassMappings[fileName];
            var indexOfOpenSqBracket = destInfo.IndexOf('[');
            var indexOfCloseSqBracket = destInfo.LastIndexOf(']');
            var projectName = destInfo.Substring(indexOfOpenSqBracket + 1, indexOfCloseSqBracket - indexOfOpenSqBracket - 1);
            var className = destInfo.Substring(indexOfCloseSqBracket + 1);
            var project = profile.Projects[projectName] = new Project
                {IsRoot = projectName == "Core", Namespace = task.Namespace};
            var @class = new Class {ClassName = className};
            
            Console.WriteLine("Converting functions...");
            @class.NativeApis[fileName] = new NativeApiSet{Name = "I" + className};
            foreach (var function in parsed.Functions)
            {
                if (!function.IsPublicExport())
                {
                    continue;
                }
            }
        }

        public static Type TranslateType(CppType cppType, out UnmanagedType? marshalAs, bool nested = false)
        {
            // Early exit for primitive types
            if (cppType is CppPrimitiveType cppPrimitiveType)
            {
                marshalAs = cppPrimitiveType.Kind switch
                {
                    CppPrimitiveKind.Void => null,
                    CppPrimitiveKind.Bool => UnmanagedType.U1,
                    CppPrimitiveKind.WChar => null,
                    CppPrimitiveKind.Char => null,
                    CppPrimitiveKind.Short => null,
                    CppPrimitiveKind.Int => null,
                    CppPrimitiveKind.LongLong => null,
                    CppPrimitiveKind.UnsignedChar => null,
                    CppPrimitiveKind.UnsignedShort => null,
                    CppPrimitiveKind.UnsignedInt => null,
                    CppPrimitiveKind.UnsignedLongLong => null,
                    CppPrimitiveKind.Float => null,
                    CppPrimitiveKind.Double => null,
                    CppPrimitiveKind.LongDouble => null,
                    _ => null
                };
                return cppPrimitiveType.Kind switch
                {
                    CppPrimitiveKind.Void => new Type{Name = "void", OriginalName = "void"},
                    CppPrimitiveKind.Bool => new Type{Name = "bool", OriginalName = "bool"},
                    CppPrimitiveKind.WChar => new Type{Name = "char", OriginalName = "char"},
                    CppPrimitiveKind.Char => new Type{Name = "byte", OriginalName = "byte"},
                    CppPrimitiveKind.Short => new Type{Name = "short", OriginalName = "short"},
                    CppPrimitiveKind.Int => new Type{Name = "int", OriginalName = "int"},
                    CppPrimitiveKind.LongLong => new Type{Name = "long", OriginalName = "long"},
                    CppPrimitiveKind.UnsignedChar => new Type{Name = "byte", OriginalName = "byte"},
                    CppPrimitiveKind.UnsignedShort => new Type{Name = "ushort", OriginalName = "ushort"},
                    CppPrimitiveKind.UnsignedInt => new Type{Name = "uint", OriginalName = "uint"},
                    CppPrimitiveKind.UnsignedLongLong => new Type{Name = "ulong", OriginalName = "ulong"},
                    CppPrimitiveKind.Float => new Type{Name = "float", OriginalName = "float"},
                    CppPrimitiveKind.Double => new Type{Name = "double", OriginalName = "double"},
                    CppPrimitiveKind.LongDouble => new Type{Name = "double", OriginalName = "double"},
                    _ => null
                };
            }

            Type csType = null;

            // Pre-decode the type by extracting any const/pointer and get the element type directly
            DecodeSimpleType(cppType, out var isConst, out var isPointer, out var elementType);

            if (isPointer)
            {
                var pointedCSharpType = TranslateType(elementType, out _, true);
                pointedCSharpType.IndirectionLevels++;
                marshalAs = null;
                return pointedCSharpType;
            }
            
        }

        public static Type TranslateType(CppType type, out Count count)
        {
            count = null;
            switch (type.TypeKind)
            {
                case CppTypeKind.Primitive:
                {
                    return ((CppPrimitiveType) type).Kind switch
                    {
                        CppPrimitiveKind.Void => new Type{Name = "void"},
                        CppPrimitiveKind.Bool => new Type{Name = "bool"},
                        CppPrimitiveKind.WChar => new Type{Name = "char"},
                        CppPrimitiveKind.Char => new Type{Name = "byte"},
                        CppPrimitiveKind.Short => new Type{Name = "short"},
                        CppPrimitiveKind.Int => new Type{Name = "int"},
                        CppPrimitiveKind.LongLong => new Type{Name = "long"},
                        CppPrimitiveKind.UnsignedChar => new Type{Name = "byte"},
                        CppPrimitiveKind.UnsignedShort => new Type{Name = "ushort"},
                        CppPrimitiveKind.UnsignedInt => new Type{Name = "uint"},
                        CppPrimitiveKind.UnsignedLongLong => new Type{Name = "ulong"},
                        CppPrimitiveKind.Float => new Type{Name = "float"},
                        CppPrimitiveKind.Double => new Type{Name = "double"},
                        CppPrimitiveKind.LongDouble => new Type{Name = "double"},
                        _ => null
                    };
                }
                case CppTypeKind.Pointer:
                {
                    var ptrType = (CppPointerType) type;
                    var eType = TranslateType(ptrType.ElementType, out count);
                    eType.IndirectionLevels++;
                    return eType;
                }
                case CppTypeKind.Reference:
                {
                    var refType = (CppReferenceType) type;
                    var eType = TranslateType(refType.ElementType, out count);
                    eType.IsByRef = true;
                    return eType;
                }
                case CppTypeKind.Array:
                {
                    var arrType = (CppArrayType) type;
                    var eType = TranslateType(arrType.ElementType, out count);
                    eType.IndirectionLevels++;
                    count = new Count(arrType.Size);
                    return eType;
                }
                case CppTypeKind.Qualified:
                {
                    var qualType = (CppQualifiedType) type;
                    var eType = TranslateType(qualType.ElementType, out count);
                    if (qualType.Qualifier == CppTypeQualifier.Const)
                    {
                        eType.IsByRef = false;
                        eType.IsIn = true;
                    }

                    return eType;
                }
                case CppTypeKind.Function:
                {
                    break;
                }
                case CppTypeKind.Typedef:
                {
                    break;
                }
                case CppTypeKind.StructOrClass:
                {
                    break;
                }
                case CppTypeKind.Enum:
                {
                    break;
                }
                case CppTypeKind.TemplateParameterType:
                {
                    break;
                }
                case CppTypeKind.Unexposed:
                {
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static Parameter TranslateParameter(CppParameter arg)
        {
            throw new NotImplementedException();
        }
    }
}
