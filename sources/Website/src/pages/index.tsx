import clsx from 'clsx';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import Layout from '@theme/Layout';
import HomepageFeatures from '@site/src/components/HomepageFeatures';
import Heading from '@theme/Heading';

import styles from './index.module.css';
import {Carousel} from "react-responsive-3d-carousel";
import 'react-responsive-3d-carousel/dist/styles.css';
import useBaseUrl from '@docusaurus/useBaseUrl';
import BrowserOnly from "@docusaurus/core/lib/client/exports/BrowserOnly";

function HomepageHeader() {
    const {siteConfig} = useDocusaurusContext();
    return (
        <header className={clsx('hero', styles.heroBanner)}>
            <div className={clsx('container')}>
                <div className={clsx('row', styles.heroRow)}>
                    <div className={clsx(styles.heroWords)}>
                        <Heading as="h1">
                            {siteConfig.title}
                        </Heading>

                        <p className={clsx(styles.heroSubtitle)} style={{textAlign: "initial"}}>
                            {siteConfig.tagline}
                        </p>

                        <div className={clsx(styles.heroButtons)}>
                            <Link
                                className={clsx('button button--primary button--lg', styles.silkBtn)}
                                to="/docs/">
                                Get Started
                            </Link>
                            <Link
                                className={clsx('button button--secondary button--lg', styles.silkBtn)}
                                to="https://github.com/dotnet/Silk.NET">
                                GitHub
                            </Link>
                        </div>

                        <br/>

                        <div className={clsx(styles.silkDnfText)}>
                            <span>An official</span>
                            <a href="https://dotnetfoundation.org">
                                <img
                                    src="https://raw.githubusercontent.com/dotnet-foundation/swag/main/logo/dotnetfoundation_v4_horizontal.svg"
                                    className={clsx(styles.silkDnfLogo)}/>
                            </a>
                            <span>project</span>
                        </div>
                    </div>
                    <div className={clsx(styles.heroCarousel)}>
                        <BrowserOnly>
                            {() => {
                                const items = [
                                    <span className={clsx(styles.carouselImage)}>
                                        <img src={useBaseUrl("/img/home/hedra.gif")} alt="Hedra preview"/>
                                    </span>,
                                                                <span className={clsx(styles.carouselImage)}>
                                        <img src={useBaseUrl("/img/home/platformer.gif")} alt="Platformer preview"/>
                                    </span>,
                                                                <span className={clsx(styles.carouselImage)}>
                                        <img src={useBaseUrl("/img/home/cat.gif")} alt="Cat preview"/>
                                    </span>,
                                                                <span className={clsx(styles.carouselImage)}>
                                        <img src={useBaseUrl("/img/home/cubes.gif")} alt="Cubes demo preview"/>
                                    </span>,
                                ];
                                return <Carousel
                                    items={items}
                                    startIndex={0}
                                    containerWidth={"100%"}
                                    containerHeight={"auto"}
                                    width={"80%"}
                                    height={"auto"}
                                    boxShadow={"none"}
                                    aspectRatio={1.78}
                                    showArrows={false}
                                    showStatus={false}
                                    showIndicators={false}
                                    sizeDuration={5000}
                                    defaultOption={{angleFactor: 0, depthFactor: 1, widthFactor: 1.25}}
                                    transformDuration={250}
                                />;
                            }}
                        </BrowserOnly>
                    </div>
                </div>
            </div>
        </header>
    );
}

function SupportedTechnology({icon}) {
    return (<li className={clsx(styles.supportedIcon)}>
        <img src={useBaseUrl(icon)}/>
    </li>);
}

export default function Home(): JSX.Element {
    const {siteConfig} = useDocusaurusContext();
    return (
        <Layout
            title="Silk.NET - High-Speed &amp; Advanced .NET Graphics &amp; Compute"
            description="Your one-stop-shop for high performance .NET graphics &amp; compute. A .NET Foundation project.">
            <HomepageHeader/>
            <main>
                <HomepageFeatures/>

                <section className={clsx(styles.homeContainer)}>
                    <div className={clsx(styles.technologiesSection)}>
                        <div>
                            <h1>Supported Technologies</h1>
                            <ul className={clsx(styles.supportedIcons)}>
                                <SupportedTechnology icon={"/img/home/assimp.png"}/>
                                <SupportedTechnology icon={"/img/home/dx12ultimate.png"}/>
                                <SupportedTechnology icon={"/img/home/glfw.png"}/>
                                <SupportedTechnology icon={"/img/home/openal.png"}/>
                                <SupportedTechnology icon={"/img/home/opencl.svg"}/>
                                <SupportedTechnology icon={"/img/home/opengl.jpg"}/>
                                <SupportedTechnology icon={"/img/home/opengles.png"}/>
                                <SupportedTechnology icon={"/img/home/openxr.svg"}/>
                                <SupportedTechnology icon={"/img/home/sdl.png"}/>
                                <SupportedTechnology icon={"/img/home/vulkan.svg"}/>
                            </ul>
                        </div>
                        <div>
                            <h1>Supported Targets</h1>
                            <ul className={clsx(styles.supportedIcons)}>
                                <SupportedTechnology icon={"/img/home/windows.svg"}/>
                                <SupportedTechnology icon={"/img/home/linux.svg"}/>
                                <SupportedTechnology icon={"/img/home/macos.svg"}/>
                                <SupportedTechnology icon={"/img/home/ios.svg"}/>
                                <SupportedTechnology icon={"/img/home/android.svg"}/>
                            </ul>
                        </div>
                    </div>
                </section>

                <section className={clsx(styles.homeContainer)}>
                    <h1 className={clsx(styles.centerText)}>Why choose Silk.NET?</h1>
                    <div className={clsx(styles.homeRow)}>
                        <div className={clsx('col col--6')}>
                            <h2>Backed &amp; Built to Last</h2>
                            <p>
                                We're proud to be an official project under the benevolent .NET Foundation umbrella - an
                                independent, non-profit organization established to steward the .NET ecosystem. With
                                this, our thriving community, and our efficient bindings regeneration mechanism, you can
                                count on us not disappearing tomorrow.
                            </p>
                        </div>
                        <div className={clsx('col col--6')}>
                            <h2>Open, Collaborative, and Always Evolving.</h2>
                            <p>
                                We're quick to develop and release new major versions for keeping up with changes and
                                new trends in the ecosystem, and do so with unparalleled transparency and collaboration
                                with our community. With Silk.NET being licensed under the very permissive MIT/X11
                                license, you can use it in any project - commercial or non-commercial - and get access
                                to every development on GitHub as it happens.
                            </p>
                        </div>
                    </div>
                </section>

                <section className={clsx(styles.homeContainer, styles.centerText)}>
                    <h1>Join the Conversation.</h1>
                    <div className={clsx(styles.supportedIcons)}>
                        <a href="https://discord.gg/DTHHXRt" className={clsx(styles.communityIcon)}>
                            <img src={useBaseUrl("/img/home/discord.svg")}/>
                        </a>
                        <a href="https://github.com/dotnet/Silk.NET"
                           className={clsx(styles.invertOnDark, styles.communityIcon)}>
                            <img src={useBaseUrl("/img/home/github.svg")}/>
                        </a>
                    </div>
                    <div className={clsx(styles.contactUs)}>
                        <p>
                            Join, chat, ask for help on our vibrant Discord community frequented by power users, top
                            contributors, and the library maintainers themselves. Keep up-to-date with the project's
                            latest developments on GitHub. We don't have premium support, which means that through these
                            channels you always get equal access to the best resources available.
                        </p>
                    </div>
                </section>

                <section className={clsx(styles.homeContainer)}>
                    <div className={clsx(styles.homeRow, styles.strideSection)}>
                        <div className={clsx('col col--9')} style={{alignContent: 'center'}}>
                            <h2>Not your cup of tea? Try Stride.</h2>
                            <p>
                                Silk.NET is low-level and empowers the developer with complete control over rendering.
                                Because of this, we understand Silk.NET isn't for everyone. If you fancy something more
                                high-level, give Stride a shot! Stride is a 2D & 3D game engine supported by the .NET
                                Foundation.
                            </p>
                        </div>
                        <div className={clsx('col col--3')} style={{alignContent: 'center'}}>
                            <img src={useBaseUrl("/img/home/stride.svg")}
                                 style={{
                                     filter: "invert(1)",
                                     padding: "var(--ifm-spacing-horizontal)",
                                     width: "min(15rem, 100%)"
                                 }}/>
                            <br/>
                            <Link
                                className={clsx('button button--secondary button--lg', styles.silkBtn)}
                                style={{width: '100%'}}
                                to="https://stride3d.net">
                                Learn More
                            </Link>
                        </div>
                    </div>
                </section>
            </main>
        </Layout>
    );
}
