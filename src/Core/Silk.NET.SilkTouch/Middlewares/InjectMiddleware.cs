// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.Core.Attributes;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch {
    public static partial class Middlewares {
        private static readonly Regex _substitutionRegex = new Regex(@"%\$((?<result>RESULT)|PARAM\((?<pname>[a-zA-Z_]{1}[a-zA-Z0-9_]*)\))\$%", RegexOptions.Compiled);
        public static void InjectMiddleware(ref IMarshalContext ctx, Action next) {
            var context = ctx;
            var injectDatas = ctx.MethodSymbol.GetAttributes().Where(
                x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, context.Compilation.GetTypeByMetadataName(typeof (InjectAttribute).FullName))
            );

            foreach(var injectData in injectDatas) {
                var injectPoint = (SilkTouchStage) injectData.ConstructorArguments[0].Value!;
                var code = (string) injectData.ConstructorArguments[1].Value!;
                ctx.AddSideEffectToStage(injectPoint, ctx => {
                    if (injectPoint == SilkTouchStage.End) {
                        var substitutions = _substitutionRegex.Match(code);
                        if (substitutions.Success) {
                            var codeBuilder = new StringBuilder();
                            var start = 0;
                            string ? resultStr = null;
                            Dictionary < string, string > ? pValues = null;
                            while (substitutions.Success) {
                                string ? substitution = null;
                                if (substitutions.Groups["result"].Success) {
                                    if (ctx.ResultVariable.HasValue) {
                                        // Cache for multiple-substitution
                                        if (resultStr is null) {
                                            resultStr = ParenthesizedExpression(ctx.ResolveVariable(ctx.ResultVariable.Value).Value)
                                                .NormalizeWhitespace()
                                                .ToFullString();
                                        }
                                        substitution = resultStr;
                                    }
                                } else {
                                    var parameterName = substitutions.Groups["pname"].Value;

                                    // Create parameter lookup dictionary first time we see the substitution.
                                    if (pValues is null) {
                                        pValues = ctx.MethodSymbol.Parameters
                                            .Select((p, i) => (
                                                Name: p.Name,
                                                Value: ParenthesizedExpression(ctx.ResolveVariable(ctx.ParameterVariables[i]).Value)
                                                    .NormalizeWhitespace()
                                                    .ToFullString()))
                                            .ToDictionary(t => t.Name, t => t.Value);
                                    }

                                    if (pValues.TryGetValue(parameterName, out
                                            var value)) {
                                        substitution = value;
                                    }
                                }

                                if (substitution != null) {
                                    codeBuilder.Append(code.Substring(start, substitutions.Index - start))
                                        .Append(substitution);
                                    start = substitutions.Index + substitutions.Length;
                                }
                                substitutions = substitutions.NextMatch();
                            }

                            if (start > 0) {
                                if (start < code.Length) codeBuilder.Append(code.Substring(start));
                                code = codeBuilder.ToString();
                            }
                        }
                    }

                    return ParseStatement(code);
                });
            }

            ctx.TransitionTo(SilkTouchStage.Begin);
            next();
            ctx.TransitionTo(SilkTouchStage.End);
        }
    }
}