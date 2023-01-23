// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading;

/// <summary>
/// Implemented by simple overloads that do extra postprocessing at the end, such as adding an attribute.
/// </summary>
public interface IPostProcessingSimpleOverloader
{
    /// <summary>
    /// Post processes the overloaded function.
    /// </summary>
    /// <param name="function">The function.</param>
    /// <param name="profile">The profile.</param>
    void Finalize(Function function, Profile profile);
}
