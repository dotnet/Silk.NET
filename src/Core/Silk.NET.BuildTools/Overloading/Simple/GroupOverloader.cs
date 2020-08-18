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
    public class GroupOverloader : ISimpleParameterOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter variant, Project core)
        {
            if (parameter.Type.OriginalGroup is null || core.Enums.All
                (x => x.Name != parameter.Type.OriginalGroup)/* || (parameter.Type.OriginalName != "GLenum" &&
                                                                  parameter.Type.OriginalName != "CLenum")*/)
            {
                variant = null;
                return false;
            }

            var t =
                new TypeSignatureBuilder(parameter.Type).WithName
                        (parameter.Type.OriginalGroup)
                    .Build();
            t.OriginalName = t.Name; // stop GLenum mapping
            variant =
                new ParameterSignatureBuilder(parameter).WithType
                    (
                        t
                    )
                    .Build()
                ;
            return true;
        }
    }
}
