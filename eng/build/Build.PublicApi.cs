// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Linq;
using Nuke.Common.IO;

partial class Build
{
    private void MoveUnshippedContentsToShipped()
    {
        foreach (var unshippedFile in RootDirectory.GlobFiles("**/PublicAPI.Unshipped.txt"))
        {
            var shippedFile = unshippedFile.Parent / "PublicAPI.Shipped.txt";
            if (!File.Exists(shippedFile))
            {
                // common.props should've made this file, so if it's not here then i'm guessing this isn't a
                // public api after all.
                continue;
            }

            var shippedLines = File.ReadAllLines(shippedFile).ToList();
            var unshippedLines = File.ReadAllLines(unshippedFile).ToList();
            for (var i = 0; i < unshippedLines.Count; i++)
            {
                var unshippedLine = unshippedLines[i];
                if (unshippedLine.StartsWith("//") || unshippedLine.StartsWith("#"))
                {
                    continue;
                }

                if (!shippedLines.Contains(unshippedLine))
                {
                    shippedLines.Add(unshippedLine);
                }

                unshippedLines.RemoveAt(i);
                i--; // so we don't skip the next element
            }

            File.WriteAllLines(unshippedFile, unshippedLines);
            File.WriteAllLines(shippedFile, shippedLines);
        }
    }
}
