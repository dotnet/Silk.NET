# Symbols

This document / folder is for tracking all the available symbols, and documenting what creation of one entails.

## Relation to SymbolVisitor

In general each symbol listed below should have a corresponding method `VisitMySymbol` the only exception being `UnresolvedTypeReference` as only few visitors should ever interact with it.

## List

(Order alphabetically please!)

Parent Symbols (Unlisted, abstract):
| Name | See Also |
| ---- | -------- |
| MemberSymbol | |
| Symbol | |
| TypeReference | [here](../type-references.md) |
| TypeSymbol | |
| MethodSymbol |

| Name                         | Symbol Layer File                                                                                | Symbol Layer Tests                                                                                                    | Emitter Tests                                                                                      |
| ---------------------------- | ------------------------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| ClassSymbol                  | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/ClassSymbol.cs)                  | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/ClassSymbolTests.cs)                  | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/ClassSymbolTests.cs)                  |
| ExternalTypeReference        | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/ExternalTypeReference.cs)        | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/ExternalTypeReferenceTests.cs)        | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/ExternalTypeReferenceTests.cs)        |
| FunctionPointerTypeReference | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/FunctionPointerTypeReference.cs) | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/FunctionPointerTypeReferenceTests.cs) | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/FunctionPointerTypeReferenceTests.cs) |
| FieldSymbol                  | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/FieldSymbol.cs)                  | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/FieldTests.cs)                        | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/EmitterFieldTests.cs)                 |
| IdentifierSymbol             | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/IdentifierSymbol.cs)             | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/IdentifierTests.cs)                   | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/IdentifierSymbolTests.cs)             |
| InternalTypeReference        | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/InternalTypeReference.cs)        | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/InternalTypeReferenceTests.cs)        | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/InternalTypeReferenceTests.cs)        |
| NamespaceSymbol              | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/NamespaceSymbol.cs)              | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/NamespaceTests.cs)                    | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/EmitterNamespaceTests.cs)             |
| PointerTypeReference         | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/PointerTypeReference.cs)         | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/PointerTypeReferenceTests.cs)         | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/PointerTypeReferenceTests.cs)         |
| StaticExternalMethodSymbol   | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/StaticExternalMethodSymbol.cs)   | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/StaticExternalMethodSymbolTests.cs)   | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/StaticExternalMethodSymbolTests.cs)   |
| StructSymbol                 | [here](../../../../../src/generators/Silk.NET.SilkTouch.Symbols/StructSymbol.cs)                 | [here](../../../../../tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/StructTests.cs)                       | [here](../../../../../tests/Silk.NET.SilkTouch.Emitter.Tests/EmitterStructTests.cs)                |
| UnresolvedTypeReference      | [here](src/generators/Silk.NET.SilkTouch.Symbols/UnresolvedTypeReference.cs)                     | [here](tests/Silk.NET.SilkTouch.Symbols.Tests/SymbolVisitorTests/UnresolvedTypeReferenceTests.cs)                     | -                                                                                                  |

## How to create a symbol

Checklist:

-   [ ] Write a short description of what this symbol does in the above list.
-   [ ] Add the symbol to Silk.NET.SilkTouch.Symbols
-   [ ] Add a partial of SymbolVisitor to below the definition, and add visiting method in there.
-   [ ] Call the new visiting method either from
    -   The root Visit(Symbol) method, this should rarely be needed
    -   The parent's visit method
-   [ ] Add Tests to Silk.NET.SilkTouch.Symbols.Tests for
    -   [ ] The type being visited with it's own visiting method
    -   [ ] The type being visited with it's parent (not needed if this is a new root type, with no parent)
    -   [ ] Each part being visited correctly. Only shallowly check this, don't check parts of parts.
-   [ ] Handle symbol in Silk.NET.SilkTouch.Emitter
-   [ ] Add Tests to Silk.NET.SilkTouch.Emitter.Tests
    -   [ ] Transforming a sample Symbol matching a specific string
    -   [ ] Other tests, this is highly dependend on how complex the C# output looks like
    -   [ ] More is better!
-   [ ] You're done. Feel free to use the symbol wherever needed. Prefer to add usages in a separate PR.
