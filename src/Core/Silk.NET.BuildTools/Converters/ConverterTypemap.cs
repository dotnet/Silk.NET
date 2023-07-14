// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Silk.NET.BuildTools.Converters;

/// <summary>
/// A typemap produced & consumed within the profile converter.
/// </summary>
public record ConverterTypemap
(
    Dictionary<string, string> Typemap,
    string? ProfileName
);
