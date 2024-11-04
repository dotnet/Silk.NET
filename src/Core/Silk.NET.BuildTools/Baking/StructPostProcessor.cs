// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.Baking;

public static class StructPostProcessor
{
    public static void Process(Profile profile, BindTask task)
    {
        foreach (var proj in profile.Projects.Values)
        {
            foreach (var @struct in proj.Structs)
            {
                foreach (var field in @struct.Fields)
                {
                    if (field.Name == @struct.Name)
                    {
                        // Risky to do at this stage (e.g. what if a struct has a function that references it) but sue
                        // me, we'll fix it in 3.0.
                        field.Name = @struct.Fields.Any(x => x.Name == "Value") ? $"M{field.Name}" : "Value";
                    }
                }
            }
        }
    }
}
