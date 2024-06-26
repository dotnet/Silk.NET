// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading;

namespace Silk.NET.BuildTools.Bind
{
    public static class ClassWriter
    {
        /// <summary>
        /// Create a class that extends SearchPathContainer.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write the object for.</param>
        /// <param name="file">The file to write the class to.</param>
        public static void WriteNameContainer(this Project project, Profile profile, string file, BindState task)
        {
            if (File.Exists(file) || task.Task.Controls.Contains("no-name-container"))
            {
                return;
            }

            using var sw = new StreamWriter(file) {NewLine = "\n"};
            
            sw.WriteLine(task.LicenseText());
            sw.WriteLine("using Silk.NET.Core.Loader;");
            sw.WriteLine();
            sw.WriteLine($"namespace {task.Task.Namespace}{project.Namespace}");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine($"    /// Contains the library name of {profile.Name}.");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine($"    internal class {task.Task.NameContainer.ClassName} : SearchPathContainer");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string[] Linux => new[] {{ \"{task.Task.NameContainer.Linux}\" }};");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string[] MacOS => new[] {{ \"{task.Task.NameContainer.MacOS}\" }};");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string[] Android => new[] {{ \"{task.Task.NameContainer.Android}\" }};");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string[] IOS => new[] {{ \"{task.Task.NameContainer.IOS}\" }};");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string[] Windows64 => new[] {{ \"{task.Task.NameContainer.Windows64}\" }};");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string[] Windows86 => new[] {{ \"{task.Task.NameContainer.Windows86}\" }};");
            sw.WriteLine("    }");
            sw.WriteLine("}");
        }

        /// <summary>
        /// Write mixed-mode (partial) classes.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write mixed-mode classes for.</param>
        /// <param name="folder">The folder to store the generated classes in.</param>
        public static void WriteMixedModeClasses(this Project project, Profile profile, string folder, string manualFolder, BindState task)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            foreach (var @class in project.Classes)
            {
                if ((@class.NativeApis.Values.Sum
                    (x => x.Functions.Count) + @class.Functions.Count + @class.Constants.Count) == 0)
                {
                    Console.WriteLine($"Warning: No functions or constants, writing of class \"{@class.ClassName}\" " +
                                      $"skipped...");
                    continue;
                }
            
                if (project.IsRoot)
                {
                    var allFunctions = @class.NativeApis.SelectMany
                            (x => x.Value.Functions)
                        .RemoveDuplicatesFast(GetSignature)
                        .ToArray();

                    static string GetSignature(Function func) 
                        => func.ToString(null, returnType: false, appendAttributes: false);

                    var sw = new StreamWriter(Path.Combine(folder, $"{@class.ClassName}.gen.cs")) {NewLine = "\n"};
                    StreamWriter? swOverloads = null;
                    sw.Write(task.LicenseText());
                    sw.WriteCoreUsings();
                    sw.WriteLine();
                    sw.WriteLine("#pragma warning disable 1591");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {task.Task.Namespace}{project.Namespace}");
                    sw.WriteLine("{");
                    sw.Write($"    public unsafe partial class {@class.ClassName}");
                    if (allFunctions.Any())
                    {
                        sw.WriteLine(" : NativeAPI");
                    }
                    else
                    {
                        sw.WriteLine();
                    }

                    sw.WriteLine("    {");
                    foreach (var constant in @class.Constants)
                    {
                        sw.WriteLine($"        [NativeName(\"Type\", \"{constant.Type.OriginalName}\")]");
                        sw.WriteLine($"        [NativeName(\"Name\", \"{constant.NativeName}\")]");
                        sw.WriteLine
                        (
                            $"        public const {constant.Type} {constant.Name} = " +
                            $"unchecked(({constant.Type}) {constant.Value});"
                        );
                    }

                    sw.WriteLine();
                    foreach (var function in allFunctions)
                    {
                        AddInjectionAttributes(function, task);
                        
                        if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                        {
                            sw.WriteLine($"#if {function.PreprocessorConditions}");
                        }

                        using (var sr = new StringReader(function.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in function.GetAttributes())
                        {
                            sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }


                        if (function.Convention != CallingConvention.Cdecl)
                        {
                            sw.WriteLine
                            (
                                $"        [NativeApi(EntryPoint = \"{function.NativeName}\", " +
                                $"Convention = CallingConvention.{function.Convention})]"
                            );
                        }
                        else
                        {
                            sw.WriteLine($"        [NativeApi(EntryPoint = \"{function.NativeName}\")]");
                        }

                        using (var sr = new StringReader(function.ToString(null, true, true)))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                        {
                            sw.WriteLine("#endif");
                        }

                        sw.WriteLine();
                    }

                    foreach (var overload in Overloader.GetOverloads(allFunctions, profile.Projects["Core"], task.Task.OverloaderExclusions, true))
                    {
                        var sw2u = overload.Signature.Kind == SignatureKind.PotentiallyConflictingOverload
                            ? swOverloads ??= CreateOverloadsFile(folder, @class.ClassName, false)
                            : sw;
                        if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                        {
                            sw2u.WriteLine($"#if {overload.Base.PreprocessorConditions}");
                        }

                        if (sw2u == swOverloads)
                        {
                            overload.Signature.Parameters.Insert
                            (
                                0,
                                new Parameter
                                {
                                    Name = "thisApi",
                                    Type = new Common.Functions.Type {Name = @class.ClassName, IsThis = true}
                                }
                            );
                        }

                        using (var sr = new StringReader(overload.Signature.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw2u.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in overload.Signature.GetAttributes())
                        {
                            sw2u.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }

                        sw2u.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe, @static: sw2u == swOverloads).TrimEnd(';')}");
                        sw2u.WriteLine("        {");
                        foreach (var line in overload.Body)
                        {
                            sw2u.WriteLine($"            {line}");
                        }

                        sw2u.WriteLine("        }");
                        
                        if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                        {
                            sw2u.WriteLine($"#endif");
                        }
                        
                        sw2u.WriteLine();
                    }

                    if (allFunctions.Any())
                    {
                        sw.WriteLine();
                        sw.WriteLine($"        public {@class.ClassName}(INativeContext ctx)");
                        sw.WriteLine("            : base(ctx)");
                        sw.WriteLine("        {");
                        sw.WriteLine("        }");
                    }

                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.WriteLine();
                    FinishOverloadsFile(swOverloads);
                    sw.Flush();
                    sw.Dispose();
                    if (!File.Exists(Path.Combine(manualFolder, $"{@class.ClassName}.cs")) && allFunctions.Any())
                    {
                        sw = new StreamWriter(Path.Combine(manualFolder, $"{@class.ClassName}.cs")) {NewLine = "\n"};
                        sw.WriteCoreUsings();
                        sw.WriteLine("using static Silk.NET.Core.Attributes.ExtensionAttribute;");
                        sw.WriteLine();
                        sw.WriteLine("#pragma warning disable 1591");
                        sw.WriteLine();
                        sw.WriteLine($"namespace {task.Task.Namespace}{project.Namespace}");
                        sw.WriteLine("{");
                        sw.WriteLine($"    public partial class {@class.ClassName}");
                        sw.WriteLine("    {");
                        sw.WriteLine($"        public static {@class.ClassName} GetApi()");
                        sw.WriteLine("        {");
                        if (!(task.Task.NameContainer is null))
                        {
                            sw.WriteLine
                            (
                                $"             return new(CreateDefaultContext" +
                                $"(new {task.Task.NameContainer.ClassName}().GetLibraryNames()));"
                            );
                        }
                        else
                        {
                            sw.WriteLine("             throw new NotImplementedException();");
                        }
                        sw.WriteLine("        }");
                        sw.WriteLine();
                        sw.WriteLine("        public bool TryGetExtension<T>(out T ext)");
                        sw.WriteLine($"            where T:NativeExtension<{@class.ClassName}>");
                        sw.WriteLine("        {");
                        sw.WriteLine("             throw new NotImplementedException();");
                        sw.WriteLine("        }");
                        sw.WriteLine();
                        sw.WriteLine("        public override bool IsExtensionPresent(string extension)");
                        sw.WriteLine("        {");
                        sw.WriteLine("            throw new NotImplementedException();");
                        sw.WriteLine("        }");
                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                        sw.WriteLine();
                        sw.Flush();
                        sw.Dispose();
                    }

                    if (!(task.Task.NameContainer is null))
                    {
                        project.WriteNameContainer
                            (profile, Path.Combine(manualFolder, $"{task.Task.NameContainer.ClassName}.cs"), task);
                    }
                }
                else
                {
                    foreach (var (key, i) in @class.NativeApis)
                    {
                        var name = i.Name.Substring(1);
                        var sw = new StreamWriter(Path.Combine(folder, $"{name}.gen.cs")) {NewLine = "\n"};
                        StreamWriter? swOverloads = null;
                        sw.Write(task.LicenseText());
                        sw.WriteCoreUsings();
                        sw.WriteLine($"using {profile.Projects["Core"].GetNamespace(task.Task)};");
                        sw.WriteLine("using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;");
                        sw.WriteLine();
                        sw.WriteLine("#pragma warning disable 1591");
                        sw.WriteLine();
                        sw.WriteLine($"namespace {task.Task.ExtensionsNamespace}{project.Namespace}");
                        sw.WriteLine("{");
                        sw.WriteLine($"    [Extension(\"{key}\")]");
                        sw.Write($"    public unsafe partial class {name}");
                        if (i.Functions.Any())
                        {
                            sw.WriteLine($" : NativeExtension<{@class.ClassName}>");
                        }
                        else
                        {
                            sw.WriteLine();
                        }

                        sw.WriteLine("    {");
                        sw.WriteLine($"        public const string ExtensionName = \"{key}\";");
                        foreach (var function in i.Functions)
                        {
                            var coreProject = profile.Projects["Core"];

                            if (!task.Task.Controls.Contains("allow-redefinitions") && coreProject.Classes.Any(x => x.NativeApis.Any(x => x.Value.Functions.Any(x => x.NativeName == function.NativeName 
                                && x.Parameters.Select(x => x.Type.OriginalName).SequenceEqual(function.Parameters.Select(x => x.Type.OriginalName))))))
                            {
                                continue;
                            }
                            
                            AddInjectionAttributes(function, task);

                            if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                            {
                                sw.WriteLine($"#if {function.PreprocessorConditions}");
                            }

                            using (var sr = new StringReader(function.Doc))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.WriteLine($"        {line}");
                                }
                            }

                            foreach (var attr in function.GetAttributes())
                            {
                                sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                            }

                            if (function.Convention != CallingConvention.Cdecl)
                            {
                                sw.WriteLine
                                (
                                    $"        [NativeApi(EntryPoint = \"{function.NativeName}\", " +
                                    $"Convention = CallingConvention.{function.Convention})]"
                                );
                            }
                            else
                            {
                                sw.WriteLine($"        [NativeApi(EntryPoint = \"{function.NativeName}\")]");
                            }

                            using (var sr = new StringReader(function.ToString(null, true, true)))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.WriteLine($"        {line}");
                                }
                            }
                            
                            if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                            {
                                sw.WriteLine($"#endif");
                            }

                            sw.WriteLine();
                        }

                        var overloads = Overloader.GetOverloads(i.Functions, profile.Projects["Core"], task.Task.OverloaderExclusions);
                        foreach (var overload in overloads)
                        {
                            var coreProject = profile.Projects["Core"];

                            if (!task.Task.Controls.Contains("allow-redefinitions") && coreProject.Classes.Any(x => x.NativeApis.Any(x => x.Value.Functions.Any(x => x.NativeName == overload.Signature.NativeName))))
                            {
                                continue;
                            }

                            var sw2u = overload.Signature.Kind == SignatureKind.PotentiallyConflictingOverload
                                ? swOverloads ??= CreateOverloadsFile(folder, name, true)
                                : sw;
                            if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                            {
                                sw2u.WriteLine($"#if {overload.Base.PreprocessorConditions}");
                            }

                            if (sw2u == swOverloads)
                            {
                                overload.Signature.Parameters.Insert
                                (
                                    0,
                                    new Parameter
                                    {
                                        Name = "thisApi",
                                        Type = new Common.Functions.Type {Name = name, IsThis = true}
                                    }
                                );
                            }

                            using (var sr = new StringReader(overload.Signature.Doc))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw2u.WriteLine($"        {line}");
                                }
                            }

                            foreach (var attr in overload.Signature.GetAttributes())
                            {
                                sw2u.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                            }

                            sw2u.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe, @static: sw2u == swOverloads).TrimEnd(';')}");
                            sw2u.WriteLine("        {");
                            foreach (var line in overload.Body)
                            {
                                sw2u.WriteLine($"            {line}");
                            }

                            sw2u.WriteLine("        }");
                            
                            if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                            {
                                sw2u.WriteLine($"#endif");
                            }

                            sw2u.WriteLine();
                        }

                        if (i.Functions.Any())
                        {
                            sw.WriteLine($"        public {name}(INativeContext ctx)");
                            sw.WriteLine("            : base(ctx)");
                            sw.WriteLine("        {");
                            sw.WriteLine("        }");
                        }

                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                        sw.WriteLine();
                        sw.Flush();
                        sw.Dispose();
                        FinishOverloadsFile(swOverloads);
                    }
                }
            }

            StreamWriter CreateOverloadsFile(string folder, string @class, bool isExtension)
            {
                var ns = isExtension ? task.Task.ExtensionsNamespace : task.Task.Namespace;
                var swOverloads = new StreamWriter(Path.Combine(folder, $"{@class}Overloads.gen.cs")) {NewLine = "\n"};
                swOverloads.Write(task.LicenseText());
                swOverloads.WriteCoreUsings();
                swOverloads.WriteLine();
                swOverloads.WriteLine("#pragma warning disable 1591");
                swOverloads.WriteLine();
                swOverloads.WriteLine($"namespace {ns}{project.Namespace}");
                swOverloads.WriteLine("{");
                swOverloads.WriteLine($"    public static class {@class}Overloads");
                swOverloads.WriteLine("    {");
                return swOverloads;
            }

            static void FinishOverloadsFile(StreamWriter? swOverloads)
            {
                swOverloads?.WriteLine("    }");
                swOverloads?.WriteLine("}");
                swOverloads?.WriteLine();
                swOverloads?.Flush();
                swOverloads?.Dispose();
            }
        }

        private static void AddInjectionAttributes(Function function, BindState state)
        {
            foreach (var injection in state.Task.OutputOpts.Injections ?? Enumerable.Empty<Injection>())
            {
                if (injection.FunctionNativeNames.Contains(function.NativeName))
                {
                    function.Attributes.Add
                    (
                        new()
                        {
                            Name = "Inject", Arguments = new()
                            {
                                $"(SilkTouchStage) {(int) injection.Stage}",
                                $"\"{injection.Code.Replace("\"", "\\\"").Replace("\\", "\\\\")}\""
                            }
                        }
                    );
                }
            }
        }
    }
}
