// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Generator.Common;
using Generator.Convert.Construction;
using Generator.Convert.XML;
using Newtonsoft.Json;

namespace Generator.Convert
{
    /// <summary>
    /// A class for reading and creating profiles from XML.
    /// </summary>
    public class ProfileConstructor : IDisposable
    {
        /// <summary>
        /// Gets or sets the input XML files.
        /// </summary>
        public List<string> InputFiles { get; set; }

        /// <summary>
        /// Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets the prefix to be removed from function and enum names.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the JSON should be pretty-printed.
        /// </summary>
        public bool Pretty { get; set; }

        /// <summary>
        /// Gets or sets a list of type maps to use.
        /// </summary>
        public List<Dictionary<string, string>> TypeMaps { get; set; }

        /// <inheritdoc />
        public void Dispose()
        {
        }

        /// <summary>
        /// Reads and parses the XML input files, and returns the constructed profiles.
        /// </summary>
        /// <returns>The profiles constructed from the XML files.</returns>
        public IEnumerable<Profile> ReadProfiles()
        {
            Console.WriteLine("Reading raw profiles...");
            var parser = new GLXmlParser {Prefix = Prefix};
            var sigs = InputFiles.Select(x => parser.Parse(x)).ToList();

            // Merge any duplicate enum entries (in case an enum is declared
            // in multiple files with different entries in each file).
            var entries = MergeDuplicates(sigs);
            SortTokens(entries);
            return Task.WhenAll(sigs.SelectMany(s => s).Select(ReadProfileAsync)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously reads a profile from the given XML block.
        /// </summary>
        /// <param name="api">The XML block.</param>
        /// <returns>An asynchronous task.</returns>
        private Task<Profile> ReadProfileAsync(XElement api)
        {
            var profile = new Profile
            {
                Name = api.Attribute("name")?.Value,
                Version = api.Attribute("version")?.Value ?? string.Empty,
                TypeMaps = TypeMaps ?? new List<Dictionary<string, string>>() // NRE
            };
            var elements = api.Elements()
                .OrderBy(s => s.Name.LocalName)
                .ThenBy(s => (string) s.Attribute("value") ?? string.Empty)
                .ThenBy(s => (string) s.Attribute("name") ?? string.Empty)
                .ThenBy(s => (string) s.Attribute("version") ?? string.Empty)
                .ThenBy(s => (string) s.Attribute("extension") ?? string.Empty)
                .ToList();
            var enums = elements.Where(x => x.Name == "enum");
            var functions = elements.Where(x => x.Name == "function");
            profile.ParseXml(enums, functions);
            return Task.FromResult(profile);
        }

        /// <summary>
        /// Reads and constructs profiles from the XML files, and writes the resultant profiles to the output folder.
        /// </summary>
        public void WriteProfiles()
        {
            if (!Directory.Exists(OutputFolder))
            {
                Directory.CreateDirectory(OutputFolder);
            }

            foreach (var profile in ReadProfiles())
            {
                using
                (
                    var outStream = OutputFolder == null
                        ? Console.Out
                        : new StreamWriter
                        (
                            Path.Combine
                            (
                                OutputFolder,
                                "api-" + profile.Name +
                                (!string.IsNullOrEmpty(profile.Version) ? "-" + profile.Version : null) + ".json"
                            )
                        )
                )
                {
                    outStream.Write
                    (
                        JsonConvert.SerializeObject(profile, Pretty ? Formatting.Indented : Formatting.None)
                    );
                    outStream.Flush();
                }
            }
            
            Console.WriteLine("Raw profiles have been successfully converted.");
        }

        /// <summary>
        /// Sorts enum tokens by their names.
        /// </summary>
        /// <param name="entries">The enum tokens to sort.</param>
        private static void SortTokens(Dictionary<string, XElement> entries)
        {
            foreach (var e in entries)
            {
                if (e.Value.Name.LocalName != "enum")
                {
                    continue;
                }

                var tokens = e.Value.Elements()
                    .OrderBy(t => (string) t.Attribute("name"))
                    .ToList();
                e.Value.RemoveNodes();
                e.Value.Add(tokens);
            }
        }

        /// <summary>
        /// Merges duplicate enum signatures.
        /// </summary>
        /// <param name="sigs">The signatures to merge, if duplicates are found.</param>
        /// <returns>The merged signatures.</returns>
        private static Dictionary<string, XElement> MergeDuplicates(IEnumerable<IEnumerable<XElement>> sigs)
        {
            var entries = new Dictionary<string, XElement>();
            foreach (var e in sigs.SelectMany(s => s))
            {
                var name = (string) e.Attribute("name") ?? string.Empty;
                var version = (string) e.Attribute("version") ?? string.Empty;
                var key = name + version;
                if (entries.ContainsKey(key))
                {
                    var p = entries[key];
                    var curTokens = p.Nodes().ToList();
                    p.RemoveNodes();
                    p.Add(curTokens.Concat(e.Nodes()).Distinct(new EnumTokenComparer()));
                }
                else
                {
                    entries.Add(key, e);
                }
            }

            return entries;
        }
    }
}
