// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class GroupOverloader : ISimpleParameterOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter variant, Profile profile)
        {
            if (parameter.Type.OriginalGroup is null || profile.Projects["Core"].Enums.All
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
