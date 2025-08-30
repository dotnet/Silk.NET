// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A <see cref="Function"/> with an implementation.
    /// </summary>
    public class ImplementedFunction
    {
        /// <summary>
        /// Do not use, for serialization only.
        /// </summary>
        [Obsolete("Do not use, for serialization only.", true)]
        public ImplementedFunction() {}
        
        /// <summary>
        /// Creates a new ImplementedFunction.
        /// </summary>
        /// <param name="function">The function signature.</param>
        /// <param name="sb">The code for the implemented function.</param>
        /// <param name="base">The base function.</param>
        /// <param name="isUnsafe">Whether or not this function should be marked as unsafe.</param>
        public ImplementedFunction(Function function, StringBuilder sb, Function @base, bool isUnsafe = true)
        {
            Signature = function;
            using var sr = new StringReader(sb.ToString());
            string line;
            var lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }

            Body = lines.ToArray();
            IsUnsafe = isUnsafe;
            Base = @base;
        }

        /// <summary>
        /// The function signature.
        /// </summary>
        public Function Signature { get; set; }
        
        /// <summary>
        /// The base function.
        /// </summary>
        public Function Base { get; set; }
        
        /// <summary>
        /// The body of the function.
        /// </summary>
        public string[] Body { get; set; }
        
        /// <summary>
        /// Whether or not this function is unsafe.
        /// </summary>
        public bool IsUnsafe { get; set; }
    }
}
