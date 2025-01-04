import clsx from 'clsx';
import Heading from '@theme/Heading';
import styles from './styles.module.css';
import useBaseUrl from '@docusaurus/useBaseUrl';

type FeatureItem = {
  title: string;
  image: string;
  description: JSX.Element;
};

const FeatureList: FeatureItem[] = [
  {
    title: 'Up-to-Date',
    image: '/img/home/beakers.png',
    description: (
      <>
          Silk.NET provides low-level bindings to many high-performance graphics &amp; compute frameworks.
          With an efficient bindings regeneration mechanism, we are committed to ensuring all our bindings reflect the
          latest specifications with monthly updates generated straight from the upstream sources.
      </>
    ),
  },
  {
    title: 'Development Made Easy',
    image: '/img/home/devices2.png',
    description: (
      <>
          In addition to providing high-speed, direct, and transparent bindings, we provide high-level utilities and
          wrappers to maximise productivity in common workloads such as platform-agnostic abstractions around Windowing
          and Input, bringing your apps to a vast number of platforms without changing a single line!
      </>
    ),
  },
  {
    title: 'Ready To Go',
    image: '/img/home/world.png',
    description: (
      <>
          Silk.NET caters for anything you could need in swift development of multimedia, graphics, compute
          applications. Silk.NET is an all-in-one solution, complete with Graphics, Compute, Audio, Input, and
          Windowing. With support for all major desktop and mobile platforms included too, you have everything you need
          to excel.
      </>
    ),
  },
];

function Feature({title, image, description}: FeatureItem) {
  return (
    <div className={clsx('col col--4')} style={{padding: "0"}}>
      <div>
        <img src={useBaseUrl(image)} className={styles.featureimg} role="img" />
      </div>
      <div className="padding-horiz--md">
        <Heading as="h3">{title}</Heading>
        <p>{description}</p>
      </div>
    </div>
  );
}

export default function HomepageFeatures(): JSX.Element {
  return (
    <section className={styles.corerow}>
      <div className="container" style={{padding: "0"}}>
        <div className="row">
          {FeatureList.map((props, idx) => (
            <Feature key={idx} {...props} />
          ))}
        </div>
      </div>
    </section>
  );
}
