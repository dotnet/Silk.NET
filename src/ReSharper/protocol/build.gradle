plugins {
    id 'java'
    id 'org.jetbrains.kotlin.jvm'
}

dependencies {
    implementation "org.jetbrains.kotlin:kotlin-stdlib"
    implementation name: "rd-gen"
    implementation name: "rider-model"
}

repositories {
    mavenCentral()
    flatDir {
        dirs rdLibDirectory().absolutePath
    }
}