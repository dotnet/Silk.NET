# Visitor

See [here](../symbol-layer/symbol-visitor.md) for details on how the base symbol visitor works.

To Transform our internal symbol layer to C# code a visitor (`CSharpEmitter.Visitor`) is used.

## State

To communicate produced syntax nodes with the levels above the current one the state variables are used.
Therefore its important to enshure that this state is clear at all times. (Using `AssertClearState` & `ClearState`)

## Depth First

In general we try to push symbols down as far as possible to avoid code duplication and increase testable surface area.
The best example of this that instead of creating identifier tokens / identifier name syntax nodes inline (which would be very easy) we visit the identifier, letting the `VisitIdentifier` function create those, and then take what we need, using a pattern like

```cs
VisitIdentifier(structSymbol.Identifier);
if (_syntaxToken is not { } identifierToken)
    throw new InvalidOperationException("Some Identifier was not visited correctly");
ClearState();
```

when a token is required, or

```cs
VisitIdentifier(fieldSymbol.Type.Identifier);
if (_syntax is not IdentifierNameSyntax typeIdentifierSyntax)
    throw new InvalidOperationException("Some Identifier was not visited correctly");
ClearState();
```

when a syntax node is required.

## Trivia

The visitor is intended to produce "valid" code, that means it can be formatted using .ToFullString and the resulting code is valid and can be parsed back by roslyn.
In addition we try to avoid elastic trivia wherever possible. For performance reasons we don't want to normalize our trivia / syntax internally, but elastic trivia would be thrown away when doing so, therefore we try to avoid generating elastic trivia in the first place.
Integration tests should test for elastic trivia, although their primary purpose is to check the resulting formatted string.
