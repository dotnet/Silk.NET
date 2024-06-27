import React, { useEffect, useState } from 'react';
import { CSSTransition } from 'react-transition-group';
import clsx from 'clsx';
import Layout from '@theme/Layout';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import styles from './index.module.css';
import SilkFeatures from '../components/mainPage/SilkFeatures/SilkFeatures';
import BackgroundLighBalls from '../components/mainPage/LightBalls/LightBalls';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCode } from '@fortawesome/free-solid-svg-icons/faCode';
import { faGithubAlt } from '@fortawesome/free-brands-svg-icons/faGithubAlt';
import ReadyForAnything from '../components/mainPage/ReadyForAnything/ReadyForAnything';
import AllInOneSolution from '../components/mainPage/AllInOneSolution/AllinOneSolution';
import RealiableAndDependable from '../components/mainPage/ReliableDepend/ReliableDepend';
import JoinTheConversation from '../components/mainPage/JoinConversation/joinConversation';
import TryStride from '../components/mainPage/TryStride/TryStride';


export default function Home(): JSX.Element {
  const {siteConfig} = useDocusaurusContext();
  return (

    <Layout
      title={`${siteConfig.title}`}
      description="Description will go into a meta tag in <head />">

      <HomepageHeader />

      <MicrosoftLogo />

      <main>

        <SilkFeatures />
        <ReadyForAnything />
        <AllInOneSolution />
        <RealiableAndDependable />
        <JoinTheConversation />
        <TryStride />
      
      </main>

    </Layout>

  );
}

/* Components */

function HomepageHeader() {

  const {siteConfig} = useDocusaurusContext();
  return (

    <header className={clsx('hero', styles.heroBanner)}>

      <div className={"container " + styles.container}>

        <BackgroundLighBalls />

        {/* just one of these will appear in the page, for each theme and device width */}

        <img draggable="false" className={clsx([styles.wordmark, styles.wordmarkDark, styles.wide])}
        src='/Silk.NET/img/wordmarkw.svg'></img>
        <img draggable="false" className={clsx([styles.wordmark, styles.wordmarkLight, styles.wide])}
        src='/Silk.NET/img/wordmark.svg'></img>
        <img draggable="false" className={clsx([styles.wordmark, styles.wordmarkDark, styles.thin])}
        src='/Silk.NET/img/silkdotnet_v3_w.svg'></img>
        <img draggable="false" className={clsx([styles.wordmark, styles.wordmarkLight, styles.thin])}
        src='/Silk.NET/img/silkdotnet_v3.svg'></img>

        <h1 className={styles.wordmarkLabel}>SILK.NET</h1>

        <p className={styles.subtitle}>
          {siteConfig.tagline}
        </p>

        <p className={styles.description}>
          Spruce up your applications and games with cross-platform 2D & 3D graphics,
          audio, compute and haptics.
        </p>

        <DynamicText />

        <div className={styles.buttonsHolder}>

          <Link className={styles.button} to="/docs/getStarted"
          style={{background: '#5E72E4', color: 'white'}}>
            START NOW
            <FontAwesomeIcon className={styles.buttonIcons} icon={faCode} style={{right: '-10px'}} />
          </Link>

          <Link className={styles.button} to="https://github.com/dotnet/Silk.NET">
            <FontAwesomeIcon className={styles.buttonIcons} icon={faGithubAlt} style={{left: '-10px'}} />
            COLABORATE
          </Link>

        </div>

      </div>
      
    </header>
  
  );

}
function DynamicText() {

  const options = ["FAST", "FREE", "CROSS PLATAFORM"];
  const [index, setIndex] = useState(0);

  useEffect(() => {

    const updateText = () => { setIndex( oldIndex => (oldIndex + 1) % options.length ); };

    const interval = setInterval(updateText, 3000);
    return () => clearInterval(interval);

  }, []);

  return (
    <div className={styles.dynamicText}>
      {options.map((textOption : string, i : number) => (
        <CSSTransition
          key={i}
          in={i === index}
          timeout={500}
          classNames={{
            enterActive: styles.fadeEnter,
            enterDone: styles.fadeEnterDone,
            exitActive: styles.fadeExitActive,
            exitDone: styles.fadeExit
          }}
          unmountOnExit
        >
          <p>{textOption}</p>
        </CSSTransition>
      ))}
    </div>
  );

}
function MicrosoftLogo() {
  return (
    <div className={styles.dotNetLogo}>

      <div className={styles.angledBar}></div>

      <div className={styles.content}>
        <p>SUPPORTED BY</p>
        <img src='/Silk.NET/img/dotnetfoundation.png'></img>
      </div>

    </div>
  );
}