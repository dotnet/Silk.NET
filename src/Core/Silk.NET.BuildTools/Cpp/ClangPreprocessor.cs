// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using ClangSharp;
using ClangSharp.Interop;

namespace Silk.NET.BuildTools.Cpp
{
    public class ClangPreprocessor
    {
        public const string MacroPrefix = "SILKDOTNETMACROS__";
        private StringBuilder _fileContentsBuilder = new();
        private void VisitMacroDefinitionRecord(BindTask task, MacroDefinitionRecord macroDefinitionRecord)
        {
            if (task.ExcludedNativeNames.Contains(macroDefinitionRecord.Spelling))
            {
                return;
            }

            if (macroDefinitionRecord.IsFunctionLike)
            {
                return;
            }

            if (!Clang.ShouldVisit(macroDefinitionRecord, task, true))
            {
                return;
            }

            var translationUnitHandle = macroDefinitionRecord.TranslationUnit.Handle;
            var tokens = translationUnitHandle.Tokenize(macroDefinitionRecord.Extent).ToArray();

            if ((tokens[0].Kind == CXTokenKind.CXToken_Identifier) &&
                (tokens[0].GetSpelling(translationUnitHandle).CString == macroDefinitionRecord.Spelling))
            {
                if (tokens.Length == 1)
                {
                    // Nothing to do for simple macro definitions with no value
                    return;
                }

                var spelling = macroDefinitionRecord.Spelling;
                var macroName = $"{MacroPrefix}{spelling}";

                _fileContentsBuilder.AppendLine();
                
                _fileContentsBuilder.Append($"const auto {macroName} = ");

                var sourceRangeEnd = tokens[^1].GetExtent(translationUnitHandle).End;
                var sourceRangeStart = tokens[1].GetLocation(translationUnitHandle);

                var sourceRange = CXSourceRange.Create(sourceRangeStart, sourceRangeEnd);

                var macroValue = GetSourceRangeContents(translationUnitHandle, sourceRange);
                _fileContentsBuilder.Append(macroValue);

                _fileContentsBuilder.Append(';');
                _fileContentsBuilder.Append('\n');
            }
            else
            {
                Console.WriteLine
                (
                    $"Warning: Unsupported macro definition record: {macroDefinitionRecord.Name}. " +
                    $"Generated bindings may be incomplete. ({macroDefinitionRecord.Location})"
                );
            }
        }

        private string GetSourceRangeContents(CXTranslationUnit translationUnit, CXSourceRange sourceRange)
        {
            sourceRange.Start.GetFileLocation
                (out var startFile, out var startLine, out var startColumn, out var startOffset);
            sourceRange.End.GetFileLocation(out var endFile, out var endLine, out var endColumn, out var endOffset);

            if (startFile != endFile)
            {
                return string.Empty;
            }

            var fileContents = translationUnit.GetFileContents(startFile, out var fileSize);
            fileContents = fileContents.Slice(unchecked((int) startOffset), unchecked((int) (endOffset - startOffset)));

            return Encoding.UTF8.GetString(fileContents);
        }

        private void VisitPreprocessingDirective(BindTask task, PreprocessingDirective preprocessingDirective)
        {
            if (preprocessingDirective is InclusionDirective)
            {
                // Not currently handling inclusion directives
            }
            else if (preprocessingDirective is MacroDefinitionRecord macroDefinitionRecord)
            {
                VisitMacroDefinitionRecord(task, macroDefinitionRecord);
            }
            else
            {
                Console.WriteLine
                (
                    $"Warning: Unsupported preprocessing directive: '{preprocessingDirective.CursorKind}'. Generated bindings may be incomplete. ({preprocessingDirective.Location})"
                );
            }
        }

        private void VisitPreprocessedEntity(BindTask task, PreprocessedEntity preprocessedEntity)
        {
            if (preprocessedEntity is MacroExpansion)
            {
                // Not currently handling macro expansions
            }
            else if (preprocessedEntity is PreprocessingDirective preprocessingDirective)
            {
                VisitPreprocessingDirective(task, preprocessingDirective);
            }
            else
            {
                Console.WriteLine
                (
                    $"Warning: Unsupported preprocessed entity: '{preprocessedEntity.CursorKind}'. Generated bindings may be incomplete. ({preprocessedEntity.Location})"
                );
            }
        }

        public TranslationUnit WithPreprocessorMixins
        (
            TranslationUnit translationUnit,
            CXTranslationUnit_Flags flags,
            string filePath,
            string[] cliArgs,
            CXIndex index,
            BindTask task
        )
        {
            var translationUnitHandle = translationUnit.Handle;

            var file = translationUnitHandle.GetFile(filePath);
            var fileContents = translationUnitHandle.GetFileContents(file, out var size);

            _fileContentsBuilder.Append(Encoding.UTF8.GetString(fileContents));

            foreach (var cursor in translationUnit.TranslationUnitDecl.CursorChildren)
            {            
                if (cursor is PreprocessedEntity preprocessedEntity)
                {
                    VisitPreprocessedEntity(task, preprocessedEntity);
                }
            }

            var unsavedFileContents = _fileContentsBuilder.ToString();

            if (Generator.TestMode)
            {
                var outTo = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                Console.WriteLine($"!!! TEST MODE !!! Outputting preprocessor result to {outTo}");
                File.WriteAllText(outTo, unsavedFileContents);
            }
            
            _fileContentsBuilder.Clear();

            using var unsavedFile = CXUnsavedFile.Create(filePath, unsavedFileContents);
            ReadOnlySpan<CXUnsavedFile> unsavedFiles = stackalloc CXUnsavedFile[] {unsavedFile};

            flags &= ~CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
            var handle = CXTranslationUnit.Parse(index, filePath, cliArgs, unsavedFiles, flags);

            return TranslationUnit.GetOrCreate(handle);
        }
    }
}
