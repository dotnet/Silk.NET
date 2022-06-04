// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;

namespace Silk.NET.BuildTools.Baking;

public static class EnumPostProcessor
{
    public static void Process(Profile profile)
    {
        AddNoneFlags(profile);
    }

    private static void AddNoneFlags(Profile profile)
    {
        foreach (var @enum in from project in profile.Projects.Values
                 from @enum in project.Enums
                 where @enum.Attributes.Any(x => x.Name is "System.Flags" or "Flags") &&
                       @enum.Tokens.All(x => x.Name is not "None")
                 select @enum)
        {
            @enum.Tokens.Insert(0, new Token { Name = "None", Value = "0" });
        }
    }
}
