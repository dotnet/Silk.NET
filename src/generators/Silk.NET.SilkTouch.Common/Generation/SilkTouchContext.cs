// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.SilkTouch.Configuration;

namespace Silk.NET.SilkTouch.Generation
{
    public sealed class SilkTouchContext
    {
        // TODO make constructors because .NET Standard 2.0 is crap and we can't have init properties.
        
        // Public Properties
        /// <summary>
        /// The syntax trees contained within the current project.
        /// </summary>
        public IEnumerable<CSharpSyntaxTree> SyntaxTrees { get; set; } = Enumerable.Empty<CSharpSyntaxTree>();
        
        /// <summary>
        /// The 
        /// </summary>
        public ProjectConfiguration Configuration { get; set; }
        
        // Internal Properties
        internal List<(string FileNameHint, string Content)> Outputs { get; } = new();
        internal List<Diagnostic> Diagnostics { get; } = new();
        
        // Public Methods
        public void EmitOutput(string fileNameHint, string content)
            => Outputs.Add((fileNameHint, content));
        
        public void EmitDiagnostic(Diagnostic diagnostic) => Diagnostics.Add(diagnostic);

        public (List<(string FileNameHint, string Content)> Outputs, List<Diagnostic>) GetResult()
            => (Outputs, Diagnostics);
    }
}
