// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class RefOverloader : ISimpleParameterOverloader, IPostProcessingSimpleOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Profile profile)
        {
            if (parameter.Type.IsPointer)
            {
                //if its an opaque pointer, dont do ref overloads
                if(parameter.Type.IndirectionLevels == 1)
                {
                    foreach (var project in profile.Projects)
                    {
                        if(project.Value.Structs.FirstOrDefault(x => x.Name == parameter.Type.Name)?.IsOpaque ?? false)
                        {
                            varied = null;
                            return false;
                        }
                    }
                }

                varied = new ParameterSignatureBuilder(parameter).WithType
                    (
                        new TypeSignatureBuilder(parameter.Type)
                            .WithIndirectionLevel(parameter.Type.IndirectionLevels - 1)
                            .WithByRef(parameter.Flow != FlowDirection.In && parameter.Flow != FlowDirection.Out)
                            .WithIsIn(parameter.Flow == FlowDirection.In)
                            .WithIsOut(parameter.Flow == FlowDirection.Out)
                            .WithIsGenericType(parameter.Type.IsSinglePointerTo("void"))
                            .Build()
                    )
                    .Build();
                return true;
            }

            varied = null;
            return false;
        }
        
        // TODO ref returns once we know they work
        public void Finalize(Function function, Profile profile)
        {
            if (function.NativeName.ConstitutesVulkanOutOverload() &&
                (function.Parameters.LastOrDefault()?.Type.IsOut ?? false))
            {
                var last = function.Parameters.Last();
                var outStruct = profile.Projects["Core"].Structs.FirstOrDefault(x => x.Name == last.Type.Name);
                var outSType = outStruct?.Fields.FirstOrDefault();
                if (outSType is not null && outSType.Name == "SType" && outSType.DefaultAssignment is not null)
                {
                    function.Attributes.Add
                    (
                        new()
                        {
                            Name = "Inject",
                            Arguments = new()
                            {
                                "SilkTouchStage.Begin",
                                $"\"{last.Name} = new({outSType.DefaultAssignment});\""
                            }
                        }
                    );
                }
            }
        }
    }
}
