using System;

namespace Vk.Generator
{
    public class UnionHelpers
    {
        public static void WriteUnion(CsCodeWriter cw, TypeNameMappings tnm, StructureDefinition union)
        {
            cw.WriteLine("[StructLayout(LayoutKind.Explicit)]");
            using (cw.PushBlock("public partial struct " + union.Name))
            {
                foreach (var member in union.Members)
                {
                    if (member.ElementCount > 1)
                    {
                        for (int i = 0; i < member.ElementCount; i++)
                        {
                            int fieldSize = Util.GetTypeSize(member.Type.MapTypeSpec(tnm));
                            cw.WriteLine($"[FieldOffset({i * fieldSize})]");
                            WriteMember(cw, tnm, member, "_" + i);
                        }
                    }
                    else
                    {
                        cw.WriteLine("[FieldOffset(0)]");
                        WriteMember(cw, tnm, member, string.Empty);
                    }
                }
            }
        }

        private static void WriteMember(CsCodeWriter cw, TypeNameMappings tnm, MemberSpec member, string nameSuffix)
        {
            if (!string.IsNullOrEmpty(member.Comment))
            {
                cw.WriteLine($"///<summary>{member.Comment}</summary>");
            }

            cw.WriteLine($"public {member.Type.MapTypeSpec(tnm)} {Util.NormalizeFieldName(member.Name)}{nameSuffix};");
        }
    }
}