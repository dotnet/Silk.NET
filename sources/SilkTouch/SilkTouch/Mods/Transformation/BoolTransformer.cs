// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// A transformer transforming parameters that are recognised to be akin to booleans to use the <c>MaybeBool</c> type.
/// </summary>
public class BoolTransformer(IOptionsSnapshot<TransformFunctions.Configuration> options)
    : IFunctionTransformer
{
    /// <inheritdoc />
    public void Transform(
        MethodDeclarationSyntax current,
        ITransformationContext ctx,
        Action<MethodDeclarationSyntax> next
    )
    {
        var ogCurrent = current;
        var cfg = options.Get(ctx.JobKey);
        string? retBoolScheme = null;
        TypeSyntax? newRetType = null;
        var retNative = current.GetNativeReturnTypeName() ?? current.ReturnType.ToString();
        if (
            (current.ReturnType.IsInteger() && cfg.IntReturnsMaybeBool)
            || cfg.BoolTypes.TryGetValue(retNative, out retBoolScheme)
            || (retNative == "bool" && current.ReturnType.ToString().Trim() != "bool") // stdbool.h, hopefully...
        )
        {
            newRetType = MaybeBoolUtils.MaybeBoolType(current.ReturnType, retBoolScheme);
            current = current.WithReturnType(newRetType);
        }

        List<ParameterSyntax>? @params = null;
        for (var i = 0; i < current.ParameterList.Parameters.Count; i++)
        {
            var param = current.ParameterList.Parameters[i];
            var paramNative = param.GetNativeTypeName() ?? param.Type?.ToString();
            string? paramBoolScheme = null;
            if (
                paramNative is not null
                && param.Type is not null
                && (
                    cfg.BoolTypes.TryGetValue(paramNative, out paramBoolScheme)
                    || (paramNative == "bool" && param.Type.ToString().Trim() != "bool") // stdbool.h, hopefully...
                )
            )
            {
                var newType = MaybeBoolUtils.MaybeBoolType(param.Type, paramBoolScheme);
                (@params ??= [.. current.ParameterList.Parameters])[i] = param.WithType(newType);
            }
        }

        if (@params is not null)
        {
            current = current.WithParameterList(
                current.ParameterList.WithParameters(SeparatedList(@params))
            );
        }

        if (!ReferenceEquals(current, ogCurrent))
        {
            current =
                current.CastFunctionCalls(
                    ctx.Original!,
                    newRetType,
                    current.ParameterList.Parameters
                ) as MethodDeclarationSyntax
                ?? current;
        }

        next(current);
    }
}
