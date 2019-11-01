using System;
using System.Collections.Generic;
using System.Linq;

namespace Vk.Generator
{
    public static class StructureHelpers
    {
        private static readonly HashSet<string> s_fixedCapableTypes = new HashSet<string>()
        {
            "byte", "short", "int", "long", "char", "sbyte", "ushort", "uint", "ulong", "float", "double"
        };

        public static void WriteStructure(CsCodeWriter cw, StructureDefinition structure, TypeNameMappings tnm, ConstantDefinition[] constants)
        {
            using (cw.PushBlock("public unsafe partial struct " + structure.Name))
            {
                foreach (var member in structure.Members)
                {
                    if (member.ElementCount > 1)
                    {
                        for (int i = 0; i < member.ElementCount; i++)
                        {
                            WriteMember(cw, tnm, member, "_" + i);
                        }
                    }
                    else if (member.ElementCountSymbolic != null)
                    {
                        var validConstant = constants.FirstOrDefault(cd => cd.Name == member.ElementCountSymbolic);
                        if (validConstant != null)
                            WriteMemberSymbolicCount(cw, tnm, member, constants);
                        else
                            WriteMember(cw, tnm, member, string.Empty);
                    }
                    else
                    {
                        WriteMember(cw, tnm, member, string.Empty);
                    }
                }

                if (HasAnyFieldWithSpecifiedValues(structure))
                {
                    // Add a helper property which fills in the structure type.
                    using (cw.PushBlock($"public static {structure.Name} New()"))
                    {
                        cw.WriteLine($"{structure.Name} ret = new {structure.Name}();");
                        foreach (var member in structure.Members.Where(ms => ms.LegalValues != null))
                        {
                            cw.WriteLine($"ret.{member.Name} = {member.Type}.{GetDefaultValueString(member.Type, member.LegalValues)};");
                        }
                        cw.WriteLine("return ret;");
                    }
                }
            }
        }

        private static string GetDefaultValueString(TypeSpec type, string legalValues)
        {
            string prefix = EnumHelpers.GetEnumNamePrefix(type.Name);
            string prettyName = EnumHelpers.GetPrettyEnumName(legalValues, prefix);
            return prettyName;
        }

        private static bool HasAnyFieldWithSpecifiedValues(StructureDefinition sd)
        {
            return sd.Members.Any(ms => ms.LegalValues != null);
        }

        private static void WriteMember(CsCodeWriter cw, TypeNameMappings tnm, MemberSpec member, string nameSuffix)
        {
            if (!string.IsNullOrEmpty(member.Comment))
            {
                cw.WriteLine($"///<summary>{member.Comment}</summary>");
            }

            cw.WriteLine($"public {member.Type.MapTypeSpec(tnm)} {Util.NormalizeFieldName(member.Name)}{nameSuffix};");
        }

        private static void WriteMemberSymbolicCount(CsCodeWriter cw, TypeNameMappings tnm, MemberSpec member, ConstantDefinition[] constants)
        {
            if (!CanUseFixed(member.Type.MapTypeSpec(tnm)))
            {
                int count = GetSymbolValue(member.ElementCountSymbolic, constants);
                for (int i = 0; i < count; i++)
                {
                    WriteMember(cw, tnm, member, "_" + i);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(member.Comment))
                {
                    cw.WriteLine($"///<summary>{member.Comment}</summary>");
                }

                string mappedSymbolicName = EnumHelpers.GetPrettyEnumName(member.ElementCountSymbolic, "VK_");
                cw.WriteLine($"public fixed {member.Type.MapTypeSpec(tnm)} {Util.NormalizeFieldName(member.Name)}[(int)VulkanNative.{mappedSymbolicName}];");
            }
        }

        private static int GetSymbolValue(string symbolName, ConstantDefinition[] constants)
        {
            return int.Parse(constants.Single(cd => cd.Name == symbolName).Value);
        }

        private static bool CanUseFixed(TypeSpec type)
        {
            return s_fixedCapableTypes.Contains(type.Name);
        }
    }
}
