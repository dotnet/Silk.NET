// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;

namespace Silk.NET.SilkTouch.Configuration
{
    public static class Config
    {
        /// <summary>
        /// Loads the given SilkTouch JSON Configuration into a dictionary of per-project configurations.
        /// </summary>
        /// <param name="json">The SilkTouch JSON Configuration.</param>
        /// <returns></returns>
        /// <exception cref="DataException"></exception>
        public static Dictionary<string, ProjectConfiguration> Load(string json)
            => JsonSerializer.Deserialize<Dictionary<string, ProjectConfiguration>>(json) ??
               throw new DataException("JSON deserialization of SilkTouch Configuration yielded null.");

        public static string Save(Dictionary<string, ProjectConfiguration> projects)
            => JsonSerializer.Serialize(projects);
    }
}
