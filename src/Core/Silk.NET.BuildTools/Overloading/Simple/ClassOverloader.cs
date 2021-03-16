// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class ClassOverloader : ISimpleParameterOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter variant, Project core)
        {
            Struct s;
            if (parameter.Type.OriginalClass is null || (s = core.Structs.FirstOrDefault
                (x => x.NativeName == parameter.Type.OriginalClass)) is null)
            {
                variant = null;
                return false;
            }

            var t = new TypeSignatureBuilder(parameter.Type).WithName(s.Name).Build();
            t.OriginalName = t.Name; // stop GLenum mapping
            variant = new ParameterSignatureBuilder(parameter).WithType(t).Build();
            return true;
        }
    }
}
