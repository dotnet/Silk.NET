using System;

namespace Vk.Generator
{
    public static class ConstantHelpers
    {
        public static void WriteAllConstants(CsCodeWriter cw, TypeNameMappings tnm, ConstantDefinition[] constants)
        {
            using (cw.PushBlock("public static partial class VulkanNative"))
            {
                foreach (ConstantDefinition constant in constants)
                {
                    if (constant.Comment != null)
                    {
                        cw.WriteLine($"///<summary>{constant.Comment}</summary>");
                    }

                    cw.WriteLine($"public const {GetCSharpNameForConstantType(constant.Type)} {EnumHelpers.GetPrettyEnumName(constant.Name, "VK_")} = {NormalizeValue(constant.Value)};");
                }
            }

            cw.WriteLine();

            using (cw.PushBlock("public static partial class RawConstants"))
            {
                foreach (ConstantDefinition constant in constants)
                {
                    if (constant.Comment != null)
                    {
                        cw.WriteLine($"///<summary>{constant.Comment}</summary>");
                    }

                    cw.WriteLine($"public const {GetCSharpNameForConstantType(constant.Type)} {constant.Name} = VulkanNative.{EnumHelpers.GetPrettyEnumName(constant.Name, "VK_")};");
                }
            }
        }

        public static void WriteConstant(CsCodeWriter cw, TypeNameMappings tnm, ConstantDefinition constant)
        {
        }

        public static string GetCSharpNameForConstantType(ConstantDefinition.ConstantType type)
        {
            switch (type)
            {
                case ConstantDefinition.ConstantType.UInt32:
                    return "uint";
                case ConstantDefinition.ConstantType.UInt64:
                    return "ulong";
                case ConstantDefinition.ConstantType.Float32:
                    return "float";
                default:
                    throw new InvalidOperationException("Illegal ConstantType: " + type);
            }
        }

        private static string NormalizeValue(string value)
        {
            return value.Replace("ULL", "UL");
        }
    }
}