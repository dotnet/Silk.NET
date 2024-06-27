import React, { useEffect, useState } from 'react';
import styles from './LightBalls.module.scss';


type LightBall = {
    posX : number;
    posY : number;
    size : number;
}

let Lightballs : LightBall[] = [];
function LightBallElement({posX, posY, size} : LightBall)
{
    return (
        <div
        className={styles.lightBall}
        style={{
                left: posX * 100 + "%",
                top: posY * 100 + "%",
                height: size * 130 + 80 + "px",
                width: size * 130 + 100 + "px",
                opacity: size / 4,
                animationDuration: size * 30 + 5 + "s"
            }}>
        </div>
    );
}

export default function BackgroundLighBalls(): JSX.Element
{

    Lightballs = [];
    for (let i = 0; i < 10; i++) {
        Lightballs.push(
            {
                posX : Math.random(),
                posY : Math.random(),
                size : Math.random()
            }
        )
    }

    return (

    <div id={styles.container}>
        {Lightballs.map((props, idx) => (
            <LightBallElement key={idx} {...props} />
        ))}
    </div>

    );

}