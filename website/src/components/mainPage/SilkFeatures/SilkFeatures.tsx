import React from 'react';
import clsx from 'clsx';
import styles from './SilkFeatures.module.scss';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUpLong } from '@fortawesome/free-solid-svg-icons/faUpLong';
import { faRocket } from '@fortawesome/free-solid-svg-icons/faRocket';
import { faAtom } from '@fortawesome/free-solid-svg-icons/faAtom';
import { IconDefinition } from '@fortawesome/fontawesome-svg-core';

type FeatureItem = {
  color: string;
  title: string;
  icon: IconDefinition;
  description: JSX.Element;
};

const FeatureList: FeatureItem[] = [
  {
    color: '#C624FF',
    title: 'UP-TO-DATE',
    icon: faUpLong,
    description: (
      <>
        With an efficient bindings regeneration mechanism, we are committed to
        ensuring our bindings reflect the latest specifications with monthly
        updates generated straight from the upstream sources.
      </>
    ),
  },
  {
    color: '#4AFF5C',
    title: 'HIGH-LEVEL UTILITIES',
    icon: faAtom,
    description: (
      <>
        In addition to providing high-speed, direct, and transparent bindings,
        we provide high-level utilities and wrappers to maximise productivity
        in common workloads such as platform-agnostic abstractions around Windowing
        and Input, bringing your apps to a vast number of platforms without changing
        a single line!
      </>
    ),
  },
  {
    color: '#E86100',
    title: 'GOOD-TO-GO',
    icon: faRocket,
    description: (
      <>
        Silk.NET caters for anything you could need in swift development of multimedia,
        graphics, compute applications. Silk.NET is an all-in-one solution, complete
        with Graphics, Compute, Audio, Input, and Windowing.
      </>
    ),
  },
];

function Feature({color, title, icon, description}: FeatureItem) {
  return (
    <div className={clsx(styles.featureCard)}>
      
      <span className={clsx(["fa-layers", styles.featureIcon])}>
        <FontAwesomeIcon className={styles.featureIcon} icon={icon}
        style={{color: color, filter: 'blur(10px)', opacity: 0.75}} />
        <FontAwesomeIcon className={styles.featureIcon} icon={icon} style={{color: color}} />
      </span>

      <h3 style={{color: color, textShadow: '0 0 10px {color}'}}>{title}</h3>
      <p>{description}</p>

    </div>
  );
}

export default function SilkFeatures(): JSX.Element {
  return (
    <section className={styles.featuresContainer}>

      <div className="container">
        <div className={styles.featuresList}>
          {FeatureList.map((props, idx) => (
            <Feature key={idx} {...props} />
          ))}
        </div>
      </div>
      
    </section>
  );
}
