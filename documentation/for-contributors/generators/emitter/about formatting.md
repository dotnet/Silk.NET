# About Formatting

This document is just a sink for all things related formatting.
If your code is acting up and spitting out unreadable garbage, or you want to improve code style - READ THIS FRIST!

## Indentation

The emitter implements a very basic system based on 4 members: `Indent()`, `Outdent()`, `NewLine`, `Indentation`

-   `Indent()`: After this call indentation will be more
-   `Outdent()`: After this call indentation will be less
-   `NewLine`: Put this when you want to go to the next line. It automatically handles putting the right amount of spaces after.
-   `Indentation`: only use this if absolutely necessary. It's only there as a safety net

The common pattern is something like this:

```cs
Indent()
var members = memberSymbols.Select(s => {
    VisitSomething(s);
    if (_syntax is not SomeSyntax memberSyntax)
        throw Something;
    ClearState();
    memberSyntax = memberSyntax.WithLeadingTrivia(NewLine);
    return memberSyntax;
}).ToArray();
Outdent();

// use members somehow
```

Note the `.ToArray()` this forces execution to happen during the indent/outdent scope.

## On Trivia

Prefer using leading trivia over trailing trivia. This is because leading trivia is impossible to leak outside of the symbol you are working on, while trailing trivia easily does this. While sometimes inconvinient because the parent symbol you have no control over leaks it's trivia into your symbol, it's still preferable - had the parent symbol followed this advice it couldn't leak into your symbol right now. Do us all a favor.

Similar things apply at the micro level too - use leading trivia on braces over trailing trivia on identifiers. This improves the editing experience when adding extra things later and massively improves the reviewers understanding, as there are simply fewer changes.
