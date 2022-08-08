// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading;

public class NonKhrReturnTypeOverloader : IComplexFunctionOverloader
{
    public bool TryGetFunctionVariant(Function original, out ImplementedFunction varied, Project core)
    {
        throw new System.NotImplementedException();
    }
}
