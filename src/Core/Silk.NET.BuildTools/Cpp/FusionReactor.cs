// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Structs;
using Attribute = Silk.NET.BuildTools.Common.Attribute;

namespace Silk.NET.BuildTools.Cpp
{
    public static class FusionReactor
    {
        public static void ReactStructs(IReadOnlyList<Struct> structs)
        {
            // reverse iteration, nested structs are usually parsed after the parent struct.
            for (var i = structs.Count - 1; i >= 0; i--)
            {
                var @struct = structs[i];
                for (var j = 0; j < @struct.Fields.Count; j++)
                {
                    var field = @struct.Fields[j];
                    if (field.Attributes.IsBuildToolsIntrinsic(out var args) && args[0] == "$FUSECPP")
                    {
                        field.Attributes.RemoveAll(x => x.Name == "BuildToolsIntrinsic");
                        var nestedStruct = structs.FirstOrDefault(x => x.NativeName == args[1]);
                        if (nestedStruct is null)
                        {
                            Console.WriteLine("Warning: Fusion reactor failed to fuse nested unnamed anonymous struct.");
                            Console.WriteLine($"    Failed to find struct with native name \"{args[1]}\"");
                            Console.WriteLine($"Removing field \"{field.Name}\" with type \"{field.Type.Name}\"...");
                            @struct.Fields.RemoveAt(j);
                            continue;
                        }
                        
                        foreach (var nestedField in nestedStruct.Fields)
                        {
                            if (nestedField.Type.IsIn || nestedField.Type.IsOut || nestedField.Type.IsByRef)
                            {
                                Console.WriteLine
                                (
                                    "Warning: Fusion reactor failed to fuse nested unnamed anonymous struct field."
                                );
                                Console.WriteLine($"    Can't fuse ref-like fields: \"{@struct.Name}.{nestedField.Name}\"");
                                Console.WriteLine("Skipping this field, fusion will continue for other fields...");
                                continue;
                            }
                            
                            if (nestedField.Count is not null)
                            {
                                // TODO I opted not to do fixed buffers in the initial iteration because there's a lot
                                // TODO of fix-ups that we do, and the implementation would be entirely different
                                Console.WriteLine
                                (
                                    "Warning: Fusion reactor failed to fuse nested unnamed anonymous struct field."
                                );
                                Console.WriteLine($"    Multi-count fields currently can't be fused.");
                                Console.WriteLine("Skipping this field, fusion will continue for other fields...");
                                continue;
                            }

                            if (@struct.Fields.Any(x => x.Name == nestedField.Name))
                            {
                                Console.WriteLine
                                (
                                    "Warning: Fusion reactor failed to fuse nested unnamed anonymous struct field."
                                );
                                Console.WriteLine($"    A field named \"{nestedField.Name}\" already exists.");
                                Console.WriteLine("Skipping this field, fusion will continue for other fields...");
                                continue;
                            }

                            if (nestedField.Count is not null)
                            {
                                Console.WriteLine
                                (
                                    "Warning: Fusion reactor failed to fuse nested unnamed anonymous struct field."
                                );
                                Console.WriteLine($"    Multi-count fields currently can't be fused (\"{nestedField.Name}\")");
                                Console.WriteLine("Skipping this field, fusion will continue for other fields...");
                            }
                            
                            @struct.Fields.Add(new Field
                            {
                                Name = nestedField.Name,
                                Attributes = new List<Attribute>
                                {
                                    new Attribute
                                    {
                                        Name = "BuildToolsIntrinsic",
                                        Arguments = new List<string>
                                        {
                                            "$FUSEFLD",
                                            field.Name,
                                            nestedField.Name
                                        }
                                    }
                                },
                                NativeName = $"{field.NativeName}.{nestedField.NativeName}",
                                NativeType = nestedField.NativeType,
                                Type = nestedField.Type
                            });
                        }
                    }
                }
            }
        }
    }
}
