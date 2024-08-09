const {themes} = require('prism-react-renderer');
const lightCodeTheme = themes.github;
const darkCodeTheme = themes.dracula;


(module.exports = {

  title: 'Silk.NET',
  tagline: 'Your all in one high-performance .NET graphics library',

  url: 'https://dotnet.github.io',
  baseUrl: 'Silk.NET',

  onBrokenLinks: 'warn', //'throw',
  onBrokenMarkdownLinks: 'warn',

  favicon: 'img/favicon.ico',

  organizationName: 'dotnet comunity',
  projectName: 'Silk.NET',

  presets: [
    [
      '@docusaurus/preset-classic',
      ({

        docs: {
          sidebarPath: require.resolve('./sidebars.js'),
          showLastUpdateAuthor: true,
          showLastUpdateTime: true,
          // TOFIX update it to the right repo path
          editUrl: 'https://github.com/facebook/docusaurus/edit/main/website/',
        },

        blog: {
          showReadingTime: true,
          // Please change this to your repo.
          editUrl: 'https://github.com/facebook/docusaurus/edit/main/website/blog/',
        },

        theme: {
          customCss: require.resolve('./src/css/custom.css'),
        },

      }),
    ],
  ],

  plugins : [
    'docusaurus-plugin-sass'
  ],

  themeConfig:
    /** @type {import('@docusaurus/preset-classic').ThemeConfig} */
    ({
      navbar: {
        title: 'Silk.NET',
        logo: {
          alt: 'Silk.NET',
          src: 'img/silkdotnet_v3.svg',
        },

        items: [
          {
            label: 'Docs',
            to: '/docs/getStarted',
            position: 'left'
          },
          
          {
            label: 'Blog',
            to: '/blog',
            position: 'left'
          },

          {
            label: 'FAQ',
            to : '/',
            position: 'left'
          },

          {
            href: 'https://github.com/dotnet/Silk.NET',
            label: 'GitHub',
            position: 'right',
          },
        ],
      },
      footer: {
        style: 'light',
        links: [
          {
            title: 'Docs',
            items: [
              {
                label: 'Tutorial',
                to: '/docs/getStarted',
              },
            ],
          },
          {
            title: 'Community',
            items: [
              {
                label: 'Discord',
                href: 'https://discord.gg/DTHHXRt',
              },
            ],
          },
          {
            title: 'More',
            items: [
              {
                label: 'Blog',
                to: '/blog',
              },
              {
                label: 'GitHub',
                href: 'https://github.com/dotnet/Silk.NET',
              },
            ],
          },
        ],
        copyright: `Copyright © ${new Date().getFullYear()} .NET Foundation and Contributors. Built with Docusaurus.`,
      },
      prism: {
        theme: lightCodeTheme,
        darkTheme: darkCodeTheme,
      },
    }),
});
