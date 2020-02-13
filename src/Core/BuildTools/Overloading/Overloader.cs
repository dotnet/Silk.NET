// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class Overloader
    {
        public static IFunctionOverloader[] EarlyOverloaders { get; } =
        {
            new GroupOverloader(), // in order of priority
            new StringOverloader()
        };
        
        public static Function GetEarlyVariant(Function function, Project core)
        {
            var parameters = new List<Parameter>();
            var returnType = function.ReturnType;
            parameters.AddRange(function.Parameters);
            var parametersVaried = false;
            var returnTypeVaried = false;
            for (var i = 0; i < parameters.Count; i++)
            {
                foreach (var earlyOverloader in EarlyOverloaders)
                {
                    if (earlyOverloader.TryCreateVariant(parameters[i], out var variant, core))
                    {
                        parametersVaried = true;
                        parameters[i] = variant;
                        break;
                    }
                }
            }
            
            foreach (var earlyOverloader in EarlyOverloaders)
            {
                if (earlyOverloader.TryCreateVariant(returnType, out var variant, core))
                {
                    returnTypeVaried = true;
                    returnType = variant;
                    break;
                }
            }

            return new FunctionSignatureBuilder(function)
                .WithParameters(parameters)
                .WithReturnType(returnType)
                .WithName(returnTypeVaried && !parametersVaried ? function.Name + "S" : function.Name)
                .Build();
        }
    }
}
