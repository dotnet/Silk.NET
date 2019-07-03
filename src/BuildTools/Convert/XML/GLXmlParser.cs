// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Generator.Convert.XML
{
    /// <summary>
    /// A class which parses Khronos XML files and converts them to a friendlier format.
    /// </summary>
    internal class GLXmlParser
    {
        private static readonly Regex ExtensionRegex = new Regex
        (
            @"3DFX|(?!(?<=[1-4])D)[A-Z]{2,}$",
            RegexOptions.Compiled
        );

        /// <summary>
        /// Gets or sets a prefix that should be removed from methods and tokens in the XML files, e.g. "gl", "cl", etc.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Gets the enum prefix.
        /// </summary>
        public string EnumPrefix => Prefix.ToUpper() + "_";

        /// <summary>
        /// Gets the function prefix.
        /// </summary>
        public string FuncPrefix => Prefix;

        /// <summary>
        /// Parses Khronos XML files and converts them to a friendlier format.
        /// </summary>
        /// <param name="path">The path to the Khronos XML file.</param>
        /// <returns>A friendlier representation of the XML file.</returns>
        public IEnumerable<XElement> Parse(string path)
        {
            string[] contents = null;
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                using (var wb = new WebClient())
                {
                    var filename = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

                    try
                    {
                        wb.DownloadFile(path, filename);
                    }
                    catch (WebException e)
                    {
                        if (e.Message == "The remote server returned an error: (401) Unauthorized.")
                        {
                            Console.WriteLine(e.Message);
                            Console.Write("Username: ");
                            var username = Console.ReadLine();
                            Console.Write("Password: ");
                            var password = Console.ReadLine();

                            wb.UseDefaultCredentials = true;
                            wb.Credentials = new NetworkCredential(username, password);
                            wb.DownloadFile(path, filename);
                        }
                    }

                    contents = File.ReadAllLines(filename);
                    File.Delete(filename);
                }
            }
            else
            {
                // The file is on disk, just read it directly
                contents = File.ReadAllLines(path);
            }

            return Parse(contents);
        }

        /// <summary>
        /// Trims the prefix from the given name.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <returns>The trimmed name.</returns>
        public string TrimName(string name)
        {
            if (name.StartsWith(EnumPrefix))
            {
                return name.Remove(0, EnumPrefix.Length);
            }

            if (name.StartsWith(FuncPrefix))
            {
                return name.Remove(0, FuncPrefix.Length);
            }

            return name;
        }

        /// <summary>
        /// Parses Khronos XML lines and converts them to a friendlier format.
        /// </summary>
        /// <param name="lines">The contents of the XML file.</param>
        /// <returns>A friendlier representation of the XML file.</returns>
        public IEnumerable<XElement> Parse(string[] lines)
        {
            var input = XDocument.Parse(string.Join(" ", lines));

            var elements = new SortedDictionary<string, XElement>();
            foreach (var e in ParseEnums(input).Concat(ParseFunctions(input)))
            {
                var name = e.Attribute("name").Value;
                var version = (e.Attribute("version") ?? new XAttribute("version", string.Empty)).Value;
                var key = name + version;
                if (!elements.ContainsKey(key))
                {
                    elements.Add(key, e);
                }
                else
                {
                    elements[key].Add(e.Elements());
                }
            }

            return elements.Values;
        }

        /// <summary>
        /// Gets all API names from the given XML element.
        /// </summary>
        /// <param name="feature">The XML element.</param>
        /// <returns>All API names in this XML element.</returns>
        /// <exception cref="NotSupportedException">The feature type is unknown.</exception>
        private static string[] GetApiNames(XElement feature)
        {
            string[] apinames = null;
            switch (feature.Name.LocalName)
            {
                case "feature":
                {
                    var v = feature.Attribute("api") != null ? feature.Attribute("api").Value : "gl|glcore";
                    if (v == "gl")
                    {
                        // Add all gl features to both compatibility (gl) and core (glcore) profiles.
                        // Deprecated features will be explicitly marked or removed when parsing
                        // the <remove> elements.
                        v = "gl|glcore";
                    }

                    apinames = v.Split('|');
                    break;
                }

                case "extension":
                {
                    var v = feature.Attribute("supported") != null ? feature.Attribute("supported").Value : "gl|glcore";
                    apinames = v.Split('|');
                    break;
                }

                case "group":
                {
                    apinames = new[] {"gl", "glcore", "gles1", "gles2"};
                    break;
                }

                default:
                {
                    throw new NotSupportedException("Unknown feature type");
                }
            }

            return apinames;
        }

        private IEnumerable<XElement> ParseEnums(XDocument input)
        {
            var features = input.Root.Elements("feature");
            var extensions = input.Root.Elements("extensions").Elements("extension");
            var enumerations = input.Root.Elements("enums").Elements("enum");
            var groups = input.Root.Elements("groups").Elements("group");
            var apis = new SortedDictionary<string, XElement>();

            // Build a list of all available tokens.
            // Some tokens have a different value between GL and GLES,
            // so we need to keep separate lists for each API. Tokens
            // that are common go to the "default" list.
            var enums = new Dictionary<string, SortedDictionary<string, string>>();
            foreach (var e in enumerations)
            {
                var api = (e.Attribute("api") ?? new XAttribute("api", "default")).Value;
                if (!enums.ContainsKey(api))
                {
                    enums.Add(api, new SortedDictionary<string, string>());
                }

                enums[api]
                    .Add
                    (
                        TrimName(e.Attribute("name").Value),
                        e.Attribute("value").Value
                    );
            }

            // Now we go through each feature, extension and group
            // and construct the actual enumerations. Each API
            // gets its own list of enumerations. Common enums are
            // explicitly repeated. For example:
            // <extension name="GL_AMD_performance_monitor" supported="gl|gles2">
            // means that its enums must go to both the gl and gles2 APIs.
            
            // Note that we no longer use the <group> definitions in the Khronos spec, though all of the functionality
            // is there to add them in should they mature again.
            // see also: https://github.com/KhronosGroup/OpenGL-Registry/issues/280
            // see also: https://github.com/KhronosGroup/OpenGL-Registry/issues/109
            // see also: https://github.com/KhronosGroup/OpenGL-Registry/pull/273
            // see also: https://discordapp.com/channels/521092042781229087/587346162802229298/590211773399826438
            foreach (var feature in
                features.Concat(extensions)
//                  .Concat(groups)
                    .OrderBy(f => TrimName(f.Attribute("name").Value)))
            {
                var version = feature.Attribute("number") != null ? feature.Attribute("number").Value : null;
                var apinames = GetApiNames(feature);

                // An enum may belong to one or more APIs.
                // Add it to all relevant ones.
                foreach (var apiname in apinames)
                {
                    var key = apiname + version;
                    if (!apis.ContainsKey(key))
                    {
                        apis.Add
                        (
                            key,
                            new XElement
                            (
                                "api",
                                new XAttribute("name", apiname),
                                string.IsNullOrEmpty(version) ? null : new XAttribute("version", version)
                            )
                        );
                    }

                    var api = apis[key];

                    var enum_name = TrimName(feature.Attribute("name").Value);

                    var e = new XElement("enum", new XAttribute("name", enum_name), new XAttribute("for", feature.Attribute("name").Value));
                    foreach (var token in
                        feature.Elements("enum")
                            .Concat(feature.Elements("require").Elements("enum")))
                    {
                        var token_name = TrimName(token.Attribute("name").Value);
                        var token_value =
                            enums.ContainsKey(apiname) && enums[apiname].ContainsKey(token_name)
                                ? enums[apiname][token_name]
                                : enums["default"].ContainsKey(token_name)
                                    ? enums["default"][token_name]
                                    : string.Empty;

                        if (!string.IsNullOrEmpty(token_value))
                        {
                            var @enum =
                                new XElement
                                (
                                    "token",
                                    new XAttribute("name", token_name),
                                    new XAttribute("value", token_value)
                                );
                            e.Add(@enum);
                        }
                        else
                        {
                            Trace.WriteLine($"Token {token_name} is not defined.");
                        }
                    }

                    api.Add(e);
                }

                foreach (var api in apis.Values)
                {
                    var apiname = api.Attribute("name").Value;

                    // Mark deprecated enums
                    foreach (var token in feature.Elements("remove").Elements("enum"))
                    {
                        var token_name = TrimName(token.Attribute("name").Value);
                        var deprecated =
                            api.Elements("enum")
                                .Elements("token")
                                .FirstOrDefault(t => t.Attribute("name").Value == token_name);

                        if (deprecated != null)
                        {
                            if (apiname == "glcore")
                            {
                                // These tokens do not exist in the glcore profile, remove them
                                api.Elements("enum")
                                    .Elements("token")
                                    .First(t => t.Attribute("name").Value == token_name)
                                    .Remove();
                            }
                            else
                            {
                                // These tokens exist in all other profiles, mark them as deprecated.
                                deprecated.Add(new XAttribute("deprecated", version));
                            }
                        }
                    }
                }
            }

            return apis.Values;
        }

        /// <summary>
        /// Parses all functions from the given XML document.
        /// </summary>
        /// <param name="input">The XML document.</param>
        /// <returns>Friendlier representations of the function signatures contained within the document.</returns>
        private IEnumerable<XElement> ParseFunctions(XDocument input)
        {
            // Go through the list of commands and build Silk.NET functions out of those.
            // Every function has a number of attributes that define which API version and
            // category (see above) they belong to.
            // It also includes information about the return type and parameters. These
            // are then parsed by the binding generator in order to create the necessary
            // overloads for correct use.
            var features = input.Root.Elements("feature");
            var extensions = input.Root.Elements("extensions").Elements("extension");
            var apis = new SortedDictionary<string, XElement>();

            // First we build a list of all available commands,
            // including their parameters and return types.
            var commands = new SortedDictionary<string, XElement>();
            foreach (var command in input.Root.Elements("commands").Elements("command"))
            {
                commands.Add(FunctionName(command), command);
            }

            // First, we go through all available features and extensions and build a list
            // of commands that belong to them.
            // We will then use this information to "decorate" our bindings with
            // information about versioning, extension support and deprecation.
            foreach (var feature in features.Concat(extensions))
            {
                var category = TrimName(feature.Attribute("name").Value);
                var apinames = GetApiNames(feature);

                var version =
                    (feature.Attribute("number") != null ? feature.Attribute("number").Value : string.Empty)?
                    .Split('|');

                var i = -1;
                foreach (var apiname in apinames)
                {
                    i++;

                    var cmd_category = category;
                    var cmd_version = version.Length > i ? version[i] : version[0];

                    var key = apiname + cmd_version;
                    if (!apis.ContainsKey(key))
                    {
                        apis.Add
                        (
                            key,
                            new XElement
                            (
                                "api",
                                new XAttribute("name", apiname),
                                new XAttribute("version", cmd_version)
                            )
                        );
                    }

                    var api = apis[key];

                    foreach (var command in feature.Elements("require").Elements("command"))
                    {
                        var cmd_name = TrimName(command.Attribute("name").Value);
                        var cmd_extension =
                            ExtensionRegex.Match(cmd_name).Value ??
                            (feature.Name == "extension" ? category.Substring(0, category.IndexOf("_")) : "Core");
                        if (string.IsNullOrEmpty(cmd_extension))
                        {
                            cmd_extension = "Core";
                        }

                        var function = TranslateCommand(commands[cmd_name]);
                        function.Add(new XAttribute("category", cmd_category));
                        function.Add(new XAttribute("extension", cmd_extension));
                        if (!string.IsNullOrEmpty(cmd_version))
                        {
                            function.Add(new XAttribute("version", cmd_version));
                        }

                        Merge(api, function);
                    }
                }

                i = -1;
                foreach (var api in apis.Values)
                {
                    i++;
                    var apiname = api.Attribute("name").Value;
                    var cmd_version = version.Length > i ? version[i] : version[0];

                    // Mark all deprecated functions as such
                    foreach (var command in feature.Elements("remove").Elements("command"))
                    {
                        var deprecated_name = TrimName(command.Attribute("name").Value);
                        var deprecated =
                            api.Elements("function")
                                .FirstOrDefault(t => t.Attribute("name").Value == deprecated_name);

                        if (deprecated != null)
                        {
                            if (apiname == "glcore")
                            {
                                // These tokens do not exist in the glcore profile, remove them
                                api.Elements("function")
                                    .First(t => t.Attribute("name").Value == deprecated_name)
                                    .Remove();
                            }
                            else
                            {
                                // These tokens exist in all other profiles, mark them as deprecated.
                                deprecated.Add(new XAttribute("deprecated", cmd_version));
                            }
                        }
                    }
                }
            }

            return apis.Values;
        }

        /// <summary>
        /// Adds the function to the API.
        /// </summary>
        /// <param name="api">The API.</param>
        /// <param name="function">The function to add to the API.</param>
        /// <exception cref="InvalidOperationException">The function has multiple extensions.</exception>
        private void Merge(XElement api, XElement function)
        {
            var type = function.Name.LocalName;
            var name = function.Attribute("name").Value;
            var f = api.Elements(type).FirstOrDefault(p => p.Attribute("name").Value == name);
            if (f != null)
            {
                f.SetAttributeValue
                (
                    "category",
                    string.Join("|", f.Attribute("category").Value, function.Attribute("category").Value)
                );
                f.SetAttributeValue
                (
                    "version",
                    (f.Attribute("version") ?? function.Attribute("version"))?.Value
                );

                // Sanity check: one function cannot belong to two different extensions
                if (f.Attribute("extension").Value != function.Attribute("extension").Value)
                {
                    throw new InvalidOperationException("Different extensions for the same function");
                }
            }
            else
            {
                api.Add(function);
            }
        }

        /// <summary>
        /// Converts the given function XML to the friendlier format.
        /// </summary>
        /// <param name="command">The function XML.</param>
        /// <returns>A friendlier representation of the function XML.</returns>
        private XElement TranslateCommand(XElement command)
        {
            var function = new XElement("function");

            var cmd_name = FunctionName(command);
            var name = new XAttribute("name", cmd_name);

            var returns = new XElement
            (
                "returns",
                new XAttribute
                (
                    "type",
                    FunctionParameterType(command.Element("proto"))
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Replace("String *", "String")
                        .Trim()
                )
            );

            foreach (var parameter in command.Elements("param"))
            {
                var param = FunctionParameterType(parameter);

                var p = new XElement("param");
                var pname = new XAttribute("name", parameter.Element("name").Value);
                var type = new XAttribute
                (
                    "type",
                    param
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Trim()
                );

                var count = parameter.Attribute("len") != null
                    ? new XAttribute("count", parameter.Attribute("len").Value)
                    : null;

                var flow = new XAttribute
                (
                    "flow",
                    param.Contains("*") && !param.Contains("const") ? "out" : "in"
                );

                p.Add(pname, type, flow);
                if (count != null)
                {
                    p.Add(count);
                }

                function.Add(p);
            }

            function.Add(name);
            function.Add(returns);
            return function;
        }

        /// <summary>
        /// Gets the trimmed function name from the XML element.
        /// </summary>
        /// <param name="e">The XML element.</param>
        /// <returns>The trimmed name.</returns>
        private string FunctionName(XElement e)
        {
            return TrimName(e.Element("proto").Element("name").Value);
        }

        /// <summary>
        /// Parse the C-like proto element.
        /// </summary>
        /// <param name="e">The proto element.</param>
        /// <returns>The type signature represented by the proto element.</returns>
        private string FunctionParameterType(XElement e)
        {
            // Parse the C-like <proto> element. Possible instances:
            // Return types:
            // - <proto>void <name>glGetSharpenTexFuncSGIS</name></proto>
            //   -> <returns>void</returns>
            // - <proto group="String">const <ptype>GLubyte</ptype> *<name>glGetString</name></proto>
            //   -> <returns>String</returns>
            // Note: group attribute takes precedence if it exists. This matches the old .spec file format.
            // Parameter types:
            // - <param><ptype>GLenum</ptype> <name>shadertype</name></param>
            //   -> <param name="shadertype" type="GLenum" />
            // - <param len="1"><ptype>GLsizei</ptype> *<name>length</name></param>
            //   -> <param name="length" type="GLsizei" count="1" />
            var proto = e.Value;
            var name = e.Element("name").Value;
            var group = e.Attribute("group");

            var ret = proto.Remove(proto.LastIndexOf(name)).Trim();

            if (group != null)
            {
                var words = ret.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (words[0] == "struct" || words[0] == "const")
                {
                    words[1] = group.Value;
                }
                else
                {
                    words[0] = group.Value;
                }

                ret = string.Join(" ", words);
            }

            return ret;
        }

        /// <summary>
        /// Gets the given attribute from the given command contained within the given categories.
        /// </summary>
        /// <param name="categories">The categories.</param>
        /// <param name="cmdName">The command name.</param>
        /// <param name="attribute">The attribute name.</param>
        /// <returns>The attribute.</returns>
        private static XAttribute Lookup(IDictionary<string, XElement> categories, string cmdName, string attribute)
        {
            if (categories.ContainsKey(cmdName))
            {
                return categories[cmdName].Attribute(attribute);
            }

            return null;
        }
    }
}
