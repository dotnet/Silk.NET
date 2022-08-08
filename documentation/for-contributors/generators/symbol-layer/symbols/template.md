(This is a template for other symbol docs)

# My Symbol

Checklist:

-   [ ] Write a short description of what this symbol does here.
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
