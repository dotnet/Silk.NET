import {themes as prismThemes} from 'prism-react-renderer';
import type {Config} from '@docusaurus/types';
import type * as Preset from '@docusaurus/preset-classic';
import remarkGithubAdmonitionsToDirectives from "remark-github-admonitions-to-directives";
import { visit } from 'unist-util-visit';
import { pathToFileURL } from 'node:url';
import path from 'node:path';
import { readFileSync, existsSync } from 'node:fs';

// This runs in Node.js - Don't use client-side code here (browser APIs, JSX...)

const ABS_URL_REGEX = /^[a-zA-Z][a-zA-Z\d+\-.]*?:/;
function isAbsolute(url) {
    return path.isAbsolute(url) || ABS_URL_REGEX.test(url);
}

const rewriteSourceLinks = (options) => {
    const transformer = async (ast, vfile) => {
        let fileDirPath = path.resolve(path.dirname(vfile.path));
        let repoRoot = path.resolve("../../");
        let docsRoot = path.join(repoRoot, "docs");
        let silk2Src = path.join(repoRoot, "src");
        visit(ast, 'link', (node) => {
            if (isAbsolute(node.url)) {
                return;
            }
            let url = node.url;
            let hashtag = url.indexOf('#');
            if (hashtag !== -1) {
                url = url.substring(0, hashtag);
            }
            let resolvedUrlPath = path.join(fileDirPath, node.url);
            if (!path.relative(docsRoot, resolvedUrlPath).startsWith("..")) {
                return;
            }
            // console.log(resolvedUrlPath + " - " + node.url + " - " + fileDirPath + " - " + path.relative(docsRoot, resolvedUrlPath));
            let silk2Rel = path.relative(silk2Src, resolvedUrlPath);
            if (!silk2Rel.startsWith("..")) {
                // console.log(`replaced ${silk2Rel}`);
                node.url = `https://github.com/dotnet/Silk.NET/blob/main/src/${silk2Rel}`
            }
            let silk3Rel = path.relative(repoRoot, resolvedUrlPath);
            if (!silk3Rel.startsWith("..")) {
                // console.log(`replaced ${silk3Rel}`);
                node.url = `https://github.com/dotnet/Silk.NET/blob/develop/3.0/${silk3Rel}`
            }
        });
    };
    return transformer;
};

// Used in the NUKE workflow
function addSilkVersionsJson(dict: object): object {
    if (existsSync("silkversions.json")) {
        for (const [key, value] of Object.entries(JSON.parse(readFileSync("silkversions.json", "utf8")))) {
            dict[key] = value;
        }
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

    staticDirectories: ["static", "../../eng/submodules/silk.net-2.x/documentation/images"],

    presets: [
        [
            'classic',
            {
                docs: {
                    sidebarPath: '../../docs/sidebars.ts',
                    path: "../../docs",
                    routeBasePath: "docs",
                    // Please change this to your repo.
                    // Remove this to remove the "edit this page" links.
                    // editUrl:
                    //     'https://github.com/facebook/docusaurus/tree/main/packages/create-docusaurus/templates/shared/',
                    editUrl: x => {
                        // TODO basically change everything here once 3.0 is releasing
                        if (x.version == "v2") {
                            // TODO once v2 is no longer maintained, remove this.
                            return `https://github.com/dotnet/Silk.NET/edit/main/documentation/${x.docPath}`
                        }
                        // TODO handle more than 3.0
                        return `https://github.com/dotnet/Silk.NET/edit/develop/${x.version[1]}.0/docs/${x.docPath}`;
                    },
                    exclude: ["README.md"],
                    beforeDefaultRemarkPlugins: [
                        remarkGithubAdmonitionsToDirectives,
                        rewriteSourceLinks
                    ],
                    // TODO uncomment when v3 is released
                    // lastVersion: "current",
                    // @ts-ignore
                    versions: addSilkVersionsJson({}),
                },
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
