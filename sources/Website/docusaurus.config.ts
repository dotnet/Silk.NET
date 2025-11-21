import {themes as prismThemes} from 'prism-react-renderer';
import type {Config} from '@docusaurus/types';
import type * as Preset from '@docusaurus/preset-classic';
import type { PluginOptions } from '@docusaurus/plugin-content-docs';

import remarkGithubAdmonitionsToDirectives from "remark-github-admonitions-to-directives";
import { visit } from 'unist-util-visit';
import path from 'node:path';
import { readFileSync, existsSync } from 'node:fs';
import tailwindPlugin from './plugins/tailwind-config.cjs';

// This runs in Node.js - Don't use client-side code here (browser APIs, JSX...)

const ABS_URL_REGEX = /^[a-zA-Z][a-zA-Z\d+\-.]*?:/;
function isAbsolute(url) {
    return path.isAbsolute(url) || ABS_URL_REGEX.test(url);
}

const rewriteSourceLinks = (options) => {
    let versions = {};
    let repoRoot = path.resolve("../../");
    let docsRoot = path.join(repoRoot, "docs");
    let versionedRoot = path.resolve("versioned_docs");
    if (existsSync("silkversions.json")) {
        versions = JSON.parse(readFileSync("silkversions.json", "utf8"))["versions"];
    }
    let versionNames = Object.keys(versions);
    const transformer = async (ast, vfile) => {
        let fileDirPath = path.resolve(path.dirname(vfile.path));
        visit(ast, 'link', (node) => {
            if (isAbsolute(node.url)) {
                return;
            }
            let versionRoot = null;
            let current = 0;
            for (var versionName in versionNames) {
                let candidate = path.join(versionedRoot, `version-${versionName}`);
                if (!path.relative(candidate, path.resolve(vfile.path)).startsWith("..")) {
                    versionRoot = candidate;
                    break;
                }
                current++;
                if (current == versionNames.length) {
                    if (!path.relative(docsRoot, path.resolve(vfile.path)).startsWith("..")) {
                        versionRoot = docsRoot;
                        break;
                    }
                }
            }
            if (versionRoot == null) {
                return;
            }
            let url = node.url;
            let hashtag = url.indexOf('#');
            if (hashtag !== -1) {
                url = url.substring(0, hashtag);
            }
            let resolvedUrlPath = path.join(fileDirPath, node.url);
            if (!path.relative(versionRoot, resolvedUrlPath).startsWith("..") ||
                existsSync(resolvedUrlPath))
            {
                return;
            }
            // console.log(resolvedUrlPath + " - " + node.url + " - " + fileDirPath + " - " + path.relative(docsRoot, resolvedUrlPath));
            let silk2Src = path.join(versionRoot, "..", "src");
            let silk2Rel = path.relative(silk2Src, resolvedUrlPath);
            if (!silk2Rel.startsWith("..")) {
                // console.log(`replaced ${silk2Rel}`);
                node.url = `https://github.com/dotnet/Silk.NET/blob/main/src/${silk2Rel}`
            }
            let silk3Root = path.join(versionRoot, "..");
            let silk3Rel = path.relative(silk3Root, resolvedUrlPath);
            if (!silk3Rel.startsWith("..")) {
                // console.log(`replaced ${silk3Rel}`);
                node.url = `https://github.com/dotnet/Silk.NET/blob/develop/3.0/${silk3Rel}`
            }
        });
    };
    return transformer;
};

// Used in the NUKE workflow
function addSilkVersionsJson(dict: PluginOptions): PluginOptions {
    if (existsSync("silkversions.json")) {
        let silkVersions = JSON.parse(readFileSync("silkversions.json", "utf8"));
        for (const [key, value] of Object.entries(silkVersions["versions"])) {
            dict.versions[key] = value;
        }
        if (typeof silkVersions["lastVersion"] === 'string') {
            dict.lastVersion = silkVersions["lastVersion"];
        }
        dict.editUrl = x => {
            if (typeof x.version !== "string") {
                return undefined;
            }
            if (x.version == dict["lastVersion"]) {
                // TODO this won't work if we do versioning outside of /docs (e.g. /api)
                if (x.version == "v2") {
                    return `https://github.com/dotnet/Silk.NET/edit/main/documentation/${x.docPath}`;
                } else {
                    return `https://github.com/dotnet/Silk.NET/edit/main/docs/${x.docPath}`;
                }
            } else if (x.version == silkVersions["nextVersion"]) {
                return `https://github.com/dotnet/Silk.NET/edit/develop/${dict.versions[x.version].path.substring(1)}.0/docs/${x.docPath}`;
            }
            return undefined;
        };
    }
    return dict;
}

// @ts-ignore
// @ts-ignore
const config: Config = {
    title: 'Silk.NET',
    tagline: 'Your one-stop-shop for high performance .NET graphics & compute.',
    favicon: 'img/favicon.ico',

    // Set the production url of your site here
    url: 'https://dotnet.github.io',

    // Set the /<baseUrl>/ pathname under which your site is served
    // For GitHub pages deployment, it is often '/<projectName>/'
    baseUrl: '/Silk.NET/',

    // GitHub pages deployment config.
    // If you aren't using GitHub pages, you don't need these.
    organizationName: 'dotnet', // Usually your GitHub org/user name.
    projectName: 'Silk.NET', // Usually your repo name.

    onBrokenLinks: 'warn',
    onBrokenMarkdownLinks: 'warn',

    // Even if you don't use internationalization, you can use this field to set
    // useful metadata like html lang. For example, if your site is Chinese, you
    // may want to replace "en" with "zh-Hans".
    i18n: {
        defaultLocale: 'en',
        locales: ['en'],
    },

    staticDirectories: ["static"],

    plugins: [
        tailwindPlugin
    ],

    presets: [
        [
            'classic',
            {
                docs: addSilkVersionsJson({
                    sidebarPath: '../../docs/sidebars.ts',
                    path: "../../docs",
                    routeBasePath: "docs",
                    exclude: ["README.md"],
                    beforeDefaultRemarkPlugins: [
                        remarkGithubAdmonitionsToDirectives,
                        rewriteSourceLinks
                    ],
                    // These properties are populated by addSilkVersionsJson
                    // lastVersion: "current",
                    versions: {},
                }),
                blog: {
                    showReadingTime: true,
                    feedOptions: {
                        type: ['rss', 'atom'],
                        xslt: true,
                    },
                    // Useful options to enforce blogging best practices
                    onInlineTags: 'throw',
                    onInlineAuthors: 'throw',
                    onUntruncatedBlogPosts: 'throw',
                    blogSidebarTitle: 'All posts',
                    blogSidebarCount: 'ALL',
                },
                theme: {
                    customCss: './src/css/custom.css',
                },
            } satisfies Preset.Options,
        ],
    ],
    themeConfig: {
        // Replace with your project's social card
        image: 'img/wallpaper.png',
        navbar: {
            // title: 'My Site',
            logo: {
                alt: 'Silk.NET Logo',
                src: 'img/logoh.svg',
            },
            items: [
                {
                    type: 'docSidebar',
                    sidebarId: 'docsSidebar',
                    position: 'left',
                    label: 'Documentation',
                },
                {to: '/blog', label: 'Blog', position: 'left'},
                {
                    type: 'docsVersionDropdown',
                    position: 'right',
                    dropdownItemsAfter: [],
                    dropdownActiveClassDisabled: true,
                    docsPluginId: "default"
                },
                {
                    href: 'https://github.com/dotnet/Silk.NET',
                    label: 'GitHub',
                    position: 'right',
                },
            ],
        },
        // TODO footer?
        prism: {
            theme: prismThemes.github,
            darkTheme: prismThemes.dracula,
            additionalLanguages: ["csharp"]
        },
    } satisfies Preset.ThemeConfig,
};

export default config;
