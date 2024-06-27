import React from "react";
import styles from './ReadyForAnything.module.scss';


type ApiItem = {
    index : number;
    image : string;
}

export default function ReadyForAnything(): JSX.Element {

    return (
        <div>
            <h1 className={styles.title}>Ready for anything</h1>

            <div className={styles.majorContainer}>

                <div className={styles.center}>
                    <p>
                        Silk.NET provides a plethora of bindings to accommodate
                        just about any audio, video, graphics, asset management
                        and compute workload you could possibly throw at it.
                    </p>
                </div>

                <MovingApiItensElement />
                <StaticApiItensElement />

            </div>

        </div>
    );

}

// components
let ApiItens : ApiItem[] = [
    { index : 0, image : "assimp.png" },
    { index : 1, image : "dx12ultimate.png" },
    { index : 2, image : "glfw.png" },
    { index : 3, image : "openal.png" },
    { index : 4, image : "opencl.svg" },
    { index : 5, image : "opengl.jpg" },
    { index : 6, image : "opengles.png" },
    { index : 7, image : "openxr.svg" },
    { index : 8, image : "sdl.png" },
    { index : 9, image : "vulkan.svg" },
];

function MovingApiItensElement() : JSX.Element
{
    return (
        <div className={styles.movingApiItensElement}>

            {ApiItens.map((props, idx) => (
                <ApiItemElement key={idx} {...props} />
            ))}

        </div>
    );
}

function StaticApiItensElement() : JSX.Element
{

    return (
        <div className={styles.staticApiItensElement}>

            {ApiItens.map((props, idx) => (
                <ApiItemElement key={idx} {...props} />
            ))}

        </div>
    );

}

function ApiItemElement({image, index} : ApiItem)
{
    return (
        <div className={styles.apiItem}
        style={{
            animationDelay: '-' + ((10 / ApiItens.length) * index) + 's',
            backgroundImage: 'url("img/apis/' + image + '")'
        }}>
        </div>
    );
}

