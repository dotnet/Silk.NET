// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class ClassOverloader : ISimpleParameterOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter variant, Profile profile)
        {
            Struct s;
            if (parameter.Type.OriginalClass is null || (s = profile.Projects["Core"].Structs.FirstOrDefault
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
