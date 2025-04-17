# dotnet.github.io/Silk.NET

We use Docusaurus to build our website, however our usage of it is a bit esoteric. Docusaurus is a React-based
static site generator, the output from which we host on GitHub Pages (i.e. no dynamic server-side code whatsoever).
Docusaurus gives us a lot of features for free (docs, versioning, blogs, etc) while also making use of the ever-familiar
frontend ecosystem that is React. Previous iterations of the website used the Statiq C#/Razor static site generator,
however this required significantly more work on the Silk.NET side to get a full site and as a result wasn't
particularly well-written or well-maintained given the developers that excel at making a great bindings library often
aren't the same people that excel at frontend - yes, the old Statiq-based codebase _was_ **worse** than what we have
now.

The website is built using the following command:

```
nuke website
```

Alternatively, one of the build scripts can be used in place of the `nuke` global tool. For more information, see the
[build system](../build-system.md) documentation.

In its simplest form, Docusaurus is used with the following details:
- The content at the `docs` URL is kept in the `docs` directory in the repository root.
- The rest of the website files are at [`sources/Website`](../../../sources/Website).
    - This includes static files (e.g. images) at [`sources/Website/static`](../../../sources/Website/static)
    - This also includes the Silk.NET blog at [`sources/Website/blog`](../../../sources/Website/blog).
      **FUTURE IMPROVEMENT**: Maybe we want to move this one day?

Generally, you should lean on the Docusaurus documentation for most of the Docusaurus configuration, we'll delve into
our extra bits on top later. But first, we should probably go over the elements of our Docusaurus config that seem
utterly bonkers when considering reference configurations for Docusaurus.

## The Theme

We did a lot of modifications to the theme to be more in line with the Microsoft .NET brand and the Silk.NET brand.
This is mostly CSS work, which can be found at [`sources/Website/src/css`](../../../sources/Website/src/css).
We also put a lot of work into the front-page, which is riddled with lots of custom React stuff at
[`sources/Website/src/pages/index.tsx`](../../../sources/Website/src/pages/index.tsx). There wasn't much appetite to
deviate further from the default than simple CSS modifications as the Silk.NET team aren't really frontend engineers and
we don't want to maintain anything fancy.

## Giscus

Like the previous Statiq-based version of the Silk.NET Website, we use Giscus to provide a comments section on pages
throughout the site. This uses GitHub Discussions (specifically the
[Webpage Comments](https://github.com/dotnet/Silk.NET/discussions/categories/webpage-comments) section) to store
discussions. Being a static site, nothing fancier we can do here really.

## Paths

The `docs` directory being in the repository root instead of being a subdirectory adjacent to `static` is a very
atypical configuration for Docusaurus, however it was a priority to make documentation viewable within GitHub as well as
on the website for maximum flexibility and ease of use. There is an assumption that the Docusaurus build command will
always run in `sources/Website`, so from a config perspective we pull the docs from `../../docs`. It is a bit strange to
have the static files so far away from the documentation content, and indeed this might be an oversight given that we
want that maximum flexibility (those URLs will only resolve in one viewing mode!), but we haven't found a good way to
reconcile those differences yet.

**FUTURE IMPROVEMENT**: Should we? Perhaps we could add a step to the NUKE job that will get all the images in the
`docs` directory and copy them to `static` implicitly?

## GitHub Admonitions

We use `remark-github-admonitions-to-directives` to convert between GitHub-viewable `> [!NOTE]` syntax and Docusaurus'
expected syntax, again for the previously stated goal of being viewable both ways. This is added as a
`beforeDefaultRemarkPlugins` and instructs Docusaurus to convert the syntaxes while it's converting the `mdx` files to
JavaScript files.

## NUKE

Now we get into the very exotic bits. In theory, you can stop reading this document here and still have a (relatively)
functional Silk.NET website. We use NUKE to have some more complicated build logic to give our website the bells and
whistles we need.

**FUTURE IMPROVEMENT**: Although there is the known issue of for some reason not being able to build the website for a
second time without purging `node_modules` and reinstalling again, which the NUKE script does.
[Here's the original conversation in Discord](https://discord.com/channels/521092042781229087/587346162802229298/1332782687638917207).

### Blog Authors

First, the NUKE script uses the GitHub GraphQL to get information about the GitHub usernames that are recorded as
authors of blog posts in Markdown front-matter. This includes names, social accounts, and public email addresses.
We do check the `authors.yml` into the repo, so you can skip this by doing `--skip-contributors-scrape`, but it's fairly
quick. Note, however, that this uses the `gh` official GitHub CLI tool to get an auth token outside of CI (i.e. `gh auth
token`), so you'll want to login to `gh` ahead-of-time. You'll also need to add some scopes given that access public
email addresses, for some reason, demands a specific scope (that apparently isn't required or is implicitly granted to
CI jobs?):

```bash
gh auth login --scopes "user:email,read:user,workflow"
```

If you have already logged into the `gh` CLI, you can ensure these scopes are added by logging in again.

### Redirects

The Statiq-based site used URLs with `.html` at the end a lot. The NUKE script adds those files back to ensure link
compatibility, and these files will just redirect to the URls without the `.html` suffix.

### Versioning

Docusaurus has built-in versioning, but it doesn't use Git. Instead, it expects all versions to be checked into the
repository in the branch the website is being built on (resulting in lots of duplication - this is not acceptable for
us!) As a result of this, we decided to forgo the standard Docusaurus versioning workflow and "emulate" it at build-time
using the NUKE workflow. This pulls on the Git repo to provide the historical versions, and makes up most of the logic
in the NUKE script.

The versioning process is as follows:
1. See if we're currently working on the next version of Silk.NET by looking for a `develop/X.0` branch. See
   [Repository Etiquette](../repository-etiquette.md) for more info.
2. Determine the version being tracked by the branch we're currently on.
3. For each major version, get the latest released version name. If there is no released version, then we try the
   [CHANGELOG](../../CHANGELOG.md). This means that the documentation website is up as soon as the branch is created,
   but once we've snapped Preview 1 the website won't claim to be docs for Preview 2 until Preview 2 is released.
4. Retrieve the documentation for each major version. If the major version is one that is still being developed (be that
   in sustaining or as a next major version), then we download the documentation from the relevant branch. If not, we
   download the documentation from the last tag of that major version. Note that we do check whether a
   `eng/submodules/silk.net-X.x` submodule exists first to avoid unnecessarily hitting the GitHub API.

   You can override the version read by this script by placing a `version.txt` file in the submodule. This is how
   Silk.NET 2.0's NUKE script works (more on that later).

   **FUTURE IMPROVEMENT**: This does mean that in theory someone could do some docs work between that tag and the next
   major version releasing, and that work being discarded once the next major version gets merged into `main`.
5. Backup the `sources/Website` and `docs` directories, as we'll be moving a lot of files back and forth from various
   versions hereafter. This backup is restored even if the script crashes (unless you Ctrl+C/kill it). Failing that, you
   still have Git! This is just backed up to a temporary directory in `.nuke`.
6. For each version, replace the `docs` directory in the checked out repository root (i.e. in which the NUKE script is
   running, not within the version we just downloaded) with that of the version we just downloaded, and copy the static
   files over as well. Note that we merge the static files from all versions as we go, newest taking precedence. Once
   we've done that, we use the `docusaurus docs:version` command for the major version (unless it's the latest/next
   major version, as this is treated as the `current` version)
7. After all that, we output the versioning data scraped from the repository to a file called `silkversions.json` in
   `sources/Website`. This is then read in by the Docusaurus config file. Note that this contains the `lastVersion` (as
   in the Docusaurus documentation - this lets us figure out whether `current` represents the _current_ release or a
   _preview_ release) and the `nextVersion`, which are used in determining the "edit this page" URLs. Note that `/docs`
   will always represent the last major version that has a non-preview release - the moment that this ceases to be true
   for `v3`, `v3` will change from `/docs/v3` to just `/docs` and `v2` will change from `/docs/` to `/docs/v2`.

   **FUTURE IMPROVEMENT**: I hate potentially breaking links. Can we figure out a faux redirect mechanism like we did
   for .html->non-.html?

After all of that, we build the site using Docusaurus. The versioning information is populated into the configuration
structure as above using the `addSilkVersionsJson` function. Note that there is a lot more hackery in the Docusaurus
config mostly because we developed a habit of having relative links to source code (as this is fairly nice from a GitHub
perspective, linking to code on the branch being currently viewed) which Docusaurus got very confused about. As such, we
have to manually reconcile these links into absolute URLs, which we once again use the versioning data for. This is far
more complicated than it should've been. This is added as a link rewriter remark plugin, processing the Markdown files
in much the same way that the GitHub Admonitions plugin does.

### Silk.NET 2.X

Silk.NET 2.X is a bit of a unique case from the perspective of this website. First, it is possibly the only time that we
will ever use a non-stable branch for the website of the stable version (given that everything outlined above should
just work when we develop past 3.0), as the repository structure is just so different in 2.X and it was deemed too
disruptive to do these changes in the main branch while also making them a good base for the 3.0 documentation (which we
want to start on _before_ we ship as per the working group approved software development plan). Second of all, a lot of
its website workflows were designed against the Statiq-based site, which was originally developed in the 2.X branch. As
such, to minimise disruption, the corresponding NUKE script in 2.X was changed to clone into the 3.0 branch and copy its
documentation directory into a `eng/submodules/silk.net-2.x` submodule (along with a `version.txt`) and build the
website using the 3.0 NUKE script. This also allows contributors to build in the 2.X branch fairly easily, with this
horrific setup being hidden away.
