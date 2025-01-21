import {themes as prismThemes} from 'prism-react-renderer';
import type {Config} from '@docusaurus/types';
import type * as Preset from '@docusaurus/preset-classic';
import remarkGithubAdmonitionsToDirectives from "remark-github-admonitions-to-directives";
import { visit } from 'unist-util-visit';
import { pathToFileURL } from 'node:url';
import path from 'node:path';
import { exec } from 'node:child_process';

function getSilk2Version(): string {
    let ver = "";
    exec(
        "git describe --tags HEAD --abbrev=0",
        { cwd: "../../eng/submodules/silk.net-2.x" },
        (_a, stdout, _b)=> ver = stdout
    );
    return ver;
}

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

    onBrokenLinks: 'throw',
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
                    exclude: ["README.md"],
                    beforeDefaultRemarkPlugins: [
                        remarkGithubAdmonitionsToDirectives,
                        rewriteSourceLinks
                    ],
                    // TODO uncomment when v3 is released
                    // lastVersion: "current",
                    versions: {
                        current: {
                            label: 'v3.0.0',
                            path: "v3"
                        },
                        "v2": {
                            label: getSilk2Version()
                        }
                    },
                },
                blog: {
                    showReadingTime: true,
                    feedOptions: {
                        type: ['rss', 'atom'],
                        xslt: true,
                    },
                    // Useful options to enforce blogging best practices
                    onInlineTags: 'warn',
                    onInlineAuthors: 'warn',
                    onUntruncatedBlogPosts: 'warn',
                },
                theme: {
                    customCss: './src/css/custom.css',
                },
            } satisfies Preset.Options,
        ],
    ],
    themeConfig: {
        // Replace with your project's social card
        image: 'img/docusaurus-social-card.jpg',
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
                },
                {
                    href: 'https://github.com/facebook/docusaurus',
                    label: 'GitHub',
                    position: 'right',
                },
            ],
        },
        // TODO footer?
        prism: {
            theme: prismThemes.github,
            darkTheme: prismThemes.dracula,
        },
    } satisfies Preset.ThemeConfig,
};

export default config;
